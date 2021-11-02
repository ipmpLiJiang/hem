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
using SAP.Middleware.Connector;

namespace Ipedf.Hrp.Hem.Sap.BizLogic
{
    public class BizLogicObject_HEM_SAP : ServiceContract_HEM_SAP
    {
        public BizLogicObject_HEM_SAP() { }

        private static ServiceContract_HEM_SAP singleton;
        public static ServiceContract_HEM_SAP Proxy
        {
            get
            {
                if (singleton == null) singleton = new BizLogicObject_HEM_SAP();
                return singleton;
            }
        }
        /*
        public List<string> GetSAP_RYCG(string GRDAT)
        {
            BizLogicMsg msg = new BizLogicMsg();
            RfcDestination destination = this.GetDestination();

            RfcRepository rfcrep = destination.Repository;
            IRfcFunction myfun = null;
            myfun = rfcrep.CreateFunction("ZHR00_FM_RYCG");
            myfun.SetValue("GRDAT", GRDAT);

            myfun.Invoke(destination);//执行
            IRfcTable rfcReturn = myfun.GetTable("T_RYCG");
            List<string> list = new List<string>();
            string NACHN = "";
            for (int i = 0; i < rfcReturn.Count; i++)
            {
                rfcReturn.CurrentIndex = i;
                NACHN = rfcReturn.GetString("PERNR") + "-" + rfcReturn.GetString("NACHN");
                list.Add(NACHN);
                NACHN = "";
            }
            return list;
        }

        public List<string> GetSAP_YGGZT(string No, string C, string FC)
        {
            BizLogicMsg msg = new BizLogicMsg();
            RfcDestination destination = this.GetDestination();

            RfcRepository rfcrep = destination.Repository;
            IRfcFunction myfun = null;
            myfun = rfcrep.CreateFunction("ZHR00_FM_YGGZT");
            myfun.SetValue("PERNR", No);
            myfun.SetValue("ABKRS", C);
            myfun.SetValue("INPER", FC);

            myfun.Invoke(destination);//执行
            IRfcTable rfcReturn = myfun.GetTable("T_GZT");
            List<string> list = new List<string>();
            string NACHN = "";
            for (int i = 0; i < rfcReturn.Count; i++)
            {
                rfcReturn.CurrentIndex = i;
                NACHN = rfcReturn.GetString("NACHN");
                list.Add(NACHN);
                NACHN = "";
            }
            return list;
        }*/
        public BizLogicMsg ChannelSAP(CauseObject_HEM_B_STAFF cause)
        {
            BizLogicMsg msg = new BizLogicMsg();
            return msg;
        }
            /*
            public BizLogicMsg ChannelSAP(CauseObject_HEM_B_STAFF cause)
            {
                BizLogicMsg msg = new BizLogicMsg();
                //BizLogicObject_HEM_B_STAFF biz_Staff = new BizLogicObject_HEM_B_STAFF();
                DisplayObject_HEM_B_STAFF[] itemStaff = HelperObject_HEM_B_STAFF.Query(cause);
                CauseObject_HEM_B_STAFF_EDUCATION causeStaff_Education = new CauseObject_HEM_B_STAFF_EDUCATION();
                CauseObject_HEM_B_STAFF_ESSAY causeStaff_Essay = new CauseObject_HEM_B_STAFF_ESSAY();
                CauseObject_HEM_B_STAFF_PROJECT causeStaff_Project = new CauseObject_HEM_B_STAFF_PROJECT();
                CauseObject_HEM_B_STAFF_WORK causeStaff_Work = new CauseObject_HEM_B_STAFF_WORK();

                //int result = 0;
                RfcDestination destination = this.GetDestination();

                RfcRepository rfcrep = destination.Repository;
                IRfcFunction myfun = null;

                myfun = rfcrep.CreateFunction("ZHR00_FM_ZPXX");
                //myfun.SetValue("", "");
                //myfun.SetValue("", "");
                //员工信息
                IRfcTable IrfTable_T_ZPJC = myfun.GetTable("T_ZPJC");

                foreach (DisplayObject_HEM_B_STAFF entityStaff in itemStaff)
                {
                    IrfTable_T_ZPJC.Insert();
                    IrfTable_T_ZPJC.CurrentRow.SetValue("STAFFID", entityStaff.ID);
                    IrfTable_T_ZPJC.CurrentRow.SetValue("NACHN", entityStaff.NACHN); //姓名1
                    IrfTable_T_ZPJC.CurrentRow.SetValue("GESCH", entityStaff.GESCH); //性别1
                    if (entityStaff.GBDAT != null && entityStaff.GBDAT != ConstLibrary.Template.UndefineDatetime)
                    {
                        IrfTable_T_ZPJC.CurrentRow.SetValue("GBDAT", entityStaff.GBDAT.ToString("yyyyMMdd")); //-出生日期1
                    }
                    IrfTable_T_ZPJC.CurrentRow.SetValue("ICNUM", entityStaff.ICNUM);//身份证号1
                    IrfTable_T_ZPJC.CurrentRow.SetValue("ZHRJG", entityStaff.ZHRJG);//籍贯1
                    IrfTable_T_ZPJC.CurrentRow.SetValue("ZHRGRSG", entityStaff.ZHRGRSG);//身高(CM)1
                    IrfTable_T_ZPJC.CurrentRow.SetValue("ZHRGRTZ", entityStaff.ZHRGRTZ);//体重(斤)1
                    IrfTable_T_ZPJC.CurrentRow.SetValue("ZHRJKZK", entityStaff.ZHRJKZK);//健康状况1
                    IrfTable_T_ZPJC.CurrentRow.SetValue("ZHRYRXX", entityStaff.ZHRYRXX);//血型1
                    IrfTable_T_ZPJC.CurrentRow.SetValue("RACKY", entityStaff.RACKY);//民族1
                    //IrfTable_T_ZPJC.CurrentRow.SetValue("ZHRFZDJ", entityStaff.ZHRFZDJ);//是否服从调剂
                    IrfTable_T_ZPJC.CurrentRow.SetValue("PCODE", entityStaff.PCODE);//政治面貌1
                    IrfTable_T_ZPJC.CurrentRow.SetValue("FAMST", entityStaff.FAMST);//婚姻状况1
                    IrfTable_T_ZPJC.CurrentRow.SetValue("ANZKD", entityStaff.ANZKD);//子女个数1
                    IrfTable_T_ZPJC.CurrentRow.SetValue("ZHRWYSP", entityStaff.ZHRWYSP);//外语水平1
                    IrfTable_T_ZPJC.CurrentRow.SetValue("ZHRWYFS", entityStaff.ZHRWYFS);//外语水平分数1
                    IrfTable_T_ZPJC.CurrentRow.SetValue("ZHRJSJSP", entityStaff.ZHRJSJSP);//计算机水平1
                    IrfTable_T_ZPJC.CurrentRow.SetValue("USRID_TEL", entityStaff.USRID_TEL);//手机号码1
                    IrfTable_T_ZPJC.CurrentRow.SetValue("LOCAT_JT", entityStaff.LOCAT_JT);//家庭住址1
                    IrfTable_T_ZPJC.CurrentRow.SetValue("LOCAT_HJ", entityStaff.LOCAT_HJ);//户籍地址1
                    IrfTable_T_ZPJC.CurrentRow.SetValue("LOCAT_XJ", entityStaff.LOCAT_XJ);//现居住地1
                    IrfTable_T_ZPJC.CurrentRow.SetValue("FANAM", entityStaff.FANAM);//紧急联络人1
                    IrfTable_T_ZPJC.CurrentRow.SetValue("FASEX", entityStaff.FASEX);//紧急联络人性别1
                    if (entityStaff.FGBDT != null && entityStaff.FGBDT != ConstLibrary.Template.UndefineDatetime)
                    {
                        IrfTable_T_ZPJC.CurrentRow.SetValue("FGBDT", entityStaff.FGBDT.ToString("yyyyMMdd"));//紧急联络人出生日期1
                    }
                    IrfTable_T_ZPJC.CurrentRow.SetValue("USRID_MAIL", entityStaff.USRID_MAIL);//电子信箱1
                    //IrfTable_T_ZPJC.CurrentRow.SetValue("ZHRZWJS", entityStaff.ZHRZWJS);//自我介绍
                    IrfTable_T_ZPJC.CurrentRow.SetValue("ZHRDH", entityStaff.TELNR);//紧急联系人电话

                    causeStaff_Education.SetINValue("STAFF_ID", entityStaff.ID);
                    causeStaff_Essay.SetINValue("STAFF_ID", entityStaff.ID);
                    causeStaff_Project.SetINValue("STAFF_ID", entityStaff.ID);
                    causeStaff_Work.SetINValue("STAFF_ID", entityStaff.ID);
                }
                myfun.SetValue("T_ZPJC", IrfTable_T_ZPJC);

                //员工学历
                DisplayObject_HEM_B_STAFF_EDUCATION[] itemEducation = HelperObject_HEM_B_STAFF_EDUCATION.Query(causeStaff_Education);
                //string strSLART = "";
                //if (itemEducation.Length > 0)
                //{
                //    itemEducation = itemEducation.OrderBy(p => p.SLART).ToArray();
                //    strSLART = itemEducation[0].SLART;
                //}
                IRfcTable IrfTable_T_RYXL = myfun.GetTable("T_ZPJY");
                foreach (DisplayObject_HEM_B_STAFF_EDUCATION entityEducation in itemEducation)
                {
                    IrfTable_T_RYXL.Insert();
                    IrfTable_T_RYXL.CurrentRow.SetValue("STAFFID", entityEducation.STAFF_ID);
                    IrfTable_T_RYXL.CurrentRow.SetValue("INSTI", entityEducation.INSTI); //学校名称
                    if (entityEducation.BEGDA != null && entityEducation.BEGDA != ConstLibrary.Template.UndefineDatetime)
                    {
                        IrfTable_T_RYXL.CurrentRow.SetValue("BEGDA", entityEducation.BEGDA.ToString("yyyyMMdd")); //开始日期
                    }
                    if (entityEducation.ENDDA != null && entityEducation.ENDDA != ConstLibrary.Template.UndefineDatetime)
                    {
                        IrfTable_T_RYXL.CurrentRow.SetValue("ENDDA", entityEducation.ENDDA.ToString("yyyyMMdd")); //-结束日期
                    }
                    IrfTable_T_RYXL.CurrentRow.SetValue("SLART", entityEducation.SLART);//学历
                    IrfTable_T_RYXL.CurrentRow.SetValue("ZHRDSXM", entityEducation.ZHRDSXM);//导师
                    IrfTable_T_RYXL.CurrentRow.SetValue("ZHRXKZY1", entityEducation.ZHRXKZY1);//学科专业1
                    IrfTable_T_RYXL.CurrentRow.SetValue("ZHRXKZY2", entityEducation.ZHRXKZY2);//学科专业2
                    IrfTable_T_RYXL.CurrentRow.SetValue("ZHRXYJFX", entityEducation.ZHRXYJFX);//研究方向
                    IrfTable_T_RYXL.CurrentRow.SetValue("ZHRSFZGXL", entityEducation.IS_HIGHEST == 1 ? "X" : "");//是否最高
                    //if (strSLART == entityEducation.SLART)
                    //{
                    //    IrfTable_T_RYXL.CurrentRow.SetValue("ZHRSFZGXL", "X");//是否最高
                    //}
                    //else
                    //{
                    //    IrfTable_T_RYXL.CurrentRow.SetValue("ZHRSFZGXL", "");//是否最高
                    //}
                }

                myfun.SetValue("T_ZPJY", IrfTable_T_RYXL);

                //员工项目
                DisplayObject_HEM_B_STAFF_PROJECT[] itemProject = HelperObject_HEM_B_STAFF_PROJECT.Query(causeStaff_Project);
                IRfcTable IrfTable_T_RYXM = myfun.GetTable("T_ZPXM");
                foreach (DisplayObject_HEM_B_STAFF_PROJECT entityProject in itemProject)
                {
                    IrfTable_T_RYXM.Insert();
                    IrfTable_T_RYXM.CurrentRow.SetValue("STAFFID", entityProject.STAFF_ID);
                    if (entityProject.BEGDA != null && entityProject.BEGDA != ConstLibrary.Template.UndefineDatetime)
                    {
                        IrfTable_T_RYXM.CurrentRow.SetValue("BEGDA", entityProject.BEGDA.ToString("yyyyMMdd")); //开始日期
                    }
                    if (entityProject.ENDDA != null && entityProject.ENDDA != ConstLibrary.Template.UndefineDatetime)
                    {
                        IrfTable_T_RYXM.CurrentRow.SetValue("ENDDA", entityProject.ENDDA.ToString("yyyyMMdd")); //-结束日期
                    }
                    IrfTable_T_RYXM.CurrentRow.SetValue("ZHRXMMC", entityProject.ZHRXMMC); //项目名称
                    IrfTable_T_RYXM.CurrentRow.SetValue("ZHRXMLBLY", entityProject.ZHRXMLBLY);//项目类别_来源
                    IrfTable_T_RYXM.CurrentRow.SetValue("ZHRXMJF", entityProject.ZHRXMJF);//经费(万)
                    IrfTable_T_RYXM.CurrentRow.SetValue("ZHRXMPM", entityProject.ZHRXMPM);//本人排名
                }

                myfun.SetValue("T_ZPXM", IrfTable_T_RYXM);

                //员工文章
                DisplayObject_HEM_B_STAFF_ESSAY[] itemEssay = HelperObject_HEM_B_STAFF_ESSAY.Query(causeStaff_Essay);
                IRfcTable IrfTable_T_RYWZ = myfun.GetTable("T_ZPWZ");
                foreach (DisplayObject_HEM_B_STAFF_ESSAY entityEssay in itemEssay)
                {
                    IrfTable_T_RYWZ.Insert();
                    IrfTable_T_RYWZ.CurrentRow.SetValue("STAFFID", entityEssay.STAFF_ID);
                    IrfTable_T_RYWZ.CurrentRow.SetValue("ZHRWZMC", entityEssay.ZHRWZMC); //文章名称
                    if (entityEssay.BEGDA != null && entityEssay.BEGDA != ConstLibrary.Template.UndefineDatetime)
                    {
                        IrfTable_T_RYWZ.CurrentRow.SetValue("BEGDA", entityEssay.BEGDA.ToString("yyyyMMdd")); //出版时间
                    }
                    IrfTable_T_RYWZ.CurrentRow.SetValue("ZHRCBKW", entityEssay.ZHRCBKW); //-出版刊物
                    IrfTable_T_RYWZ.CurrentRow.SetValue("ZHRFBZT", entityEssay.ZHRFBZT);//发布状态
                    IrfTable_T_RYWZ.CurrentRow.SetValue("ZHRCBKH", entityEssay.ZHRCBKH);//刊号
                    IrfTable_T_RYWZ.CurrentRow.SetValue("ZHRKWJB", entityEssay.ZHRKWJB);//刊物级别
                    IrfTable_T_RYWZ.CurrentRow.SetValue("ZHRYXYZ", entityEssay.ZHRYXYZ);//影响因子
                    IrfTable_T_RYWZ.CurrentRow.SetValue("ZHRBRMP", entityEssay.ZHRBRMP);//本人排名
                }

                myfun.SetValue("T_ZPWZ", IrfTable_T_RYWZ);

                //员工工作经历
                DisplayObject_HEM_B_STAFF_WORK[] itemWork = HelperObject_HEM_B_STAFF_WORK.Query(causeStaff_Work);
                IRfcTable IrfTable_T_RYJL = myfun.GetTable("T_ZPJL");
                foreach (DisplayObject_HEM_B_STAFF_WORK entityWork in itemWork)
                {
                    IrfTable_T_RYJL.Insert();
                    IrfTable_T_RYJL.CurrentRow.SetValue("STAFFID", entityWork.STAFF_ID);
                    IrfTable_T_RYJL.CurrentRow.SetValue("ZHRXXDW", entityWork.ZHRXXDW); //学校_单位
                    if (entityWork.BEGDA != null && entityWork.BEGDA != ConstLibrary.Template.UndefineDatetime)
                    {
                        IrfTable_T_RYJL.CurrentRow.SetValue("BEGDA", entityWork.BEGDA.ToString("yyyyMMdd")); //开始日期
                    }
                    if (entityWork.ENDDA != null && entityWork.ENDDA != ConstLibrary.Template.UndefineDatetime)
                    {
                        IrfTable_T_RYJL.CurrentRow.SetValue("ENDDA", entityWork.ENDDA.ToString("yyyyMMdd")); //-结束日期
                    }
                    IrfTable_T_RYJL.CurrentRow.SetValue("SLART", entityWork.SLART);//学历/学位
                    IrfTable_T_RYJL.CurrentRow.SetValue("ZHRZYBM", entityWork.ZHRZYBM);//专业_部门
                    IrfTable_T_RYJL.CurrentRow.SetValue("ZHRGZZW", entityWork.ZHRGZZW);//职务
                }

                myfun.SetValue("T_ZPJL", IrfTable_T_RYJL);

                //提前实例化一个空的表结构出来
                try
                {
                    myfun.Invoke(destination);//执行
                    object objRet = myfun.GetValue("ZMESSAGE");
                    if (objRet.ToString() == "成功")
                    {
                        msg.Succeed = true;
                        msg.Message = objRet.ToString();
                    }
                    else
                    {
                        msg.Succeed = false;
                        msg.Message = objRet.ToString();
                    }
                }
                catch (Exception ex)
                {
                    msg.Succeed = false;
                    msg.Message = ex.Message;
                }
                return msg;

            }
            */
            public RfcDestination GetDestination()
        {
            //RfcConfigParameters configParams = this.GetConfigParams();
            RfcDestination dest = RfcDestinationManager.GetDestination("ECC");//在Webconfig里面配置
            return dest;

        }
    }
}
