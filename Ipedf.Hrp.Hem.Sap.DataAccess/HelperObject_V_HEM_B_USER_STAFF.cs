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
	[CauseObject(typeof(CauseObject_V_HEM_B_USER_STAFF))]	
	public partial class HelperObject_V_HEM_B_USER_STAFF
	{		
		#region Method Blok
		public static DisplayObject_V_HEM_B_USER_STAFF[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_HEM_B_USER_STAFF.STAFF_IS_NURSE, V_HEM_B_USER_STAFF.ID, V_HEM_B_USER_STAFF.TYPE_NAME, V_HEM_B_USER_STAFF.USER_IS_USABL, V_HEM_B_USER_STAFF.STAFF_TYPE_ID, V_HEM_B_USER_STAFF.IS_CERTIFICATE, V_HEM_B_USER_STAFF.USER_ID, V_HEM_B_USER_STAFF.GBDAT, V_HEM_B_USER_STAFF.RECRUIT_POSITION, V_HEM_B_USER_STAFF.INSTI, V_HEM_B_USER_STAFF.SLART_NAME, V_HEM_B_USER_STAFF.GESCH, V_HEM_B_USER_STAFF.TYPE_ID, V_HEM_B_USER_STAFF.NACHN, V_HEM_B_USER_STAFF.ZHRJG, V_HEM_B_USER_STAFF.USRID_TEL, V_HEM_B_USER_STAFF.STAFF_IS_NURSE_NAME, V_HEM_B_USER_STAFF.USRID_MAIL from V_HEM_B_USER_STAFF where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_HEM_B_USER_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_USER_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.GBDAT = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.INSTI = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SLART_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.GESCH = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.NACHN = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ZHRJG = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.USRID_TEL = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.STAFF_IS_NURSE_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.USRID_MAIL = sqlReader.GetString(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_USER_STAFF[] objs = new DisplayObject_V_HEM_B_USER_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_HEM_B_USER_STAFF cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.STAFF_IS_NURSE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_USER_STAFF.STAFF_IS_NURSE = :C_STAFF_IS_NURSE");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_IS_NURSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STAFF_IS_NURSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_IS_NURSE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_USER_STAFF", "STAFF_IS_NURSE"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_HEM_B_USER_STAFF.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_USER_STAFF", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.TYPE_NAME))
			{
				strBuf.Append(" And V_HEM_B_USER_STAFF.TYPE_NAME ").Append((cause.TYPE_NAME.StartsWith("%") || cause.TYPE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_TYPE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_TYPE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.TYPE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_USER_STAFF", "TYPE_NAME"));
			}
			if(cause.USER_IS_USABL!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_USER_STAFF.USER_IS_USABL = :C_USER_IS_USABL");
				param = new OracleParameter();
				param.ParameterName =":C_USER_IS_USABL";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.USER_IS_USABL;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_IS_USABL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_USER_STAFF", "USER_IS_USABL"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_TYPE_ID))
			{
				strBuf.Append(" And V_HEM_B_USER_STAFF.STAFF_TYPE_ID ").Append((cause.STAFF_TYPE_ID.StartsWith("%") || cause.STAFF_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_USER_STAFF", "STAFF_TYPE_ID"));
			}
			if(cause.IS_CERTIFICATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_USER_STAFF.IS_CERTIFICATE = :C_IS_CERTIFICATE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_CERTIFICATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_CERTIFICATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_CERTIFICATE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_USER_STAFF", "IS_CERTIFICATE"));
			}
			if(!string.IsNullOrEmpty(cause.USER_ID))
			{
				strBuf.Append(" And V_HEM_B_USER_STAFF.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_USER_STAFF", "USER_ID"));
			}
			if(cause.GBDAT!= null)
			{
				if (cause.GBDAT.Begin != null)
				{
					strBuf.Append(" And V_HEM_B_USER_STAFF.GBDAT >= :C_GBDAT_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_GBDAT_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.GBDAT.Begin;
					paramList.Add(param);
				}
				if (cause.GBDAT.End != null)
				{
					strBuf.Append(" And V_HEM_B_USER_STAFF.GBDAT < :C_GBDAT_END");
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
				strBuf.Append(cause.GetINSQL("V_HEM_B_USER_STAFF", "GBDAT"));
			}
			if(!string.IsNullOrEmpty(cause.RECRUIT_POSITION))
			{
				strBuf.Append(" And V_HEM_B_USER_STAFF.RECRUIT_POSITION ").Append((cause.RECRUIT_POSITION.StartsWith("%") || cause.RECRUIT_POSITION.EndsWith("%")) ? " like " : " = ").Append(" :C_RECRUIT_POSITION");
				param = new OracleParameter();
				param.ParameterName =":C_RECRUIT_POSITION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 4000;
				param.Value = cause.RECRUIT_POSITION;
				paramList.Add(param);
			}
			if (cause.HasINValue("RECRUIT_POSITION"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_USER_STAFF", "RECRUIT_POSITION"));
			}
			if(!string.IsNullOrEmpty(cause.INSTI))
			{
				strBuf.Append(" And V_HEM_B_USER_STAFF.INSTI ").Append((cause.INSTI.StartsWith("%") || cause.INSTI.EndsWith("%")) ? " like " : " = ").Append(" :C_INSTI");
				param = new OracleParameter();
				param.ParameterName =":C_INSTI";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.INSTI;
				paramList.Add(param);
			}
			if (cause.HasINValue("INSTI"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_USER_STAFF", "INSTI"));
			}
			if(!string.IsNullOrEmpty(cause.SLART_NAME))
			{
				strBuf.Append(" And V_HEM_B_USER_STAFF.SLART_NAME ").Append((cause.SLART_NAME.StartsWith("%") || cause.SLART_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_SLART_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_SLART_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SLART_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("SLART_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_USER_STAFF", "SLART_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.GESCH))
			{
				strBuf.Append(" And V_HEM_B_USER_STAFF.GESCH ").Append((cause.GESCH.StartsWith("%") || cause.GESCH.EndsWith("%")) ? " like " : " = ").Append(" :C_GESCH");
				param = new OracleParameter();
				param.ParameterName =":C_GESCH";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.GESCH;
				paramList.Add(param);
			}
			if (cause.HasINValue("GESCH"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_USER_STAFF", "GESCH"));
			}
			if(!string.IsNullOrEmpty(cause.TYPE_ID))
			{
				strBuf.Append(" And V_HEM_B_USER_STAFF.TYPE_ID ").Append((cause.TYPE_ID.StartsWith("%") || cause.TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_USER_STAFF", "TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.NACHN))
			{
				strBuf.Append(" And V_HEM_B_USER_STAFF.NACHN ").Append((cause.NACHN.StartsWith("%") || cause.NACHN.EndsWith("%")) ? " like " : " = ").Append(" :C_NACHN");
				param = new OracleParameter();
				param.ParameterName =":C_NACHN";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.NACHN;
				paramList.Add(param);
			}
			if (cause.HasINValue("NACHN"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_USER_STAFF", "NACHN"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRJG))
			{
				strBuf.Append(" And V_HEM_B_USER_STAFF.ZHRJG ").Append((cause.ZHRJG.StartsWith("%") || cause.ZHRJG.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRJG");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRJG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.ZHRJG;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRJG"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_USER_STAFF", "ZHRJG"));
			}
			if(!string.IsNullOrEmpty(cause.USRID_TEL))
			{
				strBuf.Append(" And V_HEM_B_USER_STAFF.USRID_TEL ").Append((cause.USRID_TEL.StartsWith("%") || cause.USRID_TEL.EndsWith("%")) ? " like " : " = ").Append(" :C_USRID_TEL");
				param = new OracleParameter();
				param.ParameterName =":C_USRID_TEL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = cause.USRID_TEL;
				paramList.Add(param);
			}
			if (cause.HasINValue("USRID_TEL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_USER_STAFF", "USRID_TEL"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_IS_NURSE_NAME))
			{
				strBuf.Append(" And V_HEM_B_USER_STAFF.STAFF_IS_NURSE_NAME ").Append((cause.STAFF_IS_NURSE_NAME.StartsWith("%") || cause.STAFF_IS_NURSE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_IS_NURSE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_IS_NURSE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 2;
				param.Value = cause.STAFF_IS_NURSE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_IS_NURSE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_USER_STAFF", "STAFF_IS_NURSE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.USRID_MAIL))
			{
				strBuf.Append(" And V_HEM_B_USER_STAFF.USRID_MAIL ").Append((cause.USRID_MAIL.StartsWith("%") || cause.USRID_MAIL.EndsWith("%")) ? " like " : " = ").Append(" :C_USRID_MAIL");
				param = new OracleParameter();
				param.ParameterName =":C_USRID_MAIL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.USRID_MAIL;
				paramList.Add(param);
			}
			if (cause.HasINValue("USRID_MAIL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_USER_STAFF", "USRID_MAIL"));
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
		public static DisplayObject_V_HEM_B_USER_STAFF[] Query(CauseObject_V_HEM_B_USER_STAFF cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_HEM_B_USER_STAFF.STAFF_IS_NURSE, V_HEM_B_USER_STAFF.ID, V_HEM_B_USER_STAFF.TYPE_NAME, V_HEM_B_USER_STAFF.USER_IS_USABL, V_HEM_B_USER_STAFF.STAFF_TYPE_ID, V_HEM_B_USER_STAFF.IS_CERTIFICATE, V_HEM_B_USER_STAFF.USER_ID, V_HEM_B_USER_STAFF.GBDAT, V_HEM_B_USER_STAFF.RECRUIT_POSITION, V_HEM_B_USER_STAFF.INSTI, V_HEM_B_USER_STAFF.SLART_NAME, V_HEM_B_USER_STAFF.GESCH, V_HEM_B_USER_STAFF.TYPE_ID, V_HEM_B_USER_STAFF.NACHN, V_HEM_B_USER_STAFF.ZHRJG, V_HEM_B_USER_STAFF.USRID_TEL, V_HEM_B_USER_STAFF.STAFF_IS_NURSE_NAME, V_HEM_B_USER_STAFF.USRID_MAIL from V_HEM_B_USER_STAFF where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_B_USER_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_USER_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.GBDAT = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.INSTI = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SLART_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.GESCH = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.NACHN = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ZHRJG = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.USRID_TEL = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.STAFF_IS_NURSE_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.USRID_MAIL = sqlReader.GetString(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_USER_STAFF[] objs = new DisplayObject_V_HEM_B_USER_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_USER_STAFF[] Query(CauseObject_V_HEM_B_USER_STAFF cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_HEM_B_USER_STAFF.STAFF_IS_NURSE, V_HEM_B_USER_STAFF.ID, V_HEM_B_USER_STAFF.TYPE_NAME, V_HEM_B_USER_STAFF.USER_IS_USABL, V_HEM_B_USER_STAFF.STAFF_TYPE_ID, V_HEM_B_USER_STAFF.IS_CERTIFICATE, V_HEM_B_USER_STAFF.USER_ID, V_HEM_B_USER_STAFF.GBDAT, V_HEM_B_USER_STAFF.RECRUIT_POSITION, V_HEM_B_USER_STAFF.INSTI, V_HEM_B_USER_STAFF.SLART_NAME, V_HEM_B_USER_STAFF.GESCH, V_HEM_B_USER_STAFF.TYPE_ID, V_HEM_B_USER_STAFF.NACHN, V_HEM_B_USER_STAFF.ZHRJG, V_HEM_B_USER_STAFF.USRID_TEL, V_HEM_B_USER_STAFF.STAFF_IS_NURSE_NAME, V_HEM_B_USER_STAFF.USRID_MAIL from V_HEM_B_USER_STAFF where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_B_USER_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_USER_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.GBDAT = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.INSTI = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SLART_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.GESCH = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.NACHN = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ZHRJG = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.USRID_TEL = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.STAFF_IS_NURSE_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.USRID_MAIL = sqlReader.GetString(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_B_USER_STAFF[] objs = new DisplayObject_V_HEM_B_USER_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_USER_STAFF[] Query(CauseObject_V_HEM_B_USER_STAFF cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_HEM_B_USER_STAFF.STAFF_IS_NURSE, V_HEM_B_USER_STAFF.ID, V_HEM_B_USER_STAFF.TYPE_NAME, V_HEM_B_USER_STAFF.USER_IS_USABL, V_HEM_B_USER_STAFF.STAFF_TYPE_ID, V_HEM_B_USER_STAFF.IS_CERTIFICATE, V_HEM_B_USER_STAFF.USER_ID, V_HEM_B_USER_STAFF.GBDAT, V_HEM_B_USER_STAFF.RECRUIT_POSITION, V_HEM_B_USER_STAFF.INSTI, V_HEM_B_USER_STAFF.SLART_NAME, V_HEM_B_USER_STAFF.GESCH, V_HEM_B_USER_STAFF.TYPE_ID, V_HEM_B_USER_STAFF.NACHN, V_HEM_B_USER_STAFF.ZHRJG, V_HEM_B_USER_STAFF.USRID_TEL, V_HEM_B_USER_STAFF.STAFF_IS_NURSE_NAME, V_HEM_B_USER_STAFF.USRID_MAIL from V_HEM_B_USER_STAFF where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_B_USER_STAFF",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_HEM_B_USER_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_USER_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.GBDAT = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.INSTI = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SLART_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.GESCH = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.NACHN = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ZHRJG = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.USRID_TEL = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.STAFF_IS_NURSE_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.USRID_MAIL = sqlReader.GetString(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_USER_STAFF[] objs = new DisplayObject_V_HEM_B_USER_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_USER_STAFF[] Query(CauseObject_V_HEM_B_USER_STAFF cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_HEM_B_USER_STAFF.STAFF_IS_NURSE, V_HEM_B_USER_STAFF.ID, V_HEM_B_USER_STAFF.TYPE_NAME, V_HEM_B_USER_STAFF.USER_IS_USABL, V_HEM_B_USER_STAFF.STAFF_TYPE_ID, V_HEM_B_USER_STAFF.IS_CERTIFICATE, V_HEM_B_USER_STAFF.USER_ID, V_HEM_B_USER_STAFF.GBDAT, V_HEM_B_USER_STAFF.RECRUIT_POSITION, V_HEM_B_USER_STAFF.INSTI, V_HEM_B_USER_STAFF.SLART_NAME, V_HEM_B_USER_STAFF.GESCH, V_HEM_B_USER_STAFF.TYPE_ID, V_HEM_B_USER_STAFF.NACHN, V_HEM_B_USER_STAFF.ZHRJG, V_HEM_B_USER_STAFF.USRID_TEL, V_HEM_B_USER_STAFF.STAFF_IS_NURSE_NAME, V_HEM_B_USER_STAFF.USRID_MAIL from V_HEM_B_USER_STAFF where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_B_USER_STAFF",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_HEM_B_USER_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_USER_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.GBDAT = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.INSTI = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.SLART_NAME = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.GESCH = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.TYPE_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.NACHN = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ZHRJG = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.USRID_TEL = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.STAFF_IS_NURSE_NAME = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.USRID_MAIL = sqlReader.GetString(17);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_B_USER_STAFF[] objs = new DisplayObject_V_HEM_B_USER_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		#endregion 
	}
}
