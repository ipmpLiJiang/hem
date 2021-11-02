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
	[CauseObject(typeof(CauseObject_HEM_B_STAFF))]
	public partial class HelperObject_HEM_B_STAFF
	{		
		#region Method Blok
		public static int Save(EntityObject_HEM_B_STAFF obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			obj.ID= Guid.NewGuid().ToString();
            string sSql = "insert into HEM_B_STAFF( FIRSTCHOICE, ZHRTC, ZHRYRXX, USRID_MAIL, GBDAT, LOCAT_JT, USER_ID, ZHRGRSG, ID, FAMST, ZHRHJJL, ZHRSXXX, ZHRSLJZ, USRID_TEL, ZHRJSJSP, ZHRWYFS, ZHRGZNX, FGBDT, FANAM, ICNUM, GESCH, ZHRWYSP, NACHN, ANZKD, ZHRBZ, TELNR, FASEX, ZHRJKZK, SECONDCHOICE, PCODE, ZHRGRTZ, LOCAT_XJ, ZHRTZGG, ZHRFZDJ, ZHRJG, RACKY, LOCAT_HJ, ZHRZWJS,YJSSXXX,IS_STANDARD, IS_SZHY, SCHOOLINFO, JWBS) values ( :FIRSTCHOICE, :ZHRTC, :ZHRYRXX, :USRID_MAIL, :GBDAT, :LOCAT_JT, :USER_ID, :ZHRGRSG, :ID, :FAMST, :ZHRHJJL, :ZHRSXXX, :ZHRSLJZ, :USRID_TEL, :ZHRJSJSP, :ZHRWYFS, :ZHRGZNX, :FGBDT, :FANAM, :ICNUM, :GESCH, :ZHRWYSP, :NACHN, :ANZKD, :ZHRBZ, :TELNR, :FASEX, :ZHRJKZK, :SECONDCHOICE, :PCODE, :ZHRGRTZ, :LOCAT_XJ, :ZHRTZGG, :ZHRFZDJ, :ZHRJG, :RACKY, :LOCAT_HJ, :ZHRZWJS,:YJSSXXX,:IS_STANDARD, :IS_SZHY, :SCHOOLINFO, :JWBS)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[43];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":FIRSTCHOICE";
			parameters[0].Size = 120;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[0].Value = obj.FIRSTCHOICE == null ? String.Empty:obj.FIRSTCHOICE;
			parameters[1] = new OracleParameter();
			parameters[1].ParameterName =":ZHRTC";
			parameters[1].Size = 600;
			parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[1].Value = obj.ZHRTC == null ? String.Empty:obj.ZHRTC;
			parameters[2] = new OracleParameter();
			parameters[2].ParameterName =":ZHRYRXX";
			parameters[2].Size = 1;
			parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[2].Value = obj.ZHRYRXX == null ? String.Empty:obj.ZHRYRXX;
			parameters[3] = new OracleParameter();
			parameters[3].ParameterName =":USRID_MAIL";
			parameters[3].Size = 100;
			parameters[3].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[3].Value = obj.USRID_MAIL == null ? String.Empty:obj.USRID_MAIL;
			parameters[4] = new OracleParameter();
			parameters[4].ParameterName =":GBDAT";
			parameters[4].Size = 7;
			parameters[4].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[4].Value = obj.GBDAT;
			parameters[5] = new OracleParameter();
			parameters[5].ParameterName =":LOCAT_JT";
			parameters[5].Size = 120;
			parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[5].Value = obj.LOCAT_JT == null ? String.Empty:obj.LOCAT_JT;
			parameters[6] = new OracleParameter();
			parameters[6].ParameterName =":USER_ID";
			parameters[6].Size = 36;
			parameters[6].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[6].Value = obj.USER_ID == null ? String.Empty:obj.USER_ID;
			parameters[7] = new OracleParameter();
			parameters[7].ParameterName =":ZHRGRSG";
			parameters[7].Size = 10;
			parameters[7].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[7].Value = obj.ZHRGRSG == null ? String.Empty:obj.ZHRGRSG;
			parameters[8] = new OracleParameter();
			parameters[8].ParameterName =":ID";
			parameters[8].Size = 36;
			parameters[8].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[8].Value = obj.ID == null ? String.Empty:obj.ID;
			parameters[9] = new OracleParameter();
			parameters[9].ParameterName =":FAMST";
			parameters[9].Size = 1;
			parameters[9].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[9].Value = obj.FAMST == null ? String.Empty:obj.FAMST;
			parameters[10] = new OracleParameter();
			parameters[10].ParameterName =":ZHRHJJL";
			parameters[10].Size = 600;
			parameters[10].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[10].Value = obj.ZHRHJJL == null ? String.Empty:obj.ZHRHJJL;
			parameters[11] = new OracleParameter();
			parameters[11].ParameterName =":ZHRSXXX";
			parameters[11].Size = 300;
			parameters[11].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[11].Value = obj.ZHRSXXX == null ? String.Empty:obj.ZHRSXXX;
			parameters[12] = new OracleParameter();
			parameters[12].ParameterName =":ZHRSLJZ";
			parameters[12].Size = 10;
			parameters[12].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[12].Value = obj.ZHRSLJZ == null ? String.Empty:obj.ZHRSLJZ;
			parameters[13] = new OracleParameter();
			parameters[13].ParameterName =":USRID_TEL";
			parameters[13].Size = 11;
			parameters[13].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[13].Value = obj.USRID_TEL == null ? String.Empty:obj.USRID_TEL;
			parameters[14] = new OracleParameter();
			parameters[14].ParameterName =":ZHRJSJSP";
			parameters[14].Size = 1;
			parameters[14].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[14].Value = obj.ZHRJSJSP == null ? String.Empty:obj.ZHRJSJSP;
			parameters[15] = new OracleParameter();
			parameters[15].ParameterName =":ZHRWYFS";
			parameters[15].Size = 16;
			parameters[15].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[15].Value = obj.ZHRWYFS == null ? String.Empty:obj.ZHRWYFS;
			parameters[16] = new OracleParameter();
			parameters[16].ParameterName =":ZHRGZNX";
			parameters[16].Size = 30;
			parameters[16].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[16].Value = obj.ZHRGZNX == null ? String.Empty:obj.ZHRGZNX;
			parameters[17] = new OracleParameter();
			parameters[17].ParameterName =":FGBDT";
			parameters[17].Size = 7;
			parameters[17].OracleType = System.Data.OracleClient.OracleType.DateTime;
			parameters[17].Value = obj.FGBDT;
			parameters[18] = new OracleParameter();
			parameters[18].ParameterName =":FANAM";
			parameters[18].Size = 120;
			parameters[18].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[18].Value = obj.FANAM == null ? String.Empty:obj.FANAM;
			parameters[19] = new OracleParameter();
			parameters[19].ParameterName =":ICNUM";
			parameters[19].Size = 30;
			parameters[19].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[19].Value = obj.ICNUM == null ? String.Empty:obj.ICNUM;
			parameters[20] = new OracleParameter();
			parameters[20].ParameterName =":GESCH";
			parameters[20].Size = 1;
			parameters[20].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[20].Value = obj.GESCH == null ? String.Empty:obj.GESCH;
			parameters[21] = new OracleParameter();
			parameters[21].ParameterName =":ZHRWYSP";
			parameters[21].Size = 1;
			parameters[21].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[21].Value = obj.ZHRWYSP == null ? String.Empty:obj.ZHRWYSP;
			parameters[22] = new OracleParameter();
			parameters[22].ParameterName =":NACHN";
			parameters[22].Size = 120;
			parameters[22].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[22].Value = obj.NACHN == null ? String.Empty:obj.NACHN;
			parameters[23] = new OracleParameter();
			parameters[23].ParameterName =":ANZKD";
			parameters[23].Size = 22;
			parameters[23].OracleType = System.Data.OracleClient.OracleType.Number;
			parameters[23].Value = obj.ANZKD;
			parameters[24] = new OracleParameter();
			parameters[24].ParameterName =":ZHRBZ";
			parameters[24].Size = 600;
			parameters[24].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[24].Value = obj.ZHRBZ == null ? String.Empty:obj.ZHRBZ;
			parameters[25] = new OracleParameter();
			parameters[25].ParameterName =":TELNR";
			parameters[25].Size = 11;
			parameters[25].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[25].Value = obj.TELNR == null ? String.Empty:obj.TELNR;
			parameters[26] = new OracleParameter();
			parameters[26].ParameterName =":FASEX";
			parameters[26].Size = 1;
			parameters[26].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[26].Value = obj.FASEX == null ? String.Empty:obj.FASEX;
			parameters[27] = new OracleParameter();
			parameters[27].ParameterName =":ZHRJKZK";
			parameters[27].Size = 30;
			parameters[27].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[27].Value = obj.ZHRJKZK == null ? String.Empty:obj.ZHRJKZK;
			parameters[28] = new OracleParameter();
			parameters[28].ParameterName =":SECONDCHOICE";
			parameters[28].Size = 120;
			parameters[28].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[28].Value = obj.SECONDCHOICE == null ? String.Empty:obj.SECONDCHOICE;
			parameters[29] = new OracleParameter();
			parameters[29].ParameterName =":PCODE";
			parameters[29].Size = 2;
			parameters[29].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[29].Value = obj.PCODE == null ? String.Empty:obj.PCODE;
			parameters[30] = new OracleParameter();
			parameters[30].ParameterName =":ZHRGRTZ";
			parameters[30].Size = 10;
			parameters[30].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[30].Value = obj.ZHRGRTZ == null ? String.Empty:obj.ZHRGRTZ;
			parameters[31] = new OracleParameter();
			parameters[31].ParameterName =":LOCAT_XJ";
			parameters[31].Size = 120;
			parameters[31].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[31].Value = obj.LOCAT_XJ == null ? String.Empty:obj.LOCAT_XJ;
			parameters[32] = new OracleParameter();
			parameters[32].ParameterName =":ZHRTZGG";
			parameters[32].Size = 4;
			parameters[32].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[32].Value = obj.ZHRTZGG == null ? String.Empty:obj.ZHRTZGG;
			parameters[33] = new OracleParameter();
			parameters[33].ParameterName =":ZHRFZDJ";
			parameters[33].Size = 1;
			parameters[33].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[33].Value = obj.ZHRFZDJ == null ? String.Empty:obj.ZHRFZDJ;
			parameters[34] = new OracleParameter();
			parameters[34].ParameterName =":ZHRJG";
			parameters[34].Size = 120;
			parameters[34].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[34].Value = obj.ZHRJG == null ? String.Empty:obj.ZHRJG;
			parameters[35] = new OracleParameter();
			parameters[35].ParameterName =":RACKY";
			parameters[35].Size = 2;
			parameters[35].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[35].Value = obj.RACKY == null ? String.Empty:obj.RACKY;
			parameters[36] = new OracleParameter();
			parameters[36].ParameterName =":LOCAT_HJ";
			parameters[36].Size = 120;
			parameters[36].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[36].Value = obj.LOCAT_HJ == null ? String.Empty:obj.LOCAT_HJ;
			parameters[37] = new OracleParameter();
			parameters[37].ParameterName =":ZHRZWJS";
			parameters[37].Size = 1200;
			parameters[37].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[37].Value = obj.ZHRZWJS == null ? String.Empty:obj.ZHRZWJS;
            parameters[38] = new OracleParameter();
            parameters[38].ParameterName = ":YJSSXXX";
            parameters[38].Size = 300;
            parameters[38].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[38].Value = obj.YJSSXXX == null ? String.Empty : obj.YJSSXXX;
            parameters[39] = new OracleParameter();
            parameters[39].ParameterName = ":IS_STANDARD";
            parameters[39].Size = 22;
            parameters[39].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[39].Value = obj.IS_STANDARD;
            parameters[40] = new OracleParameter();
            parameters[40].ParameterName = ":IS_SZHY";
            parameters[40].Size = 22;
            parameters[40].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[40].Value = obj.IS_SZHY;

			parameters[41] = new OracleParameter();
			parameters[41].ParameterName = ":SCHOOLINFO";
			parameters[41].Size = 1200;
			parameters[41].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[41].Value = obj.SCHOOLINFO == null ? String.Empty : obj.SCHOOLINFO;

			parameters[42] = new OracleParameter();
			parameters[42].ParameterName = ":JWBS";
			parameters[42].Size = 50;
			parameters[42].OracleType = System.Data.OracleClient.OracleType.VarChar;
			parameters[42].Value = obj.JWBS == null ? String.Empty : obj.JWBS;

			#endregion
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_STAFF obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_STAFF set ";
			sSql += PrepareUpdate(obj, out parameters,true);
			sSql += " where  ID = :U_ID ";
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Update(EntityObject_HEM_B_STAFF obj,CauseObject_HEM_B_STAFF cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			List<OracleParameter> list = new List<OracleParameter>();
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "update HEM_B_STAFF set ";
			sSql += PrepareUpdate(obj, out parameters,false);
			list.AddRange(parameters);
			sSql += " where 1=1 ";
			sSql += PrepareCause(cause, out parameters);
			list.AddRange(parameters);
			parameters = list.ToArray();
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static int Delete(EntityObject_HEM_B_STAFF obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "delete from HEM_B_STAFF where  ID = :ID ";
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
		public static int Delete(CauseObject_HEM_B_STAFF cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion
			string sSql = "delete from HEM_B_STAFF where (1=1)";
			sSql += PrepareCause(cause, out parameters);
			return IDALProvider.IDAL.ExecuteNonQuery(sSql,parameters,trans);
		}
		public static EntityObject_HEM_B_STAFF Get(EntityObject_HEM_B_STAFF obj)
		{
			
			//平台自动生成代码
			string sSql = "select  FIRSTCHOICE, ZHRTC, ZHRYRXX, USRID_MAIL, GBDAT, LOCAT_JT, USER_ID, ZHRGRSG, ID, FAMST, ZHRHJJL, ZHRSXXX, ZHRSLJZ, USRID_TEL, ZHRJSJSP, ZHRWYFS, ZHRGZNX, FGBDT, FANAM, ICNUM, GESCH, ZHRWYSP, NACHN, ANZKD, ZHRBZ, TELNR, FASEX, ZHRJKZK, SECONDCHOICE, PCODE, ZHRGRTZ, LOCAT_XJ, ZHRTZGG, ZHRFZDJ, ZHRJG, RACKY, LOCAT_HJ, ZHRZWJS , SCHOOLINFO, JWBS from HEM_B_STAFF where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRTC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRYRXX = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USRID_MAIL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GBDAT = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LOCAT_JT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ZHRGRSG = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.FAMST = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ZHRHJJL = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRSXXX = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.USRID_TEL = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ZHRJSJSP = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ZHRWYFS = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ZHRGZNX = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.FGBDT = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FANAM = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ICNUM = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.GESCH = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ZHRWYSP = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NACHN = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ANZKD = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.ZHRBZ = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.TELNR = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FASEX = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.ZHRJKZK = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PCODE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.ZHRGRTZ = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.LOCAT_XJ = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.ZHRTZGG = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ZHRFZDJ = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.ZHRJG = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.RACKY = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.LOCAT_HJ = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ZHRZWJS = sqlReader.GetString(37);
				if (!sqlReader.IsDBNull(38))
					dataObj.SCHOOLINFO = sqlReader.GetString(38);
				if (!sqlReader.IsDBNull(39))
					dataObj.JWBS = sqlReader.GetString(39);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			EntityObject_HEM_B_STAFF[] objs = new EntityObject_HEM_B_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static EntityObject_HEM_B_STAFF Get(EntityObject_HEM_B_STAFF obj,IDbTransaction trans)
		{
			
			//平台自动生成代码
			string sSql = "select  FIRSTCHOICE, ZHRTC, ZHRYRXX, USRID_MAIL, GBDAT, LOCAT_JT, USER_ID, ZHRGRSG, ID, FAMST, ZHRHJJL, ZHRSXXX, ZHRSLJZ, USRID_TEL, ZHRJSJSP, ZHRWYFS, ZHRGZNX, FGBDT, FANAM, ICNUM, GESCH, ZHRWYSP, NACHN, ANZKD, ZHRBZ, TELNR, FASEX, ZHRJKZK, SECONDCHOICE, PCODE, ZHRGRTZ, LOCAT_XJ, ZHRTZGG, ZHRFZDJ, ZHRJG, RACKY, LOCAT_HJ, ZHRZWJS, SCHOOLINFO, JWBS from HEM_B_STAFF where  ID = :ID ";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[1];
			parameters[0] = new OracleParameter();
			parameters[0].ParameterName =":ID";
			parameters[0].Size = 36;
			parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
			parameters[0].Value = obj.ID;
			#endregion 
			#region Push Block
			EntityObject_HEM_B_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new EntityObject_HEM_B_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRTC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRYRXX = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USRID_MAIL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GBDAT = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LOCAT_JT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ZHRGRSG = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.FAMST = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ZHRHJJL = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRSXXX = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.USRID_TEL = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ZHRJSJSP = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ZHRWYFS = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ZHRGZNX = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.FGBDT = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FANAM = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ICNUM = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.GESCH = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ZHRWYSP = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NACHN = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ANZKD = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.ZHRBZ = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.TELNR = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FASEX = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.ZHRJKZK = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PCODE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.ZHRGRTZ = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.LOCAT_XJ = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.ZHRTZGG = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ZHRFZDJ = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.ZHRJG = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.RACKY = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.LOCAT_HJ = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ZHRZWJS = sqlReader.GetString(37);
				if (!sqlReader.IsDBNull(38))
					dataObj.SCHOOLINFO = sqlReader.GetString(38);
				if (!sqlReader.IsDBNull(39))
					dataObj.JWBS = sqlReader.GetString(39);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			EntityObject_HEM_B_STAFF[] objs = new EntityObject_HEM_B_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs.Length == 0 ? null:objs[0];
		}
		public static DisplayObject_HEM_B_STAFF[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  HEM_B_STAFF.FIRSTCHOICE, HEM_B_STAFF.ZHRTC, HEM_B_STAFF.ZHRYRXX, HEM_B_STAFF.USRID_MAIL, HEM_B_STAFF.GBDAT, HEM_B_STAFF.LOCAT_JT, HEM_B_STAFF.USER_ID, HEM_B_STAFF.ZHRGRSG, HEM_B_STAFF.ID, HEM_B_STAFF.FAMST, HEM_B_STAFF.ZHRHJJL, HEM_B_STAFF.ZHRSXXX, HEM_B_STAFF.ZHRSLJZ, HEM_B_STAFF.USRID_TEL, HEM_B_STAFF.ZHRJSJSP, HEM_B_STAFF.ZHRWYFS, HEM_B_STAFF.ZHRGZNX, HEM_B_STAFF.FGBDT, HEM_B_STAFF.FANAM, HEM_B_STAFF.ICNUM, HEM_B_STAFF.GESCH, HEM_B_STAFF.ZHRWYSP, HEM_B_STAFF.NACHN, HEM_B_STAFF.ANZKD, HEM_B_STAFF.ZHRBZ, HEM_B_STAFF.TELNR, HEM_B_STAFF.FASEX, HEM_B_STAFF.ZHRJKZK, HEM_B_STAFF.SECONDCHOICE, HEM_B_STAFF.PCODE, HEM_B_STAFF.ZHRGRTZ, HEM_B_STAFF.LOCAT_XJ, HEM_B_STAFF.ZHRTZGG, HEM_B_STAFF.ZHRFZDJ, HEM_B_STAFF.ZHRJG, HEM_B_STAFF.RACKY, HEM_B_STAFF.LOCAT_HJ, HEM_B_STAFF.ZHRZWJS,HEM_B_STAFF.SCHOOLINFO, HEM_B_STAFF.JWBS from HEM_B_STAFF where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_HEM_B_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRTC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRYRXX = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USRID_MAIL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GBDAT = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LOCAT_JT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ZHRGRSG = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.FAMST = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ZHRHJJL = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRSXXX = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.USRID_TEL = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ZHRJSJSP = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ZHRWYFS = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ZHRGZNX = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.FGBDT = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FANAM = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ICNUM = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.GESCH = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ZHRWYSP = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NACHN = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ANZKD = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.ZHRBZ = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.TELNR = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FASEX = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.ZHRJKZK = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PCODE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.ZHRGRTZ = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.LOCAT_XJ = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.ZHRTZGG = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ZHRFZDJ = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.ZHRJG = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.RACKY = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.LOCAT_HJ = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ZHRZWJS = sqlReader.GetString(37);
				if (!sqlReader.IsDBNull(38))
					dataObj.SCHOOLINFO = sqlReader.GetString(38);
				if (!sqlReader.IsDBNull(39))
					dataObj.JWBS = sqlReader.GetString(39);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF[] objs = new DisplayObject_HEM_B_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_HEM_B_STAFF cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(!string.IsNullOrEmpty(cause.FIRSTCHOICE))
			{
				strBuf.Append(" And HEM_B_STAFF.FIRSTCHOICE ").Append((cause.FIRSTCHOICE.StartsWith("%") || cause.FIRSTCHOICE.EndsWith("%")) ? " like " : " = ").Append(" :C_FIRSTCHOICE");
				param = new OracleParameter();
				param.ParameterName =":C_FIRSTCHOICE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.FIRSTCHOICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FIRSTCHOICE"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "FIRSTCHOICE"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRTC))
			{
				strBuf.Append(" And HEM_B_STAFF.ZHRTC ").Append((cause.ZHRTC.StartsWith("%") || cause.ZHRTC.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRTC");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRTC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 600;
				param.Value = cause.ZHRTC;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRTC"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ZHRTC"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRYRXX))
			{
				strBuf.Append(" And HEM_B_STAFF.ZHRYRXX ").Append((cause.ZHRYRXX.StartsWith("%") || cause.ZHRYRXX.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRYRXX");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRYRXX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.ZHRYRXX;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRYRXX"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ZHRYRXX"));
			}
			if(!string.IsNullOrEmpty(cause.USRID_MAIL))
			{
				strBuf.Append(" And HEM_B_STAFF.USRID_MAIL ").Append((cause.USRID_MAIL.StartsWith("%") || cause.USRID_MAIL.EndsWith("%")) ? " like " : " = ").Append(" :C_USRID_MAIL");
				param = new OracleParameter();
				param.ParameterName =":C_USRID_MAIL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.USRID_MAIL;
				paramList.Add(param);
			}
			if (cause.HasINValue("USRID_MAIL"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "USRID_MAIL"));
			}
			if(cause.GBDAT!= null)
			{
				if (cause.GBDAT.Begin != null)
				{
					strBuf.Append(" And HEM_B_STAFF.GBDAT >= :C_GBDAT_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_GBDAT_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.GBDAT.Begin;
					paramList.Add(param);
				}
				if (cause.GBDAT.End != null)
				{
					strBuf.Append(" And HEM_B_STAFF.GBDAT < :C_GBDAT_END");
					param = new OracleParameter();
					param.ParameterName = ":C_GBDAT_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.GBDAT.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("GBDAT"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "GBDAT"));
			}
			if(!string.IsNullOrEmpty(cause.LOCAT_JT))
			{
				strBuf.Append(" And HEM_B_STAFF.LOCAT_JT ").Append((cause.LOCAT_JT.StartsWith("%") || cause.LOCAT_JT.EndsWith("%")) ? " like " : " = ").Append(" :C_LOCAT_JT");
				param = new OracleParameter();
				param.ParameterName =":C_LOCAT_JT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.LOCAT_JT;
				paramList.Add(param);
			}
			if (cause.HasINValue("LOCAT_JT"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "LOCAT_JT"));
			}
			if(!string.IsNullOrEmpty(cause.USER_ID))
			{
				strBuf.Append(" And HEM_B_STAFF.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRGRSG))
			{
				strBuf.Append(" And HEM_B_STAFF.ZHRGRSG ").Append((cause.ZHRGRSG.StartsWith("%") || cause.ZHRGRSG.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRGRSG");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRGRSG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.ZHRGRSG;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRGRSG"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ZHRGRSG"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And HEM_B_STAFF.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.FAMST))
			{
				strBuf.Append(" And HEM_B_STAFF.FAMST ").Append((cause.FAMST.StartsWith("%") || cause.FAMST.EndsWith("%")) ? " like " : " = ").Append(" :C_FAMST");
				param = new OracleParameter();
				param.ParameterName =":C_FAMST";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.FAMST;
				paramList.Add(param);
			}
			if (cause.HasINValue("FAMST"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "FAMST"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRHJJL))
			{
				strBuf.Append(" And HEM_B_STAFF.ZHRHJJL ").Append((cause.ZHRHJJL.StartsWith("%") || cause.ZHRHJJL.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRHJJL");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRHJJL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 600;
				param.Value = cause.ZHRHJJL;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRHJJL"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ZHRHJJL"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRSXXX))
			{
				strBuf.Append(" And HEM_B_STAFF.ZHRSXXX ").Append((cause.ZHRSXXX.StartsWith("%") || cause.ZHRSXXX.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRSXXX");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRSXXX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.ZHRSXXX;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRSXXX"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ZHRSXXX"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRSLJZ))
			{
				strBuf.Append(" And HEM_B_STAFF.ZHRSLJZ ").Append((cause.ZHRSLJZ.StartsWith("%") || cause.ZHRSLJZ.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRSLJZ");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRSLJZ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.ZHRSLJZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRSLJZ"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ZHRSLJZ"));
			}
			if(!string.IsNullOrEmpty(cause.USRID_TEL))
			{
				strBuf.Append(" And HEM_B_STAFF.USRID_TEL ").Append((cause.USRID_TEL.StartsWith("%") || cause.USRID_TEL.EndsWith("%")) ? " like " : " = ").Append(" :C_USRID_TEL");
				param = new OracleParameter();
				param.ParameterName =":C_USRID_TEL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = cause.USRID_TEL;
				paramList.Add(param);
			}
			if (cause.HasINValue("USRID_TEL"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "USRID_TEL"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRJSJSP))
			{
				strBuf.Append(" And HEM_B_STAFF.ZHRJSJSP ").Append((cause.ZHRJSJSP.StartsWith("%") || cause.ZHRJSJSP.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRJSJSP");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRJSJSP";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.ZHRJSJSP;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRJSJSP"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ZHRJSJSP"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRWYFS))
			{
				strBuf.Append(" And HEM_B_STAFF.ZHRWYFS ").Append((cause.ZHRWYFS.StartsWith("%") || cause.ZHRWYFS.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRWYFS");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRWYFS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 16;
				param.Value = cause.ZHRWYFS;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRWYFS"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ZHRWYFS"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRGZNX))
			{
				strBuf.Append(" And HEM_B_STAFF.ZHRGZNX ").Append((cause.ZHRGZNX.StartsWith("%") || cause.ZHRGZNX.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRGZNX");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRGZNX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 30;
				param.Value = cause.ZHRGZNX;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRGZNX"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ZHRGZNX"));
			}
			if(cause.FGBDT!= null)
			{
				if (cause.FGBDT.Begin != null)
				{
					strBuf.Append(" And HEM_B_STAFF.FGBDT >= :C_FGBDT_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_FGBDT_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.FGBDT.Begin;
					paramList.Add(param);
				}
				if (cause.FGBDT.End != null)
				{
					strBuf.Append(" And HEM_B_STAFF.FGBDT < :C_FGBDT_END");
					param = new OracleParameter();
					param.ParameterName = ":C_FGBDT_END";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.FGBDT.End;
					paramList.Add(param);
				}
			}
			if (cause.HasINValue("FGBDT"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "FGBDT"));
			}
			if(!string.IsNullOrEmpty(cause.FANAM))
			{
				strBuf.Append(" And HEM_B_STAFF.FANAM ").Append((cause.FANAM.StartsWith("%") || cause.FANAM.EndsWith("%")) ? " like " : " = ").Append(" :C_FANAM");
				param = new OracleParameter();
				param.ParameterName =":C_FANAM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.FANAM;
				paramList.Add(param);
			}
			if (cause.HasINValue("FANAM"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "FANAM"));
			}
			if(!string.IsNullOrEmpty(cause.ICNUM))
			{
				strBuf.Append(" And HEM_B_STAFF.ICNUM ").Append((cause.ICNUM.StartsWith("%") || cause.ICNUM.EndsWith("%")) ? " like " : " = ").Append(" :C_ICNUM");
				param = new OracleParameter();
				param.ParameterName =":C_ICNUM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 30;
				param.Value = cause.ICNUM;
				paramList.Add(param);
			}
			if (cause.HasINValue("ICNUM"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ICNUM"));
			}
			if(!string.IsNullOrEmpty(cause.GESCH))
			{
				strBuf.Append(" And HEM_B_STAFF.GESCH ").Append((cause.GESCH.StartsWith("%") || cause.GESCH.EndsWith("%")) ? " like " : " = ").Append(" :C_GESCH");
				param = new OracleParameter();
				param.ParameterName =":C_GESCH";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.GESCH;
				paramList.Add(param);
			}
			if (cause.HasINValue("GESCH"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "GESCH"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRWYSP))
			{
				strBuf.Append(" And HEM_B_STAFF.ZHRWYSP ").Append((cause.ZHRWYSP.StartsWith("%") || cause.ZHRWYSP.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRWYSP");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRWYSP";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.ZHRWYSP;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRWYSP"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ZHRWYSP"));
			}
			if(!string.IsNullOrEmpty(cause.NACHN))
			{
				strBuf.Append(" And HEM_B_STAFF.NACHN ").Append((cause.NACHN.StartsWith("%") || cause.NACHN.EndsWith("%")) ? " like " : " = ").Append(" :C_NACHN");
				param = new OracleParameter();
				param.ParameterName =":C_NACHN";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.NACHN;
				paramList.Add(param);
			}
			if (cause.HasINValue("NACHN"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "NACHN"));
			}
			if(cause.ANZKD!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And HEM_B_STAFF.ANZKD = :C_ANZKD");
				param = new OracleParameter();
				param.ParameterName =":C_ANZKD";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ANZKD;
				paramList.Add(param);
			}
			if (cause.HasINValue("ANZKD"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ANZKD"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRBZ))
			{
				strBuf.Append(" And HEM_B_STAFF.ZHRBZ ").Append((cause.ZHRBZ.StartsWith("%") || cause.ZHRBZ.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRBZ");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRBZ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 600;
				param.Value = cause.ZHRBZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRBZ"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ZHRBZ"));
			}
			if(!string.IsNullOrEmpty(cause.TELNR))
			{
				strBuf.Append(" And HEM_B_STAFF.TELNR ").Append((cause.TELNR.StartsWith("%") || cause.TELNR.EndsWith("%")) ? " like " : " = ").Append(" :C_TELNR");
				param = new OracleParameter();
				param.ParameterName =":C_TELNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = cause.TELNR;
				paramList.Add(param);
			}
			if (cause.HasINValue("TELNR"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "TELNR"));
			}
			if(!string.IsNullOrEmpty(cause.FASEX))
			{
				strBuf.Append(" And HEM_B_STAFF.FASEX ").Append((cause.FASEX.StartsWith("%") || cause.FASEX.EndsWith("%")) ? " like " : " = ").Append(" :C_FASEX");
				param = new OracleParameter();
				param.ParameterName =":C_FASEX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.FASEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("FASEX"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "FASEX"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRJKZK))
			{
				strBuf.Append(" And HEM_B_STAFF.ZHRJKZK ").Append((cause.ZHRJKZK.StartsWith("%") || cause.ZHRJKZK.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRJKZK");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRJKZK";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 30;
				param.Value = cause.ZHRJKZK;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRJKZK"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ZHRJKZK"));
			}
			if(!string.IsNullOrEmpty(cause.SECONDCHOICE))
			{
				strBuf.Append(" And HEM_B_STAFF.SECONDCHOICE ").Append((cause.SECONDCHOICE.StartsWith("%") || cause.SECONDCHOICE.EndsWith("%")) ? " like " : " = ").Append(" :C_SECONDCHOICE");
				param = new OracleParameter();
				param.ParameterName =":C_SECONDCHOICE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.SECONDCHOICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SECONDCHOICE"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "SECONDCHOICE"));
			}
			if(!string.IsNullOrEmpty(cause.PCODE))
			{
				strBuf.Append(" And HEM_B_STAFF.PCODE ").Append((cause.PCODE.StartsWith("%") || cause.PCODE.EndsWith("%")) ? " like " : " = ").Append(" :C_PCODE");
				param = new OracleParameter();
				param.ParameterName =":C_PCODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = cause.PCODE;
				paramList.Add(param);
			}
			if (cause.HasINValue("PCODE"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "PCODE"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRGRTZ))
			{
				strBuf.Append(" And HEM_B_STAFF.ZHRGRTZ ").Append((cause.ZHRGRTZ.StartsWith("%") || cause.ZHRGRTZ.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRGRTZ");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRGRTZ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.ZHRGRTZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRGRTZ"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ZHRGRTZ"));
			}
			if(!string.IsNullOrEmpty(cause.LOCAT_XJ))
			{
				strBuf.Append(" And HEM_B_STAFF.LOCAT_XJ ").Append((cause.LOCAT_XJ.StartsWith("%") || cause.LOCAT_XJ.EndsWith("%")) ? " like " : " = ").Append(" :C_LOCAT_XJ");
				param = new OracleParameter();
				param.ParameterName =":C_LOCAT_XJ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.LOCAT_XJ;
				paramList.Add(param);
			}
			if (cause.HasINValue("LOCAT_XJ"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "LOCAT_XJ"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRTZGG))
			{
				strBuf.Append(" And HEM_B_STAFF.ZHRTZGG ").Append((cause.ZHRTZGG.StartsWith("%") || cause.ZHRTZGG.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRTZGG");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRTZGG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 4;
				param.Value = cause.ZHRTZGG;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRTZGG"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ZHRTZGG"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRFZDJ))
			{
				strBuf.Append(" And HEM_B_STAFF.ZHRFZDJ ").Append((cause.ZHRFZDJ.StartsWith("%") || cause.ZHRFZDJ.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRFZDJ");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRFZDJ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.ZHRFZDJ;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRFZDJ"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ZHRFZDJ"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRJG))
			{
				strBuf.Append(" And HEM_B_STAFF.ZHRJG ").Append((cause.ZHRJG.StartsWith("%") || cause.ZHRJG.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRJG");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRJG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.ZHRJG;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRJG"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ZHRJG"));
			}
			if(!string.IsNullOrEmpty(cause.RACKY))
			{
				strBuf.Append(" And HEM_B_STAFF.RACKY ").Append((cause.RACKY.StartsWith("%") || cause.RACKY.EndsWith("%")) ? " like " : " = ").Append(" :C_RACKY");
				param = new OracleParameter();
				param.ParameterName =":C_RACKY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = cause.RACKY;
				paramList.Add(param);
			}
			if (cause.HasINValue("RACKY"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "RACKY"));
			}
			if(!string.IsNullOrEmpty(cause.LOCAT_HJ))
			{
				strBuf.Append(" And HEM_B_STAFF.LOCAT_HJ ").Append((cause.LOCAT_HJ.StartsWith("%") || cause.LOCAT_HJ.EndsWith("%")) ? " like " : " = ").Append(" :C_LOCAT_HJ");
				param = new OracleParameter();
				param.ParameterName =":C_LOCAT_HJ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.LOCAT_HJ;
				paramList.Add(param);
			}
			if (cause.HasINValue("LOCAT_HJ"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "LOCAT_HJ"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRZWJS))
			{
				strBuf.Append(" And HEM_B_STAFF.ZHRZWJS ").Append((cause.ZHRZWJS.StartsWith("%") || cause.ZHRZWJS.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRZWJS");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRZWJS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1200;
				param.Value = cause.ZHRZWJS;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRZWJS"))
			{
				strBuf.Append(cause.GetINSQL("HEM_B_STAFF", "ZHRZWJS"));
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
		public static DisplayObject_HEM_B_STAFF[] Query(CauseObject_HEM_B_STAFF cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF.FIRSTCHOICE, HEM_B_STAFF.ZHRTC, HEM_B_STAFF.ZHRYRXX, HEM_B_STAFF.USRID_MAIL, HEM_B_STAFF.GBDAT, HEM_B_STAFF.LOCAT_JT, HEM_B_STAFF.USER_ID, HEM_B_STAFF.ZHRGRSG, HEM_B_STAFF.ID, HEM_B_STAFF.FAMST, HEM_B_STAFF.ZHRHJJL, HEM_B_STAFF.ZHRSXXX, HEM_B_STAFF.ZHRSLJZ, HEM_B_STAFF.USRID_TEL, HEM_B_STAFF.ZHRJSJSP, HEM_B_STAFF.ZHRWYFS, HEM_B_STAFF.ZHRGZNX, HEM_B_STAFF.FGBDT, HEM_B_STAFF.FANAM, HEM_B_STAFF.ICNUM, HEM_B_STAFF.GESCH, HEM_B_STAFF.ZHRWYSP, HEM_B_STAFF.NACHN, HEM_B_STAFF.ANZKD, HEM_B_STAFF.ZHRBZ, HEM_B_STAFF.TELNR, HEM_B_STAFF.FASEX, HEM_B_STAFF.ZHRJKZK, HEM_B_STAFF.SECONDCHOICE, HEM_B_STAFF.PCODE, HEM_B_STAFF.ZHRGRTZ, HEM_B_STAFF.LOCAT_XJ, HEM_B_STAFF.ZHRTZGG, HEM_B_STAFF.ZHRFZDJ, HEM_B_STAFF.ZHRJG, HEM_B_STAFF.RACKY, HEM_B_STAFF.LOCAT_HJ, HEM_B_STAFF.ZHRZWJS, HEM_B_STAFF.SCHOOLINFO, HEM_B_STAFF.JWBS from HEM_B_STAFF where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRTC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRYRXX = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USRID_MAIL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GBDAT = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LOCAT_JT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ZHRGRSG = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.FAMST = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ZHRHJJL = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRSXXX = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.USRID_TEL = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ZHRJSJSP = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ZHRWYFS = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ZHRGZNX = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.FGBDT = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FANAM = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ICNUM = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.GESCH = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ZHRWYSP = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NACHN = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ANZKD = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.ZHRBZ = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.TELNR = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FASEX = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.ZHRJKZK = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PCODE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.ZHRGRTZ = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.LOCAT_XJ = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.ZHRTZGG = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ZHRFZDJ = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.ZHRJG = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.RACKY = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.LOCAT_HJ = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ZHRZWJS = sqlReader.GetString(37);
				if (!sqlReader.IsDBNull(38))
					dataObj.SCHOOLINFO = sqlReader.GetString(38);
				if (!sqlReader.IsDBNull(39))
					dataObj.JWBS = sqlReader.GetString(39);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF[] objs = new DisplayObject_HEM_B_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		
		public static DisplayObject_HEM_B_STAFF[] Query(CauseObject_HEM_B_STAFF cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF.FIRSTCHOICE, HEM_B_STAFF.ZHRTC, HEM_B_STAFF.ZHRYRXX, HEM_B_STAFF.USRID_MAIL, HEM_B_STAFF.GBDAT, HEM_B_STAFF.LOCAT_JT, HEM_B_STAFF.USER_ID, HEM_B_STAFF.ZHRGRSG, HEM_B_STAFF.ID, HEM_B_STAFF.FAMST, HEM_B_STAFF.ZHRHJJL, HEM_B_STAFF.ZHRSXXX, HEM_B_STAFF.ZHRSLJZ, HEM_B_STAFF.USRID_TEL, HEM_B_STAFF.ZHRJSJSP, HEM_B_STAFF.ZHRWYFS, HEM_B_STAFF.ZHRGZNX, HEM_B_STAFF.FGBDT, HEM_B_STAFF.FANAM, HEM_B_STAFF.ICNUM, HEM_B_STAFF.GESCH, HEM_B_STAFF.ZHRWYSP, HEM_B_STAFF.NACHN, HEM_B_STAFF.ANZKD, HEM_B_STAFF.ZHRBZ, HEM_B_STAFF.TELNR, HEM_B_STAFF.FASEX, HEM_B_STAFF.ZHRJKZK, HEM_B_STAFF.SECONDCHOICE, HEM_B_STAFF.PCODE, HEM_B_STAFF.ZHRGRTZ, HEM_B_STAFF.LOCAT_XJ, HEM_B_STAFF.ZHRTZGG, HEM_B_STAFF.ZHRFZDJ, HEM_B_STAFF.ZHRJG, HEM_B_STAFF.RACKY, HEM_B_STAFF.LOCAT_HJ, HEM_B_STAFF.ZHRZWJS, HEM_B_STAFF.SCHOOLINFO, HEM_B_STAFF.JWBS  from HEM_B_STAFF where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_HEM_B_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRTC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRYRXX = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USRID_MAIL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GBDAT = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LOCAT_JT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ZHRGRSG = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.FAMST = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ZHRHJJL = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRSXXX = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.USRID_TEL = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ZHRJSJSP = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ZHRWYFS = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ZHRGZNX = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.FGBDT = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FANAM = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ICNUM = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.GESCH = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ZHRWYSP = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NACHN = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ANZKD = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.ZHRBZ = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.TELNR = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FASEX = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.ZHRJKZK = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PCODE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.ZHRGRTZ = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.LOCAT_XJ = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.ZHRTZGG = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ZHRFZDJ = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.ZHRJG = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.RACKY = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.LOCAT_HJ = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ZHRZWJS = sqlReader.GetString(37);
				if (!sqlReader.IsDBNull(38))
					dataObj.SCHOOLINFO= sqlReader.GetString(38);
				if (!sqlReader.IsDBNull(39))
					dataObj.JWBS = sqlReader.GetString(39);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_STAFF[] objs = new DisplayObject_HEM_B_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_STAFF[] Query(CauseObject_HEM_B_STAFF cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF.FIRSTCHOICE, HEM_B_STAFF.ZHRTC, HEM_B_STAFF.ZHRYRXX, HEM_B_STAFF.USRID_MAIL, HEM_B_STAFF.GBDAT, HEM_B_STAFF.LOCAT_JT, HEM_B_STAFF.USER_ID, HEM_B_STAFF.ZHRGRSG, HEM_B_STAFF.ID, HEM_B_STAFF.FAMST, HEM_B_STAFF.ZHRHJJL, HEM_B_STAFF.ZHRSXXX, HEM_B_STAFF.ZHRSLJZ, HEM_B_STAFF.USRID_TEL, HEM_B_STAFF.ZHRJSJSP, HEM_B_STAFF.ZHRWYFS, HEM_B_STAFF.ZHRGZNX, HEM_B_STAFF.FGBDT, HEM_B_STAFF.FANAM, HEM_B_STAFF.ICNUM, HEM_B_STAFF.GESCH, HEM_B_STAFF.ZHRWYSP, HEM_B_STAFF.NACHN, HEM_B_STAFF.ANZKD, HEM_B_STAFF.ZHRBZ, HEM_B_STAFF.TELNR, HEM_B_STAFF.FASEX, HEM_B_STAFF.ZHRJKZK, HEM_B_STAFF.SECONDCHOICE, HEM_B_STAFF.PCODE, HEM_B_STAFF.ZHRGRTZ, HEM_B_STAFF.LOCAT_XJ, HEM_B_STAFF.ZHRTZGG, HEM_B_STAFF.ZHRFZDJ, HEM_B_STAFF.ZHRJG, HEM_B_STAFF.RACKY, HEM_B_STAFF.LOCAT_HJ, HEM_B_STAFF.ZHRZWJS,HEM_B_STAFF.SCHOOLINFO ,HEM_B_STAFF.JWBS from HEM_B_STAFF where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_STAFF",paging, order, sSql, parameters, connection);
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
			DisplayObject_HEM_B_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRTC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRYRXX = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USRID_MAIL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GBDAT = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LOCAT_JT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ZHRGRSG = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.FAMST = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ZHRHJJL = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRSXXX = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.USRID_TEL = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ZHRJSJSP = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ZHRWYFS = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ZHRGZNX = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.FGBDT = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FANAM = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ICNUM = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.GESCH = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ZHRWYSP = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NACHN = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ANZKD = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.ZHRBZ = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.TELNR = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FASEX = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.ZHRJKZK = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PCODE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.ZHRGRTZ = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.LOCAT_XJ = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.ZHRTZGG = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ZHRFZDJ = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.ZHRJG = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.RACKY = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.LOCAT_HJ = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ZHRZWJS = sqlReader.GetString(37);
				if (!sqlReader.IsDBNull(38))
					dataObj.SCHOOLINFO = sqlReader.GetString(38);
				if (!sqlReader.IsDBNull(39))
					dataObj.JWBS = sqlReader.GetString(39);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_HEM_B_STAFF[] objs = new DisplayObject_HEM_B_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_HEM_B_STAFF[] Query(CauseObject_HEM_B_STAFF cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  HEM_B_STAFF.FIRSTCHOICE, HEM_B_STAFF.ZHRTC, HEM_B_STAFF.ZHRYRXX, HEM_B_STAFF.USRID_MAIL, HEM_B_STAFF.GBDAT, HEM_B_STAFF.LOCAT_JT, HEM_B_STAFF.USER_ID, HEM_B_STAFF.ZHRGRSG, HEM_B_STAFF.ID, HEM_B_STAFF.FAMST, HEM_B_STAFF.ZHRHJJL, HEM_B_STAFF.ZHRSXXX, HEM_B_STAFF.ZHRSLJZ, HEM_B_STAFF.USRID_TEL, HEM_B_STAFF.ZHRJSJSP, HEM_B_STAFF.ZHRWYFS, HEM_B_STAFF.ZHRGZNX, HEM_B_STAFF.FGBDT, HEM_B_STAFF.FANAM, HEM_B_STAFF.ICNUM, HEM_B_STAFF.GESCH, HEM_B_STAFF.ZHRWYSP, HEM_B_STAFF.NACHN, HEM_B_STAFF.ANZKD, HEM_B_STAFF.ZHRBZ, HEM_B_STAFF.TELNR, HEM_B_STAFF.FASEX, HEM_B_STAFF.ZHRJKZK, HEM_B_STAFF.SECONDCHOICE, HEM_B_STAFF.PCODE, HEM_B_STAFF.ZHRGRTZ, HEM_B_STAFF.LOCAT_XJ, HEM_B_STAFF.ZHRTZGG, HEM_B_STAFF.ZHRFZDJ, HEM_B_STAFF.ZHRJG, HEM_B_STAFF.RACKY, HEM_B_STAFF.LOCAT_HJ, HEM_B_STAFF.ZHRZWJS, HEM_B_STAFF.SCHOOLINFO, HEM_B_STAFF.JWBS  from HEM_B_STAFF where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_STAFF",paging, order, sSql, parameters, trans);
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
			DisplayObject_HEM_B_STAFF dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_HEM_B_STAFF();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.ZHRTC = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.ZHRYRXX = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.USRID_MAIL = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.GBDAT = sqlReader.GetDateTime(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.LOCAT_JT = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.USER_ID = sqlReader.GetString(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.ZHRGRSG = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.ID = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.FAMST = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ZHRHJJL = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.ZHRSXXX = sqlReader.GetString(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.USRID_TEL = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.ZHRJSJSP = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.ZHRWYFS = sqlReader.GetString(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.ZHRGZNX = sqlReader.GetString(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.FGBDT = sqlReader.GetDateTime(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.FANAM = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.ICNUM = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.GESCH = sqlReader.GetString(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ZHRWYSP = sqlReader.GetString(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.NACHN = sqlReader.GetString(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.ANZKD = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.ZHRBZ = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.TELNR = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.FASEX = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.ZHRJKZK = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.PCODE = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.ZHRGRTZ = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.LOCAT_XJ = sqlReader.GetString(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.ZHRTZGG = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.ZHRFZDJ = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.ZHRJG = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.RACKY = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.LOCAT_HJ = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.ZHRZWJS = sqlReader.GetString(37);
				if (!sqlReader.IsDBNull(38))
					dataObj.SCHOOLINFO = sqlReader.GetString(38);
				if (!sqlReader.IsDBNull(39))
					dataObj.SCHOOLINFO = sqlReader.GetString(39);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_HEM_B_STAFF[] objs = new DisplayObject_HEM_B_STAFF[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareUpdate(EntityObject_HEM_B_STAFF obj, out OracleParameter[] parameters,bool appendpk)
        {
            
			//平台自动生成代码
			List<string> strBuf = new List<string>();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if (!obj.IsNotUpdate("FIRSTCHOICE"))
			{
				strBuf.Add("  HEM_B_STAFF.FIRSTCHOICE = :U_FIRSTCHOICE");
				param = new OracleParameter();
				param.ParameterName = ":U_FIRSTCHOICE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = string.IsNullOrEmpty(obj.FIRSTCHOICE) ? string.Empty : obj.FIRSTCHOICE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRTC"))
			{
				strBuf.Add("  HEM_B_STAFF.ZHRTC = :U_ZHRTC");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRTC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 600;
				param.Value = string.IsNullOrEmpty(obj.ZHRTC) ? string.Empty : obj.ZHRTC;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRYRXX"))
			{
				strBuf.Add("  HEM_B_STAFF.ZHRYRXX = :U_ZHRYRXX");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRYRXX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = string.IsNullOrEmpty(obj.ZHRYRXX) ? string.Empty : obj.ZHRYRXX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USRID_MAIL"))
			{
				strBuf.Add("  HEM_B_STAFF.USRID_MAIL = :U_USRID_MAIL");
				param = new OracleParameter();
				param.ParameterName = ":U_USRID_MAIL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = string.IsNullOrEmpty(obj.USRID_MAIL) ? string.Empty : obj.USRID_MAIL;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GBDAT"))
			{
				strBuf.Add("  HEM_B_STAFF.GBDAT = :U_GBDAT");
				param = new OracleParameter();
				param.ParameterName = ":U_GBDAT";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.GBDAT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("LOCAT_JT"))
			{
				strBuf.Add("  HEM_B_STAFF.LOCAT_JT = :U_LOCAT_JT");
				param = new OracleParameter();
				param.ParameterName = ":U_LOCAT_JT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = string.IsNullOrEmpty(obj.LOCAT_JT) ? string.Empty : obj.LOCAT_JT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USER_ID"))
			{
				strBuf.Add("  HEM_B_STAFF.USER_ID = :U_USER_ID");
				param = new OracleParameter();
				param.ParameterName = ":U_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = string.IsNullOrEmpty(obj.USER_ID) ? string.Empty : obj.USER_ID;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRGRSG"))
			{
				strBuf.Add("  HEM_B_STAFF.ZHRGRSG = :U_ZHRGRSG");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRGRSG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.ZHRGRSG) ? string.Empty : obj.ZHRGRSG;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FAMST"))
			{
				strBuf.Add("  HEM_B_STAFF.FAMST = :U_FAMST");
				param = new OracleParameter();
				param.ParameterName = ":U_FAMST";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = string.IsNullOrEmpty(obj.FAMST) ? string.Empty : obj.FAMST;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRHJJL"))
			{
				strBuf.Add("  HEM_B_STAFF.ZHRHJJL = :U_ZHRHJJL");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRHJJL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 600;
				param.Value = string.IsNullOrEmpty(obj.ZHRHJJL) ? string.Empty : obj.ZHRHJJL;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRSXXX"))
			{
				strBuf.Add("  HEM_B_STAFF.ZHRSXXX = :U_ZHRSXXX");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRSXXX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = string.IsNullOrEmpty(obj.ZHRSXXX) ? string.Empty : obj.ZHRSXXX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRSLJZ"))
			{
				strBuf.Add("  HEM_B_STAFF.ZHRSLJZ = :U_ZHRSLJZ");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRSLJZ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.ZHRSLJZ) ? string.Empty : obj.ZHRSLJZ;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("USRID_TEL"))
			{
				strBuf.Add("  HEM_B_STAFF.USRID_TEL = :U_USRID_TEL");
				param = new OracleParameter();
				param.ParameterName = ":U_USRID_TEL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = string.IsNullOrEmpty(obj.USRID_TEL) ? string.Empty : obj.USRID_TEL;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRJSJSP"))
			{
				strBuf.Add("  HEM_B_STAFF.ZHRJSJSP = :U_ZHRJSJSP");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRJSJSP";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = string.IsNullOrEmpty(obj.ZHRJSJSP) ? string.Empty : obj.ZHRJSJSP;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRWYFS"))
			{
				strBuf.Add("  HEM_B_STAFF.ZHRWYFS = :U_ZHRWYFS");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRWYFS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 16;
				param.Value = string.IsNullOrEmpty(obj.ZHRWYFS) ? string.Empty : obj.ZHRWYFS;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRGZNX"))
			{
				strBuf.Add("  HEM_B_STAFF.ZHRGZNX = :U_ZHRGZNX");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRGZNX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 30;
				param.Value = string.IsNullOrEmpty(obj.ZHRGZNX) ? string.Empty : obj.ZHRGZNX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FGBDT"))
			{
				strBuf.Add("  HEM_B_STAFF.FGBDT = :U_FGBDT");
				param = new OracleParameter();
				param.ParameterName = ":U_FGBDT";
				param.OracleType = System.Data.OracleClient.OracleType.DateTime;
				param.Size = 7;
				param.Value = obj.FGBDT;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FANAM"))
			{
				strBuf.Add("  HEM_B_STAFF.FANAM = :U_FANAM");
				param = new OracleParameter();
				param.ParameterName = ":U_FANAM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = string.IsNullOrEmpty(obj.FANAM) ? string.Empty : obj.FANAM;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ICNUM"))
			{
				strBuf.Add("  HEM_B_STAFF.ICNUM = :U_ICNUM");
				param = new OracleParameter();
				param.ParameterName = ":U_ICNUM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 30;
				param.Value = string.IsNullOrEmpty(obj.ICNUM) ? string.Empty : obj.ICNUM;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("GESCH"))
			{
				strBuf.Add("  HEM_B_STAFF.GESCH = :U_GESCH");
				param = new OracleParameter();
				param.ParameterName = ":U_GESCH";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = string.IsNullOrEmpty(obj.GESCH) ? string.Empty : obj.GESCH;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRWYSP"))
			{
				strBuf.Add("  HEM_B_STAFF.ZHRWYSP = :U_ZHRWYSP");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRWYSP";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = string.IsNullOrEmpty(obj.ZHRWYSP) ? string.Empty : obj.ZHRWYSP;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("NACHN"))
			{
				strBuf.Add("  HEM_B_STAFF.NACHN = :U_NACHN");
				param = new OracleParameter();
				param.ParameterName = ":U_NACHN";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = string.IsNullOrEmpty(obj.NACHN) ? string.Empty : obj.NACHN;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ANZKD"))
			{
				strBuf.Add("  HEM_B_STAFF.ANZKD = :U_ANZKD");
				param = new OracleParameter();
				param.ParameterName = ":U_ANZKD";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = obj.ANZKD;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRBZ"))
			{
				strBuf.Add("  HEM_B_STAFF.ZHRBZ = :U_ZHRBZ");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRBZ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 600;
				param.Value = string.IsNullOrEmpty(obj.ZHRBZ) ? string.Empty : obj.ZHRBZ;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("TELNR"))
			{
				strBuf.Add("  HEM_B_STAFF.TELNR = :U_TELNR");
				param = new OracleParameter();
				param.ParameterName = ":U_TELNR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = string.IsNullOrEmpty(obj.TELNR) ? string.Empty : obj.TELNR;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("FASEX"))
			{
				strBuf.Add("  HEM_B_STAFF.FASEX = :U_FASEX");
				param = new OracleParameter();
				param.ParameterName = ":U_FASEX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = string.IsNullOrEmpty(obj.FASEX) ? string.Empty : obj.FASEX;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRJKZK"))
			{
				strBuf.Add("  HEM_B_STAFF.ZHRJKZK = :U_ZHRJKZK");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRJKZK";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 30;
				param.Value = string.IsNullOrEmpty(obj.ZHRJKZK) ? string.Empty : obj.ZHRJKZK;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("SECONDCHOICE"))
			{
				strBuf.Add("  HEM_B_STAFF.SECONDCHOICE = :U_SECONDCHOICE");
				param = new OracleParameter();
				param.ParameterName = ":U_SECONDCHOICE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = string.IsNullOrEmpty(obj.SECONDCHOICE) ? string.Empty : obj.SECONDCHOICE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("PCODE"))
			{
				strBuf.Add("  HEM_B_STAFF.PCODE = :U_PCODE");
				param = new OracleParameter();
				param.ParameterName = ":U_PCODE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = string.IsNullOrEmpty(obj.PCODE) ? string.Empty : obj.PCODE;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRGRTZ"))
			{
				strBuf.Add("  HEM_B_STAFF.ZHRGRTZ = :U_ZHRGRTZ");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRGRTZ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = string.IsNullOrEmpty(obj.ZHRGRTZ) ? string.Empty : obj.ZHRGRTZ;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("LOCAT_XJ"))
			{
				strBuf.Add("  HEM_B_STAFF.LOCAT_XJ = :U_LOCAT_XJ");
				param = new OracleParameter();
				param.ParameterName = ":U_LOCAT_XJ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = string.IsNullOrEmpty(obj.LOCAT_XJ) ? string.Empty : obj.LOCAT_XJ;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRTZGG"))
			{
				strBuf.Add("  HEM_B_STAFF.ZHRTZGG = :U_ZHRTZGG");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRTZGG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 4;
				param.Value = string.IsNullOrEmpty(obj.ZHRTZGG) ? string.Empty : obj.ZHRTZGG;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRFZDJ"))
			{
				strBuf.Add("  HEM_B_STAFF.ZHRFZDJ = :U_ZHRFZDJ");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRFZDJ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = string.IsNullOrEmpty(obj.ZHRFZDJ) ? string.Empty : obj.ZHRFZDJ;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRJG"))
			{
				strBuf.Add("  HEM_B_STAFF.ZHRJG = :U_ZHRJG");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRJG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = string.IsNullOrEmpty(obj.ZHRJG) ? string.Empty : obj.ZHRJG;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("RACKY"))
			{
				strBuf.Add("  HEM_B_STAFF.RACKY = :U_RACKY");
				param = new OracleParameter();
				param.ParameterName = ":U_RACKY";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = string.IsNullOrEmpty(obj.RACKY) ? string.Empty : obj.RACKY;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("LOCAT_HJ"))
			{
				strBuf.Add("  HEM_B_STAFF.LOCAT_HJ = :U_LOCAT_HJ");
				param = new OracleParameter();
				param.ParameterName = ":U_LOCAT_HJ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = string.IsNullOrEmpty(obj.LOCAT_HJ) ? string.Empty : obj.LOCAT_HJ;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("ZHRZWJS"))
			{
				strBuf.Add("  HEM_B_STAFF.ZHRZWJS = :U_ZHRZWJS");
				param = new OracleParameter();
				param.ParameterName = ":U_ZHRZWJS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1200;
				param.Value = string.IsNullOrEmpty(obj.ZHRZWJS) ? string.Empty : obj.ZHRZWJS;
				paramList.Add(param);
			}
            if (!obj.IsNotUpdate("YJSSXXX"))
            {
                strBuf.Add("  HEM_B_STAFF.YJSSXXX = :U_YJSSXXX");
                param = new OracleParameter();
                param.ParameterName = ":U_YJSSXXX";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 300;
                param.Value = string.IsNullOrEmpty(obj.YJSSXXX) ? string.Empty : obj.YJSSXXX;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("IS_STANDARD"))
            {
                strBuf.Add("  HEM_B_STAFF.IS_STANDARD = :IS_STANDARD");
                param = new OracleParameter();
                param.ParameterName = ":IS_STANDARD";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = obj.IS_STANDARD;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("IS_SZHY"))
            {
                strBuf.Add("  HEM_B_STAFF.IS_SZHY = :IS_SZHY");
                param = new OracleParameter();
                param.ParameterName = ":IS_SZHY";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = obj.IS_SZHY;
                paramList.Add(param);
            }
            //pk here
            if (appendpk)
			{
				param = new OracleParameter();
				param.ParameterName = ":U_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = obj.ID;
				paramList.Add(param);
			}

			if (!obj.IsNotUpdate("SCHOOLINFO"))
			{
				strBuf.Add("  HEM_B_STAFF.SCHOOLINFO = :U_SCHOOLINFO");
				param = new OracleParameter();
				param.ParameterName = ":U_SCHOOLINFO";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1200;
				param.Value = string.IsNullOrEmpty(obj.SCHOOLINFO) ? string.Empty : obj.SCHOOLINFO;
				paramList.Add(param);
			}
			if (!obj.IsNotUpdate("JWBS"))
			{
				strBuf.Add("  HEM_B_STAFF.JWBS = :U_JWBS");
				param = new OracleParameter();
				param.ParameterName = ":U_JWBS";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = string.IsNullOrEmpty(obj.JWBS) ? string.Empty : obj.JWBS;
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
