using System;
using System.Data;
using System.Data.OracleClient;
using System.Collections;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Collections.Generic;
using Ipedf.Core;
using ConstLibrary = Ipedf.Common;
using Ipedf.Hrp.Hem.Sap.Entity;

namespace Ipedf.Hrp.Hem.Sap.DataAccess
{
    [CauseObject(typeof(CauseObject_HEM_B_USER_LOGIN))]
    public partial class HelperObject_HEM_B_USER_LOGIN
    {
        #region Method Blok
        public static int Save(EntityObject_HEM_B_USER_LOGIN obj, IDbTransaction trans)
        {

            //平台自动生成代码
            obj.ID = Guid.NewGuid().ToString();
            string sSql = "insert into HEM_B_USER_LOGIN( IS_USABL, ACCOUNT, PASSWORD, ID, FLAG) values ( :IS_USABL, :ACCOUNT, :PASSWORD, :ID, :FLAG)";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[5];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":IS_USABL";
            parameters[0].Size = 22;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[0].Value = obj.IS_USABL;
            parameters[1] = new OracleParameter();
            parameters[1].ParameterName = ":ACCOUNT";
            parameters[1].Size = 11;
            parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[1].Value = obj.ACCOUNT == null ? String.Empty : obj.ACCOUNT;
            parameters[2] = new OracleParameter();
            parameters[2].ParameterName = ":PASSWORD";
            parameters[2].Size = 50;
            parameters[2].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[2].Value = obj.PASSWORD == null ? String.Empty : obj.PASSWORD;
            parameters[3] = new OracleParameter();
            parameters[3].ParameterName = ":ID";
            parameters[3].Size = 36;
            parameters[3].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[3].Value = obj.ID == null ? String.Empty : obj.ID;
            parameters[4] = new OracleParameter();
            parameters[4].ParameterName = ":FLAG";
            parameters[4].Size = 22;
            parameters[4].OracleType = System.Data.OracleClient.OracleType.Number;
            parameters[4].Value = obj.FLAG;
            #endregion
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static int Update(EntityObject_HEM_B_USER_LOGIN obj, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = "update HEM_B_USER_LOGIN set ";
            sSql += PrepareUpdate(obj, out parameters);
            sSql += " where  ID = :ID ";
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static int Delete(EntityObject_HEM_B_USER_LOGIN obj, IDbTransaction trans)
        {

            //平台自动生成代码
            string sSql = "delete from HEM_B_USER_LOGIN where  ID = :ID ";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = obj.ID;
            #endregion
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static EntityObject_HEM_B_USER_LOGIN Get(EntityObject_HEM_B_USER_LOGIN obj)
        {

            //平台自动生成代码
            string sSql = "select  IS_USABL, ACCOUNT, PASSWORD, ID, FLAG from HEM_B_USER_LOGIN where  ID = :ID ";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = obj.ID;
            #endregion
            #region Push Block
            EntityObject_HEM_B_USER_LOGIN dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new EntityObject_HEM_B_USER_LOGIN();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IS_USABL = sqlReader.GetDecimal(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.ACCOUNT = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.PASSWORD = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.FLAG = sqlReader.GetDecimal(4);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            EntityObject_HEM_B_USER_LOGIN[] objs = new EntityObject_HEM_B_USER_LOGIN[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs.Length == 0 ? null : objs[0];
        }
        public static EntityObject_HEM_B_USER_LOGIN Get(EntityObject_HEM_B_USER_LOGIN obj, IDbTransaction trans)
        {

            //平台自动生成代码
            string sSql = "select  IS_USABL, ACCOUNT, PASSWORD, ID, FLAG from HEM_B_USER_LOGIN where  ID = :ID ";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = obj.ID;
            #endregion
            #region Push Block
            EntityObject_HEM_B_USER_LOGIN dataObj = null;
            ArrayList objArray = new ArrayList();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
            while (sqlReader.Read())
            {
                dataObj = new EntityObject_HEM_B_USER_LOGIN();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IS_USABL = sqlReader.GetDecimal(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.ACCOUNT = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.PASSWORD = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.FLAG = sqlReader.GetDecimal(4);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            EntityObject_HEM_B_USER_LOGIN[] objs = new EntityObject_HEM_B_USER_LOGIN[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs.Length == 0 ? null : objs[0];
        }
        public static DisplayObject_HEM_B_USER_LOGIN[] List()
        {

            //平台自动生成代码
            string sSql = " select  HEM_B_USER_LOGIN.IS_USABL, HEM_B_USER_LOGIN.ACCOUNT, HEM_B_USER_LOGIN.PASSWORD, HEM_B_USER_LOGIN.ID, HEM_B_USER_LOGIN.FLAG from HEM_B_USER_LOGIN where (1=1)";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[0];
            #endregion
            #region Push Block
            DisplayObject_HEM_B_USER_LOGIN dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_HEM_B_USER_LOGIN();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IS_USABL = sqlReader.GetDecimal(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.ACCOUNT = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.PASSWORD = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.FLAG = sqlReader.GetDecimal(4);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_HEM_B_USER_LOGIN[] objs = new DisplayObject_HEM_B_USER_LOGIN[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static string PrepareCause(CauseObject_HEM_B_USER_LOGIN cause, out OracleParameter[] parameters)
        {

            //平台自动生成代码
            System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
            ArrayList paramList = new ArrayList();
            OracleParameter param = null;
            #region Push Block
            if (cause.IS_USABL != ConstLibrary.Template.UndefineDecimal)
            {
                strBuf.Append(" And HEM_B_USER_LOGIN.IS_USABL = :IS_USABL");
                param = new OracleParameter();
                param.ParameterName = ":IS_USABL";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = cause.IS_USABL;
                paramList.Add(param);
            }
            if (cause.HasINValue("IS_USABL"))
            {
                strBuf.Append(cause.GetINSQL("HEM_B_USER_LOGIN", "IS_USABL"));
            }
            if (!string.IsNullOrEmpty(cause.ACCOUNT))
            {
                strBuf.Append(" And HEM_B_USER_LOGIN.ACCOUNT ").Append((cause.ACCOUNT.StartsWith("%") || cause.ACCOUNT.EndsWith("%")) ? " like " : " = ").Append(" :ACCOUNT");
                param = new OracleParameter();
                param.ParameterName = ":ACCOUNT";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 11;
                param.Value = cause.ACCOUNT;
                paramList.Add(param);
            }
            if (cause.HasINValue("ACCOUNT"))
            {
                strBuf.Append(cause.GetINSQL("HEM_B_USER_LOGIN", "ACCOUNT"));
            }
            if (!string.IsNullOrEmpty(cause.PASSWORD))
            {
                strBuf.Append(" And HEM_B_USER_LOGIN.PASSWORD ").Append((cause.PASSWORD.StartsWith("%") || cause.PASSWORD.EndsWith("%")) ? " like " : " = ").Append(" :PASSWORD");
                param = new OracleParameter();
                param.ParameterName = ":PASSWORD";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = cause.PASSWORD;
                paramList.Add(param);
            }
            if (cause.HasINValue("PASSWORD"))
            {
                strBuf.Append(cause.GetINSQL("HEM_B_USER_LOGIN", "PASSWORD"));
            }
            if (!string.IsNullOrEmpty(cause.ID))
            {
                strBuf.Append(" And HEM_B_USER_LOGIN.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
                param = new OracleParameter();
                param.ParameterName = ":ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("ID"))
            {
                strBuf.Append(cause.GetINSQL("HEM_B_USER_LOGIN", "ID"));
            }
            if (cause.FLAG != ConstLibrary.Template.UndefineDecimal)
            {
                strBuf.Append(" And HEM_B_USER_LOGIN.FLAG = :FLAG");
                param = new OracleParameter();
                param.ParameterName = ":FLAG";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = cause.FLAG;
                paramList.Add(param);
            }
            if (cause.HasINValue("FLAG"))
            {
                strBuf.Append(cause.GetINSQL("HEM_B_USER_LOGIN", "FLAG"));
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
        public static DisplayObject_HEM_B_USER_LOGIN[] Query(CauseObject_HEM_B_USER_LOGIN cause)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  HEM_B_USER_LOGIN.IS_USABL, HEM_B_USER_LOGIN.ACCOUNT, HEM_B_USER_LOGIN.PASSWORD, HEM_B_USER_LOGIN.ID, HEM_B_USER_LOGIN.FLAG from HEM_B_USER_LOGIN where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            DisplayObject_HEM_B_USER_LOGIN dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_HEM_B_USER_LOGIN();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IS_USABL = sqlReader.GetDecimal(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.ACCOUNT = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.PASSWORD = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.FLAG = sqlReader.GetDecimal(4);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_HEM_B_USER_LOGIN[] objs = new DisplayObject_HEM_B_USER_LOGIN[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static int Delete(CauseObject_HEM_B_USER_LOGIN cause, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = "delete from HEM_B_USER_LOGIN where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static DisplayObject_HEM_B_USER_LOGIN[] Query(CauseObject_HEM_B_USER_LOGIN cause, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  HEM_B_USER_LOGIN.IS_USABL, HEM_B_USER_LOGIN.ACCOUNT, HEM_B_USER_LOGIN.PASSWORD, HEM_B_USER_LOGIN.ID, HEM_B_USER_LOGIN.FLAG from HEM_B_USER_LOGIN where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            DisplayObject_HEM_B_USER_LOGIN dataObj = null;
            ArrayList objArray = new ArrayList();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_HEM_B_USER_LOGIN();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IS_USABL = sqlReader.GetDecimal(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.ACCOUNT = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.PASSWORD = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.FLAG = sqlReader.GetDecimal(4);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            DisplayObject_HEM_B_USER_LOGIN[] objs = new DisplayObject_HEM_B_USER_LOGIN[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_HEM_B_USER_LOGIN[] Query(CauseObject_HEM_B_USER_LOGIN cause, PagingParamter paging, OrderByParameter order)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = " select  HEM_B_USER_LOGIN.IS_USABL, HEM_B_USER_LOGIN.ACCOUNT, HEM_B_USER_LOGIN.PASSWORD, HEM_B_USER_LOGIN.ID, HEM_B_USER_LOGIN.FLAG from HEM_B_USER_LOGIN where (1=1)";
            string sCauseSql = PrepareCause(cause, out parameters);
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
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_USER_LOGIN", paging, order, sSql, parameters, connection);
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
            DisplayObject_HEM_B_USER_LOGIN dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_HEM_B_USER_LOGIN();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IS_USABL = sqlReader.GetDecimal(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.ACCOUNT = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.PASSWORD = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.FLAG = sqlReader.GetDecimal(4);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_HEM_B_USER_LOGIN[] objs = new DisplayObject_HEM_B_USER_LOGIN[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_HEM_B_USER_LOGIN[] Query(CauseObject_HEM_B_USER_LOGIN cause, PagingParamter paging, OrderByParameter order, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = " select  HEM_B_USER_LOGIN.IS_USABL, HEM_B_USER_LOGIN.ACCOUNT, HEM_B_USER_LOGIN.PASSWORD, HEM_B_USER_LOGIN.ID, HEM_B_USER_LOGIN.FLAG from HEM_B_USER_LOGIN where (1=1)";
            string sCauseSql = PrepareCause(cause, out parameters);
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
                    paging.TotalRecords = IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.SqlServer || IDALProvider.IDAL.DatabaseType == Ipedf.Common.DatabaseType.Db2 ? (int)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans) : (int)(decimal)IDALProvider.IDAL.ExecuteScalar(countSql, parameters, trans);
                }
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_USER_LOGIN", paging, order, sSql, parameters, trans);
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
            DisplayObject_HEM_B_USER_LOGIN dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_HEM_B_USER_LOGIN();
                if (!sqlReader.IsDBNull(0))
                    dataObj.IS_USABL = sqlReader.GetDecimal(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.ACCOUNT = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.PASSWORD = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.ID = sqlReader.GetString(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.FLAG = sqlReader.GetDecimal(4);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            DisplayObject_HEM_B_USER_LOGIN[] objs = new DisplayObject_HEM_B_USER_LOGIN[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static string PrepareUpdate(EntityObject_HEM_B_USER_LOGIN obj, out OracleParameter[] parameters)
        {

            //平台自动生成代码
            List<string> strBuf = new List<string>();
            ArrayList paramList = new ArrayList();
            OracleParameter param = null;
            #region Push Block
            if (!obj.IsNotUpdate("IS_USABL"))
            {
                strBuf.Add("  HEM_B_USER_LOGIN.IS_USABL = :IS_USABL");
                param = new OracleParameter();
                param.ParameterName = ":IS_USABL";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = obj.IS_USABL;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("ACCOUNT"))
            {
                strBuf.Add("  HEM_B_USER_LOGIN.ACCOUNT = :ACCOUNT");
                param = new OracleParameter();
                param.ParameterName = ":ACCOUNT";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 11;
                param.Value = string.IsNullOrEmpty(obj.ACCOUNT) ? string.Empty : obj.ACCOUNT;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("PASSWORD"))
            {
                strBuf.Add("  HEM_B_USER_LOGIN.PASSWORD = :PASSWORD");
                param = new OracleParameter();
                param.ParameterName = ":PASSWORD";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.PASSWORD) ? string.Empty : obj.PASSWORD;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("FLAG"))
            {
                strBuf.Add("  HEM_B_USER_LOGIN.FLAG = :FLAG");
                param = new OracleParameter();
                param.ParameterName = ":FLAG";
                param.OracleType = System.Data.OracleClient.OracleType.Number;
                param.Size = 22;
                param.Value = obj.FLAG;
                paramList.Add(param);
            }
            //pk here
            param = new OracleParameter();
            param.ParameterName = ":ID";
            param.OracleType = System.Data.OracleClient.OracleType.Char;
            param.Size = 36;
            param.Value = obj.ID;
            paramList.Add(param);
            #endregion
            parameters = new OracleParameter[paramList.Count];
            paramList.CopyTo(parameters);
            return string.Join(", ", strBuf.ToArray());

        }
        #endregion

    }
}
