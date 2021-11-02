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
    public class BizLogicObject_HEM_B_USER_LOGIN : BizLogicBase<EntityObject_HEM_B_USER_LOGIN>, ServiceContract_HEM_B_USER_LOGIN
    {
        public BizLogicObject_HEM_B_USER_LOGIN() { }

        private static ServiceContract_HEM_B_USER_LOGIN singleton;
        public static ServiceContract_HEM_B_USER_LOGIN Proxy
        {
            get
            {
                if (singleton == null) singleton = new BizLogicObject_HEM_B_USER_LOGIN();
                return singleton;
            }
        }

        public DisplayObject_HEM_B_USER_LOGIN[] Query(CauseObject_HEM_B_USER_LOGIN cause)
        {
            return HelperObject_HEM_B_USER_LOGIN.Query(cause);
        }

        public DisplayObject_HEM_B_USER_LOGIN[] Query(CauseObject_HEM_B_USER_LOGIN cause, PagingParamter paging, OrderByParameter order)
        {
            return HelperObject_HEM_B_USER_LOGIN.Query(cause, paging, order);
        }

        public BizLogicMsg RegisterSave(EntityObject_HEM_B_USER_LOGIN entityLogin, EntityObject_HEM_B_USER entityUser)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int amount = HelperObject_HEM_B_USER_LOGIN.Save(entityLogin, transaction);

                        if (amount > 0)
                        {
                            entityUser.USER_LOGIN_ID = entityLogin.ID;
                            amount = HelperObject_HEM_B_USER.Save(entityUser, transaction);
                            if (amount > 0)
                            {
                                transaction.Commit();
                            }
                            else
                            {
                                throw new Exception("注册失败,请联系管理员!");
                            }
                        }
                        else
                        {
                            throw new Exception("注册失败,请联系管理员!");
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

        public BizLogicMsg RegisterSave(EntityObject_HEM_B_USER_LOGIN entityLogin, EntityObject_HEM_B_USER entityUser, EntityObject_HEM_B_STAFF_APPLY_N entity)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int amount = HelperObject_HEM_B_USER_LOGIN.Save(entityLogin, transaction);
                        if (amount > 0)
                        {
                            entityUser.USER_LOGIN_ID = entityLogin.ID;

                            amount = HelperObject_HEM_B_USER.Save(entityUser, transaction);
                            if (amount > 0)
                            {
                                entity.USER_ID = entityUser.ID;
                                entity.STATUS = 1;
                                amount = HelperObject_HEM_B_STAFF_APPLY_N.Save(entity, transaction);
                                if (amount > 0)
                                {
                                    transaction.Commit();
                                }
                                else
                                {
                                    throw new Exception("注册失败,如有问题请联系管理员!");
                                }
                            }
                            else
                            {
                                throw new Exception("注册失败,如有问题请联系管理员!");
                            }
                        }
                        else
                        {
                            throw new Exception("注册失败,如有问题请联系管理员!");
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

        public BizLogicMsg RegisterUpdate(EntityObject_HEM_B_USER_LOGIN entityLogin, EntityObject_HEM_B_USER entityUser, EntityObject_HEM_B_STAFF entityStaff)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int amount = HelperObject_HEM_B_USER_LOGIN.Update(entityLogin, transaction);
                        if (amount > 0)
                        {
                            entityUser.USER_LOGIN_ID = entityLogin.ID;
                            amount = HelperObject_HEM_B_USER.Update(entityUser, transaction);
                            if (amount > 0)
                            {
                                if (!string.IsNullOrEmpty(entityStaff.USER_ID))
                                {
                                    amount = HelperObject_HEM_B_STAFF.MyUpdate(entityStaff, transaction);
                                    if (amount == 0)
                                    {
                                        throw new Exception("更新失败,如有问题请联系管理员!");
                                    }
                                }
                                transaction.Commit();
                            }
                            else
                            {
                                throw new Exception("更新失败,如有问题请联系管理员!");
                            }
                        }
                        else {
                            throw new Exception("更新失败,如有问题请联系管理员!");
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

        public BizLogicMsg Save(EntityObject_HEM_B_USER_LOGIN obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_USER_LOGIN.Save(obj, transaction);
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

        public BizLogicMsg Update(EntityObject_HEM_B_USER_LOGIN obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_USER_LOGIN.Update(obj, transaction);
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

        public BizLogicMsg Login(CauseObject_V_USER_LOGIN_INFO cause, ref EntityObject_HEM_B_RECRUIT_POSTER entityRecruitPoster, ref EntityObject_V_USER_LOGIN_INFO loginEntity)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        DisplayObject_V_USER_LOGIN_INFO displayEntity = HelperObject_V_USER_LOGIN_INFO.Login(cause);
                        if (displayEntity != null && displayEntity.ID != null)
                        {
                            if (displayEntity.IS_USABL == 1)
                            {
                                loginEntity.ID = displayEntity.ID;
                                loginEntity.ACCOUNT = displayEntity.ACCOUNT;
                                loginEntity.IS_USABL = displayEntity.IS_USABL;
                                loginEntity.FLAG = displayEntity.FLAG;
                                loginEntity.IS_USABL_NAME = displayEntity.IS_USABL_NAME;
                                loginEntity.CREATE_DATE = displayEntity.CREATE_DATE;
                                loginEntity.EMAIL = displayEntity.EMAIL;
                                loginEntity.MOBILE = displayEntity.MOBILE;
                                loginEntity.NAME = displayEntity.NAME;
                                loginEntity.PASSWORD = displayEntity.PASSWORD;
                                loginEntity.TYPE_ID_NAME = displayEntity.TYPE_ID_NAME;
                                loginEntity.USER_ID = displayEntity.USER_ID;

                                bool IsTrue = true;
                                int nDel = 0;
                                int amount = 0;
                                CauseObject_HEM_B_STAFF_APPLY_N causeStaffApplyN = new CauseObject_HEM_B_STAFF_APPLY_N();
                                causeStaffApplyN.USER_ID = displayEntity.USER_ID;
                                DisplayObject_HEM_B_STAFF_APPLY_N[] dispalyN = HelperObject_HEM_B_STAFF_APPLY_N.Query(causeStaffApplyN, transaction);
                                if (dispalyN.Length > 0)
                                {
                                    //删除所有招聘申请记录
                                    nDel = HelperObject_HEM_B_STAFF_APPLY_N.Delete(causeStaffApplyN, transaction);
                                    if (nDel == 0)
                                    {
                                        throw new Exception("申请失败!");
                                    }
                                }

                                entityRecruitPoster = HelperObject_HEM_B_RECRUIT_POSTER.Get(entityRecruitPoster);

                                decimal IS_NURSE = entityRecruitPoster.IS_NURSE;
                                string POSTER_ID = entityRecruitPoster.ID;
                                bool IS_STAFF_TYPE = false;
                                if (entityRecruitPoster != null)
                                {
                                    entityRecruitPoster.END_DATE = entityRecruitPoster.END_DATE.AddDays(1);
                                    //招聘启事是否过期
                                    if (entityRecruitPoster.STATUS != (decimal)POSTER_STATUS.已过期 && entityRecruitPoster.END_DATE > DateTime.Now)
                                    {
                                        EntityObject_HEM_B_STAFF_APPLY_N entityN = new EntityObject_HEM_B_STAFF_APPLY_N();
                                        entityN.POSTER_ID = entityRecruitPoster.ID;
                                        entityN.USER_ID = displayEntity.USER_ID;
                                        entityN.STATUS = 1;

                                        DisplayObject_V_HEM_B_STAFF[] itemVStaff = HelperObject_V_HEM_B_STAFF.Query(
                                            new CauseObject_V_HEM_B_STAFF() { USER_ID = displayEntity.USER_ID }, transaction
                                        );
                                        if (itemVStaff.Length > 0)
                                        {
                                            string StaffID = itemVStaff[0].ID;
                                            
                                            DisplayObject_HEM_B_STAFF_EDUCATION[] itemStaffEducation = HelperObject_HEM_B_STAFF_EDUCATION.Query(
                                                new CauseObject_HEM_B_STAFF_EDUCATION() { STAFF_ID = StaffID }, transaction
                                            );
                                            itemVStaff = itemVStaff.Where(p => p.IS_NURSE == IS_NURSE).ToArray();
                                            string TypeID = "";
                                            string StaffTypeID = "";
                                            string StaffFile = "";
                                            if (itemVStaff.Length > 0)
                                            {
                                                TypeID = itemVStaff[0].TYPE_ID;
                                                StaffTypeID = itemVStaff[0].STAFF_TYPE_ID;
                                                StaffFile = itemVStaff[0].FILE_PATH;
                                            }
                                            if (itemVStaff.Length > 0 && itemStaffEducation.Length > 0 && !string.IsNullOrEmpty(StaffFile))
                                            {
                                                itemStaffEducation = itemStaffEducation.Where(p=>p.SLART=="23").ToArray();
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
                                                        CauseObject_V_HEM_B_STAFF_APPLY_ALL causeStaffApplyAll = new CauseObject_V_HEM_B_STAFF_APPLY_ALL();
                                                        causeStaffApplyAll.STAFF_ID = StaffID;
                                                        DisplayObject_V_HEM_B_STAFF_APPLY_ALL[] itemStaffApplyAll = HelperObject_V_HEM_B_STAFF_APPLY_ALL.Query(causeStaffApplyAll, transaction);
                                                        if (itemStaffApplyAll.Length == 0)
                                                        {
                                                            EntityObject_HEM_B_STAFF_APPLY entitySa = new EntityObject_HEM_B_STAFF_APPLY();
                                                            entitySa.STATUS = (decimal)APPLY_STATUS.未处理;
                                                            entitySa.POSTER_ID = entityRecruitPoster.ID;
                                                            entitySa.STAFF_TYPE_ID = StaffTypeID;
                                                            entitySa.CREATE_DATE = DateTime.Now;
                                                            amount = HelperObject_HEM_B_STAFF_APPLY.Save(entitySa, transaction);
                                                            if (amount > 0)
                                                            {
                                                                transaction.Commit();
                                                                IsTrue = false;
                                                                msg.Message = "申请成功!";
                                                            }
                                                            else
                                                            {
                                                                msg.Message = "申请失败,请登录后完善简历后重新申请!";
                                                            }
                                                        }
                                                        else
                                                        {
                                                            DisplayObject_V_HEM_B_STAFF_APPLY_ALL[] itemStaffApply = itemStaffApplyAll.Where(o => o.POSTER_ID == POSTER_ID).ToArray();
                                                            if (itemStaffApply.Length > 0)
                                                            {
                                                                msg.Message = "申请失败,您已申请过该招聘启事,请耐心等待处理结果!";
                                                            }
                                                            else
                                                            {
                                                                itemStaffApply = itemStaffApplyAll.Where(s => s.STATUS == (decimal)APPLY_STATUS.未处理 || s.STATUS == (decimal)APPLY_STATUS.简历通过 || s.STATUS == (decimal)APPLY_STATUS.传输成功 || s.STATUS == (decimal)APPLY_STATUS.安排面试 || s.STATUS == (decimal)APPLY_STATUS.已完成).ToArray();
                                                                if (itemStaffApply.Length > 0)
                                                                {
                                                                    msg.Message = "申请失败,您已申请了其他招聘启事,请耐心等待处理结果!";
                                                                }
                                                                else
                                                                {
                                                                    EntityObject_HEM_B_STAFF_APPLY entitySa = new EntityObject_HEM_B_STAFF_APPLY();
                                                                    entitySa.STATUS = (decimal)APPLY_STATUS.未处理;
                                                                    entitySa.POSTER_ID = entityRecruitPoster.ID;
                                                                    entitySa.STAFF_TYPE_ID = StaffTypeID;
                                                                    entitySa.CREATE_DATE = DateTime.Now;
                                                                    amount = HelperObject_HEM_B_STAFF_APPLY.Save(entitySa, transaction);
                                                                    if (amount > 0)
                                                                    {
                                                                        transaction.Commit();
                                                                        IsTrue = false;
                                                                        msg.Message = "申请成功!";
                                                                    }
                                                                    else
                                                                    {
                                                                        msg.Message = "申请失败,请登录后完善简历后重新申请!";
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }else
                                                    {
                                                        amount = HelperObject_HEM_B_STAFF_APPLY_N.Save(entityN, transaction);
                                                        if (amount > 0)
                                                        {
                                                            msg.Message = "C1";
                                                        }
                                                        IsTrue = false;
                                                        transaction.Commit();
                                                    }
                                                }
                                                else
                                                {
                                                    amount = HelperObject_HEM_B_STAFF_APPLY_N.Save(entityN, transaction);
                                                    if (amount > 0)
                                                    {
                                                        msg.Message = "B2";
                                                    }
                                                    IsTrue = false;
                                                    transaction.Commit();
                                                }
                                            }
                                            else
                                            {
                                                //itemVStaff.Length > 0 && itemStaffEducation.Length > 0
                                                //存在简历没有申请职位类型的简历
                                                amount = HelperObject_HEM_B_STAFF_APPLY_N.Save(entityN, transaction);
                                                if (amount > 0)
                                                {
                                                    if (itemVStaff.Length > 0 && itemStaffEducation.Length == 0)
                                                    {
                                                        msg.Message = "B1";//申请失败,请登录后完善简历
                                                    }
                                                    else if (!string.IsNullOrEmpty(StaffFile))
                                                    {
                                                        msg.Message = "A1";//申请失败,请登录后完善简历
                                                    }
                                                    else
                                                    {
                                                        msg.Message = "B3";//申请失败,请登录后完善简历
                                                    }
                                                }
                                                else
                                                {
                                                    if (itemVStaff.Length > 0 && itemStaffEducation.Length == 0)
                                                    {
                                                        msg.Message = "B0";//申请失败,请登录后完善简历后重新申请!
                                                    }
                                                    else
                                                    {
                                                        msg.Message = "A0";//申请失败,请登录后完善简历后重新申请!
                                                    }
                                                }
                                                IsTrue = false;
                                                transaction.Commit();
                                            }
                                        }
                                        else
                                        {
                                            //已注册但未填写简历信息
                                            amount = HelperObject_HEM_B_STAFF_APPLY_N.Save(entityN, transaction);
                                            if (amount > 0)
                                            {
                                                msg.Message = "A1";
                                                //申请失败,请登录后完善简历!
                                            }
                                            else
                                            {
                                                msg.Message = "A0";
                                                //申请失败,请登录后完善简历后重新申请!
                                            }
                                            IsTrue = false;
                                            transaction.Commit();
                                        }
                                    }
                                    else
                                    {
                                        msg.Message = "申请失败,该招聘启事已过期!";
                                    }
                                }
                                else
                                {
                                    msg.Message = "申请失败,该招聘启事信息有误!";
                                }

                                if (IsTrue && nDel > 0)
                                {
                                    transaction.Commit();
                                }
                            }
                            else
                            {
                                throw new Exception("当前用户账户不可用！");
                            }
                        }
                        else
                        {
                            throw new Exception("账户不存在或密码错误！");
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
