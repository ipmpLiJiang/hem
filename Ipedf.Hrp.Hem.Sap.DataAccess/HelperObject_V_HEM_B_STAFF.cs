using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Hrp.Hem.Sap.Entity;
namespace Ipedf.Hrp.Hem.Sap.DataAccess
{
	[CauseObject(typeof(CauseObject_V_HEM_B_STAFF))]	
	public partial class HelperObject_V_HEM_B_STAFF
	{		
		#region Method Blok
		public static DisplayObject_V_HEM_B_STAFF[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_HEM_B_STAFF.FIRSTCHOICE, V_HEM_B_STAFF.ZHRTC, V_HEM_B_STAFF.ZHRYRXX, V_HEM_B_STAFF.USRID_MAIL, V_HEM_B_STAFF.GBDAT, V_HEM_B_STAFF.LOCAT_JT, V_HEM_B_STAFF.USER_ID, V_HEM_B_STAFF.ZHRGRSG, V_HEM_B_STAFF.ID, V_HEM_B_STAFF.FAMST, V_HEM_B_STAFF.ZHRSXXX, V_HEM_B_STAFF.ZHRHJJL, V_HEM_B_STAFF.ZHRWYSP, V_HEM_B_STAFF.ZHRSLJZ, V_HEM_B_STAFF.USRID_TEL, V_HEM_B_STAFF.IS_NURSE, V_HEM_B_STAFF.ZHRJSJSP, V_HEM_B_STAFF.ZHRWYFS, V_HEM_B_STAFF.ZHRGZNX, V_HEM_B_STAFF.FGBDT, V_HEM_B_STAFF.IS_ACTION, V_HEM_B_STAFF.FANAM, V_HEM_B_STAFF.ICNUM, V_HEM_B_STAFF.GESCH, V_HEM_B_STAFF.NACHN, V_HEM_B_STAFF.ANZKD, V_HEM_B_STAFF.ZHRBZ, V_HEM_B_STAFF.TELNR, V_HEM_B_STAFF.FASEX, V_HEM_B_STAFF.STAFF_TYPE_ID, V_HEM_B_STAFF.ZHRJKZK, V_HEM_B_STAFF.SECONDCHOICE, V_HEM_B_STAFF.PCODE, V_HEM_B_STAFF.ZHRTZGG, V_HEM_B_STAFF.ZHRGRTZ, V_HEM_B_STAFF.LOCAT_XJ, V_HEM_B_STAFF.TYPE_ID, V_HEM_B_STAFF.PRACTICE_TYPE_ID, V_HEM_B_STAFF.ZHRFZDJ, V_HEM_B_STAFF.ZHRJG, V_HEM_B_STAFF.RACKY, V_HEM_B_STAFF.LOCAT_HJ, V_HEM_B_STAFF.FILE_PATH, V_HEM_B_STAFF.ZHRZWJS, V_HEM_B_STAFF.IS_CERTIFICATE,V_HEM_B_STAFF.SCHOOLINFO,V_HEM_B_STAFF.JWBS from V_HEM_B_STAFF where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_HEM_B_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRTC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRYRXX = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USRID_MAIL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GBDAT = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LOCAT_JT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ZHRGRSG = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.FAMST = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ZHRSXXX = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRHJJL = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ZHRWYSP = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.USRID_TEL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ZHRJSJSP = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ZHRWYFS = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.ZHRGZNX = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.FGBDT = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.IS_ACTION = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FANAM = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.ICNUM = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.GESCH = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.NACHN = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.ANZKD = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.ZHRBZ = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.TELNR = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.FASEX = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.ZHRJKZK = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.PCODE = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ZHRTZGG = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.ZHRGRTZ = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.LOCAT_XJ = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.TYPE_ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.PRACTICE_TYPE_ID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.ZHRFZDJ = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.ZHRJG = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.RACKY = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.LOCAT_HJ = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.FILE_PATH = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.ZHRZWJS = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(44);
				if (!sqlReader.IsDBNull(45))
					dataObj.SCHOOLINFO = sqlReader.GetString(45);
						if (!sqlReader.IsDBNull(46))
					dataObj.JWBS = sqlReader.GetString(46);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_STAFF[] objs = new DisplayObject_V_HEM_B_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_HEM_B_STAFF cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.FIRSTCHOICE))
			{
				strBuf.Append(" And V_HEM_B_STAFF.FIRSTCHOICE ").Append((cause.FIRSTCHOICE.StartsWith("%") || cause.FIRSTCHOICE.EndsWith("%")) ? " like " : " = ").Append(" :C_FIRSTCHOICE");
				param = new OracleParameter();
				param.ParameterName =":C_FIRSTCHOICE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.FIRSTCHOICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FIRSTCHOICE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "FIRSTCHOICE"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRTC))
			{
				strBuf.Append(" And V_HEM_B_STAFF.ZHRTC ").Append((cause.ZHRTC.StartsWith("%") || cause.ZHRTC.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRTC");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRTC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 600;
				param.Value = cause.ZHRTC;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRTC"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ZHRTC"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRYRXX))
			{
				strBuf.Append(" And V_HEM_B_STAFF.ZHRYRXX ").Append((cause.ZHRYRXX.StartsWith("%") || cause.ZHRYRXX.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRYRXX");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRYRXX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.ZHRYRXX;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRYRXX"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ZHRYRXX"));
			}
			if(!string.IsNullOrEmpty(cause.USRID_MAIL))
			{
				strBuf.Append(" And V_HEM_B_STAFF.USRID_MAIL ").Append((cause.USRID_MAIL.StartsWith("%") || cause.USRID_MAIL.EndsWith("%")) ? " like " : " = ").Append(" :C_USRID_MAIL");
				param = new OracleParameter();
				param.ParameterName =":C_USRID_MAIL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.USRID_MAIL;
				paramList.Add(param);
			}
			if (cause.HasINValue("USRID_MAIL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "USRID_MAIL"));
			}
			if(cause.GBDAT!= null)
			{
				if (cause.GBDAT.Begin != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF.GBDAT >= :C_GBDAT_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_GBDAT_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.GBDAT.Begin;
					paramList.Add(param);
				}
				if (cause.GBDAT.End != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF.GBDAT < :C_GBDAT_END");
					param = new OracleParameter();
					param.ParameterName = ":C_GBDAT_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.GBDAT.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("GBDAT"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "GBDAT"));
			}
			if(!string.IsNullOrEmpty(cause.LOCAT_JT))
			{
				strBuf.Append(" And V_HEM_B_STAFF.LOCAT_JT ").Append((cause.LOCAT_JT.StartsWith("%") || cause.LOCAT_JT.EndsWith("%")) ? " like " : " = ").Append(" :C_LOCAT_JT");
				param = new OracleParameter();
				param.ParameterName =":C_LOCAT_JT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.LOCAT_JT;
				paramList.Add(param);
			}
			if (cause.HasINValue("LOCAT_JT"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "LOCAT_JT"));
			}
			if(!string.IsNullOrEmpty(cause.USER_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRGRSG))
			{
				strBuf.Append(" And V_HEM_B_STAFF.ZHRGRSG ").Append((cause.ZHRGRSG.StartsWith("%") || cause.ZHRGRSG.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRGRSG");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRGRSG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.ZHRGRSG;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRGRSG"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ZHRGRSG"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.FAMST))
			{
				strBuf.Append(" And V_HEM_B_STAFF.FAMST ").Append((cause.FAMST.StartsWith("%") || cause.FAMST.EndsWith("%")) ? " like " : " = ").Append(" :C_FAMST");
				param = new OracleParameter();
				param.ParameterName =":C_FAMST";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.FAMST;
				paramList.Add(param);
			}
			if (cause.HasINValue("FAMST"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "FAMST"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRSXXX))
			{
				strBuf.Append(" And V_HEM_B_STAFF.ZHRSXXX ").Append((cause.ZHRSXXX.StartsWith("%") || cause.ZHRSXXX.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRSXXX");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRSXXX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.ZHRSXXX;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRSXXX"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ZHRSXXX"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRHJJL))
			{
				strBuf.Append(" And V_HEM_B_STAFF.ZHRHJJL ").Append((cause.ZHRHJJL.StartsWith("%") || cause.ZHRHJJL.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRHJJL");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRHJJL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 600;
				param.Value = cause.ZHRHJJL;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRHJJL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ZHRHJJL"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRWYSP))
			{
				strBuf.Append(" And V_HEM_B_STAFF.ZHRWYSP ").Append((cause.ZHRWYSP.StartsWith("%") || cause.ZHRWYSP.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRWYSP");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRWYSP";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.ZHRWYSP;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRWYSP"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ZHRWYSP"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRSLJZ))
			{
				strBuf.Append(" And V_HEM_B_STAFF.ZHRSLJZ ").Append((cause.ZHRSLJZ.StartsWith("%") || cause.ZHRSLJZ.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRSLJZ");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRSLJZ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.ZHRSLJZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRSLJZ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ZHRSLJZ"));
			}
			if(!string.IsNullOrEmpty(cause.USRID_TEL))
			{
				strBuf.Append(" And V_HEM_B_STAFF.USRID_TEL ").Append((cause.USRID_TEL.StartsWith("%") || cause.USRID_TEL.EndsWith("%")) ? " like " : " = ").Append(" :C_USRID_TEL");
				param = new OracleParameter();
				param.ParameterName =":C_USRID_TEL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = cause.USRID_TEL;
				paramList.Add(param);
			}
			if (cause.HasINValue("USRID_TEL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "USRID_TEL"));
			}
			if(cause.IS_NURSE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF.IS_NURSE = :C_IS_NURSE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_NURSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_NURSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_NURSE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "IS_NURSE"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRJSJSP))
			{
				strBuf.Append(" And V_HEM_B_STAFF.ZHRJSJSP ").Append((cause.ZHRJSJSP.StartsWith("%") || cause.ZHRJSJSP.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRJSJSP");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRJSJSP";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.ZHRJSJSP;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRJSJSP"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ZHRJSJSP"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRWYFS))
			{
				strBuf.Append(" And V_HEM_B_STAFF.ZHRWYFS ").Append((cause.ZHRWYFS.StartsWith("%") || cause.ZHRWYFS.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRWYFS");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRWYFS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 16;
				param.Value = cause.ZHRWYFS;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRWYFS"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ZHRWYFS"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRGZNX))
			{
				strBuf.Append(" And V_HEM_B_STAFF.ZHRGZNX ").Append((cause.ZHRGZNX.StartsWith("%") || cause.ZHRGZNX.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRGZNX");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRGZNX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 30;
				param.Value = cause.ZHRGZNX;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRGZNX"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ZHRGZNX"));
			}
			if(cause.FGBDT!= null)
			{
				if (cause.FGBDT.Begin != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF.FGBDT >= :C_FGBDT_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_FGBDT_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.FGBDT.Begin;
					paramList.Add(param);
				}
				if (cause.FGBDT.End != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF.FGBDT < :C_FGBDT_END");
					param = new OracleParameter();
					param.ParameterName = ":C_FGBDT_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.FGBDT.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("FGBDT"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "FGBDT"));
			}
			if(cause.IS_ACTION!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF.IS_ACTION = :C_IS_ACTION");
				param = new OracleParameter();
				param.ParameterName =":C_IS_ACTION";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_ACTION;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_ACTION"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "IS_ACTION"));
			}
			if(!string.IsNullOrEmpty(cause.FANAM))
			{
				strBuf.Append(" And V_HEM_B_STAFF.FANAM ").Append((cause.FANAM.StartsWith("%") || cause.FANAM.EndsWith("%")) ? " like " : " = ").Append(" :C_FANAM");
				param = new OracleParameter();
				param.ParameterName =":C_FANAM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.FANAM;
				paramList.Add(param);
			}
			if (cause.HasINValue("FANAM"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "FANAM"));
			}
			if(!string.IsNullOrEmpty(cause.ICNUM))
			{
				strBuf.Append(" And V_HEM_B_STAFF.ICNUM ").Append((cause.ICNUM.StartsWith("%") || cause.ICNUM.EndsWith("%")) ? " like " : " = ").Append(" :C_ICNUM");
				param = new OracleParameter();
				param.ParameterName =":C_ICNUM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 30;
				param.Value = cause.ICNUM;
				paramList.Add(param);
			}
			if (cause.HasINValue("ICNUM"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ICNUM"));
			}
			if(!string.IsNullOrEmpty(cause.GESCH))
			{
				strBuf.Append(" And V_HEM_B_STAFF.GESCH ").Append((cause.GESCH.StartsWith("%") || cause.GESCH.EndsWith("%")) ? " like " : " = ").Append(" :C_GESCH");
				param = new OracleParameter();
				param.ParameterName =":C_GESCH";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.GESCH;
				paramList.Add(param);
			}
			if (cause.HasINValue("GESCH"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "GESCH"));
			}
			if(!string.IsNullOrEmpty(cause.NACHN))
			{
				strBuf.Append(" And V_HEM_B_STAFF.NACHN ").Append((cause.NACHN.StartsWith("%") || cause.NACHN.EndsWith("%")) ? " like " : " = ").Append(" :C_NACHN");
				param = new OracleParameter();
				param.ParameterName =":C_NACHN";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.NACHN;
				paramList.Add(param);
			}
			if (cause.HasINValue("NACHN"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "NACHN"));
			}
			if(cause.ANZKD!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF.ANZKD = :C_ANZKD");
				param = new OracleParameter();
				param.ParameterName =":C_ANZKD";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ANZKD;
				paramList.Add(param);
			}
			if (cause.HasINValue("ANZKD"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ANZKD"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRBZ))
			{
				strBuf.Append(" And V_HEM_B_STAFF.ZHRBZ ").Append((cause.ZHRBZ.StartsWith("%") || cause.ZHRBZ.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRBZ");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRBZ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 600;
				param.Value = cause.ZHRBZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRBZ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ZHRBZ"));
			}
			if(!string.IsNullOrEmpty(cause.TELNR))
			{
				strBuf.Append(" And V_HEM_B_STAFF.TELNR ").Append((cause.TELNR.StartsWith("%") || cause.TELNR.EndsWith("%")) ? " like " : " = ").Append(" :C_TELNR");
				param = new OracleParameter();
				param.ParameterName =":C_TELNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = cause.TELNR;
				paramList.Add(param);
			}
			if (cause.HasINValue("TELNR"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "TELNR"));
			}
			if(!string.IsNullOrEmpty(cause.FASEX))
			{
				strBuf.Append(" And V_HEM_B_STAFF.FASEX ").Append((cause.FASEX.StartsWith("%") || cause.FASEX.EndsWith("%")) ? " like " : " = ").Append(" :C_FASEX");
				param = new OracleParameter();
				param.ParameterName =":C_FASEX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.FASEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("FASEX"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "FASEX"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_TYPE_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF.STAFF_TYPE_ID ").Append((cause.STAFF_TYPE_ID.StartsWith("%") || cause.STAFF_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "STAFF_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRJKZK))
			{
				strBuf.Append(" And V_HEM_B_STAFF.ZHRJKZK ").Append((cause.ZHRJKZK.StartsWith("%") || cause.ZHRJKZK.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRJKZK");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRJKZK";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 30;
				param.Value = cause.ZHRJKZK;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRJKZK"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ZHRJKZK"));
			}
			if(!string.IsNullOrEmpty(cause.SECONDCHOICE))
			{
				strBuf.Append(" And V_HEM_B_STAFF.SECONDCHOICE ").Append((cause.SECONDCHOICE.StartsWith("%") || cause.SECONDCHOICE.EndsWith("%")) ? " like " : " = ").Append(" :C_SECONDCHOICE");
				param = new OracleParameter();
				param.ParameterName =":C_SECONDCHOICE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.SECONDCHOICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SECONDCHOICE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "SECONDCHOICE"));
			}
			if(!string.IsNullOrEmpty(cause.PCODE))
			{
				strBuf.Append(" And V_HEM_B_STAFF.PCODE ").Append((cause.PCODE.StartsWith("%") || cause.PCODE.EndsWith("%")) ? " like " : " = ").Append(" :C_PCODE");
				param = new OracleParameter();
				param.ParameterName =":C_PCODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = cause.PCODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PCODE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "PCODE"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRTZGG))
			{
				strBuf.Append(" And V_HEM_B_STAFF.ZHRTZGG ").Append((cause.ZHRTZGG.StartsWith("%") || cause.ZHRTZGG.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRTZGG");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRTZGG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 4;
				param.Value = cause.ZHRTZGG;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRTZGG"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ZHRTZGG"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRGRTZ))
			{
				strBuf.Append(" And V_HEM_B_STAFF.ZHRGRTZ ").Append((cause.ZHRGRTZ.StartsWith("%") || cause.ZHRGRTZ.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRGRTZ");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRGRTZ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.ZHRGRTZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRGRTZ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ZHRGRTZ"));
			}
			if(!string.IsNullOrEmpty(cause.LOCAT_XJ))
			{
				strBuf.Append(" And V_HEM_B_STAFF.LOCAT_XJ ").Append((cause.LOCAT_XJ.StartsWith("%") || cause.LOCAT_XJ.EndsWith("%")) ? " like " : " = ").Append(" :C_LOCAT_XJ");
				param = new OracleParameter();
				param.ParameterName =":C_LOCAT_XJ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.LOCAT_XJ;
				paramList.Add(param);
			}
			if (cause.HasINValue("LOCAT_XJ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "LOCAT_XJ"));
			}
			if(!string.IsNullOrEmpty(cause.TYPE_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF.TYPE_ID ").Append((cause.TYPE_ID.StartsWith("%") || cause.TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.PRACTICE_TYPE_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF.PRACTICE_TYPE_ID ").Append((cause.PRACTICE_TYPE_ID.StartsWith("%") || cause.PRACTICE_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PRACTICE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PRACTICE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PRACTICE_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRACTICE_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "PRACTICE_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRFZDJ))
			{
				strBuf.Append(" And V_HEM_B_STAFF.ZHRFZDJ ").Append((cause.ZHRFZDJ.StartsWith("%") || cause.ZHRFZDJ.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRFZDJ");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRFZDJ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.ZHRFZDJ;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRFZDJ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ZHRFZDJ"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRJG))
			{
				strBuf.Append(" And V_HEM_B_STAFF.ZHRJG ").Append((cause.ZHRJG.StartsWith("%") || cause.ZHRJG.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRJG");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRJG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.ZHRJG;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRJG"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ZHRJG"));
			}
			if(!string.IsNullOrEmpty(cause.RACKY))
			{
				strBuf.Append(" And V_HEM_B_STAFF.RACKY ").Append((cause.RACKY.StartsWith("%") || cause.RACKY.EndsWith("%")) ? " like " : " = ").Append(" :C_RACKY");
				param = new OracleParameter();
				param.ParameterName =":C_RACKY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = cause.RACKY;
				paramList.Add(param);
			}
			if (cause.HasINValue("RACKY"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "RACKY"));
			}
			if(!string.IsNullOrEmpty(cause.LOCAT_HJ))
			{
				strBuf.Append(" And V_HEM_B_STAFF.LOCAT_HJ ").Append((cause.LOCAT_HJ.StartsWith("%") || cause.LOCAT_HJ.EndsWith("%")) ? " like " : " = ").Append(" :C_LOCAT_HJ");
				param = new OracleParameter();
				param.ParameterName =":C_LOCAT_HJ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.LOCAT_HJ;
				paramList.Add(param);
			}
			if (cause.HasINValue("LOCAT_HJ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "LOCAT_HJ"));
			}
			if(!string.IsNullOrEmpty(cause.FILE_PATH))
			{
				strBuf.Append(" And V_HEM_B_STAFF.FILE_PATH ").Append((cause.FILE_PATH.StartsWith("%") || cause.FILE_PATH.EndsWith("%")) ? " like " : " = ").Append(" :C_FILE_PATH");
				param = new OracleParameter();
				param.ParameterName =":C_FILE_PATH";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.FILE_PATH;
				paramList.Add(param);
			}
			if (cause.HasINValue("FILE_PATH"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "FILE_PATH"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRZWJS))
			{
				strBuf.Append(" And V_HEM_B_STAFF.ZHRZWJS ").Append((cause.ZHRZWJS.StartsWith("%") || cause.ZHRZWJS.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRZWJS");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRZWJS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1200;
				param.Value = cause.ZHRZWJS;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRZWJS"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "ZHRZWJS"));
			}
			if(cause.IS_CERTIFICATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF.IS_CERTIFICATE = :C_IS_CERTIFICATE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_CERTIFICATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_CERTIFICATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_CERTIFICATE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF", "IS_CERTIFICATE"));
			}
			if (!string.IsNullOrEmpty(cause.GetCustomCondition())) 
			{ 
				strBuf.Append(cause.GetCustomCondition()); 
			} 
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return strBuf.ToString();


		}		
		public static DisplayObject_V_HEM_B_STAFF[] Query(CauseObject_V_HEM_B_STAFF cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
            string sSql = " select  V_HEM_B_STAFF.FIRSTCHOICE, V_HEM_B_STAFF.ZHRTC, V_HEM_B_STAFF.ZHRYRXX, V_HEM_B_STAFF.USRID_MAIL, V_HEM_B_STAFF.GBDAT, V_HEM_B_STAFF.LOCAT_JT, V_HEM_B_STAFF.USER_ID, V_HEM_B_STAFF.ZHRGRSG, V_HEM_B_STAFF.ID, V_HEM_B_STAFF.FAMST, V_HEM_B_STAFF.ZHRSXXX, V_HEM_B_STAFF.ZHRHJJL, V_HEM_B_STAFF.ZHRWYSP, V_HEM_B_STAFF.ZHRSLJZ, V_HEM_B_STAFF.USRID_TEL, V_HEM_B_STAFF.IS_NURSE, V_HEM_B_STAFF.ZHRJSJSP, V_HEM_B_STAFF.ZHRWYFS, V_HEM_B_STAFF.ZHRGZNX, V_HEM_B_STAFF.FGBDT, V_HEM_B_STAFF.IS_ACTION, V_HEM_B_STAFF.FANAM, V_HEM_B_STAFF.ICNUM, V_HEM_B_STAFF.GESCH, V_HEM_B_STAFF.NACHN, V_HEM_B_STAFF.ANZKD, V_HEM_B_STAFF.ZHRBZ, V_HEM_B_STAFF.TELNR, V_HEM_B_STAFF.FASEX, V_HEM_B_STAFF.STAFF_TYPE_ID, V_HEM_B_STAFF.ZHRJKZK, V_HEM_B_STAFF.SECONDCHOICE, V_HEM_B_STAFF.PCODE, V_HEM_B_STAFF.ZHRTZGG, V_HEM_B_STAFF.ZHRGRTZ, V_HEM_B_STAFF.LOCAT_XJ, V_HEM_B_STAFF.TYPE_ID, V_HEM_B_STAFF.PRACTICE_TYPE_ID, V_HEM_B_STAFF.ZHRFZDJ, V_HEM_B_STAFF.ZHRJG, V_HEM_B_STAFF.RACKY, V_HEM_B_STAFF.LOCAT_HJ, V_HEM_B_STAFF.FILE_PATH, V_HEM_B_STAFF.ZHRZWJS, V_HEM_B_STAFF.IS_CERTIFICATE,V_HEM_B_STAFF.YJSSXXX,V_HEM_B_STAFF.IS_STANDARD, V_HEM_B_STAFF.IS_SZHY,V_HEM_B_STAFF.SCHOOLINFO,V_HEM_B_STAFF.JWBS from V_HEM_B_STAFF where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_B_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRTC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRYRXX = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USRID_MAIL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GBDAT = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LOCAT_JT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ZHRGRSG = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.FAMST = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ZHRSXXX = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRHJJL = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ZHRWYSP = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.USRID_TEL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ZHRJSJSP = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ZHRWYFS = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.ZHRGZNX = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.FGBDT = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.IS_ACTION = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FANAM = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.ICNUM = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.GESCH = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.NACHN = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.ANZKD = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.ZHRBZ = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.TELNR = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.FASEX = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.ZHRJKZK = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.PCODE = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ZHRTZGG = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.ZHRGRTZ = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.LOCAT_XJ = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.TYPE_ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.PRACTICE_TYPE_ID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.ZHRFZDJ = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.ZHRJG = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.RACKY = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.LOCAT_HJ = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.FILE_PATH = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.ZHRZWJS = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(44);
                if (!sqlReader.IsDBNull(45))
                    dataObj.YJSSXXX = sqlReader.GetString(45);
                if (!sqlReader.IsDBNull(46))
                    dataObj.IS_STANDARD = sqlReader.GetDecimal(46);
                if (!sqlReader.IsDBNull(47))
                    dataObj.IS_SZHY = sqlReader.GetDecimal(47);
				if (!sqlReader.IsDBNull(48))
					dataObj.SCHOOLINFO = sqlReader.GetString(48);
				if (!sqlReader.IsDBNull(49))
					dataObj.JWBS = sqlReader.GetString(49);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_STAFF[] objs = new DisplayObject_V_HEM_B_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_STAFF[] Query(CauseObject_V_HEM_B_STAFF cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_HEM_B_STAFF.FIRSTCHOICE, V_HEM_B_STAFF.ZHRTC, V_HEM_B_STAFF.ZHRYRXX, V_HEM_B_STAFF.USRID_MAIL, V_HEM_B_STAFF.GBDAT, V_HEM_B_STAFF.LOCAT_JT, V_HEM_B_STAFF.USER_ID, V_HEM_B_STAFF.ZHRGRSG, V_HEM_B_STAFF.ID, V_HEM_B_STAFF.FAMST, V_HEM_B_STAFF.ZHRSXXX, V_HEM_B_STAFF.ZHRHJJL, V_HEM_B_STAFF.ZHRWYSP, V_HEM_B_STAFF.ZHRSLJZ, V_HEM_B_STAFF.USRID_TEL, V_HEM_B_STAFF.IS_NURSE, V_HEM_B_STAFF.ZHRJSJSP, V_HEM_B_STAFF.ZHRWYFS, V_HEM_B_STAFF.ZHRGZNX, V_HEM_B_STAFF.FGBDT, V_HEM_B_STAFF.IS_ACTION, V_HEM_B_STAFF.FANAM, V_HEM_B_STAFF.ICNUM, V_HEM_B_STAFF.GESCH, V_HEM_B_STAFF.NACHN, V_HEM_B_STAFF.ANZKD, V_HEM_B_STAFF.ZHRBZ, V_HEM_B_STAFF.TELNR, V_HEM_B_STAFF.FASEX, V_HEM_B_STAFF.STAFF_TYPE_ID, V_HEM_B_STAFF.ZHRJKZK, V_HEM_B_STAFF.SECONDCHOICE, V_HEM_B_STAFF.PCODE, V_HEM_B_STAFF.ZHRTZGG, V_HEM_B_STAFF.ZHRGRTZ, V_HEM_B_STAFF.LOCAT_XJ, V_HEM_B_STAFF.TYPE_ID, V_HEM_B_STAFF.PRACTICE_TYPE_ID, V_HEM_B_STAFF.ZHRFZDJ, V_HEM_B_STAFF.ZHRJG, V_HEM_B_STAFF.RACKY, V_HEM_B_STAFF.LOCAT_HJ, V_HEM_B_STAFF.FILE_PATH, V_HEM_B_STAFF.ZHRZWJS, V_HEM_B_STAFF.IS_CERTIFICATE, V_HEM_B_STAFF.SCHOOLINFO, V_HEM_B_STAFF.JWBS from V_HEM_B_STAFF where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_B_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRTC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRYRXX = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USRID_MAIL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GBDAT = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LOCAT_JT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ZHRGRSG = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.FAMST = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ZHRSXXX = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRHJJL = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ZHRWYSP = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.USRID_TEL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ZHRJSJSP = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ZHRWYFS = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.ZHRGZNX = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.FGBDT = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.IS_ACTION = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FANAM = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.ICNUM = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.GESCH = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.NACHN = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.ANZKD = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.ZHRBZ = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.TELNR = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.FASEX = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.ZHRJKZK = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.PCODE = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ZHRTZGG = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.ZHRGRTZ = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.LOCAT_XJ = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.TYPE_ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.PRACTICE_TYPE_ID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.ZHRFZDJ = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.ZHRJG = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.RACKY = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.LOCAT_HJ = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.FILE_PATH = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.ZHRZWJS = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44))
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(44);
				if(!sqlReader.IsDBNull(45))
					dataObj.SCHOOLINFO = sqlReader.GetString(45);
				if (!sqlReader.IsDBNull(46))
					dataObj.JWBS = sqlReader.GetString(46);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_B_STAFF[] objs = new DisplayObject_V_HEM_B_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_STAFF[] Query(CauseObject_V_HEM_B_STAFF cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_HEM_B_STAFF.FIRSTCHOICE, V_HEM_B_STAFF.ZHRTC, V_HEM_B_STAFF.ZHRYRXX, V_HEM_B_STAFF.USRID_MAIL, V_HEM_B_STAFF.GBDAT, V_HEM_B_STAFF.LOCAT_JT, V_HEM_B_STAFF.USER_ID, V_HEM_B_STAFF.ZHRGRSG, V_HEM_B_STAFF.ID, V_HEM_B_STAFF.FAMST, V_HEM_B_STAFF.ZHRSXXX, V_HEM_B_STAFF.ZHRHJJL, V_HEM_B_STAFF.ZHRWYSP, V_HEM_B_STAFF.ZHRSLJZ, V_HEM_B_STAFF.USRID_TEL, V_HEM_B_STAFF.IS_NURSE, V_HEM_B_STAFF.ZHRJSJSP, V_HEM_B_STAFF.ZHRWYFS, V_HEM_B_STAFF.ZHRGZNX, V_HEM_B_STAFF.FGBDT, V_HEM_B_STAFF.IS_ACTION, V_HEM_B_STAFF.FANAM, V_HEM_B_STAFF.ICNUM, V_HEM_B_STAFF.GESCH, V_HEM_B_STAFF.NACHN, V_HEM_B_STAFF.ANZKD, V_HEM_B_STAFF.ZHRBZ, V_HEM_B_STAFF.TELNR, V_HEM_B_STAFF.FASEX, V_HEM_B_STAFF.STAFF_TYPE_ID, V_HEM_B_STAFF.ZHRJKZK, V_HEM_B_STAFF.SECONDCHOICE, V_HEM_B_STAFF.PCODE, V_HEM_B_STAFF.ZHRTZGG, V_HEM_B_STAFF.ZHRGRTZ, V_HEM_B_STAFF.LOCAT_XJ, V_HEM_B_STAFF.TYPE_ID, V_HEM_B_STAFF.PRACTICE_TYPE_ID, V_HEM_B_STAFF.ZHRFZDJ, V_HEM_B_STAFF.ZHRJG, V_HEM_B_STAFF.RACKY, V_HEM_B_STAFF.LOCAT_HJ, V_HEM_B_STAFF.FILE_PATH, V_HEM_B_STAFF.ZHRZWJS, V_HEM_B_STAFF.IS_CERTIFICATE,V_HEM_B_STAFF.SCHOOLINFO,V_HEM_B_STAFF.JWBS from V_HEM_B_STAFF where (1=1)";
			string sCauseSql = PrepareCause(cause,out parameters);
			sSql += sCauseSql;
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			if (paging != null)
			{
				string countSql = string.Empty;
				if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
				{
					countSql = "Select Count(*) From (" + sSql + ") t";
				}
				else
				{
					countSql = "Select Count(*) From (" + sSql + ") t";
				}
				if (paging.TotalRecords == 0)
				{
					paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer ? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, connection);
				}
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_B_STAFF",paging, order, sSql, parameters, connection);
			}
			else if (order != null)
			{
				sSql += order.ToString();
				sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
			}
			else
			{
				sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
			}
			DisplayObject_V_HEM_B_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRTC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRYRXX = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USRID_MAIL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GBDAT = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LOCAT_JT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ZHRGRSG = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.FAMST = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ZHRSXXX = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRHJJL = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ZHRWYSP = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.USRID_TEL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ZHRJSJSP = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ZHRWYFS = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.ZHRGZNX = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.FGBDT = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.IS_ACTION = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FANAM = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.ICNUM = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.GESCH = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.NACHN = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.ANZKD = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.ZHRBZ = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.TELNR = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.FASEX = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.ZHRJKZK = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.PCODE = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ZHRTZGG = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.ZHRGRTZ = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.LOCAT_XJ = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.TYPE_ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.PRACTICE_TYPE_ID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.ZHRFZDJ = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.ZHRJG = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.RACKY = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.LOCAT_HJ = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.FILE_PATH = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.ZHRZWJS = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(44);
				if (!sqlReader.IsDBNull(45))
					dataObj.SCHOOLINFO = sqlReader.GetString(45);
				if (!sqlReader.IsDBNull(46))
					dataObj.JWBS = sqlReader.GetString(46);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_STAFF[] objs = new DisplayObject_V_HEM_B_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_STAFF[] Query(CauseObject_V_HEM_B_STAFF cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_HEM_B_STAFF.FIRSTCHOICE, V_HEM_B_STAFF.ZHRTC, V_HEM_B_STAFF.ZHRYRXX, V_HEM_B_STAFF.USRID_MAIL, V_HEM_B_STAFF.GBDAT, V_HEM_B_STAFF.LOCAT_JT, V_HEM_B_STAFF.USER_ID, V_HEM_B_STAFF.ZHRGRSG, V_HEM_B_STAFF.ID, V_HEM_B_STAFF.FAMST, V_HEM_B_STAFF.ZHRSXXX, V_HEM_B_STAFF.ZHRHJJL, V_HEM_B_STAFF.ZHRWYSP, V_HEM_B_STAFF.ZHRSLJZ, V_HEM_B_STAFF.USRID_TEL, V_HEM_B_STAFF.IS_NURSE, V_HEM_B_STAFF.ZHRJSJSP, V_HEM_B_STAFF.ZHRWYFS, V_HEM_B_STAFF.ZHRGZNX, V_HEM_B_STAFF.FGBDT, V_HEM_B_STAFF.IS_ACTION, V_HEM_B_STAFF.FANAM, V_HEM_B_STAFF.ICNUM, V_HEM_B_STAFF.GESCH, V_HEM_B_STAFF.NACHN, V_HEM_B_STAFF.ANZKD, V_HEM_B_STAFF.ZHRBZ, V_HEM_B_STAFF.TELNR, V_HEM_B_STAFF.FASEX, V_HEM_B_STAFF.STAFF_TYPE_ID, V_HEM_B_STAFF.ZHRJKZK, V_HEM_B_STAFF.SECONDCHOICE, V_HEM_B_STAFF.PCODE, V_HEM_B_STAFF.ZHRTZGG, V_HEM_B_STAFF.ZHRGRTZ, V_HEM_B_STAFF.LOCAT_XJ, V_HEM_B_STAFF.TYPE_ID, V_HEM_B_STAFF.PRACTICE_TYPE_ID, V_HEM_B_STAFF.ZHRFZDJ, V_HEM_B_STAFF.ZHRJG, V_HEM_B_STAFF.RACKY, V_HEM_B_STAFF.LOCAT_HJ, V_HEM_B_STAFF.FILE_PATH, V_HEM_B_STAFF.ZHRZWJS, V_HEM_B_STAFF.IS_CERTIFICATE,V_HEM_B_STAFF.SCHOOLINFO,V_HEM_B_STAFF.JWBS from V_HEM_B_STAFF where (1=1)";
			string sCauseSql = PrepareCause(cause,out parameters);
			sSql += sCauseSql;
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			if (paging != null)
			{
				string countSql = string.Empty;
				if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
				{
					countSql = "Select Count(*) From (" + sSql + ") t";
				}
				else
				{
					countSql = "Select Count(*) From (" + sSql + ") t";
				}
				if (paging.TotalRecords == 0)
				{
					paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer || IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.Db2? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans);
				}
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_B_STAFF",paging, order, sSql, parameters, trans);
			}
			else if (order != null)
			{
				sSql += order.ToString();
				sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
			}
			else
			{
				sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
			}
			DisplayObject_V_HEM_B_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRTC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRYRXX = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USRID_MAIL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GBDAT = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LOCAT_JT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ZHRGRSG = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.FAMST = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ZHRSXXX = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRHJJL = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ZHRWYSP = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.USRID_TEL = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ZHRJSJSP = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ZHRWYFS = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.ZHRGZNX = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.FGBDT = sqlReader.GetDateTime(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.IS_ACTION = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.FANAM = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.ICNUM = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.GESCH = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.NACHN = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.ANZKD = sqlReader.GetDecimal(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.ZHRBZ = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.TELNR = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.FASEX = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.ZHRJKZK = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.PCODE = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ZHRTZGG = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.ZHRGRTZ = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.LOCAT_XJ = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.TYPE_ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.PRACTICE_TYPE_ID = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.ZHRFZDJ = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.ZHRJG = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.RACKY = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.LOCAT_HJ = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.FILE_PATH = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.ZHRZWJS = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(44);
				if (!sqlReader.IsDBNull(45))
					dataObj.SCHOOLINFO = sqlReader.GetString(45);
				if (!sqlReader.IsDBNull(46))
					dataObj.JWBS = sqlReader.GetString(46);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_B_STAFF[] objs = new DisplayObject_V_HEM_B_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		#endregion 
	}
}
