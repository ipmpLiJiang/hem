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
    public class BizLogicObject_HEM_B_STAFF : BizLogicBase<EntityObject_HEM_B_STAFF>, ServiceContract_HEM_B_STAFF
    {
        public BizLogicObject_HEM_B_STAFF() { }

        private static ServiceContract_HEM_B_STAFF singleton;
        public static ServiceContract_HEM_B_STAFF Proxy
        {
            get
            {
                if (singleton == null) singleton = new BizLogicObject_HEM_B_STAFF();
                return singleton;
            }
        }

        public BizLogicMsg Save(EntityObject_HEM_B_STAFF obj, EntityObject_HEM_B_STAFF_TYPE objNurse)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_STAFF.Save(obj, transaction);
                        if (amount > 0)
                        {
                            objNurse.STAFF_ID = obj.ID;
                            amount = HelperObject_HEM_B_STAFF_TYPE.Save(objNurse, transaction);
                            if (amount > 0)
                            {
                                //CauseObject_V_HEM_B_STAFF_APPLY_N cause = new CauseObject_V_HEM_B_STAFF_APPLY_N();
                                //cause.USER_ID = obj.USER_ID;
                                //cause.IS_NURSE = objNurse.IS_NURSE;
                                //DisplayObject_V_HEM_B_STAFF_APPLY_N[] itemDisplay = HelperObject_V_HEM_B_STAFF_APPLY_N.Query(cause, transaction);

                                //if (itemDisplay.Length > 0)
                                //{
                                //    EntityObject_HEM_B_STAFF_APPLY entitySa = new EntityObject_HEM_B_STAFF_APPLY();
                                //    entitySa.STATUS = (decimal)APPLY_STATUS.未处理;
                                //    entitySa.POSTER_ID = itemDisplay[0].POSTER_ID;
                                //    entitySa.STAFF_TYPE_ID = objNurse.ID;
                                //    entitySa.CREATE_DATE = DateTime.Now;
                                //    amount = HelperObject_HEM_B_STAFF_APPLY.Save(entitySa, transaction);
                                //    if (amount > 0)
                                //    {
                                //        CauseObject_HEM_B_STAFF_APPLY_N causeStaffApplyN = new CauseObject_HEM_B_STAFF_APPLY_N();
                                //        causeStaffApplyN.USER_ID = obj.USER_ID;
                                //        DisplayObject_HEM_B_STAFF_APPLY_N[] dispalyN = HelperObject_HEM_B_STAFF_APPLY_N.Query(causeStaffApplyN, transaction);
                                //        if (dispalyN.Length > 0)
                                //        {
                                //            amount = HelperObject_HEM_B_STAFF_APPLY_N.Delete(causeStaffApplyN, transaction);
                                //            if (amount == 0)
                                //            {
                                //                throw new Exception("保存失败,如有问题请联系管理员!!");
                                //            }
                                //        }
                                //    }
                                //}

                                transaction.Commit();
                            }
                            else
                            {
                                throw new Exception("人员简历新增失败!");
                            }
                        }
                        else
                        {
                            throw new Exception("人员简历新增失败!");
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

        public BizLogicMsg Save(EntityObject_HEM_B_STAFF obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_STAFF.Save(obj, transaction);
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

        //public BizLogicMsg Update(EntityObject_HEM_B_STAFF obj, EntityObject_HEM_B_STAFF_TYPE entityNurse)
        //{
        //    BizLogicMsg msg = new BizLogicMsg();
        //    using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
        //    {
        //        using (IDbTransaction transaction = connection.BeginTransaction())
        //        {
        //            try
        //            {      
        //                int amount = HelperObject_HEM_B_STAFF.Update(obj, transaction);
        //                if (!string.IsNullOrEmpty(entityNurse.ID))
        //                {
        //                    entityNurse.SetUpdate("TYPE_ID");
        //                    amount = HelperObject_HEM_B_STAFF_TYPE.Update(entityNurse, transaction);
        //                }
        //                else
        //                {
        //                    amount = HelperObject_HEM_B_STAFF_TYPE.Save(entityNurse, transaction);
        //                }                        
        //                transaction.Commit();
        //            }
        //            catch (Exception expt)
        //            {
        //                transaction.Rollback();
        //                msg = new BizLogicMsg(false, expt.Message);
        //                Error(expt);
        //            }
        //            finally
        //            {
        //                IDALProvider.IDAL.PushConnection(connection);
        //            }
        //        }
        //    }
        //    return msg;
        //}


        public BizLogicMsg Update(EntityObject_HEM_B_STAFF obj, EntityObject_HEM_B_STAFF_TYPE entityNurse)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_STAFF.Update(obj, transaction);
                        int nCount = 0;
                        if (amount > 0)
                        {
                            if (!string.IsNullOrEmpty(entityNurse.ID))
                            {
                                entityNurse.SetUpdate("TYPE_ID", "IS_CERTIFICATE", "PRACTICE_TYPE_ID");
                                amount = HelperObject_HEM_B_STAFF_TYPE.Update(entityNurse, transaction);
                            }
                            else
                            {
                                amount = HelperObject_HEM_B_STAFF_TYPE.Save(entityNurse, transaction);
                            }

                            if (amount > 0)
                            {
                                //CauseObject_V_HEM_B_STAFF_APPLY_N cause = new CauseObject_V_HEM_B_STAFF_APPLY_N();
                                //cause.USER_ID = obj.USER_ID;
                                //DisplayObject_V_HEM_B_STAFF_APPLY_N[] itemDisplayAll = HelperObject_V_HEM_B_STAFF_APPLY_N.Query(cause, transaction);

                                //bool Is_Del = false;
                                //DisplayObject_V_HEM_B_STAFF_APPLY_N[] itemDisplay = itemDisplayAll.Where(d => d.IS_NURSE == entityNurse.IS_NURSE).ToArray();
                                //if (itemDisplay.Length > 0)
                                //{
                                //    DisplayObject_V_HEM_B_STAFF_APPLY_N displayStaffApply0 = itemDisplay[0];
                                //    displayStaffApply0.END_DATE = displayStaffApply0.END_DATE.AddDays(1);

                                //    if (displayStaffApply0.POSTER_STATUS != (decimal)POSTER_STATUS.已过期 && displayStaffApply0.END_DATE > DateTime.Now)
                                //    {
                                //        if (displayStaffApply0.EDUCATION_COUNT > 0)
                                //        {
                                //            CauseObject_V_HEM_B_STAFF_APPLY_ALL causeStaffApplyAll = new CauseObject_V_HEM_B_STAFF_APPLY_ALL();
                                //            causeStaffApplyAll.STAFF_ID = obj.ID;
                                //            DisplayObject_V_HEM_B_STAFF_APPLY_ALL[] itemStaffApplyAll = HelperObject_V_HEM_B_STAFF_APPLY_ALL.Query(causeStaffApplyAll, transaction);
                                //            nCount = itemStaffApplyAll.Where(o => o.STATUS != 3).Count();
                                //            if (nCount == 0)
                                //            {
                                //                nCount = itemStaffApplyAll.Where(p => p.POSTER_ID == displayStaffApply0.POSTER_ID).Count();
                                //                if (nCount == 0)
                                //                {
                                //                    EntityObject_HEM_B_STAFF_APPLY entitySa = new EntityObject_HEM_B_STAFF_APPLY();
                                //                    entitySa.STATUS = (decimal)APPLY_STATUS.未处理;
                                //                    entitySa.POSTER_ID = displayStaffApply0.POSTER_ID;
                                //                    entitySa.STAFF_TYPE_ID = entityNurse.ID;
                                //                    entitySa.CREATE_DATE = DateTime.Now;
                                //                    amount = HelperObject_HEM_B_STAFF_APPLY.Save(entitySa, transaction);
                                //                    if (amount > 0)
                                //                    {
                                //                        Is_Del = true;
                                //                    }
                                //                }
                                //                else
                                //                {
                                //                    Is_Del = true;
                                //                }
                                //            }
                                //            else
                                //            {
                                //                Is_Del = true;
                                //            }
                                //        }
                                //    }
                                //    else
                                //    {
                                //        Is_Del = true;
                                //    }
                                //}
                                //else
                                //{
                                //    if (itemDisplayAll.Length > 0)
                                //    {
                                //        CauseObject_V_HEM_B_STAFF_APPLY_ALL causeStaffApplyAll = new CauseObject_V_HEM_B_STAFF_APPLY_ALL();
                                //        causeStaffApplyAll.STAFF_ID = obj.ID;
                                //        DisplayObject_V_HEM_B_STAFF_APPLY_ALL[] itemStaffApplyAll = HelperObject_V_HEM_B_STAFF_APPLY_ALL.Query(causeStaffApplyAll, transaction);
                                //        nCount = itemStaffApplyAll.Where(o => o.STATUS != 3).Count();
                                //        if (nCount > 0)
                                //        {
                                //            Is_Del = true;
                                //        }
                                //    }
                                //}

                                //if (Is_Del)
                                //{
                                //    if (!string.IsNullOrEmpty(obj.USER_ID))
                                //    {
                                //        CauseObject_HEM_B_STAFF_APPLY_N causeStaffApplyN = new CauseObject_HEM_B_STAFF_APPLY_N();
                                //        causeStaffApplyN.USER_ID = obj.USER_ID;
                                //        DisplayObject_HEM_B_STAFF_APPLY_N[] dispalyN = HelperObject_HEM_B_STAFF_APPLY_N.Query(causeStaffApplyN, transaction);
                                //        if (dispalyN.Length > 0)
                                //        {
                                //            amount = HelperObject_HEM_B_STAFF_APPLY_N.Delete(causeStaffApplyN, transaction);
                                //            if (amount == 0)
                                //            {
                                //                throw new Exception("修改人员简历失败!");
                                //            }
                                //        }
                                //    }
                                //}

                                transaction.Commit();
                            }
                            else
                            {
                                throw new Exception("修改人员简历失败!");
                            }
                        }
                        else
                        {
                            throw new Exception("修改人员简历失败!");
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

        public BizLogicMsg Update(EntityObject_HEM_B_STAFF obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_STAFF.Update(obj, transaction);
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

        public BizLogicMsg Update(EntityObject_HEM_B_STAFF[] itemObj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        foreach (EntityObject_HEM_B_STAFF obj in itemObj)
                        {
                            int amount = HelperObject_HEM_B_STAFF.Update(obj, transaction);
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

        public DisplayObject_HEM_B_STAFF[] Query(CauseObject_HEM_B_STAFF cause, PagingParamter paging, OrderByParameter order)
        {
            return HelperObject_HEM_B_STAFF.Query(cause, paging, order);
        }

        public DisplayObject_HEM_B_STAFF[] Query(CauseObject_HEM_B_STAFF cause)
        {
            return HelperObject_HEM_B_STAFF.Query(cause);
        }

        public EntityObject_HEM_B_STAFF Get(EntityObject_HEM_B_STAFF entity)
        {
            return HelperObject_HEM_B_STAFF.Get(entity);
        }

        public BizLogicMsg Delete(EntityObject_HEM_B_STAFF obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_STAFF.Delete(obj, transaction);
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

        public BizLogicMsg Delete(EntityObject_HEM_B_STAFF[] itemObj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        foreach (EntityObject_HEM_B_STAFF obj in itemObj)
                        {
                            int amount = HelperObject_HEM_B_STAFF.Delete(obj, transaction);
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

        public DataTable GetHem_Staff_Gather(string staff_type_ids)
        {
            DataTable dt = new DataTable();
            string retMsg = string.Empty;
            int retSucceed = 0;
            try
            {
                dt = HelperObject_HEM_B_STAFF.GetHem_Staff_Gather(staff_type_ids, out retSucceed, out retMsg);
            }
            catch (Exception expt)
            {
                Error(expt);
            }
            return dt;
        }

        public HEM_B_STAFF_HEADER[] GetHem_Header_Gather()
        {
            HEM_B_STAFF_HEADER[] itemHeader = null;
            try
            {
                itemHeader = HelperObject_HEM_B_STAFF.GetHem_Header_Gather();
            }
            catch (Exception expt)
            {
                Error(expt);
            }
            if (itemHeader == null)
            {
                itemHeader = new HEM_B_STAFF_HEADER[0];
            }
            return itemHeader;
        }


        public DataTable GetHem_Staff_Nyn_Gather(string staff_type_ids)
        {
            DataTable dt = new DataTable();
            string retMsg = string.Empty;
            int retSucceed = 0;
            try
            {
                dt = HelperObject_HEM_B_STAFF.GetHem_Staff_Nyn_Gather(staff_type_ids, out retSucceed, out retMsg);
            }
            catch (Exception expt)
            {
                Error(expt);
            }
            return dt;
        }

        public HEM_B_STAFF_HEADER[] GetHem_Nyn_Header_Gather()
        {
            HEM_B_STAFF_HEADER[] itemHeader = null;
            try
            {
                itemHeader = HelperObject_HEM_B_STAFF.GetHem_Nyn_Header_Gather();
            }
            catch (Exception expt)
            {
                Error(expt);
            }
            if (itemHeader == null)
            {
                itemHeader = new HEM_B_STAFF_HEADER[0];
            }
            return itemHeader;
        }

        public DataTable GetHem_Staff_Nyw_Gather(string staff_type_ids)
        {
            DataTable dt = new DataTable();
            string retMsg = string.Empty;
            int retSucceed = 0;
            try
            {
                dt = HelperObject_HEM_B_STAFF.GetHem_Staff_Nyw_Gather(staff_type_ids, out retSucceed, out retMsg);
            }
            catch (Exception expt)
            {
                Error(expt);
            }
            return dt;
        }

        public HEM_B_STAFF_HEADER[] GetHem_Nyw_Header_Gather()
        {
            HEM_B_STAFF_HEADER[] itemHeader = null;
            try
            {
                itemHeader = HelperObject_HEM_B_STAFF.GetHem_Nyw_Header_Gather();
            }
            catch (Exception expt)
            {
                Error(expt);
            }
            if (itemHeader == null)
            {
                itemHeader = new HEM_B_STAFF_HEADER[0];
            }
            return itemHeader;
        }

        public DataTable GetHem_Staff_Nwj_Gather(string staff_type_ids)
        {
            DataTable dt = new DataTable();
            string retMsg = string.Empty;
            int retSucceed = 0;
            try
            {
                dt = HelperObject_HEM_B_STAFF.GetHem_Staff_Nwj_Gather(staff_type_ids, out retSucceed, out retMsg);
            }
            catch (Exception expt)
            {
                Error(expt);
            }
            return dt;
        }

        public HEM_B_STAFF_HEADER[] GetHem_Nwj_Header_Gather()
        {
            HEM_B_STAFF_HEADER[] itemHeader = null;
            try
            {
                itemHeader = HelperObject_HEM_B_STAFF.GetHem_Nwj_Header_Gather();
            }
            catch (Exception expt)
            {
                Error(expt);
            }
            if (itemHeader == null)
            {
                itemHeader = new HEM_B_STAFF_HEADER[0];
            }
            return itemHeader;
        }

        public DataTable GetHem_Staff_Nyj_Gather(string staff_type_ids)
        {
            DataTable dt = new DataTable();
            string retMsg = string.Empty;
            int retSucceed = 0;
            try
            {
                dt = HelperObject_HEM_B_STAFF.GetHem_Staff_Nyj_Gather(staff_type_ids, out retSucceed, out retMsg);
            }
            catch (Exception expt)
            {
                Error(expt);
            }
            return dt;
        }

        public HEM_B_STAFF_HEADER[] GetHem_Nyj_Header_Gather()
        {
            HEM_B_STAFF_HEADER[] itemHeader = null;
            try
            {
                itemHeader = HelperObject_HEM_B_STAFF.GetHem_Nyj_Header_Gather();
            }
            catch (Exception expt)
            {
                Error(expt);
            }
            if (itemHeader == null)
            {
                itemHeader = new HEM_B_STAFF_HEADER[0];
            }
            return itemHeader;
        }

        public BizLogicMsg StaffSubmitOrCheck(string UserID, decimal IsNurse)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        CauseObject_V_HEM_B_STAFF causeVStaff = new CauseObject_V_HEM_B_STAFF();
                        causeVStaff.USER_ID = UserID;
                        causeVStaff.IS_NURSE = IsNurse;
                        DisplayObject_V_HEM_B_STAFF[] vStaffitem = HelperObject_V_HEM_B_STAFF.Query(causeVStaff);
                        //判断是否有简历信息
                        if (vStaffitem.Length > 0)
                        {
                            string staffID = vStaffitem[0].ID;
                            string typeID = vStaffitem[0].TYPE_ID;
                            int amount = 0;
                            bool Is_Del = false;
                            bool IsSubmit = false;
                            int nCount = 0;
                            CauseObject_HEM_B_STAFF_EDUCATION causeStaffEducation = new CauseObject_HEM_B_STAFF_EDUCATION();
                            causeStaffEducation.STAFF_ID = staffID;
                            DisplayObject_HEM_B_STAFF_EDUCATION[] StaffEducationItem = HelperObject_HEM_B_STAFF_EDUCATION.Query(causeStaffEducation);
                            if (string.IsNullOrEmpty(vStaffitem[0].FILE_PATH))
                            {
                                throw new Exception("请先上传简历文件!");
                            }
                            //判断是否有学历信息
                            if (StaffEducationItem.Length > 0)
                            {
                                StaffEducationItem = StaffEducationItem.Where(p => p.SLART == "23").ToArray();
                                //判断是否有高中学历信息
                                if (StaffEducationItem.Length > 0)
                                {
                                    bool IsTrue = false;
                                    //往届生
                                    if (typeID == "1003")
                                    {
                                        CauseObject_HEM_B_STAFF_WORK causeStaffWork = new CauseObject_HEM_B_STAFF_WORK();
                                        causeStaffWork.STAFF_ID = staffID;
                                        DisplayObject_HEM_B_STAFF_WORK[] StaffWorkItem = HelperObject_HEM_B_STAFF_WORK.Query(causeStaffWork);
                                        //往届生必须填写工作经历
                                        if (StaffWorkItem.Length > 0)
                                        {
                                            IsTrue = true;
                                        }
                                        else
                                        {
                                            throw new Exception("护理简历-往届生,必须填写工作经历!");
                                        }
                                    }
                                    else
                                    {
                                        IsTrue = true;
                                    }
                                    //绝对为真
                                    if (IsTrue)
                                    {
                                        IsTrue = false;

                                        CauseObject_V_HEM_B_STAFF_APPLY_N causeN = new CauseObject_V_HEM_B_STAFF_APPLY_N();
                                        causeN.USER_ID = UserID;
                                        //人员所有的待提交招聘申请(通常情况下只有一个)
                                        DisplayObject_V_HEM_B_STAFF_APPLY_N[] itemDisplayAll = HelperObject_V_HEM_B_STAFF_APPLY_N.Query(causeN, transaction);
                                        if (itemDisplayAll.Length > 0)
                                        {
                                            DisplayObject_V_HEM_B_STAFF_APPLY_N[] itemDisplay = itemDisplayAll.Where(d => d.IS_NURSE == IsNurse).ToArray();
                                            //是否包含当前点击按钮状态类型的待提交招聘申请
                                            if (itemDisplay.Length > 0)
                                            {
                                                DisplayObject_V_HEM_B_STAFF_APPLY_N displayStaffApply0 = itemDisplay[0];

                                                displayStaffApply0.END_DATE = displayStaffApply0.END_DATE.AddDays(1);
                                                //判断待提交招聘申请的招聘启事是否已过期
                                                if (displayStaffApply0.POSTER_STATUS != (decimal)POSTER_STATUS.已过期 && displayStaffApply0.END_DATE > DateTime.Now)
                                                {
                                                    CauseObject_V_HEM_B_STAFF_APPLY_ALL causeStaffApplyAll = new CauseObject_V_HEM_B_STAFF_APPLY_ALL();
                                                    causeStaffApplyAll.STAFF_ID = staffID;
                                                    DisplayObject_V_HEM_B_STAFF_APPLY_ALL[] itemStaffApplyAll = HelperObject_V_HEM_B_STAFF_APPLY_ALL.Query(causeStaffApplyAll, transaction);
                                                    nCount = itemStaffApplyAll.Where(o => o.STATUS != 3).Count();
                                                    //存在待提交招聘申请并且也存在审核的招聘启事
                                                    if (nCount == 0)
                                                    {
                                                        nCount = itemStaffApplyAll.Where(p => p.POSTER_ID == displayStaffApply0.POSTER_ID).Count();
                                                        //判断是否申请过招聘启事
                                                        if (nCount == 0)
                                                        {
                                                            EntityObject_HEM_B_STAFF_APPLY entitySa = new EntityObject_HEM_B_STAFF_APPLY();
                                                            entitySa.STATUS = (decimal)APPLY_STATUS.未处理;
                                                            entitySa.POSTER_ID = displayStaffApply0.POSTER_ID;
                                                            entitySa.STAFF_TYPE_ID = itemDisplay[0].STAFF_TYPE_ID;
                                                            entitySa.CREATE_DATE = DateTime.Now;
                                                            amount = HelperObject_HEM_B_STAFF_APPLY.Save(entitySa, transaction);
                                                            if (amount > 0)
                                                            {
                                                                //删除待提交招聘申请
                                                                Is_Del = true;
                                                                IsSubmit = true;
                                                            }
                                                            //可提交
                                                            IsTrue = true;
                                                        }
                                                        else
                                                        {
                                                            //申请过招聘启事,删除待提交招聘申请
                                                            Is_Del = true;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        //存在审核的招聘启事,删除待提交招聘申请
                                                        Is_Del = true;
                                                    }

                                                }
                                                else
                                                {
                                                    //过期后删除待提交招聘申请
                                                    Is_Del = true;
                                                }
                                            }
                                            else
                                            {
                                                //是否有待提交招聘申请
                                                if (itemDisplayAll.Length > 0)
                                                {
                                                    CauseObject_V_HEM_B_STAFF_APPLY_ALL causeStaffApplyAll = new CauseObject_V_HEM_B_STAFF_APPLY_ALL();
                                                    causeStaffApplyAll.STAFF_ID = staffID;
                                                    DisplayObject_V_HEM_B_STAFF_APPLY_ALL[] itemStaffApplyAll = HelperObject_V_HEM_B_STAFF_APPLY_ALL.Query(causeStaffApplyAll, transaction);
                                                    nCount = itemStaffApplyAll.Where(o => o.STATUS != 3).Count();
                                                    //存在待提交招聘申请并且也存在审核的招聘启事
                                                    if (nCount > 0)
                                                    {
                                                        Is_Del = true;
                                                    }
                                                }
                                                else
                                                {
                                                    //弹出提示
                                                    if (IsNurse == 1)
                                                    {
                                                        //msg.Succeed = true;
                                                        //msg.Message = "护理简历,提交成功!";
                                                        throw new Exception("护理简历,提交成功!");
                                                    }
                                                    else
                                                    {
                                                        //msg.Succeed = true;
                                                        //msg.Message = "简历,提交成功!";
                                                        throw new Exception("简历,提交成功!");
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            //弹出提示
                                            if (IsNurse == 1)
                                            {
                                                //msg.Succeed = true;
                                                //msg.Message = "护理简历,提交成功!";
                                                throw new Exception("护理简历,提交成功!");
                                            }
                                            else
                                            {
                                                //msg.Succeed = true;
                                                //msg.Message = "简历,提交成功!";
                                                throw new Exception("简历,提交成功!");
                                            }
                                        }

                                        //删除所有的待提交招聘申请
                                        if (Is_Del)
                                        {
                                            CauseObject_HEM_B_STAFF_APPLY_N causeStaffApplyN = new CauseObject_HEM_B_STAFF_APPLY_N();
                                            causeStaffApplyN.USER_ID = UserID;
                                            DisplayObject_HEM_B_STAFF_APPLY_N[] dispalyN = HelperObject_HEM_B_STAFF_APPLY_N.Query(causeStaffApplyN, transaction);
                                            if (dispalyN.Length > 0)
                                            {
                                                amount = HelperObject_HEM_B_STAFF_APPLY_N.Delete(causeStaffApplyN, transaction);
                                                //删除有待申请招聘,删除失败
                                                if (amount == 0)
                                                {
                                                    throw new Exception("提交失败,请确保信息填写完整!");
                                                }
                                                //可提交
                                                IsTrue = true;
                                            }

                                        }

                                        if (IsTrue)
                                        {
                                            transaction.Commit();
                                        }
                                        if (IsSubmit)
                                        {
                                            //弹出提示
                                            if (IsNurse == 1)
                                            {
                                                msg.Succeed = true;
                                                msg.Message = "护理简历,提交招聘申请成功!";
                                            }
                                            else
                                            {
                                                msg.Succeed = true;
                                                msg.Message = "简历,提交招聘申请成功!";
                                            }
                                        }
                                        IsSubmit = false;
                                        IsTrue = false;
                                    }
                                }
                                else
                                {
                                    throw new Exception("教育信息未填写高中学历信息!");
                                }
                            }
                            else
                            {
                                throw new Exception("未填写教育信息,请从高中填写教育信息!");
                            }
                        }
                        else
                        {
                            if (IsNurse == 1)
                            {
                                throw new Exception("请先保存护理简历信息!");
                            }
                            else
                            {
                                throw new Exception("请先保存简历信息!");
                            }
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

        public BizLogicMsg StaffSubmitOrCheckNoMessage(string UserID, decimal IsNurse)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        CauseObject_V_HEM_B_STAFF causeVStaff = new CauseObject_V_HEM_B_STAFF();
                        causeVStaff.USER_ID = UserID;
                        causeVStaff.IS_NURSE = IsNurse;
                        DisplayObject_V_HEM_B_STAFF[] vStaffitem = HelperObject_V_HEM_B_STAFF.Query(causeVStaff);
                        //判断是否有简历信息
                        if (vStaffitem.Length > 0)
                        {
                            string staffID = vStaffitem[0].ID;
                            string typeID = vStaffitem[0].TYPE_ID;
                            int amount = 0;
                            bool Is_Del = false;
                            bool IsSubmit = false;
                            int nCount = 0;
                            CauseObject_HEM_B_STAFF_EDUCATION causeStaffEducation = new CauseObject_HEM_B_STAFF_EDUCATION();
                            causeStaffEducation.STAFF_ID = staffID;
                            DisplayObject_HEM_B_STAFF_EDUCATION[] StaffEducationItem = HelperObject_HEM_B_STAFF_EDUCATION.Query(causeStaffEducation);
                            if (string.IsNullOrEmpty(vStaffitem[0].FILE_PATH))
                            {
                                msg.Succeed = false;
                                msg.Message = "请先上传简历文件!";
                                return msg;
                                //throw new Exception("请先上传简历文件!");
                            }
                            //判断是否有学历信息
                            if (StaffEducationItem.Length > 0)
                            {
                                StaffEducationItem = StaffEducationItem.Where(p => p.SLART == "23").ToArray();
                                //判断是否有高中学历信息
                                if (StaffEducationItem.Length > 0)
                                {
                                    bool IsTrue = false;
                                    //往届生
                                    if (typeID == "1003")
                                    {
                                        CauseObject_HEM_B_STAFF_WORK causeStaffWork = new CauseObject_HEM_B_STAFF_WORK();
                                        causeStaffWork.STAFF_ID = staffID;
                                        DisplayObject_HEM_B_STAFF_WORK[] StaffWorkItem = HelperObject_HEM_B_STAFF_WORK.Query(causeStaffWork);
                                        //往届生必须填写工作经历
                                        if (StaffWorkItem.Length > 0)
                                        {
                                            IsTrue = true;
                                        }
                                        else
                                        {
                                            msg.Succeed = false;
                                            msg.Message = "护理简历-往届生,必须填写工作经历!";
                                            return msg;
                                            //throw new Exception("护理简历-往届生,必须填写工作经历!");
                                        }
                                    }
                                    else
                                    {
                                        IsTrue = true;
                                    }
                                    //绝对为真
                                    if (IsTrue)
                                    {
                                        IsTrue = false;

                                        CauseObject_V_HEM_B_STAFF_APPLY_N causeN = new CauseObject_V_HEM_B_STAFF_APPLY_N();
                                        causeN.USER_ID = UserID;
                                        //人员所有的待提交招聘申请(通常情况下只有一个)
                                        DisplayObject_V_HEM_B_STAFF_APPLY_N[] itemDisplayAll = HelperObject_V_HEM_B_STAFF_APPLY_N.Query(causeN, transaction);
                                        if (itemDisplayAll.Length > 0)
                                        {
                                            DisplayObject_V_HEM_B_STAFF_APPLY_N[] itemDisplay = itemDisplayAll.Where(d => d.IS_NURSE == IsNurse).ToArray();
                                            //是否包含当前点击按钮状态类型的待提交招聘申请
                                            if (itemDisplay.Length > 0)
                                            {
                                                DisplayObject_V_HEM_B_STAFF_APPLY_N displayStaffApply0 = itemDisplay[0];

                                                displayStaffApply0.END_DATE = displayStaffApply0.END_DATE.AddDays(1);
                                                //判断待提交招聘申请的招聘启事是否已过期
                                                if (displayStaffApply0.POSTER_STATUS != (decimal)POSTER_STATUS.已过期 && displayStaffApply0.END_DATE > DateTime.Now)
                                                {
                                                    CauseObject_V_HEM_B_STAFF_APPLY_ALL causeStaffApplyAll = new CauseObject_V_HEM_B_STAFF_APPLY_ALL();
                                                    causeStaffApplyAll.STAFF_ID = staffID;
                                                    DisplayObject_V_HEM_B_STAFF_APPLY_ALL[] itemStaffApplyAll = HelperObject_V_HEM_B_STAFF_APPLY_ALL.Query(causeStaffApplyAll, transaction);
                                                    nCount = itemStaffApplyAll.Where(o => o.STATUS != 3).Count();
                                                    //存在待提交招聘申请并且也存在审核的招聘启事
                                                    if (nCount == 0)
                                                    {
                                                        nCount = itemStaffApplyAll.Where(p => p.POSTER_ID == displayStaffApply0.POSTER_ID).Count();
                                                        //判断是否申请过招聘启事
                                                        if (nCount == 0)
                                                        {
                                                            EntityObject_HEM_B_STAFF_APPLY entitySa = new EntityObject_HEM_B_STAFF_APPLY();
                                                            entitySa.STATUS = (decimal)APPLY_STATUS.未处理;
                                                            entitySa.POSTER_ID = displayStaffApply0.POSTER_ID;
                                                            entitySa.STAFF_TYPE_ID = itemDisplay[0].STAFF_TYPE_ID;
                                                            entitySa.CREATE_DATE = DateTime.Now;
                                                            amount = HelperObject_HEM_B_STAFF_APPLY.Save(entitySa, transaction);
                                                            if (amount > 0)
                                                            {
                                                                //删除待提交招聘申请
                                                                Is_Del = true;
                                                                IsSubmit = true;
                                                            }
                                                            //可提交
                                                            IsTrue = true;
                                                        }
                                                        else
                                                        {
                                                            //申请过招聘启事,删除待提交招聘申请
                                                            Is_Del = true;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        //存在审核的招聘启事,删除待提交招聘申请
                                                        Is_Del = true;
                                                    }

                                                }
                                                else
                                                {
                                                    //过期后删除待提交招聘申请
                                                    Is_Del = true;
                                                }
                                            }
                                            else
                                            {
                                                //是否有待提交招聘申请
                                                if (itemDisplayAll.Length > 0)
                                                {
                                                    CauseObject_V_HEM_B_STAFF_APPLY_ALL causeStaffApplyAll = new CauseObject_V_HEM_B_STAFF_APPLY_ALL();
                                                    causeStaffApplyAll.STAFF_ID = staffID;
                                                    DisplayObject_V_HEM_B_STAFF_APPLY_ALL[] itemStaffApplyAll = HelperObject_V_HEM_B_STAFF_APPLY_ALL.Query(causeStaffApplyAll, transaction);
                                                    nCount = itemStaffApplyAll.Where(o => o.STATUS != 3).Count();
                                                    //存在待提交招聘申请并且也存在审核的招聘启事
                                                    if (nCount > 0)
                                                    {
                                                        Is_Del = true;
                                                    }
                                                }
                                                else
                                                {
                                                    //弹出提示
                                                    if (IsNurse == 1)
                                                    {
                                                        msg.Succeed = true;
                                                        msg.Message = "护理简历,提交成功!";
                                                        return msg;
                                                        //throw new Exception("护理简历,提交成功!");
                                                    }
                                                    else
                                                    {
                                                        msg.Succeed = true;
                                                        msg.Message = "简历,提交成功!";
                                                        return msg;
                                                        //throw new Exception("简历,提交成功!");
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            //弹出提示
                                            if (IsNurse == 1)
                                            {
                                                msg.Succeed = true;
                                                msg.Message = "护理简历,提交成功!";
                                                return msg;
                                                //throw new Exception("护理简历,提交成功!");
                                            }
                                            else
                                            {
                                                msg.Succeed = true;
                                                msg.Message = "简历,提交成功!";
                                                return msg;
                                                //throw new Exception("简历,提交成功!");
                                            }
                                        }

                                        //删除所有的待提交招聘申请
                                        if (Is_Del)
                                        {
                                            CauseObject_HEM_B_STAFF_APPLY_N causeStaffApplyN = new CauseObject_HEM_B_STAFF_APPLY_N();
                                            causeStaffApplyN.USER_ID = UserID;
                                            DisplayObject_HEM_B_STAFF_APPLY_N[] dispalyN = HelperObject_HEM_B_STAFF_APPLY_N.Query(causeStaffApplyN, transaction);
                                            if (dispalyN.Length > 0)
                                            {
                                                amount = HelperObject_HEM_B_STAFF_APPLY_N.Delete(causeStaffApplyN, transaction);
                                                //删除有待申请招聘,删除失败
                                                if (amount == 0)
                                                {
                                                    msg.Succeed = false;
                                                    msg.Message = "提交失败,请确保信息填写完整!";
                                                    return msg;

                                                    //throw new Exception("提交失败,请确保信息填写完整!");
                                                }
                                                //可提交
                                                IsTrue = true;
                                            }

                                        }

                                        if (IsTrue)
                                        {
                                            transaction.Commit();
                                        }
                                        if (IsSubmit)
                                        {
                                            //弹出提示
                                            if (IsNurse == 1)
                                            {
                                                msg.Succeed = true;
                                                msg.Message = "护理简历,提交招聘申请成功!";
                                                return msg;
                                            }
                                            else
                                            {
                                                msg.Succeed = true;
                                                msg.Message = "简历,提交招聘申请成功!";
                                                return msg;
                                            }
                                        }
                                        IsSubmit = false;
                                        IsTrue = false;
                                    }
                                }
                                else
                                {
                                    msg.Succeed = false;
                                    msg.Message = "教育信息未填写高中学历信息!";
                                    return msg;
                                    //throw new Exception("教育信息未填写高中学历信息!");
                                }
                            }
                            else
                            {
                                msg.Succeed = false;
                                msg.Message = "未填写教育信息,请从高中填写教育信息!";
                                return msg;
                                //throw new Exception("未填写教育信息,请从高中填写教育信息!");
                            }
                        }
                        else
                        {
                            if (IsNurse == 1)
                            {
                                msg.Succeed = false;
                                msg.Message = "请先保存护理简历信息!";
                                return msg;
                                //throw new Exception("请先保存护理简历信息!");
                            }
                            else
                            {
                                msg.Succeed = false;
                                msg.Message = "请先保存简历信息!";
                                return msg;
                                //throw new Exception("请先保存简历信息!");
                            }
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
    }
}
