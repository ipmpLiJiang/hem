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
	[CauseObject(typeof(CauseObject_HEM_B_STAFF_REAL))]
	public partial class HelperObject_HEM_B_STAFF_REAL
	{		
		#region Method Blok
		public static int Save(EntityObject_HEM_B_STAFF_REAL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into HEM_B_STAFF_REAL( ID, REAL_ZHRSLJZ, REAL_ZHRGRSG, WRITTEN_ENGLISH, OPERATOR_ONE, REAL_PHONE, REAL_ZHRGRTZ, STAFF_ID, CREATE_TIME, STATUS, USER_ID, WRITTEN_THEORY, REAL_NAME, APPLY_ID, ERRORMESSAGE, NUM) values ( :ID, :REAL_ZHRSLJZ, :REAL_ZHRGRSG, :WRITTEN_ENGLISH, :OPERATOR_ONE, :REAL_PHONE, :REAL_ZHRGRTZ, :STAFF_ID, :CREATE_TIME, :STATUS, :USER_ID, :WRITTEN_THEORY, :REAL_NAME, :APPLY_ID, :ERRORMESSAGE, :NUM)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[16];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":REAL_ZHRSLJZ";
			parameters[1].Size = 22;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[1].Value = obj.REAL_ZHRSLJZ;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":REAL_ZHRGRSG";
			parameters[2].Size = 22;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[2].Value = obj.REAL_ZHRGRSG;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":WRITTEN_ENGLISH";
			parameters[3].Size = 22;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[3].Value = obj.WRITTEN_ENGLISH;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":OPERATOR_ONE";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.OPERATOR_ONE;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":REAL_PHONE";
			parameters[5].Size = 11;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.REAL_PHONE == null ? String.Empty:obj.REAL_PHONE;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":REAL_ZHRGRTZ";
			parameters[6].Size = 22;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[6].Value = obj.REAL_ZHRGRTZ;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":STAFF_ID";
			parameters[7].Size = 36;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[7].Value = obj.STAFF_ID == null ? String.Empty:obj.STAFF_ID;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":CREATE_TIME";
			parameters[8].Size = 7;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[8].Value = obj.CREATE_TIME;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":STATUS";
			parameters[9].Size = 22;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[9].Value = obj.STATUS;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":USER_ID";
			parameters[10].Size = 36;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[10].Value = obj.USER_ID == null ? String.Empty:obj.USER_ID;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":WRITTEN_THEORY";
			parameters[11].Size = 22;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[11].Value = obj.WRITTEN_THEORY;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":REAL_NAME";
			parameters[12].Size = 120;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.REAL_NAME == null ? String.Empty:obj.REAL_NAME;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":APPLY_ID";
			parameters[13].Size = 36;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[13].Value = obj.APPLY_ID == null ? String.Empty:obj.APPLY_ID;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":ERRORMESSAGE";
			parameters[14].Size = 3000;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[14].Value = obj.ERRORMESSAGE == null ? String.Empty:obj.ERRORMESSAGE;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":NUM";
			parameters[15].Size = 22;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[15].Value = obj.NUM;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_STAFF_REAL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_STAFF_REAL set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_STAFF_REAL obj,CauseObject_HEM_B_STAFF_REAL cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_STAFF_REAL set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_HEM_B_STAFF_REAL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from HEM_B_STAFF_REAL where  ID = :ID ";
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
		public static int Delete(CauseObject_HEM_B_STAFF_REAL cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from HEM_B_STAFF_REAL where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_HEM_B_STAFF_REAL Get(EntityObject_HEM_B_STAFF_REAL obj)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, REAL_ZHRSLJZ, REAL_ZHRGRSG, WRITTEN_ENGLISH, OPERATOR_ONE, REAL_PHONE, REAL_ZHRGRTZ, STAFF_ID, CREATE_TIME, STATUS, USER_ID, WRITTEN_THEORY, MODIFY_TIME, REAL_NAME, APPLY_ID, ERRORMESSAGE, NUM from HEM_B_STAFF_REAL where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_STAFF_REAL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_STAFF_REAL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REAL_PHONE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STAFF_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATUS = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.REAL_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ERRORMESSAGE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.NUM = sqlReader.GetDecimal(16);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_HEM_B_STAFF_REAL[] objs = new EntityObject_HEM_B_STAFF_REAL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_HEM_B_STAFF_REAL Get(EntityObject_HEM_B_STAFF_REAL obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  ID, REAL_ZHRSLJZ, REAL_ZHRGRSG, WRITTEN_ENGLISH, OPERATOR_ONE, REAL_PHONE, REAL_ZHRGRTZ, STAFF_ID, CREATE_TIME, STATUS, USER_ID, WRITTEN_THEORY, MODIFY_TIME, REAL_NAME, APPLY_ID, ERRORMESSAGE, NUM from HEM_B_STAFF_REAL where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_STAFF_REAL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_STAFF_REAL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REAL_PHONE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STAFF_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATUS = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.REAL_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ERRORMESSAGE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.NUM = sqlReader.GetDecimal(16);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_HEM_B_STAFF_REAL[] objs = new EntityObject_HEM_B_STAFF_REAL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_HEM_B_STAFF_REAL[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  HEM_B_STAFF_REAL.ID, HEM_B_STAFF_REAL.REAL_ZHRSLJZ, HEM_B_STAFF_REAL.REAL_ZHRGRSG, HEM_B_STAFF_REAL.WRITTEN_ENGLISH, HEM_B_STAFF_REAL.OPERATOR_ONE, HEM_B_STAFF_REAL.REAL_PHONE, HEM_B_STAFF_REAL.REAL_ZHRGRTZ, HEM_B_STAFF_REAL.STAFF_ID, HEM_B_STAFF_REAL.CREATE_TIME, HEM_B_STAFF_REAL.STATUS, HEM_B_STAFF_REAL.USER_ID, HEM_B_STAFF_REAL.WRITTEN_THEORY, HEM_B_STAFF_REAL.MODIFY_TIME, HEM_B_STAFF_REAL.REAL_NAME, HEM_B_STAFF_REAL.APPLY_ID, HEM_B_STAFF_REAL.ERRORMESSAGE, HEM_B_STAFF_REAL.NUM from HEM_B_STAFF_REAL where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_HEM_B_STAFF_REAL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_REAL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REAL_PHONE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STAFF_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATUS = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.REAL_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ERRORMESSAGE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.NUM = sqlReader.GetDecimal(16);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_REAL[] objs = new DisplayObject_HEM_B_STAFF_REAL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_HEM_B_STAFF_REAL cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And HEM_B_STAFF_REAL.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REAL", "ID"));
			}
			if(cause.REAL_ZHRSLJZ!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_STAFF_REAL.REAL_ZHRSLJZ = :C_REAL_ZHRSLJZ");
				param = new OracleParameter();
				param.ParameterName =":C_REAL_ZHRSLJZ";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.REAL_ZHRSLJZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("REAL_ZHRSLJZ"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REAL", "REAL_ZHRSLJZ"));
			}
			if(cause.REAL_ZHRGRSG!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_STAFF_REAL.REAL_ZHRGRSG = :C_REAL_ZHRGRSG");
				param = new OracleParameter();
				param.ParameterName =":C_REAL_ZHRGRSG";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.REAL_ZHRGRSG;
				paramList.Add(param);
			}
			if (cause.HasINValue("REAL_ZHRGRSG"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REAL", "REAL_ZHRGRSG"));
			}
			if(cause.WRITTEN_ENGLISH!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_STAFF_REAL.WRITTEN_ENGLISH = :C_WRITTEN_ENGLISH");
				param = new OracleParameter();
				param.ParameterName =":C_WRITTEN_ENGLISH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.WRITTEN_ENGLISH;
				paramList.Add(param);
			}
			if (cause.HasINValue("WRITTEN_ENGLISH"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REAL", "WRITTEN_ENGLISH"));
			}
			if(cause.OPERATOR_ONE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_STAFF_REAL.OPERATOR_ONE = :C_OPERATOR_ONE");
				param = new OracleParameter();
				param.ParameterName =":C_OPERATOR_ONE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.OPERATOR_ONE;
				paramList.Add(param);
			}
			if (cause.HasINValue("OPERATOR_ONE"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REAL", "OPERATOR_ONE"));
			}
			if(!string.IsNullOrEmpty(cause.REAL_PHONE))
			{
				strBuf.Append(" And HEM_B_STAFF_REAL.REAL_PHONE ").Append((cause.REAL_PHONE.StartsWith("%") || cause.REAL_PHONE.EndsWith("%")) ? " like " : " = ").Append(" :C_REAL_PHONE");
				param = new OracleParameter();
				param.ParameterName =":C_REAL_PHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = cause.REAL_PHONE;
				paramList.Add(param);
			}
			if (cause.HasINValue("REAL_PHONE"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REAL", "REAL_PHONE"));
			}
			if(cause.REAL_ZHRGRTZ!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_STAFF_REAL.REAL_ZHRGRTZ = :C_REAL_ZHRGRTZ");
				param = new OracleParameter();
				param.ParameterName =":C_REAL_ZHRGRTZ";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.REAL_ZHRGRTZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("REAL_ZHRGRTZ"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REAL", "REAL_ZHRGRTZ"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_ID))
			{
				strBuf.Append(" And HEM_B_STAFF_REAL.STAFF_ID ").Append((cause.STAFF_ID.StartsWith("%") || cause.STAFF_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_ID");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REAL", "STAFF_ID"));
			}
			if(cause.CREATE_TIME!= null)
			{
				if (cause.CREATE_TIME.Begin != null)
				{
					strBuf.Append(" And HEM_B_STAFF_REAL.CREATE_TIME >= :C_CREATE_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_TIME.End != null)
				{
					strBuf.Append(" And HEM_B_STAFF_REAL.CREATE_TIME < :C_CREATE_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("CREATE_TIME"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REAL", "CREATE_TIME"));
			}
			if(cause.STATUS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_STAFF_REAL.STATUS = :C_STATUS");
				param = new OracleParameter();
				param.ParameterName =":C_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATUS"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REAL", "STATUS"));
			}
			if(!string.IsNullOrEmpty(cause.USER_ID))
			{
				strBuf.Append(" And HEM_B_STAFF_REAL.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REAL", "USER_ID"));
			}
			if(cause.WRITTEN_THEORY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_STAFF_REAL.WRITTEN_THEORY = :C_WRITTEN_THEORY");
				param = new OracleParameter();
				param.ParameterName =":C_WRITTEN_THEORY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.WRITTEN_THEORY;
				paramList.Add(param);
			}
			if (cause.HasINValue("WRITTEN_THEORY"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REAL", "WRITTEN_THEORY"));
			}
			if(cause.MODIFY_TIME!= null)
			{
				if (cause.MODIFY_TIME.Begin != null)
				{
					strBuf.Append(" And HEM_B_STAFF_REAL.MODIFY_TIME >= :C_MODIFY_TIME_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.Begin;
					paramList.Add(param);
				}
				if (cause.MODIFY_TIME.End != null)
				{
					strBuf.Append(" And HEM_B_STAFF_REAL.MODIFY_TIME < :C_MODIFY_TIME_END");
					param = new OracleParameter();
					param.ParameterName = ":C_MODIFY_TIME_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.MODIFY_TIME.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("MODIFY_TIME"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REAL", "MODIFY_TIME"));
			}
			if(!string.IsNullOrEmpty(cause.REAL_NAME))
			{
				strBuf.Append(" And HEM_B_STAFF_REAL.REAL_NAME ").Append((cause.REAL_NAME.StartsWith("%") || cause.REAL_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_REAL_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_REAL_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.REAL_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("REAL_NAME"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REAL", "REAL_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.APPLY_ID))
			{
				strBuf.Append(" And HEM_B_STAFF_REAL.APPLY_ID ").Append((cause.APPLY_ID.StartsWith("%") || cause.APPLY_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_APPLY_ID");
				param = new OracleParameter();
				param.ParameterName =":C_APPLY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.APPLY_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("APPLY_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REAL", "APPLY_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ERRORMESSAGE))
			{
				strBuf.Append(" And HEM_B_STAFF_REAL.ERRORMESSAGE ").Append((cause.ERRORMESSAGE.StartsWith("%") || cause.ERRORMESSAGE.EndsWith("%")) ? " like " : " = ").Append(" :C_ERRORMESSAGE");
				param = new OracleParameter();
				param.ParameterName =":C_ERRORMESSAGE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 3000;
				param.Value = cause.ERRORMESSAGE;
				paramList.Add(param);
			}
			if (cause.HasINValue("ERRORMESSAGE"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REAL", "ERRORMESSAGE"));
			}
			if(cause.NUM!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_STAFF_REAL.NUM = :C_NUM");
				param = new OracleParameter();
				param.ParameterName =":C_NUM";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.NUM;
				paramList.Add(param);
			}
			if (cause.HasINValue("NUM"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_REAL", "NUM"));
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
		public static DisplayObject_HEM_B_STAFF_REAL[] Query(CauseObject_HEM_B_STAFF_REAL cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_REAL.ID, HEM_B_STAFF_REAL.REAL_ZHRSLJZ, HEM_B_STAFF_REAL.REAL_ZHRGRSG, HEM_B_STAFF_REAL.WRITTEN_ENGLISH, HEM_B_STAFF_REAL.OPERATOR_ONE, HEM_B_STAFF_REAL.REAL_PHONE, HEM_B_STAFF_REAL.REAL_ZHRGRTZ, HEM_B_STAFF_REAL.STAFF_ID, HEM_B_STAFF_REAL.CREATE_TIME, HEM_B_STAFF_REAL.STATUS, HEM_B_STAFF_REAL.USER_ID, HEM_B_STAFF_REAL.WRITTEN_THEORY, HEM_B_STAFF_REAL.MODIFY_TIME, HEM_B_STAFF_REAL.REAL_NAME, HEM_B_STAFF_REAL.APPLY_ID, HEM_B_STAFF_REAL.ERRORMESSAGE, HEM_B_STAFF_REAL.NUM from HEM_B_STAFF_REAL where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_STAFF_REAL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_REAL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REAL_PHONE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STAFF_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATUS = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.REAL_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ERRORMESSAGE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.NUM = sqlReader.GetDecimal(16);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_REAL[] objs = new DisplayObject_HEM_B_STAFF_REAL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_HEM_B_STAFF_REAL[] Query(CauseObject_HEM_B_STAFF_REAL cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_REAL.ID, HEM_B_STAFF_REAL.REAL_ZHRSLJZ, HEM_B_STAFF_REAL.REAL_ZHRGRSG, HEM_B_STAFF_REAL.WRITTEN_ENGLISH, HEM_B_STAFF_REAL.OPERATOR_ONE, HEM_B_STAFF_REAL.REAL_PHONE, HEM_B_STAFF_REAL.REAL_ZHRGRTZ, HEM_B_STAFF_REAL.STAFF_ID, HEM_B_STAFF_REAL.CREATE_TIME, HEM_B_STAFF_REAL.STATUS, HEM_B_STAFF_REAL.USER_ID, HEM_B_STAFF_REAL.WRITTEN_THEORY, HEM_B_STAFF_REAL.MODIFY_TIME, HEM_B_STAFF_REAL.REAL_NAME, HEM_B_STAFF_REAL.APPLY_ID, HEM_B_STAFF_REAL.ERRORMESSAGE, HEM_B_STAFF_REAL.NUM from HEM_B_STAFF_REAL where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_STAFF_REAL dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_REAL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REAL_PHONE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STAFF_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATUS = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.REAL_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ERRORMESSAGE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.NUM = sqlReader.GetDecimal(16);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_STAFF_REAL[] objs = new DisplayObject_HEM_B_STAFF_REAL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_STAFF_REAL[] Query(CauseObject_HEM_B_STAFF_REAL cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_REAL.ID, HEM_B_STAFF_REAL.REAL_ZHRSLJZ, HEM_B_STAFF_REAL.REAL_ZHRGRSG, HEM_B_STAFF_REAL.WRITTEN_ENGLISH, HEM_B_STAFF_REAL.OPERATOR_ONE, HEM_B_STAFF_REAL.REAL_PHONE, HEM_B_STAFF_REAL.REAL_ZHRGRTZ, HEM_B_STAFF_REAL.STAFF_ID, HEM_B_STAFF_REAL.CREATE_TIME, HEM_B_STAFF_REAL.STATUS, HEM_B_STAFF_REAL.USER_ID, HEM_B_STAFF_REAL.WRITTEN_THEORY, HEM_B_STAFF_REAL.MODIFY_TIME, HEM_B_STAFF_REAL.REAL_NAME, HEM_B_STAFF_REAL.APPLY_ID, HEM_B_STAFF_REAL.ERRORMESSAGE, HEM_B_STAFF_REAL.NUM from HEM_B_STAFF_REAL where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_STAFF_REAL",paging, order, sSql, parameters, connection);
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
			DisplayObject_HEM_B_STAFF_REAL dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_REAL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REAL_PHONE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STAFF_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATUS = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.REAL_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ERRORMESSAGE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.NUM = sqlReader.GetDecimal(16);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_REAL[] objs = new DisplayObject_HEM_B_STAFF_REAL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_STAFF_REAL[] Query(CauseObject_HEM_B_STAFF_REAL cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_REAL.ID, HEM_B_STAFF_REAL.REAL_ZHRSLJZ, HEM_B_STAFF_REAL.REAL_ZHRGRSG, HEM_B_STAFF_REAL.WRITTEN_ENGLISH, HEM_B_STAFF_REAL.OPERATOR_ONE, HEM_B_STAFF_REAL.REAL_PHONE, HEM_B_STAFF_REAL.REAL_ZHRGRTZ, HEM_B_STAFF_REAL.STAFF_ID, HEM_B_STAFF_REAL.CREATE_TIME, HEM_B_STAFF_REAL.STATUS, HEM_B_STAFF_REAL.USER_ID, HEM_B_STAFF_REAL.WRITTEN_THEORY, HEM_B_STAFF_REAL.MODIFY_TIME, HEM_B_STAFF_REAL.REAL_NAME, HEM_B_STAFF_REAL.APPLY_ID, HEM_B_STAFF_REAL.ERRORMESSAGE, HEM_B_STAFF_REAL.NUM from HEM_B_STAFF_REAL where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_STAFF_REAL",paging, order, sSql, parameters, trans);
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
			DisplayObject_HEM_B_STAFF_REAL dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_REAL();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.ID = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.REAL_PHONE = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.STAFF_ID = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.CREATE_TIME = sqlReader.GetDateTime(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.STATUS = sqlReader.GetDecimal(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.USER_ID = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.MODIFY_TIME = sqlReader.GetDateTime(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.REAL_NAME = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.APPLY_ID = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ERRORMESSAGE = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.NUM = sqlReader.GetDecimal(16);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_STAFF_REAL[] objs = new DisplayObject_HEM_B_STAFF_REAL[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_HEM_B_STAFF_REAL obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("REAL_ZHRSLJZ"))
			{
				strBuf.Add("  HEM_B_STAFF_REAL.REAL_ZHRSLJZ = :U_REAL_ZHRSLJZ");
				param = new OracleParameter();
				param.ParameterName = ":U_REAL_ZHRSLJZ";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.REAL_ZHRSLJZ;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REAL_ZHRGRSG"))
			{
				strBuf.Add("  HEM_B_STAFF_REAL.REAL_ZHRGRSG = :U_REAL_ZHRGRSG");
				param = new OracleParameter();
				param.ParameterName = ":U_REAL_ZHRGRSG";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.REAL_ZHRGRSG;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("WRITTEN_ENGLISH"))
			{
				strBuf.Add("  HEM_B_STAFF_REAL.WRITTEN_ENGLISH = :U_WRITTEN_ENGLISH");
				param = new OracleParameter();
				param.ParameterName = ":U_WRITTEN_ENGLISH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.WRITTEN_ENGLISH;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("OPERATOR_ONE"))
			{
				strBuf.Add("  HEM_B_STAFF_REAL.OPERATOR_ONE = :U_OPERATOR_ONE");
				param = new OracleParameter();
				param.ParameterName = ":U_OPERATOR_ONE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.OPERATOR_ONE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REAL_PHONE"))
			{
				strBuf.Add("  HEM_B_STAFF_REAL.REAL_PHONE = :U_REAL_PHONE");
				param = new OracleParameter();
				param.ParameterName = ":U_REAL_PHONE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = string.IsNullOrEmpty(obj.REAL_PHONE) ? string.Empty : obj.REAL_PHONE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REAL_ZHRGRTZ"))
			{
				strBuf.Add("  HEM_B_STAFF_REAL.REAL_ZHRGRTZ = :U_REAL_ZHRGRTZ");
				param = new OracleParameter();
				param.ParameterName = ":U_REAL_ZHRGRTZ";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.REAL_ZHRGRTZ;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STAFF_ID"))
			{
				strBuf.Add("  HEM_B_STAFF_REAL.STAFF_ID = :U_STAFF_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_STAFF_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.STAFF_ID) ? string.Empty : obj.STAFF_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STATUS"))
			{
				strBuf.Add("  HEM_B_STAFF_REAL.STATUS = :U_STATUS");
				param = new OracleParameter();
				param.ParameterName = ":U_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.STATUS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USER_ID"))
			{
				strBuf.Add("  HEM_B_STAFF_REAL.USER_ID = :U_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USER_ID) ? string.Empty : obj.USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("WRITTEN_THEORY"))
			{
				strBuf.Add("  HEM_B_STAFF_REAL.WRITTEN_THEORY = :U_WRITTEN_THEORY");
				param = new OracleParameter();
				param.ParameterName = ":U_WRITTEN_THEORY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.WRITTEN_THEORY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("MODIFY_TIME"))
			{
				strBuf.Add("  HEM_B_STAFF_REAL.MODIFY_TIME = :U_MODIFY_TIME");
				param = new OracleParameter();
				param.ParameterName = ":U_MODIFY_TIME";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.MODIFY_TIME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("REAL_NAME"))
			{
				strBuf.Add("  HEM_B_STAFF_REAL.REAL_NAME = :U_REAL_NAME");
				param = new OracleParameter();
				param.ParameterName = ":U_REAL_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = string.IsNullOrEmpty(obj.REAL_NAME) ? string.Empty : obj.REAL_NAME;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("APPLY_ID"))
			{
				strBuf.Add("  HEM_B_STAFF_REAL.APPLY_ID = :U_APPLY_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_APPLY_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.APPLY_ID) ? string.Empty : obj.APPLY_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ERRORMESSAGE"))
			{
				strBuf.Add("  HEM_B_STAFF_REAL.ERRORMESSAGE = :U_ERRORMESSAGE");
				param = new OracleParameter();
				param.ParameterName = ":U_ERRORMESSAGE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 3000;
				param.Value = string.IsNullOrEmpty(obj.ERRORMESSAGE) ? string.Empty : obj.ERRORMESSAGE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NUM"))
			{
				strBuf.Add("  HEM_B_STAFF_REAL.NUM = :U_NUM");
				param = new OracleParameter();
				param.ParameterName = ":U_NUM";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.NUM;
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
