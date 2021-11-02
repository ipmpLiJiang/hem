
using System;
using System.Data;
using System.Collections;
using System.ServiceModel;
using Ipedf.Hrp.Hem.Sap.Entity;
using Ipedf.Hrp.Hem.Sap.DataAccess;
using Ipedf.Hrp.Hem.Sap.ServiceContract;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Hrp.Hem.Sap.BizLogic;
using Ipedf.Wcf.ClientProxy;
namespace Ipedf.Hrp.Hem.Sap.BizLogic
{
	[CauseObject(typeof(CauseObject_HEM_B_STAFF_TYPE))]
	public partial class BizLogicObject_HEM_B_STAFF_TYPE: BizLogicBase<EntityObject_HEM_B_STAFF_TYPE>,ServiceContract_HEM_B_STAFF_TYPE
	{	
		#region Proxy 
		public BizLogicObject_HEM_B_STAFF_TYPE() { }
        private static ServiceContract_HEM_B_STAFF_TYPE singleton;
        public static ServiceContract_HEM_B_STAFF_TYPE Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_HEM_B_STAFF_TYPE();
                    return singleton;
            }
        }
        #endregion	

		public BizLogicMsg Save(EntityObject_HEM_B_STAFF_TYPE obj)
		{
			BizLogicMsg msg = new BizLogicMsg();
			using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
			{
				using (IDbTransaction transaction = connection.BeginTransaction())
				{                    
                    
					try
					{
						int amount = HelperObject_HEM_B_STAFF_TYPE.Save(obj, transaction);
				//平台自动生成代码
						PostSave(obj, transaction);
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
		public BizLogicMsg Update(EntityObject_HEM_B_STAFF_TYPE obj)
		{
			BizLogicMsg msg = new BizLogicMsg();
			using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
			{
				using (IDbTransaction transaction = connection.BeginTransaction())
				{ 
					try
					{
						int amount = HelperObject_HEM_B_STAFF_TYPE.Update(obj, transaction);
				//平台自动生成代码
						PostSave(obj, transaction);
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

        public BizLogicMsg MyUpdate(EntityObject_HEM_B_STAFF_TYPE[] ayyObj,string ID)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach(EntityObject_HEM_B_STAFF_TYPE obj in ayyObj)
                        {
                            if (obj.ID == ID)
                            {
                                obj.IS_ACTION = 1;
                            }
                            else
                            {
                                obj.IS_ACTION = 2;
                            }
                            obj.SetUpdate("IS_ACTION");
                            int amount = HelperObject_HEM_B_STAFF_TYPE.Update(obj, transaction);
                        }
                        //平台自动生成代码

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

		public BizLogicMsg Delete(EntityObject_HEM_B_STAFF_TYPE obj)
		{
		    BizLogicMsg msg = new BizLogicMsg();
		    using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
		    {
			    using (IDbTransaction transaction = connection.BeginTransaction())
			    { 
				    try
				    {
					    int amount = HelperObject_HEM_B_STAFF_TYPE.Delete(obj, transaction);
			    //平台自动生成代码
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
		public EntityObject_HEM_B_STAFF_TYPE Get(EntityObject_HEM_B_STAFF_TYPE obj)
		{
			//平台自动生成代码
			return HelperObject_HEM_B_STAFF_TYPE.Get(obj);
		}
	
		public DisplayObject_HEM_B_STAFF_TYPE[] Query(CauseObject_HEM_B_STAFF_TYPE cause)
		{	
				
			//平台自动生成代码
			return HelperObject_HEM_B_STAFF_TYPE.Query(cause);
		}

        public DisplayObject_HEM_B_STAFF_TYPE[] Query(CauseObject_HEM_B_STAFF_TYPE cause, PagingParamter paging, OrderByParameter order)
        {
            return HelperObject_HEM_B_STAFF_TYPE.Query(cause, paging, order);
        }
		
	}
}
