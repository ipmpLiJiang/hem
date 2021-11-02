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
	[CauseObject(typeof(CauseObject_HEM_B_STAFF_WORK))]
	public partial class HelperObject_HEM_B_STAFF_WORK
	{		
		#region Method Blok
		public static int Save(EntityObject_HEM_B_STAFF_WORK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into HEM_B_STAFF_WORK( SLART, ENDDA, ID, ZHRXXDW, ZHRGZZW, STAFF_ID, ZHRZYBM, BEGDA) values ( :SLART, :ENDDA, :ID, :ZHRXXDW, :ZHRGZZW, :STAFF_ID, :ZHRZYBM, :BEGDA)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[8];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":SLART";
			parameters[0].Size = 2;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.SLART == null ? String.Empty:obj.SLART;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ENDDA";
			parameters[1].Size = 7;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[1].Value = obj.ENDDA;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":ZHRXXDW";
			parameters[3].Size = 300;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.ZHRXXDW == null ? String.Empty:obj.ZHRXXDW;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":ZHRGZZW";
			parameters[4].Size = 300;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.ZHRGZZW == null ? String.Empty:obj.ZHRGZZW;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":STAFF_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.STAFF_ID == null ? String.Empty:obj.STAFF_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":ZHRZYBM";
			parameters[6].Size = 300;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.ZHRZYBM == null ? String.Empty:obj.ZHRZYBM;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":BEGDA";
			parameters[7].Size = 7;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[7].Value = obj.BEGDA;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_STAFF_WORK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_STAFF_WORK set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_STAFF_WORK obj,CauseObject_HEM_B_STAFF_WORK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_STAFF_WORK set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_HEM_B_STAFF_WORK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from HEM_B_STAFF_WORK where  ID = :ID ";
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
		public static int Delete(CauseObject_HEM_B_STAFF_WORK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from HEM_B_STAFF_WORK where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_HEM_B_STAFF_WORK Get(EntityObject_HEM_B_STAFF_WORK obj)
		{
			
			//平台自动生成代码
			string sSql = "select  SLART, ENDDA, ID, ZHRXXDW, ZHRGZZW, STAFF_ID, ZHRZYBM, BEGDA from HEM_B_STAFF_WORK where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_STAFF_WORK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_STAFF_WORK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SLART = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ENDDA = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ZHRXXDW = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ZHRGZZW = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STAFF_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRZYBM = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BEGDA = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_HEM_B_STAFF_WORK[] objs = new EntityObject_HEM_B_STAFF_WORK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_HEM_B_STAFF_WORK Get(EntityObject_HEM_B_STAFF_WORK obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  SLART, ENDDA, ID, ZHRXXDW, ZHRGZZW, STAFF_ID, ZHRZYBM, BEGDA from HEM_B_STAFF_WORK where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_STAFF_WORK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_STAFF_WORK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SLART = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ENDDA = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ZHRXXDW = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ZHRGZZW = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STAFF_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRZYBM = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BEGDA = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_HEM_B_STAFF_WORK[] objs = new EntityObject_HEM_B_STAFF_WORK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_HEM_B_STAFF_WORK[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  HEM_B_STAFF_WORK.SLART, HEM_B_STAFF_WORK.ENDDA, HEM_B_STAFF_WORK.ID, HEM_B_STAFF_WORK.ZHRXXDW, HEM_B_STAFF_WORK.ZHRGZZW, HEM_B_STAFF_WORK.STAFF_ID, HEM_B_STAFF_WORK.ZHRZYBM, HEM_B_STAFF_WORK.BEGDA from HEM_B_STAFF_WORK where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_HEM_B_STAFF_WORK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_WORK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SLART = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ENDDA = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ZHRXXDW = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ZHRGZZW = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STAFF_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRZYBM = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BEGDA = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_WORK[] objs = new DisplayObject_HEM_B_STAFF_WORK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_HEM_B_STAFF_WORK cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.SLART))
			{
				strBuf.Append(" And HEM_B_STAFF_WORK.SLART ").Append((cause.SLART.StartsWith("%") || cause.SLART.EndsWith("%")) ? " like " : " = ").Append(" :C_SLART");
				param = new OracleParameter();
				param.ParameterName =":C_SLART";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = cause.SLART;
				paramList.Add(param);
			}
			if (cause.HasINValue("SLART"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_WORK", "SLART"));
			}
			if(cause.ENDDA!= null)
			{
				if (cause.ENDDA.Begin != null)
				{
					strBuf.Append(" And HEM_B_STAFF_WORK.ENDDA >= :C_ENDDA_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_ENDDA_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.ENDDA.Begin;
					paramList.Add(param);
				}
				if (cause.ENDDA.End != null)
				{
					strBuf.Append(" And HEM_B_STAFF_WORK.ENDDA < :C_ENDDA_END");
					param = new OracleParameter();
					param.ParameterName = ":C_ENDDA_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.ENDDA.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("ENDDA"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_WORK", "ENDDA"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And HEM_B_STAFF_WORK.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_WORK", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRXXDW))
			{
				strBuf.Append(" And HEM_B_STAFF_WORK.ZHRXXDW ").Append((cause.ZHRXXDW.StartsWith("%") || cause.ZHRXXDW.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRXXDW");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRXXDW";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.ZHRXXDW;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRXXDW"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_WORK", "ZHRXXDW"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRGZZW))
			{
				strBuf.Append(" And HEM_B_STAFF_WORK.ZHRGZZW ").Append((cause.ZHRGZZW.StartsWith("%") || cause.ZHRGZZW.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRGZZW");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRGZZW";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.ZHRGZZW;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRGZZW"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_WORK", "ZHRGZZW"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_ID))
			{
				strBuf.Append(" And HEM_B_STAFF_WORK.STAFF_ID ").Append((cause.STAFF_ID.StartsWith("%") || cause.STAFF_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_ID");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_WORK", "STAFF_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRZYBM))
			{
				strBuf.Append(" And HEM_B_STAFF_WORK.ZHRZYBM ").Append((cause.ZHRZYBM.StartsWith("%") || cause.ZHRZYBM.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRZYBM");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRZYBM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.ZHRZYBM;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRZYBM"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_WORK", "ZHRZYBM"));
			}
			if(cause.BEGDA!= null)
			{
				if (cause.BEGDA.Begin != null)
				{
					strBuf.Append(" And HEM_B_STAFF_WORK.BEGDA >= :C_BEGDA_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_BEGDA_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.BEGDA.Begin;
					paramList.Add(param);
				}
				if (cause.BEGDA.End != null)
				{
					strBuf.Append(" And HEM_B_STAFF_WORK.BEGDA < :C_BEGDA_END");
					param = new OracleParameter();
					param.ParameterName = ":C_BEGDA_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.BEGDA.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("BEGDA"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_WORK", "BEGDA"));
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
		public static DisplayObject_HEM_B_STAFF_WORK[] Query(CauseObject_HEM_B_STAFF_WORK cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_WORK.SLART, HEM_B_STAFF_WORK.ENDDA, HEM_B_STAFF_WORK.ID, HEM_B_STAFF_WORK.ZHRXXDW, HEM_B_STAFF_WORK.ZHRGZZW, HEM_B_STAFF_WORK.STAFF_ID, HEM_B_STAFF_WORK.ZHRZYBM, HEM_B_STAFF_WORK.BEGDA from HEM_B_STAFF_WORK where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_STAFF_WORK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_WORK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SLART = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ENDDA = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ZHRXXDW = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ZHRGZZW = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STAFF_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRZYBM = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BEGDA = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_WORK[] objs = new DisplayObject_HEM_B_STAFF_WORK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_HEM_B_STAFF_WORK[] Query(CauseObject_HEM_B_STAFF_WORK cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_WORK.SLART, HEM_B_STAFF_WORK.ENDDA, HEM_B_STAFF_WORK.ID, HEM_B_STAFF_WORK.ZHRXXDW, HEM_B_STAFF_WORK.ZHRGZZW, HEM_B_STAFF_WORK.STAFF_ID, HEM_B_STAFF_WORK.ZHRZYBM, HEM_B_STAFF_WORK.BEGDA from HEM_B_STAFF_WORK where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_STAFF_WORK dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_WORK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SLART = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ENDDA = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ZHRXXDW = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ZHRGZZW = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STAFF_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRZYBM = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BEGDA = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_STAFF_WORK[] objs = new DisplayObject_HEM_B_STAFF_WORK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_STAFF_WORK[] Query(CauseObject_HEM_B_STAFF_WORK cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_WORK.SLART, HEM_B_STAFF_WORK.ENDDA, HEM_B_STAFF_WORK.ID, HEM_B_STAFF_WORK.ZHRXXDW, HEM_B_STAFF_WORK.ZHRGZZW, HEM_B_STAFF_WORK.STAFF_ID, HEM_B_STAFF_WORK.ZHRZYBM, HEM_B_STAFF_WORK.BEGDA from HEM_B_STAFF_WORK where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_STAFF_WORK",paging, order, sSql, parameters, connection);
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
			DisplayObject_HEM_B_STAFF_WORK dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_WORK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SLART = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ENDDA = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ZHRXXDW = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ZHRGZZW = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STAFF_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRZYBM = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BEGDA = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_WORK[] objs = new DisplayObject_HEM_B_STAFF_WORK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_STAFF_WORK[] Query(CauseObject_HEM_B_STAFF_WORK cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_WORK.SLART, HEM_B_STAFF_WORK.ENDDA, HEM_B_STAFF_WORK.ID, HEM_B_STAFF_WORK.ZHRXXDW, HEM_B_STAFF_WORK.ZHRGZZW, HEM_B_STAFF_WORK.STAFF_ID, HEM_B_STAFF_WORK.ZHRZYBM, HEM_B_STAFF_WORK.BEGDA from HEM_B_STAFF_WORK where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_STAFF_WORK",paging, order, sSql, parameters, trans);
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
			DisplayObject_HEM_B_STAFF_WORK dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_WORK();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SLART = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ENDDA = sqlReader.GetDateTime(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.ZHRXXDW = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ZHRGZZW = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STAFF_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRZYBM = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BEGDA = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_STAFF_WORK[] objs = new DisplayObject_HEM_B_STAFF_WORK[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_HEM_B_STAFF_WORK obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("SLART"))
			{
				strBuf.Add("  HEM_B_STAFF_WORK.SLART = :U_SLART");
				param = new OracleParameter();
				param.ParameterName = ":U_SLART";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = string.IsNullOrEmpty(obj.SLART) ? string.Empty : obj.SLART;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ENDDA"))
			{
				strBuf.Add("  HEM_B_STAFF_WORK.ENDDA = :U_ENDDA");
				param = new OracleParameter();
				param.ParameterName = ":U_ENDDA";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.ENDDA;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRXXDW"))
			{
				strBuf.Add("  HEM_B_STAFF_WORK.ZHRXXDW = :U_ZHRXXDW");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRXXDW";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.ZHRXXDW) ? string.Empty : obj.ZHRXXDW;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRGZZW"))
			{
				strBuf.Add("  HEM_B_STAFF_WORK.ZHRGZZW = :U_ZHRGZZW");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRGZZW";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.ZHRGZZW) ? string.Empty : obj.ZHRGZZW;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STAFF_ID"))
			{
				strBuf.Add("  HEM_B_STAFF_WORK.STAFF_ID = :U_STAFF_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_STAFF_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.STAFF_ID) ? string.Empty : obj.STAFF_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRZYBM"))
			{
				strBuf.Add("  HEM_B_STAFF_WORK.ZHRZYBM = :U_ZHRZYBM");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRZYBM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.ZHRZYBM) ? string.Empty : obj.ZHRZYBM;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BEGDA"))
			{
				strBuf.Add("  HEM_B_STAFF_WORK.BEGDA = :U_BEGDA");
				param = new OracleParameter();
				param.ParameterName = ":U_BEGDA";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.BEGDA;
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
