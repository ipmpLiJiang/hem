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
	[CauseObject(typeof(CauseObject_V_HEM_B_STAFF_APPLY_N))]	
	public partial class HelperObject_V_HEM_B_STAFF_APPLY_N
	{		
		#region Method Blok
		public static DisplayObject_V_HEM_B_STAFF_APPLY_N[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_HEM_B_STAFF_APPLY_N.PUBLISH_DATE, V_HEM_B_STAFF_APPLY_N.ID, V_HEM_B_STAFF_APPLY_N.POSTER_ID, V_HEM_B_STAFF_APPLY_N.STATUS, V_HEM_B_STAFF_APPLY_N.STAFF_ID, V_HEM_B_STAFF_APPLY_N.EDUCATION_COUNT, V_HEM_B_STAFF_APPLY_N.USER_ID, V_HEM_B_STAFF_APPLY_N.END_DATE, V_HEM_B_STAFF_APPLY_N.STAFF_TYPE_ID, V_HEM_B_STAFF_APPLY_N.POSTER_STATUS, V_HEM_B_STAFF_APPLY_N.IS_PUBLIC, V_HEM_B_STAFF_APPLY_N.IS_NURSE from V_HEM_B_STAFF_APPLY_N where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_HEM_B_STAFF_APPLY_N dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_APPLY_N();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.POSTER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATUS = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STAFF_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.EDUCATION_COUNT = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.END_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.POSTER_STATUS = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_STAFF_APPLY_N[] objs = new DisplayObject_V_HEM_B_STAFF_APPLY_N[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_HEM_B_STAFF_APPLY_N cause,out OracleParameter[] parameters )
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
					strBuf.Append(" And V_HEM_B_STAFF_APPLY_N.PUBLISH_DATE >= :C_PUBLISH_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_PUBLISH_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PUBLISH_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.PUBLISH_DATE.End != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF_APPLY_N.PUBLISH_DATE < :C_PUBLISH_DATE_END");
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
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_N", "PUBLISH_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_N.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_N", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.POSTER_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_N.POSTER_ID ").Append((cause.POSTER_ID.StartsWith("%") || cause.POSTER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_POSTER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_POSTER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.POSTER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("POSTER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_N", "POSTER_ID"));
			}
			if(cause.STATUS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_N.STATUS = :C_STATUS");
				param = new OracleParameter();
				param.ParameterName =":C_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATUS"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_N", "STATUS"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_N.STAFF_ID ").Append((cause.STAFF_ID.StartsWith("%") || cause.STAFF_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_ID");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_N", "STAFF_ID"));
			}
			if(cause.EDUCATION_COUNT!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_N.EDUCATION_COUNT = :C_EDUCATION_COUNT");
				param = new OracleParameter();
				param.ParameterName =":C_EDUCATION_COUNT";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.EDUCATION_COUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("EDUCATION_COUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_N", "EDUCATION_COUNT"));
			}
			if(!string.IsNullOrEmpty(cause.USER_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_N.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_N", "USER_ID"));
			}
			if(cause.END_DATE!= null)
			{
				if (cause.END_DATE.Begin != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF_APPLY_N.END_DATE >= :C_END_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_END_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.END_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.END_DATE.End != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF_APPLY_N.END_DATE < :C_END_DATE_END");
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
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_N", "END_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_TYPE_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_N.STAFF_TYPE_ID ").Append((cause.STAFF_TYPE_ID.StartsWith("%") || cause.STAFF_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_N", "STAFF_TYPE_ID"));
			}
			if(cause.POSTER_STATUS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_N.POSTER_STATUS = :C_POSTER_STATUS");
				param = new OracleParameter();
				param.ParameterName =":C_POSTER_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.POSTER_STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("POSTER_STATUS"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_N", "POSTER_STATUS"));
			}
			if(cause.IS_PUBLIC!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_N.IS_PUBLIC = :C_IS_PUBLIC");
				param = new OracleParameter();
				param.ParameterName =":C_IS_PUBLIC";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_PUBLIC;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_PUBLIC"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_N", "IS_PUBLIC"));
			}
			if(cause.IS_NURSE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_N.IS_NURSE = :C_IS_NURSE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_NURSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_NURSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_NURSE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_N", "IS_NURSE"));
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
		public static DisplayObject_V_HEM_B_STAFF_APPLY_N[] Query(CauseObject_V_HEM_B_STAFF_APPLY_N cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_HEM_B_STAFF_APPLY_N.PUBLISH_DATE, V_HEM_B_STAFF_APPLY_N.ID, V_HEM_B_STAFF_APPLY_N.POSTER_ID, V_HEM_B_STAFF_APPLY_N.STATUS, V_HEM_B_STAFF_APPLY_N.STAFF_ID, V_HEM_B_STAFF_APPLY_N.EDUCATION_COUNT, V_HEM_B_STAFF_APPLY_N.USER_ID, V_HEM_B_STAFF_APPLY_N.END_DATE, V_HEM_B_STAFF_APPLY_N.STAFF_TYPE_ID, V_HEM_B_STAFF_APPLY_N.POSTER_STATUS, V_HEM_B_STAFF_APPLY_N.IS_PUBLIC, V_HEM_B_STAFF_APPLY_N.IS_NURSE from V_HEM_B_STAFF_APPLY_N where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_B_STAFF_APPLY_N dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_APPLY_N();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.POSTER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATUS = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STAFF_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.EDUCATION_COUNT = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.END_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.POSTER_STATUS = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_STAFF_APPLY_N[] objs = new DisplayObject_V_HEM_B_STAFF_APPLY_N[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_STAFF_APPLY_N[] Query(CauseObject_V_HEM_B_STAFF_APPLY_N cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_HEM_B_STAFF_APPLY_N.PUBLISH_DATE, V_HEM_B_STAFF_APPLY_N.ID, V_HEM_B_STAFF_APPLY_N.POSTER_ID, V_HEM_B_STAFF_APPLY_N.STATUS, V_HEM_B_STAFF_APPLY_N.STAFF_ID, V_HEM_B_STAFF_APPLY_N.EDUCATION_COUNT, V_HEM_B_STAFF_APPLY_N.USER_ID, V_HEM_B_STAFF_APPLY_N.END_DATE, V_HEM_B_STAFF_APPLY_N.STAFF_TYPE_ID, V_HEM_B_STAFF_APPLY_N.POSTER_STATUS, V_HEM_B_STAFF_APPLY_N.IS_PUBLIC, V_HEM_B_STAFF_APPLY_N.IS_NURSE from V_HEM_B_STAFF_APPLY_N where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_B_STAFF_APPLY_N dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_APPLY_N();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.POSTER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATUS = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STAFF_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.EDUCATION_COUNT = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.END_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.POSTER_STATUS = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_B_STAFF_APPLY_N[] objs = new DisplayObject_V_HEM_B_STAFF_APPLY_N[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_STAFF_APPLY_N[] Query(CauseObject_V_HEM_B_STAFF_APPLY_N cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_HEM_B_STAFF_APPLY_N.PUBLISH_DATE, V_HEM_B_STAFF_APPLY_N.ID, V_HEM_B_STAFF_APPLY_N.POSTER_ID, V_HEM_B_STAFF_APPLY_N.STATUS, V_HEM_B_STAFF_APPLY_N.STAFF_ID, V_HEM_B_STAFF_APPLY_N.EDUCATION_COUNT, V_HEM_B_STAFF_APPLY_N.USER_ID, V_HEM_B_STAFF_APPLY_N.END_DATE, V_HEM_B_STAFF_APPLY_N.STAFF_TYPE_ID, V_HEM_B_STAFF_APPLY_N.POSTER_STATUS, V_HEM_B_STAFF_APPLY_N.IS_PUBLIC, V_HEM_B_STAFF_APPLY_N.IS_NURSE from V_HEM_B_STAFF_APPLY_N where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_B_STAFF_APPLY_N",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_HEM_B_STAFF_APPLY_N dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_APPLY_N();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.POSTER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATUS = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STAFF_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.EDUCATION_COUNT = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.END_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.POSTER_STATUS = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_STAFF_APPLY_N[] objs = new DisplayObject_V_HEM_B_STAFF_APPLY_N[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_STAFF_APPLY_N[] Query(CauseObject_V_HEM_B_STAFF_APPLY_N cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_HEM_B_STAFF_APPLY_N.PUBLISH_DATE, V_HEM_B_STAFF_APPLY_N.ID, V_HEM_B_STAFF_APPLY_N.POSTER_ID, V_HEM_B_STAFF_APPLY_N.STATUS, V_HEM_B_STAFF_APPLY_N.STAFF_ID, V_HEM_B_STAFF_APPLY_N.EDUCATION_COUNT, V_HEM_B_STAFF_APPLY_N.USER_ID, V_HEM_B_STAFF_APPLY_N.END_DATE, V_HEM_B_STAFF_APPLY_N.STAFF_TYPE_ID, V_HEM_B_STAFF_APPLY_N.POSTER_STATUS, V_HEM_B_STAFF_APPLY_N.IS_PUBLIC, V_HEM_B_STAFF_APPLY_N.IS_NURSE from V_HEM_B_STAFF_APPLY_N where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_B_STAFF_APPLY_N",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_HEM_B_STAFF_APPLY_N dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_APPLY_N();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.POSTER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATUS = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STAFF_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.EDUCATION_COUNT = sqlReader.GetDecimal(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.END_DATE = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.POSTER_STATUS = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_B_STAFF_APPLY_N[] objs = new DisplayObject_V_HEM_B_STAFF_APPLY_N[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		#endregion 
	}
}
