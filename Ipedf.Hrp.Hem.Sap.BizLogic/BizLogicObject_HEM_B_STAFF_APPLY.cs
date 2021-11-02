using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ipedf.Hrp.Hem.Sap.Entity;
using Ipedf.Hrp.Hem.Sap.DataAccess;
using Ipedf.Hrp.Hem.Sap.ServiceContract;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;

namespace Ipedf.Hrp.Hem.Sap.BizLogic
{
    public class BizLogicObject_HEM_B_STAFF_APPLY : BizLogicBase<EntityObject_HEM_B_STAFF_APPLY>, ServiceContract_HEM_B_STAFF_APPLY
    {
        public BizLogicObject_HEM_B_STAFF_APPLY() { }

        private static ServiceContract_HEM_B_STAFF_APPLY singleton;
        public static ServiceContract_HEM_B_STAFF_APPLY Proxy
        {
            get
            {
                if (singleton == null) singleton = new BizLogicObject_HEM_B_STAFF_APPLY();
                return singleton;
            }
        }

        public BizLogicMsg Recruit_Apply(EntityObject_HEM_B_STAFF_APPLY obj, EntityObject_V_USER_LOGIN_INFO ULI, decimal IS_NURSE)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        DisplayObject_V_HEM_B_STAFF[] itemVStaffAll = BizLogicObject_V_HEM_B_STAFF.Proxy.Query(new CauseObject_V_HEM_B_STAFF() { USER_ID = ULI.USER_ID });
                        if (itemVStaffAll.Length > 0)
                        {
                            CauseObject_HEM_B_STAFF_APPLY causeStaffApply = new CauseObject_HEM_B_STAFF_APPLY();
                            foreach (DisplayObject_V_HEM_B_STAFF st in itemVStaffAll)
                            {
                                causeStaffApply.SetINValue("STAFF_TYPE_ID", st.STAFF_TYPE_ID);
                            }
                            causeStaffApply.SetCustomCondition(" AND HEM_B_STAFF_APPLY.STATUS IN(0,1,2,4,5)");
                            //AND (HEM_B_STAFF_APPLY.STATUS IN(4,5) OR (HEM_B_STAFF_APPLY.STATUS IN(0,1,2) AND NOT EXISTS(SELECT P.ID FROM HEM_B_RECRUIT_POSTER P WHERE 
                            //P.ID = HEM_B_STAFF_APPLY.POSTER_ID AND P.END_DATE < to_date(to_char(sysdate,'yyyy-MM-dd'),'yyyy-MM-dd'))))
                            //当前人员所有的申请记录是否有非拒绝
                            EntityObject_HEM_B_STAFF_APPLY[] itemStaffApply = HelperObject_HEM_B_STAFF_APPLY.Query(causeStaffApply, transaction);
                            if (itemStaffApply.Length == 0)
                            {
                                //当前人员有IS_NURSE的简历
                                DisplayObject_V_HEM_B_STAFF[] itemVStaff = itemVStaffAll.Where(p => p.IS_NURSE == IS_NURSE).ToArray();
                                if (itemVStaff.Length > 0)
                                {
                                    string StaffID = itemVStaff[0].ID;
                                    string StaffTypeID = itemVStaff[0].STAFF_TYPE_ID;
                                    string TypeID = itemVStaff[0].TYPE_ID;
                                    string StaffFile = itemVStaff[0].FILE_PATH;
                                    bool IS_STAFF_TYPE = false;
                                    CauseObject_HEM_B_STAFF_EDUCATION causeStaffEducation = new CauseObject_HEM_B_STAFF_EDUCATION();
                                    causeStaffEducation.STAFF_ID = StaffID;
                                    DisplayObject_HEM_B_STAFF_EDUCATION[] itemStaffEducation = HelperObject_HEM_B_STAFF_EDUCATION.Query(causeStaffEducation, transaction);
                                    if (string.IsNullOrEmpty(StaffFile))
                                    {
                                        SaveN(obj, ULI, transaction);
                                        transaction.Commit();
                                        msg.Succeed = false;
                                        msg.Message = "NoFile";
                                    }
                                    else if (itemStaffEducation.Length > 0)
                                    {
                                        itemStaffEducation = itemStaffEducation.Where(p=>p.SLART =="23").ToArray();
                                        if (itemStaffEducation.Length > 0)
                                        {
                                            if (TypeID == "1003")
                                            {
                                                CauseObject_HEM_B_STAFF_WORK causeStaffWork = new CauseObject_HEM_B_STAFF_WORK();
                                                causeStaffWork.STAFF_ID = StaffID;
                                                DisplayObject_HEM_B_STAFF_WORK[] StaffWorkItem = HelperObject_HEM_B_STAFF_WORK.Query(causeStaffWork);
                                                //往届生必须填写工作经历
                                                if (StaffWorkItem.Length > 0)
                                                {
                                                    IS_STAFF_TYPE = true;
                                                }
                                            }
                                            else
                                            {
                                                IS_STAFF_TYPE = true;
                                            }

                                            if (IS_STAFF_TYPE)
                                            {
                                                causeStaffApply = new CauseObject_HEM_B_STAFF_APPLY();
                                                causeStaffApply.POSTER_ID = obj.POSTER_ID;
                                                causeStaffApply.STAFF_TYPE_ID = StaffTypeID;
                                                //当前人员的简历是否投过该招娉广告
                                                itemStaffApply = HelperObject_HEM_B_STAFF_APPLY.Query(causeStaffApply, transaction);
                                                if (itemStaffApply.Length == 0)
                                                {
                                                    obj.STAFF_TYPE_ID = StaffTypeID;
                                                    int amount = 0;
                                                    #region 不需要
                                                    //foreach (DisplayObject_HEM_B_STAFF_TYPE st in itemTemplate)
                                                    //{
                                                    //    amount = HelperObject_HEM_B_STAFF_APPLY.MyUpdate(st.ID, (decimal)APPLY_STATUS.已拒绝, transaction);
                                                    //}

                                                    //foreach (EntityObject_HEM_B_STAFF_TYPE objTemplate in itemTemplate)
                                                    //{
                                                    //    if (objTemplate.ID == obj.STAFF_TYPE_ID)
                                                    //    {
                                                    //        objTemplate.IS_ACTION = 1;
                                                    //    }
                                                    //    else
                                                    //    {
                                                    //        objTemplate.IS_ACTION = 2;
                                                    //    }
                                                    //    objTemplate.SetUpdate("IS_ACTION");
                                                    //    amount = HelperObject_HEM_B_STAFF_TYPE.Update(objTemplate, transaction);
                                                    //}
                                                    #endregion
                                                    amount = HelperObject_HEM_B_STAFF_APPLY.Save(obj, transaction);
                                                    if (amount > 0)
                                                    {
                                                        CauseObject_HEM_B_STAFF_APPLY_N cause = new CauseObject_HEM_B_STAFF_APPLY_N();
                                                        cause.USER_ID = ULI.USER_ID;
                                                        DisplayObject_HEM_B_STAFF_APPLY_N[] dispalyN = HelperObject_HEM_B_STAFF_APPLY_N.Query(cause, transaction);
                                                        if (dispalyN.Length > 0)
                                                        {
                                                            amount = HelperObject_HEM_B_STAFF_APPLY_N.Delete(cause, transaction);
                                                            if (amount == 0)
                                                            {
                                                                throw new Exception("申请失败,如有问题请联系管理员!!");
                                                            }
                                                        }
                                                        transaction.Commit();
                                                    }
                                                    else
                                                    {
                                                        throw new Exception("申请失败,如有问题请联系管理员!!");
                                                    }

                                                }
                                                else
                                                {
                                                    msg.Succeed = false;
                                                    msg.Message = "您已申请过该职位，不能再次申请了!";
                                                }
                                            }
                                            else
                                            {
                                                SaveN(obj, ULI, transaction);
                                                transaction.Commit();
                                                msg.Succeed = false;
                                                msg.Message = "NoWork";
                                            }
                                        }
                                        else
                                        {
                                            SaveN(obj, ULI, transaction);
                                            transaction.Commit();
                                            msg.Succeed = false;
                                            msg.Message = "NoEducation1";
                                        }

                                    }
                                    else
                                    {
                                        SaveN(obj, ULI, transaction);
                                        transaction.Commit();
                                        msg.Succeed = false;
                                        msg.Message = "NoEducation";
                                    }
                                }
                                else
                                {
                                    SaveN(obj, ULI, transaction);
                                    transaction.Commit();
                                    msg.Succeed = false;
                                    msg.Message = "NoStaff3";
                                }
                            }
                            else
                            {
                                msg.Succeed = false;
                                msg.Message = "您已申请过职位，请耐心等待审批!";
                            }
                        }
                        else
                        {
                            SaveN(obj, ULI, transaction);
                            transaction.Commit();

                            msg.Succeed = false;
                            msg.Message = "NoStaff";
                        }
                    }
                    catch (Exception expt)
                    {
                        transaction.Rollback();
                        msg = new BizLogicMsg(false, expt.Message);
                        Error(expt);
                    }
                    finally
                    {
                        IDALProvider.IDAL.PushConnection(connection);
                    }
                }
            }
            return msg;
        }

        private void SaveN(EntityObject_HEM_B_STAFF_APPLY obj, EntityObject_V_USER_LOGIN_INFO ULI, IDbTransaction transaction)
        {
            int nCount = 1;
            CauseObject_HEM_B_STAFF_APPLY_N cause = new CauseObject_HEM_B_STAFF_APPLY_N();
            cause.USER_ID = ULI.USER_ID;
            DisplayObject_HEM_B_STAFF_APPLY_N[] dispalyN = HelperObject_HEM_B_STAFF_APPLY_N.Query(cause, transaction);
            if (dispalyN.Length > 0)
            {
                nCount = HelperObject_HEM_B_STAFF_APPLY_N.Delete(cause, transaction);
            }

            if (nCount > 0)
            {
                EntityObject_HEM_B_STAFF_APPLY_N entityN = new EntityObject_HEM_B_STAFF_APPLY_N();
                entityN.POSTER_ID = obj.POSTER_ID;
                entityN.STATUS = 2;
                entityN.USER_ID = ULI.USER_ID;
                HelperObject_HEM_B_STAFF_APPLY_N.Save(entityN, transaction);
            }
        }

        public BizLogicMsg Save(EntityObject_HEM_B_STAFF_APPLY obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_STAFF_APPLY.Save(obj, transaction);
                        transaction.Commit();
                    }
                    catch (Exception expt)
                    {
                        transaction.Rollback();
                        msg = new BizLogicMsg(false, expt.Message);
                        Error(expt);
                    }
                    finally
                    {
                        IDALProvider.IDAL.PushConnection(connection);
                    }
                }
            }
            return msg;
        }

        public BizLogicMsg Update(CauseObject_V_HEM_B_STAFF_APPLY cause,decimal STATUS)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        DisplayObject_V_HEM_B_STAFF_APPLY[] itemStaffApply = BizLogicObject_V_HEM_B_STAFF_APPLY.Proxy.Query(cause);
                        if (itemStaffApply.Length > 0)
                        {
                            foreach (DisplayObject_V_HEM_B_STAFF_APPLY StaffApply in itemStaffApply)
                            {
                                EntityObject_HEM_B_STAFF_APPLY entity = new EntityObject_HEM_B_STAFF_APPLY();
                                entity.ID = StaffApply.ID;
                                entity.STATUS = STATUS;
                                entity.SetUpdate("STATUS");
                                int amount = HelperObject_HEM_B_STAFF_APPLY.Update(entity, transaction);
                            }
                        }
                        transaction.Commit();
                    }
                    catch (Exception expt)
                    {
                        transaction.Rollback();
                        msg = new BizLogicMsg(false, expt.Message);
                        Error(expt);
                    }
                    finally
                    {
                        IDALProvider.IDAL.PushConnection(connection);
                    }
                }
            }
            return msg;
        }

        public BizLogicMsg Update(EntityObject_HEM_B_STAFF_APPLY obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_STAFF_APPLY.Update(obj, transaction);
                        transaction.Commit();
                    }
                    catch (Exception expt)
                    {
                        transaction.Rollback();
                        msg = new BizLogicMsg(false, expt.Message);
                        Error(expt);
                    }
                    finally
                    {
                        IDALProvider.IDAL.PushConnection(connection);
                    }
                }
            }
            return msg;
        }

        public BizLogicMsg UpdateState(EntityObject_HEM_B_STAFF_APPLY obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        string strMsg = "";
                        if (obj.STATUS != (decimal)APPLY_STATUS.已拒绝)
                        {
                            int amount = Update(obj, transaction, out strMsg);
                            //if (!string.IsNullOrEmpty(strMsg))
                            //{
                            //    msg.Succeed = false;
                            //}
                        }
                        else
                        {
                            int amount = HelperObject_HEM_B_STAFF_APPLY.Update(obj, transaction);
                        }
                        msg.Message = strMsg;

                        if (string.IsNullOrEmpty(strMsg))
                        {
                            transaction.Commit();
                        }
                    }
                    catch (Exception expt)
                    {
                        transaction.Rollback();
                        msg = new BizLogicMsg(false, expt.Message);
                        Error(expt);
                    }
                    finally
                    {
                        IDALProvider.IDAL.PushConnection(connection);
                    }
                }
            }
            return msg;
        }

        public int Update(EntityObject_HEM_B_STAFF_APPLY obj, IDbTransaction transaction, out string msg)
        {
            int amount = 0;
            CauseObject_HEM_B_STAFF_APPLY cause = new CauseObject_HEM_B_STAFF_APPLY();
            cause.SetCustomCondition(" AND HEM_B_STAFF_APPLY.ID <> '" + obj.ID + "' AND HEM_B_STAFF_APPLY.STATUS IN(1,2,4,5) AND HEM_B_STAFF_APPLY.STAFF_TYPE_ID IN(SELECT ID FROM HEM_B_STAFF_TYPE WHERE STAFF_ID =(SELECT STAFF_ID FROM HEM_B_STAFF_TYPE WHERE ID = '" + obj.STAFF_TYPE_ID + "'))");
            DisplayObject_HEM_B_STAFF_APPLY[] item = HelperObject_HEM_B_STAFF_APPLY.Query(cause);
            msg = "";
            if (item.Length == 0 || obj.STATUS == (decimal)APPLY_STATUS.已拒绝)
            {
                amount = HelperObject_HEM_B_STAFF_APPLY.Update(obj, transaction);
            }
            else
            {
                DisplayObject_V_HEM_B_STAFF_APPLY[] itemDisplay = BizLogicObject_V_HEM_B_STAFF_APPLY.Proxy.Query(new CauseObject_V_HEM_B_STAFF_APPLY() { ID = item[0].ID });
                if (itemDisplay.Length > 0)
                {
                    DisplayObject_V_HEM_B_STAFF_APPLY display = itemDisplay[0];
                    if (display != null && !string.IsNullOrEmpty(display.NACHN))
                    {
                        msg = "[" + display.NACHN.Trim() + ":" + display.TYPE_NAME + "]";
                    }
                }
            }
            return amount;
        }

        public string UpdateMessage(EntityObject_HEM_B_STAFF_APPLY[] ItmeObj)
        {
            string strMsg = "";
            return strMsg;
        }

        public BizLogicMsg Update(EntityObject_HEM_B_STAFF_APPLY[] itemObj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        string strMsg = "";
                        ArrayList list = new ArrayList();
                        foreach (EntityObject_HEM_B_STAFF_APPLY obj in itemObj)
                        {
                            int amount = Update(obj, transaction, out strMsg);
                            if (amount == 0 && !list.Contains(strMsg))
                            {
                                list.Add(strMsg);
                            }
                        }
                        if (list.Count > 0)
                        {
                            msg.Message = string.Join(",", list.ToArray(typeof(string)) as string[]);
                        }
                        transaction.Commit();
                    }
                    catch (Exception expt)
                    {
                        transaction.Rollback();
                        msg = new BizLogicMsg(false, expt.Message);
                        Error(expt);
                    }
                    finally
                    {
                        IDALProvider.IDAL.PushConnection(connection);
                    }
                }
            }

            return msg;
        }

        public DisplayObject_HEM_B_STAFF_APPLY[] Query(CauseObject_HEM_B_STAFF_APPLY cause, PagingParamter paging, OrderByParameter order)
        {
            return HelperObject_HEM_B_STAFF_APPLY.Query(cause, paging, order);
        }

        public DisplayObject_HEM_B_STAFF_APPLY[] Query(CauseObject_HEM_B_STAFF_APPLY cause)
        {
            return HelperObject_HEM_B_STAFF_APPLY.Query(cause);
        }

        public EntityObject_HEM_B_STAFF_APPLY Get(EntityObject_HEM_B_STAFF_APPLY entity)
        {
            return HelperObject_HEM_B_STAFF_APPLY.Get(entity);
        }

        public BizLogicMsg Delete(EntityObject_HEM_B_STAFF_APPLY obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_STAFF_APPLY.Delete(obj, transaction);
                        transaction.Commit();
                    }
                    catch (Exception expt)
                    {
                        transaction.Rollback();
                        msg = new BizLogicMsg(false, expt.Message);
                        Error(expt);
                    }
                    finally
                    {
                        IDALProvider.IDAL.PushConnection(connection);
                    }
                }
            }
            return msg;
        }

        public BizLogicMsg Delete(EntityObject_HEM_B_STAFF_APPLY[] itemObj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        foreach (EntityObject_HEM_B_STAFF_APPLY obj in itemObj)
                        {
                            int amount = HelperObject_HEM_B_STAFF_APPLY.Delete(obj, transaction);
                        }

                        transaction.Commit();
                    }
                    catch (Exception expt)
                    {
                        transaction.Rollback();
                        msg = new BizLogicMsg(false, expt.Message);
                        Error(expt);
                    }
                    finally
                    {
                        IDALProvider.IDAL.PushConnection(connection);
                    }
                }
            }
            return msg;
        }
    }
}
