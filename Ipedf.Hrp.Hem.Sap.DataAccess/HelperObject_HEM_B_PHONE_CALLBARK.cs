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
	[CauseObject(typeof(CauseObject_HEM_B_PHONE_CALLBARK))]
	public partial class HelperObject_HEM_B_PHONE_CALLBARK
	{		
		#region Method Blok
		public static int Save(EntityObject_HEM_B_PHONE_CALLBARK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into HEM_B_PHONE_CALLBARK( CONTENT, ID, STATUS, TASKID, APPLY_ID, MOBILE, SEND_ID, INSERTTIME) values ( :CONTENT, :ID, :STATUS, :TASKID, :APPLY_ID, :MOBILE, :SEND_ID, :INSERTTIME)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[8];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":CONTENT";
			parameters[0].Size = 500;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.CONTENT == null ? String.Empty:obj.CONTENT;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":STATUS";
			parameters[2].Size = 22;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[2].Value = obj.STATUS;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":TASKID";
			parameters[3].Size = 50;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.TASKID == null ? String.Empty:obj.TASKID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":APPLY_ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.APPLY_ID == null ? String.Empty:obj.APPLY_ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":MOBILE";
			parameters[5].Size = 50;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.MOBILE == null ? String.Empty:obj.MOBILE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":SEND_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.SEND_ID == null ? String.Empty:obj.SEND_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":INSERTTIME";
			parameters[7].Size = 7;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[7].Value = obj.INSERTTIME;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_PHONE_CALLBARK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_PHONE_CALLBARK set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_PHONE_CALLBARK obj,CauseObject_HEM_B_PHONE_CALLBARK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_PHONE_CALLBARK set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_HEM_B_PHONE_CALLBARK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from HEM_B_PHONE_CALLBARK where  ID = :ID ";
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
		public static int Delete(CauseObject_HEM_B_PHONE_CALLBARK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from HEM_B_PHONE_CALLBARK where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_HEM_B_PHONE_CALLBARK Get(EntityObject_HEM_B_PHONE_CALLBARK obj)
		{
			
			//平台自动生成代码
			string sSql = "select  CONTENT, ID, STATUS, TASKID, APPLY_ID, MOBILE, SEND_ID, INSERTTIME from HEM_B_PHONE_CALLBARK where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_PHONE_CALLBARK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_PHONE_CALLBARK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTENT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STATUS = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TASKID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.APPLY_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MOBILE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SEND_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.INSERTTIME = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_HEM_B_PHONE_CALLBARK[] objs = new EntityObject_HEM_B_PHONE_CALLBARK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_HEM_B_PHONE_CALLBARK Get(EntityObject_HEM_B_PHONE_CALLBARK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  CONTENT, ID, STATUS, TASKID, APPLY_ID, MOBILE, SEND_ID, INSERTTIME from HEM_B_PHONE_CALLBARK where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_PHONE_CALLBARK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_PHONE_CALLBARK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTENT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STATUS = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TASKID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.APPLY_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MOBILE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SEND_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.INSERTTIME = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_HEM_B_PHONE_CALLBARK[] objs = new EntityObject_HEM_B_PHONE_CALLBARK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_HEM_B_PHONE_CALLBARK[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  HEM_B_PHONE_CALLBARK.CONTENT, HEM_B_PHONE_CALLBARK.ID, HEM_B_PHONE_CALLBARK.STATUS, HEM_B_PHONE_CALLBARK.TASKID, HEM_B_PHONE_CALLBARK.APPLY_ID, HEM_B_PHONE_CALLBARK.MOBILE, HEM_B_PHONE_CALLBARK.SEND_ID, HEM_B_PHONE_CALLBARK.INSERTTIME from HEM_B_PHONE_CALLBARK where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_HEM_B_PHONE_CALLBARK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_PHONE_CALLBARK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTENT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STATUS = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TASKID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.APPLY_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MOBILE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SEND_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.INSERTTIME = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_PHONE_CALLBARK[] objs = new DisplayObject_HEM_B_PHONE_CALLBARK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_HEM_B_PHONE_CALLBARK cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.CONTENT))
			{
				strBuf.Append(" And HEM_B_PHONE_CALLBARK.CONTENT ").Append((cause.CONTENT.StartsWith("%") || cause.CONTENT.EndsWith("%")) ? " like " : " = ").Append(" :C_CONTENT");
				param = new OracleParameter();
				param.ParameterName =":C_CONTENT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.CONTENT;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTENT"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_CALLBARK", "CONTENT"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And HEM_B_PHONE_CALLBARK.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_CALLBARK", "ID"));
			}
			if(cause.STATUS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_PHONE_CALLBARK.STATUS = :C_STATUS");
				param = new OracleParameter();
				param.ParameterName =":C_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATUS"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_CALLBARK", "STATUS"));
			}
			if(!string.IsNullOrEmpty(cause.TASKID))
			{
				strBuf.Append(" And HEM_B_PHONE_CALLBARK.TASKID ").Append((cause.TASKID.StartsWith("%") || cause.TASKID.EndsWith("%")) ? " like " : " = ").Append(" :C_TASKID");
				param = new OracleParameter();
				param.ParameterName =":C_TASKID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.TASKID;
				paramList.Add(param);
			}
			if (cause.HasINValue("TASKID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_CALLBARK", "TASKID"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_ID))
			{
				strBuf.Append(" And HEM_B_PHONE_CALLBARK.APPLY_ID ").Append((cause.APPLY_ID.StartsWith("%") || cause.APPLY_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_ID");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.APPLY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_CALLBARK", "APPLY_ID"));
			}
			if(!string.IsNullOrEmpty(cause.MOBILE))
			{
				strBuf.Append(" And HEM_B_PHONE_CALLBARK.MOBILE ").Append((cause.MOBILE.StartsWith("%") || cause.MOBILE.EndsWith("%")) ? " like " : " = ").Append(" :C_MOBILE");
				param = new OracleParameter();
				param.ParameterName =":C_MOBILE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MOBILE;
				paramList.Add(param);
			}
			if (cause.HasINValue("MOBILE"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_CALLBARK", "MOBILE"));
			}
			if(!string.IsNullOrEmpty(cause.SEND_ID))
			{
				strBuf.Append(" And HEM_B_PHONE_CALLBARK.SEND_ID ").Append((cause.SEND_ID.StartsWith("%") || cause.SEND_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_SEND_ID");
				param = new OracleParameter();
				param.ParameterName =":C_SEND_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.SEND_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEND_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_CALLBARK", "SEND_ID"));
			}
			if(cause.INSERTTIME!= null)
			{
				if (cause.INSERTTIME.Begin != null)
				{
					strBuf.Append(" And HEM_B_PHONE_CALLBARK.INSERTTIME >= :C_INSERTTIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_INSERTTIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.INSERTTIME.Begin;
					paramList.Add(param);
				}
				if (cause.INSERTTIME.End != null)
				{
					strBuf.Append(" And HEM_B_PHONE_CALLBARK.INSERTTIME < :C_INSERTTIME_END");
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
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_CALLBARK", "INSERTTIME"));
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
		public static DisplayObject_HEM_B_PHONE_CALLBARK[] Query(CauseObject_HEM_B_PHONE_CALLBARK cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_PHONE_CALLBARK.CONTENT, HEM_B_PHONE_CALLBARK.ID, HEM_B_PHONE_CALLBARK.STATUS, HEM_B_PHONE_CALLBARK.TASKID, HEM_B_PHONE_CALLBARK.APPLY_ID, HEM_B_PHONE_CALLBARK.MOBILE, HEM_B_PHONE_CALLBARK.SEND_ID, HEM_B_PHONE_CALLBARK.INSERTTIME from HEM_B_PHONE_CALLBARK where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_PHONE_CALLBARK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_PHONE_CALLBARK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTENT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STATUS = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TASKID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.APPLY_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MOBILE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SEND_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.INSERTTIME = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_PHONE_CALLBARK[] objs = new DisplayObject_HEM_B_PHONE_CALLBARK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_HEM_B_PHONE_CALLBARK[] Query(CauseObject_HEM_B_PHONE_CALLBARK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_PHONE_CALLBARK.CONTENT, HEM_B_PHONE_CALLBARK.ID, HEM_B_PHONE_CALLBARK.STATUS, HEM_B_PHONE_CALLBARK.TASKID, HEM_B_PHONE_CALLBARK.APPLY_ID, HEM_B_PHONE_CALLBARK.MOBILE, HEM_B_PHONE_CALLBARK.SEND_ID, HEM_B_PHONE_CALLBARK.INSERTTIME from HEM_B_PHONE_CALLBARK where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_PHONE_CALLBARK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_PHONE_CALLBARK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTENT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STATUS = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TASKID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.APPLY_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MOBILE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SEND_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.INSERTTIME = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_PHONE_CALLBARK[] objs = new DisplayObject_HEM_B_PHONE_CALLBARK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_PHONE_CALLBARK[] Query(CauseObject_HEM_B_PHONE_CALLBARK cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_PHONE_CALLBARK.CONTENT, HEM_B_PHONE_CALLBARK.ID, HEM_B_PHONE_CALLBARK.STATUS, HEM_B_PHONE_CALLBARK.TASKID, HEM_B_PHONE_CALLBARK.APPLY_ID, HEM_B_PHONE_CALLBARK.MOBILE, HEM_B_PHONE_CALLBARK.SEND_ID, HEM_B_PHONE_CALLBARK.INSERTTIME from HEM_B_PHONE_CALLBARK where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_PHONE_CALLBARK",paging, order, sSql, parameters, connection);
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
			DisplayObject_HEM_B_PHONE_CALLBARK dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_PHONE_CALLBARK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTENT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STATUS = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TASKID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.APPLY_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MOBILE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SEND_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.INSERTTIME = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_PHONE_CALLBARK[] objs = new DisplayObject_HEM_B_PHONE_CALLBARK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_PHONE_CALLBARK[] Query(CauseObject_HEM_B_PHONE_CALLBARK cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_PHONE_CALLBARK.CONTENT, HEM_B_PHONE_CALLBARK.ID, HEM_B_PHONE_CALLBARK.STATUS, HEM_B_PHONE_CALLBARK.TASKID, HEM_B_PHONE_CALLBARK.APPLY_ID, HEM_B_PHONE_CALLBARK.MOBILE, HEM_B_PHONE_CALLBARK.SEND_ID, HEM_B_PHONE_CALLBARK.INSERTTIME from HEM_B_PHONE_CALLBARK where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_PHONE_CALLBARK",paging, order, sSql, parameters, trans);
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
			DisplayObject_HEM_B_PHONE_CALLBARK dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_PHONE_CALLBARK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTENT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.STATUS = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.TASKID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.APPLY_ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.MOBILE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SEND_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.INSERTTIME = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_PHONE_CALLBARK[] objs = new DisplayObject_HEM_B_PHONE_CALLBARK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_HEM_B_PHONE_CALLBARK obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("CONTENT"))
			{
				strBuf.Add("  HEM_B_PHONE_CALLBARK.CONTENT = :U_CONTENT");
				param = new OracleParameter();
				param.ParameterName = ":U_CONTENT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = string.IsNullOrEmpty(obj.CONTENT) ? string.Empty : obj.CONTENT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATUS"))
			{
				strBuf.Add("  HEM_B_PHONE_CALLBARK.STATUS = :U_STATUS");
				param = new OracleParameter();
				param.ParameterName = ":U_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATUS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TASKID"))
			{
				strBuf.Add("  HEM_B_PHONE_CALLBARK.TASKID = :U_TASKID");
				param = new OracleParameter();
				param.ParameterName = ":U_TASKID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.TASKID) ? string.Empty : obj.TASKID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_ID"))
			{
				strBuf.Add("  HEM_B_PHONE_CALLBARK.APPLY_ID = :U_APPLY_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.APPLY_ID) ? string.Empty : obj.APPLY_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MOBILE"))
			{
				strBuf.Add("  HEM_B_PHONE_CALLBARK.MOBILE = :U_MOBILE");
				param = new OracleParameter();
				param.ParameterName = ":U_MOBILE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MOBILE) ? string.Empty : obj.MOBILE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SEND_ID"))
			{
				strBuf.Add("  HEM_B_PHONE_CALLBARK.SEND_ID = :U_SEND_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_SEND_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.SEND_ID) ? string.Empty : obj.SEND_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INSERTTIME"))
			{
				strBuf.Add("  HEM_B_PHONE_CALLBARK.INSERTTIME = :U_INSERTTIME");
				param = new OracleParameter();
				param.ParameterName = ":U_INSERTTIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.INSERTTIME;
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
