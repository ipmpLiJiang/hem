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
	[CauseObject(typeof(CauseObject_V_USER_LOGIN_INFO))]	
	public partial class HelperObject_V_USER_LOGIN_INFO
	{		
		#region Method Blok
		public static DisplayObject_V_USER_LOGIN_INFO[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_USER_LOGIN_INFO.ACCOUNT, V_USER_LOGIN_INFO.PASSWORD, V_USER_LOGIN_INFO.IS_USABL, V_USER_LOGIN_INFO.IS_USABL_NAME, V_USER_LOGIN_INFO.USER_ID, V_USER_LOGIN_INFO.NAME, V_USER_LOGIN_INFO.FLAG, V_USER_LOGIN_INFO.CREATE_DATE, V_USER_LOGIN_INFO.MOBILE, V_USER_LOGIN_INFO.ID, V_USER_LOGIN_INFO.WMC_IS_NURSE, V_USER_LOGIN_INFO.TYPE_ID_NAME, V_USER_LOGIN_INFO.EMAIL from V_USER_LOGIN_INFO where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_USER_LOGIN_INFO dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_USER_LOGIN_INFO();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PASSWORD = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IS_USABL = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.IS_USABL_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FLAG = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MOBILE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.WMC_IS_NURSE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.EMAIL = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_USER_LOGIN_INFO[] objs = new DisplayObject_V_USER_LOGIN_INFO[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_USER_LOGIN_INFO cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ACCOUNT))
			{
				strBuf.Append(" And V_USER_LOGIN_INFO.ACCOUNT ").Append((cause.ACCOUNT.StartsWith("%") || cause.ACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :C_ACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_ACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = cause.ACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("ACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_USER_LOGIN_INFO", "ACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.PASSWORD))
			{
				strBuf.Append(" And V_USER_LOGIN_INFO.PASSWORD ").Append((cause.PASSWORD.StartsWith("%") || cause.PASSWORD.EndsWith("%")) ? " like " : " = ").Append(" :C_PASSWORD");
				param = new OracleParameter();
				param.ParameterName =":C_PASSWORD";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PASSWORD;
				paramList.Add(param);
			}
			if (cause.HasINValue("PASSWORD"))
			{
				strBuf.Append(cause.GetINSQL("V_USER_LOGIN_INFO", "PASSWORD"));
			}
			if(cause.IS_USABL!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_USER_LOGIN_INFO.IS_USABL = :C_IS_USABL");
				param = new OracleParameter();
				param.ParameterName =":C_IS_USABL";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_USABL;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_USABL"))
			{
				strBuf.Append(cause.GetINSQL("V_USER_LOGIN_INFO", "IS_USABL"));
			}
			if(!string.IsNullOrEmpty(cause.IS_USABL_NAME))
			{
				strBuf.Append(" And V_USER_LOGIN_INFO.IS_USABL_NAME ").Append((cause.IS_USABL_NAME.StartsWith("%") || cause.IS_USABL_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_IS_USABL_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_IS_USABL_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 6;
				param.Value = cause.IS_USABL_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_USABL_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_USER_LOGIN_INFO", "IS_USABL_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.USER_ID))
			{
				strBuf.Append(" And V_USER_LOGIN_INFO.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_USER_LOGIN_INFO", "USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.NAME))
			{
				strBuf.Append(" And V_USER_LOGIN_INFO.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_USER_LOGIN_INFO", "NAME"));
			}
			if(cause.FLAG!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_USER_LOGIN_INFO.FLAG = :C_FLAG");
				param = new OracleParameter();
				param.ParameterName =":C_FLAG";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.FLAG;
				paramList.Add(param);
			}
			if (cause.HasINValue("FLAG"))
			{
				strBuf.Append(cause.GetINSQL("V_USER_LOGIN_INFO", "FLAG"));
			}
			if(cause.CREATE_DATE!= null)
			{
				if (cause.CREATE_DATE.Begin != null)
				{
					strBuf.Append(" And V_USER_LOGIN_INFO.CREATE_DATE >= :C_CREATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_DATE.End != null)
				{
					strBuf.Append(" And V_USER_LOGIN_INFO.CREATE_DATE < :C_CREATE_DATE_END");
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
				strBuf.Append(cause.GetINSQL("V_USER_LOGIN_INFO", "CREATE_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.MOBILE))
			{
				strBuf.Append(" And V_USER_LOGIN_INFO.MOBILE ").Append((cause.MOBILE.StartsWith("%") || cause.MOBILE.EndsWith("%")) ? " like " : " = ").Append(" :C_MOBILE");
				param = new OracleParameter();
				param.ParameterName =":C_MOBILE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = cause.MOBILE;
				paramList.Add(param);
			}
			if (cause.HasINValue("MOBILE"))
			{
				strBuf.Append(cause.GetINSQL("V_USER_LOGIN_INFO", "MOBILE"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_USER_LOGIN_INFO.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_USER_LOGIN_INFO", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.WMC_IS_NURSE))
			{
				strBuf.Append(" And V_USER_LOGIN_INFO.WMC_IS_NURSE ").Append((cause.WMC_IS_NURSE.StartsWith("%") || cause.WMC_IS_NURSE.EndsWith("%")) ? " like " : " = ").Append(" :C_WMC_IS_NURSE");
				param = new OracleParameter();
				param.ParameterName =":C_WMC_IS_NURSE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 4000;
				param.Value = cause.WMC_IS_NURSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("WMC_IS_NURSE"))
			{
				strBuf.Append(cause.GetINSQL("V_USER_LOGIN_INFO", "WMC_IS_NURSE"));
			}
			if(!string.IsNullOrEmpty(cause.TYPE_ID_NAME))
			{
				strBuf.Append(" And V_USER_LOGIN_INFO.TYPE_ID_NAME ").Append((cause.TYPE_ID_NAME.StartsWith("%") || cause.TYPE_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_TYPE_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_TYPE_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 4000;
				param.Value = cause.TYPE_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_USER_LOGIN_INFO", "TYPE_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.EMAIL))
			{
				strBuf.Append(" And V_USER_LOGIN_INFO.EMAIL ").Append((cause.EMAIL.StartsWith("%") || cause.EMAIL.EndsWith("%")) ? " like " : " = ").Append(" :C_EMAIL");
				param = new OracleParameter();
				param.ParameterName =":C_EMAIL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.EMAIL;
				paramList.Add(param);
			}
			if (cause.HasINValue("EMAIL"))
			{
				strBuf.Append(cause.GetINSQL("V_USER_LOGIN_INFO", "EMAIL"));
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
		public static DisplayObject_V_USER_LOGIN_INFO[] Query(CauseObject_V_USER_LOGIN_INFO cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_USER_LOGIN_INFO.ACCOUNT, V_USER_LOGIN_INFO.PASSWORD, V_USER_LOGIN_INFO.IS_USABL, V_USER_LOGIN_INFO.IS_USABL_NAME, V_USER_LOGIN_INFO.USER_ID, V_USER_LOGIN_INFO.NAME, V_USER_LOGIN_INFO.FLAG, V_USER_LOGIN_INFO.CREATE_DATE, V_USER_LOGIN_INFO.MOBILE, V_USER_LOGIN_INFO.ID, V_USER_LOGIN_INFO.WMC_IS_NURSE, V_USER_LOGIN_INFO.TYPE_ID_NAME, V_USER_LOGIN_INFO.EMAIL from V_USER_LOGIN_INFO where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_USER_LOGIN_INFO dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_USER_LOGIN_INFO();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PASSWORD = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IS_USABL = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.IS_USABL_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FLAG = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MOBILE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.WMC_IS_NURSE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.EMAIL = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_USER_LOGIN_INFO[] objs = new DisplayObject_V_USER_LOGIN_INFO[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_USER_LOGIN_INFO[] Query(CauseObject_V_USER_LOGIN_INFO cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_USER_LOGIN_INFO.ACCOUNT, V_USER_LOGIN_INFO.PASSWORD, V_USER_LOGIN_INFO.IS_USABL, V_USER_LOGIN_INFO.IS_USABL_NAME, V_USER_LOGIN_INFO.USER_ID, V_USER_LOGIN_INFO.NAME, V_USER_LOGIN_INFO.FLAG, V_USER_LOGIN_INFO.CREATE_DATE, V_USER_LOGIN_INFO.MOBILE, V_USER_LOGIN_INFO.ID, V_USER_LOGIN_INFO.WMC_IS_NURSE, V_USER_LOGIN_INFO.TYPE_ID_NAME, V_USER_LOGIN_INFO.EMAIL from V_USER_LOGIN_INFO where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_USER_LOGIN_INFO dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_USER_LOGIN_INFO();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PASSWORD = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IS_USABL = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.IS_USABL_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FLAG = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MOBILE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.WMC_IS_NURSE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.EMAIL = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_USER_LOGIN_INFO[] objs = new DisplayObject_V_USER_LOGIN_INFO[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_USER_LOGIN_INFO[] Query(CauseObject_V_USER_LOGIN_INFO cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_USER_LOGIN_INFO.ACCOUNT, V_USER_LOGIN_INFO.PASSWORD, V_USER_LOGIN_INFO.IS_USABL, V_USER_LOGIN_INFO.IS_USABL_NAME, V_USER_LOGIN_INFO.USER_ID, V_USER_LOGIN_INFO.NAME, V_USER_LOGIN_INFO.FLAG, V_USER_LOGIN_INFO.CREATE_DATE, V_USER_LOGIN_INFO.MOBILE, V_USER_LOGIN_INFO.ID, V_USER_LOGIN_INFO.WMC_IS_NURSE, V_USER_LOGIN_INFO.TYPE_ID_NAME, V_USER_LOGIN_INFO.EMAIL from V_USER_LOGIN_INFO where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_USER_LOGIN_INFO",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_USER_LOGIN_INFO dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_USER_LOGIN_INFO();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PASSWORD = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IS_USABL = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.IS_USABL_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FLAG = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MOBILE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.WMC_IS_NURSE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.EMAIL = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_USER_LOGIN_INFO[] objs = new DisplayObject_V_USER_LOGIN_INFO[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_USER_LOGIN_INFO[] Query(CauseObject_V_USER_LOGIN_INFO cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_USER_LOGIN_INFO.ACCOUNT, V_USER_LOGIN_INFO.PASSWORD, V_USER_LOGIN_INFO.IS_USABL, V_USER_LOGIN_INFO.IS_USABL_NAME, V_USER_LOGIN_INFO.USER_ID, V_USER_LOGIN_INFO.NAME, V_USER_LOGIN_INFO.FLAG, V_USER_LOGIN_INFO.CREATE_DATE, V_USER_LOGIN_INFO.MOBILE, V_USER_LOGIN_INFO.ID, V_USER_LOGIN_INFO.WMC_IS_NURSE, V_USER_LOGIN_INFO.TYPE_ID_NAME, V_USER_LOGIN_INFO.EMAIL from V_USER_LOGIN_INFO where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_USER_LOGIN_INFO",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_USER_LOGIN_INFO dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_USER_LOGIN_INFO();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ACCOUNT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.PASSWORD = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.IS_USABL = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.IS_USABL_NAME = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.USER_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NAME = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.FLAG = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.MOBILE = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ID = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.WMC_IS_NURSE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.TYPE_ID_NAME = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.EMAIL = sqlReader.GetString(12);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_USER_LOGIN_INFO[] objs = new DisplayObject_V_USER_LOGIN_INFO[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		#endregion 
	}
}
