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
    public class BizLogicObject_HEM_B_STAFF_EDUCATION : BizLogicBase<EntityObject_HEM_B_STAFF_EDUCATION>, ServiceContract_HEM_B_STAFF_EDUCATION
    {
        public BizLogicObject_HEM_B_STAFF_EDUCATION() { }

        private static ServiceContract_HEM_B_STAFF_EDUCATION singleton;
        public static ServiceContract_HEM_B_STAFF_EDUCATION Proxy
        {
            get
            {
                if (singleton == null) singleton = new BizLogicObject_HEM_B_STAFF_EDUCATION();
                return singleton;
            }
        }

        public BizLogicMsg Save(EntityObject_HEM_B_STAFF_EDUCATION obj, EntityObject_HEM_B_STAFF entityStaff, decimal IS_NURSE)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = 0;
                        int nCount = 0;

                        EntityObject_HEM_B_STAFF_EDUCATION[] updateItemAll = Staff_EducationAll(obj.STAFF_ID);
                        EntityObject_HEM_B_STAFF_EDUCATION[] updateItem = updateItemAll.Where(p => p.SLART == "23").ToArray();
                        if (updateItem.Length >0 || obj.SLART == "23")
                        {
                            updateItem = updateItemAll.Where(p => p.SLART == obj.SLART).ToArray();
                            if (updateItem.Length == 0)
                            {
                                if (obj.IS_HIGHEST == 1)
                                {
                                    updateItem = updateItemAll.Where(p=>p.IS_HIGHEST==1).ToArray();
                                    foreach (EntityObject_HEM_B_STAFF_EDUCATION entity in updateItem)
                                    {
                                        entity.IS_HIGHEST = 0;
                                        entity.SetUpdate("IS_HIGHEST");
                                        amount = HelperObject_HEM_B_STAFF_EDUCATION.Update(entity, transaction);
                                    }
                                }
                                amount = HelperObject_HEM_B_STAFF_EDUCATION.Save(obj, transaction);
                                if (amount > 0)
                                {
                                    //CauseObject_V_HEM_B_STAFF_APPLY_N causeN = new CauseObject_V_HEM_B_STAFF_APPLY_N();
                                    //causeN.USER_ID = entityStaff.USER_ID;
                                    //DisplayObject_V_HEM_B_STAFF_APPLY_N[] itemDisplayAll = HelperObject_V_HEM_B_STAFF_APPLY_N.Query(causeN, transaction);

                                    //bool Is_Del = false;
                                    //DisplayObject_V_HEM_B_STAFF_APPLY_N[] itemDisplay = itemDisplayAll.Where(d => d.IS_NURSE == IS_NURSE).ToArray();
                                    //if (itemDisplay.Length > 0)
                                    //{
                                    //    DisplayObject_V_HEM_B_STAFF_APPLY_N displayStaffApply0 = itemDisplay[0];

                                    //    displayStaffApply0.END_DATE = displayStaffApply0.END_DATE.AddDays(1);
                                    //    if (displayStaffApply0.POSTER_STATUS != (decimal)POSTER_STATUS.已过期 && displayStaffApply0.END_DATE > DateTime.Now)
                                    //    {
                                    //        CauseObject_V_HEM_B_STAFF_APPLY_ALL causeStaffApplyAll = new CauseObject_V_HEM_B_STAFF_APPLY_ALL();
                                    //        causeStaffApplyAll.STAFF_ID = obj.STAFF_ID;
                                    //        DisplayObject_V_HEM_B_STAFF_APPLY_ALL[] itemStaffApplyAll = HelperObject_V_HEM_B_STAFF_APPLY_ALL.Query(causeStaffApplyAll, transaction);
                                    //        nCount = itemStaffApplyAll.Where(o => o.STATUS != 3).Count();
                                    //        if (nCount == 0)
                                    //        {
                                    //            nCount = itemStaffApplyAll.Where(p => p.POSTER_ID == displayStaffApply0.POSTER_ID).Count();
                                    //            if (nCount == 0)
                                    //            {
                                    //                EntityObject_HEM_B_STAFF_APPLY entitySa = new EntityObject_HEM_B_STAFF_APPLY();
                                    //                entitySa.STATUS = (decimal)APPLY_STATUS.未处理;
                                    //                entitySa.POSTER_ID = displayStaffApply0.POSTER_ID;
                                    //                entitySa.STAFF_TYPE_ID = itemDisplay[0].STAFF_TYPE_ID;
                                    //                entitySa.CREATE_DATE = DateTime.Now;
                                    //                amount = HelperObject_HEM_B_STAFF_APPLY.Save(entitySa, transaction);
                                    //                if (amount > 0)
                                    //                {
                                    //                    Is_Del = true;
                                    //                }
                                    //            }
                                    //            else
                                    //            {
                                    //                Is_Del = true;
                                    //            }
                                    //        }
                                    //        else
                                    //        {
                                    //            Is_Del = true;
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
                                    //        causeStaffApplyAll.STAFF_ID = obj.STAFF_ID;
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
                                    //    if (!string.IsNullOrEmpty(entityStaff.USER_ID))
                                    //    {
                                    //        CauseObject_HEM_B_STAFF_APPLY_N causeStaffApplyN = new CauseObject_HEM_B_STAFF_APPLY_N();
                                    //        causeStaffApplyN.USER_ID = entityStaff.USER_ID;
                                    //        DisplayObject_HEM_B_STAFF_APPLY_N[] dispalyN = HelperObject_HEM_B_STAFF_APPLY_N.Query(causeStaffApplyN, transaction);
                                    //        if (dispalyN.Length > 0)
                                    //        {
                                    //            amount = HelperObject_HEM_B_STAFF_APPLY_N.Delete(causeStaffApplyN, transaction);
                                    //            if (amount == 0)
                                    //            {
                                    //                throw new Exception("保存教育信息失败!");
                                    //            }
                                    //        }
                                    //    }
                                    //}
                                    transaction.Commit();
                                }
                            }
                            else
                            {
                                throw new Exception("您已保存过在此学历信息!");
                            }
                        }
                        else
                        {
                            throw new Exception("学历信息请从高中填起!");
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

        public BizLogicMsg Update(EntityObject_HEM_B_STAFF_EDUCATION obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = 0;
                        EntityObject_HEM_B_STAFF_EDUCATION[] updateItemAll = Staff_EducationAll(obj.STAFF_ID);
                        EntityObject_HEM_B_STAFF_EDUCATION[] updateItem = updateItemAll.Where(p => p.ID == obj.ID).ToArray();
                        if (updateItem[0].SLART != obj.SLART && updateItem[0].SLART == "23")
                        {
                            throw new Exception("不可修改,教育信息必须填写高中学历!");
                        }else{
                            updateItem = updateItemAll.Where(p => p.ID != obj.ID && p.SLART == obj.SLART).ToArray();
                            if (updateItem.Length == 0)
                            {
                                if (obj.IS_HIGHEST == 1)
                                {
                                    updateItem = updateItemAll.Where(p => p.IS_HIGHEST == 1 && p.ID != obj.ID).ToArray();
                                    foreach (EntityObject_HEM_B_STAFF_EDUCATION entity in updateItem)
                                    {
                                        entity.IS_HIGHEST = 0;
                                        entity.SetUpdate("IS_HIGHEST");
                                        amount = HelperObject_HEM_B_STAFF_EDUCATION.Update(entity, transaction);
                                    }
                                }

                                amount = HelperObject_HEM_B_STAFF_EDUCATION.Update(obj, transaction);
                                transaction.Commit();
                            }
                            else
                            {
                                throw new Exception("您已保存过在此学历信息");
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

        public EntityObject_HEM_B_STAFF_EDUCATION[] Staff_EducationAll(string staffId)
        {
            CauseObject_HEM_B_STAFF_EDUCATION cause = new CauseObject_HEM_B_STAFF_EDUCATION();
            cause.STAFF_ID = staffId;
            return HelperObject_HEM_B_STAFF_EDUCATION.Query(cause);
        }

        public BizLogicMsg Update(EntityObject_HEM_B_STAFF_EDUCATION[] itemObj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        foreach (EntityObject_HEM_B_STAFF_EDUCATION obj in itemObj)
                        {
                            int amount = HelperObject_HEM_B_STAFF_EDUCATION.Update(obj, transaction);
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

        public DisplayObject_HEM_B_STAFF_EDUCATION[] Query(CauseObject_HEM_B_STAFF_EDUCATION cause)
        {
            return HelperObject_HEM_B_STAFF_EDUCATION.Query(cause);
        }

        public DisplayObject_HEM_B_STAFF_EDUCATION[] Query(CauseObject_HEM_B_STAFF_EDUCATION cause, PagingParamter paging, OrderByParameter order)
        {
            return HelperObject_HEM_B_STAFF_EDUCATION.Query(cause, paging, order);
        }

        public EntityObject_HEM_B_STAFF_EDUCATION Get(EntityObject_HEM_B_STAFF_EDUCATION entity)
        {
            return HelperObject_HEM_B_STAFF_EDUCATION.Get(entity);
        }

        public BizLogicMsg Delete(EntityObject_HEM_B_STAFF_EDUCATION obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        obj = HelperObject_HEM_B_STAFF_EDUCATION.Get(obj);
                        if (obj.SLART == "23") 
                        {
                            throw new Exception("不可删除,教育信息必须填写高中学历!");
                        }
                        else
                        {
                            int amount = HelperObject_HEM_B_STAFF_EDUCATION.Delete(obj, transaction);
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

        public BizLogicMsg Delete(EntityObject_HEM_B_STAFF_EDUCATION[] itemObj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        foreach (EntityObject_HEM_B_STAFF_EDUCATION obj in itemObj)
                        {
                            int amount = HelperObject_HEM_B_STAFF_EDUCATION.Delete(obj, transaction);
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
