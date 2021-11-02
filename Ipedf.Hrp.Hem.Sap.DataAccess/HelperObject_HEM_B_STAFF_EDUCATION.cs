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
	[CauseObject(typeof(CauseObject_HEM_B_STAFF_EDUCATION))]
	public partial class HelperObject_HEM_B_STAFF_EDUCATION
	{		
		#region Method Blok
		public static int Save(EntityObject_HEM_B_STAFF_EDUCATION obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
			string sSql = "insert into HEM_B_STAFF_EDUCATION( SLART, ID, TYPE_ID, STAFF_ID, IS_HIGHEST, ZHRXYJFX, ZHRXKZY2, ENDDA, ZHRXKZY1, BEGDA, INSTI, ZHRDSXM) values ( :SLART, :ID, :TYPE_ID, :STAFF_ID, :IS_HIGHEST, :ZHRXYJFX, :ZHRXKZY2, :ENDDA, :ZHRXKZY1, :BEGDA, :INSTI, :ZHRDSXM)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[12];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":SLART";
			parameters[0].Size = 2;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.SLART == null ? String.Empty:obj.SLART;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ID";
			parameters[1].Size = 36;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[1].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":TYPE_ID";
			parameters[2].Size = 50;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.TYPE_ID == null ? String.Empty:obj.TYPE_ID;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":STAFF_ID";
			parameters[3].Size = 36;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[3].Value = obj.STAFF_ID == null ? String.Empty:obj.STAFF_ID;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":IS_HIGHEST";
			parameters[4].Size = 22;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[4].Value = obj.IS_HIGHEST;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":ZHRXYJFX";
			parameters[5].Size = 300;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.ZHRXYJFX == null ? String.Empty:obj.ZHRXYJFX;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":ZHRXKZY2";
			parameters[6].Size = 300;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[6].Value = obj.ZHRXKZY2 == null ? String.Empty:obj.ZHRXKZY2;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":ENDDA";
			parameters[7].Size = 7;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[7].Value = obj.ENDDA;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":ZHRXKZY1";
			parameters[8].Size = 300;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[8].Value = obj.ZHRXKZY1 == null ? String.Empty:obj.ZHRXKZY1;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":BEGDA";
			parameters[9].Size = 7;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[9].Value = obj.BEGDA;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":INSTI";
			parameters[10].Size = 300;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.INSTI == null ? String.Empty:obj.INSTI;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":ZHRDSXM";
			parameters[11].Size = 60;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.ZHRDSXM == null ? String.Empty:obj.ZHRDSXM;
			#endregion 
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_STAFF_EDUCATION obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_STAFF_EDUCATION set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_STAFF_EDUCATION obj,CauseObject_HEM_B_STAFF_EDUCATION cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_STAFF_EDUCATION set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_HEM_B_STAFF_EDUCATION obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from HEM_B_STAFF_EDUCATION where  ID = :ID ";
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
		public static int Delete(CauseObject_HEM_B_STAFF_EDUCATION cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from HEM_B_STAFF_EDUCATION where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_HEM_B_STAFF_EDUCATION Get(EntityObject_HEM_B_STAFF_EDUCATION obj)
		{
			
			//平台自动生成代码
			string sSql = "select  SLART, ID, TYPE_ID, STAFF_ID, IS_HIGHEST, ZHRXYJFX, ZHRXKZY2, ENDDA, ZHRXKZY1, BEGDA, INSTI, ZHRDSXM from HEM_B_STAFF_EDUCATION where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_STAFF_EDUCATION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_STAFF_EDUCATION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SLART = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_HIGHEST = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRXYJFX = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRXKZY2 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ENDDA = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ZHRXKZY1 = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BEGDA = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.INSTI = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRDSXM = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_HEM_B_STAFF_EDUCATION[] objs = new EntityObject_HEM_B_STAFF_EDUCATION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_HEM_B_STAFF_EDUCATION Get(EntityObject_HEM_B_STAFF_EDUCATION obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  SLART, ID, TYPE_ID, STAFF_ID, IS_HIGHEST, ZHRXYJFX, ZHRXKZY2, ENDDA, ZHRXKZY1, BEGDA, INSTI, ZHRDSXM from HEM_B_STAFF_EDUCATION where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_STAFF_EDUCATION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_STAFF_EDUCATION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SLART = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_HIGHEST = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRXYJFX = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRXKZY2 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ENDDA = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ZHRXKZY1 = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BEGDA = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.INSTI = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRDSXM = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_HEM_B_STAFF_EDUCATION[] objs = new EntityObject_HEM_B_STAFF_EDUCATION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_HEM_B_STAFF_EDUCATION[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  HEM_B_STAFF_EDUCATION.SLART, HEM_B_STAFF_EDUCATION.ID, HEM_B_STAFF_EDUCATION.TYPE_ID, HEM_B_STAFF_EDUCATION.STAFF_ID, HEM_B_STAFF_EDUCATION.IS_HIGHEST, HEM_B_STAFF_EDUCATION.ZHRXYJFX, HEM_B_STAFF_EDUCATION.ZHRXKZY2, HEM_B_STAFF_EDUCATION.ENDDA, HEM_B_STAFF_EDUCATION.ZHRXKZY1, HEM_B_STAFF_EDUCATION.BEGDA, HEM_B_STAFF_EDUCATION.INSTI, HEM_B_STAFF_EDUCATION.ZHRDSXM from HEM_B_STAFF_EDUCATION where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_HEM_B_STAFF_EDUCATION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_EDUCATION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SLART = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_HIGHEST = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRXYJFX = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRXKZY2 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ENDDA = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ZHRXKZY1 = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BEGDA = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.INSTI = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRDSXM = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_EDUCATION[] objs = new DisplayObject_HEM_B_STAFF_EDUCATION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_HEM_B_STAFF_EDUCATION cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.SLART))
			{
				strBuf.Append(" And HEM_B_STAFF_EDUCATION.SLART ").Append((cause.SLART.StartsWith("%") || cause.SLART.EndsWith("%")) ? " like " : " = ").Append(" :C_SLART");
				param = new OracleParameter();
				param.ParameterName =":C_SLART";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = cause.SLART;
				paramList.Add(param);
			}
			if (cause.HasINValue("SLART"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_EDUCATION", "SLART"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And HEM_B_STAFF_EDUCATION.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_EDUCATION", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.TYPE_ID))
			{
				strBuf.Append(" And HEM_B_STAFF_EDUCATION.TYPE_ID ").Append((cause.TYPE_ID.StartsWith("%") || cause.TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_EDUCATION", "TYPE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_ID))
			{
				strBuf.Append(" And HEM_B_STAFF_EDUCATION.STAFF_ID ").Append((cause.STAFF_ID.StartsWith("%") || cause.STAFF_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_ID");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_EDUCATION", "STAFF_ID"));
			}
			if(cause.IS_HIGHEST!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_STAFF_EDUCATION.IS_HIGHEST = :C_IS_HIGHEST");
				param = new OracleParameter();
				param.ParameterName =":C_IS_HIGHEST";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_HIGHEST;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_HIGHEST"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_EDUCATION", "IS_HIGHEST"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRXYJFX))
			{
				strBuf.Append(" And HEM_B_STAFF_EDUCATION.ZHRXYJFX ").Append((cause.ZHRXYJFX.StartsWith("%") || cause.ZHRXYJFX.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRXYJFX");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRXYJFX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.ZHRXYJFX;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRXYJFX"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_EDUCATION", "ZHRXYJFX"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRXKZY2))
			{
				strBuf.Append(" And HEM_B_STAFF_EDUCATION.ZHRXKZY2 ").Append((cause.ZHRXKZY2.StartsWith("%") || cause.ZHRXKZY2.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRXKZY2");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRXKZY2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.ZHRXKZY2;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRXKZY2"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_EDUCATION", "ZHRXKZY2"));
			}
			if(cause.ENDDA!= null)
			{
				if (cause.ENDDA.Begin != null)
				{
					strBuf.Append(" And HEM_B_STAFF_EDUCATION.ENDDA >= :C_ENDDA_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_ENDDA_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.ENDDA.Begin;
					paramList.Add(param);
				}
				if (cause.ENDDA.End != null)
				{
					strBuf.Append(" And HEM_B_STAFF_EDUCATION.ENDDA < :C_ENDDA_END");
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
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_EDUCATION", "ENDDA"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRXKZY1))
			{
				strBuf.Append(" And HEM_B_STAFF_EDUCATION.ZHRXKZY1 ").Append((cause.ZHRXKZY1.StartsWith("%") || cause.ZHRXKZY1.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRXKZY1");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRXKZY1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.ZHRXKZY1;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRXKZY1"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_EDUCATION", "ZHRXKZY1"));
			}
			if(cause.BEGDA!= null)
			{
				if (cause.BEGDA.Begin != null)
				{
					strBuf.Append(" And HEM_B_STAFF_EDUCATION.BEGDA >= :C_BEGDA_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_BEGDA_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.BEGDA.Begin;
					paramList.Add(param);
				}
				if (cause.BEGDA.End != null)
				{
					strBuf.Append(" And HEM_B_STAFF_EDUCATION.BEGDA < :C_BEGDA_END");
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
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_EDUCATION", "BEGDA"));
			}
			if(!string.IsNullOrEmpty(cause.INSTI))
			{
				strBuf.Append(" And HEM_B_STAFF_EDUCATION.INSTI ").Append((cause.INSTI.StartsWith("%") || cause.INSTI.EndsWith("%")) ? " like " : " = ").Append(" :C_INSTI");
				param = new OracleParameter();
				param.ParameterName =":C_INSTI";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.INSTI;
				paramList.Add(param);
			}
			if (cause.HasINValue("INSTI"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_EDUCATION", "INSTI"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRDSXM))
			{
				strBuf.Append(" And HEM_B_STAFF_EDUCATION.ZHRDSXM ").Append((cause.ZHRDSXM.StartsWith("%") || cause.ZHRDSXM.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRDSXM");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRDSXM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 60;
				param.Value = cause.ZHRDSXM;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRDSXM"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF_EDUCATION", "ZHRDSXM"));
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
		public static DisplayObject_HEM_B_STAFF_EDUCATION[] Query(CauseObject_HEM_B_STAFF_EDUCATION cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_EDUCATION.SLART, HEM_B_STAFF_EDUCATION.ID, HEM_B_STAFF_EDUCATION.TYPE_ID, HEM_B_STAFF_EDUCATION.STAFF_ID, HEM_B_STAFF_EDUCATION.IS_HIGHEST, HEM_B_STAFF_EDUCATION.ZHRXYJFX, HEM_B_STAFF_EDUCATION.ZHRXKZY2, HEM_B_STAFF_EDUCATION.ENDDA, HEM_B_STAFF_EDUCATION.ZHRXKZY1, HEM_B_STAFF_EDUCATION.BEGDA, HEM_B_STAFF_EDUCATION.INSTI, HEM_B_STAFF_EDUCATION.ZHRDSXM from HEM_B_STAFF_EDUCATION where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_STAFF_EDUCATION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_EDUCATION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SLART = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_HIGHEST = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRXYJFX = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRXKZY2 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ENDDA = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ZHRXKZY1 = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BEGDA = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.INSTI = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRDSXM = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_EDUCATION[] objs = new DisplayObject_HEM_B_STAFF_EDUCATION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_HEM_B_STAFF_EDUCATION[] Query(CauseObject_HEM_B_STAFF_EDUCATION cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_EDUCATION.SLART, HEM_B_STAFF_EDUCATION.ID, HEM_B_STAFF_EDUCATION.TYPE_ID, HEM_B_STAFF_EDUCATION.STAFF_ID, HEM_B_STAFF_EDUCATION.IS_HIGHEST, HEM_B_STAFF_EDUCATION.ZHRXYJFX, HEM_B_STAFF_EDUCATION.ZHRXKZY2, HEM_B_STAFF_EDUCATION.ENDDA, HEM_B_STAFF_EDUCATION.ZHRXKZY1, HEM_B_STAFF_EDUCATION.BEGDA, HEM_B_STAFF_EDUCATION.INSTI, HEM_B_STAFF_EDUCATION.ZHRDSXM from HEM_B_STAFF_EDUCATION where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_STAFF_EDUCATION dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_EDUCATION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SLART = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_HIGHEST = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRXYJFX = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRXKZY2 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ENDDA = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ZHRXKZY1 = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BEGDA = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.INSTI = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRDSXM = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_STAFF_EDUCATION[] objs = new DisplayObject_HEM_B_STAFF_EDUCATION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_STAFF_EDUCATION[] Query(CauseObject_HEM_B_STAFF_EDUCATION cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_EDUCATION.SLART, HEM_B_STAFF_EDUCATION.ID, HEM_B_STAFF_EDUCATION.TYPE_ID, HEM_B_STAFF_EDUCATION.STAFF_ID, HEM_B_STAFF_EDUCATION.IS_HIGHEST, HEM_B_STAFF_EDUCATION.ZHRXYJFX, HEM_B_STAFF_EDUCATION.ZHRXKZY2, HEM_B_STAFF_EDUCATION.ENDDA, HEM_B_STAFF_EDUCATION.ZHRXKZY1, HEM_B_STAFF_EDUCATION.BEGDA, HEM_B_STAFF_EDUCATION.INSTI, HEM_B_STAFF_EDUCATION.ZHRDSXM from HEM_B_STAFF_EDUCATION where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_STAFF_EDUCATION",paging, order, sSql, parameters, connection);
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
			DisplayObject_HEM_B_STAFF_EDUCATION dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_EDUCATION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SLART = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_HIGHEST = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRXYJFX = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRXKZY2 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ENDDA = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ZHRXKZY1 = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BEGDA = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.INSTI = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRDSXM = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF_EDUCATION[] objs = new DisplayObject_HEM_B_STAFF_EDUCATION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_STAFF_EDUCATION[] Query(CauseObject_HEM_B_STAFF_EDUCATION cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF_EDUCATION.SLART, HEM_B_STAFF_EDUCATION.ID, HEM_B_STAFF_EDUCATION.TYPE_ID, HEM_B_STAFF_EDUCATION.STAFF_ID, HEM_B_STAFF_EDUCATION.IS_HIGHEST, HEM_B_STAFF_EDUCATION.ZHRXYJFX, HEM_B_STAFF_EDUCATION.ZHRXKZY2, HEM_B_STAFF_EDUCATION.ENDDA, HEM_B_STAFF_EDUCATION.ZHRXKZY1, HEM_B_STAFF_EDUCATION.BEGDA, HEM_B_STAFF_EDUCATION.INSTI, HEM_B_STAFF_EDUCATION.ZHRDSXM from HEM_B_STAFF_EDUCATION where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_STAFF_EDUCATION",paging, order, sSql, parameters, trans);
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
			DisplayObject_HEM_B_STAFF_EDUCATION dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF_EDUCATION();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.SLART = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ID = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.TYPE_ID = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.STAFF_ID = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.IS_HIGHEST = sqlReader.GetDecimal(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.ZHRXYJFX = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ZHRXKZY2 = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ENDDA = sqlReader.GetDateTime(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ZHRXKZY1 = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.BEGDA = sqlReader.GetDateTime(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.INSTI = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRDSXM = sqlReader.GetString(11);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_STAFF_EDUCATION[] objs = new DisplayObject_HEM_B_STAFF_EDUCATION[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_HEM_B_STAFF_EDUCATION obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("SLART"))
			{
				strBuf.Add("  HEM_B_STAFF_EDUCATION.SLART = :U_SLART");
				param = new OracleParameter();
				param.ParameterName = ":U_SLART";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = string.IsNullOrEmpty(obj.SLART) ? string.Empty : obj.SLART;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TYPE_ID"))
			{
				strBuf.Add("  HEM_B_STAFF_EDUCATION.TYPE_ID = :U_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.TYPE_ID) ? string.Empty : obj.TYPE_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("STAFF_ID"))
			{
				strBuf.Add("  HEM_B_STAFF_EDUCATION.STAFF_ID = :U_STAFF_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_STAFF_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.STAFF_ID) ? string.Empty : obj.STAFF_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("IS_HIGHEST"))
			{
				strBuf.Add("  HEM_B_STAFF_EDUCATION.IS_HIGHEST = :U_IS_HIGHEST");
				param = new OracleParameter();
				param.ParameterName = ":U_IS_HIGHEST";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.IS_HIGHEST;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRXYJFX"))
			{
				strBuf.Add("  HEM_B_STAFF_EDUCATION.ZHRXYJFX = :U_ZHRXYJFX");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRXYJFX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.ZHRXYJFX) ? string.Empty : obj.ZHRXYJFX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRXKZY2"))
			{
				strBuf.Add("  HEM_B_STAFF_EDUCATION.ZHRXKZY2 = :U_ZHRXKZY2");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRXKZY2";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.ZHRXKZY2) ? string.Empty : obj.ZHRXKZY2;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ENDDA"))
			{
				strBuf.Add("  HEM_B_STAFF_EDUCATION.ENDDA = :U_ENDDA");
				param = new OracleParameter();
				param.ParameterName = ":U_ENDDA";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.ENDDA;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRXKZY1"))
			{
				strBuf.Add("  HEM_B_STAFF_EDUCATION.ZHRXKZY1 = :U_ZHRXKZY1");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRXKZY1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.ZHRXKZY1) ? string.Empty : obj.ZHRXKZY1;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("BEGDA"))
			{
				strBuf.Add("  HEM_B_STAFF_EDUCATION.BEGDA = :U_BEGDA");
				param = new OracleParameter();
				param.ParameterName = ":U_BEGDA";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.BEGDA;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("INSTI"))
			{
				strBuf.Add("  HEM_B_STAFF_EDUCATION.INSTI = :U_INSTI");
				param = new OracleParameter();
				param.ParameterName = ":U_INSTI";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.INSTI) ? string.Empty : obj.INSTI;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRDSXM"))
			{
				strBuf.Add("  HEM_B_STAFF_EDUCATION.ZHRDSXM = :U_ZHRDSXM");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRDSXM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 60;
				param.Value = string.IsNullOrEmpty(obj.ZHRDSXM) ? string.Empty : obj.ZHRDSXM;
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
