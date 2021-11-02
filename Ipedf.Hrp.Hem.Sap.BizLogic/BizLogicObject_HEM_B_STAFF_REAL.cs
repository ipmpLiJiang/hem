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
    public class BizLogicObject_HEM_B_STAFF_REAL : BizLogicBase<EntityObject_HEM_B_STAFF_REAL> , ServiceContract_HEM_B_STAFF_REAL
    {
        public BizLogicObject_HEM_B_STAFF_REAL() { }

        private static ServiceContract_HEM_B_STAFF_REAL singleton;
        public static ServiceContract_HEM_B_STAFF_REAL Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_HEM_B_STAFF_REAL();
                    return singleton;
            }
        }

        

        public BizLogicMsg Save(EntityObject_HEM_B_STAFF_REAL[] itemObj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = 0;

                        CauseObject_HEM_B_STAFF_REAL cause = new CauseObject_HEM_B_STAFF_REAL();
                        cause.USER_ID = itemObj[0].USER_ID;
                        cause.STATUS = itemObj[0].STATUS;

                        DisplayObject_HEM_B_STAFF_REAL[] itemDisplay = HelperObject_HEM_B_STAFF_REAL.Query(cause);
                        if (itemDisplay.Length > 0)
                        {
                            amount = HelperObject_HEM_B_STAFF_REAL.Delete(cause, transaction);
                        }
                        else
                        {
                            amount = 1;
                        }

                        if (amount > 0)
                        {
                            foreach (EntityObject_HEM_B_STAFF_REAL obj in itemObj)
                            {
                                amount = HelperObject_HEM_B_STAFF_REAL.Save(obj, transaction);
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

        public BizLogicMsg Save(EntityObject_HEM_B_STAFF_REAL obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_STAFF_REAL.Save(obj, transaction);
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

        public BizLogicMsg Update(string UserID)
        {
            BizLogicMsg msg = new BizLogicMsg();
            string strMessage = "";
            int amount = HelperObject_HEM_B_STAFF_REAL.UPDATE_STAFF_REAL(UserID,out strMessage);
            if (amount > 0)
            {
                msg.Succeed = true;
            }
            else
            {
                msg.Succeed = false;
            }
            msg.Message = strMessage;
            return msg;
        }

        public BizLogicMsg Update(EntityObject_HEM_B_STAFF_REAL obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_STAFF_REAL.Update(obj, transaction);
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

        public BizLogicMsg Update(EntityObject_HEM_B_STAFF_REAL[] itemObj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        foreach (EntityObject_HEM_B_STAFF_REAL obj in itemObj)
                        {
                            int amount = HelperObject_HEM_B_STAFF_REAL.Update(obj, transaction);
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

        public DisplayObject_HEM_B_STAFF_REAL[] Query(CauseObject_HEM_B_STAFF_REAL cause, PagingParamter paging, OrderByParameter order)
        {
            return HelperObject_HEM_B_STAFF_REAL.Query(cause, paging, order);
        }

        public DisplayObject_HEM_B_STAFF_REAL[] Query(CauseObject_HEM_B_STAFF_REAL cause)
        {
            return HelperObject_HEM_B_STAFF_REAL.Query(cause);
        }

        public EntityObject_HEM_B_STAFF_REAL Get(EntityObject_HEM_B_STAFF_REAL entity)
        {
            return HelperObject_HEM_B_STAFF_REAL.Get(entity);
        }

        public BizLogicMsg Delete(EntityObject_HEM_B_STAFF_REAL obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_STAFF_REAL.Delete(obj, transaction);
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

        public BizLogicMsg Delete(EntityObject_HEM_B_STAFF_REAL[] itemObj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        foreach (EntityObject_HEM_B_STAFF_REAL obj in itemObj)
                        {
                            int amount = HelperObject_HEM_B_STAFF_REAL.Delete(obj, transaction);
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
