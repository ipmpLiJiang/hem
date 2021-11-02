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
    public class BizLogicObject_HEM_B_STAFF_MEMBER : BizLogicBase<EntityObject_HEM_B_STAFF_MEMBER> , ServiceContract_HEM_B_STAFF_MEMBER
    {
        public BizLogicObject_HEM_B_STAFF_MEMBER() { }

        private static ServiceContract_HEM_B_STAFF_MEMBER singleton;
        public static ServiceContract_HEM_B_STAFF_MEMBER Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_HEM_B_STAFF_MEMBER();
                    return singleton;
            }
        }

        public BizLogicMsg Save(EntityObject_HEM_B_STAFF_MEMBER obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_STAFF_MEMBER.Save(obj, transaction);
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

        public BizLogicMsg Update(EntityObject_HEM_B_STAFF_MEMBER obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_STAFF_MEMBER.Update(obj, transaction);
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

        public BizLogicMsg Update(EntityObject_HEM_B_STAFF_MEMBER[] itemObj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        foreach (EntityObject_HEM_B_STAFF_MEMBER obj in itemObj)
                        {
                            int amount = HelperObject_HEM_B_STAFF_MEMBER.Update(obj, transaction);
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

        public DisplayObject_HEM_B_STAFF_MEMBER[] Query(CauseObject_HEM_B_STAFF_MEMBER cause, PagingParamter paging, OrderByParameter order)
        {
            return HelperObject_HEM_B_STAFF_MEMBER.Query(cause, paging, order);
        }

        public DisplayObject_HEM_B_STAFF_MEMBER[] Query(CauseObject_HEM_B_STAFF_MEMBER cause)
        {
            return HelperObject_HEM_B_STAFF_MEMBER.Query(cause);
        }

        public EntityObject_HEM_B_STAFF_MEMBER Get(EntityObject_HEM_B_STAFF_MEMBER entity)
        {
            return HelperObject_HEM_B_STAFF_MEMBER.Get(entity);
        }

        public BizLogicMsg Delete(EntityObject_HEM_B_STAFF_MEMBER obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_STAFF_MEMBER.Delete(obj, transaction);
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

        public BizLogicMsg Delete(EntityObject_HEM_B_STAFF_MEMBER[] itemObj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        foreach (EntityObject_HEM_B_STAFF_MEMBER obj in itemObj)
                        {
                            int amount = HelperObject_HEM_B_STAFF_MEMBER.Delete(obj, transaction);
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
