using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Hrp.Hem.Sap.Entity;
namespace Ipedf.Hrp.Hem.Sap.DataAccess
{
	[CauseObject(typeof(CauseObject_V_HEM_B_STAFF_APPLY_NPOI))]	
	public partial class HelperObject_V_HEM_B_STAFF_APPLY_NPOI
	{		
		#region Method Blok
		public static DisplayObject_V_HEM_B_STAFF_APPLY_NPOI[] List()
		{
			
			//平台自动生成代码
			string sSql = " select  V_HEM_B_STAFF_APPLY_NPOI.IS_PUBLIC, V_HEM_B_STAFF_APPLY_NPOI.SF_GZ_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_ZHRDSXM, V_HEM_B_STAFF_APPLY_NPOI.TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.STAFF_TYPE_ID, V_HEM_B_STAFF_APPLY_NPOI.ESB, V_HEM_B_STAFF_APPLY_NPOI.SEX, V_HEM_B_STAFF_APPLY_NPOI.DT_SS_TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_ZHRJSJSP_NAME, V_HEM_B_STAFF_APPLY_NPOI.ICNUM, V_HEM_B_STAFF_APPLY_NPOI.EQW, V_HEM_B_STAFF_APPLY_NPOI.ZHRJG, V_HEM_B_STAFF_APPLY_NPOI.STAFF_ID, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.STATUS, V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_IS_USABL, V_HEM_B_STAFF_APPLY_NPOI.STATUS_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.DT_BS_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.EYB, V_HEM_B_STAFF_APPLY_NPOI.ZHRTZGG, V_HEM_B_STAFF_APPLY_NPOI.IS_SEND, V_HEM_B_STAFF_APPLY_NPOI.STAFF_IS_NURSE, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_ZHRDSXM, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.GESCH, V_HEM_B_STAFF_APPLY_NPOI.MSSAGE_ID, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.IS_CERTIFICATE, V_HEM_B_STAFF_APPLY_NPOI.CONTENT, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.RACKY_NAME, V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_ID, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.POSTER_ID, V_HEM_B_STAFF_APPLY_NPOI.SECONDCHOICE, V_HEM_B_STAFF_APPLY_NPOI.OPERATOR_ONE, V_HEM_B_STAFF_APPLY_NPOI.ZHRGRTZ, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.SF_ZHRWYSP_NAME, V_HEM_B_STAFF_APPLY_NPOI.ID, V_HEM_B_STAFF_APPLY_NPOI.SF_WORK_SX_ZHRXXDW, V_HEM_B_STAFF_APPLY_NPOI.SF_FAMST_NAME, V_HEM_B_STAFF_APPLY_NPOI.ZHRHJJL, V_HEM_B_STAFF_APPLY_NPOI.SX_ZHRGZNX, V_HEM_B_STAFF_APPLY_NPOI.DT_HH_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.RECRUIT_POSITION, V_HEM_B_STAFF_APPLY_NPOI.ESC, V_HEM_B_STAFF_APPLY_NPOI.SF_WORK_YJ_ZHRXXDW, V_HEM_B_STAFF_APPLY_NPOI.DT_BS_TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.ESA, V_HEM_B_STAFF_APPLY_NPOI.YJ_ZHRGZNX, V_HEM_B_STAFF_APPLY_NPOI.WRITTEN_THEORY, V_HEM_B_STAFF_APPLY_NPOI.EOTHER, V_HEM_B_STAFF_APPLY_NPOI.PCODE_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.CREATE_DATE, V_HEM_B_STAFF_APPLY_NPOI.TYPE_ID, V_HEM_B_STAFF_APPLY_NPOI.GBDAT, V_HEM_B_STAFF_APPLY_NPOI.PRACTICE_TYPE_ID_NAME, V_HEM_B_STAFF_APPLY_NPOI.EHX, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.ZHRSLJZ, V_HEM_B_STAFF_APPLY_NPOI.FIRSTCHOICE, V_HEM_B_STAFF_APPLY_NPOI.DT_SS_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.WRITTEN_ENGLISH, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.ZHRSXXX, V_HEM_B_STAFF_APPLY_NPOI.ESCI, V_HEM_B_STAFF_APPLY_NPOI.DT_BK_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.WRITTEN_TOTAL, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_ZHRDSXM, V_HEM_B_STAFF_APPLY_NPOI.REAL_ZHRGRTZ, V_HEM_B_STAFF_APPLY_NPOI.REAL_ZHRGRSG, V_HEM_B_STAFF_APPLY_NPOI.ZHRGRSG, V_HEM_B_STAFF_APPLY_NPOI.ACCOUNT, V_HEM_B_STAFF_APPLY_NPOI.ZHRTC, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_ID_NAME, V_HEM_B_STAFF_APPLY_NPOI.SEND_ERROR, V_HEM_B_STAFF_APPLY_NPOI.DT_ZG_TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_SLART, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.ZHRWZMC, V_HEM_B_STAFF_APPLY_NPOI.REAL_ZHRSLJZ, V_HEM_B_STAFF_APPLY_NPOI.NACHN, V_HEM_B_STAFF_APPLY_NPOI.USER_ID, V_HEM_B_STAFF_APPLY_NPOI.USRID_MAIL, V_HEM_B_STAFF_APPLY_NPOI.ZHRBZ, V_HEM_B_STAFF_APPLY_NPOI.USER_IS_USABL, V_HEM_B_STAFF_APPLY_NPOI.STAFF_IS_NURSE_NAME, V_HEM_B_STAFF_APPLY_NPOI.USRID_TEL, V_HEM_B_STAFF_APPLY_NPOI.JWBS from V_HEM_B_STAFF_APPLY_NPOI where (1=1)";
			#region Parameters Block
			OracleParameter[] parameters = new OracleParameter[0];
			#endregion 
			#region Push Block
			DisplayObject_V_HEM_B_STAFF_APPLY_NPOI dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_APPLY_NPOI();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SF_GZ_EDUCATION_INSTI = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SF_BS_EDUCATION_INSTI = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SF_SS_EDUCATION_ZHRDSXM = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ESB = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SEX = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DT_SS_TYPE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SF_ZHRJSJSP_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ICNUM = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.EQW = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ZHRJG = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.STAFF_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SF_BK_EDUCATION_INSTI = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATUS = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.STATUS_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.SF_BS_EDUCATION_ZHRXKZY1 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.DT_BS_EDUCATION_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.EYB = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ZHRTZGG = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.IS_SEND = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.SF_BS_EDUCATION_ZHRDSXM = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SF_BS_EDUCATION_ENDDA = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.SF_SS_EDUCATION_INSTI = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.SF_HH_EDUCATION_INSTI = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.GESCH = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.MSSAGE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.SF_BK_EDUCATION_BEGDA = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONTENT = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.SF_HH_EDUCATION_ENDDA = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.RACKY_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.SF_BK_EDUCATION_ZHRXKZY1 = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.SF_SS_EDUCATION_ENDDA = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.POSTER_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.ZHRGRTZ = sqlReader.GetDecimal(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.SF_BS_EDUCATION_BEGDA = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.SF_ZHRWYSP_NAME = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.ID = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.SF_WORK_SX_ZHRXXDW = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.SF_FAMST_NAME = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.ZHRHJJL = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.SX_ZHRGZNX = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.DT_HH_EDUCATION_NAME = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.ESC = sqlReader.GetDecimal(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.SF_WORK_YJ_ZHRXXDW = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.DT_BS_TYPE_NAME = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.ESA = sqlReader.GetDecimal(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.YJ_ZHRGZNX = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.EOTHER = sqlReader.GetDecimal(57);
				if(!sqlReader.IsDBNull(58)) 
					dataObj.PCODE_NAME = sqlReader.GetString(58);
				if(!sqlReader.IsDBNull(59)) 
					dataObj.SF_HH_EDUCATION_BEGDA = sqlReader.GetString(59);
				if(!sqlReader.IsDBNull(60)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(60);
				if(!sqlReader.IsDBNull(61)) 
					dataObj.TYPE_ID = sqlReader.GetString(61);
				if(!sqlReader.IsDBNull(62)) 
					dataObj.GBDAT = sqlReader.GetDateTime(62);
				if(!sqlReader.IsDBNull(63)) 
					dataObj.PRACTICE_TYPE_ID_NAME = sqlReader.GetString(63);
				if(!sqlReader.IsDBNull(64)) 
					dataObj.EHX = sqlReader.GetDecimal(64);
				if(!sqlReader.IsDBNull(65)) 
					dataObj.SF_HH_EDUCATION_ZHRXKZY1 = sqlReader.GetString(65);
				if(!sqlReader.IsDBNull(66)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(66);
				if(!sqlReader.IsDBNull(67)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(67);
				if(!sqlReader.IsDBNull(68)) 
					dataObj.DT_SS_EDUCATION_NAME = sqlReader.GetString(68);
				if(!sqlReader.IsDBNull(69)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(69);
				if(!sqlReader.IsDBNull(70)) 
					dataObj.SF_SS_EDUCATION_ZHRXKZY1 = sqlReader.GetString(70);
				if(!sqlReader.IsDBNull(71)) 
					dataObj.ZHRSXXX = sqlReader.GetString(71);
				if(!sqlReader.IsDBNull(72)) 
					dataObj.ESCI = sqlReader.GetDecimal(72);
				if(!sqlReader.IsDBNull(73)) 
					dataObj.DT_BK_EDUCATION_NAME = sqlReader.GetString(73);
				if(!sqlReader.IsDBNull(74)) 
					dataObj.WRITTEN_TOTAL = sqlReader.GetDecimal(74);
				if(!sqlReader.IsDBNull(75)) 
					dataObj.SF_HH_EDUCATION_ZHRDSXM = sqlReader.GetString(75);
				if(!sqlReader.IsDBNull(76)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(76);
				if(!sqlReader.IsDBNull(77)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(77);
				if(!sqlReader.IsDBNull(78)) 
					dataObj.ZHRGRSG = sqlReader.GetDecimal(78);
				if(!sqlReader.IsDBNull(79)) 
					dataObj.ACCOUNT = sqlReader.GetString(79);
				if(!sqlReader.IsDBNull(80)) 
					dataObj.ZHRTC = sqlReader.GetString(80);
				if(!sqlReader.IsDBNull(81)) 
					dataObj.SF_SS_EDUCATION_BEGDA = sqlReader.GetString(81);
				if(!sqlReader.IsDBNull(82)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(82);
				if(!sqlReader.IsDBNull(83)) 
					dataObj.SEND_ERROR = sqlReader.GetString(83);
				if(!sqlReader.IsDBNull(84)) 
					dataObj.DT_ZG_TYPE_NAME = sqlReader.GetString(84);
				if(!sqlReader.IsDBNull(85)) 
					dataObj.SF_SS_EDUCATION_SLART = sqlReader.GetString(85);
				if(!sqlReader.IsDBNull(86)) 
					dataObj.SF_BK_EDUCATION_ENDDA = sqlReader.GetString(86);
				if(!sqlReader.IsDBNull(87)) 
					dataObj.ZHRWZMC = sqlReader.GetString(87);
				if(!sqlReader.IsDBNull(88)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(88);
				if(!sqlReader.IsDBNull(89)) 
					dataObj.NACHN = sqlReader.GetString(89);
				if(!sqlReader.IsDBNull(90)) 
					dataObj.USER_ID = sqlReader.GetString(90);
				if(!sqlReader.IsDBNull(91)) 
					dataObj.USRID_MAIL = sqlReader.GetString(91);
				if(!sqlReader.IsDBNull(92)) 
					dataObj.ZHRBZ = sqlReader.GetString(92);
				if(!sqlReader.IsDBNull(93)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(93);
				if(!sqlReader.IsDBNull(94)) 
					dataObj.STAFF_IS_NURSE_NAME = sqlReader.GetString(94);
				if(!sqlReader.IsDBNull(95)) 
					dataObj.USRID_TEL = sqlReader.GetString(95);
				if (!sqlReader.IsDBNull(96))
					dataObj.JWBS = sqlReader.GetString(96);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_STAFF_APPLY_NPOI[] objs = new DisplayObject_V_HEM_B_STAFF_APPLY_NPOI[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static string PrepareCause(CauseObject_V_HEM_B_STAFF_APPLY_NPOI cause,out OracleParameter[] parameters )
		{
			
			//平台自动生成代码
			System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
			ArrayList paramList = new ArrayList();
			OracleParameter param = null;
			#region Push Block
			if(cause.IS_PUBLIC!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.IS_PUBLIC = :C_IS_PUBLIC");
				param = new OracleParameter();
				param.ParameterName =":C_IS_PUBLIC";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_PUBLIC;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_PUBLIC"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "IS_PUBLIC"));
			}
			if(!string.IsNullOrEmpty(cause.SF_GZ_EDUCATION_INSTI))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_GZ_EDUCATION_INSTI ").Append((cause.SF_GZ_EDUCATION_INSTI.StartsWith("%") || cause.SF_GZ_EDUCATION_INSTI.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_GZ_EDUCATION_INSTI");
				param = new OracleParameter();
				param.ParameterName =":C_SF_GZ_EDUCATION_INSTI";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.SF_GZ_EDUCATION_INSTI;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_GZ_EDUCATION_INSTI"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_GZ_EDUCATION_INSTI"));
			}
			if(!string.IsNullOrEmpty(cause.SF_BS_EDUCATION_INSTI))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_INSTI ").Append((cause.SF_BS_EDUCATION_INSTI.StartsWith("%") || cause.SF_BS_EDUCATION_INSTI.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_BS_EDUCATION_INSTI");
				param = new OracleParameter();
				param.ParameterName =":C_SF_BS_EDUCATION_INSTI";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.SF_BS_EDUCATION_INSTI;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_BS_EDUCATION_INSTI"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_BS_EDUCATION_INSTI"));
			}
			if(!string.IsNullOrEmpty(cause.SF_SS_EDUCATION_ZHRDSXM))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_ZHRDSXM ").Append((cause.SF_SS_EDUCATION_ZHRDSXM.StartsWith("%") || cause.SF_SS_EDUCATION_ZHRDSXM.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_SS_EDUCATION_ZHRDSXM");
				param = new OracleParameter();
				param.ParameterName =":C_SF_SS_EDUCATION_ZHRDSXM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 60;
				param.Value = cause.SF_SS_EDUCATION_ZHRDSXM;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_SS_EDUCATION_ZHRDSXM"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_SS_EDUCATION_ZHRDSXM"));
			}
			if(!string.IsNullOrEmpty(cause.TYPE_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.TYPE_NAME ").Append((cause.TYPE_NAME.StartsWith("%") || cause.TYPE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_TYPE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_TYPE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.TYPE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "TYPE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_TYPE_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.STAFF_TYPE_ID ").Append((cause.STAFF_TYPE_ID.StartsWith("%") || cause.STAFF_TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "STAFF_TYPE_ID"));
			}
			if(cause.ESB!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.ESB = :C_ESB");
				param = new OracleParameter();
				param.ParameterName =":C_ESB";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ESB;
				paramList.Add(param);
			}
			if (cause.HasINValue("ESB"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "ESB"));
			}
			if(!string.IsNullOrEmpty(cause.SEX))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SEX ").Append((cause.SEX.StartsWith("%") || cause.SEX.EndsWith("%")) ? " like " : " = ").Append(" :C_SEX");
				param = new OracleParameter();
				param.ParameterName =":C_SEX";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 2;
				param.Value = cause.SEX;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEX"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SEX"));
			}
			if(!string.IsNullOrEmpty(cause.DT_SS_TYPE_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.DT_SS_TYPE_NAME ").Append((cause.DT_SS_TYPE_NAME.StartsWith("%") || cause.DT_SS_TYPE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_DT_SS_TYPE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_DT_SS_TYPE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.DT_SS_TYPE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("DT_SS_TYPE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "DT_SS_TYPE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.SF_ZHRJSJSP_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_ZHRJSJSP_NAME ").Append((cause.SF_ZHRJSJSP_NAME.StartsWith("%") || cause.SF_ZHRJSJSP_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_ZHRJSJSP_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_SF_ZHRJSJSP_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SF_ZHRJSJSP_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_ZHRJSJSP_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_ZHRJSJSP_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ICNUM))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.ICNUM ").Append((cause.ICNUM.StartsWith("%") || cause.ICNUM.EndsWith("%")) ? " like " : " = ").Append(" :C_ICNUM");
				param = new OracleParameter();
				param.ParameterName =":C_ICNUM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 30;
				param.Value = cause.ICNUM;
				paramList.Add(param);
			}
			if (cause.HasINValue("ICNUM"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "ICNUM"));
			}
			if(cause.EQW!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.EQW = :C_EQW");
				param = new OracleParameter();
				param.ParameterName =":C_EQW";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.EQW;
				paramList.Add(param);
			}
			if (cause.HasINValue("EQW"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "EQW"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRJG))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.ZHRJG ").Append((cause.ZHRJG.StartsWith("%") || cause.ZHRJG.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRJG");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRJG";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.ZHRJG;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRJG"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "ZHRJG"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.STAFF_ID ").Append((cause.STAFF_ID.StartsWith("%") || cause.STAFF_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_ID");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.STAFF_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "STAFF_ID"));
			}
			if(!string.IsNullOrEmpty(cause.SF_BK_EDUCATION_INSTI))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_INSTI ").Append((cause.SF_BK_EDUCATION_INSTI.StartsWith("%") || cause.SF_BK_EDUCATION_INSTI.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_BK_EDUCATION_INSTI");
				param = new OracleParameter();
				param.ParameterName =":C_SF_BK_EDUCATION_INSTI";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.SF_BK_EDUCATION_INSTI;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_BK_EDUCATION_INSTI"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_BK_EDUCATION_INSTI"));
			}
			if(cause.STATUS!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.STATUS = :C_STATUS");
				param = new OracleParameter();
				param.ParameterName =":C_STATUS";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STATUS;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATUS"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "STATUS"));
			}
			if(cause.MANAGE_USER_IS_USABL!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_IS_USABL = :C_MANAGE_USER_IS_USABL");
				param = new OracleParameter();
				param.ParameterName =":C_MANAGE_USER_IS_USABL";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.MANAGE_USER_IS_USABL;
				paramList.Add(param);
			}
			if (cause.HasINValue("MANAGE_USER_IS_USABL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "MANAGE_USER_IS_USABL"));
			}
			if(!string.IsNullOrEmpty(cause.STATUS_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.STATUS_NAME ").Append((cause.STATUS_NAME.StartsWith("%") || cause.STATUS_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_STATUS_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_STATUS_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.STATUS_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("STATUS_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "STATUS_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.SF_BS_EDUCATION_ZHRXKZY1))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_ZHRXKZY1 ").Append((cause.SF_BS_EDUCATION_ZHRXKZY1.StartsWith("%") || cause.SF_BS_EDUCATION_ZHRXKZY1.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_BS_EDUCATION_ZHRXKZY1");
				param = new OracleParameter();
				param.ParameterName =":C_SF_BS_EDUCATION_ZHRXKZY1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.SF_BS_EDUCATION_ZHRXKZY1;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_BS_EDUCATION_ZHRXKZY1"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_BS_EDUCATION_ZHRXKZY1"));
			}
			if(!string.IsNullOrEmpty(cause.DT_BS_EDUCATION_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.DT_BS_EDUCATION_NAME ").Append((cause.DT_BS_EDUCATION_NAME.StartsWith("%") || cause.DT_BS_EDUCATION_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_DT_BS_EDUCATION_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_DT_BS_EDUCATION_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 4;
				param.Value = cause.DT_BS_EDUCATION_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("DT_BS_EDUCATION_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "DT_BS_EDUCATION_NAME"));
			}
			if(cause.EYB!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.EYB = :C_EYB");
				param = new OracleParameter();
				param.ParameterName =":C_EYB";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.EYB;
				paramList.Add(param);
			}
			if (cause.HasINValue("EYB"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "EYB"));
			}
			if(cause.ZHRTZGG!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.ZHRTZGG = :C_ZHRTZGG");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRTZGG";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ZHRTZGG;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRTZGG"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "ZHRTZGG"));
			}
			if(cause.IS_SEND!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.IS_SEND = :C_IS_SEND");
				param = new OracleParameter();
				param.ParameterName =":C_IS_SEND";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_SEND;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_SEND"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "IS_SEND"));
			}
			if(cause.STAFF_IS_NURSE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.STAFF_IS_NURSE = :C_STAFF_IS_NURSE");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_IS_NURSE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.STAFF_IS_NURSE;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_IS_NURSE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "STAFF_IS_NURSE"));
			}
			if(!string.IsNullOrEmpty(cause.SF_BS_EDUCATION_ZHRDSXM))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_ZHRDSXM ").Append((cause.SF_BS_EDUCATION_ZHRDSXM.StartsWith("%") || cause.SF_BS_EDUCATION_ZHRDSXM.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_BS_EDUCATION_ZHRDSXM");
				param = new OracleParameter();
				param.ParameterName =":C_SF_BS_EDUCATION_ZHRDSXM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 60;
				param.Value = cause.SF_BS_EDUCATION_ZHRDSXM;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_BS_EDUCATION_ZHRDSXM"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_BS_EDUCATION_ZHRDSXM"));
			}
			if(!string.IsNullOrEmpty(cause.SF_BS_EDUCATION_ENDDA))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_ENDDA ").Append((cause.SF_BS_EDUCATION_ENDDA.StartsWith("%") || cause.SF_BS_EDUCATION_ENDDA.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_BS_EDUCATION_ENDDA");
				param = new OracleParameter();
				param.ParameterName =":C_SF_BS_EDUCATION_ENDDA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.SF_BS_EDUCATION_ENDDA;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_BS_EDUCATION_ENDDA"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_BS_EDUCATION_ENDDA"));
			}
			if(!string.IsNullOrEmpty(cause.SF_SS_EDUCATION_INSTI))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_INSTI ").Append((cause.SF_SS_EDUCATION_INSTI.StartsWith("%") || cause.SF_SS_EDUCATION_INSTI.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_SS_EDUCATION_INSTI");
				param = new OracleParameter();
				param.ParameterName =":C_SF_SS_EDUCATION_INSTI";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.SF_SS_EDUCATION_INSTI;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_SS_EDUCATION_INSTI"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_SS_EDUCATION_INSTI"));
			}
			if(!string.IsNullOrEmpty(cause.SF_HH_EDUCATION_INSTI))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_INSTI ").Append((cause.SF_HH_EDUCATION_INSTI.StartsWith("%") || cause.SF_HH_EDUCATION_INSTI.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_HH_EDUCATION_INSTI");
				param = new OracleParameter();
				param.ParameterName =":C_SF_HH_EDUCATION_INSTI";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.SF_HH_EDUCATION_INSTI;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_HH_EDUCATION_INSTI"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_HH_EDUCATION_INSTI"));
			}
			if(!string.IsNullOrEmpty(cause.GESCH))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.GESCH ").Append((cause.GESCH.StartsWith("%") || cause.GESCH.EndsWith("%")) ? " like " : " = ").Append(" :C_GESCH");
				param = new OracleParameter();
				param.ParameterName =":C_GESCH";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 1;
				param.Value = cause.GESCH;
				paramList.Add(param);
			}
			if (cause.HasINValue("GESCH"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "GESCH"));
			}
			if(!string.IsNullOrEmpty(cause.MSSAGE_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.MSSAGE_ID ").Append((cause.MSSAGE_ID.StartsWith("%") || cause.MSSAGE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MSSAGE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MSSAGE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MSSAGE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MSSAGE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "MSSAGE_ID"));
			}
			if(!string.IsNullOrEmpty(cause.SF_BK_EDUCATION_BEGDA))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_BEGDA ").Append((cause.SF_BK_EDUCATION_BEGDA.StartsWith("%") || cause.SF_BK_EDUCATION_BEGDA.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_BK_EDUCATION_BEGDA");
				param = new OracleParameter();
				param.ParameterName =":C_SF_BK_EDUCATION_BEGDA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.SF_BK_EDUCATION_BEGDA;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_BK_EDUCATION_BEGDA"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_BK_EDUCATION_BEGDA"));
			}
			if(cause.IS_CERTIFICATE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.IS_CERTIFICATE = :C_IS_CERTIFICATE");
				param = new OracleParameter();
				param.ParameterName =":C_IS_CERTIFICATE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.IS_CERTIFICATE;
				paramList.Add(param);
			}
			if (cause.HasINValue("IS_CERTIFICATE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "IS_CERTIFICATE"));
			}
			if(!string.IsNullOrEmpty(cause.CONTENT))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.CONTENT ").Append((cause.CONTENT.StartsWith("%") || cause.CONTENT.EndsWith("%")) ? " like " : " = ").Append(" :C_CONTENT");
				param = new OracleParameter();
				param.ParameterName =":C_CONTENT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 500;
				param.Value = cause.CONTENT;
				paramList.Add(param);
			}
			if (cause.HasINValue("CONTENT"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "CONTENT"));
			}
			if(!string.IsNullOrEmpty(cause.SF_HH_EDUCATION_ENDDA))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_ENDDA ").Append((cause.SF_HH_EDUCATION_ENDDA.StartsWith("%") || cause.SF_HH_EDUCATION_ENDDA.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_HH_EDUCATION_ENDDA");
				param = new OracleParameter();
				param.ParameterName =":C_SF_HH_EDUCATION_ENDDA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.SF_HH_EDUCATION_ENDDA;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_HH_EDUCATION_ENDDA"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_HH_EDUCATION_ENDDA"));
			}
			if(!string.IsNullOrEmpty(cause.RACKY_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.RACKY_NAME ").Append((cause.RACKY_NAME.StartsWith("%") || cause.RACKY_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_RACKY_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_RACKY_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.RACKY_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("RACKY_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "RACKY_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.MANAGE_USER_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_ID ").Append((cause.MANAGE_USER_ID.StartsWith("%") || cause.MANAGE_USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_MANAGE_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_MANAGE_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.MANAGE_USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("MANAGE_USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "MANAGE_USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.SF_BK_EDUCATION_ZHRXKZY1))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_ZHRXKZY1 ").Append((cause.SF_BK_EDUCATION_ZHRXKZY1.StartsWith("%") || cause.SF_BK_EDUCATION_ZHRXKZY1.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_BK_EDUCATION_ZHRXKZY1");
				param = new OracleParameter();
				param.ParameterName =":C_SF_BK_EDUCATION_ZHRXKZY1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.SF_BK_EDUCATION_ZHRXKZY1;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_BK_EDUCATION_ZHRXKZY1"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_BK_EDUCATION_ZHRXKZY1"));
			}
			if(!string.IsNullOrEmpty(cause.SF_SS_EDUCATION_ENDDA))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_ENDDA ").Append((cause.SF_SS_EDUCATION_ENDDA.StartsWith("%") || cause.SF_SS_EDUCATION_ENDDA.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_SS_EDUCATION_ENDDA");
				param = new OracleParameter();
				param.ParameterName =":C_SF_SS_EDUCATION_ENDDA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.SF_SS_EDUCATION_ENDDA;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_SS_EDUCATION_ENDDA"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_SS_EDUCATION_ENDDA"));
			}
			if(!string.IsNullOrEmpty(cause.POSTER_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.POSTER_ID ").Append((cause.POSTER_ID.StartsWith("%") || cause.POSTER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_POSTER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_POSTER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.POSTER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("POSTER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "POSTER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.SECONDCHOICE))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SECONDCHOICE ").Append((cause.SECONDCHOICE.StartsWith("%") || cause.SECONDCHOICE.EndsWith("%")) ? " like " : " = ").Append(" :C_SECONDCHOICE");
				param = new OracleParameter();
				param.ParameterName =":C_SECONDCHOICE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.SECONDCHOICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("SECONDCHOICE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SECONDCHOICE"));
			}
			if(cause.OPERATOR_ONE!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.OPERATOR_ONE = :C_OPERATOR_ONE");
				param = new OracleParameter();
				param.ParameterName =":C_OPERATOR_ONE";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.OPERATOR_ONE;
				paramList.Add(param);
			}
			if (cause.HasINValue("OPERATOR_ONE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "OPERATOR_ONE"));
			}
			if(cause.ZHRGRTZ!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.ZHRGRTZ = :C_ZHRGRTZ");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRGRTZ";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ZHRGRTZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRGRTZ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "ZHRGRTZ"));
			}
			if(!string.IsNullOrEmpty(cause.SF_BS_EDUCATION_BEGDA))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_BEGDA ").Append((cause.SF_BS_EDUCATION_BEGDA.StartsWith("%") || cause.SF_BS_EDUCATION_BEGDA.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_BS_EDUCATION_BEGDA");
				param = new OracleParameter();
				param.ParameterName =":C_SF_BS_EDUCATION_BEGDA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.SF_BS_EDUCATION_BEGDA;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_BS_EDUCATION_BEGDA"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_BS_EDUCATION_BEGDA"));
			}
			if(!string.IsNullOrEmpty(cause.SF_ZHRWYSP_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_ZHRWYSP_NAME ").Append((cause.SF_ZHRWYSP_NAME.StartsWith("%") || cause.SF_ZHRWYSP_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_ZHRWYSP_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_SF_ZHRWYSP_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SF_ZHRWYSP_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_ZHRWYSP_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_ZHRWYSP_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :C_ID");
				param = new OracleParameter();
				param.ParameterName =":C_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "ID"));
			}
			if(!string.IsNullOrEmpty(cause.SF_WORK_SX_ZHRXXDW))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_WORK_SX_ZHRXXDW ").Append((cause.SF_WORK_SX_ZHRXXDW.StartsWith("%") || cause.SF_WORK_SX_ZHRXXDW.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_WORK_SX_ZHRXXDW");
				param = new OracleParameter();
				param.ParameterName =":C_SF_WORK_SX_ZHRXXDW";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 4000;
				param.Value = cause.SF_WORK_SX_ZHRXXDW;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_WORK_SX_ZHRXXDW"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_WORK_SX_ZHRXXDW"));
			}
			if(!string.IsNullOrEmpty(cause.SF_FAMST_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_FAMST_NAME ").Append((cause.SF_FAMST_NAME.StartsWith("%") || cause.SF_FAMST_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_FAMST_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_SF_FAMST_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.SF_FAMST_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_FAMST_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_FAMST_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRHJJL))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.ZHRHJJL ").Append((cause.ZHRHJJL.StartsWith("%") || cause.ZHRHJJL.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRHJJL");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRHJJL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 600;
				param.Value = cause.ZHRHJJL;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRHJJL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "ZHRHJJL"));
			}
			if(!string.IsNullOrEmpty(cause.SX_ZHRGZNX))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SX_ZHRGZNX ").Append((cause.SX_ZHRGZNX.StartsWith("%") || cause.SX_ZHRGZNX.EndsWith("%")) ? " like " : " = ").Append(" :C_SX_ZHRGZNX");
				param = new OracleParameter();
				param.ParameterName =":C_SX_ZHRGZNX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 30;
				param.Value = cause.SX_ZHRGZNX;
				paramList.Add(param);
			}
			if (cause.HasINValue("SX_ZHRGZNX"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SX_ZHRGZNX"));
			}
			if(!string.IsNullOrEmpty(cause.DT_HH_EDUCATION_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.DT_HH_EDUCATION_NAME ").Append((cause.DT_HH_EDUCATION_NAME.StartsWith("%") || cause.DT_HH_EDUCATION_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_DT_HH_EDUCATION_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_DT_HH_EDUCATION_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.DT_HH_EDUCATION_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("DT_HH_EDUCATION_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "DT_HH_EDUCATION_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.RECRUIT_POSITION))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.RECRUIT_POSITION ").Append((cause.RECRUIT_POSITION.StartsWith("%") || cause.RECRUIT_POSITION.EndsWith("%")) ? " like " : " = ").Append(" :C_RECRUIT_POSITION");
				param = new OracleParameter();
				param.ParameterName =":C_RECRUIT_POSITION";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 180;
				param.Value = cause.RECRUIT_POSITION;
				paramList.Add(param);
			}
			if (cause.HasINValue("RECRUIT_POSITION"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "RECRUIT_POSITION"));
			}
			if(cause.ESC!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.ESC = :C_ESC");
				param = new OracleParameter();
				param.ParameterName =":C_ESC";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ESC;
				paramList.Add(param);
			}
			if (cause.HasINValue("ESC"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "ESC"));
			}
			if(!string.IsNullOrEmpty(cause.SF_WORK_YJ_ZHRXXDW))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_WORK_YJ_ZHRXXDW ").Append((cause.SF_WORK_YJ_ZHRXXDW.StartsWith("%") || cause.SF_WORK_YJ_ZHRXXDW.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_WORK_YJ_ZHRXXDW");
				param = new OracleParameter();
				param.ParameterName =":C_SF_WORK_YJ_ZHRXXDW";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 4000;
				param.Value = cause.SF_WORK_YJ_ZHRXXDW;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_WORK_YJ_ZHRXXDW"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_WORK_YJ_ZHRXXDW"));
			}
			if(!string.IsNullOrEmpty(cause.DT_BS_TYPE_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.DT_BS_TYPE_NAME ").Append((cause.DT_BS_TYPE_NAME.StartsWith("%") || cause.DT_BS_TYPE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_DT_BS_TYPE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_DT_BS_TYPE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.DT_BS_TYPE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("DT_BS_TYPE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "DT_BS_TYPE_NAME"));
			}
			if(cause.ESA!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.ESA = :C_ESA");
				param = new OracleParameter();
				param.ParameterName =":C_ESA";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ESA;
				paramList.Add(param);
			}
			if (cause.HasINValue("ESA"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "ESA"));
			}
			if(!string.IsNullOrEmpty(cause.YJ_ZHRGZNX))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.YJ_ZHRGZNX ").Append((cause.YJ_ZHRGZNX.StartsWith("%") || cause.YJ_ZHRGZNX.EndsWith("%")) ? " like " : " = ").Append(" :C_YJ_ZHRGZNX");
				param = new OracleParameter();
				param.ParameterName =":C_YJ_ZHRGZNX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 30;
				param.Value = cause.YJ_ZHRGZNX;
				paramList.Add(param);
			}
			if (cause.HasINValue("YJ_ZHRGZNX"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "YJ_ZHRGZNX"));
			}
			if(cause.WRITTEN_THEORY!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.WRITTEN_THEORY = :C_WRITTEN_THEORY");
				param = new OracleParameter();
				param.ParameterName =":C_WRITTEN_THEORY";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.WRITTEN_THEORY;
				paramList.Add(param);
			}
			if (cause.HasINValue("WRITTEN_THEORY"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "WRITTEN_THEORY"));
			}
			if(cause.EOTHER!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.EOTHER = :C_EOTHER");
				param = new OracleParameter();
				param.ParameterName =":C_EOTHER";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.EOTHER;
				paramList.Add(param);
			}
			if (cause.HasINValue("EOTHER"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "EOTHER"));
			}
			if(!string.IsNullOrEmpty(cause.PCODE_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.PCODE_NAME ").Append((cause.PCODE_NAME.StartsWith("%") || cause.PCODE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_PCODE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_PCODE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PCODE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("PCODE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "PCODE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.SF_HH_EDUCATION_BEGDA))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_BEGDA ").Append((cause.SF_HH_EDUCATION_BEGDA.StartsWith("%") || cause.SF_HH_EDUCATION_BEGDA.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_HH_EDUCATION_BEGDA");
				param = new OracleParameter();
				param.ParameterName =":C_SF_HH_EDUCATION_BEGDA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.SF_HH_EDUCATION_BEGDA;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_HH_EDUCATION_BEGDA"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_HH_EDUCATION_BEGDA"));
			}
			if(cause.CREATE_DATE!= null)
			{
				if (cause.CREATE_DATE.Begin != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.CREATE_DATE >= :C_CREATE_DATE_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_CREATE_DATE_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.CREATE_DATE.Begin;
					paramList.Add(param);
				}
				if (cause.CREATE_DATE.End != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.CREATE_DATE < :C_CREATE_DATE_END");
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
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "CREATE_DATE"));
			}
			if(!string.IsNullOrEmpty(cause.TYPE_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.TYPE_ID ").Append((cause.TYPE_ID.StartsWith("%") || cause.TYPE_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_TYPE_ID");
				param = new OracleParameter();
				param.ParameterName =":C_TYPE_ID";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.TYPE_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("TYPE_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "TYPE_ID"));
			}
			if(cause.GBDAT!= null)
			{
				if (cause.GBDAT.Begin != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.GBDAT >= :C_GBDAT_BEGIN");
					param = new OracleParameter();
					param.ParameterName = ":C_GBDAT_BEGIN";
					param.OracleType = System.Data.OracleClient.OracleType.DateTime;
					param.Size = 7;
					param.Value = cause.GBDAT.Begin;
					paramList.Add(param);
				}
				if (cause.GBDAT.End != null)
				{
					strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.GBDAT < :C_GBDAT_END");
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
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "GBDAT"));
			}
			if(!string.IsNullOrEmpty(cause.PRACTICE_TYPE_ID_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.PRACTICE_TYPE_ID_NAME ").Append((cause.PRACTICE_TYPE_ID_NAME.StartsWith("%") || cause.PRACTICE_TYPE_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_PRACTICE_TYPE_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_PRACTICE_TYPE_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.PRACTICE_TYPE_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("PRACTICE_TYPE_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "PRACTICE_TYPE_ID_NAME"));
			}
			if(cause.EHX!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.EHX = :C_EHX");
				param = new OracleParameter();
				param.ParameterName =":C_EHX";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.EHX;
				paramList.Add(param);
			}
			if (cause.HasINValue("EHX"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "EHX"));
			}
			if(!string.IsNullOrEmpty(cause.SF_HH_EDUCATION_ZHRXKZY1))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_ZHRXKZY1 ").Append((cause.SF_HH_EDUCATION_ZHRXKZY1.StartsWith("%") || cause.SF_HH_EDUCATION_ZHRXKZY1.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_HH_EDUCATION_ZHRXKZY1");
				param = new OracleParameter();
				param.ParameterName =":C_SF_HH_EDUCATION_ZHRXKZY1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.SF_HH_EDUCATION_ZHRXKZY1;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_HH_EDUCATION_ZHRXKZY1"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_HH_EDUCATION_ZHRXKZY1"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRSLJZ))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.ZHRSLJZ ").Append((cause.ZHRSLJZ.StartsWith("%") || cause.ZHRSLJZ.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRSLJZ");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRSLJZ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.ZHRSLJZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRSLJZ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "ZHRSLJZ"));
			}
			if(!string.IsNullOrEmpty(cause.FIRSTCHOICE))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.FIRSTCHOICE ").Append((cause.FIRSTCHOICE.StartsWith("%") || cause.FIRSTCHOICE.EndsWith("%")) ? " like " : " = ").Append(" :C_FIRSTCHOICE");
				param = new OracleParameter();
				param.ParameterName =":C_FIRSTCHOICE";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.FIRSTCHOICE;
				paramList.Add(param);
			}
			if (cause.HasINValue("FIRSTCHOICE"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "FIRSTCHOICE"));
			}
			if(!string.IsNullOrEmpty(cause.DT_SS_EDUCATION_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.DT_SS_EDUCATION_NAME ").Append((cause.DT_SS_EDUCATION_NAME.StartsWith("%") || cause.DT_SS_EDUCATION_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_DT_SS_EDUCATION_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_DT_SS_EDUCATION_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 4;
				param.Value = cause.DT_SS_EDUCATION_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("DT_SS_EDUCATION_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "DT_SS_EDUCATION_NAME"));
			}
			if(cause.WRITTEN_ENGLISH!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.WRITTEN_ENGLISH = :C_WRITTEN_ENGLISH");
				param = new OracleParameter();
				param.ParameterName =":C_WRITTEN_ENGLISH";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.WRITTEN_ENGLISH;
				paramList.Add(param);
			}
			if (cause.HasINValue("WRITTEN_ENGLISH"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "WRITTEN_ENGLISH"));
			}
			if(!string.IsNullOrEmpty(cause.SF_SS_EDUCATION_ZHRXKZY1))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_ZHRXKZY1 ").Append((cause.SF_SS_EDUCATION_ZHRXKZY1.StartsWith("%") || cause.SF_SS_EDUCATION_ZHRXKZY1.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_SS_EDUCATION_ZHRXKZY1");
				param = new OracleParameter();
				param.ParameterName =":C_SF_SS_EDUCATION_ZHRXKZY1";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.SF_SS_EDUCATION_ZHRXKZY1;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_SS_EDUCATION_ZHRXKZY1"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_SS_EDUCATION_ZHRXKZY1"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRSXXX))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.ZHRSXXX ").Append((cause.ZHRSXXX.StartsWith("%") || cause.ZHRSXXX.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRSXXX");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRSXXX";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.ZHRSXXX;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRSXXX"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "ZHRSXXX"));
			}
			if(cause.ESCI!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.ESCI = :C_ESCI");
				param = new OracleParameter();
				param.ParameterName =":C_ESCI";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ESCI;
				paramList.Add(param);
			}
			if (cause.HasINValue("ESCI"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "ESCI"));
			}
			if(!string.IsNullOrEmpty(cause.DT_BK_EDUCATION_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.DT_BK_EDUCATION_NAME ").Append((cause.DT_BK_EDUCATION_NAME.StartsWith("%") || cause.DT_BK_EDUCATION_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_DT_BK_EDUCATION_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_DT_BK_EDUCATION_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 4;
				param.Value = cause.DT_BK_EDUCATION_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("DT_BK_EDUCATION_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "DT_BK_EDUCATION_NAME"));
			}
			if(cause.WRITTEN_TOTAL!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.WRITTEN_TOTAL = :C_WRITTEN_TOTAL");
				param = new OracleParameter();
				param.ParameterName =":C_WRITTEN_TOTAL";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.WRITTEN_TOTAL;
				paramList.Add(param);
			}
			if (cause.HasINValue("WRITTEN_TOTAL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "WRITTEN_TOTAL"));
			}
			if(!string.IsNullOrEmpty(cause.SF_HH_EDUCATION_ZHRDSXM))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_ZHRDSXM ").Append((cause.SF_HH_EDUCATION_ZHRDSXM.StartsWith("%") || cause.SF_HH_EDUCATION_ZHRDSXM.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_HH_EDUCATION_ZHRDSXM");
				param = new OracleParameter();
				param.ParameterName =":C_SF_HH_EDUCATION_ZHRDSXM";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 60;
				param.Value = cause.SF_HH_EDUCATION_ZHRDSXM;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_HH_EDUCATION_ZHRDSXM"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_HH_EDUCATION_ZHRDSXM"));
			}
			if(cause.REAL_ZHRGRTZ!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.REAL_ZHRGRTZ = :C_REAL_ZHRGRTZ");
				param = new OracleParameter();
				param.ParameterName =":C_REAL_ZHRGRTZ";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.REAL_ZHRGRTZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("REAL_ZHRGRTZ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "REAL_ZHRGRTZ"));
			}
			if(cause.REAL_ZHRGRSG!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.REAL_ZHRGRSG = :C_REAL_ZHRGRSG");
				param = new OracleParameter();
				param.ParameterName =":C_REAL_ZHRGRSG";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.REAL_ZHRGRSG;
				paramList.Add(param);
			}
			if (cause.HasINValue("REAL_ZHRGRSG"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "REAL_ZHRGRSG"));
			}
			if(cause.ZHRGRSG!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.ZHRGRSG = :C_ZHRGRSG");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRGRSG";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.ZHRGRSG;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRGRSG"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "ZHRGRSG"));
			}
			if(!string.IsNullOrEmpty(cause.ACCOUNT))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.ACCOUNT ").Append((cause.ACCOUNT.StartsWith("%") || cause.ACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :C_ACCOUNT");
				param = new OracleParameter();
				param.ParameterName =":C_ACCOUNT";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = cause.ACCOUNT;
				paramList.Add(param);
			}
			if (cause.HasINValue("ACCOUNT"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "ACCOUNT"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRTC))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.ZHRTC ").Append((cause.ZHRTC.StartsWith("%") || cause.ZHRTC.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRTC");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRTC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 600;
				param.Value = cause.ZHRTC;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRTC"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "ZHRTC"));
			}
			if(!string.IsNullOrEmpty(cause.SF_SS_EDUCATION_BEGDA))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_BEGDA ").Append((cause.SF_SS_EDUCATION_BEGDA.StartsWith("%") || cause.SF_SS_EDUCATION_BEGDA.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_SS_EDUCATION_BEGDA");
				param = new OracleParameter();
				param.ParameterName =":C_SF_SS_EDUCATION_BEGDA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.SF_SS_EDUCATION_BEGDA;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_SS_EDUCATION_BEGDA"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_SS_EDUCATION_BEGDA"));
			}
			if(!string.IsNullOrEmpty(cause.MANAGE_USER_ID_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_ID_NAME ").Append((cause.MANAGE_USER_ID_NAME.StartsWith("%") || cause.MANAGE_USER_ID_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_MANAGE_USER_ID_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_MANAGE_USER_ID_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.MANAGE_USER_ID_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("MANAGE_USER_ID_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "MANAGE_USER_ID_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.SEND_ERROR))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SEND_ERROR ").Append((cause.SEND_ERROR.StartsWith("%") || cause.SEND_ERROR.EndsWith("%")) ? " like " : " = ").Append(" :C_SEND_ERROR");
				param = new OracleParameter();
				param.ParameterName =":C_SEND_ERROR";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 300;
				param.Value = cause.SEND_ERROR;
				paramList.Add(param);
			}
			if (cause.HasINValue("SEND_ERROR"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SEND_ERROR"));
			}
			if(!string.IsNullOrEmpty(cause.DT_ZG_TYPE_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.DT_ZG_TYPE_NAME ").Append((cause.DT_ZG_TYPE_NAME.StartsWith("%") || cause.DT_ZG_TYPE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_DT_ZG_TYPE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_DT_ZG_TYPE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 50;
				param.Value = cause.DT_ZG_TYPE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("DT_ZG_TYPE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "DT_ZG_TYPE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.SF_SS_EDUCATION_SLART))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_SLART ").Append((cause.SF_SS_EDUCATION_SLART.StartsWith("%") || cause.SF_SS_EDUCATION_SLART.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_SS_EDUCATION_SLART");
				param = new OracleParameter();
				param.ParameterName =":C_SF_SS_EDUCATION_SLART";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 2;
				param.Value = cause.SF_SS_EDUCATION_SLART;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_SS_EDUCATION_SLART"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_SS_EDUCATION_SLART"));
			}
			if(!string.IsNullOrEmpty(cause.SF_BK_EDUCATION_ENDDA))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_ENDDA ").Append((cause.SF_BK_EDUCATION_ENDDA.StartsWith("%") || cause.SF_BK_EDUCATION_ENDDA.EndsWith("%")) ? " like " : " = ").Append(" :C_SF_BK_EDUCATION_ENDDA");
				param = new OracleParameter();
				param.ParameterName =":C_SF_BK_EDUCATION_ENDDA";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 10;
				param.Value = cause.SF_BK_EDUCATION_ENDDA;
				paramList.Add(param);
			}
			if (cause.HasINValue("SF_BK_EDUCATION_ENDDA"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "SF_BK_EDUCATION_ENDDA"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRWZMC))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.ZHRWZMC ").Append((cause.ZHRWZMC.StartsWith("%") || cause.ZHRWZMC.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRWZMC");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRWZMC";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 4000;
				param.Value = cause.ZHRWZMC;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRWZMC"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "ZHRWZMC"));
			}
			if(cause.REAL_ZHRSLJZ!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.REAL_ZHRSLJZ = :C_REAL_ZHRSLJZ");
				param = new OracleParameter();
				param.ParameterName =":C_REAL_ZHRSLJZ";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.REAL_ZHRSLJZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("REAL_ZHRSLJZ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "REAL_ZHRSLJZ"));
			}
			if(!string.IsNullOrEmpty(cause.NACHN))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.NACHN ").Append((cause.NACHN.StartsWith("%") || cause.NACHN.EndsWith("%")) ? " like " : " = ").Append(" :C_NACHN");
				param = new OracleParameter();
				param.ParameterName =":C_NACHN";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 120;
				param.Value = cause.NACHN;
				paramList.Add(param);
			}
			if (cause.HasINValue("NACHN"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "NACHN"));
			}
			if(!string.IsNullOrEmpty(cause.USER_ID))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.USER_ID ").Append((cause.USER_ID.StartsWith("%") || cause.USER_ID.EndsWith("%")) ? " like " : " = ").Append(" :C_USER_ID");
				param = new OracleParameter();
				param.ParameterName =":C_USER_ID";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 36;
				param.Value = cause.USER_ID;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_ID"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "USER_ID"));
			}
			if(!string.IsNullOrEmpty(cause.USRID_MAIL))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.USRID_MAIL ").Append((cause.USRID_MAIL.StartsWith("%") || cause.USRID_MAIL.EndsWith("%")) ? " like " : " = ").Append(" :C_USRID_MAIL");
				param = new OracleParameter();
				param.ParameterName =":C_USRID_MAIL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 100;
				param.Value = cause.USRID_MAIL;
				paramList.Add(param);
			}
			if (cause.HasINValue("USRID_MAIL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "USRID_MAIL"));
			}
			if(!string.IsNullOrEmpty(cause.ZHRBZ))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.ZHRBZ ").Append((cause.ZHRBZ.StartsWith("%") || cause.ZHRBZ.EndsWith("%")) ? " like " : " = ").Append(" :C_ZHRBZ");
				param = new OracleParameter();
				param.ParameterName =":C_ZHRBZ";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 600;
				param.Value = cause.ZHRBZ;
				paramList.Add(param);
			}
			if (cause.HasINValue("ZHRBZ"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "ZHRBZ"));
			}
			if(cause.USER_IS_USABL!= ConstLibrary.Template.UndefineDecimal)
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.USER_IS_USABL = :C_USER_IS_USABL");
				param = new OracleParameter();
				param.ParameterName =":C_USER_IS_USABL";
				param.OracleType = System.Data.OracleClient.OracleType.Number;
				param.Size = 22;
				param.Value = cause.USER_IS_USABL;
				paramList.Add(param);
			}
			if (cause.HasINValue("USER_IS_USABL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "USER_IS_USABL"));
			}
			if(!string.IsNullOrEmpty(cause.STAFF_IS_NURSE_NAME))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.STAFF_IS_NURSE_NAME ").Append((cause.STAFF_IS_NURSE_NAME.StartsWith("%") || cause.STAFF_IS_NURSE_NAME.EndsWith("%")) ? " like " : " = ").Append(" :C_STAFF_IS_NURSE_NAME");
				param = new OracleParameter();
				param.ParameterName =":C_STAFF_IS_NURSE_NAME";
				param.OracleType = System.Data.OracleClient.OracleType.Char;
				param.Size = 2;
				param.Value = cause.STAFF_IS_NURSE_NAME;
				paramList.Add(param);
			}
			if (cause.HasINValue("STAFF_IS_NURSE_NAME"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "STAFF_IS_NURSE_NAME"));
			}
			if(!string.IsNullOrEmpty(cause.USRID_TEL))
			{
				strBuf.Append(" And V_HEM_B_STAFF_APPLY_NPOI.USRID_TEL ").Append((cause.USRID_TEL.StartsWith("%") || cause.USRID_TEL.EndsWith("%")) ? " like " : " = ").Append(" :C_USRID_TEL");
				param = new OracleParameter();
				param.ParameterName =":C_USRID_TEL";
				param.OracleType = System.Data.OracleClient.OracleType.VarChar;
				param.Size = 11;
				param.Value = cause.USRID_TEL;
				paramList.Add(param);
			}
			if (cause.HasINValue("USRID_TEL"))
			{
				strBuf.Append(cause.GetINSQL("V_HEM_B_STAFF_APPLY_NPOI", "USRID_TEL"));
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
		public static DisplayObject_V_HEM_B_STAFF_APPLY_NPOI[] Query(CauseObject_V_HEM_B_STAFF_APPLY_NPOI cause)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
            string sSql = " select  V_HEM_B_STAFF_APPLY_NPOI.IS_PUBLIC, V_HEM_B_STAFF_APPLY_NPOI.SF_GZ_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_ZHRDSXM, V_HEM_B_STAFF_APPLY_NPOI.TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.STAFF_TYPE_ID, V_HEM_B_STAFF_APPLY_NPOI.ESB, V_HEM_B_STAFF_APPLY_NPOI.SEX, V_HEM_B_STAFF_APPLY_NPOI.DT_SS_TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_ZHRJSJSP_NAME, V_HEM_B_STAFF_APPLY_NPOI.ICNUM, V_HEM_B_STAFF_APPLY_NPOI.EQW, V_HEM_B_STAFF_APPLY_NPOI.ZHRJG, V_HEM_B_STAFF_APPLY_NPOI.STAFF_ID, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.STATUS, V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_IS_USABL, V_HEM_B_STAFF_APPLY_NPOI.STATUS_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.DT_BS_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.EYB, V_HEM_B_STAFF_APPLY_NPOI.ZHRTZGG, V_HEM_B_STAFF_APPLY_NPOI.IS_SEND, V_HEM_B_STAFF_APPLY_NPOI.STAFF_IS_NURSE, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_ZHRDSXM, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.GESCH, V_HEM_B_STAFF_APPLY_NPOI.MSSAGE_ID, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.IS_CERTIFICATE, V_HEM_B_STAFF_APPLY_NPOI.CONTENT, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.RACKY_NAME, V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_ID, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.POSTER_ID, V_HEM_B_STAFF_APPLY_NPOI.SECONDCHOICE, V_HEM_B_STAFF_APPLY_NPOI.OPERATOR_ONE, V_HEM_B_STAFF_APPLY_NPOI.ZHRGRTZ, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.SF_ZHRWYSP_NAME, V_HEM_B_STAFF_APPLY_NPOI.ID, V_HEM_B_STAFF_APPLY_NPOI.SF_WORK_SX_ZHRXXDW, V_HEM_B_STAFF_APPLY_NPOI.SF_FAMST_NAME, V_HEM_B_STAFF_APPLY_NPOI.ZHRHJJL, V_HEM_B_STAFF_APPLY_NPOI.SX_ZHRGZNX, V_HEM_B_STAFF_APPLY_NPOI.DT_HH_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.RECRUIT_POSITION, V_HEM_B_STAFF_APPLY_NPOI.ESC, V_HEM_B_STAFF_APPLY_NPOI.SF_WORK_YJ_ZHRXXDW, V_HEM_B_STAFF_APPLY_NPOI.DT_BS_TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.ESA, V_HEM_B_STAFF_APPLY_NPOI.YJ_ZHRGZNX, V_HEM_B_STAFF_APPLY_NPOI.WRITTEN_THEORY, V_HEM_B_STAFF_APPLY_NPOI.EOTHER, V_HEM_B_STAFF_APPLY_NPOI.PCODE_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.CREATE_DATE, V_HEM_B_STAFF_APPLY_NPOI.TYPE_ID, V_HEM_B_STAFF_APPLY_NPOI.GBDAT, V_HEM_B_STAFF_APPLY_NPOI.PRACTICE_TYPE_ID_NAME, V_HEM_B_STAFF_APPLY_NPOI.EHX, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.ZHRSLJZ, V_HEM_B_STAFF_APPLY_NPOI.FIRSTCHOICE, V_HEM_B_STAFF_APPLY_NPOI.DT_SS_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.WRITTEN_ENGLISH, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.ZHRSXXX, V_HEM_B_STAFF_APPLY_NPOI.ESCI, V_HEM_B_STAFF_APPLY_NPOI.DT_BK_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.WRITTEN_TOTAL, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_ZHRDSXM, V_HEM_B_STAFF_APPLY_NPOI.REAL_ZHRGRTZ, V_HEM_B_STAFF_APPLY_NPOI.REAL_ZHRGRSG, V_HEM_B_STAFF_APPLY_NPOI.ZHRGRSG, V_HEM_B_STAFF_APPLY_NPOI.ACCOUNT, V_HEM_B_STAFF_APPLY_NPOI.ZHRTC, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_ID_NAME, V_HEM_B_STAFF_APPLY_NPOI.SEND_ERROR, V_HEM_B_STAFF_APPLY_NPOI.DT_ZG_TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_SLART, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.ZHRWZMC, V_HEM_B_STAFF_APPLY_NPOI.REAL_ZHRSLJZ, V_HEM_B_STAFF_APPLY_NPOI.NACHN, V_HEM_B_STAFF_APPLY_NPOI.USER_ID, V_HEM_B_STAFF_APPLY_NPOI.USRID_MAIL, V_HEM_B_STAFF_APPLY_NPOI.ZHRBZ, V_HEM_B_STAFF_APPLY_NPOI.USER_IS_USABL, V_HEM_B_STAFF_APPLY_NPOI.STAFF_IS_NURSE_NAME, V_HEM_B_STAFF_APPLY_NPOI.USRID_TEL, V_HEM_B_STAFF_APPLY_NPOI.YJSSXXX,V_HEM_B_STAFF_APPLY_NPOI.IS_STANDARD, V_HEM_B_STAFF_APPLY_NPOI.OUTOCEAN, V_HEM_B_STAFF_APPLY_NPOI.IS_SZHY,V_HEM_B_STAFF_APPLY_NPOI.JWBS from V_HEM_B_STAFF_APPLY_NPOI where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_B_STAFF_APPLY_NPOI dataObj = null;
			ArrayList objArray = new ArrayList();
			IDbConnection connection = IDALProvider.IDAL.PopConnection();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,connection);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_APPLY_NPOI();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SF_GZ_EDUCATION_INSTI = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SF_BS_EDUCATION_INSTI = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SF_SS_EDUCATION_ZHRDSXM = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ESB = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SEX = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DT_SS_TYPE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SF_ZHRJSJSP_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ICNUM = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.EQW = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ZHRJG = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.STAFF_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SF_BK_EDUCATION_INSTI = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATUS = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.STATUS_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.SF_BS_EDUCATION_ZHRXKZY1 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.DT_BS_EDUCATION_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.EYB = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ZHRTZGG = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.IS_SEND = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.SF_BS_EDUCATION_ZHRDSXM = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SF_BS_EDUCATION_ENDDA = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.SF_SS_EDUCATION_INSTI = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.SF_HH_EDUCATION_INSTI = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.GESCH = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.MSSAGE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.SF_BK_EDUCATION_BEGDA = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONTENT = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.SF_HH_EDUCATION_ENDDA = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.RACKY_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.SF_BK_EDUCATION_ZHRXKZY1 = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.SF_SS_EDUCATION_ENDDA = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.POSTER_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.ZHRGRTZ = sqlReader.GetDecimal(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.SF_BS_EDUCATION_BEGDA = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.SF_ZHRWYSP_NAME = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.ID = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.SF_WORK_SX_ZHRXXDW = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.SF_FAMST_NAME = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.ZHRHJJL = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.SX_ZHRGZNX = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.DT_HH_EDUCATION_NAME = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.ESC = sqlReader.GetDecimal(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.SF_WORK_YJ_ZHRXXDW = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.DT_BS_TYPE_NAME = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.ESA = sqlReader.GetDecimal(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.YJ_ZHRGZNX = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.EOTHER = sqlReader.GetDecimal(57);
				if(!sqlReader.IsDBNull(58)) 
					dataObj.PCODE_NAME = sqlReader.GetString(58);
				if(!sqlReader.IsDBNull(59)) 
					dataObj.SF_HH_EDUCATION_BEGDA = sqlReader.GetString(59);
				if(!sqlReader.IsDBNull(60)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(60);
				if(!sqlReader.IsDBNull(61)) 
					dataObj.TYPE_ID = sqlReader.GetString(61);
				if(!sqlReader.IsDBNull(62)) 
					dataObj.GBDAT = sqlReader.GetDateTime(62);
				if(!sqlReader.IsDBNull(63)) 
					dataObj.PRACTICE_TYPE_ID_NAME = sqlReader.GetString(63);
				if(!sqlReader.IsDBNull(64)) 
					dataObj.EHX = sqlReader.GetDecimal(64);
				if(!sqlReader.IsDBNull(65)) 
					dataObj.SF_HH_EDUCATION_ZHRXKZY1 = sqlReader.GetString(65);
				if(!sqlReader.IsDBNull(66)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(66);
				if(!sqlReader.IsDBNull(67)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(67);
				if(!sqlReader.IsDBNull(68)) 
					dataObj.DT_SS_EDUCATION_NAME = sqlReader.GetString(68);
				if(!sqlReader.IsDBNull(69)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(69);
				if(!sqlReader.IsDBNull(70)) 
					dataObj.SF_SS_EDUCATION_ZHRXKZY1 = sqlReader.GetString(70);
				if(!sqlReader.IsDBNull(71)) 
					dataObj.ZHRSXXX = sqlReader.GetString(71);
				if(!sqlReader.IsDBNull(72)) 
					dataObj.ESCI = sqlReader.GetDecimal(72);
				if(!sqlReader.IsDBNull(73)) 
					dataObj.DT_BK_EDUCATION_NAME = sqlReader.GetString(73);
				if(!sqlReader.IsDBNull(74)) 
					dataObj.WRITTEN_TOTAL = sqlReader.GetDecimal(74);
				if(!sqlReader.IsDBNull(75)) 
					dataObj.SF_HH_EDUCATION_ZHRDSXM = sqlReader.GetString(75);
				if(!sqlReader.IsDBNull(76)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(76);
				if(!sqlReader.IsDBNull(77)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(77);
				if(!sqlReader.IsDBNull(78)) 
					dataObj.ZHRGRSG = sqlReader.GetDecimal(78);
				if(!sqlReader.IsDBNull(79)) 
					dataObj.ACCOUNT = sqlReader.GetString(79);
				if(!sqlReader.IsDBNull(80)) 
					dataObj.ZHRTC = sqlReader.GetString(80);
				if(!sqlReader.IsDBNull(81)) 
					dataObj.SF_SS_EDUCATION_BEGDA = sqlReader.GetString(81);
				if(!sqlReader.IsDBNull(82)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(82);
				if(!sqlReader.IsDBNull(83)) 
					dataObj.SEND_ERROR = sqlReader.GetString(83);
				if(!sqlReader.IsDBNull(84)) 
					dataObj.DT_ZG_TYPE_NAME = sqlReader.GetString(84);
				if(!sqlReader.IsDBNull(85)) 
					dataObj.SF_SS_EDUCATION_SLART = sqlReader.GetString(85);
				if(!sqlReader.IsDBNull(86)) 
					dataObj.SF_BK_EDUCATION_ENDDA = sqlReader.GetString(86);
				if(!sqlReader.IsDBNull(87)) 
					dataObj.ZHRWZMC = sqlReader.GetString(87);
				if(!sqlReader.IsDBNull(88)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(88);
				if(!sqlReader.IsDBNull(89)) 
					dataObj.NACHN = sqlReader.GetString(89);
				if(!sqlReader.IsDBNull(90)) 
					dataObj.USER_ID = sqlReader.GetString(90);
				if(!sqlReader.IsDBNull(91)) 
					dataObj.USRID_MAIL = sqlReader.GetString(91);
				if(!sqlReader.IsDBNull(92)) 
					dataObj.ZHRBZ = sqlReader.GetString(92);
				if(!sqlReader.IsDBNull(93)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(93);
				if(!sqlReader.IsDBNull(94)) 
					dataObj.STAFF_IS_NURSE_NAME = sqlReader.GetString(94);
				if(!sqlReader.IsDBNull(95)) 
					dataObj.USRID_TEL = sqlReader.GetString(95);
                if (!sqlReader.IsDBNull(96))
                    dataObj.YJSSXXX = sqlReader.GetString(96);
                if (!sqlReader.IsDBNull(97))
                    dataObj.IS_STANDARD = sqlReader.GetString(97);
                if (!sqlReader.IsDBNull(98))
                    dataObj.OUTOCEAN = sqlReader.GetString(98);
                if (!sqlReader.IsDBNull(99))
                    dataObj.IS_SZHY = sqlReader.GetString(99);
				if (!sqlReader.IsDBNull(100))
					dataObj.JWBS = sqlReader.GetString(100);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_STAFF_APPLY_NPOI[] objs = new DisplayObject_V_HEM_B_STAFF_APPLY_NPOI[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_STAFF_APPLY_NPOI[] Query(CauseObject_V_HEM_B_STAFF_APPLY_NPOI cause,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			#endregion 
			string sSql = " select  V_HEM_B_STAFF_APPLY_NPOI.IS_PUBLIC, V_HEM_B_STAFF_APPLY_NPOI.SF_GZ_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_ZHRDSXM, V_HEM_B_STAFF_APPLY_NPOI.TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.STAFF_TYPE_ID, V_HEM_B_STAFF_APPLY_NPOI.ESB, V_HEM_B_STAFF_APPLY_NPOI.SEX, V_HEM_B_STAFF_APPLY_NPOI.DT_SS_TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_ZHRJSJSP_NAME, V_HEM_B_STAFF_APPLY_NPOI.ICNUM, V_HEM_B_STAFF_APPLY_NPOI.EQW, V_HEM_B_STAFF_APPLY_NPOI.ZHRJG, V_HEM_B_STAFF_APPLY_NPOI.STAFF_ID, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.STATUS, V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_IS_USABL, V_HEM_B_STAFF_APPLY_NPOI.STATUS_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.DT_BS_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.EYB, V_HEM_B_STAFF_APPLY_NPOI.ZHRTZGG, V_HEM_B_STAFF_APPLY_NPOI.IS_SEND, V_HEM_B_STAFF_APPLY_NPOI.STAFF_IS_NURSE, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_ZHRDSXM, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.GESCH, V_HEM_B_STAFF_APPLY_NPOI.MSSAGE_ID, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.IS_CERTIFICATE, V_HEM_B_STAFF_APPLY_NPOI.CONTENT, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.RACKY_NAME, V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_ID, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.POSTER_ID, V_HEM_B_STAFF_APPLY_NPOI.SECONDCHOICE, V_HEM_B_STAFF_APPLY_NPOI.OPERATOR_ONE, V_HEM_B_STAFF_APPLY_NPOI.ZHRGRTZ, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.SF_ZHRWYSP_NAME, V_HEM_B_STAFF_APPLY_NPOI.ID, V_HEM_B_STAFF_APPLY_NPOI.SF_WORK_SX_ZHRXXDW, V_HEM_B_STAFF_APPLY_NPOI.SF_FAMST_NAME, V_HEM_B_STAFF_APPLY_NPOI.ZHRHJJL, V_HEM_B_STAFF_APPLY_NPOI.SX_ZHRGZNX, V_HEM_B_STAFF_APPLY_NPOI.DT_HH_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.RECRUIT_POSITION, V_HEM_B_STAFF_APPLY_NPOI.ESC, V_HEM_B_STAFF_APPLY_NPOI.SF_WORK_YJ_ZHRXXDW, V_HEM_B_STAFF_APPLY_NPOI.DT_BS_TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.ESA, V_HEM_B_STAFF_APPLY_NPOI.YJ_ZHRGZNX, V_HEM_B_STAFF_APPLY_NPOI.WRITTEN_THEORY, V_HEM_B_STAFF_APPLY_NPOI.EOTHER, V_HEM_B_STAFF_APPLY_NPOI.PCODE_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.CREATE_DATE, V_HEM_B_STAFF_APPLY_NPOI.TYPE_ID, V_HEM_B_STAFF_APPLY_NPOI.GBDAT, V_HEM_B_STAFF_APPLY_NPOI.PRACTICE_TYPE_ID_NAME, V_HEM_B_STAFF_APPLY_NPOI.EHX, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.ZHRSLJZ, V_HEM_B_STAFF_APPLY_NPOI.FIRSTCHOICE, V_HEM_B_STAFF_APPLY_NPOI.DT_SS_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.WRITTEN_ENGLISH, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.ZHRSXXX, V_HEM_B_STAFF_APPLY_NPOI.ESCI, V_HEM_B_STAFF_APPLY_NPOI.DT_BK_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.WRITTEN_TOTAL, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_ZHRDSXM, V_HEM_B_STAFF_APPLY_NPOI.REAL_ZHRGRTZ, V_HEM_B_STAFF_APPLY_NPOI.REAL_ZHRGRSG, V_HEM_B_STAFF_APPLY_NPOI.ZHRGRSG, V_HEM_B_STAFF_APPLY_NPOI.ACCOUNT, V_HEM_B_STAFF_APPLY_NPOI.ZHRTC, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_ID_NAME, V_HEM_B_STAFF_APPLY_NPOI.SEND_ERROR, V_HEM_B_STAFF_APPLY_NPOI.DT_ZG_TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_SLART, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.ZHRWZMC, V_HEM_B_STAFF_APPLY_NPOI.REAL_ZHRSLJZ, V_HEM_B_STAFF_APPLY_NPOI.NACHN, V_HEM_B_STAFF_APPLY_NPOI.USER_ID, V_HEM_B_STAFF_APPLY_NPOI.USRID_MAIL, V_HEM_B_STAFF_APPLY_NPOI.ZHRBZ, V_HEM_B_STAFF_APPLY_NPOI.USER_IS_USABL, V_HEM_B_STAFF_APPLY_NPOI.STAFF_IS_NURSE_NAME, V_HEM_B_STAFF_APPLY_NPOI.USRID_TEL, V_HEM_B_STAFF_APPLY_NPOI.JWBS from V_HEM_B_STAFF_APPLY_NPOI where (1=1)";
			sSql += PrepareCause(cause,out parameters);
			if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
			{
				sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
			}
			#region Push Block
			DisplayObject_V_HEM_B_STAFF_APPLY_NPOI dataObj = null;
			ArrayList objArray = new ArrayList();
			IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql,parameters,trans);
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_APPLY_NPOI();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SF_GZ_EDUCATION_INSTI = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SF_BS_EDUCATION_INSTI = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SF_SS_EDUCATION_ZHRDSXM = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ESB = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SEX = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DT_SS_TYPE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SF_ZHRJSJSP_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ICNUM = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.EQW = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ZHRJG = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.STAFF_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SF_BK_EDUCATION_INSTI = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATUS = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.STATUS_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.SF_BS_EDUCATION_ZHRXKZY1 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.DT_BS_EDUCATION_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.EYB = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ZHRTZGG = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.IS_SEND = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.SF_BS_EDUCATION_ZHRDSXM = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SF_BS_EDUCATION_ENDDA = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.SF_SS_EDUCATION_INSTI = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.SF_HH_EDUCATION_INSTI = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.GESCH = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.MSSAGE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.SF_BK_EDUCATION_BEGDA = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONTENT = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.SF_HH_EDUCATION_ENDDA = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.RACKY_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.SF_BK_EDUCATION_ZHRXKZY1 = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.SF_SS_EDUCATION_ENDDA = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.POSTER_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.ZHRGRTZ = sqlReader.GetDecimal(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.SF_BS_EDUCATION_BEGDA = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.SF_ZHRWYSP_NAME = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.ID = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.SF_WORK_SX_ZHRXXDW = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.SF_FAMST_NAME = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.ZHRHJJL = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.SX_ZHRGZNX = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.DT_HH_EDUCATION_NAME = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.ESC = sqlReader.GetDecimal(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.SF_WORK_YJ_ZHRXXDW = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.DT_BS_TYPE_NAME = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.ESA = sqlReader.GetDecimal(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.YJ_ZHRGZNX = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.EOTHER = sqlReader.GetDecimal(57);
				if(!sqlReader.IsDBNull(58)) 
					dataObj.PCODE_NAME = sqlReader.GetString(58);
				if(!sqlReader.IsDBNull(59)) 
					dataObj.SF_HH_EDUCATION_BEGDA = sqlReader.GetString(59);
				if(!sqlReader.IsDBNull(60)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(60);
				if(!sqlReader.IsDBNull(61)) 
					dataObj.TYPE_ID = sqlReader.GetString(61);
				if(!sqlReader.IsDBNull(62)) 
					dataObj.GBDAT = sqlReader.GetDateTime(62);
				if(!sqlReader.IsDBNull(63)) 
					dataObj.PRACTICE_TYPE_ID_NAME = sqlReader.GetString(63);
				if(!sqlReader.IsDBNull(64)) 
					dataObj.EHX = sqlReader.GetDecimal(64);
				if(!sqlReader.IsDBNull(65)) 
					dataObj.SF_HH_EDUCATION_ZHRXKZY1 = sqlReader.GetString(65);
				if(!sqlReader.IsDBNull(66)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(66);
				if(!sqlReader.IsDBNull(67)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(67);
				if(!sqlReader.IsDBNull(68)) 
					dataObj.DT_SS_EDUCATION_NAME = sqlReader.GetString(68);
				if(!sqlReader.IsDBNull(69)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(69);
				if(!sqlReader.IsDBNull(70)) 
					dataObj.SF_SS_EDUCATION_ZHRXKZY1 = sqlReader.GetString(70);
				if(!sqlReader.IsDBNull(71)) 
					dataObj.ZHRSXXX = sqlReader.GetString(71);
				if(!sqlReader.IsDBNull(72)) 
					dataObj.ESCI = sqlReader.GetDecimal(72);
				if(!sqlReader.IsDBNull(73)) 
					dataObj.DT_BK_EDUCATION_NAME = sqlReader.GetString(73);
				if(!sqlReader.IsDBNull(74)) 
					dataObj.WRITTEN_TOTAL = sqlReader.GetDecimal(74);
				if(!sqlReader.IsDBNull(75)) 
					dataObj.SF_HH_EDUCATION_ZHRDSXM = sqlReader.GetString(75);
				if(!sqlReader.IsDBNull(76)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(76);
				if(!sqlReader.IsDBNull(77)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(77);
				if(!sqlReader.IsDBNull(78)) 
					dataObj.ZHRGRSG = sqlReader.GetDecimal(78);
				if(!sqlReader.IsDBNull(79)) 
					dataObj.ACCOUNT = sqlReader.GetString(79);
				if(!sqlReader.IsDBNull(80)) 
					dataObj.ZHRTC = sqlReader.GetString(80);
				if(!sqlReader.IsDBNull(81)) 
					dataObj.SF_SS_EDUCATION_BEGDA = sqlReader.GetString(81);
				if(!sqlReader.IsDBNull(82)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(82);
				if(!sqlReader.IsDBNull(83)) 
					dataObj.SEND_ERROR = sqlReader.GetString(83);
				if(!sqlReader.IsDBNull(84)) 
					dataObj.DT_ZG_TYPE_NAME = sqlReader.GetString(84);
				if(!sqlReader.IsDBNull(85)) 
					dataObj.SF_SS_EDUCATION_SLART = sqlReader.GetString(85);
				if(!sqlReader.IsDBNull(86)) 
					dataObj.SF_BK_EDUCATION_ENDDA = sqlReader.GetString(86);
				if(!sqlReader.IsDBNull(87)) 
					dataObj.ZHRWZMC = sqlReader.GetString(87);
				if(!sqlReader.IsDBNull(88)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(88);
				if(!sqlReader.IsDBNull(89)) 
					dataObj.NACHN = sqlReader.GetString(89);
				if(!sqlReader.IsDBNull(90)) 
					dataObj.USER_ID = sqlReader.GetString(90);
				if(!sqlReader.IsDBNull(91)) 
					dataObj.USRID_MAIL = sqlReader.GetString(91);
				if(!sqlReader.IsDBNull(92)) 
					dataObj.ZHRBZ = sqlReader.GetString(92);
				if(!sqlReader.IsDBNull(93)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(93);
				if(!sqlReader.IsDBNull(94)) 
					dataObj.STAFF_IS_NURSE_NAME = sqlReader.GetString(94);
				if(!sqlReader.IsDBNull(95)) 
					dataObj.USRID_TEL = sqlReader.GetString(95);
				if (!sqlReader.IsDBNull(96))
					dataObj.JWBS = sqlReader.GetString(96);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_B_STAFF_APPLY_NPOI[] objs = new DisplayObject_V_HEM_B_STAFF_APPLY_NPOI[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_STAFF_APPLY_NPOI[] Query(CauseObject_V_HEM_B_STAFF_APPLY_NPOI cause,PagingParamter paging,OrderByParameter order)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
			string sSql = " select  V_HEM_B_STAFF_APPLY_NPOI.IS_PUBLIC, V_HEM_B_STAFF_APPLY_NPOI.SF_GZ_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_ZHRDSXM, V_HEM_B_STAFF_APPLY_NPOI.TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.STAFF_TYPE_ID, V_HEM_B_STAFF_APPLY_NPOI.ESB, V_HEM_B_STAFF_APPLY_NPOI.SEX, V_HEM_B_STAFF_APPLY_NPOI.DT_SS_TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_ZHRJSJSP_NAME, V_HEM_B_STAFF_APPLY_NPOI.ICNUM, V_HEM_B_STAFF_APPLY_NPOI.EQW, V_HEM_B_STAFF_APPLY_NPOI.ZHRJG, V_HEM_B_STAFF_APPLY_NPOI.STAFF_ID, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.STATUS, V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_IS_USABL, V_HEM_B_STAFF_APPLY_NPOI.STATUS_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.DT_BS_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.EYB, V_HEM_B_STAFF_APPLY_NPOI.ZHRTZGG, V_HEM_B_STAFF_APPLY_NPOI.IS_SEND, V_HEM_B_STAFF_APPLY_NPOI.STAFF_IS_NURSE, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_ZHRDSXM, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.GESCH, V_HEM_B_STAFF_APPLY_NPOI.MSSAGE_ID, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.IS_CERTIFICATE, V_HEM_B_STAFF_APPLY_NPOI.CONTENT, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.RACKY_NAME, V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_ID, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.POSTER_ID, V_HEM_B_STAFF_APPLY_NPOI.SECONDCHOICE, V_HEM_B_STAFF_APPLY_NPOI.OPERATOR_ONE, V_HEM_B_STAFF_APPLY_NPOI.ZHRGRTZ, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.SF_ZHRWYSP_NAME, V_HEM_B_STAFF_APPLY_NPOI.ID, V_HEM_B_STAFF_APPLY_NPOI.SF_WORK_SX_ZHRXXDW, V_HEM_B_STAFF_APPLY_NPOI.SF_FAMST_NAME, V_HEM_B_STAFF_APPLY_NPOI.ZHRHJJL, V_HEM_B_STAFF_APPLY_NPOI.SX_ZHRGZNX, V_HEM_B_STAFF_APPLY_NPOI.DT_HH_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.RECRUIT_POSITION, V_HEM_B_STAFF_APPLY_NPOI.ESC, V_HEM_B_STAFF_APPLY_NPOI.SF_WORK_YJ_ZHRXXDW, V_HEM_B_STAFF_APPLY_NPOI.DT_BS_TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.ESA, V_HEM_B_STAFF_APPLY_NPOI.YJ_ZHRGZNX, V_HEM_B_STAFF_APPLY_NPOI.WRITTEN_THEORY, V_HEM_B_STAFF_APPLY_NPOI.EOTHER, V_HEM_B_STAFF_APPLY_NPOI.PCODE_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.CREATE_DATE, V_HEM_B_STAFF_APPLY_NPOI.TYPE_ID, V_HEM_B_STAFF_APPLY_NPOI.GBDAT, V_HEM_B_STAFF_APPLY_NPOI.PRACTICE_TYPE_ID_NAME, V_HEM_B_STAFF_APPLY_NPOI.EHX, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.ZHRSLJZ, V_HEM_B_STAFF_APPLY_NPOI.FIRSTCHOICE, V_HEM_B_STAFF_APPLY_NPOI.DT_SS_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.WRITTEN_ENGLISH, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.ZHRSXXX, V_HEM_B_STAFF_APPLY_NPOI.ESCI, V_HEM_B_STAFF_APPLY_NPOI.DT_BK_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.WRITTEN_TOTAL, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_ZHRDSXM, V_HEM_B_STAFF_APPLY_NPOI.REAL_ZHRGRTZ, V_HEM_B_STAFF_APPLY_NPOI.REAL_ZHRGRSG, V_HEM_B_STAFF_APPLY_NPOI.ZHRGRSG, V_HEM_B_STAFF_APPLY_NPOI.ACCOUNT, V_HEM_B_STAFF_APPLY_NPOI.ZHRTC, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_ID_NAME, V_HEM_B_STAFF_APPLY_NPOI.SEND_ERROR, V_HEM_B_STAFF_APPLY_NPOI.DT_ZG_TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_SLART, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.ZHRWZMC, V_HEM_B_STAFF_APPLY_NPOI.REAL_ZHRSLJZ, V_HEM_B_STAFF_APPLY_NPOI.NACHN, V_HEM_B_STAFF_APPLY_NPOI.USER_ID, V_HEM_B_STAFF_APPLY_NPOI.USRID_MAIL, V_HEM_B_STAFF_APPLY_NPOI.ZHRBZ, V_HEM_B_STAFF_APPLY_NPOI.USER_IS_USABL, V_HEM_B_STAFF_APPLY_NPOI.STAFF_IS_NURSE_NAME, V_HEM_B_STAFF_APPLY_NPOI.USRID_TEL, V_HEM_B_STAFF_APPLY_NPOI.JWBS from V_HEM_B_STAFF_APPLY_NPOI where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_B_STAFF_APPLY_NPOI",paging, order, sSql, parameters, connection);
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
			DisplayObject_V_HEM_B_STAFF_APPLY_NPOI dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_APPLY_NPOI();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SF_GZ_EDUCATION_INSTI = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SF_BS_EDUCATION_INSTI = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SF_SS_EDUCATION_ZHRDSXM = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ESB = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SEX = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DT_SS_TYPE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SF_ZHRJSJSP_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ICNUM = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.EQW = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ZHRJG = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.STAFF_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SF_BK_EDUCATION_INSTI = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATUS = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.STATUS_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.SF_BS_EDUCATION_ZHRXKZY1 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.DT_BS_EDUCATION_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.EYB = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ZHRTZGG = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.IS_SEND = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.SF_BS_EDUCATION_ZHRDSXM = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SF_BS_EDUCATION_ENDDA = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.SF_SS_EDUCATION_INSTI = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.SF_HH_EDUCATION_INSTI = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.GESCH = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.MSSAGE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.SF_BK_EDUCATION_BEGDA = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONTENT = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.SF_HH_EDUCATION_ENDDA = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.RACKY_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.SF_BK_EDUCATION_ZHRXKZY1 = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.SF_SS_EDUCATION_ENDDA = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.POSTER_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.ZHRGRTZ = sqlReader.GetDecimal(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.SF_BS_EDUCATION_BEGDA = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.SF_ZHRWYSP_NAME = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.ID = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.SF_WORK_SX_ZHRXXDW = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.SF_FAMST_NAME = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.ZHRHJJL = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.SX_ZHRGZNX = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.DT_HH_EDUCATION_NAME = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.ESC = sqlReader.GetDecimal(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.SF_WORK_YJ_ZHRXXDW = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.DT_BS_TYPE_NAME = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.ESA = sqlReader.GetDecimal(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.YJ_ZHRGZNX = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.EOTHER = sqlReader.GetDecimal(57);
				if(!sqlReader.IsDBNull(58)) 
					dataObj.PCODE_NAME = sqlReader.GetString(58);
				if(!sqlReader.IsDBNull(59)) 
					dataObj.SF_HH_EDUCATION_BEGDA = sqlReader.GetString(59);
				if(!sqlReader.IsDBNull(60)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(60);
				if(!sqlReader.IsDBNull(61)) 
					dataObj.TYPE_ID = sqlReader.GetString(61);
				if(!sqlReader.IsDBNull(62)) 
					dataObj.GBDAT = sqlReader.GetDateTime(62);
				if(!sqlReader.IsDBNull(63)) 
					dataObj.PRACTICE_TYPE_ID_NAME = sqlReader.GetString(63);
				if(!sqlReader.IsDBNull(64)) 
					dataObj.EHX = sqlReader.GetDecimal(64);
				if(!sqlReader.IsDBNull(65)) 
					dataObj.SF_HH_EDUCATION_ZHRXKZY1 = sqlReader.GetString(65);
				if(!sqlReader.IsDBNull(66)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(66);
				if(!sqlReader.IsDBNull(67)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(67);
				if(!sqlReader.IsDBNull(68)) 
					dataObj.DT_SS_EDUCATION_NAME = sqlReader.GetString(68);
				if(!sqlReader.IsDBNull(69)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(69);
				if(!sqlReader.IsDBNull(70)) 
					dataObj.SF_SS_EDUCATION_ZHRXKZY1 = sqlReader.GetString(70);
				if(!sqlReader.IsDBNull(71)) 
					dataObj.ZHRSXXX = sqlReader.GetString(71);
				if(!sqlReader.IsDBNull(72)) 
					dataObj.ESCI = sqlReader.GetDecimal(72);
				if(!sqlReader.IsDBNull(73)) 
					dataObj.DT_BK_EDUCATION_NAME = sqlReader.GetString(73);
				if(!sqlReader.IsDBNull(74)) 
					dataObj.WRITTEN_TOTAL = sqlReader.GetDecimal(74);
				if(!sqlReader.IsDBNull(75)) 
					dataObj.SF_HH_EDUCATION_ZHRDSXM = sqlReader.GetString(75);
				if(!sqlReader.IsDBNull(76)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(76);
				if(!sqlReader.IsDBNull(77)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(77);
				if(!sqlReader.IsDBNull(78)) 
					dataObj.ZHRGRSG = sqlReader.GetDecimal(78);
				if(!sqlReader.IsDBNull(79)) 
					dataObj.ACCOUNT = sqlReader.GetString(79);
				if(!sqlReader.IsDBNull(80)) 
					dataObj.ZHRTC = sqlReader.GetString(80);
				if(!sqlReader.IsDBNull(81)) 
					dataObj.SF_SS_EDUCATION_BEGDA = sqlReader.GetString(81);
				if(!sqlReader.IsDBNull(82)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(82);
				if(!sqlReader.IsDBNull(83)) 
					dataObj.SEND_ERROR = sqlReader.GetString(83);
				if(!sqlReader.IsDBNull(84)) 
					dataObj.DT_ZG_TYPE_NAME = sqlReader.GetString(84);
				if(!sqlReader.IsDBNull(85)) 
					dataObj.SF_SS_EDUCATION_SLART = sqlReader.GetString(85);
				if(!sqlReader.IsDBNull(86)) 
					dataObj.SF_BK_EDUCATION_ENDDA = sqlReader.GetString(86);
				if(!sqlReader.IsDBNull(87)) 
					dataObj.ZHRWZMC = sqlReader.GetString(87);
				if(!sqlReader.IsDBNull(88)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(88);
				if(!sqlReader.IsDBNull(89)) 
					dataObj.NACHN = sqlReader.GetString(89);
				if(!sqlReader.IsDBNull(90)) 
					dataObj.USER_ID = sqlReader.GetString(90);
				if(!sqlReader.IsDBNull(91)) 
					dataObj.USRID_MAIL = sqlReader.GetString(91);
				if(!sqlReader.IsDBNull(92)) 
					dataObj.ZHRBZ = sqlReader.GetString(92);
				if(!sqlReader.IsDBNull(93)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(93);
				if(!sqlReader.IsDBNull(94)) 
					dataObj.STAFF_IS_NURSE_NAME = sqlReader.GetString(94);
				if(!sqlReader.IsDBNull(95)) 
					dataObj.USRID_TEL = sqlReader.GetString(95);
				if (!sqlReader.IsDBNull(96))
					dataObj.JWBS = sqlReader.GetString(96);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			IDALProvider.IDAL.PushConnection(connection);
			#endregion 
			DisplayObject_V_HEM_B_STAFF_APPLY_NPOI[] objs = new DisplayObject_V_HEM_B_STAFF_APPLY_NPOI[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		public static DisplayObject_V_HEM_B_STAFF_APPLY_NPOI[] Query(CauseObject_V_HEM_B_STAFF_APPLY_NPOI cause,PagingParamter paging,OrderByParameter order,IDbTransaction trans)
		{
			
			//平台自动生成代码
			#region Parameters Block
			OracleParameter[] parameters = null;
			IDataReader sqlReader = null;
			#endregion 
            string sSql = " select  V_HEM_B_STAFF_APPLY_NPOI.IS_PUBLIC, V_HEM_B_STAFF_APPLY_NPOI.SF_GZ_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_ZHRDSXM, V_HEM_B_STAFF_APPLY_NPOI.TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.STAFF_TYPE_ID, V_HEM_B_STAFF_APPLY_NPOI.ESB, V_HEM_B_STAFF_APPLY_NPOI.SEX, V_HEM_B_STAFF_APPLY_NPOI.DT_SS_TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_ZHRJSJSP_NAME, V_HEM_B_STAFF_APPLY_NPOI.ICNUM, V_HEM_B_STAFF_APPLY_NPOI.EQW, V_HEM_B_STAFF_APPLY_NPOI.ZHRJG, V_HEM_B_STAFF_APPLY_NPOI.STAFF_ID, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.STATUS, V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_IS_USABL, V_HEM_B_STAFF_APPLY_NPOI.STATUS_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.DT_BS_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.EYB, V_HEM_B_STAFF_APPLY_NPOI.ZHRTZGG, V_HEM_B_STAFF_APPLY_NPOI.IS_SEND, V_HEM_B_STAFF_APPLY_NPOI.STAFF_IS_NURSE, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_ZHRDSXM, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_INSTI, V_HEM_B_STAFF_APPLY_NPOI.GESCH, V_HEM_B_STAFF_APPLY_NPOI.MSSAGE_ID, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.IS_CERTIFICATE, V_HEM_B_STAFF_APPLY_NPOI.CONTENT, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.RACKY_NAME, V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_ID, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.POSTER_ID, V_HEM_B_STAFF_APPLY_NPOI.SECONDCHOICE, V_HEM_B_STAFF_APPLY_NPOI.OPERATOR_ONE, V_HEM_B_STAFF_APPLY_NPOI.ZHRGRTZ, V_HEM_B_STAFF_APPLY_NPOI.SF_BS_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.SF_ZHRWYSP_NAME, V_HEM_B_STAFF_APPLY_NPOI.ID, V_HEM_B_STAFF_APPLY_NPOI.SF_WORK_SX_ZHRXXDW, V_HEM_B_STAFF_APPLY_NPOI.SF_FAMST_NAME, V_HEM_B_STAFF_APPLY_NPOI.ZHRHJJL, V_HEM_B_STAFF_APPLY_NPOI.SX_ZHRGZNX, V_HEM_B_STAFF_APPLY_NPOI.DT_HH_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.RECRUIT_POSITION, V_HEM_B_STAFF_APPLY_NPOI.ESC, V_HEM_B_STAFF_APPLY_NPOI.SF_WORK_YJ_ZHRXXDW, V_HEM_B_STAFF_APPLY_NPOI.DT_BS_TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.ESA, V_HEM_B_STAFF_APPLY_NPOI.YJ_ZHRGZNX, V_HEM_B_STAFF_APPLY_NPOI.WRITTEN_THEORY, V_HEM_B_STAFF_APPLY_NPOI.EOTHER, V_HEM_B_STAFF_APPLY_NPOI.PCODE_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.CREATE_DATE, V_HEM_B_STAFF_APPLY_NPOI.TYPE_ID, V_HEM_B_STAFF_APPLY_NPOI.GBDAT, V_HEM_B_STAFF_APPLY_NPOI.PRACTICE_TYPE_ID_NAME, V_HEM_B_STAFF_APPLY_NPOI.EHX, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.ZHRSLJZ, V_HEM_B_STAFF_APPLY_NPOI.FIRSTCHOICE, V_HEM_B_STAFF_APPLY_NPOI.DT_SS_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.WRITTEN_ENGLISH, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_ZHRXKZY1, V_HEM_B_STAFF_APPLY_NPOI.ZHRSXXX, V_HEM_B_STAFF_APPLY_NPOI.ESCI, V_HEM_B_STAFF_APPLY_NPOI.DT_BK_EDUCATION_NAME, V_HEM_B_STAFF_APPLY_NPOI.WRITTEN_TOTAL, V_HEM_B_STAFF_APPLY_NPOI.SF_HH_EDUCATION_ZHRDSXM, V_HEM_B_STAFF_APPLY_NPOI.REAL_ZHRGRTZ, V_HEM_B_STAFF_APPLY_NPOI.REAL_ZHRGRSG, V_HEM_B_STAFF_APPLY_NPOI.ZHRGRSG, V_HEM_B_STAFF_APPLY_NPOI.ACCOUNT, V_HEM_B_STAFF_APPLY_NPOI.ZHRTC, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_BEGDA, V_HEM_B_STAFF_APPLY_NPOI.MANAGE_USER_ID_NAME, V_HEM_B_STAFF_APPLY_NPOI.SEND_ERROR, V_HEM_B_STAFF_APPLY_NPOI.DT_ZG_TYPE_NAME, V_HEM_B_STAFF_APPLY_NPOI.SF_SS_EDUCATION_SLART, V_HEM_B_STAFF_APPLY_NPOI.SF_BK_EDUCATION_ENDDA, V_HEM_B_STAFF_APPLY_NPOI.ZHRWZMC, V_HEM_B_STAFF_APPLY_NPOI.REAL_ZHRSLJZ, V_HEM_B_STAFF_APPLY_NPOI.NACHN, V_HEM_B_STAFF_APPLY_NPOI.USER_ID, V_HEM_B_STAFF_APPLY_NPOI.USRID_MAIL, V_HEM_B_STAFF_APPLY_NPOI.ZHRBZ, V_HEM_B_STAFF_APPLY_NPOI.USER_IS_USABL, V_HEM_B_STAFF_APPLY_NPOI.STAFF_IS_NURSE_NAME, V_HEM_B_STAFF_APPLY_NPOI.USRID_TEL,V_HEM_B_STAFF_APPLY_NPOI.OUTOCEAN, V_HEM_B_STAFF_APPLY_NPOI.JWBS from V_HEM_B_STAFF_APPLY_NPOI where (1=1)";
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
				sqlReader = IDALProvider.IDAL.ExecutePagingReader("V_HEM_B_STAFF_APPLY_NPOI",paging, order, sSql, parameters, trans);
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
			DisplayObject_V_HEM_B_STAFF_APPLY_NPOI dataObj = null;
			ArrayList objArray = new ArrayList();
			while (sqlReader.Read())
			{
				dataObj = new DisplayObject_V_HEM_B_STAFF_APPLY_NPOI();
				if(!sqlReader.IsDBNull(0)) 
					dataObj.IS_PUBLIC = sqlReader.GetDecimal(0);
				if(!sqlReader.IsDBNull(1)) 
					dataObj.SF_GZ_EDUCATION_INSTI = sqlReader.GetString(1);
				if(!sqlReader.IsDBNull(2)) 
					dataObj.SF_BS_EDUCATION_INSTI = sqlReader.GetString(2);
				if(!sqlReader.IsDBNull(3)) 
					dataObj.SF_SS_EDUCATION_ZHRDSXM = sqlReader.GetString(3);
				if(!sqlReader.IsDBNull(4)) 
					dataObj.TYPE_NAME = sqlReader.GetString(4);
				if(!sqlReader.IsDBNull(5)) 
					dataObj.STAFF_TYPE_ID = sqlReader.GetString(5);
				if(!sqlReader.IsDBNull(6)) 
					dataObj.ESB = sqlReader.GetDecimal(6);
				if(!sqlReader.IsDBNull(7)) 
					dataObj.SEX = sqlReader.GetString(7);
				if(!sqlReader.IsDBNull(8)) 
					dataObj.DT_SS_TYPE_NAME = sqlReader.GetString(8);
				if(!sqlReader.IsDBNull(9)) 
					dataObj.SF_ZHRJSJSP_NAME = sqlReader.GetString(9);
				if(!sqlReader.IsDBNull(10)) 
					dataObj.ICNUM = sqlReader.GetString(10);
				if(!sqlReader.IsDBNull(11)) 
					dataObj.EQW = sqlReader.GetDecimal(11);
				if(!sqlReader.IsDBNull(12)) 
					dataObj.ZHRJG = sqlReader.GetString(12);
				if(!sqlReader.IsDBNull(13)) 
					dataObj.STAFF_ID = sqlReader.GetString(13);
				if(!sqlReader.IsDBNull(14)) 
					dataObj.SF_BK_EDUCATION_INSTI = sqlReader.GetString(14);
				if(!sqlReader.IsDBNull(15)) 
					dataObj.STATUS = sqlReader.GetDecimal(15);
				if(!sqlReader.IsDBNull(16)) 
					dataObj.MANAGE_USER_IS_USABL = sqlReader.GetDecimal(16);
				if(!sqlReader.IsDBNull(17)) 
					dataObj.STATUS_NAME = sqlReader.GetString(17);
				if(!sqlReader.IsDBNull(18)) 
					dataObj.SF_BS_EDUCATION_ZHRXKZY1 = sqlReader.GetString(18);
				if(!sqlReader.IsDBNull(19)) 
					dataObj.DT_BS_EDUCATION_NAME = sqlReader.GetString(19);
				if(!sqlReader.IsDBNull(20)) 
					dataObj.EYB = sqlReader.GetDecimal(20);
				if(!sqlReader.IsDBNull(21)) 
					dataObj.ZHRTZGG = sqlReader.GetDecimal(21);
				if(!sqlReader.IsDBNull(22)) 
					dataObj.IS_SEND = sqlReader.GetDecimal(22);
				if(!sqlReader.IsDBNull(23)) 
					dataObj.STAFF_IS_NURSE = sqlReader.GetDecimal(23);
				if(!sqlReader.IsDBNull(24)) 
					dataObj.SF_BS_EDUCATION_ZHRDSXM = sqlReader.GetString(24);
				if(!sqlReader.IsDBNull(25)) 
					dataObj.SF_BS_EDUCATION_ENDDA = sqlReader.GetString(25);
				if(!sqlReader.IsDBNull(26)) 
					dataObj.SF_SS_EDUCATION_INSTI = sqlReader.GetString(26);
				if(!sqlReader.IsDBNull(27)) 
					dataObj.SF_HH_EDUCATION_INSTI = sqlReader.GetString(27);
				if(!sqlReader.IsDBNull(28)) 
					dataObj.GESCH = sqlReader.GetString(28);
				if(!sqlReader.IsDBNull(29)) 
					dataObj.MSSAGE_ID = sqlReader.GetString(29);
				if(!sqlReader.IsDBNull(30)) 
					dataObj.SF_BK_EDUCATION_BEGDA = sqlReader.GetString(30);
				if(!sqlReader.IsDBNull(31)) 
					dataObj.IS_CERTIFICATE = sqlReader.GetDecimal(31);
				if(!sqlReader.IsDBNull(32)) 
					dataObj.CONTENT = sqlReader.GetString(32);
				if(!sqlReader.IsDBNull(33)) 
					dataObj.SF_HH_EDUCATION_ENDDA = sqlReader.GetString(33);
				if(!sqlReader.IsDBNull(34)) 
					dataObj.RACKY_NAME = sqlReader.GetString(34);
				if(!sqlReader.IsDBNull(35)) 
					dataObj.MANAGE_USER_ID = sqlReader.GetString(35);
				if(!sqlReader.IsDBNull(36)) 
					dataObj.SF_BK_EDUCATION_ZHRXKZY1 = sqlReader.GetString(36);
				if(!sqlReader.IsDBNull(37)) 
					dataObj.SF_SS_EDUCATION_ENDDA = sqlReader.GetString(37);
				if(!sqlReader.IsDBNull(38)) 
					dataObj.POSTER_ID = sqlReader.GetString(38);
				if(!sqlReader.IsDBNull(39)) 
					dataObj.SECONDCHOICE = sqlReader.GetString(39);
				if(!sqlReader.IsDBNull(40)) 
					dataObj.OPERATOR_ONE = sqlReader.GetDecimal(40);
				if(!sqlReader.IsDBNull(41)) 
					dataObj.ZHRGRTZ = sqlReader.GetDecimal(41);
				if(!sqlReader.IsDBNull(42)) 
					dataObj.SF_BS_EDUCATION_BEGDA = sqlReader.GetString(42);
				if(!sqlReader.IsDBNull(43)) 
					dataObj.SF_ZHRWYSP_NAME = sqlReader.GetString(43);
				if(!sqlReader.IsDBNull(44)) 
					dataObj.ID = sqlReader.GetString(44);
				if(!sqlReader.IsDBNull(45)) 
					dataObj.SF_WORK_SX_ZHRXXDW = sqlReader.GetString(45);
				if(!sqlReader.IsDBNull(46)) 
					dataObj.SF_FAMST_NAME = sqlReader.GetString(46);
				if(!sqlReader.IsDBNull(47)) 
					dataObj.ZHRHJJL = sqlReader.GetString(47);
				if(!sqlReader.IsDBNull(48)) 
					dataObj.SX_ZHRGZNX = sqlReader.GetString(48);
				if(!sqlReader.IsDBNull(49)) 
					dataObj.DT_HH_EDUCATION_NAME = sqlReader.GetString(49);
				if(!sqlReader.IsDBNull(50)) 
					dataObj.RECRUIT_POSITION = sqlReader.GetString(50);
				if(!sqlReader.IsDBNull(51)) 
					dataObj.ESC = sqlReader.GetDecimal(51);
				if(!sqlReader.IsDBNull(52)) 
					dataObj.SF_WORK_YJ_ZHRXXDW = sqlReader.GetString(52);
				if(!sqlReader.IsDBNull(53)) 
					dataObj.DT_BS_TYPE_NAME = sqlReader.GetString(53);
				if(!sqlReader.IsDBNull(54)) 
					dataObj.ESA = sqlReader.GetDecimal(54);
				if(!sqlReader.IsDBNull(55)) 
					dataObj.YJ_ZHRGZNX = sqlReader.GetString(55);
				if(!sqlReader.IsDBNull(56)) 
					dataObj.WRITTEN_THEORY = sqlReader.GetDecimal(56);
				if(!sqlReader.IsDBNull(57)) 
					dataObj.EOTHER = sqlReader.GetDecimal(57);
				if(!sqlReader.IsDBNull(58)) 
					dataObj.PCODE_NAME = sqlReader.GetString(58);
				if(!sqlReader.IsDBNull(59)) 
					dataObj.SF_HH_EDUCATION_BEGDA = sqlReader.GetString(59);
				if(!sqlReader.IsDBNull(60)) 
					dataObj.CREATE_DATE = sqlReader.GetDateTime(60);
				if(!sqlReader.IsDBNull(61)) 
					dataObj.TYPE_ID = sqlReader.GetString(61);
				if(!sqlReader.IsDBNull(62)) 
					dataObj.GBDAT = sqlReader.GetDateTime(62);
				if(!sqlReader.IsDBNull(63)) 
					dataObj.PRACTICE_TYPE_ID_NAME = sqlReader.GetString(63);
				if(!sqlReader.IsDBNull(64)) 
					dataObj.EHX = sqlReader.GetDecimal(64);
				if(!sqlReader.IsDBNull(65)) 
					dataObj.SF_HH_EDUCATION_ZHRXKZY1 = sqlReader.GetString(65);
				if(!sqlReader.IsDBNull(66)) 
					dataObj.ZHRSLJZ = sqlReader.GetString(66);
				if(!sqlReader.IsDBNull(67)) 
					dataObj.FIRSTCHOICE = sqlReader.GetString(67);
				if(!sqlReader.IsDBNull(68)) 
					dataObj.DT_SS_EDUCATION_NAME = sqlReader.GetString(68);
				if(!sqlReader.IsDBNull(69)) 
					dataObj.WRITTEN_ENGLISH = sqlReader.GetDecimal(69);
				if(!sqlReader.IsDBNull(70)) 
					dataObj.SF_SS_EDUCATION_ZHRXKZY1 = sqlReader.GetString(70);
				if(!sqlReader.IsDBNull(71)) 
					dataObj.ZHRSXXX = sqlReader.GetString(71);
				if(!sqlReader.IsDBNull(72)) 
					dataObj.ESCI = sqlReader.GetDecimal(72);
				if(!sqlReader.IsDBNull(73)) 
					dataObj.DT_BK_EDUCATION_NAME = sqlReader.GetString(73);
				if(!sqlReader.IsDBNull(74)) 
					dataObj.WRITTEN_TOTAL = sqlReader.GetDecimal(74);
				if(!sqlReader.IsDBNull(75)) 
					dataObj.SF_HH_EDUCATION_ZHRDSXM = sqlReader.GetString(75);
				if(!sqlReader.IsDBNull(76)) 
					dataObj.REAL_ZHRGRTZ = sqlReader.GetDecimal(76);
				if(!sqlReader.IsDBNull(77)) 
					dataObj.REAL_ZHRGRSG = sqlReader.GetDecimal(77);
				if(!sqlReader.IsDBNull(78)) 
					dataObj.ZHRGRSG = sqlReader.GetDecimal(78);
				if(!sqlReader.IsDBNull(79)) 
					dataObj.ACCOUNT = sqlReader.GetString(79);
				if(!sqlReader.IsDBNull(80)) 
					dataObj.ZHRTC = sqlReader.GetString(80);
				if(!sqlReader.IsDBNull(81)) 
					dataObj.SF_SS_EDUCATION_BEGDA = sqlReader.GetString(81);
				if(!sqlReader.IsDBNull(82)) 
					dataObj.MANAGE_USER_ID_NAME = sqlReader.GetString(82);
				if(!sqlReader.IsDBNull(83)) 
					dataObj.SEND_ERROR = sqlReader.GetString(83);
				if(!sqlReader.IsDBNull(84)) 
					dataObj.DT_ZG_TYPE_NAME = sqlReader.GetString(84);
				if(!sqlReader.IsDBNull(85)) 
					dataObj.SF_SS_EDUCATION_SLART = sqlReader.GetString(85);
				if(!sqlReader.IsDBNull(86)) 
					dataObj.SF_BK_EDUCATION_ENDDA = sqlReader.GetString(86);
				if(!sqlReader.IsDBNull(87)) 
					dataObj.ZHRWZMC = sqlReader.GetString(87);
				if(!sqlReader.IsDBNull(88)) 
					dataObj.REAL_ZHRSLJZ = sqlReader.GetDecimal(88);
				if(!sqlReader.IsDBNull(89)) 
					dataObj.NACHN = sqlReader.GetString(89);
				if(!sqlReader.IsDBNull(90)) 
					dataObj.USER_ID = sqlReader.GetString(90);
				if(!sqlReader.IsDBNull(91)) 
					dataObj.USRID_MAIL = sqlReader.GetString(91);
				if(!sqlReader.IsDBNull(92)) 
					dataObj.ZHRBZ = sqlReader.GetString(92);
				if(!sqlReader.IsDBNull(93)) 
					dataObj.USER_IS_USABL = sqlReader.GetDecimal(93);
				if(!sqlReader.IsDBNull(94)) 
					dataObj.STAFF_IS_NURSE_NAME = sqlReader.GetString(94);
				if(!sqlReader.IsDBNull(95)) 
					dataObj.USRID_TEL = sqlReader.GetString(95);
                if (!sqlReader.IsDBNull(96))
                    dataObj.OUTOCEAN = sqlReader.GetString(96);
				if (!sqlReader.IsDBNull(97))
					dataObj.JWBS = sqlReader.GetString(97);
				objArray.Add(dataObj);
			}
			sqlReader.Close();
			#endregion 
			DisplayObject_V_HEM_B_STAFF_APPLY_NPOI[] objs = new DisplayObject_V_HEM_B_STAFF_APPLY_NPOI[objArray.Count];
			objArray.CopyTo(0,objs,0,objs.Length);
			return objs;
		}
		#endregion 
	}
}
