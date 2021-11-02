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
    public class BizLogicObject_HEM_B_STAFF_WORK : BizLogicBase<EntityObject_HEM_B_STAFF_WORK> , ServiceContract_HEM_B_STAFF_WORK
    {
        public BizLogicObject_HEM_B_STAFF_WORK() { }

        private static ServiceContract_HEM_B_STAFF_WORK singleton;
        public static ServiceContract_HEM_B_STAFF_WORK Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_HEM_B_STAFF_WORK();
                    return singleton;
            }
        }

        public BizLogicMsg Save(EntityObject_HEM_B_STAFF_WORK obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_STAFF_WORK.Save(obj, transaction);
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

        public BizLogicMsg Update(EntityObject_HEM_B_STAFF_WORK obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_STAFF_WORK.Update(obj, transaction);
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

        public BizLogicMsg Update(EntityObject_HEM_B_STAFF_WORK[] itemObj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        foreach (EntityObject_HEM_B_STAFF_WORK obj in itemObj)
                        {
                            int amount = HelperObject_HEM_B_STAFF_WORK.Update(obj, transaction);
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

        //public EntityObject_HEM_B_STAFF_WORK[] Query(CauseObject_HEM_B_STAFF_WORK cause, PagingParamter paging, OrderByParameter order)
        //{
        //    return HelperObject_HEM_B_STAFF_WORK.Query(cause, paging, order);
        //}

        public DisplayObject_HEM_B_STAFF_WORK[] Query(CauseObject_HEM_B_STAFF_WORK cause)
        {
            return HelperObject_HEM_B_STAFF_WORK.Query(cause);
        }

        public DisplayObject_HEM_B_STAFF_WORK[] Query(CauseObject_HEM_B_STAFF_WORK cause, PagingParamter paging, OrderByParameter order)
        {
            return HelperObject_HEM_B_STAFF_WORK.Query(cause, paging,order);
        }

        public EntityObject_HEM_B_STAFF_WORK Get(EntityObject_HEM_B_STAFF_WORK entity)
        {
            return HelperObject_HEM_B_STAFF_WORK.Get(entity);
        }

        public BizLogicMsg Delete(EntityObject_HEM_B_STAFF_WORK obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_STAFF_WORK.Delete(obj, transaction);
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

        public BizLogicMsg Delete(EntityObject_HEM_B_STAFF_WORK[] itemObj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        foreach (EntityObject_HEM_B_STAFF_WORK obj in itemObj)
                        {
                            int amount = HelperObject_HEM_B_STAFF_WORK.Delete(obj, transaction);
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
