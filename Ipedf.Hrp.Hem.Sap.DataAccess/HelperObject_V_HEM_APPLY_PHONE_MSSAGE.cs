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
	[CauseObject(typeof(CauseObject_V_HEM_APPLY_PHONE_MSSAGE))]	
	public partial class HelperObject_V_HEM_APPLY_PHONE_MSSAGE
	{		
		#region Method Blok
		public static DisplayObject_V_HEM_APPLY_PHONE_MSSAGE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_HEM_APPLY_PHONE_MSSAGE.IS_SEND_NAME, V_HEM_APPLY_PHONE_MSSAGE.SEND_TIME, V_HEM_APPLY_PHONE_MSSAGE.TYPE_NAME, V_HEM_APPLY_PHONE_MSSAGE.USER_IS_USABL, V_HEM_APPLY_PHONE_MSSAGE.STAFF_TYPE_ID, V_HEM_APPLY_PHONE_MSSAGE.TITLE, V_HEM_APPLY_PHONE_MSSAGE.MANAGE_USER_IS_USABL, V_HEM_APPLY_PHONE_MSSAGE.MANAGE_USER_ID, V_HEM_APPLY_PHONE_MSSAGE.ID, V_HEM_APPLY_PHONE_MSSAGE.MANAGE_USER_ID_NAME, V_HEM_APPLY_PHONE_MSSAGE.RECRUIT_POSITION, V_HEM_APPLY_PHONE_MSSAGE.SEND_ERROR, V_HEM_APPLY_PHONE_MSSAGE.APPLY_STATUS_NAME, V_HEM_APPLY_PHONE_MSSAGE.NACHN, V_HEM_APPLY_PHONE_MSSAGE.APPLY_STATUS, V_HEM_APPLY_PHONE_MSSAGE.IS_PUBLIC, V_HEM_APPLY_PHONE_MSSAGE.ACCOUNT, V_HEM_APPLY_PHONE_MSSAGE.SEND_PHONE, V_HEM_APPLY_PHONE_MSSAGE.CONTENT from V_HEM_APPLY_PHONE_MSSAGE where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_HEM_APPLY_PHONE_MSSAGE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_APPLY_PHONE_MSSAGE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_SEND_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SEND_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.TITLE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEND_ERROR = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.APPLY_STATUS_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.NACHN = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_STATUS = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ACCOUNT = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.SEND_PHONE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CONTENT = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_APPLY_PHONE_MSSAGE[] objs = new DisplayObject_V_HEM_APPLY_PHONE_MSSAGE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_HEM_APPLY_PHONE_MSSAGE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.IS_SEND_NAME))
			{
				strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.IS_SEND_NAME ").Append((cause.IS_SEND_NAME.StartsWith("%") || cause.IS_SEND_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_IS_SEND_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_IS_SEND_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 2;
				param.Value = cause.IS_SEND_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_SEND_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_APPLY_PHONE_MSSAGE", "IS_SEND_NAME"));
			}
			if(cause.SEND_TIME!= null)
			{
				if (cause.SEND_TIME.Begin != null)
				{
					strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.SEND_TIME >= :C_SEND_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_SEND_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.SEND_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.SEND_TIME.End != null)
				{
					strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.SEND_TIME < :C_SEND_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_SEND_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.SEND_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("SEND_TIME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_APPLY_PHONE_MSSAGE", "SEND_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.TYPE_NAME))
			{
				strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.TYPE_NAME ").Append((cause.TYPE_NAME.StartsWith("%") || cause.TYPE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_TYPE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_TYPE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.TYPE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_APPLY_PHONE_MSSAGE", "TYPE_NAME"));
			}
			if(cause.USER_IS_USABL!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.USER_IS_USABL = :C_USER_IS_USABL");
				param = new OracleParameter();
				param.ParameterName =":C_USER_IS_USABL";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.USER_IS_USABL;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_IS_USABL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_APPLY_PHONE_MSSAGE", "USER_IS_USABL"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_TYPE_ID))
			{
				strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.STAFF_TYPE_ID ").Append((cause.STAFF_TYPE_ID.StartsWith("%") || cause.STAFF_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_APPLY_PHONE_MSSAGE", "STAFF_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.TITLE))
			{
				strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.TITLE ").Append((cause.TITLE.StartsWith("%") || cause.TITLE.EndsWith("%")) ? " like " : " = ").Append(" :C_TITLE");
				param = new OracleParameter();
				param.ParameterName =":C_TITLE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 180;
				param.Value = cause.TITLE;
				paramList.Add(param);
			}
			if (cause.HasINValue("TITLE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_APPLY_PHONE_MSSAGE", "TITLE"));
			}
			if(cause.MANAGE_USER_IS_USABL!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.MANAGE_USER_IS_USABL = :C_MANAGE_USER_IS_USABL");
				param = new OracleParameter();
				param.ParameterName =":C_MANAGE_USER_IS_USABL";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MANAGE_USER_IS_USABL;
				paramList.Add(param);
			}
			if (cause.HasINValue("MANAGE_USER_IS_USABL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_APPLY_PHONE_MSSAGE", "MANAGE_USER_IS_USABL"));
			}
			if(!string.IsNullOrEmpty(cause.MANAGE_USER_ID))
			{
				strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.MANAGE_USER_ID ").Append((cause.MANAGE_USER_ID.StartsWith("%") || cause.MANAGE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MANAGE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MANAGE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MANAGE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MANAGE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_APPLY_PHONE_MSSAGE", "MANAGE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_APPLY_PHONE_MSSAGE", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.MANAGE_USER_ID_NAME))
			{
				strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.MANAGE_USER_ID_NAME ").Append((cause.MANAGE_USER_ID_NAME.StartsWith("%") || cause.MANAGE_USER_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_MANAGE_USER_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_MANAGE_USER_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MANAGE_USER_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("MANAGE_USER_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_APPLY_PHONE_MSSAGE", "MANAGE_USER_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.RECRUIT_POSITION))
			{
				strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.RECRUIT_POSITION ").Append((cause.RECRUIT_POSITION.StartsWith("%") || cause.RECRUIT_POSITION.EndsWith("%")) ? " like " : " = ").Append(" :C_RECRUIT_POSITION");
				param = new OracleParameter();
				param.ParameterName =":C_RECRUIT_POSITION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 180;
				param.Value = cause.RECRUIT_POSITION;
				paramList.Add(param);
			}
			if (cause.HasINValue("RECRUIT_POSITION"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_APPLY_PHONE_MSSAGE", "RECRUIT_POSITION"));
			}
			if(!string.IsNullOrEmpty(cause.SEND_ERROR))
			{
				strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.SEND_ERROR ").Append((cause.SEND_ERROR.StartsWith("%") || cause.SEND_ERROR.EndsWith("%")) ? " like " : " = ").Append(" :C_SEND_ERROR");
				param = new OracleParameter();
				param.ParameterName =":C_SEND_ERROR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.SEND_ERROR;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEND_ERROR"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_APPLY_PHONE_MSSAGE", "SEND_ERROR"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_STATUS_NAME))
			{
				strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.APPLY_STATUS_NAME ").Append((cause.APPLY_STATUS_NAME.StartsWith("%") || cause.APPLY_STATUS_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_STATUS_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_STATUS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.APPLY_STATUS_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_STATUS_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_APPLY_PHONE_MSSAGE", "APPLY_STATUS_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.NACHN))
			{
				strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.NACHN ").Append((cause.NACHN.StartsWith("%") || cause.NACHN.EndsWith("%")) ? " like " : " = ").Append(" :C_NACHN");
				param = new OracleParameter();
				param.ParameterName =":C_NACHN";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.NACHN;
				paramList.Add(param);
			}
			if (cause.HasINValue("NACHN"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_APPLY_PHONE_MSSAGE", "NACHN"));
			}
			if(cause.APPLY_STATUS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.APPLY_STATUS = :C_APPLY_STATUS");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.APPLY_STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_STATUS"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_APPLY_PHONE_MSSAGE", "APPLY_STATUS"));
			}
			if(cause.IS_PUBLIC!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.IS_PUBLIC = :C_IS_PUBLIC");
				param = new OracleParameter();
				param.ParameterName =":C_IS_PUBLIC";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_PUBLIC;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_PUBLIC"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_APPLY_PHONE_MSSAGE", "IS_PUBLIC"));
			}
			if(!string.IsNullOrEmpty(cause.ACCOUNT))
			{
				strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.ACCOUNT ").Append((cause.ACCOUNT.StartsWith("%") || cause.ACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :C_ACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_ACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = cause.ACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("ACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_APPLY_PHONE_MSSAGE", "ACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.SEND_PHONE))
			{
				strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.SEND_PHONE ").Append((cause.SEND_PHONE.StartsWith("%") || cause.SEND_PHONE.EndsWith("%")) ? " like " : " = ").Append(" :C_SEND_PHONE");
				param = new OracleParameter();
				param.ParameterName =":C_SEND_PHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = cause.SEND_PHONE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEND_PHONE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_APPLY_PHONE_MSSAGE", "SEND_PHONE"));
			}
			if(!string.IsNullOrEmpty(cause.CONTENT))
			{
				strBuf.Append(" And V_HEM_APPLY_PHONE_MSSAGE.CONTENT ").Append((cause.CONTENT.StartsWith("%") || cause.CONTENT.EndsWith("%")) ? " like " : " = ").Append(" :C_CONTENT");
				param = new OracleParameter();
				param.ParameterName =":C_CONTENT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 900;
				param.Value = cause.CONTENT;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTENT"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_APPLY_PHONE_MSSAGE", "CONTENT"));
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
		public static DisplayObject_V_HEM_APPLY_PHONE_MSSAGE[] Query(CauseObject_V_HEM_APPLY_PHONE_MSSAGE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_HEM_APPLY_PHONE_MSSAGE.IS_SEND_NAME, V_HEM_APPLY_PHONE_MSSAGE.SEND_TIME, V_HEM_APPLY_PHONE_MSSAGE.TYPE_NAME, V_HEM_APPLY_PHONE_MSSAGE.USER_IS_USABL, V_HEM_APPLY_PHONE_MSSAGE.STAFF_TYPE_ID, V_HEM_APPLY_PHONE_MSSAGE.TITLE, V_HEM_APPLY_PHONE_MSSAGE.MANAGE_USER_IS_USABL, V_HEM_APPLY_PHONE_MSSAGE.MANAGE_USER_ID, V_HEM_APPLY_PHONE_MSSAGE.ID, V_HEM_APPLY_PHONE_MSSAGE.MANAGE_USER_ID_NAME, V_HEM_APPLY_PHONE_MSSAGE.RECRUIT_POSITION, V_HEM_APPLY_PHONE_MSSAGE.SEND_ERROR, V_HEM_APPLY_PHONE_MSSAGE.APPLY_STATUS_NAME, V_HEM_APPLY_PHONE_MSSAGE.NACHN, V_HEM_APPLY_PHONE_MSSAGE.APPLY_STATUS, V_HEM_APPLY_PHONE_MSSAGE.IS_PUBLIC, V_HEM_APPLY_PHONE_MSSAGE.ACCOUNT, V_HEM_APPLY_PHONE_MSSAGE.SEND_PHONE, V_HEM_APPLY_PHONE_MSSAGE.CONTENT from V_HEM_APPLY_PHONE_MSSAGE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_APPLY_PHONE_MSSAGE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_APPLY_PHONE_MSSAGE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_SEND_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SEND_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.TITLE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEND_ERROR = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.APPLY_STATUS_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.NACHN = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_STATUS = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ACCOUNT = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.SEND_PHONE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CONTENT = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_APPLY_PHONE_MSSAGE[] objs = new DisplayObject_V_HEM_APPLY_PHONE_MSSAGE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_APPLY_PHONE_MSSAGE[] Query(CauseObject_V_HEM_APPLY_PHONE_MSSAGE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_HEM_APPLY_PHONE_MSSAGE.IS_SEND_NAME, V_HEM_APPLY_PHONE_MSSAGE.SEND_TIME, V_HEM_APPLY_PHONE_MSSAGE.TYPE_NAME, V_HEM_APPLY_PHONE_MSSAGE.USER_IS_USABL, V_HEM_APPLY_PHONE_MSSAGE.STAFF_TYPE_ID, V_HEM_APPLY_PHONE_MSSAGE.TITLE, V_HEM_APPLY_PHONE_MSSAGE.MANAGE_USER_IS_USABL, V_HEM_APPLY_PHONE_MSSAGE.MANAGE_USER_ID, V_HEM_APPLY_PHONE_MSSAGE.ID, V_HEM_APPLY_PHONE_MSSAGE.MANAGE_USER_ID_NAME, V_HEM_APPLY_PHONE_MSSAGE.RECRUIT_POSITION, V_HEM_APPLY_PHONE_MSSAGE.SEND_ERROR, V_HEM_APPLY_PHONE_MSSAGE.APPLY_STATUS_NAME, V_HEM_APPLY_PHONE_MSSAGE.NACHN, V_HEM_APPLY_PHONE_MSSAGE.APPLY_STATUS, V_HEM_APPLY_PHONE_MSSAGE.IS_PUBLIC, V_HEM_APPLY_PHONE_MSSAGE.ACCOUNT, V_HEM_APPLY_PHONE_MSSAGE.SEND_PHONE, V_HEM_APPLY_PHONE_MSSAGE.CONTENT from V_HEM_APPLY_PHONE_MSSAGE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_APPLY_PHONE_MSSAGE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_APPLY_PHONE_MSSAGE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_SEND_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SEND_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.TITLE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEND_ERROR = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.APPLY_STATUS_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.NACHN = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_STATUS = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ACCOUNT = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.SEND_PHONE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CONTENT = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_APPLY_PHONE_MSSAGE[] objs = new DisplayObject_V_HEM_APPLY_PHONE_MSSAGE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_APPLY_PHONE_MSSAGE[] Query(CauseObject_V_HEM_APPLY_PHONE_MSSAGE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_HEM_APPLY_PHONE_MSSAGE.IS_SEND_NAME, V_HEM_APPLY_PHONE_MSSAGE.SEND_TIME, V_HEM_APPLY_PHONE_MSSAGE.TYPE_NAME, V_HEM_APPLY_PHONE_MSSAGE.USER_IS_USABL, V_HEM_APPLY_PHONE_MSSAGE.STAFF_TYPE_ID, V_HEM_APPLY_PHONE_MSSAGE.TITLE, V_HEM_APPLY_PHONE_MSSAGE.MANAGE_USER_IS_USABL, V_HEM_APPLY_PHONE_MSSAGE.MANAGE_USER_ID, V_HEM_APPLY_PHONE_MSSAGE.ID, V_HEM_APPLY_PHONE_MSSAGE.MANAGE_USER_ID_NAME, V_HEM_APPLY_PHONE_MSSAGE.RECRUIT_POSITION, V_HEM_APPLY_PHONE_MSSAGE.SEND_ERROR, V_HEM_APPLY_PHONE_MSSAGE.APPLY_STATUS_NAME, V_HEM_APPLY_PHONE_MSSAGE.NACHN, V_HEM_APPLY_PHONE_MSSAGE.APPLY_STATUS, V_HEM_APPLY_PHONE_MSSAGE.IS_PUBLIC, V_HEM_APPLY_PHONE_MSSAGE.ACCOUNT, V_HEM_APPLY_PHONE_MSSAGE.SEND_PHONE, V_HEM_APPLY_PHONE_MSSAGE.CONTENT from V_HEM_APPLY_PHONE_MSSAGE where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_APPLY_PHONE_MSSAGE",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_HEM_APPLY_PHONE_MSSAGE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_APPLY_PHONE_MSSAGE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_SEND_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SEND_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.TITLE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEND_ERROR = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.APPLY_STATUS_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.NACHN = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_STATUS = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ACCOUNT = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.SEND_PHONE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CONTENT = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_APPLY_PHONE_MSSAGE[] objs = new DisplayObject_V_HEM_APPLY_PHONE_MSSAGE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_APPLY_PHONE_MSSAGE[] Query(CauseObject_V_HEM_APPLY_PHONE_MSSAGE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_HEM_APPLY_PHONE_MSSAGE.IS_SEND_NAME, V_HEM_APPLY_PHONE_MSSAGE.SEND_TIME, V_HEM_APPLY_PHONE_MSSAGE.TYPE_NAME, V_HEM_APPLY_PHONE_MSSAGE.USER_IS_USABL, V_HEM_APPLY_PHONE_MSSAGE.STAFF_TYPE_ID, V_HEM_APPLY_PHONE_MSSAGE.TITLE, V_HEM_APPLY_PHONE_MSSAGE.MANAGE_USER_IS_USABL, V_HEM_APPLY_PHONE_MSSAGE.MANAGE_USER_ID, V_HEM_APPLY_PHONE_MSSAGE.ID, V_HEM_APPLY_PHONE_MSSAGE.MANAGE_USER_ID_NAME, V_HEM_APPLY_PHONE_MSSAGE.RECRUIT_POSITION, V_HEM_APPLY_PHONE_MSSAGE.SEND_ERROR, V_HEM_APPLY_PHONE_MSSAGE.APPLY_STATUS_NAME, V_HEM_APPLY_PHONE_MSSAGE.NACHN, V_HEM_APPLY_PHONE_MSSAGE.APPLY_STATUS, V_HEM_APPLY_PHONE_MSSAGE.IS_PUBLIC, V_HEM_APPLY_PHONE_MSSAGE.ACCOUNT, V_HEM_APPLY_PHONE_MSSAGE.SEND_PHONE, V_HEM_APPLY_PHONE_MSSAGE.CONTENT from V_HEM_APPLY_PHONE_MSSAGE where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_APPLY_PHONE_MSSAGE",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_HEM_APPLY_PHONE_MSSAGE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_APPLY_PHONE_MSSAGE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_SEND_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SEND_TIME = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE_NAME = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.TITLE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEND_ERROR = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.APPLY_STATUS_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.NACHN = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_STATUS = sqlReader.GetDecimal(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ACCOUNT = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.SEND_PHONE = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CONTENT = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_APPLY_PHONE_MSSAGE[] objs = new DisplayObject_V_HEM_APPLY_PHONE_MSSAGE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		#endregion 
	}
}
