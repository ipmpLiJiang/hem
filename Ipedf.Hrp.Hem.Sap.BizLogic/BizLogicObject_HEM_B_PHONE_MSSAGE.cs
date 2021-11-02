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
using System.Management;
using System.Configuration;

namespace Ipedf.Hrp.Hem.Sap.BizLogic
{
    public class BizLogicObject_HEM_B_PHONE_MSSAGE : BizLogicBase<EntityObject_HEM_B_PHONE_MSSAGE>, ServiceContract_HEM_B_PHONE_MSSAGE
    {
        public BizLogicObject_HEM_B_PHONE_MSSAGE() { }

        private static ServiceContract_HEM_B_PHONE_MSSAGE singleton;
        public static ServiceContract_HEM_B_PHONE_MSSAGE Proxy
        {
            get 
            {
                if (singleton == null) singleton = new BizLogicObject_HEM_B_PHONE_MSSAGE();
                    return singleton;
            }
        }

        public BizLogicMsg Delete(CauseObject_HEM_B_PHONE_MSSAGE cuase)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int amount = HelperObject_HEM_B_PHONE_MSSAGE.Delete(cuase, transaction);
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

        public BizLogicMsg Delete(EntityObject_HEM_B_PHONE_MSSAGE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int amount = HelperObject_HEM_B_PHONE_MSSAGE.Delete(obj, transaction);
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

        public BizLogicMsg Save(EntityObject_HEM_B_PHONE_MSSAGE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_PHONE_MSSAGE.Save(obj, transaction);
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

        public BizLogicMsg CommitUpdate(EntityObject_HEM_B_PHONE_MSSAGE[] saveEntities, EntityObject_HEM_B_PHONE_MSSAGE[] updateEntities)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        foreach (EntityObject_HEM_B_PHONE_MSSAGE sEntity in saveEntities)
                        {
                            int amount = HelperObject_HEM_B_PHONE_MSSAGE.Save(sEntity, transaction);
                        }

                        foreach (EntityObject_HEM_B_PHONE_MSSAGE uEntity in updateEntities)
                        {
                            int amount = HelperObject_HEM_B_PHONE_MSSAGE.Update(uEntity, transaction);
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

        public BizLogicMsg SaveUpdate(EntityObject_HEM_B_PHONE_MSSAGE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_PHONE_MSSAGE.Save(obj, transaction);
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

        public BizLogicMsg Update(EntityObject_HEM_B_PHONE_MSSAGE obj)
        {
            BizLogicMsg msg = new BizLogicMsg();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {

                    try
                    {
                        int amount = HelperObject_HEM_B_PHONE_MSSAGE.Update(obj, transaction);
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

        public DisplayObject_HEM_B_PHONE_MSSAGE[] Query(CauseObject_HEM_B_PHONE_MSSAGE cause)
        {
            return HelperObject_HEM_B_PHONE_MSSAGE.Query(cause);
        }

        public DisplayObject_HEM_B_PHONE_MSSAGE[] Query(CauseObject_HEM_B_PHONE_MSSAGE cause, PagingParamter paging, OrderByParameter order)
        {
            return HelperObject_HEM_B_PHONE_MSSAGE.Query(cause, paging,order);
        }

        public string SendMessage(string strPhone,string MAC,string content)
        {
            string msg = "";
            try
            {
                string ACCOUNT = ConfigurationManager.AppSettings["Account"].ToString();
                string PASSWORD = ConfigurationManager.AppSettings["Password"].ToString();
                string URL = ConfigurationManager.AppSettings["ServiceUrl"].ToString();
                string FC = ConfigurationManager.AppSettings["MsCode"].ToString();
                if (!string.IsNullOrEmpty(ACCOUNT) && !string.IsNullOrEmpty(PASSWORD) && !string.IsNullOrEmpty(URL) && !string.IsNullOrEmpty(FC))
                {
                    //string userName = entityService.ACCOUNT;
                    //string userPassword = entityService.PASSWORD;
                    //string userMAC = MAC;
                    //string smsCode = entityService.FC;
                    //string mobile = strPhone;
                    string[] args = new string[6];
                    args[0] = ACCOUNT;
                    args[1] = PASSWORD;
                    args[2] = MAC;
                    args[3] = FC;
                    args[4] = strPhone;
                    args[5] = content;
                    object result = WebServiceHelper.InvokeWebService(URL, "service", args);
                    msg = result.ToString();
                    //smsServicePortTypeClient msm = new smsServicePortTypeClient();
                    //msg = msm.service(userName, userPassword, userMAC, smsCode, mobile, content);
                    if (msg == "0")
                    {
                        msg = "发送成功";
                    }
                    else if (msg == "1")
                    {
                        msg = "授权认证失败，您的授权发送用户名或授权发送密码错误";
                    }
                    else if (msg == "2")
                    {
                        msg = "PS标识错误";
                    }
                    else if (msg == "3")
                    {
                        msg = "发送错误，请检查发送内容合法性";
                    }
                    else
                    {
                        msg = "发送错误";
                    }
                }
                else
                {
                    msg = "发送错误,请联系管理员！";
                }
            }catch(Exception ex)
            {
                return ex.Message;
            }

            return msg;

        }

        public string GetMac()
        {
            string MAC = "";
            System.Management.ManagementClass MC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection MOC = MC.GetInstances();
            foreach (ManagementObject moc in MOC)
            {
                if (moc["IPEnabled"].ToString() == "True")
                {
                    MAC = moc["MacAddress"].ToString();
                }
            }
            return MAC;
        }

        public BizLogicMsg PhoneMsg(EntityObject_HEM_B_STAFF_APPLY[] itemEntity, string Content)
        {
            BizLogicMsg msg = new BizLogicMsg();
            msg.Succeed = true;
            CauseObject_V_HEM_B_STAFF_APPLY cause = new CauseObject_V_HEM_B_STAFF_APPLY();
            foreach (EntityObject_HEM_B_STAFF_APPLY entity in itemEntity)
            {
                cause.SetINValue("ID", entity.ID);
            }

            //cause.SetCustomCondition(" AND V_HEM_B_STAFF_APPLY.MSSAGE_ID IS NULL");
            DisplayObject_V_HEM_B_STAFF_APPLY[] itemHSP = BizLogicObject_V_HEM_B_STAFF_APPLY.Proxy.Query(cause);
            if (itemHSP.Length > 0)
            {
                //EntityObject_V_HEM_B_STAFF_APPLY[] itemVSave = itemHSP.Where(p => string.IsNullOrEmpty(p.MSSAGE_ID)).ToArray();
                //EntityObject_V_HEM_B_STAFF_APPLY[] itemVUpdate = itemHSP.Where(p => !string.IsNullOrEmpty(p.MSSAGE_ID)).ToArray();
                
                EntityObject_HEM_B_PHONE_MSSAGE[] itemPmUpdate = new EntityObject_HEM_B_PHONE_MSSAGE[0];
                List<EntityObject_HEM_B_PHONE_MSSAGE> listPmSave = new List<EntityObject_HEM_B_PHONE_MSSAGE>();
                string SendID = Guid.NewGuid().ToString();
                string Mac = BizLogicObject_HEM_B_PHONE_MSSAGE.Proxy.GetMac();
                string content = Content;
                if (!string.IsNullOrEmpty(content))
                {
                    if (content.Length < 280)
                    {
                        List<string> listPhone = new List<string>();
                        for (int i = 0; i < itemHSP.Length; i++)
                        {
                            if (!listPhone.Contains(itemHSP[i].USRID_TEL))
                            {
                                listPhone.Add(itemHSP[i].USRID_TEL);
                                EntityObject_HEM_B_PHONE_MSSAGE entitySave = new EntityObject_HEM_B_PHONE_MSSAGE();
                                entitySave.APPLY_ID = itemHSP[i].ID;
                                entitySave.STATUS = 3;
                                entitySave.IS_SEND = 0;
                                entitySave.SEND_ID = SendID;
                                entitySave.SEND_PHONE = itemHSP[i].USRID_TEL;
                                entitySave.MAC = Mac;
                                entitySave.APPLY_STATUS = itemHSP[i].STATUS;
                                entitySave.CONTENT = content + " 确认请回复 1;";
                                entitySave.SEND_TIME = DateTime.Now;
                                listPmSave.Add(entitySave);
                            }
                        }

                        listPhone.Clear();
                        EntityObject_HEM_B_PHONE_MSSAGE[] itemPmSave = new EntityObject_HEM_B_PHONE_MSSAGE[0];
                        if (listPmSave.Count > 0)
                        {
                            itemPmSave = listPmSave.ToArray();
                        }
                        msg = BizLogicObject_HEM_B_PHONE_MSSAGE.Proxy.CommitUpdate(itemPmSave, itemPmUpdate);
                    }
                    else
                    {
                        msg.Message = "短信息内容不能大于280个字！";
                        msg.Succeed = false;
                    }
                }
                else
                {
                    msg.Message = "短信息内容不能为空！";
                    msg.Succeed = false;
                }
            }
            else
            {
                msg.Message = "未查询到有效的信息！";
                msg.Succeed = false;
            }
            return msg;
        }

        public BizLogicMsg PhoneMsg(CauseObject_V_HEM_B_STAFF_APPLY cause, string Content)
        {
            BizLogicMsg msg = new BizLogicMsg();
            msg.Succeed = true;

            DisplayObject_V_HEM_B_STAFF_APPLY[] itemHSP = BizLogicObject_V_HEM_B_STAFF_APPLY.Proxy.Query(cause);
            if (itemHSP.Length > 0)
            {
                //EntityObject_V_HEM_B_STAFF_APPLY[] itemVSave = itemHSP.Where(p => string.IsNullOrEmpty(p.MSSAGE_ID)).ToArray();
                //EntityObject_V_HEM_B_STAFF_APPLY[] itemVUpdate = itemHSP.Where(p => !string.IsNullOrEmpty(p.MSSAGE_ID)).ToArray();
                
                EntityObject_HEM_B_PHONE_MSSAGE[] itemPmUpdate = new EntityObject_HEM_B_PHONE_MSSAGE[0];
                List<EntityObject_HEM_B_PHONE_MSSAGE> listPmSave = new List<EntityObject_HEM_B_PHONE_MSSAGE>();
                string SendID = Guid.NewGuid().ToString();
                string Mac = BizLogicObject_HEM_B_PHONE_MSSAGE.Proxy.GetMac();
                string content = Content;
                if (!string.IsNullOrEmpty(content))
                {
                    if (content.Length < 280)
                    {
                        List<string> listPhone = new List<string>();
                        for (int i = 0; i < itemHSP.Length; i++)
                        {
                            if (!listPhone.Contains(itemHSP[i].USRID_TEL))
                            {
                                //var smg=SendMessage(itemHSP[i].USRID_TEL, Mac, content + " 确认请回复 1;");
                                listPhone.Add(itemHSP[i].USRID_TEL);
                                EntityObject_HEM_B_PHONE_MSSAGE entitySave = new EntityObject_HEM_B_PHONE_MSSAGE();
                                entitySave.APPLY_ID = itemHSP[i].ID;
                                entitySave.STATUS = 3;
                                entitySave.IS_SEND = 0;
                                entitySave.SEND_ID = SendID;
                                entitySave.SEND_PHONE = itemHSP[i].USRID_TEL;
                                entitySave.MAC = Mac;
                                entitySave.APPLY_STATUS = itemHSP[i].STATUS;
                                entitySave.CONTENT = content + " 确认请回复 1;";
                                entitySave.SEND_TIME = DateTime.Now;
                                listPmSave.Add(entitySave);
                                
                            }
                        }
                        listPhone.Clear();
                        EntityObject_HEM_B_PHONE_MSSAGE[] itemPmSave = new EntityObject_HEM_B_PHONE_MSSAGE[0];
                        if (listPmSave.Count > 0)
                        {
                            itemPmSave = listPmSave.ToArray();
                        }
                        msg = BizLogicObject_HEM_B_PHONE_MSSAGE.Proxy.CommitUpdate(itemPmSave, itemPmUpdate);
                    }
                    else
                    {
                        msg.Message = "短信息内容不能大于280个字！";
                        msg.Succeed = false;
                    }
                }
                else
                {
                    msg.Message = "短信息内容不能为空！";
                    msg.Succeed = false;
                }
            }
            else
            {
                msg.Message = "未查询到有效的信息！";
                msg.Succeed = false;
            }
            return msg;
        }

    }
}
