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
	public partial class HelperObject_HEM_B_STAFF_EDUCATION
	{

        public static DisplayObject_HEM_B_STAFF_EDUCATION[] Query(EntityObject_HEM_B_STAFF_EDUCATION entity)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  HEM_B_STAFF_EDUCATION.SLART, HEM_B_STAFF_EDUCATION.ID, HEM_B_STAFF_EDUCATION.STAFF_ID, HEM_B_STAFF_EDUCATION.IS_HIGHEST, HEM_B_STAFF_EDUCATION.ZHRXYJFX, HEM_B_STAFF_EDUCATION.ZHRXKZY2, HEM_B_STAFF_EDUCATION.ENDDA, HEM_B_STAFF_EDUCATION.ZHRXKZY1, HEM_B_STAFF_EDUCATION.BEGDA, HEM_B_STAFF_EDUCATION.INSTI, HEM_B_STAFF_EDUCATION.ZHRDSXM from HEM_B_STAFF_EDUCATION where HEM_B_STAFF_EDUCATION.STAFF_ID = (SELECT STAFF_ID FROM HEM_B_STAFF_EDUCATION WHERE ID = '" + entity.ID + "' AND ROWNUM = 1)";
            //sSql += PrepareCause(cause, out parameters);
            //if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            //{
            //    sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            //}
            #region Push Block
            DisplayObject_HEM_B_STAFF_EDUCATION dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_HEM_B_STAFF_EDUCATION();
                if (!sqlReader.IsDBNull(0))
                    dataObj.SLART = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.ID = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.STAFF_ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.IS_HIGHEST = sqlReader.GetDecimal(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.ZHRXYJFX = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.ZHRXKZY2 = sqlReader.GetString(5);
                if (!sqlReader.IsDBNull(6))
                    dataObj.ENDDA = sqlReader.GetDateTime(6);
                if (!sqlReader.IsDBNull(7))
                    dataObj.ZHRXKZY1 = sqlReader.GetString(7);
                if (!sqlReader.IsDBNull(8))
                    dataObj.BEGDA = sqlReader.GetDateTime(8);
                if (!sqlReader.IsDBNull(9))
                    dataObj.INSTI = sqlReader.GetString(9);
                if (!sqlReader.IsDBNull(10))
                    dataObj.ZHRDSXM = sqlReader.GetString(10);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_HEM_B_STAFF_EDUCATION[] objs = new DisplayObject_HEM_B_STAFF_EDUCATION[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }

		
		
	}
}
