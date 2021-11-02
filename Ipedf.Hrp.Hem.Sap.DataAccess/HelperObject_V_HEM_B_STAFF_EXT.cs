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
	[CauseObject(typeof(CauseObject_V_HEM_B_STAFF_EXT))]	
	public partial class HelperObject_V_HEM_B_STAFF_EXT
	{		
		#region Method Blok
		public static DisplayObject_V_HEM_B_STAFF_EXT[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_HEM_B_STAFF_EXT.REAL_ZHRGRSG, V_HEM_B_STAFF_EXT.FIRSTCHOICE, V_HEM_B_STAFF_EXT.ZHRTC, V_HEM_B_STAFF_EXT.ZHRYRXX, V_HEM_B_STAFF_EXT.USRID_MAIL, V_HEM_B_STAFF_EXT.WRITTEN_ENGLISH, V_HEM_B_STAFF_EXT.GBDAT, V_HEM_B_STAFF_EXT.LOCAT_HJ, V_HEM_B_STAFF_EXT.LOCAT_JT, V_HEM_B_STAFF_EXT.USER_ID, V_HEM_B_STAFF_EXT.TELNR, V_HEM_B_STAFF_EXT.ZHRGRSG, V_HEM_B_STAFF_EXT.ID, V_HEM_B_STAFF_EXT.FAMST, V_HEM_B_STAFF_EXT.ZHRSXXX, V_HEM_B_STAFF_EXT.ZHRHJJL, V_HEM_B_STAFF_EXT.ZHRWYSP, V_HEM_B_STAFF_EXT.ZHRSLJZ, V_HEM_B_STAFF_EXT.USRID_TEL, V_HEM_B_STAFF_EXT.IS_NURSE, V_HEM_B_STAFF_EXT.ZHRJSJSP, V_HEM_B_STAFF_EXT.ZHRWYFS, V_HEM_B_STAFF_EXT.WRITTEN_THEORY, V_HEM_B_STAFF_EXT.ZHRGZNX, V_HEM_B_STAFF_EXT.FGBDT, V_HEM_B_STAFF_EXT.PRACTICE_TYPE_ID, V_HEM_B_STAFF_EXT.IS_ACTION, V_HEM_B_STAFF_EXT.FANAM, V_HEM_B_STAFF_EXT.ICNUM, V_HEM_B_STAFF_EXT.GESCH, V_HEM_B_STAFF_EXT.NACHN, V_HEM_B_STAFF_EXT.ANZKD, V_HEM_B_STAFF_EXT.ZHRBZ, V_HEM_B_STAFF_EXT.ZHRZWJS, V_HEM_B_STAFF_EXT.FASEX, V_HEM_B_STAFF_EXT.APPLY_ID, V_HEM_B_STAFF_EXT.STAFF_TYPE_ID, V_HEM_B_STAFF_EXT.ZHRJKZK, V_HEM_B_STAFF_EXT.SECONDCHOICE, V_HEM_B_STAFF_EXT.PCODE, V_HEM_B_STAFF_EXT.ZHRGRTZ, V_HEM_B_STAFF_EXT.LOCAT_XJ, V_HEM_B_STAFF_EXT.TYPE_ID, V_HEM_B_STAFF_EXT.ZHRTZGG, V_HEM_B_STAFF_EXT.ZHRFZDJ, V_HEM_B_STAFF_EXT.ZHRJG, V_HEM_B_STAFF_EXT.RACKY, V_HEM_B_STAFF_EXT.REAL_ZHRSLJZ, V_HEM_B_STAFF_EXT.REAL_ZHRGRTZ, V_HEM_B_STAFF_EXT.FILE_PATH, V_HEM_B_STAFF_EXT.IS_CERTIFICATE, V_HEM_B_STAFF_EXT.OPERATOR_ONE from V_HEM_B_STAFF_EXT where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_HEM_B_STAFF_EXT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_EXT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRTC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ZHRYRXX = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USRID_MAIL = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.GBDAT = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.LOCAT_HJ = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.LOCAT_JT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.TELNR = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRGRSG = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FAMST = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ZHRSXXX = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ZHRHJJL = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ZHRWYSP = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.USRID_TEL = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ZHRJSJSP = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ZHRWYFS = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ZHRGZNX = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.FGBDT = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.PRACTICE_TYPE_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.IS_ACTION = sqlReader.GetDecimal(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.FANAM = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.ICNUM = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.GESCH = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.NACHN = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ANZKD = sqlReader.GetDecimal(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.ZHRBZ = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ZHRZWJS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.FASEX = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.APPLY_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ZHRJKZK = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.PCODE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ZHRGRTZ = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.LOCAT_XJ = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.TYPE_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.ZHRTZGG = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.ZHRFZDJ = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.ZHRJG = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.RACKY = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.FILE_PATH = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(51);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_STAFF_EXT[] objs = new DisplayObject_V_HEM_B_STAFF_EXT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_HEM_B_STAFF_EXT cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.REAL_ZHRGRSG!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.REAL_ZHRGRSG = :C_REAL_ZHRGRSG");
				param = new OracleParameter();
				param.ParameterName =":C_REAL_ZHRGRSG";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.REAL_ZHRGRSG;
				paramList.Add(param);
			}
			if (cause.HasINValue("REAL_ZHRGRSG"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "REAL_ZHRGRSG"));
			}
			if(!string.IsNullOrEmpty(cause.FIRSTCHOICE))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.FIRSTCHOICE ").Append((cause.FIRSTCHOICE.StartsWith("%") || cause.FIRSTCHOICE.EndsWith("%")) ? " like " : " = ").Append(" :C_FIRSTCHOICE");
				param = new OracleParameter();
				param.ParameterName =":C_FIRSTCHOICE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.FIRSTCHOICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FIRSTCHOICE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "FIRSTCHOICE"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRTC))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ZHRTC ").Append((cause.ZHRTC.StartsWith("%") || cause.ZHRTC.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRTC");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRTC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 600;
				param.Value = cause.ZHRTC;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRTC"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ZHRTC"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRYRXX))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ZHRYRXX ").Append((cause.ZHRYRXX.StartsWith("%") || cause.ZHRYRXX.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRYRXX");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRYRXX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.ZHRYRXX;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRYRXX"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ZHRYRXX"));
			}
			if(!string.IsNullOrEmpty(cause.USRID_MAIL))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.USRID_MAIL ").Append((cause.USRID_MAIL.StartsWith("%") || cause.USRID_MAIL.EndsWith("%")) ? " like " : " = ").Append(" :C_USRID_MAIL");
				param = new OracleParameter();
				param.ParameterName =":C_USRID_MAIL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.USRID_MAIL;
				paramList.Add(param);
			}
			if (cause.HasINValue("USRID_MAIL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "USRID_MAIL"));
			}
			if(cause.WRITTEN_ENGLISH!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.WRITTEN_ENGLISH = :C_WRITTEN_ENGLISH");
				param = new OracleParameter();
				param.ParameterName =":C_WRITTEN_ENGLISH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.WRITTEN_ENGLISH;
				paramList.Add(param);
			}
			if (cause.HasINValue("WRITTEN_ENGLISH"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "WRITTEN_ENGLISH"));
			}
			if(cause.GBDAT!= null)
			{
				if (cause.GBDAT.Begin != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF_EXT.GBDAT >= :C_GBDAT_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_GBDAT_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.GBDAT.Begin;
					paramList.Add(param);
				}
				if (cause.GBDAT.End != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF_EXT.GBDAT < :C_GBDAT_END");
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
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "GBDAT"));
			}
			if(!string.IsNullOrEmpty(cause.LOCAT_HJ))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.LOCAT_HJ ").Append((cause.LOCAT_HJ.StartsWith("%") || cause.LOCAT_HJ.EndsWith("%")) ? " like " : " = ").Append(" :C_LOCAT_HJ");
				param = new OracleParameter();
				param.ParameterName =":C_LOCAT_HJ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.LOCAT_HJ;
				paramList.Add(param);
			}
			if (cause.HasINValue("LOCAT_HJ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "LOCAT_HJ"));
			}
			if(!string.IsNullOrEmpty(cause.LOCAT_JT))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.LOCAT_JT ").Append((cause.LOCAT_JT.StartsWith("%") || cause.LOCAT_JT.EndsWith("%")) ? " like " : " = ").Append(" :C_LOCAT_JT");
				param = new OracleParameter();
				param.ParameterName =":C_LOCAT_JT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.LOCAT_JT;
				paramList.Add(param);
			}
			if (cause.HasINValue("LOCAT_JT"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "LOCAT_JT"));
			}
			if(!string.IsNullOrEmpty(cause.USER_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.TELNR))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.TELNR ").Append((cause.TELNR.StartsWith("%") || cause.TELNR.EndsWith("%")) ? " like " : " = ").Append(" :C_TELNR");
				param = new OracleParameter();
				param.ParameterName =":C_TELNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = cause.TELNR;
				paramList.Add(param);
			}
			if (cause.HasINValue("TELNR"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "TELNR"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRGRSG))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ZHRGRSG ").Append((cause.ZHRGRSG.StartsWith("%") || cause.ZHRGRSG.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRGRSG");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRGRSG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.ZHRGRSG;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRGRSG"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ZHRGRSG"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.FAMST))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.FAMST ").Append((cause.FAMST.StartsWith("%") || cause.FAMST.EndsWith("%")) ? " like " : " = ").Append(" :C_FAMST");
				param = new OracleParameter();
				param.ParameterName =":C_FAMST";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.FAMST;
				paramList.Add(param);
			}
			if (cause.HasINValue("FAMST"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "FAMST"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRSXXX))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ZHRSXXX ").Append((cause.ZHRSXXX.StartsWith("%") || cause.ZHRSXXX.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRSXXX");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRSXXX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.ZHRSXXX;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRSXXX"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ZHRSXXX"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRHJJL))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ZHRHJJL ").Append((cause.ZHRHJJL.StartsWith("%") || cause.ZHRHJJL.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRHJJL");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRHJJL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 600;
				param.Value = cause.ZHRHJJL;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRHJJL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ZHRHJJL"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRWYSP))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ZHRWYSP ").Append((cause.ZHRWYSP.StartsWith("%") || cause.ZHRWYSP.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRWYSP");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRWYSP";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.ZHRWYSP;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRWYSP"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ZHRWYSP"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRSLJZ))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ZHRSLJZ ").Append((cause.ZHRSLJZ.StartsWith("%") || cause.ZHRSLJZ.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRSLJZ");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRSLJZ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.ZHRSLJZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRSLJZ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ZHRSLJZ"));
			}
			if(!string.IsNullOrEmpty(cause.USRID_TEL))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.USRID_TEL ").Append((cause.USRID_TEL.StartsWith("%") || cause.USRID_TEL.EndsWith("%")) ? " like " : " = ").Append(" :C_USRID_TEL");
				param = new OracleParameter();
				param.ParameterName =":C_USRID_TEL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = cause.USRID_TEL;
				paramList.Add(param);
			}
			if (cause.HasINValue("USRID_TEL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "USRID_TEL"));
			}
			if(cause.IS_NURSE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.IS_NURSE = :C_IS_NURSE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_NURSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_NURSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_NURSE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "IS_NURSE"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRJSJSP))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ZHRJSJSP ").Append((cause.ZHRJSJSP.StartsWith("%") || cause.ZHRJSJSP.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRJSJSP");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRJSJSP";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.ZHRJSJSP;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRJSJSP"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ZHRJSJSP"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRWYFS))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ZHRWYFS ").Append((cause.ZHRWYFS.StartsWith("%") || cause.ZHRWYFS.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRWYFS");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRWYFS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 16;
				param.Value = cause.ZHRWYFS;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRWYFS"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ZHRWYFS"));
			}
			if(cause.WRITTEN_THEORY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.WRITTEN_THEORY = :C_WRITTEN_THEORY");
				param = new OracleParameter();
				param.ParameterName =":C_WRITTEN_THEORY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.WRITTEN_THEORY;
				paramList.Add(param);
			}
			if (cause.HasINValue("WRITTEN_THEORY"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "WRITTEN_THEORY"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRGZNX))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ZHRGZNX ").Append((cause.ZHRGZNX.StartsWith("%") || cause.ZHRGZNX.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRGZNX");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRGZNX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 30;
				param.Value = cause.ZHRGZNX;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRGZNX"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ZHRGZNX"));
			}
			if(cause.FGBDT!= null)
			{
				if (cause.FGBDT.Begin != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF_EXT.FGBDT >= :C_FGBDT_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_FGBDT_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.FGBDT.Begin;
					paramList.Add(param);
				}
				if (cause.FGBDT.End != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF_EXT.FGBDT < :C_FGBDT_END");
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
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "FGBDT"));
			}
			if(!string.IsNullOrEmpty(cause.PRACTICE_TYPE_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.PRACTICE_TYPE_ID ").Append((cause.PRACTICE_TYPE_ID.StartsWith("%") || cause.PRACTICE_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PRACTICE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PRACTICE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PRACTICE_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRACTICE_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "PRACTICE_TYPE_ID"));
			}
			if(cause.IS_ACTION!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.IS_ACTION = :C_IS_ACTION");
				param = new OracleParameter();
				param.ParameterName =":C_IS_ACTION";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_ACTION;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_ACTION"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "IS_ACTION"));
			}
			if(!string.IsNullOrEmpty(cause.FANAM))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.FANAM ").Append((cause.FANAM.StartsWith("%") || cause.FANAM.EndsWith("%")) ? " like " : " = ").Append(" :C_FANAM");
				param = new OracleParameter();
				param.ParameterName =":C_FANAM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.FANAM;
				paramList.Add(param);
			}
			if (cause.HasINValue("FANAM"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "FANAM"));
			}
			if(!string.IsNullOrEmpty(cause.ICNUM))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ICNUM ").Append((cause.ICNUM.StartsWith("%") || cause.ICNUM.EndsWith("%")) ? " like " : " = ").Append(" :C_ICNUM");
				param = new OracleParameter();
				param.ParameterName =":C_ICNUM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 30;
				param.Value = cause.ICNUM;
				paramList.Add(param);
			}
			if (cause.HasINValue("ICNUM"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ICNUM"));
			}
			if(!string.IsNullOrEmpty(cause.GESCH))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.GESCH ").Append((cause.GESCH.StartsWith("%") || cause.GESCH.EndsWith("%")) ? " like " : " = ").Append(" :C_GESCH");
				param = new OracleParameter();
				param.ParameterName =":C_GESCH";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.GESCH;
				paramList.Add(param);
			}
			if (cause.HasINValue("GESCH"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "GESCH"));
			}
			if(!string.IsNullOrEmpty(cause.NACHN))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.NACHN ").Append((cause.NACHN.StartsWith("%") || cause.NACHN.EndsWith("%")) ? " like " : " = ").Append(" :C_NACHN");
				param = new OracleParameter();
				param.ParameterName =":C_NACHN";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.NACHN;
				paramList.Add(param);
			}
			if (cause.HasINValue("NACHN"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "NACHN"));
			}
			if(cause.ANZKD!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ANZKD = :C_ANZKD");
				param = new OracleParameter();
				param.ParameterName =":C_ANZKD";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ANZKD;
				paramList.Add(param);
			}
			if (cause.HasINValue("ANZKD"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ANZKD"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRBZ))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ZHRBZ ").Append((cause.ZHRBZ.StartsWith("%") || cause.ZHRBZ.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRBZ");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRBZ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 600;
				param.Value = cause.ZHRBZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRBZ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ZHRBZ"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRZWJS))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ZHRZWJS ").Append((cause.ZHRZWJS.StartsWith("%") || cause.ZHRZWJS.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRZWJS");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRZWJS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1200;
				param.Value = cause.ZHRZWJS;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRZWJS"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ZHRZWJS"));
			}
			if(!string.IsNullOrEmpty(cause.FASEX))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.FASEX ").Append((cause.FASEX.StartsWith("%") || cause.FASEX.EndsWith("%")) ? " like " : " = ").Append(" :C_FASEX");
				param = new OracleParameter();
				param.ParameterName =":C_FASEX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.FASEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("FASEX"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "FASEX"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.APPLY_ID ").Append((cause.APPLY_ID.StartsWith("%") || cause.APPLY_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_ID");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.APPLY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "APPLY_ID"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_TYPE_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.STAFF_TYPE_ID ").Append((cause.STAFF_TYPE_ID.StartsWith("%") || cause.STAFF_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "STAFF_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRJKZK))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ZHRJKZK ").Append((cause.ZHRJKZK.StartsWith("%") || cause.ZHRJKZK.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRJKZK");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRJKZK";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 30;
				param.Value = cause.ZHRJKZK;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRJKZK"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ZHRJKZK"));
			}
			if(!string.IsNullOrEmpty(cause.SECONDCHOICE))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.SECONDCHOICE ").Append((cause.SECONDCHOICE.StartsWith("%") || cause.SECONDCHOICE.EndsWith("%")) ? " like " : " = ").Append(" :C_SECONDCHOICE");
				param = new OracleParameter();
				param.ParameterName =":C_SECONDCHOICE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.SECONDCHOICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SECONDCHOICE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "SECONDCHOICE"));
			}
			if(!string.IsNullOrEmpty(cause.PCODE))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.PCODE ").Append((cause.PCODE.StartsWith("%") || cause.PCODE.EndsWith("%")) ? " like " : " = ").Append(" :C_PCODE");
				param = new OracleParameter();
				param.ParameterName =":C_PCODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = cause.PCODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PCODE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "PCODE"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRGRTZ))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ZHRGRTZ ").Append((cause.ZHRGRTZ.StartsWith("%") || cause.ZHRGRTZ.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRGRTZ");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRGRTZ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.ZHRGRTZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRGRTZ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ZHRGRTZ"));
			}
			if(!string.IsNullOrEmpty(cause.LOCAT_XJ))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.LOCAT_XJ ").Append((cause.LOCAT_XJ.StartsWith("%") || cause.LOCAT_XJ.EndsWith("%")) ? " like " : " = ").Append(" :C_LOCAT_XJ");
				param = new OracleParameter();
				param.ParameterName =":C_LOCAT_XJ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.LOCAT_XJ;
				paramList.Add(param);
			}
			if (cause.HasINValue("LOCAT_XJ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "LOCAT_XJ"));
			}
			if(!string.IsNullOrEmpty(cause.TYPE_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.TYPE_ID ").Append((cause.TYPE_ID.StartsWith("%") || cause.TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRTZGG))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ZHRTZGG ").Append((cause.ZHRTZGG.StartsWith("%") || cause.ZHRTZGG.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRTZGG");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRTZGG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 4;
				param.Value = cause.ZHRTZGG;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRTZGG"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ZHRTZGG"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRFZDJ))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ZHRFZDJ ").Append((cause.ZHRFZDJ.StartsWith("%") || cause.ZHRFZDJ.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRFZDJ");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRFZDJ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.ZHRFZDJ;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRFZDJ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ZHRFZDJ"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRJG))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.ZHRJG ").Append((cause.ZHRJG.StartsWith("%") || cause.ZHRJG.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRJG");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRJG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.ZHRJG;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRJG"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "ZHRJG"));
			}
			if(!string.IsNullOrEmpty(cause.RACKY))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.RACKY ").Append((cause.RACKY.StartsWith("%") || cause.RACKY.EndsWith("%")) ? " like " : " = ").Append(" :C_RACKY");
				param = new OracleParameter();
				param.ParameterName =":C_RACKY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = cause.RACKY;
				paramList.Add(param);
			}
			if (cause.HasINValue("RACKY"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "RACKY"));
			}
			if(cause.REAL_ZHRSLJZ!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.REAL_ZHRSLJZ = :C_REAL_ZHRSLJZ");
				param = new OracleParameter();
				param.ParameterName =":C_REAL_ZHRSLJZ";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.REAL_ZHRSLJZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("REAL_ZHRSLJZ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "REAL_ZHRSLJZ"));
			}
			if(cause.REAL_ZHRGRTZ!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.REAL_ZHRGRTZ = :C_REAL_ZHRGRTZ");
				param = new OracleParameter();
				param.ParameterName =":C_REAL_ZHRGRTZ";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.REAL_ZHRGRTZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("REAL_ZHRGRTZ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "REAL_ZHRGRTZ"));
			}
			if(!string.IsNullOrEmpty(cause.FILE_PATH))
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.FILE_PATH ").Append((cause.FILE_PATH.StartsWith("%") || cause.FILE_PATH.EndsWith("%")) ? " like " : " = ").Append(" :C_FILE_PATH");
				param = new OracleParameter();
				param.ParameterName =":C_FILE_PATH";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.FILE_PATH;
				paramList.Add(param);
			}
			if (cause.HasINValue("FILE_PATH"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "FILE_PATH"));
			}
			if(cause.IS_CERTIFICATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.IS_CERTIFICATE = :C_IS_CERTIFICATE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_CERTIFICATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_CERTIFICATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_CERTIFICATE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "IS_CERTIFICATE"));
			}
			if(cause.OPERATOR_ONE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_EXT.OPERATOR_ONE = :C_OPERATOR_ONE");
				param = new OracleParameter();
				param.ParameterName =":C_OPERATOR_ONE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.OPERATOR_ONE;
				paramList.Add(param);
			}
			if (cause.HasINValue("OPERATOR_ONE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_EXT", "OPERATOR_ONE"));
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
		public static DisplayObject_V_HEM_B_STAFF_EXT[] Query(CauseObject_V_HEM_B_STAFF_EXT cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
            string sSql = " select  V_HEM_B_STAFF_EXT.REAL_ZHRGRSG, V_HEM_B_STAFF_EXT.FIRSTCHOICE, V_HEM_B_STAFF_EXT.ZHRTC, V_HEM_B_STAFF_EXT.ZHRYRXX, V_HEM_B_STAFF_EXT.USRID_MAIL, V_HEM_B_STAFF_EXT.WRITTEN_ENGLISH, V_HEM_B_STAFF_EXT.GBDAT, V_HEM_B_STAFF_EXT.LOCAT_HJ, V_HEM_B_STAFF_EXT.LOCAT_JT, V_HEM_B_STAFF_EXT.USER_ID, V_HEM_B_STAFF_EXT.TELNR, V_HEM_B_STAFF_EXT.ZHRGRSG, V_HEM_B_STAFF_EXT.ID, V_HEM_B_STAFF_EXT.FAMST, V_HEM_B_STAFF_EXT.ZHRSXXX, V_HEM_B_STAFF_EXT.ZHRHJJL, V_HEM_B_STAFF_EXT.ZHRWYSP, V_HEM_B_STAFF_EXT.ZHRSLJZ, V_HEM_B_STAFF_EXT.USRID_TEL, V_HEM_B_STAFF_EXT.IS_NURSE, V_HEM_B_STAFF_EXT.ZHRJSJSP, V_HEM_B_STAFF_EXT.ZHRWYFS, V_HEM_B_STAFF_EXT.WRITTEN_THEORY, V_HEM_B_STAFF_EXT.ZHRGZNX, V_HEM_B_STAFF_EXT.FGBDT, V_HEM_B_STAFF_EXT.PRACTICE_TYPE_ID, V_HEM_B_STAFF_EXT.IS_ACTION, V_HEM_B_STAFF_EXT.FANAM, V_HEM_B_STAFF_EXT.ICNUM, V_HEM_B_STAFF_EXT.GESCH, V_HEM_B_STAFF_EXT.NACHN, V_HEM_B_STAFF_EXT.ANZKD, V_HEM_B_STAFF_EXT.ZHRBZ, V_HEM_B_STAFF_EXT.ZHRZWJS, V_HEM_B_STAFF_EXT.FASEX, V_HEM_B_STAFF_EXT.APPLY_ID, V_HEM_B_STAFF_EXT.STAFF_TYPE_ID, V_HEM_B_STAFF_EXT.ZHRJKZK, V_HEM_B_STAFF_EXT.SECONDCHOICE, V_HEM_B_STAFF_EXT.PCODE, V_HEM_B_STAFF_EXT.ZHRGRTZ, V_HEM_B_STAFF_EXT.LOCAT_XJ, V_HEM_B_STAFF_EXT.TYPE_ID, V_HEM_B_STAFF_EXT.ZHRTZGG, V_HEM_B_STAFF_EXT.ZHRFZDJ, V_HEM_B_STAFF_EXT.ZHRJG, V_HEM_B_STAFF_EXT.RACKY, V_HEM_B_STAFF_EXT.REAL_ZHRSLJZ, V_HEM_B_STAFF_EXT.REAL_ZHRGRTZ, V_HEM_B_STAFF_EXT.FILE_PATH, V_HEM_B_STAFF_EXT.IS_CERTIFICATE, V_HEM_B_STAFF_EXT.OPERATOR_ONE,V_HEM_B_STAFF_EXT.YJSSXXX,V_HEM_B_STAFF_EXT.IS_STANDARD, V_HEM_B_STAFF_EXT.IS_SZHY from V_HEM_B_STAFF_EXT where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_B_STAFF_EXT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_EXT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRTC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ZHRYRXX = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USRID_MAIL = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.GBDAT = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.LOCAT_HJ = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.LOCAT_JT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.TELNR = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRGRSG = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FAMST = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ZHRSXXX = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ZHRHJJL = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ZHRWYSP = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.USRID_TEL = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ZHRJSJSP = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ZHRWYFS = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ZHRGZNX = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.FGBDT = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.PRACTICE_TYPE_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.IS_ACTION = sqlReader.GetDecimal(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.FANAM = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.ICNUM = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.GESCH = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.NACHN = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ANZKD = sqlReader.GetDecimal(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.ZHRBZ = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ZHRZWJS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.FASEX = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.APPLY_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ZHRJKZK = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.PCODE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ZHRGRTZ = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.LOCAT_XJ = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.TYPE_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.ZHRTZGG = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.ZHRFZDJ = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.ZHRJG = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.RACKY = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.FILE_PATH = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(51);
                if (!sqlReader.IsDBNull(52))
                    dataObj.YJSSXXX = sqlReader.GetString(52);
                if (!sqlReader.IsDBNull(53))
                    dataObj.IS_STANDARD = sqlReader.GetString(53);
                if (!sqlReader.IsDBNull(54))
                    dataObj.IS_SZHY = sqlReader.GetString(54);
                objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_STAFF_EXT[] objs = new DisplayObject_V_HEM_B_STAFF_EXT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_STAFF_EXT[] Query(CauseObject_V_HEM_B_STAFF_EXT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_HEM_B_STAFF_EXT.REAL_ZHRGRSG, V_HEM_B_STAFF_EXT.FIRSTCHOICE, V_HEM_B_STAFF_EXT.ZHRTC, V_HEM_B_STAFF_EXT.ZHRYRXX, V_HEM_B_STAFF_EXT.USRID_MAIL, V_HEM_B_STAFF_EXT.WRITTEN_ENGLISH, V_HEM_B_STAFF_EXT.GBDAT, V_HEM_B_STAFF_EXT.LOCAT_HJ, V_HEM_B_STAFF_EXT.LOCAT_JT, V_HEM_B_STAFF_EXT.USER_ID, V_HEM_B_STAFF_EXT.TELNR, V_HEM_B_STAFF_EXT.ZHRGRSG, V_HEM_B_STAFF_EXT.ID, V_HEM_B_STAFF_EXT.FAMST, V_HEM_B_STAFF_EXT.ZHRSXXX, V_HEM_B_STAFF_EXT.ZHRHJJL, V_HEM_B_STAFF_EXT.ZHRWYSP, V_HEM_B_STAFF_EXT.ZHRSLJZ, V_HEM_B_STAFF_EXT.USRID_TEL, V_HEM_B_STAFF_EXT.IS_NURSE, V_HEM_B_STAFF_EXT.ZHRJSJSP, V_HEM_B_STAFF_EXT.ZHRWYFS, V_HEM_B_STAFF_EXT.WRITTEN_THEORY, V_HEM_B_STAFF_EXT.ZHRGZNX, V_HEM_B_STAFF_EXT.FGBDT, V_HEM_B_STAFF_EXT.PRACTICE_TYPE_ID, V_HEM_B_STAFF_EXT.IS_ACTION, V_HEM_B_STAFF_EXT.FANAM, V_HEM_B_STAFF_EXT.ICNUM, V_HEM_B_STAFF_EXT.GESCH, V_HEM_B_STAFF_EXT.NACHN, V_HEM_B_STAFF_EXT.ANZKD, V_HEM_B_STAFF_EXT.ZHRBZ, V_HEM_B_STAFF_EXT.ZHRZWJS, V_HEM_B_STAFF_EXT.FASEX, V_HEM_B_STAFF_EXT.APPLY_ID, V_HEM_B_STAFF_EXT.STAFF_TYPE_ID, V_HEM_B_STAFF_EXT.ZHRJKZK, V_HEM_B_STAFF_EXT.SECONDCHOICE, V_HEM_B_STAFF_EXT.PCODE, V_HEM_B_STAFF_EXT.ZHRGRTZ, V_HEM_B_STAFF_EXT.LOCAT_XJ, V_HEM_B_STAFF_EXT.TYPE_ID, V_HEM_B_STAFF_EXT.ZHRTZGG, V_HEM_B_STAFF_EXT.ZHRFZDJ, V_HEM_B_STAFF_EXT.ZHRJG, V_HEM_B_STAFF_EXT.RACKY, V_HEM_B_STAFF_EXT.REAL_ZHRSLJZ, V_HEM_B_STAFF_EXT.REAL_ZHRGRTZ, V_HEM_B_STAFF_EXT.FILE_PATH, V_HEM_B_STAFF_EXT.IS_CERTIFICATE, V_HEM_B_STAFF_EXT.OPERATOR_ONE from V_HEM_B_STAFF_EXT where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_B_STAFF_EXT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_EXT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRTC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ZHRYRXX = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USRID_MAIL = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.GBDAT = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.LOCAT_HJ = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.LOCAT_JT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.TELNR = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRGRSG = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FAMST = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ZHRSXXX = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ZHRHJJL = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ZHRWYSP = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.USRID_TEL = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ZHRJSJSP = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ZHRWYFS = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ZHRGZNX = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.FGBDT = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.PRACTICE_TYPE_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.IS_ACTION = sqlReader.GetDecimal(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.FANAM = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.ICNUM = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.GESCH = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.NACHN = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ANZKD = sqlReader.GetDecimal(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.ZHRBZ = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ZHRZWJS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.FASEX = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.APPLY_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ZHRJKZK = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.PCODE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ZHRGRTZ = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.LOCAT_XJ = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.TYPE_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.ZHRTZGG = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.ZHRFZDJ = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.ZHRJG = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.RACKY = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.FILE_PATH = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(51);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_B_STAFF_EXT[] objs = new DisplayObject_V_HEM_B_STAFF_EXT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_STAFF_EXT[] Query(CauseObject_V_HEM_B_STAFF_EXT cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_HEM_B_STAFF_EXT.REAL_ZHRGRSG, V_HEM_B_STAFF_EXT.FIRSTCHOICE, V_HEM_B_STAFF_EXT.ZHRTC, V_HEM_B_STAFF_EXT.ZHRYRXX, V_HEM_B_STAFF_EXT.USRID_MAIL, V_HEM_B_STAFF_EXT.WRITTEN_ENGLISH, V_HEM_B_STAFF_EXT.GBDAT, V_HEM_B_STAFF_EXT.LOCAT_HJ, V_HEM_B_STAFF_EXT.LOCAT_JT, V_HEM_B_STAFF_EXT.USER_ID, V_HEM_B_STAFF_EXT.TELNR, V_HEM_B_STAFF_EXT.ZHRGRSG, V_HEM_B_STAFF_EXT.ID, V_HEM_B_STAFF_EXT.FAMST, V_HEM_B_STAFF_EXT.ZHRSXXX, V_HEM_B_STAFF_EXT.ZHRHJJL, V_HEM_B_STAFF_EXT.ZHRWYSP, V_HEM_B_STAFF_EXT.ZHRSLJZ, V_HEM_B_STAFF_EXT.USRID_TEL, V_HEM_B_STAFF_EXT.IS_NURSE, V_HEM_B_STAFF_EXT.ZHRJSJSP, V_HEM_B_STAFF_EXT.ZHRWYFS, V_HEM_B_STAFF_EXT.WRITTEN_THEORY, V_HEM_B_STAFF_EXT.ZHRGZNX, V_HEM_B_STAFF_EXT.FGBDT, V_HEM_B_STAFF_EXT.PRACTICE_TYPE_ID, V_HEM_B_STAFF_EXT.IS_ACTION, V_HEM_B_STAFF_EXT.FANAM, V_HEM_B_STAFF_EXT.ICNUM, V_HEM_B_STAFF_EXT.GESCH, V_HEM_B_STAFF_EXT.NACHN, V_HEM_B_STAFF_EXT.ANZKD, V_HEM_B_STAFF_EXT.ZHRBZ, V_HEM_B_STAFF_EXT.ZHRZWJS, V_HEM_B_STAFF_EXT.FASEX, V_HEM_B_STAFF_EXT.APPLY_ID, V_HEM_B_STAFF_EXT.STAFF_TYPE_ID, V_HEM_B_STAFF_EXT.ZHRJKZK, V_HEM_B_STAFF_EXT.SECONDCHOICE, V_HEM_B_STAFF_EXT.PCODE, V_HEM_B_STAFF_EXT.ZHRGRTZ, V_HEM_B_STAFF_EXT.LOCAT_XJ, V_HEM_B_STAFF_EXT.TYPE_ID, V_HEM_B_STAFF_EXT.ZHRTZGG, V_HEM_B_STAFF_EXT.ZHRFZDJ, V_HEM_B_STAFF_EXT.ZHRJG, V_HEM_B_STAFF_EXT.RACKY, V_HEM_B_STAFF_EXT.REAL_ZHRSLJZ, V_HEM_B_STAFF_EXT.REAL_ZHRGRTZ, V_HEM_B_STAFF_EXT.FILE_PATH, V_HEM_B_STAFF_EXT.IS_CERTIFICATE, V_HEM_B_STAFF_EXT.OPERATOR_ONE from V_HEM_B_STAFF_EXT where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_B_STAFF_EXT",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_HEM_B_STAFF_EXT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_EXT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRTC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ZHRYRXX = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USRID_MAIL = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.GBDAT = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.LOCAT_HJ = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.LOCAT_JT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.TELNR = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRGRSG = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FAMST = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ZHRSXXX = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ZHRHJJL = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ZHRWYSP = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.USRID_TEL = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ZHRJSJSP = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ZHRWYFS = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ZHRGZNX = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.FGBDT = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.PRACTICE_TYPE_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.IS_ACTION = sqlReader.GetDecimal(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.FANAM = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.ICNUM = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.GESCH = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.NACHN = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ANZKD = sqlReader.GetDecimal(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.ZHRBZ = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ZHRZWJS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.FASEX = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.APPLY_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ZHRJKZK = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.PCODE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ZHRGRTZ = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.LOCAT_XJ = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.TYPE_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.ZHRTZGG = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.ZHRFZDJ = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.ZHRJG = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.RACKY = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.FILE_PATH = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(51);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_STAFF_EXT[] objs = new DisplayObject_V_HEM_B_STAFF_EXT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_STAFF_EXT[] Query(CauseObject_V_HEM_B_STAFF_EXT cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_HEM_B_STAFF_EXT.REAL_ZHRGRSG, V_HEM_B_STAFF_EXT.FIRSTCHOICE, V_HEM_B_STAFF_EXT.ZHRTC, V_HEM_B_STAFF_EXT.ZHRYRXX, V_HEM_B_STAFF_EXT.USRID_MAIL, V_HEM_B_STAFF_EXT.WRITTEN_ENGLISH, V_HEM_B_STAFF_EXT.GBDAT, V_HEM_B_STAFF_EXT.LOCAT_HJ, V_HEM_B_STAFF_EXT.LOCAT_JT, V_HEM_B_STAFF_EXT.USER_ID, V_HEM_B_STAFF_EXT.TELNR, V_HEM_B_STAFF_EXT.ZHRGRSG, V_HEM_B_STAFF_EXT.ID, V_HEM_B_STAFF_EXT.FAMST, V_HEM_B_STAFF_EXT.ZHRSXXX, V_HEM_B_STAFF_EXT.ZHRHJJL, V_HEM_B_STAFF_EXT.ZHRWYSP, V_HEM_B_STAFF_EXT.ZHRSLJZ, V_HEM_B_STAFF_EXT.USRID_TEL, V_HEM_B_STAFF_EXT.IS_NURSE, V_HEM_B_STAFF_EXT.ZHRJSJSP, V_HEM_B_STAFF_EXT.ZHRWYFS, V_HEM_B_STAFF_EXT.WRITTEN_THEORY, V_HEM_B_STAFF_EXT.ZHRGZNX, V_HEM_B_STAFF_EXT.FGBDT, V_HEM_B_STAFF_EXT.PRACTICE_TYPE_ID, V_HEM_B_STAFF_EXT.IS_ACTION, V_HEM_B_STAFF_EXT.FANAM, V_HEM_B_STAFF_EXT.ICNUM, V_HEM_B_STAFF_EXT.GESCH, V_HEM_B_STAFF_EXT.NACHN, V_HEM_B_STAFF_EXT.ANZKD, V_HEM_B_STAFF_EXT.ZHRBZ, V_HEM_B_STAFF_EXT.ZHRZWJS, V_HEM_B_STAFF_EXT.FASEX, V_HEM_B_STAFF_EXT.APPLY_ID, V_HEM_B_STAFF_EXT.STAFF_TYPE_ID, V_HEM_B_STAFF_EXT.ZHRJKZK, V_HEM_B_STAFF_EXT.SECONDCHOICE, V_HEM_B_STAFF_EXT.PCODE, V_HEM_B_STAFF_EXT.ZHRGRTZ, V_HEM_B_STAFF_EXT.LOCAT_XJ, V_HEM_B_STAFF_EXT.TYPE_ID, V_HEM_B_STAFF_EXT.ZHRTZGG, V_HEM_B_STAFF_EXT.ZHRFZDJ, V_HEM_B_STAFF_EXT.ZHRJG, V_HEM_B_STAFF_EXT.RACKY, V_HEM_B_STAFF_EXT.REAL_ZHRSLJZ, V_HEM_B_STAFF_EXT.REAL_ZHRGRTZ, V_HEM_B_STAFF_EXT.FILE_PATH, V_HEM_B_STAFF_EXT.IS_CERTIFICATE, V_HEM_B_STAFF_EXT.OPERATOR_ONE from V_HEM_B_STAFF_EXT where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_B_STAFF_EXT",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_HEM_B_STAFF_EXT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_EXT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRTC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ZHRYRXX = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USRID_MAIL = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.GBDAT = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.LOCAT_HJ = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.LOCAT_JT = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.USER_ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.TELNR = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRGRSG = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.FAMST = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ZHRSXXX = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ZHRHJJL = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ZHRWYSP = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.USRID_TEL = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.ZHRJSJSP = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ZHRWYFS = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ZHRGZNX = sqlReader.GetString(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.FGBDT = sqlReader.GetDateTime(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.PRACTICE_TYPE_ID = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.IS_ACTION = sqlReader.GetDecimal(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.FANAM = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.ICNUM = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.GESCH = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.NACHN = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ANZKD = sqlReader.GetDecimal(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.ZHRBZ = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ZHRZWJS = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.FASEX = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.APPLY_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ZHRJKZK = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.PCODE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.ZHRGRTZ = sqlReader.GetString(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.LOCAT_XJ = sqlReader.GetString(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.TYPE_ID = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.ZHRTZGG = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.ZHRFZDJ = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.ZHRJG = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.RACKY = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.FILE_PATH = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(51);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_B_STAFF_EXT[] objs = new DisplayObject_V_HEM_B_STAFF_EXT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		#endregion 
	}
}
