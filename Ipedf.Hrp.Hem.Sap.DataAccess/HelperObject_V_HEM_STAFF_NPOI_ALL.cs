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
	[CauseObject(typeof(CauseObject_V_HEM_STAFF_NPOI_ALL))]	
	public partial class HelperObject_V_HEM_STAFF_NPOI_ALL
	{		
		#region Method Blok
		public static DisplayObject_V_HEM_STAFF_NPOI_ALL[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_HEM_STAFF_NPOI_ALL.ROWEND, V_HEM_STAFF_NPOI_ALL.CELLEND, V_HEM_STAFF_NPOI_ALL.ROWSTART, V_HEM_STAFF_NPOI_ALL.CELLSTART, V_HEM_STAFF_NPOI_ALL.HEADERNAME, V_HEM_STAFF_NPOI_ALL.NUM from V_HEM_STAFF_NPOI_ALL where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_HEM_STAFF_NPOI_ALL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_STAFF_NPOI_ALL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ROWEND = sqlReader.GetInt32(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CELLEND = sqlReader.GetInt32(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ROWSTART = sqlReader.GetInt32(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CELLSTART = sqlReader.GetInt32(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.HEADERNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NUM = sqlReader.GetInt32(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_STAFF_NPOI_ALL[] objs = new DisplayObject_V_HEM_STAFF_NPOI_ALL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_HEM_STAFF_NPOI_ALL cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.ROWEND!= ConstLibrary.Template.UndefineInt)
			{
				strBuf.Append(" And V_HEM_STAFF_NPOI_ALL.ROWEND = :C_ROWEND");
				param = new OracleParameter();
				param.ParameterName =":C_ROWEND";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ROWEND;
				paramList.Add(param);
			}
			if (cause.HasINValue("ROWEND"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_STAFF_NPOI_ALL", "ROWEND"));
			}
			if(cause.CELLEND!= ConstLibrary.Template.UndefineInt)
			{
				strBuf.Append(" And V_HEM_STAFF_NPOI_ALL.CELLEND = :C_CELLEND");
				param = new OracleParameter();
				param.ParameterName =":C_CELLEND";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CELLEND;
				paramList.Add(param);
			}
			if (cause.HasINValue("CELLEND"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_STAFF_NPOI_ALL", "CELLEND"));
			}
			if(cause.ROWSTART!= ConstLibrary.Template.UndefineInt)
			{
				strBuf.Append(" And V_HEM_STAFF_NPOI_ALL.ROWSTART = :C_ROWSTART");
				param = new OracleParameter();
				param.ParameterName =":C_ROWSTART";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ROWSTART;
				paramList.Add(param);
			}
			if (cause.HasINValue("ROWSTART"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_STAFF_NPOI_ALL", "ROWSTART"));
			}
			if(cause.CELLSTART!= ConstLibrary.Template.UndefineInt)
			{
				strBuf.Append(" And V_HEM_STAFF_NPOI_ALL.CELLSTART = :C_CELLSTART");
				param = new OracleParameter();
				param.ParameterName =":C_CELLSTART";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.CELLSTART;
				paramList.Add(param);
			}
			if (cause.HasINValue("CELLSTART"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_STAFF_NPOI_ALL", "CELLSTART"));
			}
			if(!string.IsNullOrEmpty(cause.HEADERNAME))
			{
				strBuf.Append(" And V_HEM_STAFF_NPOI_ALL.HEADERNAME ").Append((cause.HEADERNAME.StartsWith("%") || cause.HEADERNAME.EndsWith("%")) ? " like " : " = ").Append(" :C_HEADERNAME");
				param = new OracleParameter();
				param.ParameterName =":C_HEADERNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 20;
				param.Value = cause.HEADERNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("HEADERNAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_STAFF_NPOI_ALL", "HEADERNAME"));
			}
			if(cause.NUM!= ConstLibrary.Template.UndefineInt)
			{
				strBuf.Append(" And V_HEM_STAFF_NPOI_ALL.NUM = :C_NUM");
				param = new OracleParameter();
				param.ParameterName =":C_NUM";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.NUM;
				paramList.Add(param);
			}
			if (cause.HasINValue("NUM"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_STAFF_NPOI_ALL", "NUM"));
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
		public static DisplayObject_V_HEM_STAFF_NPOI_ALL[] Query(CauseObject_V_HEM_STAFF_NPOI_ALL cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_HEM_STAFF_NPOI_ALL.ROWEND, V_HEM_STAFF_NPOI_ALL.CELLEND, V_HEM_STAFF_NPOI_ALL.ROWSTART, V_HEM_STAFF_NPOI_ALL.CELLSTART, V_HEM_STAFF_NPOI_ALL.HEADERNAME, V_HEM_STAFF_NPOI_ALL.NUM from V_HEM_STAFF_NPOI_ALL where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_STAFF_NPOI_ALL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_STAFF_NPOI_ALL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ROWEND = sqlReader.GetInt32(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CELLEND = sqlReader.GetInt32(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ROWSTART = sqlReader.GetInt32(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CELLSTART = sqlReader.GetInt32(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.HEADERNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NUM = sqlReader.GetInt32(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_STAFF_NPOI_ALL[] objs = new DisplayObject_V_HEM_STAFF_NPOI_ALL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_STAFF_NPOI_ALL[] Query(CauseObject_V_HEM_STAFF_NPOI_ALL cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_HEM_STAFF_NPOI_ALL.ROWEND, V_HEM_STAFF_NPOI_ALL.CELLEND, V_HEM_STAFF_NPOI_ALL.ROWSTART, V_HEM_STAFF_NPOI_ALL.CELLSTART, V_HEM_STAFF_NPOI_ALL.HEADERNAME, V_HEM_STAFF_NPOI_ALL.NUM from V_HEM_STAFF_NPOI_ALL where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_STAFF_NPOI_ALL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_STAFF_NPOI_ALL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ROWEND = sqlReader.GetInt32(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CELLEND = sqlReader.GetInt32(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ROWSTART = sqlReader.GetInt32(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CELLSTART = sqlReader.GetInt32(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.HEADERNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NUM = sqlReader.GetInt32(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_STAFF_NPOI_ALL[] objs = new DisplayObject_V_HEM_STAFF_NPOI_ALL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_STAFF_NPOI_ALL[] Query(CauseObject_V_HEM_STAFF_NPOI_ALL cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_HEM_STAFF_NPOI_ALL.ROWEND, V_HEM_STAFF_NPOI_ALL.CELLEND, V_HEM_STAFF_NPOI_ALL.ROWSTART, V_HEM_STAFF_NPOI_ALL.CELLSTART, V_HEM_STAFF_NPOI_ALL.HEADERNAME, V_HEM_STAFF_NPOI_ALL.NUM from V_HEM_STAFF_NPOI_ALL where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_STAFF_NPOI_ALL",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_HEM_STAFF_NPOI_ALL dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_STAFF_NPOI_ALL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ROWEND = sqlReader.GetInt32(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CELLEND = sqlReader.GetInt32(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ROWSTART = sqlReader.GetInt32(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CELLSTART = sqlReader.GetInt32(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.HEADERNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NUM = sqlReader.GetInt32(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_STAFF_NPOI_ALL[] objs = new DisplayObject_V_HEM_STAFF_NPOI_ALL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_STAFF_NPOI_ALL[] Query(CauseObject_V_HEM_STAFF_NPOI_ALL cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_HEM_STAFF_NPOI_ALL.ROWEND, V_HEM_STAFF_NPOI_ALL.CELLEND, V_HEM_STAFF_NPOI_ALL.ROWSTART, V_HEM_STAFF_NPOI_ALL.CELLSTART, V_HEM_STAFF_NPOI_ALL.HEADERNAME, V_HEM_STAFF_NPOI_ALL.NUM from V_HEM_STAFF_NPOI_ALL where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_STAFF_NPOI_ALL",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_HEM_STAFF_NPOI_ALL dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_STAFF_NPOI_ALL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ROWEND = sqlReader.GetInt32(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CELLEND = sqlReader.GetInt32(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ROWSTART = sqlReader.GetInt32(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CELLSTART = sqlReader.GetInt32(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.HEADERNAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.NUM = sqlReader.GetInt32(5);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_STAFF_NPOI_ALL[] objs = new DisplayObject_V_HEM_STAFF_NPOI_ALL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		#endregion 
	}
}
