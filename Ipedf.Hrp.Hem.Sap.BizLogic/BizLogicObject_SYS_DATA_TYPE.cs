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
    public class BizLogicObject_SYS_DATA_TYPE : BizLogicBase<EntityObject_SYS_DATA_TYPE>, ServiceContract_SYS_DATA_TYPE
    {
        public BizLogicObject_SYS_DATA_TYPE() { }

        private static ServiceContract_SYS_DATA_TYPE singleton;
        public static ServiceContract_SYS_DATA_TYPE Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_SYS_DATA_TYPE();
                    return singleton;
            }
        }

        public BizLogicMsg Save(EntityObject_SYS_DATA_TYPE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_SYS_DATA_TYPE.Save(obj, transaction);
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

        public BizLogicMsg Update(EntityObject_SYS_DATA_TYPE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_SYS_DATA_TYPE.Update(obj, transaction);
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

        public BizLogicMsg Update(EntityObject_SYS_DATA_TYPE[] itemObj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        foreach (EntityObject_SYS_DATA_TYPE obj in itemObj)
                        {
                            int amount = HelperObject_SYS_DATA_TYPE.Update(obj, transaction);
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

        //public EntityObject_SYS_DATA_TYPE[] Query(CauseObject_SYS_DATA_TYPE cause, PagingParamter paging, OrderByParameter order)
        //{
        //    return HelperObject_SYS_DATA_TYPE.Query(cause, paging, order);
        //}

        public DisplayObject_SYS_DATA_TYPE[] Query(CauseObject_SYS_DATA_TYPE cause)
        {
            return HelperObject_SYS_DATA_TYPE.Query(cause);
        }

        public DisplayObject_SYS_DATA_TYPE[] Query(CauseObject_SYS_DATA_TYPE cause, PagingParamter paging, OrderByParameter order)
        {
            return HelperObject_SYS_DATA_TYPE.Query(cause, paging,order);
        }

        public EntityObject_SYS_DATA_TYPE Get(EntityObject_SYS_DATA_TYPE entity)
        {
            return HelperObject_SYS_DATA_TYPE.Get(entity);
        }

        public BizLogicMsg Delete(EntityObject_SYS_DATA_TYPE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_SYS_DATA_TYPE.Delete(obj, transaction);
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

        public BizLogicMsg Delete(EntityObject_SYS_DATA_TYPE[] itemObj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        foreach (EntityObject_SYS_DATA_TYPE obj in itemObj)
                        {
                            int amount = HelperObject_SYS_DATA_TYPE.Delete(obj, transaction);
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
