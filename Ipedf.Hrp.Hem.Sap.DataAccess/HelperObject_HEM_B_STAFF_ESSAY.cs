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
	[CauseObject(typeof(CauseObject_HEM_B_STAFF_ESSAY))]
	public partial class HelperObject_HEM_B_STAFF_ESSAY
	{		
		#region Method Blok
		public static int Save(EntityObject_HEM_B_STAFF_ESSAY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into HEM_B_STAFF_ESSAY( ID, ZHRYXYZ, ZHRCBKH, STAFF_ID, ZHRBRMP, ZHRFBZT, ZHRCBKW, ZHRWZMC, BEGDA, ZHRKWJB) values ( :ID, :ZHRYXYZ, :ZHRCBKH, :STAFF_ID, :ZHRBRMP, :ZHRFBZT, :ZHRCBKW, :ZHRWZMC, :BEGDA, :ZHRKWJB)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[10];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ZHRYXYZ";
			parameters[1].Size = 300;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.ZHRYXYZ == null ? String.Empty:obj.ZHRYXYZ;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ZHRCBKH";
			parameters[2].Size = 300;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.ZHRCBKH == null ? String.Empty:obj.ZHRCBKH;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":STAFF_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.STAFF_ID == null ? String.Empty:obj.STAFF_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":ZHRBRMP";
			parameters[4].Size = 1;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.ZHRBRMP == null ? String.Empty:obj.ZHRBRMP;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":ZHRFBZT";
			parameters[5].Size = 2;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.ZHRFBZT == null ? String.Empty:obj.ZHRFBZT;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":ZHRCBKW";
			parameters[6].Size = 300;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.ZHRCBKW == null ? String.Empty:obj.ZHRCBKW;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":ZHRWZMC";
			parameters[7].Size = 300;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.ZHRWZMC == null ? String.Empty:obj.ZHRWZMC;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":BEGDA";
			parameters[8].Size = 7;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[8].Value = obj.BEGDA;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":ZHRKWJB";
			parameters[9].Size = 1;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.ZHRKWJB == null ? String.Empty:obj.ZHRKWJB;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_STAFF_ESSAY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_STAFF_ESSAY set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_STAFF_ESSAY obj,CauseObject_HEM_B_STAFF_ESSAY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_STAFF_ESSAY set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_HEM_B_STAFF_ESSAY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from HEM_B_STAFF_ESSAY where  ID = :ID ";
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
		public static int Delete(CauseObject_HEM_B_STAFF_ESSAY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from HEM_B_STAFF_ESSAY where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_HEM_B_STAFF_ESSAY Get(EntityObject_HEM_B_STAFF_ESSAY obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, ZHRYXYZ, ZHRCBKH, STAFF_ID, ZHRBRMP, ZHRFBZT, ZHRCBKW, ZHRWZMC, BEGDA, ZHRKWJB from HEM_B_STAFF_ESSAY where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_STAFF_ESSAY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_STAFF_ESSAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRYXYZ = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRCBKH = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ZHRBRMP = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRFBZT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRCBKW = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ZHRWZMC = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BEGDA = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ZHRKWJB = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_HEM_B_STAFF_ESSAY[] objs = new EntityObject_HEM_B_STAFF_ESSAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_HEM_B_STAFF_ESSAY Get(EntityObject_HEM_B_STAFF_ESSAY obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, ZHRYXYZ, ZHRCBKH, STAFF_ID, ZHRBRMP, ZHRFBZT, ZHRCBKW, ZHRWZMC, BEGDA, ZHRKWJB from HEM_B_STAFF_ESSAY where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_STAFF_ESSAY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_STAFF_ESSAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRYXYZ = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRCBKH = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ZHRBRMP = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRFBZT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRCBKW = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ZHRWZMC = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BEGDA = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ZHRKWJB = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_HEM_B_STAFF_ESSAY[] objs = new EntityObject_HEM_B_STAFF_ESSAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_HEM_B_STAFF_ESSAY[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  HEM_B_STAFF_ESSAY.ID, HEM_B_STAFF_ESSAY.ZHRYXYZ, HEM_B_STAFF_ESSAY.ZHRCBKH, HEM_B_STAFF_ESSAY.STAFF_ID, HEM_B_STAFF_ESSAY.ZHRBRMP, HEM_B_STAFF_ESSAY.ZHRFBZT, HEM_B_STAFF_ESSAY.ZHRCBKW, HEM_B_STAFF_ESSAY.ZHRWZMC, HEM_B_STAFF_ESSAY.BEGDA, HEM_B_STAFF_ESSAY.ZHRKWJB from HEM_B_STAFF_ESSAY where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_HEM_B_STAFF_ESSAY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_ESSAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRYXYZ = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRCBKH = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ZHRBRMP = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRFBZT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRCBKW = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ZHRWZMC = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BEGDA = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ZHRKWJB = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_ESSAY[] objs = new DisplayObject_HEM_B_STAFF_ESSAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_HEM_B_STAFF_ESSAY cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And HEM_B_STAFF_ESSAY.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_ESSAY", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRYXYZ))
			{
				strBuf.Append(" And HEM_B_STAFF_ESSAY.ZHRYXYZ ").Append((cause.ZHRYXYZ.StartsWith("%") || cause.ZHRYXYZ.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRYXYZ");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRYXYZ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.ZHRYXYZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRYXYZ"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_ESSAY", "ZHRYXYZ"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRCBKH))
			{
				strBuf.Append(" And HEM_B_STAFF_ESSAY.ZHRCBKH ").Append((cause.ZHRCBKH.StartsWith("%") || cause.ZHRCBKH.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRCBKH");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRCBKH";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.ZHRCBKH;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRCBKH"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_ESSAY", "ZHRCBKH"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_ID))
			{
				strBuf.Append(" And HEM_B_STAFF_ESSAY.STAFF_ID ").Append((cause.STAFF_ID.StartsWith("%") || cause.STAFF_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_ID");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_ESSAY", "STAFF_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRBRMP))
			{
				strBuf.Append(" And HEM_B_STAFF_ESSAY.ZHRBRMP ").Append((cause.ZHRBRMP.StartsWith("%") || cause.ZHRBRMP.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRBRMP");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRBRMP";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.ZHRBRMP;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRBRMP"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_ESSAY", "ZHRBRMP"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRFBZT))
			{
				strBuf.Append(" And HEM_B_STAFF_ESSAY.ZHRFBZT ").Append((cause.ZHRFBZT.StartsWith("%") || cause.ZHRFBZT.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRFBZT");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRFBZT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = cause.ZHRFBZT;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRFBZT"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_ESSAY", "ZHRFBZT"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRCBKW))
			{
				strBuf.Append(" And HEM_B_STAFF_ESSAY.ZHRCBKW ").Append((cause.ZHRCBKW.StartsWith("%") || cause.ZHRCBKW.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRCBKW");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRCBKW";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.ZHRCBKW;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRCBKW"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_ESSAY", "ZHRCBKW"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRWZMC))
			{
				strBuf.Append(" And HEM_B_STAFF_ESSAY.ZHRWZMC ").Append((cause.ZHRWZMC.StartsWith("%") || cause.ZHRWZMC.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRWZMC");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRWZMC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.ZHRWZMC;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRWZMC"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_ESSAY", "ZHRWZMC"));
			}
			if(cause.BEGDA!= null)
			{
				if (cause.BEGDA.Begin != null)
				{
					strBuf.Append(" And HEM_B_STAFF_ESSAY.BEGDA >= :C_BEGDA_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_BEGDA_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.BEGDA.Begin;
					paramList.Add(param);
				}
				if (cause.BEGDA.End != null)
				{
					strBuf.Append(" And HEM_B_STAFF_ESSAY.BEGDA < :C_BEGDA_END");
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
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_ESSAY", "BEGDA"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRKWJB))
			{
				strBuf.Append(" And HEM_B_STAFF_ESSAY.ZHRKWJB ").Append((cause.ZHRKWJB.StartsWith("%") || cause.ZHRKWJB.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRKWJB");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRKWJB";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.ZHRKWJB;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRKWJB"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_ESSAY", "ZHRKWJB"));
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
		public static DisplayObject_HEM_B_STAFF_ESSAY[] Query(CauseObject_HEM_B_STAFF_ESSAY cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_ESSAY.ID, HEM_B_STAFF_ESSAY.ZHRYXYZ, HEM_B_STAFF_ESSAY.ZHRCBKH, HEM_B_STAFF_ESSAY.STAFF_ID, HEM_B_STAFF_ESSAY.ZHRBRMP, HEM_B_STAFF_ESSAY.ZHRFBZT, HEM_B_STAFF_ESSAY.ZHRCBKW, HEM_B_STAFF_ESSAY.ZHRWZMC, HEM_B_STAFF_ESSAY.BEGDA, HEM_B_STAFF_ESSAY.ZHRKWJB from HEM_B_STAFF_ESSAY where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_STAFF_ESSAY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_ESSAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRYXYZ = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRCBKH = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ZHRBRMP = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRFBZT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRCBKW = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ZHRWZMC = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BEGDA = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ZHRKWJB = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_ESSAY[] objs = new DisplayObject_HEM_B_STAFF_ESSAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_HEM_B_STAFF_ESSAY[] Query(CauseObject_HEM_B_STAFF_ESSAY cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_ESSAY.ID, HEM_B_STAFF_ESSAY.ZHRYXYZ, HEM_B_STAFF_ESSAY.ZHRCBKH, HEM_B_STAFF_ESSAY.STAFF_ID, HEM_B_STAFF_ESSAY.ZHRBRMP, HEM_B_STAFF_ESSAY.ZHRFBZT, HEM_B_STAFF_ESSAY.ZHRCBKW, HEM_B_STAFF_ESSAY.ZHRWZMC, HEM_B_STAFF_ESSAY.BEGDA, HEM_B_STAFF_ESSAY.ZHRKWJB from HEM_B_STAFF_ESSAY where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_STAFF_ESSAY dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_ESSAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRYXYZ = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRCBKH = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ZHRBRMP = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRFBZT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRCBKW = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ZHRWZMC = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BEGDA = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ZHRKWJB = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_STAFF_ESSAY[] objs = new DisplayObject_HEM_B_STAFF_ESSAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_STAFF_ESSAY[] Query(CauseObject_HEM_B_STAFF_ESSAY cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_ESSAY.ID, HEM_B_STAFF_ESSAY.ZHRYXYZ, HEM_B_STAFF_ESSAY.ZHRCBKH, HEM_B_STAFF_ESSAY.STAFF_ID, HEM_B_STAFF_ESSAY.ZHRBRMP, HEM_B_STAFF_ESSAY.ZHRFBZT, HEM_B_STAFF_ESSAY.ZHRCBKW, HEM_B_STAFF_ESSAY.ZHRWZMC, HEM_B_STAFF_ESSAY.BEGDA, HEM_B_STAFF_ESSAY.ZHRKWJB from HEM_B_STAFF_ESSAY where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_STAFF_ESSAY",paging, order, sSql, parameters, connection);
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
			DisplayObject_HEM_B_STAFF_ESSAY dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_ESSAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRYXYZ = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRCBKH = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ZHRBRMP = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRFBZT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRCBKW = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ZHRWZMC = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BEGDA = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ZHRKWJB = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_ESSAY[] objs = new DisplayObject_HEM_B_STAFF_ESSAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_STAFF_ESSAY[] Query(CauseObject_HEM_B_STAFF_ESSAY cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_ESSAY.ID, HEM_B_STAFF_ESSAY.ZHRYXYZ, HEM_B_STAFF_ESSAY.ZHRCBKH, HEM_B_STAFF_ESSAY.STAFF_ID, HEM_B_STAFF_ESSAY.ZHRBRMP, HEM_B_STAFF_ESSAY.ZHRFBZT, HEM_B_STAFF_ESSAY.ZHRCBKW, HEM_B_STAFF_ESSAY.ZHRWZMC, HEM_B_STAFF_ESSAY.BEGDA, HEM_B_STAFF_ESSAY.ZHRKWJB from HEM_B_STAFF_ESSAY where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_STAFF_ESSAY",paging, order, sSql, parameters, trans);
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
			DisplayObject_HEM_B_STAFF_ESSAY dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_ESSAY();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRYXYZ = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRCBKH = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.ZHRBRMP = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRFBZT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRCBKW = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ZHRWZMC = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.BEGDA = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.ZHRKWJB = sqlReader.GetString(9);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_STAFF_ESSAY[] objs = new DisplayObject_HEM_B_STAFF_ESSAY[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_HEM_B_STAFF_ESSAY obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("ZHRYXYZ"))
			{
				strBuf.Add("  HEM_B_STAFF_ESSAY.ZHRYXYZ = :U_ZHRYXYZ");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRYXYZ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.ZHRYXYZ) ? string.Empty : obj.ZHRYXYZ;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRCBKH"))
			{
				strBuf.Add("  HEM_B_STAFF_ESSAY.ZHRCBKH = :U_ZHRCBKH");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRCBKH";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.ZHRCBKH) ? string.Empty : obj.ZHRCBKH;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STAFF_ID"))
			{
				strBuf.Add("  HEM_B_STAFF_ESSAY.STAFF_ID = :U_STAFF_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_STAFF_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.STAFF_ID) ? string.Empty : obj.STAFF_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRBRMP"))
			{
				strBuf.Add("  HEM_B_STAFF_ESSAY.ZHRBRMP = :U_ZHRBRMP");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRBRMP";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = string.IsNullOrEmpty(obj.ZHRBRMP) ? string.Empty : obj.ZHRBRMP;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRFBZT"))
			{
				strBuf.Add("  HEM_B_STAFF_ESSAY.ZHRFBZT = :U_ZHRFBZT");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRFBZT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = string.IsNullOrEmpty(obj.ZHRFBZT) ? string.Empty : obj.ZHRFBZT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRCBKW"))
			{
				strBuf.Add("  HEM_B_STAFF_ESSAY.ZHRCBKW = :U_ZHRCBKW");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRCBKW";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.ZHRCBKW) ? string.Empty : obj.ZHRCBKW;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRWZMC"))
			{
				strBuf.Add("  HEM_B_STAFF_ESSAY.ZHRWZMC = :U_ZHRWZMC");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRWZMC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.ZHRWZMC) ? string.Empty : obj.ZHRWZMC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BEGDA"))
			{
				strBuf.Add("  HEM_B_STAFF_ESSAY.BEGDA = :U_BEGDA");
				param = new OracleParameter();
				param.ParameterName = ":U_BEGDA";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.BEGDA;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRKWJB"))
			{
				strBuf.Add("  HEM_B_STAFF_ESSAY.ZHRKWJB = :U_ZHRKWJB");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRKWJB";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = string.IsNullOrEmpty(obj.ZHRKWJB) ? string.Empty : obj.ZHRKWJB;
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
