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
    public class BizLogicObject_V_HEM_B_STAFF_APPLY_NPOI : ServiceContract_V_HEM_B_STAFF_APPLY_NPOI
    {
        public BizLogicObject_V_HEM_B_STAFF_APPLY_NPOI() { }

        private static ServiceContract_V_HEM_B_STAFF_APPLY_NPOI singleton;
        public static ServiceContract_V_HEM_B_STAFF_APPLY_NPOI Proxy
        {
            get
            {
                if (singleton == null) singleton = new BizLogicObject_V_HEM_B_STAFF_APPLY_NPOI();
                return singleton;
            }
        }

        public DisplayObject_V_HEM_B_STAFF_APPLY_NPOI[] Query(CauseObject_V_HEM_B_STAFF_APPLY_NPOI cause, PagingParamter paging, OrderByParameter order)
        {
            return HelperObject_V_HEM_B_STAFF_APPLY_NPOI.Query(cause, paging, order);
        }

        public DisplayObject_V_HEM_B_STAFF_APPLY_NPOI[] Query(CauseObject_V_HEM_B_STAFF_APPLY_NPOI cause)
        {
            return HelperObject_V_HEM_B_STAFF_APPLY_NPOI.Query(cause);
        }

        public DataSet Query_Npoi(CauseObject_V_HEM_B_STAFF_APPLY_NPOI cause, string TypeNo, bool IsYs)
        {
            DataSet ds = new DataSet();
            DataTable dtYs = new DataTable();
            DataTable dtYjs = new DataTable();
            DataTable dtWjs = new DataTable();
            DataTable dtYnsx = new DataTable();
            DataTable dtYwsx = new DataTable();
            DataTable dtPqz = new DataTable();

            if (TypeNo == "All" || TypeNo == "YJS")
            {
                dtYjs = getDtYjs();
            }
            if (TypeNo == "All" || TypeNo == "1001")
            {
                dtYnsx = getDtYnsx();
            }
            if (TypeNo == "All" || TypeNo == "1002")
            {
                dtYwsx = getDtYwsx();
            }
            if (TypeNo == "All" || TypeNo == "1003")
            {
                dtWjs = getDtWjs();
            }
            if (TypeNo == "1004" || IsYs)
            {
                dtYs = getDtYs();
            }

            //if (TypeNo == "PQZ" || TypeNo == "1005" || TypeNo == "All")
            //{
            //    dtPqz = getDtYwsx();
            //    dtPqz.TableName = "T6";
            //}
            
            DisplayObject_V_HEM_B_STAFF_APPLY_NPOI[] itemDisplay = HelperObject_V_HEM_B_STAFF_APPLY_NPOI.Query(cause);
            int nCount1 = 1;
            int nCount2 = 1;
            int nCount3 = 1;
            int nCount4 = 1;
            int nCount5 = 1;
            string sBEGDA = "";
            string sENDDA = "";
            DateTime dtDate = new DateTime();
            foreach (DisplayObject_V_HEM_B_STAFF_APPLY_NPOI display in itemDisplay)
            {
                sBEGDA = "";
                sENDDA = "";
                dtDate = new DateTime();

                if (TypeNo == "All" || TypeNo == "YJS")
                {
                    if (display.SF_SS_EDUCATION_SLART == "11" && display.TYPE_ID !="1004")
                    {
                        DataRow newRowYjs = dtYjs.NewRow();
                        newRowYjs["NO"] = nCount1.ToString();//1序号
                        newRowYjs["NACHN"] = display.NACHN;//2姓名
                        newRowYjs["SF_BK_EDUCATION_ENDDA"] = display.SF_SS_EDUCATION_ENDDA;//3硕士毕业日期
                        newRowYjs["SEX"] = display.SEX;//4性别
                        newRowYjs["GBDAT"] = display.GBDAT.ToString("yyyy-MM-dd");//5出生日期
                        newRowYjs["ICNUM"] = display.ICNUM;//身份证号
                        newRowYjs["ZHRGRSG"] = display.ZHRGRSG;//6身高(CM)
                        newRowYjs["DT_HH_EDUCATION_NAME"] = display.DT_HH_EDUCATION_NAME;//7最高学历
                        newRowYjs["DT_ZG_TYPE_NAME"] = display.DT_ZG_TYPE_NAME;//6最高学历学科类型
                        newRowYjs["SF_HH_EDUCATION_ZHRDSXM"] = display.SF_HH_EDUCATION_ZHRDSXM;//8最高学历导师
                        if (!string.IsNullOrEmpty(display.SF_HH_EDUCATION_INSTI))
                        {
                            newRowYjs["SF_HH_EDUCATION_INSTI"] = display.SF_HH_EDUCATION_INSTI + "(" + display.SF_HH_EDUCATION_ZHRXKZY1 + ")";//9最高学历学校
                        }
                        else
                        {
                            newRowYjs["SF_HH_EDUCATION_INSTI"] = "";
                        }
                        if (!string.IsNullOrEmpty(display.SF_BK_EDUCATION_INSTI))
                        {
                            newRowYjs["SF_BK_EDUCATION_INSTI"] = display.SF_BK_EDUCATION_INSTI + "(" + display.SF_BK_EDUCATION_ZHRXKZY1 + ")";//10本科学校
                        }
                        else
                        {
                            newRowYjs["SF_BK_EDUCATION_INSTI"] = "";
                        }
                        newRowYjs["ZHRSXXX"] = display.ZHRSXXX;//本科实习医院
                        newRowYjs["YJSSXXX"] = display.YJSSXXX;//研究生实习医院
                        newRowYjs["SF_ZHRWYSP_NAME"] = display.SF_ZHRWYSP_NAME;//11外语水平
                        newRowYjs["SF_ZHRJSJSP_NAME"] = display.SF_ZHRJSJSP_NAME;//12计算机水平
                        newRowYjs["ZHRJG"] = display.ZHRJG;//13籍贯
                        newRowYjs["PCODE_NAME"] = display.PCODE_NAME;//13政治面貌
                        newRowYjs["SF_FAMST_NAME"] = display.SF_FAMST_NAME;//14婚姻状况
                        newRowYjs["REAL_ZHRGRSG"] = display.REAL_ZHRGRSG;//15真实身高
                        newRowYjs["REAL_ZHRGRTZ"] = display.REAL_ZHRGRTZ;//16真实体重
                        newRowYjs["REAL_ZHRSLJZ"] = display.REAL_ZHRSLJZ;//17真实视力
                        newRowYjs["WRITTEN_THEORY"] = display.WRITTEN_THEORY;//18笔试理论成绩
                        newRowYjs["WRITTEN_ENGLISH"] = display.WRITTEN_ENGLISH;//19笔试英语成绩
                        newRowYjs["WRITTEN_SUM"] = "";//20笔试总分
                        newRowYjs["OPERATOR_ONE"] = display.OPERATOR_ONE;//21操作成绩
                        newRowYjs["USRID_TEL"] = display.USRID_TEL;//22手机号码
                        newRowYjs["ZHRWZMC"] = display.ZHRWZMC;//23科研
                        newRowYjs["ZHRTC"] = display.ZHRTC;//24特长
                        newRowYjs["ZHRHJJL"] = display.ZHRHJJL;//25获奖经历
                        newRowYjs["ZHRBZ"] = display.ZHRBZ;//26备注
                        newRowYjs["XLYJ"] = "";//27
                        newRowYjs["USRID_MAIL"] = display.USRID_MAIL;//邮箱
                        newRowYjs["OUTOCEAN"] = display.OUTOCEAN;//用户类型
                        dtYjs.Rows.Add(newRowYjs);

                        nCount1 = nCount1 + 1;
                    }
                }

                if (TypeNo == "All" || TypeNo == "1003")
                {
                    if (display.SF_SS_EDUCATION_SLART != "11" && display.TYPE_ID == "1003")
                    {
                        DataRow newRowWjs = dtWjs.NewRow();
                        newRowWjs["NO"] = nCount2.ToString();//1序号
                        if (!string.IsNullOrEmpty(display.SF_BK_EDUCATION_INSTI))
                        {
                            newRowWjs["SF_BK_EDUCATION_INSTI"] = display.SF_BK_EDUCATION_INSTI + "(" + display.SF_BK_EDUCATION_ZHRXKZY1 + ")";//2本科学校
                        }
                        else
                        {
                            newRowWjs["SF_BK_EDUCATION_INSTI"] = "";
                        }
                        newRowWjs["NACHN"] = display.NACHN;//3姓名
                        newRowWjs["SF_BK_EDUCATION_ENDDA"] = display.SF_BK_EDUCATION_ENDDA;//4本科毕业日期
                        newRowWjs["DT_BK_EDUCATION_NAME"] = display.DT_BK_EDUCATION_NAME;//5本科学历
                        newRowWjs["ZHRJG"] = display.ZHRJG;//6籍贯
                        newRowWjs["PCODE_NAME"] = display.PCODE_NAME;//7政治面貌
                        newRowWjs["RACKY_NAME"] = display.RACKY_NAME;//8民族
                        newRowWjs["GBDAT"] = display.GBDAT.ToString("yyyy-MM-dd");//9出生年月
                        newRowWjs["ICNUM"] = display.ICNUM;//身份证号
                        newRowWjs["ZHRGRSG"] = display.ZHRGRSG;//10身高
                        newRowWjs["SEX"] = display.SEX;//11性别
                        newRowWjs["SF_GZ_EDUCATION_INSTI"] = display.SF_GZ_EDUCATION_INSTI;//12高中学校
                        newRowWjs["ZHRTZGG"] = display.ZHRTZGG;//13高考成绩
                        newRowWjs["SF_ZHRWYSP_NAME"] = display.SF_ZHRWYSP_NAME;//14外语水平
                        newRowWjs["SF_ZHRJSJSP_NAME"] = display.SF_ZHRJSJSP_NAME;//15计算机水平
                        newRowWjs["SF_WORK_YJ_ZHRXXDW"] = display.SF_WORK_YJ_ZHRXXDW;//16工作医院
                        newRowWjs["YJ_ZHRGZNX"] = display.YJ_ZHRGZNX;//17三级甲等医院工作年限
                        newRowWjs["ZHRBZ"] = display.ZHRBZ;//18备注
                        newRowWjs["ZHRTC"] = display.ZHRTC;//19特长
                        newRowWjs["USRID_TEL"] = display.USRID_TEL;//20手机号码
                        newRowWjs["REAL_ZHRGRSG"] = display.REAL_ZHRGRSG;//21真实身高
                        newRowWjs["REAL_ZHRGRTZ"] = display.REAL_ZHRGRTZ;//22真实体重
                        newRowWjs["REAL_ZHRSLJZ"] = display.REAL_ZHRSLJZ;//23真实视力
                        newRowWjs["WRITTEN_THEORY"] = display.WRITTEN_THEORY;//24笔试理论成绩
                        newRowWjs["WRITTEN_ENGLISH"] = display.WRITTEN_ENGLISH;//25笔试英语成绩
                        newRowWjs["WRITTEN_SUM"] = "";//26笔试总分
                        newRowWjs["OPERATOR_ONE"] = display.OPERATOR_ONE;//27操作成绩
                        newRowWjs["USRID_MAIL"] = display.USRID_MAIL;//邮箱
                        newRowWjs["OUTOCEAN"] = display.OUTOCEAN;//用户类型
                        newRowWjs["JWBS"] = display.JWBS;//既往病史
                        dtWjs.Rows.Add(newRowWjs);

                        nCount2 = nCount2 + 1;
                    }
                }

                if (TypeNo == "All" || TypeNo == "1001")
                {
                    if (display.SF_SS_EDUCATION_SLART != "11" && display.TYPE_ID == "1001")
                    {
                        DataRow newRowYnsx = dtYnsx.NewRow();
                        newRowYnsx["NO"] = nCount3.ToString();//1序号
                        newRowYnsx["SF_BK_EDUCATION_INSTI"] = display.SF_BK_EDUCATION_INSTI;//2本科学校
                        newRowYnsx["NACHN"] = display.NACHN;//3姓名
                        newRowYnsx["SF_BK_EDUCATION_ENDDA"] = display.SF_BK_EDUCATION_ENDDA;//4本科毕业日期
                        newRowYnsx["DT_BK_EDUCATION_NAME"] = display.DT_BK_EDUCATION_NAME;//5本科学历
                        newRowYnsx["SF_BK_EDUCATION_ZHRXKZY1"] = display.SF_BK_EDUCATION_ZHRXKZY1;//6本科专业
                        newRowYnsx["PCODE_NAME"] = display.PCODE_NAME;//7政治面貌
                        newRowYnsx["ZHRJG"] = display.ZHRJG;//8籍贯
                        newRowYnsx["RACKY_NAME"] = display.RACKY_NAME;//民族
                        newRowYnsx["GBDAT"] = display.GBDAT.ToString("yyyy-MM-dd");//9出生年月
                        newRowYnsx["ICNUM"] = display.ICNUM;//身份证号
                        newRowYnsx["ZHRGRSG"] = display.ZHRGRSG;//10身高
                        newRowYnsx["ZHRGRTZ"] = display.ZHRGRTZ;//11体重
                        newRowYnsx["SEX"] = display.SEX;//12性别
                        newRowYnsx["ZHRSLJZ"] = display.ZHRSLJZ;//13视力
                        newRowYnsx["SF_GZ_EDUCATION_INSTI"] = display.SF_GZ_EDUCATION_INSTI;//14高中学校
                        newRowYnsx["ZHRTZGG"] = display.ZHRTZGG;//15高考成绩
                        newRowYnsx["SF_ZHRWYSP_NAME"] = display.SF_ZHRWYSP_NAME;//16外语水平
                        newRowYnsx["SF_ZHRJSJSP_NAME"] = display.SF_ZHRJSJSP_NAME;//17计算机水平
                        newRowYnsx["ZHRTC"] = display.ZHRTC;//18特长
                        newRowYnsx["ZHRHJJL"] = display.ZHRHJJL;//19获奖经历
                        newRowYnsx["ZHRBZ"] = display.ZHRBZ;//20备注
                        if (!string.IsNullOrEmpty(display.ZHRSXXX))
                        {
                            newRowYnsx["SF_WORK_SX_ZHRXXDW"] = display.ZHRSXXX;
                        }
                        else
                        {
                            newRowYnsx["SF_WORK_SX_ZHRXXDW"] = display.SF_WORK_SX_ZHRXXDW;//21实习医院
                        }
                        newRowYnsx["USRID_TEL"] = display.USRID_TEL;//22手机号码
                        newRowYnsx["REAL_ZHRGRSG"] = display.REAL_ZHRGRSG;//23真实身高
                        newRowYnsx["REAL_ZHRGRTZ"] = display.REAL_ZHRGRTZ;//24真实体重
                        newRowYnsx["REAL_ZHRSLJZ"] = display.REAL_ZHRSLJZ;//25真实视力
                        newRowYnsx["WRITTEN_THEORY"] = display.WRITTEN_THEORY;//26笔试理论成绩
                        newRowYnsx["WRITTEN_ENGLISH"] = display.WRITTEN_ENGLISH;//27笔试英语成绩
                        newRowYnsx["WRITTEN_SUM"] = "";//28笔试总分
                        newRowYnsx["OPERATOR_ONE"] = display.OPERATOR_ONE;//29操作成绩
                        newRowYnsx["USRID_MAIL"] = display.USRID_MAIL;//邮箱
                        newRowYnsx["OUTOCEAN"] = display.OUTOCEAN;//用户类型
                        newRowYnsx["JWBS"] = display.JWBS;//既往病史
                        dtYnsx.Rows.Add(newRowYnsx);
                        nCount3 = nCount3 + 1;
                    }
                }

                if (TypeNo == "All" || TypeNo == "1002")
                {
                    if (display.SF_SS_EDUCATION_SLART != "11" && display.TYPE_ID == "1002")
                    {
                        DataRow newRowYwsx = dtYwsx.NewRow();
                        newRowYwsx["NO"] = nCount4.ToString();//1序号
                        if (!string.IsNullOrEmpty(display.SF_BK_EDUCATION_INSTI))
                        {
                            newRowYwsx["SF_BK_EDUCATION_INSTI"] = display.SF_BK_EDUCATION_INSTI + "(" + display.SF_BK_EDUCATION_ZHRXKZY1 + ")";//2本科学校
                        }
                        else
                        {
                            newRowYwsx["SF_BK_EDUCATION_INSTI"] = "";
                        }
                        newRowYwsx["NACHN"] = display.NACHN;//3姓名
                        newRowYwsx["SF_BK_EDUCATION_ENDDA"] = display.SF_BK_EDUCATION_ENDDA;//4本科毕业日期
                        newRowYwsx["DT_BK_EDUCATION_NAME"] = display.DT_BK_EDUCATION_NAME;//5本科学历
                        newRowYwsx["ZHRJG"] = display.ZHRJG;//6籍贯
                        newRowYwsx["PCODE_NAME"] = display.PCODE_NAME;//7政治面貌
                        newRowYwsx["RACKY_NAME"] = display.RACKY_NAME;//8民族
                        newRowYwsx["GBDAT"] = display.GBDAT.ToString("yyyy-MM-dd");//9出生年月
                        newRowYwsx["ICNUM"] = display.ICNUM;//身份证号
                        newRowYwsx["ZHRGRSG"] = display.ZHRGRSG;//10身高
                        newRowYwsx["SEX"] = display.SEX;//11性别
                        newRowYwsx["SF_GZ_EDUCATION_INSTI"] = display.SF_GZ_EDUCATION_INSTI;//12高中学校
                        newRowYwsx["ZHRTZGG"] = display.ZHRTZGG;//13高考成绩
                        newRowYwsx["SF_ZHRWYSP_NAME"] = display.SF_ZHRWYSP_NAME;//14外语水平
                        newRowYwsx["SF_ZHRJSJSP_NAME"] = display.SF_ZHRJSJSP_NAME;//15计算机水平
                        if (!string.IsNullOrEmpty(display.ZHRSXXX))
                        {
                            newRowYwsx["SF_WORK_SX_ZHRXXDW"] = display.ZHRSXXX;
                        }
                        else
                        {
                            newRowYwsx["SF_WORK_SX_ZHRXXDW"] = display.SF_WORK_SX_ZHRXXDW;//21实习医院
                        }
                        newRowYwsx["SX_ZHRGZNX"] = display.SX_ZHRGZNX;//17实习时长
                        newRowYwsx["ZHRTC"] = display.ZHRTC;//18特长
                        newRowYwsx["USRID_TEL"] = display.USRID_TEL;//19手机号码
                        newRowYwsx["ZHRHJJL"] = display.ZHRHJJL;//20获奖经历
                        newRowYwsx["ZHRBZ"] = display.ZHRBZ;//21备注
                        newRowYwsx["REAL_ZHRGRSG"] = display.REAL_ZHRGRSG;//22真实身高
                        newRowYwsx["REAL_ZHRGRTZ"] = display.REAL_ZHRGRTZ;//23真实体重
                        newRowYwsx["REAL_ZHRSLJZ"] = display.REAL_ZHRSLJZ;//24真实视力
                        newRowYwsx["WRITTEN_THEORY"] = display.WRITTEN_THEORY;//25笔试理论成绩
                        newRowYwsx["WRITTEN_ENGLISH"] = display.WRITTEN_ENGLISH;//26笔试英语成绩
                        newRowYwsx["WRITTEN_SUM"] = "";//27笔试总分
                        newRowYwsx["OPERATOR_ONE"] = display.OPERATOR_ONE;//28操作成绩
                        newRowYwsx["USRID_MAIL"] = display.USRID_MAIL;//邮箱
                        newRowYwsx["OUTOCEAN"] = display.OUTOCEAN;//用户类型
                        newRowYwsx["JWBS"] = display.JWBS;//既往病史
                        dtYwsx.Rows.Add(newRowYwsx);
                        nCount4 = nCount4 + 1;
                    }
                }
                if (TypeNo == "1004" || IsYs)
                {
                    if (display.TYPE_ID == "1004")
                    {
                        DataRow newRowYs = dtYs.NewRow();
                        newRowYs["NO"] = nCount5.ToString();//1编号
                        newRowYs["NACHN"] = display.NACHN;//2姓名
                        newRowYs["SEX"] = display.SEX;//3性别
                        newRowYs["GBDAT"] = display.GBDAT.ToString("yyyy-MM-dd");//4出生年月
                        newRowYs["ICNUM"] = display.ICNUM;//身份证号
                        newRowYs["SF_FAMST_NAME"] = display.SF_FAMST_NAME;//5婚姻状况
                        newRowYs["ZHRJG"] = display.ZHRJG;//籍贯
                        newRowYs["RACKY_NAME"] = display.RACKY_NAME;//民族
                        newRowYs["PCODE_NAME"] = display.PCODE_NAME;//5政治面貌
                        newRowYs["DT_HH_EDUCATION_NAME"] = display.DT_HH_EDUCATION_NAME;//6最高学历
                        newRowYs["DT_ZG_TYPE_NAME"] = display.DT_ZG_TYPE_NAME;//6最高学历学科类型
                        newRowYs["SF_HH_EDUCATION_ZHRXKZY1"] = display.SF_HH_EDUCATION_ZHRXKZY1;//7最高学历专业
                        newRowYs["SF_HH_EDUCATION_ZHRDSXM"] = display.SF_HH_EDUCATION_ZHRDSXM;//8最高学历导师
                        newRowYs["SF_ZHRWYSP_NAME"] = display.SF_ZHRWYSP_NAME;//9外语水平

                        if(!string.IsNullOrEmpty(display.SF_BS_EDUCATION_INSTI))
                        {
                            sBEGDA = display.SF_BS_EDUCATION_BEGDA;
                            if(!string.IsNullOrEmpty(sBEGDA))
                            {
                                dtDate = DateTime.Parse(sBEGDA);
                                sBEGDA = dtDate.ToString("yyyy.MM");
                            }
                            sENDDA = display.SF_BS_EDUCATION_ENDDA;

                            if(!string.IsNullOrEmpty(sENDDA))
                            {
                                dtDate = DateTime.Parse(sENDDA);
                                sENDDA = dtDate.ToString("yyyy.MM");
                            }
                            //dtDate = DateTime.Parse();
                            newRowYs["SF_BS_EDUCATION_INSTI"] = display.SF_BS_EDUCATION_INSTI + "@#" + display.SF_BS_EDUCATION_ZHRXKZY1 +"@#"+ sBEGDA + "-" + sENDDA;//10博士学校
                        }else{
                            newRowYs["SF_BS_EDUCATION_INSTI"] = "";
                        }

                        if(!string.IsNullOrEmpty(sENDDA))
                        {
                            sENDDA = dtDate.ToString("yyyyMMdd");
                            newRowYs["SF_BS_EDUCATION_ENDDA"] = sENDDA;//11博士毕业时间
                        }else
                        {
                            newRowYs["SF_BS_EDUCATION_ENDDA"] = "";//11博士毕业时间
                        }
                        sBEGDA="";
                        sENDDA="";
                        dtDate = new DateTime();

                        if(!string.IsNullOrEmpty(display.SF_SS_EDUCATION_INSTI))
                        {
                            sBEGDA = display.SF_SS_EDUCATION_BEGDA;
                            if(!string.IsNullOrEmpty(sBEGDA))
                            {
                                dtDate = DateTime.Parse(sBEGDA);
                                sBEGDA = dtDate.ToString("yyyy.MM.dd");
                            }
                            sENDDA = display.SF_SS_EDUCATION_ENDDA;

                            if(!string.IsNullOrEmpty(sENDDA))
                            {
                                dtDate = DateTime.Parse(sENDDA);
                                sENDDA = dtDate.ToString("yyyy.MM.dd");
                            }

                            newRowYs["SF_SS_EDUCATION_INSTI"] = display.SF_SS_EDUCATION_INSTI + "@#"  + display.SF_SS_EDUCATION_ZHRXKZY1 + "@#" + sBEGDA + "-" + sENDDA ;//10博士学校
                        }else
                        {
                            newRowYs["SF_SS_EDUCATION_INSTI"] = "";//12硕士学校
                        }

                        sBEGDA = "";
                        sENDDA = "";
                        dtDate = new DateTime();
                        if (!string.IsNullOrEmpty(display.SF_BK_EDUCATION_INSTI))
                        {
                            sBEGDA = display.SF_BK_EDUCATION_BEGDA;
                            if (!string.IsNullOrEmpty(sBEGDA))
                            {
                                dtDate = DateTime.Parse(sBEGDA);
                                sBEGDA = dtDate.ToString("yyyy.MM.dd");
                            }
                            sENDDA = display.SF_BK_EDUCATION_ENDDA;

                            if (!string.IsNullOrEmpty(sENDDA))
                            {
                                dtDate = DateTime.Parse(sENDDA);
                                sENDDA = dtDate.ToString("yyyy.MM.dd");
                            }

                            newRowYs["SF_BK_EDUCATION_INSTI"] = display.SF_BK_EDUCATION_INSTI + "@#" + display.SF_BK_EDUCATION_ZHRXKZY1 + "@#" + sBEGDA + "-" + sENDDA ;//10博士学校
                        }
                        else
                        {
                            newRowYs["SF_BK_EDUCATION_INSTI"] = "";//13本科学校
                        }
                        sBEGDA = "";
                        sENDDA = "";
                        dtDate = new DateTime();
                        newRowYs["BBJH"] = "";//14本部计划
                        newRowYs["XBJH"] = "";//15西院计划
                        newRowYs["DYZY"] = display.FIRSTCHOICE;//16第一志愿
                        newRowYs["DEZY"] = display.SECONDCHOICE;//17第二志愿
                        newRowYs["PRACTICE_TYPE_ID_NAME"] = display.PRACTICE_TYPE_ID_NAME;//17执业类型
                        newRowYs["IS_STANDARD"] = display.IS_STANDARD;//17毕业时是否取得住院医师规范化培训合格证
                        //newRowYs["IS_SZHY"] = display.IS_SZHY;//硕士阶段四证合一
                        newRowYs["ESA"] = display.ESA;//18A
                        newRowYs["ESB"] = display.ESB;//19B
                        newRowYs["ESC"] = display.ESC;//20C
                        newRowYs["EQW"] = display.EQW;//21权威
                        newRowYs["EHX"] = display.EHX;//22核心
                        newRowYs["EYB"] = display.EYB;//23一般
                        newRowYs["ESCI"] = display.ESCI;//24SCI
                        newRowYs["EOTHER"] = display.EOTHER;//25其他
                        newRowYs["KYQK"] = "";//26科研情况
                        newRowYs["QTCG"] = "";//27其他相关成果
                        newRowYs["REMAEK"] = "";//28备注
                        newRowYs["LXYJ"] = "";//29选留意见
                        newRowYs["ZZJG"] = "";//30最终结果
                        newRowYs["SFQY"] = "";//31是否签约
                        newRowYs["USRID_TEL"] = display.USRID_TEL;//32电话
                        newRowYs["BRQZ"] = "";//33本人签字确认
                        newRowYs["REMAEK1"] = "";//34备注1
                        newRowYs["REAL_ZHRGRSG"] = display.REAL_ZHRGRSG;//35真实身高
                        newRowYs["REAL_ZHRGRTZ"] = display.REAL_ZHRGRTZ;//36真实体重
                        newRowYs["REAL_ZHRSLJZ"] = display.REAL_ZHRSLJZ;//37真实视力
                        newRowYs["WRITTEN_THEORY"] = display.WRITTEN_THEORY;//38笔试理论成绩
                        newRowYs["WRITTEN_ENGLISH"] = display.WRITTEN_ENGLISH;//39笔试英语成绩
                        newRowYs["WRITTEN_SUM"] = "";//40笔试总分
                        newRowYs["OPERATOR_ONE"] = display.OPERATOR_ONE;//41操作成绩
                        newRowYs["USRID_MAIL"] = display.USRID_MAIL;//邮箱
                        newRowYs["OUTOCEAN"] = display.OUTOCEAN;//用户类型
                        newRowYs["IS_SZHY"] = display.IS_SZHY;//用户类型
                        newRowYs["JWBS"] = display.JWBS;//既往病史
                        dtYs.Rows.Add(newRowYs);
                        nCount5 = nCount5 + 1;
                    }
                }

                //if (TypeNo == "PQZ" || TypeNo == "1005" || TypeNo == "All")
                //{
                //    if (display.SF_SS_EDUCATION_SLART != "11" && display.TYPE_ID == "1005")
                //    {

                //        DataRow newRowYs = dtPqz.NewRow();
                //        newRowYs["NO"] = nCount5.ToString();//1编号
                //        if (!string.IsNullOrEmpty(display.SF_BK_EDUCATION_INSTI))
                //        {
                //            newRowYs["SF_BK_EDUCATION_INSTI"] = display.SF_BK_EDUCATION_INSTI + "(" + display.SF_BK_EDUCATION_ZHRXKZY1 + ")";//2本科学校
                //        }
                //        else
                //        {
                //            newRowYs["SF_BK_EDUCATION_INSTI"] = "";
                //        }
                //        newRowYs["NACHN"] = display.NACHN;//3姓名
                //        newRowYs["SF_BK_EDUCATION_ENDDA"] = display.SF_BK_EDUCATION_ENDDA;//4本科毕业日期
                //        newRowYs["DT_BK_EDUCATION_NAME"] = display.DT_BK_EDUCATION_NAME;//5本科学历
                //        newRowYs["ZHRJG"] = display.ZHRJG;//6籍贯
                //        newRowYs["PCODE_NAME"] = display.PCODE_NAME;//7政治面貌
                //        newRowYs["RACKY_NAME"] = display.RACKY_NAME;//8民族
                //        newRowYs["GBDAT"] = display.GBDAT.ToString("yyyy-MM-dd");//9出生年月
                //        newRowYs["ICNUM"] = display.ICNUM;//身份证号
                //        newRowYs["ZHRGRSG"] = display.ZHRGRSG;//10身高
                //        newRowYs["SEX"] = display.SEX;//11性别
                //        newRowYs["SF_GZ_EDUCATION_INSTI"] = display.SF_GZ_EDUCATION_INSTI;//12高中学校
                //        newRowYs["ZHRTZGG"] = display.ZHRTZGG;//13高考成绩
                //        newRowYs["SF_ZHRWYSP_NAME"] = display.SF_ZHRWYSP_NAME;//14外语水平
                //        newRowYs["SF_ZHRJSJSP_NAME"] = display.SF_ZHRJSJSP_NAME;//15计算机水平
                //        if (!string.IsNullOrEmpty(display.ZHRSXXX))
                //        {
                //            newRowYs["SF_WORK_SX_ZHRXXDW"] = display.ZHRSXXX;
                //        }
                //        else
                //        {
                //            newRowYs["SF_WORK_SX_ZHRXXDW"] = display.SF_WORK_SX_ZHRXXDW;//21实习医院
                //        }
                //        newRowYs["SX_ZHRGZNX"] = display.SX_ZHRGZNX;//17实习时长
                //        newRowYs["ZHRTC"] = display.ZHRTC;//18特长
                //        newRowYs["USRID_TEL"] = display.USRID_TEL;//19手机号码
                //        newRowYs["ZHRHJJL"] = display.ZHRHJJL;//20获奖经历
                //        newRowYs["ZHRBZ"] = display.ZHRBZ;//21备注
                //        newRowYs["REAL_ZHRGRSG"] = display.REAL_ZHRGRSG;//22真实身高
                //        newRowYs["REAL_ZHRGRTZ"] = display.REAL_ZHRGRTZ;//23真实体重
                //        newRowYs["REAL_ZHRSLJZ"] = display.REAL_ZHRSLJZ;//24真实视力
                //        newRowYs["WRITTEN_THEORY"] = display.WRITTEN_THEORY;//25笔试理论成绩
                //        newRowYs["WRITTEN_ENGLISH"] = display.WRITTEN_ENGLISH;//26笔试英语成绩
                //        newRowYs["WRITTEN_SUM"] = "";//27笔试总分
                //        newRowYs["OPERATOR_ONE"] = display.OPERATOR_ONE;//28操作成绩
                //        newRowYs["USRID_MAIL"] = display.USRID_MAIL;//邮箱
                //        newRowYs["OUTOCEAN"] = display.OUTOCEAN;//用户类型
                //        newRowYs["JWBS"] = display.JWBS;//既往病史
                //        dtPqz.Rows.Add(newRowYs);
                //        nCount5 = nCount5 + 1;
                //        /**
                //        DataRow newRowYs = dtPqz.NewRow();
                //        newRowYs["NO"] = nCount5.ToString();//1编号
                //        newRowYs["NACHN"] = display.NACHN;//2姓名
                //        newRowYs["SEX"] = display.SEX;//3性别
                //        newRowYs["GBDAT"] = display.GBDAT.ToString("yyyy-MM-dd");//4出生年月
                //        newRowYs["ICNUM"] = display.ICNUM;//身份证号
                //        newRowYs["SF_FAMST_NAME"] = display.SF_FAMST_NAME;//5婚姻状况
                //        newRowYs["ZHRJG"] = display.ZHRJG;//籍贯
                //        newRowYs["PCODE_NAME"] = display.PCODE_NAME;//5政治面貌
                //        newRowYs["DT_HH_EDUCATION_NAME"] = display.DT_HH_EDUCATION_NAME;//6最高学历
                //        newRowYs["DT_ZG_TYPE_NAME"] = display.DT_ZG_TYPE_NAME;//6最高学历学科类型
                //        newRowYs["SF_HH_EDUCATION_ZHRXKZY1"] = display.SF_HH_EDUCATION_ZHRXKZY1;//7最高学历专业
                //        newRowYs["SF_HH_EDUCATION_ZHRDSXM"] = display.SF_HH_EDUCATION_ZHRDSXM;//8最高学历导师
                //        newRowYs["SF_ZHRWYSP_NAME"] = display.SF_ZHRWYSP_NAME;//9外语水平

                //        if (!string.IsNullOrEmpty(display.SF_BS_EDUCATION_INSTI))
                //        {
                //            sBEGDA = display.SF_BS_EDUCATION_BEGDA;
                //            if (!string.IsNullOrEmpty(sBEGDA))
                //            {
                //                dtDate = DateTime.Parse(sBEGDA);
                //                sBEGDA = dtDate.ToString("yyyy.MM.dd");
                //            }
                //            sENDDA = display.SF_BS_EDUCATION_ENDDA;

                //            if (!string.IsNullOrEmpty(sENDDA))
                //            {
                //                dtDate = DateTime.Parse(sENDDA);
                //                sENDDA = dtDate.ToString("yyyy.MM.dd");
                //            }
                //            //dtDate = DateTime.Parse();
                //            newRowYs["SF_BS_EDUCATION_INSTI"] = display.SF_BS_EDUCATION_INSTI + "(" + display.SF_BS_EDUCATION_ZHRXKZY1 + sBEGDA + "-" + sENDDA + ")";//10博士学校
                //        }
                //        else
                //        {
                //            newRowYs["SF_BS_EDUCATION_INSTI"] = "";
                //        }

                //        if (!string.IsNullOrEmpty(sENDDA))
                //        {
                //            sENDDA = dtDate.ToString("yyyyMMdd");
                //            newRowYs["SF_BS_EDUCATION_ENDDA"] = sENDDA;//11博士毕业时间
                //        }
                //        else
                //        {
                //            newRowYs["SF_BS_EDUCATION_ENDDA"] = "";//11博士毕业时间
                //        }
                //        sBEGDA = "";
                //        sENDDA = "";
                //        dtDate = new DateTime();

                //        if (!string.IsNullOrEmpty(display.SF_SS_EDUCATION_INSTI))
                //        {
                //            sBEGDA = display.SF_SS_EDUCATION_BEGDA;
                //            if (!string.IsNullOrEmpty(sBEGDA))
                //            {
                //                dtDate = DateTime.Parse(sBEGDA);
                //                sBEGDA = dtDate.ToString("yyyy.MM.dd");
                //            }
                //            sENDDA = display.SF_SS_EDUCATION_ENDDA;

                //            if (!string.IsNullOrEmpty(sENDDA))
                //            {
                //                dtDate = DateTime.Parse(sENDDA);
                //                sENDDA = dtDate.ToString("yyyy.MM.dd");
                //            }

                //            newRowYs["SF_SS_EDUCATION_INSTI"] = display.SF_SS_EDUCATION_INSTI + "(" + display.SF_SS_EDUCATION_ZHRXKZY1 + sBEGDA + "-" + sENDDA + ")";//10博士学校
                //        }
                //        else
                //        {
                //            newRowYs["SF_SS_EDUCATION_INSTI"] = "";//12硕士学校
                //        }

                //        sBEGDA = "";
                //        sENDDA = "";
                //        dtDate = new DateTime();
                //        if (!string.IsNullOrEmpty(display.SF_BK_EDUCATION_INSTI))
                //        {
                //            sBEGDA = display.SF_BK_EDUCATION_BEGDA;
                //            if (!string.IsNullOrEmpty(sBEGDA))
                //            {
                //                dtDate = DateTime.Parse(sBEGDA);
                //                sBEGDA = dtDate.ToString("yyyy.MM.dd");
                //            }
                //            sENDDA = display.SF_BK_EDUCATION_ENDDA;

                //            if (!string.IsNullOrEmpty(sENDDA))
                //            {
                //                dtDate = DateTime.Parse(sENDDA);
                //                sENDDA = dtDate.ToString("yyyy.MM.dd");
                //            }

                //            newRowYs["SF_BK_EDUCATION_INSTI"] = display.SF_BK_EDUCATION_INSTI + "(" + display.SF_BK_EDUCATION_ZHRXKZY1 + sBEGDA + "-" + sENDDA + ")";//10博士学校
                //        }
                //        else
                //        {
                //            newRowYs["SF_BK_EDUCATION_INSTI"] = "";//13本科学校
                //        }
                //        sBEGDA = "";
                //        sENDDA = "";
                //        dtDate = new DateTime();
                //        newRowYs["BBJH"] = "";//14本部计划
                //        newRowYs["XBJH"] = "";//15西院计划
                //                              //newRowYs["DYZY"] = display.FIRSTCHOICE;//16第一志愿
                //                              //newRowYs["DEZY"] = display.SECONDCHOICE;//17第二志愿
                //        newRowYs["PRACTICE_TYPE_ID_NAME"] = display.PRACTICE_TYPE_ID_NAME;//17执业类型
                //        newRowYs["ESA"] = display.ESA;//18A
                //        newRowYs["ESB"] = display.ESB;//19B
                //        newRowYs["ESC"] = display.ESC;//20C
                //        newRowYs["EQW"] = display.EQW;//21权威
                //        newRowYs["EHX"] = display.EHX;//22核心
                //        newRowYs["EYB"] = display.EYB;//23一般
                //        newRowYs["ESCI"] = display.ESCI;//24SCI
                //        newRowYs["EOTHER"] = display.EOTHER;//25其他
                //        newRowYs["KYQK"] = "";//26科研情况
                //        newRowYs["QTCG"] = "";//27其他相关成果
                //        newRowYs["REMAEK"] = "";//28备注
                //        newRowYs["LXYJ"] = "";//29选留意见
                //        newRowYs["ZZJG"] = "";//30最终结果
                //        newRowYs["SFQY"] = "";//31是否签约
                //        newRowYs["USRID_TEL"] = display.USRID_TEL;//32电话
                //        newRowYs["BRQZ"] = "";//33本人签字确认
                //        newRowYs["REMAEK1"] = "";//34备注1
                //        newRowYs["REAL_ZHRGRSG"] = display.REAL_ZHRGRSG;//35真实身高
                //        newRowYs["REAL_ZHRGRTZ"] = display.REAL_ZHRGRTZ;//36真实体重
                //        newRowYs["REAL_ZHRSLJZ"] = display.REAL_ZHRSLJZ;//37真实视力
                //        newRowYs["WRITTEN_THEORY"] = display.WRITTEN_THEORY;//38笔试理论成绩
                //        newRowYs["WRITTEN_ENGLISH"] = display.WRITTEN_ENGLISH;//39笔试英语成绩
                //        newRowYs["WRITTEN_SUM"] = "";//40笔试总分
                //        newRowYs["OPERATOR_ONE"] = display.OPERATOR_ONE;//41操作成绩
                //        newRowYs["USRID_MAIL"] = display.USRID_MAIL;//邮箱
                //        newRowYs["OUTOCEAN"] = display.OUTOCEAN;//用户类型
                //        dtPqz.Rows.Add(newRowYs);**/

                //    }
                //}
                
            }

            if (TypeNo == "All" || TypeNo == "YJS")
            {
                ds.Tables.Add(dtYjs);
            }

            if (TypeNo == "All" || TypeNo == "1003")
            {
                ds.Tables.Add(dtWjs);
            }

            if (TypeNo == "All" || TypeNo == "1001")
            {
                ds.Tables.Add(dtYnsx);
            }

            if (TypeNo == "All" || TypeNo == "1002")
            {
                ds.Tables.Add(dtYwsx);
            }

            if (TypeNo == "1004" || IsYs)
            {
                ds.Tables.Add(dtYs);
            }
            //if (TypeNo == "PQZ" || TypeNo == "1005" || TypeNo == "All")
            //{
            //    ds.Tables.Add(dtPqz);
            //}
            return ds;
        }

        public DataTable getDtYs()
        {
            DataTable newDt = new DataTable();
            newDt.TableName = "T5";
            newDt.Columns.Add("NO", typeof(string));//1编号
            newDt.Columns.Add("NACHN", typeof(string));//2姓名
            newDt.Columns.Add("SEX", typeof(string));//3性别
            newDt.Columns.Add("GBDAT", typeof(string));//4出生年月
            newDt.Columns.Add("ICNUM", typeof(string));//9身份证号
            newDt.Columns.Add("SF_FAMST_NAME", typeof(string));//5婚姻状况
            newDt.Columns.Add("ZHRJG", typeof(string));//5籍贯
            newDt.Columns.Add("RACKY_NAME", typeof(string));//民族
            newDt.Columns.Add("PCODE_NAME", typeof(string));//5政治面貌
            newDt.Columns.Add("DT_HH_EDUCATION_NAME", typeof(string));//6最高学历
            newDt.Columns.Add("DT_ZG_TYPE_NAME", typeof(string));//6最高学历学科类型
            newDt.Columns.Add("SF_HH_EDUCATION_ZHRXKZY1", typeof(string));//7最高学历专业
            newDt.Columns.Add("SF_HH_EDUCATION_ZHRDSXM", typeof(string));//8最高学历导师
            newDt.Columns.Add("SF_ZHRWYSP_NAME", typeof(string));//9外语水平
            newDt.Columns.Add("SF_BS_EDUCATION_INSTI", typeof(string));//10博士学校
            newDt.Columns.Add("SF_BS_EDUCATION_ENDDA", typeof(string));//11博士毕业时间
            newDt.Columns.Add("SF_SS_EDUCATION_INSTI", typeof(string));//12硕士学校
            newDt.Columns.Add("SF_BK_EDUCATION_INSTI", typeof(string));//13本科学校
            newDt.Columns.Add("BBJH", typeof(string));//14本部计划
            newDt.Columns.Add("XBJH", typeof(string));//15西院计划
            newDt.Columns.Add("DYZY", typeof(string));//16第一志愿
            newDt.Columns.Add("DEZY", typeof(string));//17第二志愿
            newDt.Columns.Add("PRACTICE_TYPE_ID_NAME", typeof(string));//17执业类型
            newDt.Columns.Add("IS_STANDARD", typeof(string));//17毕业时是否取得住院医师规范化培训合格证
            newDt.Columns.Add("ESA", typeof(string));//18A
            newDt.Columns.Add("ESB", typeof(string));//19B
            newDt.Columns.Add("ESC", typeof(string));//20C
            newDt.Columns.Add("EQW", typeof(string));//21权威
            newDt.Columns.Add("EHX", typeof(string));//22核心
            newDt.Columns.Add("EYB", typeof(string));//23一般
            newDt.Columns.Add("ESCI", typeof(string));//24SCI
            newDt.Columns.Add("EOTHER", typeof(string));//25其他
            newDt.Columns.Add("KYQK", typeof(string));//26科研情况
            newDt.Columns.Add("QTCG", typeof(string));//27其他相关成果
            newDt.Columns.Add("REMAEK", typeof(string));//28备注
            newDt.Columns.Add("LXYJ", typeof(string));//29选留意见
            newDt.Columns.Add("ZZJG", typeof(string));//30最终结果
            newDt.Columns.Add("SFQY", typeof(string));//31是否签约
            newDt.Columns.Add("USRID_TEL", typeof(string));//32电话
            newDt.Columns.Add("BRQZ", typeof(string));//33本人签字确认
            newDt.Columns.Add("REMAEK1", typeof(string));//34备注1
            newDt.Columns.Add("REAL_ZHRGRSG", typeof(string));//35真实身高
            newDt.Columns.Add("REAL_ZHRGRTZ", typeof(string));//36真实体重
            newDt.Columns.Add("REAL_ZHRSLJZ", typeof(string));//37真实视力
            newDt.Columns.Add("WRITTEN_THEORY", typeof(string));//38笔试理论成绩
            newDt.Columns.Add("WRITTEN_ENGLISH", typeof(string));//39笔试英语成绩
            newDt.Columns.Add("WRITTEN_SUM", typeof(string));//40笔试总分
            newDt.Columns.Add("OPERATOR_ONE", typeof(string));//41操作成绩
            newDt.Columns.Add("USRID_MAIL", typeof(string));//邮箱
            newDt.Columns.Add("OUTOCEAN", typeof(string));//用户类型
            newDt.Columns.Add("IS_SZHY", typeof(string));//17毕业时是否取得住院医师规范化培训合格证
            newDt.Columns.Add("JWBS", typeof(string));//既往病史
            return newDt;
        }

        public DataTable getDtPqz()
        {
            DataTable newDt = new DataTable();
            newDt.TableName = "T6";
            newDt.Columns.Add("NO", typeof(string));//1编号
            newDt.Columns.Add("NACHN", typeof(string));//2姓名
            newDt.Columns.Add("SEX", typeof(string));//3性别
            newDt.Columns.Add("GBDAT", typeof(string));//4出生年月
            newDt.Columns.Add("ICNUM", typeof(string));//9身份证号
            newDt.Columns.Add("SF_FAMST_NAME", typeof(string));//5婚姻状况
            newDt.Columns.Add("ZHRJG", typeof(string));//5籍贯
            newDt.Columns.Add("PCODE_NAME", typeof(string));//5政治面貌
            newDt.Columns.Add("DT_HH_EDUCATION_NAME", typeof(string));//6最高学历
            newDt.Columns.Add("DT_ZG_TYPE_NAME", typeof(string));//6最高学历学科类型
            newDt.Columns.Add("SF_HH_EDUCATION_ZHRXKZY1", typeof(string));//7最高学历专业
            newDt.Columns.Add("SF_HH_EDUCATION_ZHRDSXM", typeof(string));//8最高学历导师
            newDt.Columns.Add("SF_ZHRWYSP_NAME", typeof(string));//9外语水平
            newDt.Columns.Add("SF_BS_EDUCATION_INSTI", typeof(string));//10博士学校
            newDt.Columns.Add("SF_BS_EDUCATION_ENDDA", typeof(string));//11博士毕业时间
            newDt.Columns.Add("SF_SS_EDUCATION_INSTI", typeof(string));//12硕士学校
            newDt.Columns.Add("SF_BK_EDUCATION_INSTI", typeof(string));//13本科学校
            newDt.Columns.Add("BBJH", typeof(string));//14本部计划
            newDt.Columns.Add("XBJH", typeof(string));//15西院计划
            //newDt.Columns.Add("DYZY", typeof(string));//16第一志愿
            //newDt.Columns.Add("DEZY", typeof(string));//17第二志愿
            newDt.Columns.Add("PRACTICE_TYPE_ID_NAME", typeof(string));//17执业类型
            newDt.Columns.Add("ESA", typeof(string));//18A
            newDt.Columns.Add("ESB", typeof(string));//19B
            newDt.Columns.Add("ESC", typeof(string));//20C
            newDt.Columns.Add("EQW", typeof(string));//21权威
            newDt.Columns.Add("EHX", typeof(string));//22核心
            newDt.Columns.Add("EYB", typeof(string));//23一般
            newDt.Columns.Add("ESCI", typeof(string));//24SCI
            newDt.Columns.Add("EOTHER", typeof(string));//25其他
            newDt.Columns.Add("KYQK", typeof(string));//26科研情况
            newDt.Columns.Add("QTCG", typeof(string));//27其他相关成果
            newDt.Columns.Add("REMAEK", typeof(string));//28备注
            newDt.Columns.Add("LXYJ", typeof(string));//29选留意见
            newDt.Columns.Add("ZZJG", typeof(string));//30最终结果
            newDt.Columns.Add("SFQY", typeof(string));//31是否签约
            newDt.Columns.Add("USRID_TEL", typeof(string));//32电话
            newDt.Columns.Add("BRQZ", typeof(string));//33本人签字确认
            newDt.Columns.Add("REMAEK1", typeof(string));//34备注1
            newDt.Columns.Add("REAL_ZHRGRSG", typeof(string));//35真实身高
            newDt.Columns.Add("REAL_ZHRGRTZ", typeof(string));//36真实体重
            newDt.Columns.Add("REAL_ZHRSLJZ", typeof(string));//37真实视力
            newDt.Columns.Add("WRITTEN_THEORY", typeof(string));//38笔试理论成绩
            newDt.Columns.Add("WRITTEN_ENGLISH", typeof(string));//39笔试英语成绩
            newDt.Columns.Add("WRITTEN_SUM", typeof(string));//40笔试总分
            newDt.Columns.Add("OPERATOR_ONE", typeof(string));//41操作成绩
            newDt.Columns.Add("USRID_MAIL", typeof(string));//邮箱
            newDt.Columns.Add("OUTOCEAN", typeof(string));//用户类型
            newDt.Columns.Add("JWBS", typeof(string));
            return newDt;
        }

        //研究生 T1
        public DataTable getDtYjs()
        {
            DataTable newDt = new DataTable();
            newDt.TableName = "T1";
            newDt.Columns.Add("NO", typeof(string));//1序号
            newDt.Columns.Add("NACHN", typeof(string));//2姓名
            newDt.Columns.Add("SF_BK_EDUCATION_ENDDA", typeof(string));//3本科毕业日期
            newDt.Columns.Add("SEX", typeof(string));//4性别
            newDt.Columns.Add("GBDAT", typeof(string));//5出生日期
            newDt.Columns.Add("ICNUM", typeof(string));//9身份证号
            newDt.Columns.Add("ZHRGRSG", typeof(string));//6身高(CM)
            newDt.Columns.Add("DT_HH_EDUCATION_NAME", typeof(string));//7最高学历
            newDt.Columns.Add("DT_ZG_TYPE_NAME", typeof(string));//7最高学历学科类型
            newDt.Columns.Add("SF_HH_EDUCATION_ZHRDSXM", typeof(string));//8最高学历导师
            newDt.Columns.Add("SF_HH_EDUCATION_INSTI", typeof(string));//9最高学历学校
            newDt.Columns.Add("SF_BK_EDUCATION_INSTI", typeof(string));//10本科学校
            newDt.Columns.Add("ZHRSXXX", typeof(string));//本科实习医院
            newDt.Columns.Add("YJSSXXX", typeof(string));//研究生实习医院
            newDt.Columns.Add("SF_ZHRWYSP_NAME", typeof(string));//11外语水平
            newDt.Columns.Add("SF_ZHRJSJSP_NAME", typeof(string));//12计算机水平
            newDt.Columns.Add("ZHRJG", typeof(string));//5籍贯
            newDt.Columns.Add("PCODE_NAME", typeof(string));//13政治面貌
            newDt.Columns.Add("SF_FAMST_NAME", typeof(string));//14婚姻状况
            newDt.Columns.Add("REAL_ZHRGRSG", typeof(string));//15真实身高
            newDt.Columns.Add("REAL_ZHRGRTZ", typeof(string));//16真实体重
            newDt.Columns.Add("REAL_ZHRSLJZ", typeof(string));//17真实视力
            newDt.Columns.Add("WRITTEN_THEORY", typeof(string));//18笔试理论成绩
            newDt.Columns.Add("WRITTEN_ENGLISH", typeof(string));//19笔试英语成绩
            newDt.Columns.Add("WRITTEN_SUM", typeof(string));//20笔试总分
            newDt.Columns.Add("OPERATOR_ONE", typeof(string));//21操作成绩
            newDt.Columns.Add("USRID_TEL", typeof(string));//22手机号码
            newDt.Columns.Add("ZHRWZMC", typeof(string));//23科研
            newDt.Columns.Add("ZHRTC", typeof(string));//24特长
            newDt.Columns.Add("ZHRHJJL", typeof(string));//25获奖经历
            newDt.Columns.Add("ZHRBZ", typeof(string));//26备注
            newDt.Columns.Add("XLYJ", typeof(string));//27
            newDt.Columns.Add("USRID_MAIL", typeof(string));//邮箱
            newDt.Columns.Add("OUTOCEAN", typeof(string));//用户类型
            newDt.Columns.Add("JWBS", typeof(string));
            return newDt;
        }

        //往届生 T2
        public DataTable getDtWjs()
        {
            DataTable newDt = new DataTable();
            newDt.TableName = "T2";
            newDt.Columns.Add("NO", typeof(string));//1序号
            newDt.Columns.Add("SF_BK_EDUCATION_INSTI", typeof(string));//2本科学校
            newDt.Columns.Add("NACHN", typeof(string));//3姓名
            newDt.Columns.Add("SF_BK_EDUCATION_ENDDA", typeof(string));//4本科毕业日期
            newDt.Columns.Add("DT_BK_EDUCATION_NAME", typeof(string));//5本科学历
            newDt.Columns.Add("ZHRJG", typeof(string));//6籍贯
            newDt.Columns.Add("PCODE_NAME", typeof(string));//7政治面貌
            newDt.Columns.Add("RACKY_NAME", typeof(string));//8民族
            newDt.Columns.Add("GBDAT", typeof(string));//9出生年月
            newDt.Columns.Add("ICNUM", typeof(string));//9身份证号
            newDt.Columns.Add("ZHRGRSG", typeof(string));//10身高
            newDt.Columns.Add("SEX", typeof(string));//11性别
            newDt.Columns.Add("SF_GZ_EDUCATION_INSTI", typeof(string));//12高中学校
            newDt.Columns.Add("ZHRTZGG", typeof(string));//13高考成绩
            newDt.Columns.Add("SF_ZHRWYSP_NAME", typeof(string));//14外语水平
            newDt.Columns.Add("SF_ZHRJSJSP_NAME", typeof(string));//15计算机水平
            newDt.Columns.Add("SF_WORK_YJ_ZHRXXDW", typeof(string));//16工作医院
            newDt.Columns.Add("YJ_ZHRGZNX", typeof(string));//17三级甲等医院工作年限
            newDt.Columns.Add("ZHRBZ", typeof(string));//18备注
            newDt.Columns.Add("ZHRTC", typeof(string));//19特长
            newDt.Columns.Add("USRID_TEL", typeof(string));//20手机号码
            newDt.Columns.Add("REAL_ZHRGRSG", typeof(string));//21真实身高
            newDt.Columns.Add("REAL_ZHRGRTZ", typeof(string));//22真实体重
            newDt.Columns.Add("REAL_ZHRSLJZ", typeof(string));//23真实视力
            newDt.Columns.Add("WRITTEN_THEORY", typeof(string));//24笔试理论成绩
            newDt.Columns.Add("WRITTEN_ENGLISH", typeof(string));//25笔试英语成绩
            newDt.Columns.Add("WRITTEN_SUM", typeof(string));//26笔试总分
            newDt.Columns.Add("OPERATOR_ONE", typeof(string));//27操作成绩
            newDt.Columns.Add("USRID_MAIL", typeof(string));//邮箱
            newDt.Columns.Add("OUTOCEAN", typeof(string));//用户类型
            newDt.Columns.Add("JWBS", typeof(string));
            return newDt;
        }

        //院内实习 T3
        public DataTable getDtYnsx()
        {
            DataTable newDt = new DataTable();
            newDt.TableName = "T3";
            newDt.Columns.Add("NO", typeof(string));//1序号
            newDt.Columns.Add("SF_BK_EDUCATION_INSTI", typeof(string));//2本科学校
            newDt.Columns.Add("NACHN", typeof(string));//3姓名
            newDt.Columns.Add("SF_BK_EDUCATION_ENDDA", typeof(string));//4本科毕业日期
            newDt.Columns.Add("DT_BK_EDUCATION_NAME", typeof(string));//5本科学历
            newDt.Columns.Add("SF_BK_EDUCATION_ZHRXKZY1", typeof(string));//6本科专业
            newDt.Columns.Add("PCODE_NAME", typeof(string));//7政治面貌
            newDt.Columns.Add("ZHRJG", typeof(string));//8籍贯
            newDt.Columns.Add("RACKY_NAME", typeof(string));//民族
            newDt.Columns.Add("GBDAT", typeof(string));//9出生年月
            newDt.Columns.Add("ICNUM", typeof(string));//9身份证号
            newDt.Columns.Add("ZHRGRSG", typeof(string));//10身高
            newDt.Columns.Add("ZHRGRTZ", typeof(string));//11体重
            newDt.Columns.Add("SEX", typeof(string));//12性别
            newDt.Columns.Add("ZHRSLJZ", typeof(string));//13视力
            newDt.Columns.Add("SF_GZ_EDUCATION_INSTI", typeof(string));//14高中学校
            newDt.Columns.Add("ZHRTZGG", typeof(string));//15高考成绩
            newDt.Columns.Add("SF_ZHRWYSP_NAME", typeof(string));//16外语水平
            newDt.Columns.Add("SF_ZHRJSJSP_NAME", typeof(string));//17计算机水平
            newDt.Columns.Add("ZHRTC", typeof(string));//18特长
            newDt.Columns.Add("ZHRHJJL", typeof(string));//19获奖经历
            newDt.Columns.Add("ZHRBZ", typeof(string));//20备注
            newDt.Columns.Add("SF_WORK_SX_ZHRXXDW", typeof(string));//21实习医院
            newDt.Columns.Add("USRID_TEL", typeof(string));//22手机号码
            newDt.Columns.Add("REAL_ZHRGRSG", typeof(string));//23真实身高
            newDt.Columns.Add("REAL_ZHRGRTZ", typeof(string));//24真实体重
            newDt.Columns.Add("REAL_ZHRSLJZ", typeof(string));//25真实视力
            newDt.Columns.Add("WRITTEN_THEORY", typeof(string));//26笔试理论成绩
            newDt.Columns.Add("WRITTEN_ENGLISH", typeof(string));//27笔试英语成绩
            newDt.Columns.Add("WRITTEN_SUM", typeof(string));//28笔试总分
            newDt.Columns.Add("OPERATOR_ONE", typeof(string));//29操作成绩
            newDt.Columns.Add("USRID_MAIL", typeof(string));//邮箱
            newDt.Columns.Add("OUTOCEAN", typeof(string));//用户类型
            newDt.Columns.Add("JWBS", typeof(string));

            return newDt;
        }
        //院外实习 T4
        public DataTable getDtYwsx()
        {
            DataTable newDt = new DataTable();
            newDt.TableName = "T4";
            newDt.Columns.Add("NO", typeof(string));//1序号
            newDt.Columns.Add("SF_BK_EDUCATION_INSTI", typeof(string));//2本科学校
            newDt.Columns.Add("NACHN", typeof(string));//3姓名
            newDt.Columns.Add("SF_BK_EDUCATION_ENDDA", typeof(string));//4本科毕业日期
            newDt.Columns.Add("DT_BK_EDUCATION_NAME", typeof(string));//5本科学历
            newDt.Columns.Add("ZHRJG", typeof(string));//6籍贯
            newDt.Columns.Add("PCODE_NAME", typeof(string));//7政治面貌
            newDt.Columns.Add("RACKY_NAME", typeof(string));//8民族
            newDt.Columns.Add("GBDAT", typeof(string));//9出生年月
            newDt.Columns.Add("ICNUM", typeof(string));//9身份证号
            newDt.Columns.Add("ZHRGRSG", typeof(string));//10身高
            newDt.Columns.Add("SEX", typeof(string));//11性别
            newDt.Columns.Add("SF_GZ_EDUCATION_INSTI", typeof(string));//12高中学校
            newDt.Columns.Add("ZHRTZGG", typeof(string));//13高考成绩
            newDt.Columns.Add("SF_ZHRWYSP_NAME", typeof(string));//14外语水平
            newDt.Columns.Add("SF_ZHRJSJSP_NAME", typeof(string));//15计算机水平
            newDt.Columns.Add("SF_WORK_SX_ZHRXXDW", typeof(string));//16实习医院
            newDt.Columns.Add("SX_ZHRGZNX", typeof(string));//17实习时长
            newDt.Columns.Add("ZHRTC", typeof(string));//18特长
            newDt.Columns.Add("USRID_TEL", typeof(string));//19手机号码
            newDt.Columns.Add("ZHRHJJL", typeof(string));//20获奖经历
            newDt.Columns.Add("ZHRBZ", typeof(string));//21备注
            newDt.Columns.Add("REAL_ZHRGRSG", typeof(string));//22真实身高
            newDt.Columns.Add("REAL_ZHRGRTZ", typeof(string));//23真实体重
            newDt.Columns.Add("REAL_ZHRSLJZ", typeof(string));//24真实视力
            newDt.Columns.Add("WRITTEN_THEORY", typeof(string));//25笔试理论成绩
            newDt.Columns.Add("WRITTEN_ENGLISH", typeof(string));//26笔试英语成绩
            newDt.Columns.Add("WRITTEN_SUM", typeof(string));//27笔试总分
            newDt.Columns.Add("OPERATOR_ONE", typeof(string));//28操作成绩
            newDt.Columns.Add("USRID_MAIL", typeof(string));//邮箱
            newDt.Columns.Add("OUTOCEAN", typeof(string));//用户类型
            newDt.Columns.Add("JWBS", typeof(string));
            return newDt;
        }
        
    }
}
