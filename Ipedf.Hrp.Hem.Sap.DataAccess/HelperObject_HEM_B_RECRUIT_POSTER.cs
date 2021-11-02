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
	[CauseObject(typeof(CauseObject_HEM_B_RECRUIT_POSTER))]
	public partial class HelperObject_HEM_B_RECRUIT_POSTER
	{		
		#region Method Blok
		public static int Save(EntityObject_HEM_B_RECRUIT_POSTER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
            string sSql = "insert into HEM_B_RECRUIT_POSTER( CONTENT, ID, PUBLISH_DATE, STATUS, CREATE_DATE, USER_ID, TITLE, PUBLISHER, END_DATE, IS_PUBLIC, DATA_SOURCE, RECRUIT_POSITION, REMARK, IS_NURSE, IS_SEND) values ( :CONTENT, :ID, :PUBLISH_DATE, :STATUS, :CREATE_DATE, :USER_ID, :TITLE, :PUBLISHER, :END_DATE, :IS_PUBLIC, :DATA_SOURCE, :RECRUIT_POSITION, :REMARK, :IS_NURSE, :IS_SEND)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[15];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":CONTENT";
			parameters[0].Size = 4000;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Clob;
			parameters[0].Value = obj.CONTENT == null ? String.Empty:obj.CONTENT;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":PUBLISH_DATE";
			parameters[2].Size = 7;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[2].Value = obj.PUBLISH_DATE;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":STATUS";
			parameters[3].Size = 22;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[3].Value = obj.STATUS;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":CREATE_DATE";
			parameters[4].Size = 7;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[4].Value = obj.CREATE_DATE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":USER_ID";
			parameters[5].Size = 36;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[5].Value = obj.USER_ID == null ? String.Empty:obj.USER_ID;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":TITLE";
			parameters[6].Size = 180;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.TITLE == null ? String.Empty:obj.TITLE;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":PUBLISHER";
			parameters[7].Size = 120;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.PUBLISHER == null ? String.Empty:obj.PUBLISHER;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":END_DATE";
			parameters[8].Size = 7;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[8].Value = obj.END_DATE;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":IS_PUBLIC";
			parameters[9].Size = 22;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[9].Value = obj.IS_PUBLIC;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":DATA_SOURCE";
			parameters[10].Size = 120;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.DATA_SOURCE == null ? String.Empty:obj.DATA_SOURCE;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":RECRUIT_POSITION";
			parameters[11].Size = 180;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.RECRUIT_POSITION == null ? String.Empty:obj.RECRUIT_POSITION;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":REMARK";
			parameters[12].Size = 300;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.REMARK == null ? String.Empty:obj.REMARK;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":IS_NURSE";
			parameters[13].Size = 22;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[13].Value = obj.IS_NURSE;
            parameters[14] = new OracleParameter();
            parameters[14].ParameterName = ":IS_SEND";
            parameters[14].Size = 22;
            parameters[14].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[14].Value = obj.IS_SEND;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_RECRUIT_POSTER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_RECRUIT_POSTER set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_RECRUIT_POSTER obj,CauseObject_HEM_B_RECRUIT_POSTER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_RECRUIT_POSTER set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_HEM_B_RECRUIT_POSTER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from HEM_B_RECRUIT_POSTER where  ID = :ID ";
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
		public static int Delete(CauseObject_HEM_B_RECRUIT_POSTER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from HEM_B_RECRUIT_POSTER where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_HEM_B_RECRUIT_POSTER Get(EntityObject_HEM_B_RECRUIT_POSTER obj)
		{
			
			//平台自动生成代码
			string sSql = "select  CONTENT, ID, PUBLISH_DATE, STATUS, CREATE_DATE, USER_ID, TITLE, PUBLISHER, END_DATE, IS_PUBLIC, DATA_SOURCE, MODIFY_USER_ID, RECRUIT_POSITION, REMARK, IS_NURSE,IS_SEND from HEM_B_RECRUIT_POSTER where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_RECRUIT_POSTER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_RECRUIT_POSTER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTENT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATUS = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.TITLE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PUBLISHER = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.END_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_SOURCE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.REMARK = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(14);
                if (!sqlReader.IsDBNull(15))
                    dataObj.IS_SEND = sqlReader.GetDecimal(15);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_HEM_B_RECRUIT_POSTER[] objs = new EntityObject_HEM_B_RECRUIT_POSTER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_HEM_B_RECRUIT_POSTER Get(EntityObject_HEM_B_RECRUIT_POSTER obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  CONTENT, ID, PUBLISH_DATE, STATUS, CREATE_DATE, USER_ID, TITLE, PUBLISHER, END_DATE, IS_PUBLIC, DATA_SOURCE, MODIFY_USER_ID, RECRUIT_POSITION, REMARK, IS_NURSE from HEM_B_RECRUIT_POSTER where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_RECRUIT_POSTER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_RECRUIT_POSTER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTENT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATUS = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.TITLE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PUBLISHER = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.END_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_SOURCE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.REMARK = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_HEM_B_RECRUIT_POSTER[] objs = new EntityObject_HEM_B_RECRUIT_POSTER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_HEM_B_RECRUIT_POSTER[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  HEM_B_RECRUIT_POSTER.CONTENT, HEM_B_RECRUIT_POSTER.ID, HEM_B_RECRUIT_POSTER.PUBLISH_DATE, HEM_B_RECRUIT_POSTER.STATUS, HEM_B_RECRUIT_POSTER.CREATE_DATE, HEM_B_RECRUIT_POSTER.USER_ID, HEM_B_RECRUIT_POSTER.TITLE, HEM_B_RECRUIT_POSTER.PUBLISHER, HEM_B_RECRUIT_POSTER.END_DATE, HEM_B_RECRUIT_POSTER.IS_PUBLIC, HEM_B_RECRUIT_POSTER.DATA_SOURCE, HEM_B_RECRUIT_POSTER.MODIFY_USER_ID, HEM_B_RECRUIT_POSTER.RECRUIT_POSITION, HEM_B_RECRUIT_POSTER.REMARK, HEM_B_RECRUIT_POSTER.IS_NURSE from HEM_B_RECRUIT_POSTER where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_HEM_B_RECRUIT_POSTER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_RECRUIT_POSTER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTENT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATUS = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.TITLE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PUBLISHER = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.END_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_SOURCE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.REMARK = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_RECRUIT_POSTER[] objs = new DisplayObject_HEM_B_RECRUIT_POSTER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_HEM_B_RECRUIT_POSTER cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.CONTENT))
			{
				strBuf.Append(" And dbms_lob.compare(HEM_B_RECRUIT_POSTER.CONTENT,:C_CONTENT) = 0 ");
				param = new OracleParameter();
				param.ParameterName =":C_CONTENT";
				param.OracleType = System.Data.OracleClient.OracleType.Clob;
				param.Size = 4000;
				param.Value = cause.CONTENT;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTENT"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_RECRUIT_POSTER", "CONTENT"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And HEM_B_RECRUIT_POSTER.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_RECRUIT_POSTER", "ID"));
			}
			if(cause.PUBLISH_DATE!= null)
			{
				if (cause.PUBLISH_DATE.Begin != null)
				{
					strBuf.Append(" And HEM_B_RECRUIT_POSTER.PUBLISH_DATE >= :C_PUBLISH_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_PUBLISH_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.PUBLISH_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.PUBLISH_DATE.End != null)
				{
					strBuf.Append(" And HEM_B_RECRUIT_POSTER.PUBLISH_DATE < :C_PUBLISH_DATE_END");
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
				strBuf.Append(cause.GetINSQL("HEM_B_RECRUIT_POSTER", "PUBLISH_DATE"));
			}
			if(cause.STATUS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_RECRUIT_POSTER.STATUS = :C_STATUS");
				param = new OracleParameter();
				param.ParameterName =":C_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATUS"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_RECRUIT_POSTER", "STATUS"));
			}
			if(cause.CREATE_DATE!= null)
			{
				if (cause.CREATE_DATE.Begin != null)
				{
					strBuf.Append(" And HEM_B_RECRUIT_POSTER.CREATE_DATE >= :C_CREATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_DATE.End != null)
				{
					strBuf.Append(" And HEM_B_RECRUIT_POSTER.CREATE_DATE < :C_CREATE_DATE_END");
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
				strBuf.Append(cause.GetINSQL("HEM_B_RECRUIT_POSTER", "CREATE_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.USER_ID))
			{
				strBuf.Append(" And HEM_B_RECRUIT_POSTER.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_RECRUIT_POSTER", "USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.TITLE))
			{
				strBuf.Append(" And HEM_B_RECRUIT_POSTER.TITLE ").Append((cause.TITLE.StartsWith("%") || cause.TITLE.EndsWith("%")) ? " like " : " = ").Append(" :C_TITLE");
				param = new OracleParameter();
				param.ParameterName =":C_TITLE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 180;
				param.Value = cause.TITLE;
				paramList.Add(param);
			}
			if (cause.HasINValue("TITLE"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_RECRUIT_POSTER", "TITLE"));
			}
			if(!string.IsNullOrEmpty(cause.PUBLISHER))
			{
				strBuf.Append(" And HEM_B_RECRUIT_POSTER.PUBLISHER ").Append((cause.PUBLISHER.StartsWith("%") || cause.PUBLISHER.EndsWith("%")) ? " like " : " = ").Append(" :C_PUBLISHER");
				param = new OracleParameter();
				param.ParameterName =":C_PUBLISHER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.PUBLISHER;
				paramList.Add(param);
			}
			if (cause.HasINValue("PUBLISHER"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_RECRUIT_POSTER", "PUBLISHER"));
			}
			if(cause.END_DATE!= null)
			{
				if (cause.END_DATE.Begin != null)
				{
					strBuf.Append(" And HEM_B_RECRUIT_POSTER.END_DATE >= :C_END_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_END_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.END_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.END_DATE.End != null)
				{
					strBuf.Append(" And HEM_B_RECRUIT_POSTER.END_DATE < :C_END_DATE_END");
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
				strBuf.Append(cause.GetINSQL("HEM_B_RECRUIT_POSTER", "END_DATE"));
			}
			if(cause.IS_PUBLIC!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_RECRUIT_POSTER.IS_PUBLIC = :C_IS_PUBLIC");
				param = new OracleParameter();
				param.ParameterName =":C_IS_PUBLIC";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_PUBLIC;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_PUBLIC"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_RECRUIT_POSTER", "IS_PUBLIC"));
			}
			if(!string.IsNullOrEmpty(cause.DATA_SOURCE))
			{
				strBuf.Append(" And HEM_B_RECRUIT_POSTER.DATA_SOURCE ").Append((cause.DATA_SOURCE.StartsWith("%") || cause.DATA_SOURCE.EndsWith("%")) ? " like " : " = ").Append(" :C_DATA_SOURCE");
				param = new OracleParameter();
				param.ParameterName =":C_DATA_SOURCE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.DATA_SOURCE;
				paramList.Add(param);
			}
			if (cause.HasINValue("DATA_SOURCE"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_RECRUIT_POSTER", "DATA_SOURCE"));
			}
			if(!string.IsNullOrEmpty(cause.MODIFY_USER_ID))
			{
				strBuf.Append(" And HEM_B_RECRUIT_POSTER.MODIFY_USER_ID ").Append((cause.MODIFY_USER_ID.StartsWith("%") || cause.MODIFY_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MODIFY_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_RECRUIT_POSTER", "MODIFY_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.RECRUIT_POSITION))
			{
				strBuf.Append(" And HEM_B_RECRUIT_POSTER.RECRUIT_POSITION ").Append((cause.RECRUIT_POSITION.StartsWith("%") || cause.RECRUIT_POSITION.EndsWith("%")) ? " like " : " = ").Append(" :C_RECRUIT_POSITION");
				param = new OracleParameter();
				param.ParameterName =":C_RECRUIT_POSITION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 180;
				param.Value = cause.RECRUIT_POSITION;
				paramList.Add(param);
			}
			if (cause.HasINValue("RECRUIT_POSITION"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_RECRUIT_POSTER", "RECRUIT_POSITION"));
			}
			if(!string.IsNullOrEmpty(cause.REMARK))
			{
				strBuf.Append(" And HEM_B_RECRUIT_POSTER.REMARK ").Append((cause.REMARK.StartsWith("%") || cause.REMARK.EndsWith("%")) ? " like " : " = ").Append(" :C_REMARK");
				param = new OracleParameter();
				param.ParameterName =":C_REMARK";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.REMARK;
				paramList.Add(param);
			}
			if (cause.HasINValue("REMARK"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_RECRUIT_POSTER", "REMARK"));
			}
			if(cause.IS_NURSE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_RECRUIT_POSTER.IS_NURSE = :C_IS_NURSE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_NURSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_NURSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_NURSE"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_RECRUIT_POSTER", "IS_NURSE"));
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
		public static DisplayObject_HEM_B_RECRUIT_POSTER[] Query(CauseObject_HEM_B_RECRUIT_POSTER cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_RECRUIT_POSTER.CONTENT, HEM_B_RECRUIT_POSTER.ID, HEM_B_RECRUIT_POSTER.PUBLISH_DATE, HEM_B_RECRUIT_POSTER.STATUS, HEM_B_RECRUIT_POSTER.CREATE_DATE, HEM_B_RECRUIT_POSTER.USER_ID, HEM_B_RECRUIT_POSTER.TITLE, HEM_B_RECRUIT_POSTER.PUBLISHER, HEM_B_RECRUIT_POSTER.END_DATE, HEM_B_RECRUIT_POSTER.IS_PUBLIC, HEM_B_RECRUIT_POSTER.DATA_SOURCE, HEM_B_RECRUIT_POSTER.MODIFY_USER_ID, HEM_B_RECRUIT_POSTER.RECRUIT_POSITION, HEM_B_RECRUIT_POSTER.REMARK, HEM_B_RECRUIT_POSTER.IS_NURSE from HEM_B_RECRUIT_POSTER where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_RECRUIT_POSTER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_RECRUIT_POSTER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTENT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATUS = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.TITLE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PUBLISHER = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.END_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_SOURCE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.REMARK = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_RECRUIT_POSTER[] objs = new DisplayObject_HEM_B_RECRUIT_POSTER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_HEM_B_RECRUIT_POSTER[] Query(CauseObject_HEM_B_RECRUIT_POSTER cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_RECRUIT_POSTER.CONTENT, HEM_B_RECRUIT_POSTER.ID, HEM_B_RECRUIT_POSTER.PUBLISH_DATE, HEM_B_RECRUIT_POSTER.STATUS, HEM_B_RECRUIT_POSTER.CREATE_DATE, HEM_B_RECRUIT_POSTER.USER_ID, HEM_B_RECRUIT_POSTER.TITLE, HEM_B_RECRUIT_POSTER.PUBLISHER, HEM_B_RECRUIT_POSTER.END_DATE, HEM_B_RECRUIT_POSTER.IS_PUBLIC, HEM_B_RECRUIT_POSTER.DATA_SOURCE, HEM_B_RECRUIT_POSTER.MODIFY_USER_ID, HEM_B_RECRUIT_POSTER.RECRUIT_POSITION, HEM_B_RECRUIT_POSTER.REMARK, HEM_B_RECRUIT_POSTER.IS_NURSE from HEM_B_RECRUIT_POSTER where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_RECRUIT_POSTER dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_RECRUIT_POSTER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTENT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATUS = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.TITLE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PUBLISHER = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.END_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_SOURCE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.REMARK = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_RECRUIT_POSTER[] objs = new DisplayObject_HEM_B_RECRUIT_POSTER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_RECRUIT_POSTER[] Query(CauseObject_HEM_B_RECRUIT_POSTER cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_RECRUIT_POSTER.CONTENT, HEM_B_RECRUIT_POSTER.ID, HEM_B_RECRUIT_POSTER.PUBLISH_DATE, HEM_B_RECRUIT_POSTER.STATUS, HEM_B_RECRUIT_POSTER.CREATE_DATE, HEM_B_RECRUIT_POSTER.USER_ID, HEM_B_RECRUIT_POSTER.TITLE, HEM_B_RECRUIT_POSTER.PUBLISHER, HEM_B_RECRUIT_POSTER.END_DATE, HEM_B_RECRUIT_POSTER.IS_PUBLIC, HEM_B_RECRUIT_POSTER.DATA_SOURCE, HEM_B_RECRUIT_POSTER.MODIFY_USER_ID, HEM_B_RECRUIT_POSTER.RECRUIT_POSITION, HEM_B_RECRUIT_POSTER.REMARK, HEM_B_RECRUIT_POSTER.IS_NURSE from HEM_B_RECRUIT_POSTER where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_RECRUIT_POSTER",paging, order, sSql, parameters, connection);
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
			DisplayObject_HEM_B_RECRUIT_POSTER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_RECRUIT_POSTER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTENT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATUS = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.TITLE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PUBLISHER = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.END_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_SOURCE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.REMARK = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_RECRUIT_POSTER[] objs = new DisplayObject_HEM_B_RECRUIT_POSTER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_RECRUIT_POSTER[] Query(CauseObject_HEM_B_RECRUIT_POSTER cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_RECRUIT_POSTER.CONTENT, HEM_B_RECRUIT_POSTER.ID, HEM_B_RECRUIT_POSTER.PUBLISH_DATE, HEM_B_RECRUIT_POSTER.STATUS, HEM_B_RECRUIT_POSTER.CREATE_DATE, HEM_B_RECRUIT_POSTER.USER_ID, HEM_B_RECRUIT_POSTER.TITLE, HEM_B_RECRUIT_POSTER.PUBLISHER, HEM_B_RECRUIT_POSTER.END_DATE, HEM_B_RECRUIT_POSTER.IS_PUBLIC, HEM_B_RECRUIT_POSTER.DATA_SOURCE, HEM_B_RECRUIT_POSTER.MODIFY_USER_ID, HEM_B_RECRUIT_POSTER.RECRUIT_POSITION, HEM_B_RECRUIT_POSTER.REMARK, HEM_B_RECRUIT_POSTER.IS_NURSE from HEM_B_RECRUIT_POSTER where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_RECRUIT_POSTER",paging, order, sSql, parameters, trans);
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
			DisplayObject_HEM_B_RECRUIT_POSTER dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_RECRUIT_POSTER();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.CONTENT = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.PUBLISH_DATE = sqlReader.GetDateTime(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STATUS = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.USER_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.TITLE = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.PUBLISHER = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.END_DATE = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.DATA_SOURCE = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.MODIFY_USER_ID = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.REMARK = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.IS_NURSE = sqlReader.GetDecimal(14);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_RECRUIT_POSTER[] objs = new DisplayObject_HEM_B_RECRUIT_POSTER[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_HEM_B_RECRUIT_POSTER obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("CONTENT"))
			{
				strBuf.Add("  HEM_B_RECRUIT_POSTER.CONTENT = :U_CONTENT");
				param = new OracleParameter();
				param.ParameterName = ":U_CONTENT";
				param.OracleType = System.Data.OracleClient.OracleType.Clob;
				param.Size = 4000;
				param.Value = string.IsNullOrEmpty(obj.CONTENT) ? string.Empty : obj.CONTENT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PUBLISH_DATE"))
			{
				strBuf.Add("  HEM_B_RECRUIT_POSTER.PUBLISH_DATE = :U_PUBLISH_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_PUBLISH_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.PUBLISH_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATUS"))
			{
				strBuf.Add("  HEM_B_RECRUIT_POSTER.STATUS = :U_STATUS");
				param = new OracleParameter();
				param.ParameterName = ":U_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATUS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("CREATE_DATE"))
			{
				strBuf.Add("  HEM_B_RECRUIT_POSTER.CREATE_DATE = :U_CREATE_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_CREATE_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.CREATE_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USER_ID"))
			{
				strBuf.Add("  HEM_B_RECRUIT_POSTER.USER_ID = :U_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USER_ID) ? string.Empty : obj.USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TITLE"))
			{
				strBuf.Add("  HEM_B_RECRUIT_POSTER.TITLE = :U_TITLE");
				param = new OracleParameter();
				param.ParameterName = ":U_TITLE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 180;
				param.Value = string.IsNullOrEmpty(obj.TITLE) ? string.Empty : obj.TITLE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PUBLISHER"))
			{
				strBuf.Add("  HEM_B_RECRUIT_POSTER.PUBLISHER = :U_PUBLISHER");
				param = new OracleParameter();
				param.ParameterName = ":U_PUBLISHER";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = string.IsNullOrEmpty(obj.PUBLISHER) ? string.Empty : obj.PUBLISHER;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("END_DATE"))
			{
				strBuf.Add("  HEM_B_RECRUIT_POSTER.END_DATE = :U_END_DATE");
				param = new OracleParameter();
				param.ParameterName = ":U_END_DATE";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.END_DATE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_PUBLIC"))
			{
				strBuf.Add("  HEM_B_RECRUIT_POSTER.IS_PUBLIC = :U_IS_PUBLIC");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_PUBLIC";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_PUBLIC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("DATA_SOURCE"))
			{
				strBuf.Add("  HEM_B_RECRUIT_POSTER.DATA_SOURCE = :U_DATA_SOURCE");
				param = new OracleParameter();
				param.ParameterName = ":U_DATA_SOURCE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = string.IsNullOrEmpty(obj.DATA_SOURCE) ? string.Empty : obj.DATA_SOURCE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_USER_ID"))
			{
				strBuf.Add("  HEM_B_RECRUIT_POSTER.MODIFY_USER_ID = :U_MODIFY_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.MODIFY_USER_ID) ? string.Empty : obj.MODIFY_USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("RECRUIT_POSITION"))
			{
				strBuf.Add("  HEM_B_RECRUIT_POSTER.RECRUIT_POSITION = :U_RECRUIT_POSITION");
				param = new OracleParameter();
				param.ParameterName = ":U_RECRUIT_POSITION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 180;
				param.Value = string.IsNullOrEmpty(obj.RECRUIT_POSITION) ? string.Empty : obj.RECRUIT_POSITION;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REMARK"))
			{
				strBuf.Add("  HEM_B_RECRUIT_POSTER.REMARK = :U_REMARK");
				param = new OracleParameter();
				param.ParameterName = ":U_REMARK";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.REMARK) ? string.Empty : obj.REMARK;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_NURSE"))
			{
				strBuf.Add("  HEM_B_RECRUIT_POSTER.IS_NURSE = :U_IS_NURSE");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_NURSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_NURSE;
				paramList.Add(param);
			}
            if (!obj.IsNotUpdate("IS_SEND"))
            {
                strBuf.Add("  HEM_B_RECRUIT_POSTER.IS_SEND = :U_IS_SEND");
                param = new OracleParameter();
                param.ParameterName = ":U_IS_SEND";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = obj.IS_SEND;
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
