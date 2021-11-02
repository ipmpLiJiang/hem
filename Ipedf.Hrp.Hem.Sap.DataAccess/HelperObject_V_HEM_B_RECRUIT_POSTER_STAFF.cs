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
	[CauseObject(typeof(CauseObject_V_HEM_B_RECRUIT_POSTER_STAFF))]	
	public partial class HelperObject_V_HEM_B_RECRUIT_POSTER_STAFF
	{		
		#region Method Blok
		public static DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_HEM_B_RECRUIT_POSTER_STAFF.PUBLISH_DATE, V_HEM_B_RECRUIT_POSTER_STAFF.ID, V_HEM_B_RECRUIT_POSTER_STAFF.DATA_SOURCE, V_HEM_B_RECRUIT_POSTER_STAFF.MODIFY_USER_ID, V_HEM_B_RECRUIT_POSTER_STAFF.IS_NURSE_NAME, V_HEM_B_RECRUIT_POSTER_STAFF.TITLE, V_HEM_B_RECRUIT_POSTER_STAFF.REMARK, V_HEM_B_RECRUIT_POSTER_STAFF.IS_NURSE, V_HEM_B_RECRUIT_POSTER_STAFF.PUBLISHER, V_HEM_B_RECRUIT_POSTER_STAFF.RECRUIT_POSITION, V_HEM_B_RECRUIT_POSTER_STAFF.USER_IS_USABL, V_HEM_B_RECRUIT_POSTER_STAFF.STATUS, V_HEM_B_RECRUIT_POSTER_STAFF.USER_ID, V_HEM_B_RECRUIT_POSTER_STAFF.END_DATE, V_HEM_B_RECRUIT_POSTER_STAFF.CREATE_DATE, V_HEM_B_RECRUIT_POSTER_STAFF.IS_PUBLIC, V_HEM_B_RECRUIT_POSTER_STAFF.ACCOUNT, V_HEM_B_RECRUIT_POSTER_STAFF.USER_ID_NAME, V_HEM_B_RECRUIT_POSTER_STAFF.CONTENT from V_HEM_B_RECRUIT_POSTER_STAFF where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_SOURCE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_NURSE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.TITLE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.REMARK = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PUBLISHER = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.STATUS = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.USER_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.END_DATE = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ACCOUNT = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CONTENT = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF[] objs = new DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_HEM_B_RECRUIT_POSTER_STAFF cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.PUBLISH_DATE!= null)
			{
				if (cause.PUBLISH_DATE.Begin != null)
				{
					strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.PUBLISH_DATE >= :C_PUBLISH_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_PUBLISH_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PUBLISH_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.PUBLISH_DATE.End != null)
				{
					strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.PUBLISH_DATE < :C_PUBLISH_DATE_END");
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
				strBuf.Append(cause.GetINSQL("V_HEM_B_RECRUIT_POSTER_STAFF", "PUBLISH_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_RECRUIT_POSTER_STAFF", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_SOURCE))
			{
				strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.DATA_SOURCE ").Append((cause.DATA_SOURCE.StartsWith("%") || cause.DATA_SOURCE.EndsWith("%")) ? " like " : " = ").Append(" :C_DATA_SOURCE");
				param = new OracleParameter();
				param.ParameterName =":C_DATA_SOURCE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.DATA_SOURCE;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_SOURCE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_RECRUIT_POSTER_STAFF", "DATA_SOURCE"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_RECRUIT_POSTER_STAFF", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.IS_NURSE_NAME))
			{
				strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.IS_NURSE_NAME ").Append((cause.IS_NURSE_NAME.StartsWith("%") || cause.IS_NURSE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_IS_NURSE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_IS_NURSE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 2;
				param.Value = cause.IS_NURSE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_NURSE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_RECRUIT_POSTER_STAFF", "IS_NURSE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.TITLE))
			{
				strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.TITLE ").Append((cause.TITLE.StartsWith("%") || cause.TITLE.EndsWith("%")) ? " like " : " = ").Append(" :C_TITLE");
				param = new OracleParameter();
				param.ParameterName =":C_TITLE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 180;
				param.Value = cause.TITLE;
				paramList.Add(param);
			}
			if (cause.HasINValue("TITLE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_RECRUIT_POSTER_STAFF", "TITLE"));
			}
			if(!string.IsNullOrEmpty(cause.REMARK))
			{
				strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.REMARK ").Append((cause.REMARK.StartsWith("%") || cause.REMARK.EndsWith("%")) ? " like " : " = ").Append(" :C_REMARK");
				param = new OracleParameter();
				param.ParameterName =":C_REMARK";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.REMARK;
				paramList.Add(param);
			}
			if (cause.HasINValue("REMARK"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_RECRUIT_POSTER_STAFF", "REMARK"));
			}
			if(cause.IS_NURSE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.IS_NURSE = :C_IS_NURSE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_NURSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_NURSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_NURSE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_RECRUIT_POSTER_STAFF", "IS_NURSE"));
			}
			if(!string.IsNullOrEmpty(cause.PUBLISHER))
			{
				strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.PUBLISHER ").Append((cause.PUBLISHER.StartsWith("%") || cause.PUBLISHER.EndsWith("%")) ? " like " : " = ").Append(" :C_PUBLISHER");
				param = new OracleParameter();
				param.ParameterName =":C_PUBLISHER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.PUBLISHER;
				paramList.Add(param);
			}
			if (cause.HasINValue("PUBLISHER"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_RECRUIT_POSTER_STAFF", "PUBLISHER"));
			}
			if(!string.IsNullOrEmpty(cause.RECRUIT_POSITION))
			{
				strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.RECRUIT_POSITION ").Append((cause.RECRUIT_POSITION.StartsWith("%") || cause.RECRUIT_POSITION.EndsWith("%")) ? " like " : " = ").Append(" :C_RECRUIT_POSITION");
				param = new OracleParameter();
				param.ParameterName =":C_RECRUIT_POSITION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 180;
				param.Value = cause.RECRUIT_POSITION;
				paramList.Add(param);
			}
			if (cause.HasINValue("RECRUIT_POSITION"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_RECRUIT_POSTER_STAFF", "RECRUIT_POSITION"));
			}
			if(cause.USER_IS_USABL!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.USER_IS_USABL = :C_USER_IS_USABL");
				param = new OracleParameter();
				param.ParameterName =":C_USER_IS_USABL";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.USER_IS_USABL;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_IS_USABL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_RECRUIT_POSTER_STAFF", "USER_IS_USABL"));
			}
			if(cause.STATUS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.STATUS = :C_STATUS");
				param = new OracleParameter();
				param.ParameterName =":C_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATUS"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_RECRUIT_POSTER_STAFF", "STATUS"));
			}
			if(!string.IsNullOrEmpty(cause.USER_ID))
			{
				strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_RECRUIT_POSTER_STAFF", "USER_ID"));
			}
			if(cause.END_DATE!= null)
			{
				if (cause.END_DATE.Begin != null)
				{
					strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.END_DATE >= :C_END_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_END_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.END_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.END_DATE.End != null)
				{
					strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.END_DATE < :C_END_DATE_END");
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
				strBuf.Append(cause.GetINSQL("V_HEM_B_RECRUIT_POSTER_STAFF", "END_DATE"));
			}
			if(cause.CREATE_DATE!= null)
			{
				if (cause.CREATE_DATE.Begin != null)
				{
					strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.CREATE_DATE >= :C_CREATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_DATE.End != null)
				{
					strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.CREATE_DATE < :C_CREATE_DATE_END");
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
				strBuf.Append(cause.GetINSQL("V_HEM_B_RECRUIT_POSTER_STAFF", "CREATE_DATE"));
			}
			if(cause.IS_PUBLIC!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.IS_PUBLIC = :C_IS_PUBLIC");
				param = new OracleParameter();
				param.ParameterName =":C_IS_PUBLIC";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_PUBLIC;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_PUBLIC"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_RECRUIT_POSTER_STAFF", "IS_PUBLIC"));
			}
			if(!string.IsNullOrEmpty(cause.ACCOUNT))
			{
				strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.ACCOUNT ").Append((cause.ACCOUNT.StartsWith("%") || cause.ACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :C_ACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_ACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = cause.ACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("ACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_RECRUIT_POSTER_STAFF", "ACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.USER_ID_NAME))
			{
				strBuf.Append(" And V_HEM_B_RECRUIT_POSTER_STAFF.USER_ID_NAME ").Append((cause.USER_ID_NAME.StartsWith("%") || cause.USER_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_USER_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_USER_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.USER_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_RECRUIT_POSTER_STAFF", "USER_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.CONTENT))
			{
				strBuf.Append(" And dbms_lob.compare(V_HEM_B_RECRUIT_POSTER_STAFF.CONTENT,:C_CONTENT) = 0 ");
				param = new OracleParameter();
				param.ParameterName =":C_CONTENT";
				param.OracleType = System.Data.OracleClient.OracleType.Clob;
				param.Size = 4000;
				param.Value = cause.CONTENT;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTENT"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_RECRUIT_POSTER_STAFF", "CONTENT"));
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
		public static DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF[] Query(CauseObject_V_HEM_B_RECRUIT_POSTER_STAFF cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_HEM_B_RECRUIT_POSTER_STAFF.PUBLISH_DATE, V_HEM_B_RECRUIT_POSTER_STAFF.ID, V_HEM_B_RECRUIT_POSTER_STAFF.DATA_SOURCE, V_HEM_B_RECRUIT_POSTER_STAFF.MODIFY_USER_ID, V_HEM_B_RECRUIT_POSTER_STAFF.IS_NURSE_NAME, V_HEM_B_RECRUIT_POSTER_STAFF.TITLE, V_HEM_B_RECRUIT_POSTER_STAFF.REMARK, V_HEM_B_RECRUIT_POSTER_STAFF.IS_NURSE, V_HEM_B_RECRUIT_POSTER_STAFF.PUBLISHER, V_HEM_B_RECRUIT_POSTER_STAFF.RECRUIT_POSITION, V_HEM_B_RECRUIT_POSTER_STAFF.USER_IS_USABL, V_HEM_B_RECRUIT_POSTER_STAFF.STATUS, V_HEM_B_RECRUIT_POSTER_STAFF.USER_ID, V_HEM_B_RECRUIT_POSTER_STAFF.END_DATE, V_HEM_B_RECRUIT_POSTER_STAFF.CREATE_DATE, V_HEM_B_RECRUIT_POSTER_STAFF.IS_PUBLIC, V_HEM_B_RECRUIT_POSTER_STAFF.ACCOUNT, V_HEM_B_RECRUIT_POSTER_STAFF.USER_ID_NAME, V_HEM_B_RECRUIT_POSTER_STAFF.CONTENT from V_HEM_B_RECRUIT_POSTER_STAFF where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_SOURCE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_NURSE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.TITLE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.REMARK = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PUBLISHER = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.STATUS = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.USER_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.END_DATE = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ACCOUNT = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CONTENT = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF[] objs = new DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF[] Query(CauseObject_V_HEM_B_RECRUIT_POSTER_STAFF cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_HEM_B_RECRUIT_POSTER_STAFF.PUBLISH_DATE, V_HEM_B_RECRUIT_POSTER_STAFF.ID, V_HEM_B_RECRUIT_POSTER_STAFF.DATA_SOURCE, V_HEM_B_RECRUIT_POSTER_STAFF.MODIFY_USER_ID, V_HEM_B_RECRUIT_POSTER_STAFF.IS_NURSE_NAME, V_HEM_B_RECRUIT_POSTER_STAFF.TITLE, V_HEM_B_RECRUIT_POSTER_STAFF.REMARK, V_HEM_B_RECRUIT_POSTER_STAFF.IS_NURSE, V_HEM_B_RECRUIT_POSTER_STAFF.PUBLISHER, V_HEM_B_RECRUIT_POSTER_STAFF.RECRUIT_POSITION, V_HEM_B_RECRUIT_POSTER_STAFF.USER_IS_USABL, V_HEM_B_RECRUIT_POSTER_STAFF.STATUS, V_HEM_B_RECRUIT_POSTER_STAFF.USER_ID, V_HEM_B_RECRUIT_POSTER_STAFF.END_DATE, V_HEM_B_RECRUIT_POSTER_STAFF.CREATE_DATE, V_HEM_B_RECRUIT_POSTER_STAFF.IS_PUBLIC, V_HEM_B_RECRUIT_POSTER_STAFF.ACCOUNT, V_HEM_B_RECRUIT_POSTER_STAFF.USER_ID_NAME, V_HEM_B_RECRUIT_POSTER_STAFF.CONTENT from V_HEM_B_RECRUIT_POSTER_STAFF where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_SOURCE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_NURSE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.TITLE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.REMARK = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PUBLISHER = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.STATUS = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.USER_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.END_DATE = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ACCOUNT = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CONTENT = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF[] objs = new DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF[] Query(CauseObject_V_HEM_B_RECRUIT_POSTER_STAFF cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_HEM_B_RECRUIT_POSTER_STAFF.PUBLISH_DATE, V_HEM_B_RECRUIT_POSTER_STAFF.ID, V_HEM_B_RECRUIT_POSTER_STAFF.DATA_SOURCE, V_HEM_B_RECRUIT_POSTER_STAFF.MODIFY_USER_ID, V_HEM_B_RECRUIT_POSTER_STAFF.IS_NURSE_NAME, V_HEM_B_RECRUIT_POSTER_STAFF.TITLE, V_HEM_B_RECRUIT_POSTER_STAFF.REMARK, V_HEM_B_RECRUIT_POSTER_STAFF.IS_NURSE, V_HEM_B_RECRUIT_POSTER_STAFF.PUBLISHER, V_HEM_B_RECRUIT_POSTER_STAFF.RECRUIT_POSITION, V_HEM_B_RECRUIT_POSTER_STAFF.USER_IS_USABL, V_HEM_B_RECRUIT_POSTER_STAFF.STATUS, V_HEM_B_RECRUIT_POSTER_STAFF.USER_ID, V_HEM_B_RECRUIT_POSTER_STAFF.END_DATE, V_HEM_B_RECRUIT_POSTER_STAFF.CREATE_DATE, V_HEM_B_RECRUIT_POSTER_STAFF.IS_PUBLIC, V_HEM_B_RECRUIT_POSTER_STAFF.ACCOUNT, V_HEM_B_RECRUIT_POSTER_STAFF.USER_ID_NAME, V_HEM_B_RECRUIT_POSTER_STAFF.CONTENT from V_HEM_B_RECRUIT_POSTER_STAFF where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_B_RECRUIT_POSTER_STAFF",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_SOURCE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_NURSE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.TITLE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.REMARK = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PUBLISHER = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.STATUS = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.USER_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.END_DATE = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ACCOUNT = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CONTENT = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF[] objs = new DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF[] Query(CauseObject_V_HEM_B_RECRUIT_POSTER_STAFF cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_HEM_B_RECRUIT_POSTER_STAFF.PUBLISH_DATE, V_HEM_B_RECRUIT_POSTER_STAFF.ID, V_HEM_B_RECRUIT_POSTER_STAFF.DATA_SOURCE, V_HEM_B_RECRUIT_POSTER_STAFF.MODIFY_USER_ID, V_HEM_B_RECRUIT_POSTER_STAFF.IS_NURSE_NAME, V_HEM_B_RECRUIT_POSTER_STAFF.TITLE, V_HEM_B_RECRUIT_POSTER_STAFF.REMARK, V_HEM_B_RECRUIT_POSTER_STAFF.IS_NURSE, V_HEM_B_RECRUIT_POSTER_STAFF.PUBLISHER, V_HEM_B_RECRUIT_POSTER_STAFF.RECRUIT_POSITION, V_HEM_B_RECRUIT_POSTER_STAFF.USER_IS_USABL, V_HEM_B_RECRUIT_POSTER_STAFF.STATUS, V_HEM_B_RECRUIT_POSTER_STAFF.USER_ID, V_HEM_B_RECRUIT_POSTER_STAFF.END_DATE, V_HEM_B_RECRUIT_POSTER_STAFF.CREATE_DATE, V_HEM_B_RECRUIT_POSTER_STAFF.IS_PUBLIC, V_HEM_B_RECRUIT_POSTER_STAFF.ACCOUNT, V_HEM_B_RECRUIT_POSTER_STAFF.USER_ID_NAME, V_HEM_B_RECRUIT_POSTER_STAFF.CONTENT from V_HEM_B_RECRUIT_POSTER_STAFF where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_B_RECRUIT_POSTER_STAFF",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.DATA_SOURCE = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_NURSE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.TITLE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.REMARK = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.PUBLISHER = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.STATUS = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.USER_ID = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.END_DATE = sqlReader.GetDateTime(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ACCOUNT = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.USER_ID_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.CONTENT = sqlReader.GetString(18);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF[] objs = new DisplayObject_V_HEM_B_RECRUIT_POSTER_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		#endregion 
	}
}
