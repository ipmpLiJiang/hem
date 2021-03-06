using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Collections.Generic;
using Ipedf.Hrp.Hem.Sap.Entity;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
namespace Ipedf.Hrp.Hem.Sap.DataAccess
{
	[CauseObject(typeof(CauseObject_HEM_B_STAFF_APPLY))]
	public partial class HelperObject_HEM_B_STAFF_APPLY
	{		
		#region Method Blok
		public static int Save(EntityObject_HEM_B_STAFF_APPLY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into HEM_B_STAFF_APPLY( STAFF_TYPE_ID, POSTER_ID, ID, CREATE_DATE, STATUS) values ( :STAFF_TYPE_ID, :POSTER_ID, :ID, :CREATE_DATE, :STATUS)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[5];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":STAFF_TYPE_ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.STAFF_TYPE_ID == null ? String.Empty:obj.STAFF_TYPE_ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":POSTER_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.POSTER_ID == null ? String.Empty:obj.POSTER_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":CREATE_DATE";
			parameters[3].Size = 7;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[3].Value = obj.CREATE_DATE;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":STATUS";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.STATUS;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_STAFF_APPLY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_STAFF_APPLY set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_STAFF_APPLY obj,CauseObject_HEM_B_STAFF_APPLY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_STAFF_APPLY set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_HEM_B_STAFF_APPLY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from HEM_B_STAFF_APPLY where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(CauseObject_HEM_B_STAFF_APPLY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from HEM_B_STAFF_APPLY where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_HEM_B_STAFF_APPLY Get(EntityObject_HEM_B_STAFF_APPLY obj)
		{
			
			//平台自动生成代码
			string sSql = "select  STAFF_TYPE_ID, POSTER_ID, ID, CREATE_DATE, STATUS from HEM_B_STAFF_APPLY where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_STAFF_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_STAFF_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.POSTER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATUS = sqlReader.GetDecimal(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_HEM_B_STAFF_APPLY[] objs = new EntityObject_HEM_B_STAFF_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_HEM_B_STAFF_APPLY Get(EntityObject_HEM_B_STAFF_APPLY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  STAFF_TYPE_ID, POSTER_ID, ID, CREATE_DATE, STATUS from HEM_B_STAFF_APPLY where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_STAFF_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_STAFF_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.POSTER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATUS = sqlReader.GetDecimal(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_HEM_B_STAFF_APPLY[] objs = new EntityObject_HEM_B_STAFF_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_HEM_B_STAFF_APPLY[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  HEM_B_STAFF_APPLY.STAFF_TYPE_ID, HEM_B_STAFF_APPLY.POSTER_ID, HEM_B_STAFF_APPLY.ID, HEM_B_STAFF_APPLY.CREATE_DATE, HEM_B_STAFF_APPLY.STATUS from HEM_B_STAFF_APPLY where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_HEM_B_STAFF_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.POSTER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATUS = sqlReader.GetDecimal(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_APPLY[] objs = new DisplayObject_HEM_B_STAFF_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_HEM_B_STAFF_APPLY cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.STAFF_TYPE_ID))
			{
				strBuf.Append(" And HEM_B_STAFF_APPLY.STAFF_TYPE_ID ").Append((cause.STAFF_TYPE_ID.StartsWith("%") || cause.STAFF_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_APPLY", "STAFF_TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.POSTER_ID))
			{
				strBuf.Append(" And HEM_B_STAFF_APPLY.POSTER_ID ").Append((cause.POSTER_ID.StartsWith("%") || cause.POSTER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_POSTER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_POSTER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.POSTER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("POSTER_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_APPLY", "POSTER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And HEM_B_STAFF_APPLY.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_APPLY", "ID"));
			}
			if(cause.CREATE_DATE!= null)
			{
				if (cause.CREATE_DATE.Begin != null)
				{
					strBuf.Append(" And HEM_B_STAFF_APPLY.CREATE_DATE >= :C_CREATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_DATE.End != null)
				{
					strBuf.Append(" And HEM_B_STAFF_APPLY.CREATE_DATE < :C_CREATE_DATE_END");
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
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_APPLY", "CREATE_DATE"));
			}
			if(cause.STATUS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_STAFF_APPLY.STATUS = :C_STATUS");
				param = new OracleParameter();
				param.ParameterName =":C_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATUS"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_APPLY", "STATUS"));
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
		public static DisplayObject_HEM_B_STAFF_APPLY[] Query(CauseObject_HEM_B_STAFF_APPLY cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_APPLY.STAFF_TYPE_ID, HEM_B_STAFF_APPLY.POSTER_ID, HEM_B_STAFF_APPLY.ID, HEM_B_STAFF_APPLY.CREATE_DATE, HEM_B_STAFF_APPLY.STATUS from HEM_B_STAFF_APPLY where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_STAFF_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.POSTER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATUS = sqlReader.GetDecimal(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_APPLY[] objs = new DisplayObject_HEM_B_STAFF_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_HEM_B_STAFF_APPLY[] Query(CauseObject_HEM_B_STAFF_APPLY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_APPLY.STAFF_TYPE_ID, HEM_B_STAFF_APPLY.POSTER_ID, HEM_B_STAFF_APPLY.ID, HEM_B_STAFF_APPLY.CREATE_DATE, HEM_B_STAFF_APPLY.STATUS from HEM_B_STAFF_APPLY where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_STAFF_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.POSTER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATUS = sqlReader.GetDecimal(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_STAFF_APPLY[] objs = new DisplayObject_HEM_B_STAFF_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_STAFF_APPLY[] Query(CauseObject_HEM_B_STAFF_APPLY cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_APPLY.STAFF_TYPE_ID, HEM_B_STAFF_APPLY.POSTER_ID, HEM_B_STAFF_APPLY.ID, HEM_B_STAFF_APPLY.CREATE_DATE, HEM_B_STAFF_APPLY.STATUS from HEM_B_STAFF_APPLY where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_STAFF_APPLY",paging, order, sSql, parameters, connection);
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
			DisplayObject_HEM_B_STAFF_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.POSTER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATUS = sqlReader.GetDecimal(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_APPLY[] objs = new DisplayObject_HEM_B_STAFF_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_STAFF_APPLY[] Query(CauseObject_HEM_B_STAFF_APPLY cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_APPLY.STAFF_TYPE_ID, HEM_B_STAFF_APPLY.POSTER_ID, HEM_B_STAFF_APPLY.ID, HEM_B_STAFF_APPLY.CREATE_DATE, HEM_B_STAFF_APPLY.STATUS from HEM_B_STAFF_APPLY where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_STAFF_APPLY",paging, order, sSql, parameters, trans);
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
			DisplayObject_HEM_B_STAFF_APPLY dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_APPLY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.POSTER_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.STATUS = sqlReader.GetDecimal(4);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_STAFF_APPLY[] objs = new DisplayObject_HEM_B_STAFF_APPLY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_HEM_B_STAFF_APPLY obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("STAFF_TYPE_ID"))
			{
				strBuf.Add("  HEM_B_STAFF_APPLY.STAFF_TYPE_ID = :U_STAFF_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_STAFF_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.STAFF_TYPE_ID) ? string.Empty : obj.STAFF_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("POSTER_ID"))
			{
				strBuf.Add("  HEM_B_STAFF_APPLY.POSTER_ID = :U_POSTER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_POSTER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.POSTER_ID) ? string.Empty : obj.POSTER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DATE"))
			{
				strBuf.Add("  HEM_B_STAFF_APPLY.CREATE_DATE = :U_CREATE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.CREATE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATUS"))
			{
				strBuf.Add("  HEM_B_STAFF_APPLY.STATUS = :U_STATUS");
				param = new OracleParameter();
				param.ParameterName = ":U_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATUS;
				paramList.Add(param);
			}
			//pk here
			if(appendpk)
			{
				param = new OracleParameter();
				param.ParameterName = ":U_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = obj.ID;
				paramList.Add(param);
			}
			#endregion 
			parameters = new OracleParameter[paramList.Count];
			paramList.CopyTo(parameters);
			return string.Join(", ",strBuf.ToArray());

        }	
		#endregion 
	}
}
