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
	[CauseObject(typeof(CauseObject_V_HEM_B_PHONE_CALLBARK))]	
	public partial class HelperObject_V_HEM_B_PHONE_CALLBARK
	{		
		#region Method Blok
		public static DisplayObject_V_HEM_B_PHONE_CALLBARK[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_HEM_B_PHONE_CALLBARK.TYPE_NAME, V_HEM_B_PHONE_CALLBARK.IS_PUBLIC, V_HEM_B_PHONE_CALLBARK.ID, V_HEM_B_PHONE_CALLBARK.STAFF_IS_NURSE, V_HEM_B_PHONE_CALLBARK.USER_IS_USABL, V_HEM_B_PHONE_CALLBARK.IS_NURSE_NAME, V_HEM_B_PHONE_CALLBARK.MOBILE, V_HEM_B_PHONE_CALLBARK.IS_NURSE, V_HEM_B_PHONE_CALLBARK.MANAGE_USER_IS_USABL, V_HEM_B_PHONE_CALLBARK.INSERTTIME, V_HEM_B_PHONE_CALLBARK.APPLY_ID, V_HEM_B_PHONE_CALLBARK.MANAGE_USER_ID, V_HEM_B_PHONE_CALLBARK.BARK_STATUS_NAME, V_HEM_B_PHONE_CALLBARK.MANAGE_USER_ID_NAME, V_HEM_B_PHONE_CALLBARK.RECRUIT_POSITION, V_HEM_B_PHONE_CALLBARK.BARK_STATUS, V_HEM_B_PHONE_CALLBARK.STAFF_TYPE_ID, V_HEM_B_PHONE_CALLBARK.NACHN, V_HEM_B_PHONE_CALLBARK.CONTENT, V_HEM_B_PHONE_CALLBARK.ACCOUNT, V_HEM_B_PHONE_CALLBARK.TASKID from V_HEM_B_PHONE_CALLBARK where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_HEM_B_PHONE_CALLBARK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_PHONE_CALLBARK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TYPE_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_NURSE_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MOBILE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.INSERTTIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BARK_STATUS_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BARK_STATUS = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.NACHN = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CONTENT = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ACCOUNT = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.TASKID = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_PHONE_CALLBARK[] objs = new DisplayObject_V_HEM_B_PHONE_CALLBARK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_HEM_B_PHONE_CALLBARK cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.TYPE_NAME))
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.TYPE_NAME ").Append((cause.TYPE_NAME.StartsWith("%") || cause.TYPE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_TYPE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_TYPE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.TYPE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "TYPE_NAME"));
			}
			if(cause.IS_PUBLIC!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.IS_PUBLIC = :C_IS_PUBLIC");
				param = new OracleParameter();
				param.ParameterName =":C_IS_PUBLIC";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_PUBLIC;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_PUBLIC"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "IS_PUBLIC"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "ID"));
			}
			if(cause.STAFF_IS_NURSE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.STAFF_IS_NURSE = :C_STAFF_IS_NURSE");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_IS_NURSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STAFF_IS_NURSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_IS_NURSE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "STAFF_IS_NURSE"));
			}
			if(cause.USER_IS_USABL!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.USER_IS_USABL = :C_USER_IS_USABL");
				param = new OracleParameter();
				param.ParameterName =":C_USER_IS_USABL";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.USER_IS_USABL;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_IS_USABL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "USER_IS_USABL"));
			}
			if(!string.IsNullOrEmpty(cause.IS_NURSE_NAME))
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.IS_NURSE_NAME ").Append((cause.IS_NURSE_NAME.StartsWith("%") || cause.IS_NURSE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_IS_NURSE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_IS_NURSE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 2;
				param.Value = cause.IS_NURSE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_NURSE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "IS_NURSE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.MOBILE))
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.MOBILE ").Append((cause.MOBILE.StartsWith("%") || cause.MOBILE.EndsWith("%")) ? " like " : " = ").Append(" :C_MOBILE");
				param = new OracleParameter();
				param.ParameterName =":C_MOBILE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MOBILE;
				paramList.Add(param);
			}
			if (cause.HasINValue("MOBILE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "MOBILE"));
			}
			if(cause.IS_NURSE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.IS_NURSE = :C_IS_NURSE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_NURSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_NURSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_NURSE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "IS_NURSE"));
			}
			if(cause.MANAGE_USER_IS_USABL!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.MANAGE_USER_IS_USABL = :C_MANAGE_USER_IS_USABL");
				param = new OracleParameter();
				param.ParameterName =":C_MANAGE_USER_IS_USABL";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MANAGE_USER_IS_USABL;
				paramList.Add(param);
			}
			if (cause.HasINValue("MANAGE_USER_IS_USABL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "MANAGE_USER_IS_USABL"));
			}
			if(cause.INSERTTIME!= null)
			{
				if (cause.INSERTTIME.Begin != null)
				{
					strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.INSERTTIME >= :C_INSERTTIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_INSERTTIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.INSERTTIME.Begin;
					paramList.Add(param);
				}
				if (cause.INSERTTIME.End != null)
				{
					strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.INSERTTIME < :C_INSERTTIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_INSERTTIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.INSERTTIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("INSERTTIME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "INSERTTIME"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_ID))
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.APPLY_ID ").Append((cause.APPLY_ID.StartsWith("%") || cause.APPLY_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_ID");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.APPLY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "APPLY_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MANAGE_USER_ID))
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.MANAGE_USER_ID ").Append((cause.MANAGE_USER_ID.StartsWith("%") || cause.MANAGE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MANAGE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MANAGE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MANAGE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MANAGE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "MANAGE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.BARK_STATUS_NAME))
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.BARK_STATUS_NAME ").Append((cause.BARK_STATUS_NAME.StartsWith("%") || cause.BARK_STATUS_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_BARK_STATUS_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_BARK_STATUS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.BARK_STATUS_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("BARK_STATUS_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "BARK_STATUS_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.MANAGE_USER_ID_NAME))
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.MANAGE_USER_ID_NAME ").Append((cause.MANAGE_USER_ID_NAME.StartsWith("%") || cause.MANAGE_USER_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_MANAGE_USER_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_MANAGE_USER_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MANAGE_USER_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("MANAGE_USER_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "MANAGE_USER_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.RECRUIT_POSITION))
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.RECRUIT_POSITION ").Append((cause.RECRUIT_POSITION.StartsWith("%") || cause.RECRUIT_POSITION.EndsWith("%")) ? " like " : " = ").Append(" :C_RECRUIT_POSITION");
				param = new OracleParameter();
				param.ParameterName =":C_RECRUIT_POSITION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.RECRUIT_POSITION;
				paramList.Add(param);
			}
			if (cause.HasINValue("RECRUIT_POSITION"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "RECRUIT_POSITION"));
			}
			if(cause.BARK_STATUS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.BARK_STATUS = :C_BARK_STATUS");
				param = new OracleParameter();
				param.ParameterName =":C_BARK_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.BARK_STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("BARK_STATUS"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "BARK_STATUS"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_TYPE_ID))
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.STAFF_TYPE_ID ").Append((cause.STAFF_TYPE_ID.StartsWith("%") || cause.STAFF_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "STAFF_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.NACHN))
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.NACHN ").Append((cause.NACHN.StartsWith("%") || cause.NACHN.EndsWith("%")) ? " like " : " = ").Append(" :C_NACHN");
				param = new OracleParameter();
				param.ParameterName =":C_NACHN";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 40;
				param.Value = cause.NACHN;
				paramList.Add(param);
			}
			if (cause.HasINValue("NACHN"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "NACHN"));
			}
			if(!string.IsNullOrEmpty(cause.CONTENT))
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.CONTENT ").Append((cause.CONTENT.StartsWith("%") || cause.CONTENT.EndsWith("%")) ? " like " : " = ").Append(" :C_CONTENT");
				param = new OracleParameter();
				param.ParameterName =":C_CONTENT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.CONTENT;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTENT"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "CONTENT"));
			}
			if(!string.IsNullOrEmpty(cause.ACCOUNT))
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.ACCOUNT ").Append((cause.ACCOUNT.StartsWith("%") || cause.ACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :C_ACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_ACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = cause.ACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("ACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "ACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.TASKID))
			{
				strBuf.Append(" And V_HEM_B_PHONE_CALLBARK.TASKID ").Append((cause.TASKID.StartsWith("%") || cause.TASKID.EndsWith("%")) ? " like " : " = ").Append(" :C_TASKID");
				param = new OracleParameter();
				param.ParameterName =":C_TASKID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.TASKID;
				paramList.Add(param);
			}
			if (cause.HasINValue("TASKID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_PHONE_CALLBARK", "TASKID"));
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
		public static DisplayObject_V_HEM_B_PHONE_CALLBARK[] Query(CauseObject_V_HEM_B_PHONE_CALLBARK cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_HEM_B_PHONE_CALLBARK.TYPE_NAME, V_HEM_B_PHONE_CALLBARK.IS_PUBLIC, V_HEM_B_PHONE_CALLBARK.ID, V_HEM_B_PHONE_CALLBARK.STAFF_IS_NURSE, V_HEM_B_PHONE_CALLBARK.USER_IS_USABL, V_HEM_B_PHONE_CALLBARK.IS_NURSE_NAME, V_HEM_B_PHONE_CALLBARK.MOBILE, V_HEM_B_PHONE_CALLBARK.IS_NURSE, V_HEM_B_PHONE_CALLBARK.MANAGE_USER_IS_USABL, V_HEM_B_PHONE_CALLBARK.INSERTTIME, V_HEM_B_PHONE_CALLBARK.APPLY_ID, V_HEM_B_PHONE_CALLBARK.MANAGE_USER_ID, V_HEM_B_PHONE_CALLBARK.BARK_STATUS_NAME, V_HEM_B_PHONE_CALLBARK.MANAGE_USER_ID_NAME, V_HEM_B_PHONE_CALLBARK.RECRUIT_POSITION, V_HEM_B_PHONE_CALLBARK.BARK_STATUS, V_HEM_B_PHONE_CALLBARK.STAFF_TYPE_ID, V_HEM_B_PHONE_CALLBARK.NACHN, V_HEM_B_PHONE_CALLBARK.CONTENT, V_HEM_B_PHONE_CALLBARK.ACCOUNT, V_HEM_B_PHONE_CALLBARK.TASKID from V_HEM_B_PHONE_CALLBARK where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_B_PHONE_CALLBARK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_PHONE_CALLBARK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TYPE_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_NURSE_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MOBILE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.INSERTTIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BARK_STATUS_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BARK_STATUS = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.NACHN = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CONTENT = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ACCOUNT = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.TASKID = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_PHONE_CALLBARK[] objs = new DisplayObject_V_HEM_B_PHONE_CALLBARK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_PHONE_CALLBARK[] Query(CauseObject_V_HEM_B_PHONE_CALLBARK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_HEM_B_PHONE_CALLBARK.TYPE_NAME, V_HEM_B_PHONE_CALLBARK.IS_PUBLIC, V_HEM_B_PHONE_CALLBARK.ID, V_HEM_B_PHONE_CALLBARK.STAFF_IS_NURSE, V_HEM_B_PHONE_CALLBARK.USER_IS_USABL, V_HEM_B_PHONE_CALLBARK.IS_NURSE_NAME, V_HEM_B_PHONE_CALLBARK.MOBILE, V_HEM_B_PHONE_CALLBARK.IS_NURSE, V_HEM_B_PHONE_CALLBARK.MANAGE_USER_IS_USABL, V_HEM_B_PHONE_CALLBARK.INSERTTIME, V_HEM_B_PHONE_CALLBARK.APPLY_ID, V_HEM_B_PHONE_CALLBARK.MANAGE_USER_ID, V_HEM_B_PHONE_CALLBARK.BARK_STATUS_NAME, V_HEM_B_PHONE_CALLBARK.MANAGE_USER_ID_NAME, V_HEM_B_PHONE_CALLBARK.RECRUIT_POSITION, V_HEM_B_PHONE_CALLBARK.BARK_STATUS, V_HEM_B_PHONE_CALLBARK.STAFF_TYPE_ID, V_HEM_B_PHONE_CALLBARK.NACHN, V_HEM_B_PHONE_CALLBARK.CONTENT, V_HEM_B_PHONE_CALLBARK.ACCOUNT, V_HEM_B_PHONE_CALLBARK.TASKID from V_HEM_B_PHONE_CALLBARK where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_B_PHONE_CALLBARK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_PHONE_CALLBARK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TYPE_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_NURSE_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MOBILE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.INSERTTIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BARK_STATUS_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BARK_STATUS = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.NACHN = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CONTENT = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ACCOUNT = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.TASKID = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_B_PHONE_CALLBARK[] objs = new DisplayObject_V_HEM_B_PHONE_CALLBARK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_PHONE_CALLBARK[] Query(CauseObject_V_HEM_B_PHONE_CALLBARK cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_HEM_B_PHONE_CALLBARK.TYPE_NAME, V_HEM_B_PHONE_CALLBARK.IS_PUBLIC, V_HEM_B_PHONE_CALLBARK.ID, V_HEM_B_PHONE_CALLBARK.STAFF_IS_NURSE, V_HEM_B_PHONE_CALLBARK.USER_IS_USABL, V_HEM_B_PHONE_CALLBARK.IS_NURSE_NAME, V_HEM_B_PHONE_CALLBARK.MOBILE, V_HEM_B_PHONE_CALLBARK.IS_NURSE, V_HEM_B_PHONE_CALLBARK.MANAGE_USER_IS_USABL, V_HEM_B_PHONE_CALLBARK.INSERTTIME, V_HEM_B_PHONE_CALLBARK.APPLY_ID, V_HEM_B_PHONE_CALLBARK.MANAGE_USER_ID, V_HEM_B_PHONE_CALLBARK.BARK_STATUS_NAME, V_HEM_B_PHONE_CALLBARK.MANAGE_USER_ID_NAME, V_HEM_B_PHONE_CALLBARK.RECRUIT_POSITION, V_HEM_B_PHONE_CALLBARK.BARK_STATUS, V_HEM_B_PHONE_CALLBARK.STAFF_TYPE_ID, V_HEM_B_PHONE_CALLBARK.NACHN, V_HEM_B_PHONE_CALLBARK.CONTENT, V_HEM_B_PHONE_CALLBARK.ACCOUNT, V_HEM_B_PHONE_CALLBARK.TASKID from V_HEM_B_PHONE_CALLBARK where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_B_PHONE_CALLBARK",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_HEM_B_PHONE_CALLBARK dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_PHONE_CALLBARK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TYPE_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_NURSE_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MOBILE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.INSERTTIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BARK_STATUS_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BARK_STATUS = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.NACHN = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CONTENT = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ACCOUNT = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.TASKID = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_PHONE_CALLBARK[] objs = new DisplayObject_V_HEM_B_PHONE_CALLBARK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_PHONE_CALLBARK[] Query(CauseObject_V_HEM_B_PHONE_CALLBARK cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_HEM_B_PHONE_CALLBARK.TYPE_NAME, V_HEM_B_PHONE_CALLBARK.IS_PUBLIC, V_HEM_B_PHONE_CALLBARK.ID, V_HEM_B_PHONE_CALLBARK.STAFF_IS_NURSE, V_HEM_B_PHONE_CALLBARK.USER_IS_USABL, V_HEM_B_PHONE_CALLBARK.IS_NURSE_NAME, V_HEM_B_PHONE_CALLBARK.MOBILE, V_HEM_B_PHONE_CALLBARK.IS_NURSE, V_HEM_B_PHONE_CALLBARK.MANAGE_USER_IS_USABL, V_HEM_B_PHONE_CALLBARK.INSERTTIME, V_HEM_B_PHONE_CALLBARK.APPLY_ID, V_HEM_B_PHONE_CALLBARK.MANAGE_USER_ID, V_HEM_B_PHONE_CALLBARK.BARK_STATUS_NAME, V_HEM_B_PHONE_CALLBARK.MANAGE_USER_ID_NAME, V_HEM_B_PHONE_CALLBARK.RECRUIT_POSITION, V_HEM_B_PHONE_CALLBARK.BARK_STATUS, V_HEM_B_PHONE_CALLBARK.STAFF_TYPE_ID, V_HEM_B_PHONE_CALLBARK.NACHN, V_HEM_B_PHONE_CALLBARK.CONTENT, V_HEM_B_PHONE_CALLBARK.ACCOUNT, V_HEM_B_PHONE_CALLBARK.TASKID from V_HEM_B_PHONE_CALLBARK where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_B_PHONE_CALLBARK",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_HEM_B_PHONE_CALLBARK dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_PHONE_CALLBARK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.TYPE_NAME = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.IS_NURSE_NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.MOBILE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.INSERTTIME = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.APPLY_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.BARK_STATUS_NAME = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.BARK_STATUS = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.NACHN = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CONTENT = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ACCOUNT = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.TASKID = sqlReader.GetString(20);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_B_PHONE_CALLBARK[] objs = new DisplayObject_V_HEM_B_PHONE_CALLBARK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		#endregion 
	}
}
