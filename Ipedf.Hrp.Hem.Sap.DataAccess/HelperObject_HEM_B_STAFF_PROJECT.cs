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
	[CauseObject(typeof(CauseObject_HEM_B_STAFF_PROJECT))]
	public partial class HelperObject_HEM_B_STAFF_PROJECT
	{		
		#region Method Blok
		public static int Save(EntityObject_HEM_B_STAFF_PROJECT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into HEM_B_STAFF_PROJECT( ENDDA, ZHRXMLBLY, ZHRXMMC, STAFF_ID, ID, ZHRXMJF, ZHRXMPM, BEGDA) values ( :ENDDA, :ZHRXMLBLY, :ZHRXMMC, :STAFF_ID, :ID, :ZHRXMJF, :ZHRXMPM, :BEGDA)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[8];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ENDDA";
			parameters[0].Size = 7;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[0].Value = obj.ENDDA;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ZHRXMLBLY";
			parameters[1].Size = 300;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.ZHRXMLBLY == null ? String.Empty:obj.ZHRXMLBLY;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ZHRXMMC";
			parameters[2].Size = 300;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.ZHRXMMC == null ? String.Empty:obj.ZHRXMMC;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":STAFF_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.STAFF_ID == null ? String.Empty:obj.STAFF_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":ID";
			parameters[4].Size = 36;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[4].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":ZHRXMJF";
			parameters[5].Size = 300;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.ZHRXMJF == null ? String.Empty:obj.ZHRXMJF;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":ZHRXMPM";
			parameters[6].Size = 300;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.ZHRXMPM == null ? String.Empty:obj.ZHRXMPM;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":BEGDA";
			parameters[7].Size = 7;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[7].Value = obj.BEGDA;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_STAFF_PROJECT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_STAFF_PROJECT set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_STAFF_PROJECT obj,CauseObject_HEM_B_STAFF_PROJECT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_STAFF_PROJECT set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_HEM_B_STAFF_PROJECT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from HEM_B_STAFF_PROJECT where  ID = :ID ";
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
		public static int Delete(CauseObject_HEM_B_STAFF_PROJECT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from HEM_B_STAFF_PROJECT where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_HEM_B_STAFF_PROJECT Get(EntityObject_HEM_B_STAFF_PROJECT obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ENDDA, ZHRXMLBLY, ZHRXMMC, STAFF_ID, ID, ZHRXMJF, ZHRXMPM, BEGDA from HEM_B_STAFF_PROJECT where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_STAFF_PROJECT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_STAFF_PROJECT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ENDDA = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRXMLBLY = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRXMMC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRXMJF = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRXMPM = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BEGDA = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_HEM_B_STAFF_PROJECT[] objs = new EntityObject_HEM_B_STAFF_PROJECT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_HEM_B_STAFF_PROJECT Get(EntityObject_HEM_B_STAFF_PROJECT obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ENDDA, ZHRXMLBLY, ZHRXMMC, STAFF_ID, ID, ZHRXMJF, ZHRXMPM, BEGDA from HEM_B_STAFF_PROJECT where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_STAFF_PROJECT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_STAFF_PROJECT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ENDDA = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRXMLBLY = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRXMMC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRXMJF = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRXMPM = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BEGDA = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_HEM_B_STAFF_PROJECT[] objs = new EntityObject_HEM_B_STAFF_PROJECT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_HEM_B_STAFF_PROJECT[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  HEM_B_STAFF_PROJECT.ENDDA, HEM_B_STAFF_PROJECT.ZHRXMLBLY, HEM_B_STAFF_PROJECT.ZHRXMMC, HEM_B_STAFF_PROJECT.STAFF_ID, HEM_B_STAFF_PROJECT.ID, HEM_B_STAFF_PROJECT.ZHRXMJF, HEM_B_STAFF_PROJECT.ZHRXMPM, HEM_B_STAFF_PROJECT.BEGDA from HEM_B_STAFF_PROJECT where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_HEM_B_STAFF_PROJECT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_PROJECT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ENDDA = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRXMLBLY = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRXMMC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRXMJF = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRXMPM = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BEGDA = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_PROJECT[] objs = new DisplayObject_HEM_B_STAFF_PROJECT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_HEM_B_STAFF_PROJECT cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.ENDDA!= null)
			{
				if (cause.ENDDA.Begin != null)
				{
					strBuf.Append(" And HEM_B_STAFF_PROJECT.ENDDA >= :C_ENDDA_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_ENDDA_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.ENDDA.Begin;
					paramList.Add(param);
				}
				if (cause.ENDDA.End != null)
				{
					strBuf.Append(" And HEM_B_STAFF_PROJECT.ENDDA < :C_ENDDA_END");
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
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_PROJECT", "ENDDA"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRXMLBLY))
			{
				strBuf.Append(" And HEM_B_STAFF_PROJECT.ZHRXMLBLY ").Append((cause.ZHRXMLBLY.StartsWith("%") || cause.ZHRXMLBLY.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRXMLBLY");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRXMLBLY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.ZHRXMLBLY;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRXMLBLY"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_PROJECT", "ZHRXMLBLY"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRXMMC))
			{
				strBuf.Append(" And HEM_B_STAFF_PROJECT.ZHRXMMC ").Append((cause.ZHRXMMC.StartsWith("%") || cause.ZHRXMMC.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRXMMC");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRXMMC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.ZHRXMMC;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRXMMC"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_PROJECT", "ZHRXMMC"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_ID))
			{
				strBuf.Append(" And HEM_B_STAFF_PROJECT.STAFF_ID ").Append((cause.STAFF_ID.StartsWith("%") || cause.STAFF_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_ID");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_PROJECT", "STAFF_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And HEM_B_STAFF_PROJECT.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_PROJECT", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRXMJF))
			{
				strBuf.Append(" And HEM_B_STAFF_PROJECT.ZHRXMJF ").Append((cause.ZHRXMJF.StartsWith("%") || cause.ZHRXMJF.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRXMJF");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRXMJF";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.ZHRXMJF;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRXMJF"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_PROJECT", "ZHRXMJF"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRXMPM))
			{
				strBuf.Append(" And HEM_B_STAFF_PROJECT.ZHRXMPM ").Append((cause.ZHRXMPM.StartsWith("%") || cause.ZHRXMPM.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRXMPM");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRXMPM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.ZHRXMPM;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRXMPM"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_PROJECT", "ZHRXMPM"));
			}
			if(cause.BEGDA!= null)
			{
				if (cause.BEGDA.Begin != null)
				{
					strBuf.Append(" And HEM_B_STAFF_PROJECT.BEGDA >= :C_BEGDA_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_BEGDA_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.BEGDA.Begin;
					paramList.Add(param);
				}
				if (cause.BEGDA.End != null)
				{
					strBuf.Append(" And HEM_B_STAFF_PROJECT.BEGDA < :C_BEGDA_END");
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
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_PROJECT", "BEGDA"));
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
		public static DisplayObject_HEM_B_STAFF_PROJECT[] Query(CauseObject_HEM_B_STAFF_PROJECT cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_PROJECT.ENDDA, HEM_B_STAFF_PROJECT.ZHRXMLBLY, HEM_B_STAFF_PROJECT.ZHRXMMC, HEM_B_STAFF_PROJECT.STAFF_ID, HEM_B_STAFF_PROJECT.ID, HEM_B_STAFF_PROJECT.ZHRXMJF, HEM_B_STAFF_PROJECT.ZHRXMPM, HEM_B_STAFF_PROJECT.BEGDA from HEM_B_STAFF_PROJECT where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_STAFF_PROJECT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_PROJECT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ENDDA = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRXMLBLY = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRXMMC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRXMJF = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRXMPM = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BEGDA = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_PROJECT[] objs = new DisplayObject_HEM_B_STAFF_PROJECT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_HEM_B_STAFF_PROJECT[] Query(CauseObject_HEM_B_STAFF_PROJECT cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_PROJECT.ENDDA, HEM_B_STAFF_PROJECT.ZHRXMLBLY, HEM_B_STAFF_PROJECT.ZHRXMMC, HEM_B_STAFF_PROJECT.STAFF_ID, HEM_B_STAFF_PROJECT.ID, HEM_B_STAFF_PROJECT.ZHRXMJF, HEM_B_STAFF_PROJECT.ZHRXMPM, HEM_B_STAFF_PROJECT.BEGDA from HEM_B_STAFF_PROJECT where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_STAFF_PROJECT dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_PROJECT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ENDDA = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRXMLBLY = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRXMMC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRXMJF = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRXMPM = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BEGDA = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_STAFF_PROJECT[] objs = new DisplayObject_HEM_B_STAFF_PROJECT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_STAFF_PROJECT[] Query(CauseObject_HEM_B_STAFF_PROJECT cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_PROJECT.ENDDA, HEM_B_STAFF_PROJECT.ZHRXMLBLY, HEM_B_STAFF_PROJECT.ZHRXMMC, HEM_B_STAFF_PROJECT.STAFF_ID, HEM_B_STAFF_PROJECT.ID, HEM_B_STAFF_PROJECT.ZHRXMJF, HEM_B_STAFF_PROJECT.ZHRXMPM, HEM_B_STAFF_PROJECT.BEGDA from HEM_B_STAFF_PROJECT where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_STAFF_PROJECT",paging, order, sSql, parameters, connection);
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
			DisplayObject_HEM_B_STAFF_PROJECT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_PROJECT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ENDDA = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRXMLBLY = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRXMMC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRXMJF = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRXMPM = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BEGDA = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_PROJECT[] objs = new DisplayObject_HEM_B_STAFF_PROJECT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_STAFF_PROJECT[] Query(CauseObject_HEM_B_STAFF_PROJECT cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_PROJECT.ENDDA, HEM_B_STAFF_PROJECT.ZHRXMLBLY, HEM_B_STAFF_PROJECT.ZHRXMMC, HEM_B_STAFF_PROJECT.STAFF_ID, HEM_B_STAFF_PROJECT.ID, HEM_B_STAFF_PROJECT.ZHRXMJF, HEM_B_STAFF_PROJECT.ZHRXMPM, HEM_B_STAFF_PROJECT.BEGDA from HEM_B_STAFF_PROJECT where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_STAFF_PROJECT",paging, order, sSql, parameters, trans);
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
			DisplayObject_HEM_B_STAFF_PROJECT dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_PROJECT();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ENDDA = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRXMLBLY = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRXMMC = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ID = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRXMJF = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRXMPM = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.BEGDA = sqlReader.GetDateTime(7);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_STAFF_PROJECT[] objs = new DisplayObject_HEM_B_STAFF_PROJECT[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_HEM_B_STAFF_PROJECT obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("ENDDA"))
			{
				strBuf.Add("  HEM_B_STAFF_PROJECT.ENDDA = :U_ENDDA");
				param = new OracleParameter();
				param.ParameterName = ":U_ENDDA";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.ENDDA;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRXMLBLY"))
			{
				strBuf.Add("  HEM_B_STAFF_PROJECT.ZHRXMLBLY = :U_ZHRXMLBLY");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRXMLBLY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.ZHRXMLBLY) ? string.Empty : obj.ZHRXMLBLY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRXMMC"))
			{
				strBuf.Add("  HEM_B_STAFF_PROJECT.ZHRXMMC = :U_ZHRXMMC");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRXMMC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.ZHRXMMC) ? string.Empty : obj.ZHRXMMC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STAFF_ID"))
			{
				strBuf.Add("  HEM_B_STAFF_PROJECT.STAFF_ID = :U_STAFF_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_STAFF_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.STAFF_ID) ? string.Empty : obj.STAFF_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRXMJF"))
			{
				strBuf.Add("  HEM_B_STAFF_PROJECT.ZHRXMJF = :U_ZHRXMJF");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRXMJF";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.ZHRXMJF) ? string.Empty : obj.ZHRXMJF;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRXMPM"))
			{
				strBuf.Add("  HEM_B_STAFF_PROJECT.ZHRXMPM = :U_ZHRXMPM");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRXMPM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.ZHRXMPM) ? string.Empty : obj.ZHRXMPM;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BEGDA"))
			{
				strBuf.Add("  HEM_B_STAFF_PROJECT.BEGDA = :U_BEGDA");
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
