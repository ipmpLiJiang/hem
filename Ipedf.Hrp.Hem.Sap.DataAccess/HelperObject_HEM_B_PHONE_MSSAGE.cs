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
	[CauseObject(typeof(CauseObject_HEM_B_PHONE_MSSAGE))]
	public partial class HelperObject_HEM_B_PHONE_MSSAGE
	{		
		#region Method Blok
		public static int Save(EntityObject_HEM_B_PHONE_MSSAGE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into HEM_B_PHONE_MSSAGE( OVERDUE_TIME, CONTENT, ID, STATUS, SEND_ERROR, SEND_PHONE, SEND_TIME, IS_SEND, APPLY_ID, REPLY_STATUS, MAC, SEND_ID, APPLY_STATUS, ACCEPT_TIME) values ( :OVERDUE_TIME, :CONTENT, :ID, :STATUS, :SEND_ERROR, :SEND_PHONE, :SEND_TIME, :IS_SEND, :APPLY_ID, :REPLY_STATUS, :MAC, :SEND_ID, :APPLY_STATUS, :ACCEPT_TIME)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[14];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":OVERDUE_TIME";
			parameters[0].Size = 7;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[0].Value = obj.OVERDUE_TIME;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":CONTENT";
			parameters[1].Size = 900;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.CONTENT == null ? String.Empty:obj.CONTENT;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ID";
			parameters[2].Size = 36;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[2].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":STATUS";
			parameters[3].Size = 22;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[3].Value = obj.STATUS;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":SEND_ERROR";
			parameters[4].Size = 300;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[4].Value = obj.SEND_ERROR == null ? String.Empty:obj.SEND_ERROR;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":SEND_PHONE";
			parameters[5].Size = 11;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.SEND_PHONE == null ? String.Empty:obj.SEND_PHONE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":SEND_TIME";
			parameters[6].Size = 7;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[6].Value = obj.SEND_TIME;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":IS_SEND";
			parameters[7].Size = 22;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[7].Value = obj.IS_SEND;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":APPLY_ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.APPLY_ID == null ? String.Empty:obj.APPLY_ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":REPLY_STATUS";
			parameters[9].Size = 50;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.REPLY_STATUS == null ? String.Empty:obj.REPLY_STATUS;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":MAC";
			parameters[10].Size = 50;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.MAC == null ? String.Empty:obj.MAC;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":SEND_ID";
			parameters[11].Size = 36;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[11].Value = obj.SEND_ID == null ? String.Empty:obj.SEND_ID;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":APPLY_STATUS";
			parameters[12].Size = 22;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[12].Value = obj.APPLY_STATUS;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":ACCEPT_TIME";
			parameters[13].Size = 7;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[13].Value = obj.ACCEPT_TIME;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_PHONE_MSSAGE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_PHONE_MSSAGE set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_PHONE_MSSAGE obj,CauseObject_HEM_B_PHONE_MSSAGE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_PHONE_MSSAGE set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_HEM_B_PHONE_MSSAGE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from HEM_B_PHONE_MSSAGE where  ID = :ID ";
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
		public static int Delete(CauseObject_HEM_B_PHONE_MSSAGE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from HEM_B_PHONE_MSSAGE where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_HEM_B_PHONE_MSSAGE Get(EntityObject_HEM_B_PHONE_MSSAGE obj)
		{
			
			//平台自动生成代码
			string sSql = "select  OVERDUE_TIME, CONTENT, ID, STATUS, SEND_ERROR, SEND_PHONE, SEND_TIME, IS_SEND, APPLY_ID, REPLY_STATUS, MAC, SEND_ID, APPLY_STATUS, ACCEPT_TIME from HEM_B_PHONE_MSSAGE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_PHONE_MSSAGE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_PHONE_MSSAGE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.OVERDUE_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CONTENT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATUS = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SEND_ERROR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.SEND_PHONE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SEND_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_SEND = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REPLY_STATUS = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MAC = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEND_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.APPLY_STATUS = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ACCEPT_TIME = sqlReader.GetDateTime(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_HEM_B_PHONE_MSSAGE[] objs = new EntityObject_HEM_B_PHONE_MSSAGE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_HEM_B_PHONE_MSSAGE Get(EntityObject_HEM_B_PHONE_MSSAGE obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  OVERDUE_TIME, CONTENT, ID, STATUS, SEND_ERROR, SEND_PHONE, SEND_TIME, IS_SEND, APPLY_ID, REPLY_STATUS, MAC, SEND_ID, APPLY_STATUS, ACCEPT_TIME from HEM_B_PHONE_MSSAGE where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_PHONE_MSSAGE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_PHONE_MSSAGE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.OVERDUE_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CONTENT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATUS = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SEND_ERROR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.SEND_PHONE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SEND_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_SEND = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REPLY_STATUS = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MAC = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEND_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.APPLY_STATUS = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ACCEPT_TIME = sqlReader.GetDateTime(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_HEM_B_PHONE_MSSAGE[] objs = new EntityObject_HEM_B_PHONE_MSSAGE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_HEM_B_PHONE_MSSAGE[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  HEM_B_PHONE_MSSAGE.OVERDUE_TIME, HEM_B_PHONE_MSSAGE.CONTENT, HEM_B_PHONE_MSSAGE.ID, HEM_B_PHONE_MSSAGE.STATUS, HEM_B_PHONE_MSSAGE.SEND_ERROR, HEM_B_PHONE_MSSAGE.SEND_PHONE, HEM_B_PHONE_MSSAGE.SEND_TIME, HEM_B_PHONE_MSSAGE.IS_SEND, HEM_B_PHONE_MSSAGE.APPLY_ID, HEM_B_PHONE_MSSAGE.REPLY_STATUS, HEM_B_PHONE_MSSAGE.MAC, HEM_B_PHONE_MSSAGE.SEND_ID, HEM_B_PHONE_MSSAGE.APPLY_STATUS, HEM_B_PHONE_MSSAGE.ACCEPT_TIME from HEM_B_PHONE_MSSAGE where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_HEM_B_PHONE_MSSAGE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_PHONE_MSSAGE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.OVERDUE_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CONTENT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATUS = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SEND_ERROR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.SEND_PHONE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SEND_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_SEND = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REPLY_STATUS = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MAC = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEND_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.APPLY_STATUS = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ACCEPT_TIME = sqlReader.GetDateTime(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_PHONE_MSSAGE[] objs = new DisplayObject_HEM_B_PHONE_MSSAGE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_HEM_B_PHONE_MSSAGE cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.OVERDUE_TIME!= null)
			{
				if (cause.OVERDUE_TIME.Begin != null)
				{
					strBuf.Append(" And HEM_B_PHONE_MSSAGE.OVERDUE_TIME >= :C_OVERDUE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_OVERDUE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.OVERDUE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.OVERDUE_TIME.End != null)
				{
					strBuf.Append(" And HEM_B_PHONE_MSSAGE.OVERDUE_TIME < :C_OVERDUE_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_OVERDUE_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.OVERDUE_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("OVERDUE_TIME"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_MSSAGE", "OVERDUE_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.CONTENT))
			{
				strBuf.Append(" And HEM_B_PHONE_MSSAGE.CONTENT ").Append((cause.CONTENT.StartsWith("%") || cause.CONTENT.EndsWith("%")) ? " like " : " = ").Append(" :C_CONTENT");
				param = new OracleParameter();
				param.ParameterName =":C_CONTENT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 900;
				param.Value = cause.CONTENT;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTENT"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_MSSAGE", "CONTENT"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And HEM_B_PHONE_MSSAGE.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_MSSAGE", "ID"));
			}
			if(cause.STATUS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_PHONE_MSSAGE.STATUS = :C_STATUS");
				param = new OracleParameter();
				param.ParameterName =":C_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATUS"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_MSSAGE", "STATUS"));
			}
			if(!string.IsNullOrEmpty(cause.SEND_ERROR))
			{
				strBuf.Append(" And HEM_B_PHONE_MSSAGE.SEND_ERROR ").Append((cause.SEND_ERROR.StartsWith("%") || cause.SEND_ERROR.EndsWith("%")) ? " like " : " = ").Append(" :C_SEND_ERROR");
				param = new OracleParameter();
				param.ParameterName =":C_SEND_ERROR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.SEND_ERROR;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEND_ERROR"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_MSSAGE", "SEND_ERROR"));
			}
			if(!string.IsNullOrEmpty(cause.SEND_PHONE))
			{
				strBuf.Append(" And HEM_B_PHONE_MSSAGE.SEND_PHONE ").Append((cause.SEND_PHONE.StartsWith("%") || cause.SEND_PHONE.EndsWith("%")) ? " like " : " = ").Append(" :C_SEND_PHONE");
				param = new OracleParameter();
				param.ParameterName =":C_SEND_PHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = cause.SEND_PHONE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEND_PHONE"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_MSSAGE", "SEND_PHONE"));
			}
			if(cause.SEND_TIME!= null)
			{
				if (cause.SEND_TIME.Begin != null)
				{
					strBuf.Append(" And HEM_B_PHONE_MSSAGE.SEND_TIME >= :C_SEND_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_SEND_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.SEND_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.SEND_TIME.End != null)
				{
					strBuf.Append(" And HEM_B_PHONE_MSSAGE.SEND_TIME < :C_SEND_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_SEND_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.SEND_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("SEND_TIME"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_MSSAGE", "SEND_TIME"));
			}
			if(cause.IS_SEND!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_PHONE_MSSAGE.IS_SEND = :C_IS_SEND");
				param = new OracleParameter();
				param.ParameterName =":C_IS_SEND";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_SEND;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_SEND"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_MSSAGE", "IS_SEND"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_ID))
			{
				strBuf.Append(" And HEM_B_PHONE_MSSAGE.APPLY_ID ").Append((cause.APPLY_ID.StartsWith("%") || cause.APPLY_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_ID");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.APPLY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_MSSAGE", "APPLY_ID"));
			}
			if(!string.IsNullOrEmpty(cause.REPLY_STATUS))
			{
				strBuf.Append(" And HEM_B_PHONE_MSSAGE.REPLY_STATUS ").Append((cause.REPLY_STATUS.StartsWith("%") || cause.REPLY_STATUS.EndsWith("%")) ? " like " : " = ").Append(" :C_REPLY_STATUS");
				param = new OracleParameter();
				param.ParameterName =":C_REPLY_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.REPLY_STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("REPLY_STATUS"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_MSSAGE", "REPLY_STATUS"));
			}
			if(!string.IsNullOrEmpty(cause.MAC))
			{
				strBuf.Append(" And HEM_B_PHONE_MSSAGE.MAC ").Append((cause.MAC.StartsWith("%") || cause.MAC.EndsWith("%")) ? " like " : " = ").Append(" :C_MAC");
				param = new OracleParameter();
				param.ParameterName =":C_MAC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MAC;
				paramList.Add(param);
			}
			if (cause.HasINValue("MAC"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_MSSAGE", "MAC"));
			}
			if(!string.IsNullOrEmpty(cause.SEND_ID))
			{
				strBuf.Append(" And HEM_B_PHONE_MSSAGE.SEND_ID ").Append((cause.SEND_ID.StartsWith("%") || cause.SEND_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_SEND_ID");
				param = new OracleParameter();
				param.ParameterName =":C_SEND_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.SEND_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEND_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_MSSAGE", "SEND_ID"));
			}
			if(cause.APPLY_STATUS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_PHONE_MSSAGE.APPLY_STATUS = :C_APPLY_STATUS");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.APPLY_STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_STATUS"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_MSSAGE", "APPLY_STATUS"));
			}
			if(cause.ACCEPT_TIME!= null)
			{
				if (cause.ACCEPT_TIME.Begin != null)
				{
					strBuf.Append(" And HEM_B_PHONE_MSSAGE.ACCEPT_TIME >= :C_ACCEPT_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_ACCEPT_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.ACCEPT_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.ACCEPT_TIME.End != null)
				{
					strBuf.Append(" And HEM_B_PHONE_MSSAGE.ACCEPT_TIME < :C_ACCEPT_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_ACCEPT_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.ACCEPT_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("ACCEPT_TIME"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_PHONE_MSSAGE", "ACCEPT_TIME"));
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
		public static DisplayObject_HEM_B_PHONE_MSSAGE[] Query(CauseObject_HEM_B_PHONE_MSSAGE cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_PHONE_MSSAGE.OVERDUE_TIME, HEM_B_PHONE_MSSAGE.CONTENT, HEM_B_PHONE_MSSAGE.ID, HEM_B_PHONE_MSSAGE.STATUS, HEM_B_PHONE_MSSAGE.SEND_ERROR, HEM_B_PHONE_MSSAGE.SEND_PHONE, HEM_B_PHONE_MSSAGE.SEND_TIME, HEM_B_PHONE_MSSAGE.IS_SEND, HEM_B_PHONE_MSSAGE.APPLY_ID, HEM_B_PHONE_MSSAGE.REPLY_STATUS, HEM_B_PHONE_MSSAGE.MAC, HEM_B_PHONE_MSSAGE.SEND_ID, HEM_B_PHONE_MSSAGE.APPLY_STATUS, HEM_B_PHONE_MSSAGE.ACCEPT_TIME from HEM_B_PHONE_MSSAGE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_PHONE_MSSAGE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_PHONE_MSSAGE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.OVERDUE_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CONTENT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATUS = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SEND_ERROR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.SEND_PHONE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SEND_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_SEND = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REPLY_STATUS = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MAC = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEND_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.APPLY_STATUS = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ACCEPT_TIME = sqlReader.GetDateTime(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_PHONE_MSSAGE[] objs = new DisplayObject_HEM_B_PHONE_MSSAGE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_HEM_B_PHONE_MSSAGE[] Query(CauseObject_HEM_B_PHONE_MSSAGE cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_PHONE_MSSAGE.OVERDUE_TIME, HEM_B_PHONE_MSSAGE.CONTENT, HEM_B_PHONE_MSSAGE.ID, HEM_B_PHONE_MSSAGE.STATUS, HEM_B_PHONE_MSSAGE.SEND_ERROR, HEM_B_PHONE_MSSAGE.SEND_PHONE, HEM_B_PHONE_MSSAGE.SEND_TIME, HEM_B_PHONE_MSSAGE.IS_SEND, HEM_B_PHONE_MSSAGE.APPLY_ID, HEM_B_PHONE_MSSAGE.REPLY_STATUS, HEM_B_PHONE_MSSAGE.MAC, HEM_B_PHONE_MSSAGE.SEND_ID, HEM_B_PHONE_MSSAGE.APPLY_STATUS, HEM_B_PHONE_MSSAGE.ACCEPT_TIME from HEM_B_PHONE_MSSAGE where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_PHONE_MSSAGE dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_PHONE_MSSAGE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.OVERDUE_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CONTENT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATUS = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SEND_ERROR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.SEND_PHONE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SEND_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_SEND = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REPLY_STATUS = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MAC = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEND_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.APPLY_STATUS = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ACCEPT_TIME = sqlReader.GetDateTime(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_PHONE_MSSAGE[] objs = new DisplayObject_HEM_B_PHONE_MSSAGE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_PHONE_MSSAGE[] Query(CauseObject_HEM_B_PHONE_MSSAGE cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_PHONE_MSSAGE.OVERDUE_TIME, HEM_B_PHONE_MSSAGE.CONTENT, HEM_B_PHONE_MSSAGE.ID, HEM_B_PHONE_MSSAGE.STATUS, HEM_B_PHONE_MSSAGE.SEND_ERROR, HEM_B_PHONE_MSSAGE.SEND_PHONE, HEM_B_PHONE_MSSAGE.SEND_TIME, HEM_B_PHONE_MSSAGE.IS_SEND, HEM_B_PHONE_MSSAGE.APPLY_ID, HEM_B_PHONE_MSSAGE.REPLY_STATUS, HEM_B_PHONE_MSSAGE.MAC, HEM_B_PHONE_MSSAGE.SEND_ID, HEM_B_PHONE_MSSAGE.APPLY_STATUS, HEM_B_PHONE_MSSAGE.ACCEPT_TIME from HEM_B_PHONE_MSSAGE where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_PHONE_MSSAGE",paging, order, sSql, parameters, connection);
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
			DisplayObject_HEM_B_PHONE_MSSAGE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_PHONE_MSSAGE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.OVERDUE_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CONTENT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATUS = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SEND_ERROR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.SEND_PHONE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SEND_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_SEND = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REPLY_STATUS = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MAC = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEND_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.APPLY_STATUS = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ACCEPT_TIME = sqlReader.GetDateTime(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_PHONE_MSSAGE[] objs = new DisplayObject_HEM_B_PHONE_MSSAGE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_PHONE_MSSAGE[] Query(CauseObject_HEM_B_PHONE_MSSAGE cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_PHONE_MSSAGE.OVERDUE_TIME, HEM_B_PHONE_MSSAGE.CONTENT, HEM_B_PHONE_MSSAGE.ID, HEM_B_PHONE_MSSAGE.STATUS, HEM_B_PHONE_MSSAGE.SEND_ERROR, HEM_B_PHONE_MSSAGE.SEND_PHONE, HEM_B_PHONE_MSSAGE.SEND_TIME, HEM_B_PHONE_MSSAGE.IS_SEND, HEM_B_PHONE_MSSAGE.APPLY_ID, HEM_B_PHONE_MSSAGE.REPLY_STATUS, HEM_B_PHONE_MSSAGE.MAC, HEM_B_PHONE_MSSAGE.SEND_ID, HEM_B_PHONE_MSSAGE.APPLY_STATUS, HEM_B_PHONE_MSSAGE.ACCEPT_TIME from HEM_B_PHONE_MSSAGE where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_PHONE_MSSAGE",paging, order, sSql, parameters, trans);
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
			DisplayObject_HEM_B_PHONE_MSSAGE dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_PHONE_MSSAGE();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.OVERDUE_TIME = sqlReader.GetDateTime(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.CONTENT = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATUS = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.SEND_ERROR = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.SEND_PHONE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.SEND_TIME = sqlReader.GetDateTime(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.IS_SEND = sqlReader.GetDecimal(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.APPLY_ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.REPLY_STATUS = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.MAC = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.SEND_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.APPLY_STATUS = sqlReader.GetDecimal(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.ACCEPT_TIME = sqlReader.GetDateTime(13);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_PHONE_MSSAGE[] objs = new DisplayObject_HEM_B_PHONE_MSSAGE[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_HEM_B_PHONE_MSSAGE obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("OVERDUE_TIME"))
			{
				strBuf.Add("  HEM_B_PHONE_MSSAGE.OVERDUE_TIME = :U_OVERDUE_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_OVERDUE_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.OVERDUE_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CONTENT"))
			{
				strBuf.Add("  HEM_B_PHONE_MSSAGE.CONTENT = :U_CONTENT");
				param = new OracleParameter();
				param.ParameterName = ":U_CONTENT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 900;
				param.Value = string.IsNullOrEmpty(obj.CONTENT) ? string.Empty : obj.CONTENT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATUS"))
			{
				strBuf.Add("  HEM_B_PHONE_MSSAGE.STATUS = :U_STATUS");
				param = new OracleParameter();
				param.ParameterName = ":U_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATUS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SEND_ERROR"))
			{
				strBuf.Add("  HEM_B_PHONE_MSSAGE.SEND_ERROR = :U_SEND_ERROR");
				param = new OracleParameter();
				param.ParameterName = ":U_SEND_ERROR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.SEND_ERROR) ? string.Empty : obj.SEND_ERROR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SEND_PHONE"))
			{
				strBuf.Add("  HEM_B_PHONE_MSSAGE.SEND_PHONE = :U_SEND_PHONE");
				param = new OracleParameter();
				param.ParameterName = ":U_SEND_PHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = string.IsNullOrEmpty(obj.SEND_PHONE) ? string.Empty : obj.SEND_PHONE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SEND_TIME"))
			{
				strBuf.Add("  HEM_B_PHONE_MSSAGE.SEND_TIME = :U_SEND_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_SEND_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.SEND_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_SEND"))
			{
				strBuf.Add("  HEM_B_PHONE_MSSAGE.IS_SEND = :U_IS_SEND");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_SEND";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_SEND;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_ID"))
			{
				strBuf.Add("  HEM_B_PHONE_MSSAGE.APPLY_ID = :U_APPLY_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.APPLY_ID) ? string.Empty : obj.APPLY_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REPLY_STATUS"))
			{
				strBuf.Add("  HEM_B_PHONE_MSSAGE.REPLY_STATUS = :U_REPLY_STATUS");
				param = new OracleParameter();
				param.ParameterName = ":U_REPLY_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.REPLY_STATUS) ? string.Empty : obj.REPLY_STATUS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MAC"))
			{
				strBuf.Add("  HEM_B_PHONE_MSSAGE.MAC = :U_MAC");
				param = new OracleParameter();
				param.ParameterName = ":U_MAC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.MAC) ? string.Empty : obj.MAC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SEND_ID"))
			{
				strBuf.Add("  HEM_B_PHONE_MSSAGE.SEND_ID = :U_SEND_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_SEND_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.SEND_ID) ? string.Empty : obj.SEND_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_STATUS"))
			{
				strBuf.Add("  HEM_B_PHONE_MSSAGE.APPLY_STATUS = :U_APPLY_STATUS");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.APPLY_STATUS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ACCEPT_TIME"))
			{
				strBuf.Add("  HEM_B_PHONE_MSSAGE.ACCEPT_TIME = :U_ACCEPT_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_ACCEPT_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.ACCEPT_TIME;
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
