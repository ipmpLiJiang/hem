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
    public partial class HelperObject_HEM_B_STAFF_APPLY
    {
        public static int MyUpdate(string STAFF_TYPE_ID, decimal STATUS, IDbTransaction trans)
        {
            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[2];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":STAFF_TYPE_ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = STAFF_TYPE_ID;
            parameters[1] = new OracleParameter();
            parameters[1].ParameterName = ":STATUS";
            parameters[1].Size = 22;
            parameters[1].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[1].Value = STATUS;
            #endregion
            string sSql = "update HEM_B_STAFF_APPLY set STATUS = :STATUS where STAFF_TYPE_ID = :STAFF_TYPE_ID AND STATUS != :STATUS";
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
    }
}
