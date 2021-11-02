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
	[CauseObject(typeof(CauseObject_V_HEM_B_STAFF_APPLY))]	
	public partial class HelperObject_V_HEM_B_STAFF_APPLY
	{		
		#region Method Blok
		public static DisplayObject_V_HEM_B_STAFF_APPLY[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_HEM_B_STAFF_APPLY.WRITTEN_TOTAL, V_HEM_B_STAFF_APPLY.POSTER_ID, V_HEM_B_STAFF_APPLY.STAFF_IS_NURSE_NAME, V_HEM_B_STAFF_APPLY.SF_SS_EDUCATION_SLART, V_HEM_B_STAFF_APPLY.REAL_ZHRGRTZ, V_HEM_B_STAFF_APPLY.IS_CERTIFICATE, V_HEM_B_STAFF_APPLY.STATUS, V_HEM_B_STAFF_APPLY.END_DATE, V_HEM_B_STAFF_APPLY.ZHRGRTZ, V_HEM_B_STAFF_APPLY.POSTER_STATUS, V_HEM_B_STAFF_APPLY.ED_TYPE_NAME, V_HEM_B_STAFF_APPLY.CONTENT, V_HEM_B_STAFF_APPLY.TYPE_ID, V_HEM_B_STAFF_APPLY.IS_SEND_NAME, V_HEM_B_STAFF_APPLY.MANAGE_USER_ID_NAME, V_HEM_B_STAFF_APPLY.SEND_ID, V_HEM_B_STAFF_APPLY.USER_IS_USABL, V_HEM_B_STAFF_APPLY.IS_NURSE_NAME, V_HEM_B_STAFF_APPLY.IS_NURSE, V_HEM_B_STAFF_APPLY.DT_HH_EDUCATION_NAME, V_HEM_B_STAFF_APPLY.GESCH, V_HEM_B_STAFF_APPLY.REAL_ZHRGRSG, V_HEM_B_STAFF_APPLY.ACCOUNT, V_HEM_B_STAFF_APPLY.IS_PUBLIC, V_HEM_B_STAFF_APPLY.WRITTEN_THEORY, V_HEM_B_STAFF_APPLY.USRID_MAIL, V_HEM_B_STAFF_APPLY.REPLY_STATUS, V_HEM_B_STAFF_APPLY.PRACTICE_TYPE_ID_NAME, V_HEM_B_STAFF_APPLY.STAFF_ID, V_HEM_B_STAFF_APPLY.SLART_NAME, V_HEM_B_STAFF_APPLY.MANAGE_USER_IS_USABL, V_HEM_B_STAFF_APPLY.ZHRGRSG, V_HEM_B_STAFF_APPLY.TITLE, V_HEM_B_STAFF_APPLY.STATUS_NAME, V_HEM_B_STAFF_APPLY.USRID_TEL, V_HEM_B_STAFF_APPLY.SF_SS_EDUCATION_TYPE, V_HEM_B_STAFF_APPLY.GBDAT, V_HEM_B_STAFF_APPLY.RECRUIT_POSITION, V_HEM_B_STAFF_APPLY.IS_SEND, V_HEM_B_STAFF_APPLY.ID, V_HEM_B_STAFF_APPLY.PUBLISH_DATE, V_HEM_B_STAFF_APPLY.OPERATOR_ONE, V_HEM_B_STAFF_APPLY.ZHRTZGG, V_HEM_B_STAFF_APPLY.REAL_ZHRSLJZ, V_HEM_B_STAFF_APPLY.STAFF_TYPE_ID, V_HEM_B_STAFF_APPLY.STAFF_IS_NURSE, V_HEM_B_STAFF_APPLY.INSTI, V_HEM_B_STAFF_APPLY.CREATE_DATE, V_HEM_B_STAFF_APPLY.SEX, V_HEM_B_STAFF_APPLY.FIRSTCHOICE, V_HEM_B_STAFF_APPLY.NACHN, V_HEM_B_STAFF_APPLY.SEND_ERROR, V_HEM_B_STAFF_APPLY.TYPE_NAME, V_HEM_B_STAFF_APPLY.ZHRJG, V_HEM_B_STAFF_APPLY.MANAGE_USER_ID, V_HEM_B_STAFF_APPLY.USER_ID, V_HEM_B_STAFF_APPLY.WRITTEN_ENGLISH, V_HEM_B_STAFF_APPLY.MSSAGE_ID from V_HEM_B_STAFF_APPLY where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_HEM_B_STAFF_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.WRITTEN_TOTAL = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.POSTER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STAFF_IS_NURSE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SF_SS_EDUCATION_SLART = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATUS = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.END_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ZHRGRTZ = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.POSTER_STATUS = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ED_TYPE_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CONTENT = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.IS_SEND_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SEND_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IS_NURSE_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.DT_HH_EDUCATION_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.GESCH = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.ACCOUNT = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.USRID_MAIL = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.REPLY_STATUS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.PRACTICE_TYPE_ID_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.STAFF_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.SLART_NAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ZHRGRSG = sqlReader.GetDecimal(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.TITLE = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.STATUS_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.USRID_TEL = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.SF_SS_EDUCATION_TYPE = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.GBDAT = sqlReader.GetDateTime(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.IS_SEND = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.ZHRTZGG = sqlReader.GetDecimal(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.INSTI = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.SEX = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.NACHN = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.SEND_ERROR = sqlReader.GetString(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.TYPE_NAME = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.ZHRJG = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.USER_ID = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.MSSAGE_ID = sqlReader.GetString(57);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_STAFF_APPLY[] objs = new DisplayObject_V_HEM_B_STAFF_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_HEM_B_STAFF_APPLY cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.WRITTEN_TOTAL!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.WRITTEN_TOTAL = :C_WRITTEN_TOTAL");
				param = new OracleParameter();
				param.ParameterName =":C_WRITTEN_TOTAL";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.WRITTEN_TOTAL;
				paramList.Add(param);
			}
			if (cause.HasINValue("WRITTEN_TOTAL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "WRITTEN_TOTAL"));
			}
			if(!string.IsNullOrEmpty(cause.POSTER_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.POSTER_ID ").Append((cause.POSTER_ID.StartsWith("%") || cause.POSTER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_POSTER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_POSTER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.POSTER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("POSTER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "POSTER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_IS_NURSE_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.STAFF_IS_NURSE_NAME ").Append((cause.STAFF_IS_NURSE_NAME.StartsWith("%") || cause.STAFF_IS_NURSE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_IS_NURSE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_IS_NURSE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 2;
				param.Value = cause.STAFF_IS_NURSE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_IS_NURSE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "STAFF_IS_NURSE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.SF_SS_EDUCATION_SLART))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.SF_SS_EDUCATION_SLART ").Append((cause.SF_SS_EDUCATION_SLART.StartsWith("%") || cause.SF_SS_EDUCATION_SLART.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_SS_EDUCATION_SLART");
				param = new OracleParameter();
				param.ParameterName =":C_SF_SS_EDUCATION_SLART";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = cause.SF_SS_EDUCATION_SLART;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_SS_EDUCATION_SLART"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "SF_SS_EDUCATION_SLART"));
			}
			if(cause.REAL_ZHRGRTZ!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.REAL_ZHRGRTZ = :C_REAL_ZHRGRTZ");
				param = new OracleParameter();
				param.ParameterName =":C_REAL_ZHRGRTZ";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.REAL_ZHRGRTZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("REAL_ZHRGRTZ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "REAL_ZHRGRTZ"));
			}
			if(cause.IS_CERTIFICATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.IS_CERTIFICATE = :C_IS_CERTIFICATE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_CERTIFICATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_CERTIFICATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_CERTIFICATE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "IS_CERTIFICATE"));
			}
			if(cause.STATUS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.STATUS = :C_STATUS");
				param = new OracleParameter();
				param.ParameterName =":C_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATUS"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "STATUS"));
			}
			if(cause.END_DATE!= null)
			{
				if (cause.END_DATE.Begin != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF_APPLY.END_DATE >= :C_END_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_END_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.END_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.END_DATE.End != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF_APPLY.END_DATE < :C_END_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_END_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.END_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("END_DATE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "END_DATE"));
			}
			if(cause.ZHRGRTZ!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.ZHRGRTZ = :C_ZHRGRTZ");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRGRTZ";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ZHRGRTZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRGRTZ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "ZHRGRTZ"));
			}
			if(cause.POSTER_STATUS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.POSTER_STATUS = :C_POSTER_STATUS");
				param = new OracleParameter();
				param.ParameterName =":C_POSTER_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.POSTER_STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("POSTER_STATUS"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "POSTER_STATUS"));
			}
			if(!string.IsNullOrEmpty(cause.ED_TYPE_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.ED_TYPE_NAME ").Append((cause.ED_TYPE_NAME.StartsWith("%") || cause.ED_TYPE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_ED_TYPE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_ED_TYPE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.ED_TYPE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("ED_TYPE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "ED_TYPE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.CONTENT))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.CONTENT ").Append((cause.CONTENT.StartsWith("%") || cause.CONTENT.EndsWith("%")) ? " like " : " = ").Append(" :C_CONTENT");
				param = new OracleParameter();
				param.ParameterName =":C_CONTENT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.CONTENT;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTENT"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "CONTENT"));
			}
			if(!string.IsNullOrEmpty(cause.TYPE_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.TYPE_ID ").Append((cause.TYPE_ID.StartsWith("%") || cause.TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.IS_SEND_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.IS_SEND_NAME ").Append((cause.IS_SEND_NAME.StartsWith("%") || cause.IS_SEND_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_IS_SEND_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_IS_SEND_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 2;
				param.Value = cause.IS_SEND_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_SEND_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "IS_SEND_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.MANAGE_USER_ID_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.MANAGE_USER_ID_NAME ").Append((cause.MANAGE_USER_ID_NAME.StartsWith("%") || cause.MANAGE_USER_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_MANAGE_USER_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_MANAGE_USER_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MANAGE_USER_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("MANAGE_USER_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "MANAGE_USER_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.SEND_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.SEND_ID ").Append((cause.SEND_ID.StartsWith("%") || cause.SEND_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_SEND_ID");
				param = new OracleParameter();
				param.ParameterName =":C_SEND_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.SEND_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEND_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "SEND_ID"));
			}
			if(cause.USER_IS_USABL!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.USER_IS_USABL = :C_USER_IS_USABL");
				param = new OracleParameter();
				param.ParameterName =":C_USER_IS_USABL";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.USER_IS_USABL;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_IS_USABL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "USER_IS_USABL"));
			}
			if(!string.IsNullOrEmpty(cause.IS_NURSE_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.IS_NURSE_NAME ").Append((cause.IS_NURSE_NAME.StartsWith("%") || cause.IS_NURSE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_IS_NURSE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_IS_NURSE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 2;
				param.Value = cause.IS_NURSE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_NURSE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "IS_NURSE_NAME"));
			}
			if(cause.IS_NURSE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.IS_NURSE = :C_IS_NURSE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_NURSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_NURSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_NURSE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "IS_NURSE"));
			}
			if(!string.IsNullOrEmpty(cause.DT_HH_EDUCATION_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.DT_HH_EDUCATION_NAME ").Append((cause.DT_HH_EDUCATION_NAME.StartsWith("%") || cause.DT_HH_EDUCATION_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_DT_HH_EDUCATION_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_DT_HH_EDUCATION_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.DT_HH_EDUCATION_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("DT_HH_EDUCATION_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "DT_HH_EDUCATION_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.GESCH))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.GESCH ").Append((cause.GESCH.StartsWith("%") || cause.GESCH.EndsWith("%")) ? " like " : " = ").Append(" :C_GESCH");
				param = new OracleParameter();
				param.ParameterName =":C_GESCH";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.GESCH;
				paramList.Add(param);
			}
			if (cause.HasINValue("GESCH"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "GESCH"));
			}
			if(cause.REAL_ZHRGRSG!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.REAL_ZHRGRSG = :C_REAL_ZHRGRSG");
				param = new OracleParameter();
				param.ParameterName =":C_REAL_ZHRGRSG";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.REAL_ZHRGRSG;
				paramList.Add(param);
			}
			if (cause.HasINValue("REAL_ZHRGRSG"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "REAL_ZHRGRSG"));
			}
			if(!string.IsNullOrEmpty(cause.ACCOUNT))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.ACCOUNT ").Append((cause.ACCOUNT.StartsWith("%") || cause.ACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :C_ACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_ACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = cause.ACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("ACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "ACCOUNT"));
			}
			if(cause.IS_PUBLIC!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.IS_PUBLIC = :C_IS_PUBLIC");
				param = new OracleParameter();
				param.ParameterName =":C_IS_PUBLIC";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_PUBLIC;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_PUBLIC"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "IS_PUBLIC"));
			}
			if(cause.WRITTEN_THEORY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.WRITTEN_THEORY = :C_WRITTEN_THEORY");
				param = new OracleParameter();
				param.ParameterName =":C_WRITTEN_THEORY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.WRITTEN_THEORY;
				paramList.Add(param);
			}
			if (cause.HasINValue("WRITTEN_THEORY"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "WRITTEN_THEORY"));
			}
			if(!string.IsNullOrEmpty(cause.USRID_MAIL))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.USRID_MAIL ").Append((cause.USRID_MAIL.StartsWith("%") || cause.USRID_MAIL.EndsWith("%")) ? " like " : " = ").Append(" :C_USRID_MAIL");
				param = new OracleParameter();
				param.ParameterName =":C_USRID_MAIL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.USRID_MAIL;
				paramList.Add(param);
			}
			if (cause.HasINValue("USRID_MAIL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "USRID_MAIL"));
			}
			if(!string.IsNullOrEmpty(cause.REPLY_STATUS))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.REPLY_STATUS ").Append((cause.REPLY_STATUS.StartsWith("%") || cause.REPLY_STATUS.EndsWith("%")) ? " like " : " = ").Append(" :C_REPLY_STATUS");
				param = new OracleParameter();
				param.ParameterName =":C_REPLY_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.REPLY_STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("REPLY_STATUS"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "REPLY_STATUS"));
			}
			if(!string.IsNullOrEmpty(cause.PRACTICE_TYPE_ID_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.PRACTICE_TYPE_ID_NAME ").Append((cause.PRACTICE_TYPE_ID_NAME.StartsWith("%") || cause.PRACTICE_TYPE_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_PRACTICE_TYPE_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_PRACTICE_TYPE_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PRACTICE_TYPE_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRACTICE_TYPE_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "PRACTICE_TYPE_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.STAFF_ID ").Append((cause.STAFF_ID.StartsWith("%") || cause.STAFF_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_ID");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "STAFF_ID"));
			}
			if(!string.IsNullOrEmpty(cause.SLART_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.SLART_NAME ").Append((cause.SLART_NAME.StartsWith("%") || cause.SLART_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_SLART_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_SLART_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SLART_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("SLART_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "SLART_NAME"));
			}
			if(cause.MANAGE_USER_IS_USABL!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.MANAGE_USER_IS_USABL = :C_MANAGE_USER_IS_USABL");
				param = new OracleParameter();
				param.ParameterName =":C_MANAGE_USER_IS_USABL";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MANAGE_USER_IS_USABL;
				paramList.Add(param);
			}
			if (cause.HasINValue("MANAGE_USER_IS_USABL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "MANAGE_USER_IS_USABL"));
			}
			if(cause.ZHRGRSG!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.ZHRGRSG = :C_ZHRGRSG");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRGRSG";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ZHRGRSG;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRGRSG"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "ZHRGRSG"));
			}
			if(!string.IsNullOrEmpty(cause.TITLE))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.TITLE ").Append((cause.TITLE.StartsWith("%") || cause.TITLE.EndsWith("%")) ? " like " : " = ").Append(" :C_TITLE");
				param = new OracleParameter();
				param.ParameterName =":C_TITLE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 180;
				param.Value = cause.TITLE;
				paramList.Add(param);
			}
			if (cause.HasINValue("TITLE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "TITLE"));
			}
			if(!string.IsNullOrEmpty(cause.STATUS_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.STATUS_NAME ").Append((cause.STATUS_NAME.StartsWith("%") || cause.STATUS_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_STATUS_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_STATUS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.STATUS_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATUS_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "STATUS_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.USRID_TEL))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.USRID_TEL ").Append((cause.USRID_TEL.StartsWith("%") || cause.USRID_TEL.EndsWith("%")) ? " like " : " = ").Append(" :C_USRID_TEL");
				param = new OracleParameter();
				param.ParameterName =":C_USRID_TEL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = cause.USRID_TEL;
				paramList.Add(param);
			}
			if (cause.HasINValue("USRID_TEL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "USRID_TEL"));
			}
			if(!string.IsNullOrEmpty(cause.SF_SS_EDUCATION_TYPE))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.SF_SS_EDUCATION_TYPE ").Append((cause.SF_SS_EDUCATION_TYPE.StartsWith("%") || cause.SF_SS_EDUCATION_TYPE.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_SS_EDUCATION_TYPE");
				param = new OracleParameter();
				param.ParameterName =":C_SF_SS_EDUCATION_TYPE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SF_SS_EDUCATION_TYPE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_SS_EDUCATION_TYPE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "SF_SS_EDUCATION_TYPE"));
			}
			if(cause.GBDAT!= null)
			{
				if (cause.GBDAT.Begin != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF_APPLY.GBDAT >= :C_GBDAT_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_GBDAT_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.GBDAT.Begin;
					paramList.Add(param);
				}
				if (cause.GBDAT.End != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF_APPLY.GBDAT < :C_GBDAT_END");
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
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "GBDAT"));
			}
			if(!string.IsNullOrEmpty(cause.RECRUIT_POSITION))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.RECRUIT_POSITION ").Append((cause.RECRUIT_POSITION.StartsWith("%") || cause.RECRUIT_POSITION.EndsWith("%")) ? " like " : " = ").Append(" :C_RECRUIT_POSITION");
				param = new OracleParameter();
				param.ParameterName =":C_RECRUIT_POSITION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 180;
				param.Value = cause.RECRUIT_POSITION;
				paramList.Add(param);
			}
			if (cause.HasINValue("RECRUIT_POSITION"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "RECRUIT_POSITION"));
			}
			if(cause.IS_SEND!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.IS_SEND = :C_IS_SEND");
				param = new OracleParameter();
				param.ParameterName =":C_IS_SEND";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_SEND;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_SEND"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "IS_SEND"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "ID"));
			}
			if(cause.PUBLISH_DATE!= null)
			{
				if (cause.PUBLISH_DATE.Begin != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF_APPLY.PUBLISH_DATE >= :C_PUBLISH_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_PUBLISH_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PUBLISH_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.PUBLISH_DATE.End != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF_APPLY.PUBLISH_DATE < :C_PUBLISH_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_PUBLISH_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PUBLISH_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("PUBLISH_DATE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "PUBLISH_DATE"));
			}
			if(cause.OPERATOR_ONE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.OPERATOR_ONE = :C_OPERATOR_ONE");
				param = new OracleParameter();
				param.ParameterName =":C_OPERATOR_ONE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.OPERATOR_ONE;
				paramList.Add(param);
			}
			if (cause.HasINValue("OPERATOR_ONE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "OPERATOR_ONE"));
			}
			if(cause.ZHRTZGG!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.ZHRTZGG = :C_ZHRTZGG");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRTZGG";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ZHRTZGG;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRTZGG"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "ZHRTZGG"));
			}
			if(cause.REAL_ZHRSLJZ!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.REAL_ZHRSLJZ = :C_REAL_ZHRSLJZ");
				param = new OracleParameter();
				param.ParameterName =":C_REAL_ZHRSLJZ";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.REAL_ZHRSLJZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("REAL_ZHRSLJZ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "REAL_ZHRSLJZ"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_TYPE_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.STAFF_TYPE_ID ").Append((cause.STAFF_TYPE_ID.StartsWith("%") || cause.STAFF_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "STAFF_TYPE_ID"));
			}
			if(cause.STAFF_IS_NURSE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.STAFF_IS_NURSE = :C_STAFF_IS_NURSE");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_IS_NURSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STAFF_IS_NURSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_IS_NURSE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "STAFF_IS_NURSE"));
			}
			if(!string.IsNullOrEmpty(cause.INSTI))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.INSTI ").Append((cause.INSTI.StartsWith("%") || cause.INSTI.EndsWith("%")) ? " like " : " = ").Append(" :C_INSTI");
				param = new OracleParameter();
				param.ParameterName =":C_INSTI";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.INSTI;
				paramList.Add(param);
			}
			if (cause.HasINValue("INSTI"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "INSTI"));
			}
			if(cause.CREATE_DATE!= null)
			{
				if (cause.CREATE_DATE.Begin != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF_APPLY.CREATE_DATE >= :C_CREATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_DATE.End != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF_APPLY.CREATE_DATE < :C_CREATE_DATE_END");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("CREATE_DATE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "CREATE_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.SEX))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.SEX ").Append((cause.SEX.StartsWith("%") || cause.SEX.EndsWith("%")) ? " like " : " = ").Append(" :C_SEX");
				param = new OracleParameter();
				param.ParameterName =":C_SEX";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 2;
				param.Value = cause.SEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEX"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "SEX"));
			}
			if(!string.IsNullOrEmpty(cause.FIRSTCHOICE))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.FIRSTCHOICE ").Append((cause.FIRSTCHOICE.StartsWith("%") || cause.FIRSTCHOICE.EndsWith("%")) ? " like " : " = ").Append(" :C_FIRSTCHOICE");
				param = new OracleParameter();
				param.ParameterName =":C_FIRSTCHOICE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.FIRSTCHOICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FIRSTCHOICE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "FIRSTCHOICE"));
			}
			if(!string.IsNullOrEmpty(cause.NACHN))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.NACHN ").Append((cause.NACHN.StartsWith("%") || cause.NACHN.EndsWith("%")) ? " like " : " = ").Append(" :C_NACHN");
				param = new OracleParameter();
				param.ParameterName =":C_NACHN";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.NACHN;
				paramList.Add(param);
			}
			if (cause.HasINValue("NACHN"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "NACHN"));
			}
			if(!string.IsNullOrEmpty(cause.SEND_ERROR))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.SEND_ERROR ").Append((cause.SEND_ERROR.StartsWith("%") || cause.SEND_ERROR.EndsWith("%")) ? " like " : " = ").Append(" :C_SEND_ERROR");
				param = new OracleParameter();
				param.ParameterName =":C_SEND_ERROR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.SEND_ERROR;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEND_ERROR"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "SEND_ERROR"));
			}
			if(!string.IsNullOrEmpty(cause.TYPE_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.TYPE_NAME ").Append((cause.TYPE_NAME.StartsWith("%") || cause.TYPE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_TYPE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_TYPE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.TYPE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "TYPE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRJG))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.ZHRJG ").Append((cause.ZHRJG.StartsWith("%") || cause.ZHRJG.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRJG");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRJG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.ZHRJG;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRJG"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "ZHRJG"));
			}
			if(!string.IsNullOrEmpty(cause.MANAGE_USER_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.MANAGE_USER_ID ").Append((cause.MANAGE_USER_ID.StartsWith("%") || cause.MANAGE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MANAGE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MANAGE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MANAGE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MANAGE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "MANAGE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.USER_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "USER_ID"));
			}
			if(cause.WRITTEN_ENGLISH!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.WRITTEN_ENGLISH = :C_WRITTEN_ENGLISH");
				param = new OracleParameter();
				param.ParameterName =":C_WRITTEN_ENGLISH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.WRITTEN_ENGLISH;
				paramList.Add(param);
			}
			if (cause.HasINValue("WRITTEN_ENGLISH"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "WRITTEN_ENGLISH"));
			}
			if(!string.IsNullOrEmpty(cause.MSSAGE_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY.MSSAGE_ID ").Append((cause.MSSAGE_ID.StartsWith("%") || cause.MSSAGE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MSSAGE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MSSAGE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MSSAGE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MSSAGE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY", "MSSAGE_ID"));
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
		public static DisplayObject_V_HEM_B_STAFF_APPLY[] Query(CauseObject_V_HEM_B_STAFF_APPLY cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
            string sSql = " select  V_HEM_B_STAFF_APPLY.WRITTEN_TOTAL, V_HEM_B_STAFF_APPLY.POSTER_ID, V_HEM_B_STAFF_APPLY.STAFF_IS_NURSE_NAME, V_HEM_B_STAFF_APPLY.SF_SS_EDUCATION_SLART, V_HEM_B_STAFF_APPLY.REAL_ZHRGRTZ, V_HEM_B_STAFF_APPLY.IS_CERTIFICATE, V_HEM_B_STAFF_APPLY.STATUS, V_HEM_B_STAFF_APPLY.END_DATE, V_HEM_B_STAFF_APPLY.ZHRGRTZ, V_HEM_B_STAFF_APPLY.POSTER_STATUS, V_HEM_B_STAFF_APPLY.ED_TYPE_NAME, V_HEM_B_STAFF_APPLY.CONTENT, V_HEM_B_STAFF_APPLY.TYPE_ID, V_HEM_B_STAFF_APPLY.IS_SEND_NAME, V_HEM_B_STAFF_APPLY.MANAGE_USER_ID_NAME, V_HEM_B_STAFF_APPLY.SEND_ID, V_HEM_B_STAFF_APPLY.USER_IS_USABL, V_HEM_B_STAFF_APPLY.IS_NURSE_NAME, V_HEM_B_STAFF_APPLY.IS_NURSE, V_HEM_B_STAFF_APPLY.DT_HH_EDUCATION_NAME, V_HEM_B_STAFF_APPLY.GESCH, V_HEM_B_STAFF_APPLY.REAL_ZHRGRSG, V_HEM_B_STAFF_APPLY.ACCOUNT, V_HEM_B_STAFF_APPLY.IS_PUBLIC, V_HEM_B_STAFF_APPLY.WRITTEN_THEORY, V_HEM_B_STAFF_APPLY.USRID_MAIL, V_HEM_B_STAFF_APPLY.REPLY_STATUS, V_HEM_B_STAFF_APPLY.PRACTICE_TYPE_ID_NAME, V_HEM_B_STAFF_APPLY.STAFF_ID, V_HEM_B_STAFF_APPLY.SLART_NAME, V_HEM_B_STAFF_APPLY.MANAGE_USER_IS_USABL, V_HEM_B_STAFF_APPLY.ZHRGRSG, V_HEM_B_STAFF_APPLY.TITLE, V_HEM_B_STAFF_APPLY.STATUS_NAME, V_HEM_B_STAFF_APPLY.USRID_TEL, V_HEM_B_STAFF_APPLY.SF_SS_EDUCATION_TYPE, V_HEM_B_STAFF_APPLY.GBDAT, V_HEM_B_STAFF_APPLY.RECRUIT_POSITION, V_HEM_B_STAFF_APPLY.IS_SEND, V_HEM_B_STAFF_APPLY.ID, V_HEM_B_STAFF_APPLY.PUBLISH_DATE, V_HEM_B_STAFF_APPLY.OPERATOR_ONE, V_HEM_B_STAFF_APPLY.ZHRTZGG, V_HEM_B_STAFF_APPLY.REAL_ZHRSLJZ, V_HEM_B_STAFF_APPLY.STAFF_TYPE_ID, V_HEM_B_STAFF_APPLY.STAFF_IS_NURSE, V_HEM_B_STAFF_APPLY.INSTI, V_HEM_B_STAFF_APPLY.CREATE_DATE, V_HEM_B_STAFF_APPLY.SEX, V_HEM_B_STAFF_APPLY.FIRSTCHOICE, V_HEM_B_STAFF_APPLY.NACHN, V_HEM_B_STAFF_APPLY.SEND_ERROR, V_HEM_B_STAFF_APPLY.TYPE_NAME, V_HEM_B_STAFF_APPLY.ZHRJG, V_HEM_B_STAFF_APPLY.MANAGE_USER_ID, V_HEM_B_STAFF_APPLY.USER_ID, V_HEM_B_STAFF_APPLY.WRITTEN_ENGLISH, V_HEM_B_STAFF_APPLY.MSSAGE_ID,V_HEM_B_STAFF_APPLY.FILE_PATH from V_HEM_B_STAFF_APPLY where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_B_STAFF_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.WRITTEN_TOTAL = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.POSTER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STAFF_IS_NURSE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SF_SS_EDUCATION_SLART = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATUS = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.END_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ZHRGRTZ = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.POSTER_STATUS = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ED_TYPE_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CONTENT = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.IS_SEND_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SEND_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IS_NURSE_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.DT_HH_EDUCATION_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.GESCH = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.ACCOUNT = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.USRID_MAIL = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.REPLY_STATUS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.PRACTICE_TYPE_ID_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.STAFF_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.SLART_NAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ZHRGRSG = sqlReader.GetDecimal(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.TITLE = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.STATUS_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.USRID_TEL = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.SF_SS_EDUCATION_TYPE = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.GBDAT = sqlReader.GetDateTime(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.IS_SEND = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.ZHRTZGG = sqlReader.GetDecimal(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.INSTI = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.SEX = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.NACHN = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.SEND_ERROR = sqlReader.GetString(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.TYPE_NAME = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.ZHRJG = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.USER_ID = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.MSSAGE_ID = sqlReader.GetString(57);
                if (!sqlReader.IsDBNull(58))
                    dataObj.FILE_PATH = sqlReader.GetString(58);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_STAFF_APPLY[] objs = new DisplayObject_V_HEM_B_STAFF_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_STAFF_APPLY[] Query(CauseObject_V_HEM_B_STAFF_APPLY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_HEM_B_STAFF_APPLY.WRITTEN_TOTAL, V_HEM_B_STAFF_APPLY.POSTER_ID, V_HEM_B_STAFF_APPLY.STAFF_IS_NURSE_NAME, V_HEM_B_STAFF_APPLY.SF_SS_EDUCATION_SLART, V_HEM_B_STAFF_APPLY.REAL_ZHRGRTZ, V_HEM_B_STAFF_APPLY.IS_CERTIFICATE, V_HEM_B_STAFF_APPLY.STATUS, V_HEM_B_STAFF_APPLY.END_DATE, V_HEM_B_STAFF_APPLY.ZHRGRTZ, V_HEM_B_STAFF_APPLY.POSTER_STATUS, V_HEM_B_STAFF_APPLY.ED_TYPE_NAME, V_HEM_B_STAFF_APPLY.CONTENT, V_HEM_B_STAFF_APPLY.TYPE_ID, V_HEM_B_STAFF_APPLY.IS_SEND_NAME, V_HEM_B_STAFF_APPLY.MANAGE_USER_ID_NAME, V_HEM_B_STAFF_APPLY.SEND_ID, V_HEM_B_STAFF_APPLY.USER_IS_USABL, V_HEM_B_STAFF_APPLY.IS_NURSE_NAME, V_HEM_B_STAFF_APPLY.IS_NURSE, V_HEM_B_STAFF_APPLY.DT_HH_EDUCATION_NAME, V_HEM_B_STAFF_APPLY.GESCH, V_HEM_B_STAFF_APPLY.REAL_ZHRGRSG, V_HEM_B_STAFF_APPLY.ACCOUNT, V_HEM_B_STAFF_APPLY.IS_PUBLIC, V_HEM_B_STAFF_APPLY.WRITTEN_THEORY, V_HEM_B_STAFF_APPLY.USRID_MAIL, V_HEM_B_STAFF_APPLY.REPLY_STATUS, V_HEM_B_STAFF_APPLY.PRACTICE_TYPE_ID_NAME, V_HEM_B_STAFF_APPLY.STAFF_ID, V_HEM_B_STAFF_APPLY.SLART_NAME, V_HEM_B_STAFF_APPLY.MANAGE_USER_IS_USABL, V_HEM_B_STAFF_APPLY.ZHRGRSG, V_HEM_B_STAFF_APPLY.TITLE, V_HEM_B_STAFF_APPLY.STATUS_NAME, V_HEM_B_STAFF_APPLY.USRID_TEL, V_HEM_B_STAFF_APPLY.SF_SS_EDUCATION_TYPE, V_HEM_B_STAFF_APPLY.GBDAT, V_HEM_B_STAFF_APPLY.RECRUIT_POSITION, V_HEM_B_STAFF_APPLY.IS_SEND, V_HEM_B_STAFF_APPLY.ID, V_HEM_B_STAFF_APPLY.PUBLISH_DATE, V_HEM_B_STAFF_APPLY.OPERATOR_ONE, V_HEM_B_STAFF_APPLY.ZHRTZGG, V_HEM_B_STAFF_APPLY.REAL_ZHRSLJZ, V_HEM_B_STAFF_APPLY.STAFF_TYPE_ID, V_HEM_B_STAFF_APPLY.STAFF_IS_NURSE, V_HEM_B_STAFF_APPLY.INSTI, V_HEM_B_STAFF_APPLY.CREATE_DATE, V_HEM_B_STAFF_APPLY.SEX, V_HEM_B_STAFF_APPLY.FIRSTCHOICE, V_HEM_B_STAFF_APPLY.NACHN, V_HEM_B_STAFF_APPLY.SEND_ERROR, V_HEM_B_STAFF_APPLY.TYPE_NAME, V_HEM_B_STAFF_APPLY.ZHRJG, V_HEM_B_STAFF_APPLY.MANAGE_USER_ID, V_HEM_B_STAFF_APPLY.USER_ID, V_HEM_B_STAFF_APPLY.WRITTEN_ENGLISH, V_HEM_B_STAFF_APPLY.MSSAGE_ID from V_HEM_B_STAFF_APPLY where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_B_STAFF_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.WRITTEN_TOTAL = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.POSTER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STAFF_IS_NURSE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SF_SS_EDUCATION_SLART = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATUS = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.END_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ZHRGRTZ = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.POSTER_STATUS = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ED_TYPE_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CONTENT = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.IS_SEND_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SEND_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IS_NURSE_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.DT_HH_EDUCATION_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.GESCH = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.ACCOUNT = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.USRID_MAIL = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.REPLY_STATUS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.PRACTICE_TYPE_ID_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.STAFF_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.SLART_NAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ZHRGRSG = sqlReader.GetDecimal(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.TITLE = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.STATUS_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.USRID_TEL = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.SF_SS_EDUCATION_TYPE = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.GBDAT = sqlReader.GetDateTime(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.IS_SEND = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.ZHRTZGG = sqlReader.GetDecimal(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.INSTI = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.SEX = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.NACHN = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.SEND_ERROR = sqlReader.GetString(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.TYPE_NAME = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.ZHRJG = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.USER_ID = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.MSSAGE_ID = sqlReader.GetString(57);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_B_STAFF_APPLY[] objs = new DisplayObject_V_HEM_B_STAFF_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_STAFF_APPLY[] Query(CauseObject_V_HEM_B_STAFF_APPLY cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
            string sSql = " select  V_HEM_B_STAFF_APPLY.WRITTEN_TOTAL, V_HEM_B_STAFF_APPLY.POSTER_ID, V_HEM_B_STAFF_APPLY.STAFF_IS_NURSE_NAME, V_HEM_B_STAFF_APPLY.SF_SS_EDUCATION_SLART, V_HEM_B_STAFF_APPLY.REAL_ZHRGRTZ, V_HEM_B_STAFF_APPLY.IS_CERTIFICATE, V_HEM_B_STAFF_APPLY.STATUS, V_HEM_B_STAFF_APPLY.END_DATE, V_HEM_B_STAFF_APPLY.ZHRGRTZ, V_HEM_B_STAFF_APPLY.POSTER_STATUS, V_HEM_B_STAFF_APPLY.ED_TYPE_NAME, V_HEM_B_STAFF_APPLY.CONTENT, V_HEM_B_STAFF_APPLY.TYPE_ID, V_HEM_B_STAFF_APPLY.IS_SEND_NAME, V_HEM_B_STAFF_APPLY.MANAGE_USER_ID_NAME, V_HEM_B_STAFF_APPLY.SEND_ID, V_HEM_B_STAFF_APPLY.USER_IS_USABL, V_HEM_B_STAFF_APPLY.IS_NURSE_NAME, V_HEM_B_STAFF_APPLY.IS_NURSE, V_HEM_B_STAFF_APPLY.DT_HH_EDUCATION_NAME, V_HEM_B_STAFF_APPLY.GESCH, V_HEM_B_STAFF_APPLY.REAL_ZHRGRSG, V_HEM_B_STAFF_APPLY.ACCOUNT, V_HEM_B_STAFF_APPLY.IS_PUBLIC, V_HEM_B_STAFF_APPLY.WRITTEN_THEORY, V_HEM_B_STAFF_APPLY.USRID_MAIL, V_HEM_B_STAFF_APPLY.REPLY_STATUS, V_HEM_B_STAFF_APPLY.PRACTICE_TYPE_ID_NAME, V_HEM_B_STAFF_APPLY.STAFF_ID, V_HEM_B_STAFF_APPLY.SLART_NAME, V_HEM_B_STAFF_APPLY.MANAGE_USER_IS_USABL, V_HEM_B_STAFF_APPLY.ZHRGRSG, V_HEM_B_STAFF_APPLY.TITLE, V_HEM_B_STAFF_APPLY.STATUS_NAME, V_HEM_B_STAFF_APPLY.USRID_TEL, V_HEM_B_STAFF_APPLY.SF_SS_EDUCATION_TYPE, V_HEM_B_STAFF_APPLY.GBDAT, V_HEM_B_STAFF_APPLY.RECRUIT_POSITION, V_HEM_B_STAFF_APPLY.IS_SEND, V_HEM_B_STAFF_APPLY.ID, V_HEM_B_STAFF_APPLY.PUBLISH_DATE, V_HEM_B_STAFF_APPLY.OPERATOR_ONE, V_HEM_B_STAFF_APPLY.ZHRTZGG, V_HEM_B_STAFF_APPLY.REAL_ZHRSLJZ, V_HEM_B_STAFF_APPLY.STAFF_TYPE_ID, V_HEM_B_STAFF_APPLY.STAFF_IS_NURSE, V_HEM_B_STAFF_APPLY.INSTI, V_HEM_B_STAFF_APPLY.CREATE_DATE, V_HEM_B_STAFF_APPLY.SEX, V_HEM_B_STAFF_APPLY.FIRSTCHOICE, V_HEM_B_STAFF_APPLY.NACHN, V_HEM_B_STAFF_APPLY.SEND_ERROR, V_HEM_B_STAFF_APPLY.TYPE_NAME, V_HEM_B_STAFF_APPLY.ZHRJG, V_HEM_B_STAFF_APPLY.MANAGE_USER_ID, V_HEM_B_STAFF_APPLY.USER_ID, V_HEM_B_STAFF_APPLY.WRITTEN_ENGLISH, V_HEM_B_STAFF_APPLY.MSSAGE_ID,V_HEM_B_STAFF_APPLY.OUTOCEAN from V_HEM_B_STAFF_APPLY where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_B_STAFF_APPLY",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_HEM_B_STAFF_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.WRITTEN_TOTAL = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.POSTER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STAFF_IS_NURSE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SF_SS_EDUCATION_SLART = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATUS = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.END_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ZHRGRTZ = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.POSTER_STATUS = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ED_TYPE_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CONTENT = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.IS_SEND_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SEND_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IS_NURSE_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.DT_HH_EDUCATION_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.GESCH = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.ACCOUNT = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.USRID_MAIL = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.REPLY_STATUS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.PRACTICE_TYPE_ID_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.STAFF_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.SLART_NAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ZHRGRSG = sqlReader.GetDecimal(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.TITLE = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.STATUS_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.USRID_TEL = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.SF_SS_EDUCATION_TYPE = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.GBDAT = sqlReader.GetDateTime(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.IS_SEND = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.ZHRTZGG = sqlReader.GetDecimal(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.INSTI = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.SEX = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.NACHN = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.SEND_ERROR = sqlReader.GetString(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.TYPE_NAME = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.ZHRJG = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.USER_ID = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.MSSAGE_ID = sqlReader.GetString(57);
                if (!sqlReader.IsDBNull(58))
                    dataObj.OUTOCEAN = sqlReader.GetString(58);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_STAFF_APPLY[] objs = new DisplayObject_V_HEM_B_STAFF_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_STAFF_APPLY[] Query(CauseObject_V_HEM_B_STAFF_APPLY cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_HEM_B_STAFF_APPLY.WRITTEN_TOTAL, V_HEM_B_STAFF_APPLY.POSTER_ID, V_HEM_B_STAFF_APPLY.STAFF_IS_NURSE_NAME, V_HEM_B_STAFF_APPLY.SF_SS_EDUCATION_SLART, V_HEM_B_STAFF_APPLY.REAL_ZHRGRTZ, V_HEM_B_STAFF_APPLY.IS_CERTIFICATE, V_HEM_B_STAFF_APPLY.STATUS, V_HEM_B_STAFF_APPLY.END_DATE, V_HEM_B_STAFF_APPLY.ZHRGRTZ, V_HEM_B_STAFF_APPLY.POSTER_STATUS, V_HEM_B_STAFF_APPLY.ED_TYPE_NAME, V_HEM_B_STAFF_APPLY.CONTENT, V_HEM_B_STAFF_APPLY.TYPE_ID, V_HEM_B_STAFF_APPLY.IS_SEND_NAME, V_HEM_B_STAFF_APPLY.MANAGE_USER_ID_NAME, V_HEM_B_STAFF_APPLY.SEND_ID, V_HEM_B_STAFF_APPLY.USER_IS_USABL, V_HEM_B_STAFF_APPLY.IS_NURSE_NAME, V_HEM_B_STAFF_APPLY.IS_NURSE, V_HEM_B_STAFF_APPLY.DT_HH_EDUCATION_NAME, V_HEM_B_STAFF_APPLY.GESCH, V_HEM_B_STAFF_APPLY.REAL_ZHRGRSG, V_HEM_B_STAFF_APPLY.ACCOUNT, V_HEM_B_STAFF_APPLY.IS_PUBLIC, V_HEM_B_STAFF_APPLY.WRITTEN_THEORY, V_HEM_B_STAFF_APPLY.USRID_MAIL, V_HEM_B_STAFF_APPLY.REPLY_STATUS, V_HEM_B_STAFF_APPLY.PRACTICE_TYPE_ID_NAME, V_HEM_B_STAFF_APPLY.STAFF_ID, V_HEM_B_STAFF_APPLY.SLART_NAME, V_HEM_B_STAFF_APPLY.MANAGE_USER_IS_USABL, V_HEM_B_STAFF_APPLY.ZHRGRSG, V_HEM_B_STAFF_APPLY.TITLE, V_HEM_B_STAFF_APPLY.STATUS_NAME, V_HEM_B_STAFF_APPLY.USRID_TEL, V_HEM_B_STAFF_APPLY.SF_SS_EDUCATION_TYPE, V_HEM_B_STAFF_APPLY.GBDAT, V_HEM_B_STAFF_APPLY.RECRUIT_POSITION, V_HEM_B_STAFF_APPLY.IS_SEND, V_HEM_B_STAFF_APPLY.ID, V_HEM_B_STAFF_APPLY.PUBLISH_DATE, V_HEM_B_STAFF_APPLY.OPERATOR_ONE, V_HEM_B_STAFF_APPLY.ZHRTZGG, V_HEM_B_STAFF_APPLY.REAL_ZHRSLJZ, V_HEM_B_STAFF_APPLY.STAFF_TYPE_ID, V_HEM_B_STAFF_APPLY.STAFF_IS_NURSE, V_HEM_B_STAFF_APPLY.INSTI, V_HEM_B_STAFF_APPLY.CREATE_DATE, V_HEM_B_STAFF_APPLY.SEX, V_HEM_B_STAFF_APPLY.FIRSTCHOICE, V_HEM_B_STAFF_APPLY.NACHN, V_HEM_B_STAFF_APPLY.SEND_ERROR, V_HEM_B_STAFF_APPLY.TYPE_NAME, V_HEM_B_STAFF_APPLY.ZHRJG, V_HEM_B_STAFF_APPLY.MANAGE_USER_ID, V_HEM_B_STAFF_APPLY.USER_ID, V_HEM_B_STAFF_APPLY.WRITTEN_ENGLISH, V_HEM_B_STAFF_APPLY.MSSAGE_ID from V_HEM_B_STAFF_APPLY where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_B_STAFF_APPLY",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_HEM_B_STAFF_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.WRITTEN_TOTAL = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.POSTER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STAFF_IS_NURSE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SF_SS_EDUCATION_SLART = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.STATUS = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.END_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ZHRGRTZ = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.POSTER_STATUS = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ED_TYPE_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.CONTENT = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.IS_SEND_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.SEND_ID = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.IS_NURSE_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.DT_HH_EDUCATION_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.GESCH = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.ACCOUNT = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.USRID_MAIL = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.REPLY_STATUS = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.PRACTICE_TYPE_ID_NAME = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.STAFF_ID = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.SLART_NAME = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.ZHRGRSG = sqlReader.GetDecimal(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.TITLE = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.STATUS_NAME = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.USRID_TEL = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.SF_SS_EDUCATION_TYPE = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.GBDAT = sqlReader.GetDateTime(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.IS_SEND = sqlReader.GetDecimal(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.ID = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.ZHRTZGG = sqlReader.GetDecimal(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.INSTI = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.SEX = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.NACHN = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.SEND_ERROR = sqlReader.GetString(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.TYPE_NAME = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.ZHRJG = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.USER_ID = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.MSSAGE_ID = sqlReader.GetString(57);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_B_STAFF_APPLY[] objs = new DisplayObject_V_HEM_B_STAFF_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		#endregion 
	}
}
