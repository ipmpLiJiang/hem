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
	public partial class HelperObject_V_USER_LOGIN_INFO
	{
        public static DisplayObject_V_USER_LOGIN_INFO Login(CauseObject_V_USER_LOGIN_INFO cause)
        {

            //平台自动生成代码
            string sSql = "select ID,ACCOUNT,PASSWORD,FLAG,IS_USABL,USER_ID,NAME,MOBILE,EMAIL,CREATE_DATE from V_USER_LOGIN_INFO where  ACCOUNT = :ACCOUNT AND PASSWORD = :PASSWORD AND FLAG = :FLAG ";
            //string sSql = "select ID,ACCOUNT,PASSWORD,FLAG,IS_USABL,USER_ID,NAME,MOBILE,EMAIL,CREATE_DATE from V_USER_LOGIN_INFO where  ACCOUNT = :ACCOUNT AND PASSWORD = :PASSWORD AND FLAG = :FLAG ";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[3];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":ACCOUNT";
            parameters[0].Size = 11;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[0].Value = cause.ACCOUNT;
            parameters[1] = new OracleParameter();
            parameters[1].ParameterName = ":PASSWORD";
            parameters[1].Size = 50;
            parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[1].Value = cause.PASSWORD;
            parameters[2] = new OracleParameter();
            parameters[2].ParameterName = ":FLAG";
            parameters[2].Size = 3;
            parameters[2].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[2].Value = cause.FLAG;
            #endregion
            #region Push Block
            DisplayObject_V_USER_LOGIN_INFO dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_V_USER_LOGIN_INFO();
                if (!sqlReader.IsDBNull(0))
                    dataObj.ID = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.ACCOUNT = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.PASSWORD = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.FLAG = sqlReader.GetDecimal(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.IS_USABL = sqlReader.GetDecimal(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.USER_ID = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.NAME = sqlReader.GetString(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.MOBILE = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.EMAIL = sqlReader.GetString(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.CREATE_DATE = sqlReader.GetDateTime(9);
                objArray.Add(dataObj);
                //ID,ACCOUNT,PASSWORD,FLAG,IS_USABL,USER_ID,NAME,MOBILE,EMAIL,CREATE_DATE
            }
            sqlReader.Close();
            #endregion
            DisplayObject_V_USER_LOGIN_INFO[] objs = new DisplayObject_V_USER_LOGIN_INFO[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs.Length == 0 ? null : objs[0];
        }
	}
}
