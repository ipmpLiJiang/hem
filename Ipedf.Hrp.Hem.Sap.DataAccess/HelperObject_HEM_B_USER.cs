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
    [CauseObject(typeof(CauseObject_HEM_B_USER))]
    public partial class HelperObject_HEM_B_USER
    {
        #region Method Blok
        public static int Save(EntityObject_HEM_B_USER obj, IDbTransaction trans)
        {

            //平台自动生成代码
            obj.ID = Guid.NewGuid().ToString();
            string sSql = "insert into HEM_B_USER( MOBILE, NAME, ID, CREATE_DATE, USER_LOGIN_ID, EMAIL,OUTOCEAN) values ( :MOBILE, :NAME, :ID, :CREATE_DATE, :USER_LOGIN_ID, :EMAIL, :OUTOCEAN)";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[7];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":MOBILE";
            parameters[0].Size = 11;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[0].Value = obj.MOBILE == null ? String.Empty : obj.MOBILE;
            parameters[1] = new OracleParameter();
            parameters[1].ParameterName = ":NAME";
            parameters[1].Size = 50;
            parameters[1].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[1].Value = obj.NAME == null ? String.Empty : obj.NAME;
            parameters[2] = new OracleParameter();
            parameters[2].ParameterName = ":ID";
            parameters[2].Size = 36;
            parameters[2].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[2].Value = obj.ID == null ? String.Empty : obj.ID;
            parameters[3] = new OracleParameter();
            parameters[3].ParameterName = ":CREATE_DATE";
            parameters[3].Size = 7;
            parameters[3].OracleType = System.Data.OracleClient.OracleType.DateTime;
            parameters[3].Value = obj.CREATE_DATE;
            parameters[4] = new OracleParameter();
            parameters[4].ParameterName = ":USER_LOGIN_ID";
            parameters[4].Size = 36;
            parameters[4].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[4].Value = obj.USER_LOGIN_ID == null ? String.Empty : obj.USER_LOGIN_ID;
            parameters[5] = new OracleParameter();
            parameters[5].ParameterName = ":EMAIL";
            parameters[5].Size = 50;
            parameters[5].OracleType = System.Data.OracleClient.OracleType.VarChar;
            parameters[5].Value = obj.EMAIL == null ? String.Empty : obj.EMAIL;
            parameters[6] = new OracleParameter();
            parameters[6].ParameterName = ":OUTOCEAN";
            parameters[6].Size = 22;
            parameters[6].OracleType = System.Data.OracleClient.OracleType.Number;
            if (obj.OUTOCEAN == null)
            {
                parameters[6].Value = DBNull.Value;
            }
            else
            {
                parameters[6].Value = obj.OUTOCEAN;
            }
            
            #endregion
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static int Update(EntityObject_HEM_B_USER obj, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = "update HEM_B_USER set ";
            sSql += PrepareUpdate(obj, out parameters);
            sSql += " where  ID = :ID ";
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static int Delete(EntityObject_HEM_B_USER obj, IDbTransaction trans)
        {

            //平台自动生成代码
            string sSql = "delete from HEM_B_USER where  ID = :ID ";
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
        public static EntityObject_HEM_B_USER Get(EntityObject_HEM_B_USER obj)
        {

            //平台自动生成代码
            string sSql = "select  MOBILE, NAME, ID, CREATE_DATE, USER_LOGIN_ID, EMAIL from HEM_B_USER where  ID = :ID ";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = obj.ID;
            #endregion
            #region Push Block
            EntityObject_HEM_B_USER dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new EntityObject_HEM_B_USER();
                if (!sqlReader.IsDBNull(0))
                    dataObj.MOBILE = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.NAME = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.USER_LOGIN_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.EMAIL = sqlReader.GetString(5);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            EntityObject_HEM_B_USER[] objs = new EntityObject_HEM_B_USER[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs.Length == 0 ? null : objs[0];
        }
        public static EntityObject_HEM_B_USER Get(EntityObject_HEM_B_USER obj, IDbTransaction trans)
        {

            //平台自动生成代码
            string sSql = "select  MOBILE, NAME, ID, CREATE_DATE, USER_LOGIN_ID, EMAIL from HEM_B_USER where  ID = :ID ";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[1];
            parameters[0] = new OracleParameter();
            parameters[0].ParameterName = ":ID";
            parameters[0].Size = 36;
            parameters[0].OracleType = System.Data.OracleClient.OracleType.Char;
            parameters[0].Value = obj.ID;
            #endregion
            #region Push Block
            EntityObject_HEM_B_USER dataObj = null;
            ArrayList objArray = new ArrayList();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
            while (sqlReader.Read())
            {
                dataObj = new EntityObject_HEM_B_USER();
                if (!sqlReader.IsDBNull(0))
                    dataObj.MOBILE = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.NAME = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.USER_LOGIN_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.EMAIL = sqlReader.GetString(5);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            EntityObject_HEM_B_USER[] objs = new EntityObject_HEM_B_USER[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs.Length == 0 ? null : objs[0];
        }
        public static DisplayObject_HEM_B_USER[] List()
        {

            //平台自动生成代码
            string sSql = " select  HEM_B_USER.MOBILE, HEM_B_USER.NAME, HEM_B_USER.ID, HEM_B_USER.CREATE_DATE, HEM_B_USER.USER_LOGIN_ID, HEM_B_USER.EMAIL from HEM_B_USER where (1=1)";
            #region Parameters Block
            OracleParameter[] parameters = new OracleParameter[0];
            #endregion
            #region Push Block
            DisplayObject_HEM_B_USER dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_HEM_B_USER();
                if (!sqlReader.IsDBNull(0))
                    dataObj.MOBILE = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.NAME = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.USER_LOGIN_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.EMAIL = sqlReader.GetString(5);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_HEM_B_USER[] objs = new DisplayObject_HEM_B_USER[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static string PrepareCause(CauseObject_HEM_B_USER cause, out OracleParameter[] parameters)
        {

            //平台自动生成代码
            System.Text.StringBuilder strBuf = new System.Text.StringBuilder();
            ArrayList paramList = new ArrayList();
            OracleParameter param = null;
            #region Push Block
            if (!string.IsNullOrEmpty(cause.MOBILE))
            {
                strBuf.Append(" And HEM_B_USER.MOBILE ").Append((cause.MOBILE.StartsWith("%") || cause.MOBILE.EndsWith("%")) ? " like " : " = ").Append(" :MOBILE");
                param = new OracleParameter();
                param.ParameterName = ":MOBILE";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 11;
                param.Value = cause.MOBILE;
                paramList.Add(param);
            }
            if (cause.HasINValue("MOBILE"))
            {
                strBuf.Append(cause.GetINSQL("HEM_B_USER", "MOBILE"));
            }
            if (!string.IsNullOrEmpty(cause.NAME))
            {
                strBuf.Append(" And HEM_B_USER.NAME ").Append((cause.NAME.StartsWith("%") || cause.NAME.EndsWith("%")) ? " like " : " = ").Append(" :NAME");
                param = new OracleParameter();
                param.ParameterName = ":NAME";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = cause.NAME;
                paramList.Add(param);
            }
            if (cause.HasINValue("NAME"))
            {
                strBuf.Append(cause.GetINSQL("HEM_B_USER", "NAME"));
            }
            if (!string.IsNullOrEmpty(cause.ID))
            {
                strBuf.Append(" And HEM_B_USER.ID ").Append((cause.ID.StartsWith("%") || cause.ID.EndsWith("%")) ? " like " : " = ").Append(" :ID");
                param = new OracleParameter();
                param.ParameterName = ":ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("ID"))
            {
                strBuf.Append(cause.GetINSQL("HEM_B_USER", "ID"));
            }
            if (cause.CREATE_DATE != null)
            {
                if (cause.CREATE_DATE.Begin != null)
                {
                    strBuf.Append(" And HEM_B_USER.CREATE_DATE >= :CREATE_DATE_BEGIN");
                    param = new OracleParameter();
                    param.ParameterName = ":CREATE_DATE_BEGIN";
                    param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                    param.Size = 7;
                    param.Value = cause.CREATE_DATE.Begin;
                    paramList.Add(param);
                }
                if (cause.CREATE_DATE.End != null)
                {
                    strBuf.Append(" And HEM_B_USER.CREATE_DATE < :CREATE_DATE_END");
                    param = new OracleParameter();
                    param.ParameterName = ":CREATE_DATE_END";
                    param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                    param.Size = 7;
                    param.Value = cause.CREATE_DATE.End;
                    paramList.Add(param);
                }
            }
            if (cause.HasINValue("CREATE_DATE"))
            {
                strBuf.Append(cause.GetINSQL("HEM_B_USER", "CREATE_DATE"));
            }
            if (!string.IsNullOrEmpty(cause.USER_LOGIN_ID))
            {
                strBuf.Append(" And HEM_B_USER.USER_LOGIN_ID ").Append((cause.USER_LOGIN_ID.StartsWith("%") || cause.USER_LOGIN_ID.EndsWith("%")) ? " like " : " = ").Append(" :USER_LOGIN_ID");
                param = new OracleParameter();
                param.ParameterName = ":USER_LOGIN_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = cause.USER_LOGIN_ID;
                paramList.Add(param);
            }
            if (cause.HasINValue("USER_LOGIN_ID"))
            {
                strBuf.Append(cause.GetINSQL("HEM_B_USER", "USER_LOGIN_ID"));
            }
            if (!string.IsNullOrEmpty(cause.EMAIL))
            {
                strBuf.Append(" And HEM_B_USER.EMAIL ").Append((cause.EMAIL.StartsWith("%") || cause.EMAIL.EndsWith("%")) ? " like " : " = ").Append(" :EMAIL");
                param = new OracleParameter();
                param.ParameterName = ":EMAIL";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = cause.EMAIL;
                paramList.Add(param);
            }
            if (cause.HasINValue("EMAIL"))
            {
                strBuf.Append(cause.GetINSQL("HEM_B_USER", "EMAIL"));
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
        public static DisplayObject_HEM_B_USER[] Query(CauseObject_HEM_B_USER cause)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  HEM_B_USER.MOBILE, HEM_B_USER.NAME, HEM_B_USER.ID, HEM_B_USER.CREATE_DATE, HEM_B_USER.USER_LOGIN_ID, HEM_B_USER.EMAIL from HEM_B_USER where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            DisplayObject_HEM_B_USER dataObj = null;
            ArrayList objArray = new ArrayList();
            IDbConnection connection = IDALProvider.IDAL.PopConnection();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, connection);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_HEM_B_USER();
                if (!sqlReader.IsDBNull(0))
                    dataObj.MOBILE = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.NAME = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.USER_LOGIN_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.EMAIL = sqlReader.GetString(5);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_HEM_B_USER[] objs = new DisplayObject_HEM_B_USER[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static int Delete(CauseObject_HEM_B_USER cause, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = "delete from HEM_B_USER where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }
        public static DisplayObject_HEM_B_USER[] Query(CauseObject_HEM_B_USER cause, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = " select  HEM_B_USER.MOBILE, HEM_B_USER.NAME, HEM_B_USER.ID, HEM_B_USER.CREATE_DATE, HEM_B_USER.USER_LOGIN_ID, HEM_B_USER.EMAIL from HEM_B_USER where (1=1)";
            sSql += PrepareCause(cause, out parameters);
            if (cause.Recursion != null && !string.IsNullOrEmpty(cause.Recursion.RecursionFieldValue))
            {
                sSql = "select t.* from (" + sSql + ") t,( select t." + cause.Recursion.TargetKeyFieldName + " from " + cause.Recursion.TargetDataObjectName + " t start with t." + cause.Recursion.TargetKeyFieldName + " = '" + cause.Recursion.RecursionFieldValue + "' connect by  t." + cause.Recursion.TargetLevelFieldName + "  = PRIOR t." + cause.Recursion.TargetKeyFieldName + "  ) t1 where t." + cause.Recursion.RecursionFieldName + " = t1." + cause.Recursion.TargetKeyFieldName;
            }
            #region Push Block
            DisplayObject_HEM_B_USER dataObj = null;
            ArrayList objArray = new ArrayList();
            IDataReader sqlReader = IDALProvider.IDAL.ExecuteReader(sSql, parameters, trans);
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_HEM_B_USER();
                if (!sqlReader.IsDBNull(0))
                    dataObj.MOBILE = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.NAME = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.USER_LOGIN_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.EMAIL = sqlReader.GetString(5);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            DisplayObject_HEM_B_USER[] objs = new DisplayObject_HEM_B_USER[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_HEM_B_USER[] Query(CauseObject_HEM_B_USER cause, PagingParamter paging, OrderByParameter order)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = " select  HEM_B_USER.MOBILE, HEM_B_USER.NAME, HEM_B_USER.ID, HEM_B_USER.CREATE_DATE, HEM_B_USER.USER_LOGIN_ID, HEM_B_USER.EMAIL from HEM_B_USER where (1=1)";
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
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_USER", paging, order, sSql, parameters, connection);
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
            DisplayObject_HEM_B_USER dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_HEM_B_USER();
                if (!sqlReader.IsDBNull(0))
                    dataObj.MOBILE = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.NAME = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.USER_LOGIN_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.EMAIL = sqlReader.GetString(5);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            IDALProvider.IDAL.PushConnection(connection);
            #endregion
            DisplayObject_HEM_B_USER[] objs = new DisplayObject_HEM_B_USER[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static DisplayObject_HEM_B_USER[] Query(CauseObject_HEM_B_USER cause, PagingParamter paging, OrderByParameter order, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            IDataReader sqlReader = null;
            #endregion
            string sSql = " select  HEM_B_USER.MOBILE, HEM_B_USER.NAME, HEM_B_USER.ID, HEM_B_USER.CREATE_DATE, HEM_B_USER.USER_LOGIN_ID, HEM_B_USER.EMAIL from HEM_B_USER where (1=1)";
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
                sqlReader = IDALProvider.IDAL.ExecutePagingReader("HEM_B_USER", paging, order, sSql, parameters, trans);
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
            DisplayObject_HEM_B_USER dataObj = null;
            ArrayList objArray = new ArrayList();
            while (sqlReader.Read())
            {
                dataObj = new DisplayObject_HEM_B_USER();
                if (!sqlReader.IsDBNull(0))
                    dataObj.MOBILE = sqlReader.GetString(0);
                if (!sqlReader.IsDBNull(1))
                    dataObj.NAME = sqlReader.GetString(1);
                if (!sqlReader.IsDBNull(2))
                    dataObj.ID = sqlReader.GetString(2);
                if (!sqlReader.IsDBNull(3))
                    dataObj.CREATE_DATE = sqlReader.GetDateTime(3);
                if (!sqlReader.IsDBNull(4))
                    dataObj.USER_LOGIN_ID = sqlReader.GetString(4);
                if (!sqlReader.IsDBNull(5))
                    dataObj.EMAIL = sqlReader.GetString(5);
                objArray.Add(dataObj);
            }
            sqlReader.Close();
            #endregion
            DisplayObject_HEM_B_USER[] objs = new DisplayObject_HEM_B_USER[objArray.Count];
            objArray.CopyTo(0, objs, 0, objs.Length);
            return objs;
        }
        public static string PrepareUpdate(EntityObject_HEM_B_USER obj, out OracleParameter[] parameters)
        {

            //平台自动生成代码
            List<string> strBuf = new List<string>();
            ArrayList paramList = new ArrayList();
            OracleParameter param = null;
            #region Push Block
            if (!obj.IsNotUpdate("MOBILE"))
            {
                strBuf.Add("  HEM_B_USER.MOBILE = :MOBILE");
                param = new OracleParameter();
                param.ParameterName = ":MOBILE";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 11;
                param.Value = string.IsNullOrEmpty(obj.MOBILE) ? string.Empty : obj.MOBILE;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("NAME"))
            {
                strBuf.Add("  HEM_B_USER.NAME = :NAME");
                param = new OracleParameter();
                param.ParameterName = ":NAME";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.NAME) ? string.Empty : obj.NAME;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("CREATE_DATE"))
            {
                strBuf.Add("  HEM_B_USER.CREATE_DATE = :CREATE_DATE");
                param = new OracleParameter();
                param.ParameterName = ":CREATE_DATE";
                param.OracleType = System.Data.OracleClient.OracleType.DateTime;
                param.Size = 7;
                param.Value = obj.CREATE_DATE;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("USER_LOGIN_ID"))
            {
                strBuf.Add("  HEM_B_USER.USER_LOGIN_ID = :USER_LOGIN_ID");
                param = new OracleParameter();
                param.ParameterName = ":USER_LOGIN_ID";
                param.OracleType = System.Data.OracleClient.OracleType.Char;
                param.Size = 36;
                param.Value = string.IsNullOrEmpty(obj.USER_LOGIN_ID) ? string.Empty : obj.USER_LOGIN_ID;
                paramList.Add(param);
            }
            if (!obj.IsNotUpdate("EMAIL"))
            {
                strBuf.Add("  HEM_B_USER.EMAIL = :EMAIL");
                param = new OracleParameter();
                param.ParameterName = ":EMAIL";
                param.OracleType = System.Data.OracleClient.OracleType.VarChar;
                param.Size = 50;
                param.Value = string.IsNullOrEmpty(obj.EMAIL) ? string.Empty : obj.EMAIL;
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
