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
	[CauseObject(typeof(CauseObject_HEM_B_STAFF_REWARD))]
	public partial class HelperObject_HEM_B_STAFF_REWARD
	{		
		#region Method Blok
		public static int Save(EntityObject_HEM_B_STAFF_REWARD obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into HEM_B_STAFF_REWARD( ID, STAFF_ID, JXNAME, MINGCI, HJSJ,  COMMENTS, COMMENTS1) values ( :ID, :STAFF_ID, :JXNAME, :MINGCI, :HJSJ,  :COMMENTS, :COMMENTS1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[7];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty : obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName = ":STAFF_ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.STAFF_ID == null ? String.Empty : obj.STAFF_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":JXNAME";
			parameters[2].Size = 100;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.JXNAME == null ? String.Empty:obj.JXNAME;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":MINGCI";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.MINGCI == null ? String.Empty:obj.MINGCI;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":HJSJ";
			parameters[4].Size = 7;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[4].Value = obj.HJSJ;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":COMMENTS";
			parameters[5].Size = 200;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.COMMENTS == null ? String.Empty:obj.COMMENTS;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":COMMENTS1";
			parameters[6].Size = 200;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.COMMENTS1 == null ? String.Empty:obj.COMMENTS1;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_STAFF_REWARD obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_STAFF_REWARD set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_STAFF_REWARD obj,CauseObject_HEM_B_STAFF_REWARD cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_STAFF_REWARD set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_HEM_B_STAFF_REWARD obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from HEM_B_STAFF_REWARD where  ID = :ID ";
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
		public static int Delete(CauseObject_HEM_B_STAFF_REWARD cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from HEM_B_STAFF_REWARD where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_HEM_B_STAFF_REWARD Get(EntityObject_HEM_B_STAFF_REWARD obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, STAFF_ID, JXNAME, MINGCI, HJSJ,  COMMENTS, COMMENTS1 from HEM_B_STAFF_REWARD where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_STAFF_REWARD dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_STAFF_REWARD();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.STAFF_ID = sqlReader.GetString(1);
				if (!sqlReader.IsDBNull(2))
					dataObj.JXNAME = sqlReader.GetString(2);
				if (!sqlReader.IsDBNull(3))
					dataObj.MINGCI = sqlReader.GetString(3);
				if (!sqlReader.IsDBNull(4)) 
					dataObj.HJSJ = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COMMENTS1 = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_HEM_B_STAFF_REWARD[] objs = new EntityObject_HEM_B_STAFF_REWARD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_HEM_B_STAFF_REWARD Get(EntityObject_HEM_B_STAFF_REWARD obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, STAFF_ID, JXNAME, MINGCI, HJSJ,  COMMENTS, COMMENTS1 from HEM_B_STAFF_REWARD where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_STAFF_REWARD dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_STAFF_REWARD();
				if (!sqlReader.IsDBNull(0))
					dataObj.ID = sqlReader.GetString(0);
				if (!sqlReader.IsDBNull(1))
					dataObj.STAFF_ID = sqlReader.GetString(1);
				if (!sqlReader.IsDBNull(2))
					dataObj.JXNAME = sqlReader.GetString(2);
				if (!sqlReader.IsDBNull(3))
					dataObj.MINGCI = sqlReader.GetString(3);
				if (!sqlReader.IsDBNull(4))
					dataObj.HJSJ = sqlReader.GetDateTime(4);
				if (!sqlReader.IsDBNull(5))
					dataObj.COMMENTS = sqlReader.GetString(5);
				if (!sqlReader.IsDBNull(6))
					dataObj.COMMENTS1 = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_HEM_B_STAFF_REWARD[] objs = new EntityObject_HEM_B_STAFF_REWARD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_HEM_B_STAFF_REWARD[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  HEM_B_STAFF_REWARD.ID, HEM_B_STAFF_REWARD.STAFF_ID, HEM_B_STAFF_REWARD.JXNAME, HEM_B_STAFF_REWARD.MINGCI, HEM_B_STAFF_REWARD.HJSJ, HEM_B_STAFF_REWARD.COMMENTS, HEM_B_STAFF_REWARD.COMMENTS1 from HEM_B_STAFF_REWARD where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_HEM_B_STAFF_REWARD dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_REWARD();
				if (!sqlReader.IsDBNull(0))
					dataObj.ID = sqlReader.GetString(0);
				if (!sqlReader.IsDBNull(1))
					dataObj.STAFF_ID = sqlReader.GetString(1);
				if (!sqlReader.IsDBNull(2))
					dataObj.JXNAME = sqlReader.GetString(2);
				if (!sqlReader.IsDBNull(3))
					dataObj.MINGCI = sqlReader.GetString(3);
				if (!sqlReader.IsDBNull(4))
					dataObj.HJSJ = sqlReader.GetDateTime(4);
				if (!sqlReader.IsDBNull(5))
					dataObj.COMMENTS = sqlReader.GetString(5);
				if (!sqlReader.IsDBNull(6))
					dataObj.COMMENTS1 = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_REWARD[] objs = new DisplayObject_HEM_B_STAFF_REWARD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_HEM_B_STAFF_REWARD cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And HEM_B_STAFF_REWARD.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REWARD", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.JXNAME))
			{
				strBuf.Append(" And HEM_B_STAFF_REWARD.JXNAME ").Append((cause.JXNAME.StartsWith("%") || cause.JXNAME.EndsWith("%")) ? " like " : " = ").Append(" :C_JXNAME");
				param = new OracleParameter();
				param.ParameterName =":C_JXNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.JXNAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("JXNAME"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REWARD", "JXNAME"));
			}
			if(!string.IsNullOrEmpty(cause.MINGCI))
			{
				strBuf.Append(" And HEM_B_STAFF_REWARD.MINGCI ").Append((cause.MINGCI.StartsWith("%") || cause.MINGCI.EndsWith("%")) ? " like " : " = ").Append(" :C_MINGCI");
				param = new OracleParameter();
				param.ParameterName =":C_MINGCI";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MINGCI;
				paramList.Add(param);
			}
			if (cause.HasINValue("MINGCI"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REWARD", "MINGCI"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_ID))
			{
				strBuf.Append(" And HEM_B_STAFF_REWARD.STAFF_ID ").Append((cause.STAFF_ID.StartsWith("%") || cause.STAFF_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_ID");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REWARD", "STAFF_ID"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS))
			{
				strBuf.Append(" And HEM_B_STAFF_REWARD.COMMENTS ").Append((cause.COMMENTS.StartsWith("%") || cause.COMMENTS.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REWARD", "COMMENTS"));
			}
			if(!string.IsNullOrEmpty(cause.COMMENTS1))
			{
				strBuf.Append(" And HEM_B_STAFF_REWARD.COMMENTS1 ").Append((cause.COMMENTS1.StartsWith("%") || cause.COMMENTS1.EndsWith("%")) ? " like " : " = ").Append(" :C_COMMENTS1");
				param = new OracleParameter();
				param.ParameterName =":C_COMMENTS1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = cause.COMMENTS1;
				paramList.Add(param);
			}
			if (cause.HasINValue("COMMENTS1"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REWARD", "COMMENTS1"));
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
		public static DisplayObject_HEM_B_STAFF_REWARD[] Query(CauseObject_HEM_B_STAFF_REWARD cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_REWARD.ID, HEM_B_STAFF_REWARD.STAFF_ID, HEM_B_STAFF_REWARD.JXNAME, HEM_B_STAFF_REWARD.MINGCI, HEM_B_STAFF_REWARD.HJSJ, HEM_B_STAFF_REWARD.COMMENTS, HEM_B_STAFF_REWARD.COMMENTS1 from HEM_B_STAFF_REWARD where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_STAFF_REWARD dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_REWARD();
				if (!sqlReader.IsDBNull(0))
					dataObj.ID = sqlReader.GetString(0);
				if (!sqlReader.IsDBNull(1))
					dataObj.STAFF_ID = sqlReader.GetString(1);
				if (!sqlReader.IsDBNull(2))
					dataObj.JXNAME = sqlReader.GetString(2);
				if (!sqlReader.IsDBNull(3))
					dataObj.MINGCI = sqlReader.GetString(3);
				if (!sqlReader.IsDBNull(4))
					dataObj.HJSJ = sqlReader.GetDateTime(4);
				if (!sqlReader.IsDBNull(5))
					dataObj.COMMENTS = sqlReader.GetString(5);
				if (!sqlReader.IsDBNull(6))
					dataObj.COMMENTS1 = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_REWARD[] objs = new DisplayObject_HEM_B_STAFF_REWARD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_HEM_B_STAFF_REWARD[] Query(CauseObject_HEM_B_STAFF_REWARD cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_REWARD.ID, HEM_B_STAFF_REWARD.STAFF_ID, HEM_B_STAFF_REWARD.JXNAME, HEM_B_STAFF_REWARD.MINGCI, HEM_B_STAFF_REWARD.HJSJ, HEM_B_STAFF_REWARD.COMMENTS, HEM_B_STAFF_REWARD.COMMENTS1 from HEM_B_STAFF_REWARD where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_STAFF_REWARD dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_REWARD();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.STAFF_ID = sqlReader.GetString(1);
				if (!sqlReader.IsDBNull(2))
					dataObj.JXNAME = sqlReader.GetString(2);
				if (!sqlReader.IsDBNull(3))
					dataObj.MINGCI = sqlReader.GetString(3);
				if (!sqlReader.IsDBNull(4)) 
					dataObj.HJSJ = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COMMENTS1 = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_STAFF_REWARD[] objs = new DisplayObject_HEM_B_STAFF_REWARD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_STAFF_REWARD[] Query(CauseObject_HEM_B_STAFF_REWARD cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_REWARD.ID, HEM_B_STAFF_REWARD.STAFF_ID, HEM_B_STAFF_REWARD.JXNAME, HEM_B_STAFF_REWARD.MINGCI, HEM_B_STAFF_REWARD.HJSJ, HEM_B_STAFF_REWARD.COMMENTS, HEM_B_STAFF_REWARD.COMMENTS1 from HEM_B_STAFF_REWARD where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_STAFF_REWARD",paging, order, sSql, parameters, connection);
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
			DisplayObject_HEM_B_STAFF_REWARD dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_REWARD();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.STAFF_ID = sqlReader.GetString(1);
				if (!sqlReader.IsDBNull(2))
					dataObj.JXNAME = sqlReader.GetString(2);
				if (!sqlReader.IsDBNull(3))
					dataObj.MINGCI = sqlReader.GetString(3);
				if (!sqlReader.IsDBNull(4)) 
					dataObj.HJSJ = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COMMENTS1 = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_REWARD[] objs = new DisplayObject_HEM_B_STAFF_REWARD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_STAFF_REWARD[] Query(CauseObject_HEM_B_STAFF_REWARD cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_REWARD.ID, HEM_B_STAFF_REWARD.STAFF_ID, HEM_B_STAFF_REWARD.JXNAME, HEM_B_STAFF_REWARD.MINGCI, HEM_B_STAFF_REWARD.HJSJ, HEM_B_STAFF_REWARD.COMMENTS, HEM_B_STAFF_REWARD.COMMENTS1 from HEM_B_STAFF_REWARD where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_STAFF_REWARD",paging, order, sSql, parameters, trans);
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
			DisplayObject_HEM_B_STAFF_REWARD dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_REWARD();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.STAFF_ID = sqlReader.GetString(1);
				if (!sqlReader.IsDBNull(2))
					dataObj.JXNAME = sqlReader.GetString(2);
				if (!sqlReader.IsDBNull(3))
					dataObj.MINGCI = sqlReader.GetString(3);
				if (!sqlReader.IsDBNull(4)) 
					dataObj.HJSJ = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.COMMENTS = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.COMMENTS1 = sqlReader.GetString(6);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_STAFF_REWARD[] objs = new DisplayObject_HEM_B_STAFF_REWARD[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_HEM_B_STAFF_REWARD obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("JXNAME"))
			{
				strBuf.Add("  HEM_B_STAFF_REWARD.JXNAME = :U_JXNAME");
				param = new OracleParameter();
				param.ParameterName = ":U_JXNAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.JXNAME) ? string.Empty : obj.JXNAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MINGCI"))
			{
				strBuf.Add("  HEM_B_STAFF_REWARD.MINGCI = :U_MINGCI");
				param = new OracleParameter();
				param.ParameterName = ":U_MINGCI";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MINGCI) ? string.Empty : obj.MINGCI;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STAFF_ID"))
			{
				strBuf.Add("  HEM_B_STAFF_REWARD.STAFF_ID = :U_STAFF_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_STAFF_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.STAFF_ID) ? string.Empty : obj.STAFF_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("HJSJ"))
			{
				strBuf.Add("  HEM_B_STAFF_REWARD.HJSJ = :U_HJSJ");
				param = new OracleParameter();
				param.ParameterName = ":U_HJSJ";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.HJSJ;
				paramList.Add(param);
			}
			
			if (!obj.IsNotUpdate("COMMENTS"))
			{
				strBuf.Add("  HEM_B_STAFF_REWARD.COMMENTS = :U_COMMENTS");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS) ? string.Empty : obj.COMMENTS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("COMMENTS1"))
			{
				strBuf.Add("  HEM_B_STAFF_REWARD.COMMENTS1 = :U_COMMENTS1");
				param = new OracleParameter();
				param.ParameterName = ":U_COMMENTS1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 200;
				param.Value = string.IsNullOrEmpty(obj.COMMENTS1) ? string.Empty : obj.COMMENTS1;
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
