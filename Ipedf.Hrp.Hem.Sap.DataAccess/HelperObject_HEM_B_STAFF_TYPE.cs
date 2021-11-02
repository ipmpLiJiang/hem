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
	[CauseObject(typeof(CauseObject_HEM_B_STAFF_TYPE))]
	public partial class HelperObject_HEM_B_STAFF_TYPE
	{		
		#region Method Blok
		public static int Save(EntityObject_HEM_B_STAFF_TYPE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into HEM_B_STAFF_TYPE( ID, TYPE_ID, USER_ID, STAFF_ID, IS_ACTION, FILE_PATH, PRACTICE_TYPE_ID, IS_CERTIFICATE, IS_NURSE) values ( :ID, :TYPE_ID, :USER_ID, :STAFF_ID, :IS_ACTION, :FILE_PATH, :PRACTICE_TYPE_ID, :IS_CERTIFICATE, :IS_NURSE)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[9];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":TYPE_ID";
			parameters[1].Size = 10;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.TYPE_ID == null ? String.Empty:obj.TYPE_ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":USER_ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.USER_ID == null ? String.Empty:obj.USER_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":STAFF_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.STAFF_ID == null ? String.Empty:obj.STAFF_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":IS_ACTION";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.IS_ACTION;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":FILE_PATH";
			parameters[5].Size = 300;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.FILE_PATH == null ? String.Empty:obj.FILE_PATH;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":PRACTICE_TYPE_ID";
			parameters[6].Size = 50;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.PRACTICE_TYPE_ID == null ? String.Empty:obj.PRACTICE_TYPE_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":IS_CERTIFICATE";
			parameters[7].Size = 22;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[7].Value = obj.IS_CERTIFICATE;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":IS_NURSE";
			parameters[8].Size = 22;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[8].Value = obj.IS_NURSE;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_STAFF_TYPE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_STAFF_TYPE set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_STAFF_TYPE obj,CauseObject_HEM_B_STAFF_TYPE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_STAFF_TYPE set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_HEM_B_STAFF_TYPE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from HEM_B_STAFF_TYPE where  ID = :ID ";
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
		public static int Delete(CauseObject_HEM_B_STAFF_TYPE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from HEM_B_STAFF_TYPE where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_HEM_B_STAFF_TYPE Get(EntityObject_HEM_B_STAFF_TYPE obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, TYPE_ID, USER_ID, STAFF_ID, IS_ACTION, FILE_PATH, PRACTICE_TYPE_ID, IS_CERTIFICATE, IS_NURSE from HEM_B_STAFF_TYPE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_STAFF_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_STAFF_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.TYPE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_ACTION = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FILE_PATH = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRACTICE_TYPE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_HEM_B_STAFF_TYPE[] objs = new EntityObject_HEM_B_STAFF_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_HEM_B_STAFF_TYPE Get(EntityObject_HEM_B_STAFF_TYPE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, TYPE_ID, USER_ID, STAFF_ID, IS_ACTION, FILE_PATH, PRACTICE_TYPE_ID, IS_CERTIFICATE, IS_NURSE from HEM_B_STAFF_TYPE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_STAFF_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_STAFF_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.TYPE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_ACTION = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FILE_PATH = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRACTICE_TYPE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_HEM_B_STAFF_TYPE[] objs = new EntityObject_HEM_B_STAFF_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_HEM_B_STAFF_TYPE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  HEM_B_STAFF_TYPE.ID, HEM_B_STAFF_TYPE.TYPE_ID, HEM_B_STAFF_TYPE.USER_ID, HEM_B_STAFF_TYPE.STAFF_ID, HEM_B_STAFF_TYPE.IS_ACTION, HEM_B_STAFF_TYPE.FILE_PATH, HEM_B_STAFF_TYPE.PRACTICE_TYPE_ID, HEM_B_STAFF_TYPE.IS_CERTIFICATE, HEM_B_STAFF_TYPE.IS_NURSE from HEM_B_STAFF_TYPE where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_HEM_B_STAFF_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.TYPE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_ACTION = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FILE_PATH = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRACTICE_TYPE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_TYPE[] objs = new DisplayObject_HEM_B_STAFF_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_HEM_B_STAFF_TYPE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And HEM_B_STAFF_TYPE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_TYPE", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.TYPE_ID))
			{
				strBuf.Append(" And HEM_B_STAFF_TYPE.TYPE_ID ").Append((cause.TYPE_ID.StartsWith("%") || cause.TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_TYPE", "TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.USER_ID))
			{
				strBuf.Append(" And HEM_B_STAFF_TYPE.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_TYPE", "USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_ID))
			{
				strBuf.Append(" And HEM_B_STAFF_TYPE.STAFF_ID ").Append((cause.STAFF_ID.StartsWith("%") || cause.STAFF_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_ID");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_TYPE", "STAFF_ID"));
			}
			if(cause.IS_ACTION!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_STAFF_TYPE.IS_ACTION = :C_IS_ACTION");
				param = new OracleParameter();
				param.ParameterName =":C_IS_ACTION";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_ACTION;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_ACTION"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_TYPE", "IS_ACTION"));
			}
			if(!string.IsNullOrEmpty(cause.FILE_PATH))
			{
				strBuf.Append(" And HEM_B_STAFF_TYPE.FILE_PATH ").Append((cause.FILE_PATH.StartsWith("%") || cause.FILE_PATH.EndsWith("%")) ? " like " : " = ").Append(" :C_FILE_PATH");
				param = new OracleParameter();
				param.ParameterName =":C_FILE_PATH";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.FILE_PATH;
				paramList.Add(param);
			}
			if (cause.HasINValue("FILE_PATH"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_TYPE", "FILE_PATH"));
			}
			if(!string.IsNullOrEmpty(cause.PRACTICE_TYPE_ID))
			{
				strBuf.Append(" And HEM_B_STAFF_TYPE.PRACTICE_TYPE_ID ").Append((cause.PRACTICE_TYPE_ID.StartsWith("%") || cause.PRACTICE_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_PRACTICE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_PRACTICE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PRACTICE_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRACTICE_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_TYPE", "PRACTICE_TYPE_ID"));
			}
			if(cause.IS_CERTIFICATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_STAFF_TYPE.IS_CERTIFICATE = :C_IS_CERTIFICATE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_CERTIFICATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_CERTIFICATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_CERTIFICATE"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_TYPE", "IS_CERTIFICATE"));
			}
			if(cause.IS_NURSE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_STAFF_TYPE.IS_NURSE = :C_IS_NURSE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_NURSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_NURSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_NURSE"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_TYPE", "IS_NURSE"));
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
		public static DisplayObject_HEM_B_STAFF_TYPE[] Query(CauseObject_HEM_B_STAFF_TYPE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_TYPE.ID, HEM_B_STAFF_TYPE.TYPE_ID, HEM_B_STAFF_TYPE.USER_ID, HEM_B_STAFF_TYPE.STAFF_ID, HEM_B_STAFF_TYPE.IS_ACTION, HEM_B_STAFF_TYPE.FILE_PATH, HEM_B_STAFF_TYPE.PRACTICE_TYPE_ID, HEM_B_STAFF_TYPE.IS_CERTIFICATE, HEM_B_STAFF_TYPE.IS_NURSE from HEM_B_STAFF_TYPE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_STAFF_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.TYPE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_ACTION = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FILE_PATH = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRACTICE_TYPE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_TYPE[] objs = new DisplayObject_HEM_B_STAFF_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_HEM_B_STAFF_TYPE[] Query(CauseObject_HEM_B_STAFF_TYPE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_TYPE.ID, HEM_B_STAFF_TYPE.TYPE_ID, HEM_B_STAFF_TYPE.USER_ID, HEM_B_STAFF_TYPE.STAFF_ID, HEM_B_STAFF_TYPE.IS_ACTION, HEM_B_STAFF_TYPE.FILE_PATH, HEM_B_STAFF_TYPE.PRACTICE_TYPE_ID, HEM_B_STAFF_TYPE.IS_CERTIFICATE, HEM_B_STAFF_TYPE.IS_NURSE from HEM_B_STAFF_TYPE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_STAFF_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.TYPE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_ACTION = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FILE_PATH = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRACTICE_TYPE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_STAFF_TYPE[] objs = new DisplayObject_HEM_B_STAFF_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_STAFF_TYPE[] Query(CauseObject_HEM_B_STAFF_TYPE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_TYPE.ID, HEM_B_STAFF_TYPE.TYPE_ID, HEM_B_STAFF_TYPE.USER_ID, HEM_B_STAFF_TYPE.STAFF_ID, HEM_B_STAFF_TYPE.IS_ACTION, HEM_B_STAFF_TYPE.FILE_PATH, HEM_B_STAFF_TYPE.PRACTICE_TYPE_ID, HEM_B_STAFF_TYPE.IS_CERTIFICATE, HEM_B_STAFF_TYPE.IS_NURSE from HEM_B_STAFF_TYPE where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_STAFF_TYPE",paging, order, sSql, parameters, connection);
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
			DisplayObject_HEM_B_STAFF_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.TYPE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_ACTION = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FILE_PATH = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRACTICE_TYPE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_TYPE[] objs = new DisplayObject_HEM_B_STAFF_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_STAFF_TYPE[] Query(CauseObject_HEM_B_STAFF_TYPE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_TYPE.ID, HEM_B_STAFF_TYPE.TYPE_ID, HEM_B_STAFF_TYPE.USER_ID, HEM_B_STAFF_TYPE.STAFF_ID, HEM_B_STAFF_TYPE.IS_ACTION, HEM_B_STAFF_TYPE.FILE_PATH, HEM_B_STAFF_TYPE.PRACTICE_TYPE_ID, HEM_B_STAFF_TYPE.IS_CERTIFICATE, HEM_B_STAFF_TYPE.IS_NURSE from HEM_B_STAFF_TYPE where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_STAFF_TYPE",paging, order, sSql, parameters, trans);
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
			DisplayObject_HEM_B_STAFF_TYPE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_TYPE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.TYPE_ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.USER_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_ACTION = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.FILE_PATH = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.PRACTICE_TYPE_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(8);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_STAFF_TYPE[] objs = new DisplayObject_HEM_B_STAFF_TYPE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_HEM_B_STAFF_TYPE obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("TYPE_ID"))
			{
				strBuf.Add("  HEM_B_STAFF_TYPE.TYPE_ID = :U_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.TYPE_ID) ? string.Empty : obj.TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USER_ID"))
			{
				strBuf.Add("  HEM_B_STAFF_TYPE.USER_ID = :U_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USER_ID) ? string.Empty : obj.USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STAFF_ID"))
			{
				strBuf.Add("  HEM_B_STAFF_TYPE.STAFF_ID = :U_STAFF_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_STAFF_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.STAFF_ID) ? string.Empty : obj.STAFF_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_ACTION"))
			{
				strBuf.Add("  HEM_B_STAFF_TYPE.IS_ACTION = :U_IS_ACTION");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_ACTION";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_ACTION;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FILE_PATH"))
			{
				strBuf.Add("  HEM_B_STAFF_TYPE.FILE_PATH = :U_FILE_PATH");
				param = new OracleParameter();
				param.ParameterName = ":U_FILE_PATH";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.FILE_PATH) ? string.Empty : obj.FILE_PATH;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PRACTICE_TYPE_ID"))
			{
				strBuf.Add("  HEM_B_STAFF_TYPE.PRACTICE_TYPE_ID = :U_PRACTICE_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_PRACTICE_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.PRACTICE_TYPE_ID) ? string.Empty : obj.PRACTICE_TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_CERTIFICATE"))
			{
				strBuf.Add("  HEM_B_STAFF_TYPE.IS_CERTIFICATE = :U_IS_CERTIFICATE");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_CERTIFICATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_CERTIFICATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_NURSE"))
			{
				strBuf.Add("  HEM_B_STAFF_TYPE.IS_NURSE = :U_IS_NURSE");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_NURSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_NURSE;
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
