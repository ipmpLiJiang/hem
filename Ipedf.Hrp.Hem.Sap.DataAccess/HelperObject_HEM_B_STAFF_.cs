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
    public partial class HelperObject_HEM_B_STAFF
    {
        public static DataTable ConvertDataReaderToDataTable(IDataReader reader)
        {
            try
            {
                DataTable objDataTable = new DataTable();
                int intFieldCount = reader.FieldCount;
                for (int intCounter = 0; intCounter < intFieldCount; ++intCounter)
                {
                    objDataTable.Columns.Add(reader.GetName(intCounter), reader.GetFieldType(intCounter));
                }
                objDataTable.BeginLoadData();

                object[] objValues = new object[intFieldCount];
                while (reader.Read())
                {
                    reader.GetValues(objValues);
                    objDataTable.LoadDataRow(objValues, true);
                }
                reader.Close();
                objDataTable.EndLoadData();

                return objDataTable;

            }
            catch (Exception ex)
            {
                throw new Exception("转换出错!", ex);
            }

        }

        public static DataTable GetHem_Staff_Gather(string staff_ids, out int succeed, out string msg)
        {
            DataTable dt = new DataTable();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    OracleParameter p1 = new OracleParameter();
                    p1.ParameterName = "staff_type_ids";
                    p1.Direction = ParameterDirection.Input;
                    p1.Size = 5000;
                    p1.OracleType = OracleType.VarChar;
                    p1.Value = staff_ids;
                    cmd.Parameters.Add(p1);


                    OracleParameter p2 = new OracleParameter();
                    p2.ParameterName = "p_msg";
                    p2.Direction = ParameterDirection.Output;
                    p2.Size = 1024;
                    p2.OracleType = OracleType.VarChar;
                    cmd.Parameters.Add(p2);

                    OracleParameter p3 = new OracleParameter();
                    p3.ParameterName = "p_succeed";
                    p3.Direction = ParameterDirection.Output;
                    p3.OracleType = OracleType.Number;
                    cmd.Parameters.Add(p3);

                    OracleParameter p6 = new OracleParameter();
                    p6.ParameterName = "hem_staff_gather";
                    p6.Direction = ParameterDirection.Output;
                    p6.OracleType = OracleType.Cursor;
                    cmd.Parameters.Add(p6);

                    cmd.CommandText = "SP_HEM_STAFF_DATA_GATHER";
                    ArrayList objArray = new ArrayList();
                    IDataReader sqlReader = cmd.ExecuteReader();

                    dt = ConvertDataReaderToDataTable(sqlReader);

                    msg = DBNull.Value.Equals(p2.Value) ? string.Empty : (string)p2.Value;
                    //succeed = DBNull.Value.Equals(p3.Value) ? 0 : (int)p2.Value;
                    succeed = 1;
                }
                catch (Exception expt)
                {
                    succeed = 0;
                    throw expt;
                }
                finally
                {
                    connection.Close();
                }
            }
            return dt;
        }

        public static HEM_B_STAFF_HEADER[] GetHem_Header_Gather()
        {
            HEM_B_STAFF_HEADER[] objs = null;
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter p6 = new OracleParameter();
                    p6.ParameterName = "hem_staff_header";
                    p6.Direction = ParameterDirection.Output;
                    p6.OracleType = OracleType.Cursor;
                    cmd.Parameters.Add(p6);

                    cmd.CommandText = "SP_HEM_STAFF_HEADER_GATHER";
                    HEM_B_STAFF_HEADER dataObj = null;
                    ArrayList objArray = new ArrayList();
                    IDataReader sqlReader = cmd.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        dataObj = new HEM_B_STAFF_HEADER();
                        if (!sqlReader.IsDBNull(0))
                            dataObj.HeaderName = sqlReader.GetString(0);
                        if (!sqlReader.IsDBNull(1))
                            dataObj.RowStart = sqlReader.GetInt32(1);
                        if (!sqlReader.IsDBNull(2))
                            dataObj.RowEnd = sqlReader.GetInt32(2);
                        if (!sqlReader.IsDBNull(3))
                            dataObj.CellStart = sqlReader.GetInt32(3);
                        if (!sqlReader.IsDBNull(4))
                            dataObj.CellEnd = sqlReader.GetInt32(4);
                        objArray.Add(dataObj);
                    }
                    sqlReader.Close();

                    objs = new HEM_B_STAFF_HEADER[objArray.Count];
                    objArray.CopyTo(0, objs, 0, objs.Length);
                    return objs;
                }
                catch (Exception expt)
                {
                    throw expt;
                }
                finally
                {
                    connection.Close();
                }
            }
            return objs;
        }

        public static int MyUpdate(EntityObject_HEM_B_STAFF obj, IDbTransaction trans)
        {

            //平台自动生成代码
            #region Parameters Block
            OracleParameter[] parameters = null;
            #endregion
            string sSql = "update HEM_B_STAFF set NACHN = '" + obj.NACHN + "',USRID_TEL = '" + obj.USRID_TEL + "',USRID_MAIL = '" + obj.USRID_MAIL + "' where USER_ID = '" + obj.USER_ID + "'";
            //sSql += PrepareUpdate(obj, out parameters, true);
            //sSql += " where  ID = :U_ID ";
            return IDALProvider.IDAL.ExecuteNonQuery(sSql, parameters, trans);
        }

        public static DataTable GetHem_Staff_Nyn_Gather(string staff_ids, out int succeed, out string msg)
        {
            DataTable dt = new DataTable();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    OracleParameter p1 = new OracleParameter();
                    p1.ParameterName = "staff_type_ids";
                    p1.Direction = ParameterDirection.Input;
                    p1.Size = 5000;
                    p1.OracleType = OracleType.VarChar;
                    p1.Value = staff_ids;
                    cmd.Parameters.Add(p1);


                    OracleParameter p2 = new OracleParameter();
                    p2.ParameterName = "p_msg";
                    p2.Direction = ParameterDirection.Output;
                    p2.Size = 1024;
                    p2.OracleType = OracleType.VarChar;
                    cmd.Parameters.Add(p2);

                    OracleParameter p3 = new OracleParameter();
                    p3.ParameterName = "p_succeed";
                    p3.Direction = ParameterDirection.Output;
                    p3.OracleType = OracleType.Number;
                    cmd.Parameters.Add(p3);

                    OracleParameter p6 = new OracleParameter();
                    p6.ParameterName = "hem_staff_gather";
                    p6.Direction = ParameterDirection.Output;
                    p6.OracleType = OracleType.Cursor;
                    cmd.Parameters.Add(p6);

                    cmd.CommandText = "SP_HEM_STAFF_NYN_DATA_GATHER";
                    ArrayList objArray = new ArrayList();
                    IDataReader sqlReader = cmd.ExecuteReader();

                    dt = ConvertDataReaderToDataTable(sqlReader);

                    msg = DBNull.Value.Equals(p2.Value) ? string.Empty : (string)p2.Value;
                    //succeed = DBNull.Value.Equals(p3.Value) ? 0 : (int)p2.Value;
                    succeed = 1;
                }
                catch (Exception expt)
                {
                    succeed = 0;
                    throw expt;
                }
                finally
                {
                    connection.Close();
                }
            }
            return dt;
        }

        public static HEM_B_STAFF_HEADER[] GetHem_Nyn_Header_Gather()
        {
            HEM_B_STAFF_HEADER[] objs = null;
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter p6 = new OracleParameter();
                    p6.ParameterName = "hem_staff_header";
                    p6.Direction = ParameterDirection.Output;
                    p6.OracleType = OracleType.Cursor;
                    cmd.Parameters.Add(p6);

                    cmd.CommandText = "SP_HEM_STAFF_NYN_HEADER_GATHER";
                    HEM_B_STAFF_HEADER dataObj = null;
                    ArrayList objArray = new ArrayList();
                    IDataReader sqlReader = cmd.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        dataObj = new HEM_B_STAFF_HEADER();
                        if (!sqlReader.IsDBNull(0))
                            dataObj.HeaderName = sqlReader.GetString(0);
                        if (!sqlReader.IsDBNull(1))
                            dataObj.RowStart = sqlReader.GetInt32(1);
                        if (!sqlReader.IsDBNull(2))
                            dataObj.RowEnd = sqlReader.GetInt32(2);
                        if (!sqlReader.IsDBNull(3))
                            dataObj.CellStart = sqlReader.GetInt32(3);
                        if (!sqlReader.IsDBNull(4))
                            dataObj.CellEnd = sqlReader.GetInt32(4);
                        objArray.Add(dataObj);
                    }
                    sqlReader.Close();

                    objs = new HEM_B_STAFF_HEADER[objArray.Count];
                    objArray.CopyTo(0, objs, 0, objs.Length);
                    return objs;
                }
                catch (Exception expt)
                {
                    throw expt;
                }
                finally
                {
                    connection.Close();
                }
            }
            return objs;
        }

        public static DataTable GetHem_Staff_Nyw_Gather(string staff_ids, out int succeed, out string msg)
        {
            DataTable dt = new DataTable();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    OracleParameter p1 = new OracleParameter();
                    p1.ParameterName = "staff_type_ids";
                    p1.Direction = ParameterDirection.Input;
                    p1.Size = 5000;
                    p1.OracleType = OracleType.VarChar;
                    p1.Value = staff_ids;
                    cmd.Parameters.Add(p1);


                    OracleParameter p2 = new OracleParameter();
                    p2.ParameterName = "p_msg";
                    p2.Direction = ParameterDirection.Output;
                    p2.Size = 1024;
                    p2.OracleType = OracleType.VarChar;
                    cmd.Parameters.Add(p2);

                    OracleParameter p3 = new OracleParameter();
                    p3.ParameterName = "p_succeed";
                    p3.Direction = ParameterDirection.Output;
                    p3.OracleType = OracleType.Number;
                    cmd.Parameters.Add(p3);

                    OracleParameter p6 = new OracleParameter();
                    p6.ParameterName = "hem_staff_gather";
                    p6.Direction = ParameterDirection.Output;
                    p6.OracleType = OracleType.Cursor;
                    cmd.Parameters.Add(p6);

                    cmd.CommandText = "SP_HEM_STAFF_NYW_DATA_GATHER";
                    ArrayList objArray = new ArrayList();
                    IDataReader sqlReader = cmd.ExecuteReader();

                    dt = ConvertDataReaderToDataTable(sqlReader);

                    msg = DBNull.Value.Equals(p2.Value) ? string.Empty : (string)p2.Value;
                    //succeed = DBNull.Value.Equals(p3.Value) ? 0 : (int)p2.Value;
                    succeed = 1;
                }
                catch (Exception expt)
                {
                    succeed = 0;
                    throw expt;
                }
                finally
                {
                    connection.Close();
                }
            }
            return dt;
        }

        public static HEM_B_STAFF_HEADER[] GetHem_Nyw_Header_Gather()
        {
            HEM_B_STAFF_HEADER[] objs = null;
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter p6 = new OracleParameter();
                    p6.ParameterName = "hem_staff_header";
                    p6.Direction = ParameterDirection.Output;
                    p6.OracleType = OracleType.Cursor;
                    cmd.Parameters.Add(p6);

                    cmd.CommandText = "SP_HEM_STAFF_NYW_HEADER_GATHER";
                    HEM_B_STAFF_HEADER dataObj = null;
                    ArrayList objArray = new ArrayList();
                    IDataReader sqlReader = cmd.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        dataObj = new HEM_B_STAFF_HEADER();
                        if (!sqlReader.IsDBNull(0))
                            dataObj.HeaderName = sqlReader.GetString(0);
                        if (!sqlReader.IsDBNull(1))
                            dataObj.RowStart = sqlReader.GetInt32(1);
                        if (!sqlReader.IsDBNull(2))
                            dataObj.RowEnd = sqlReader.GetInt32(2);
                        if (!sqlReader.IsDBNull(3))
                            dataObj.CellStart = sqlReader.GetInt32(3);
                        if (!sqlReader.IsDBNull(4))
                            dataObj.CellEnd = sqlReader.GetInt32(4);
                        objArray.Add(dataObj);
                    }
                    sqlReader.Close();

                    objs = new HEM_B_STAFF_HEADER[objArray.Count];
                    objArray.CopyTo(0, objs, 0, objs.Length);
                    return objs;
                }
                catch (Exception expt)
                {
                    throw expt;
                }
                finally
                {
                    connection.Close();
                }
            }
            return objs;
        }

        public static DataTable GetHem_Staff_Nwj_Gather(string staff_ids, out int succeed, out string msg)
        {
            DataTable dt = new DataTable();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    OracleParameter p1 = new OracleParameter();
                    p1.ParameterName = "staff_type_ids";
                    p1.Direction = ParameterDirection.Input;
                    p1.Size = 5000;
                    p1.OracleType = OracleType.VarChar;
                    p1.Value = staff_ids;
                    cmd.Parameters.Add(p1);


                    OracleParameter p2 = new OracleParameter();
                    p2.ParameterName = "p_msg";
                    p2.Direction = ParameterDirection.Output;
                    p2.Size = 1024;
                    p2.OracleType = OracleType.VarChar;
                    cmd.Parameters.Add(p2);

                    OracleParameter p3 = new OracleParameter();
                    p3.ParameterName = "p_succeed";
                    p3.Direction = ParameterDirection.Output;
                    p3.OracleType = OracleType.Number;
                    cmd.Parameters.Add(p3);

                    OracleParameter p6 = new OracleParameter();
                    p6.ParameterName = "hem_staff_gather";
                    p6.Direction = ParameterDirection.Output;
                    p6.OracleType = OracleType.Cursor;
                    cmd.Parameters.Add(p6);

                    cmd.CommandText = "SP_HEM_STAFF_NWJ_DATA_GATHER";
                    ArrayList objArray = new ArrayList();
                    IDataReader sqlReader = cmd.ExecuteReader();

                    dt = ConvertDataReaderToDataTable(sqlReader);

                    msg = DBNull.Value.Equals(p2.Value) ? string.Empty : (string)p2.Value;
                    //succeed = DBNull.Value.Equals(p3.Value) ? 0 : (int)p2.Value;
                    succeed = 1;
                }
                catch (Exception expt)
                {
                    succeed = 0;
                    throw expt;
                }
                finally
                {
                    connection.Close();
                }
            }
            return dt;
        }

        public static HEM_B_STAFF_HEADER[] GetHem_Nwj_Header_Gather()
        {
            HEM_B_STAFF_HEADER[] objs = null;
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter p6 = new OracleParameter();
                    p6.ParameterName = "hem_staff_header";
                    p6.Direction = ParameterDirection.Output;
                    p6.OracleType = OracleType.Cursor;
                    cmd.Parameters.Add(p6);

                    cmd.CommandText = "SP_HEM_STAFF_NWJ_HEADER_GATHER";
                    HEM_B_STAFF_HEADER dataObj = null;
                    ArrayList objArray = new ArrayList();
                    IDataReader sqlReader = cmd.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        dataObj = new HEM_B_STAFF_HEADER();
                        if (!sqlReader.IsDBNull(0))
                            dataObj.HeaderName = sqlReader.GetString(0);
                        if (!sqlReader.IsDBNull(1))
                            dataObj.RowStart = sqlReader.GetInt32(1);
                        if (!sqlReader.IsDBNull(2))
                            dataObj.RowEnd = sqlReader.GetInt32(2);
                        if (!sqlReader.IsDBNull(3))
                            dataObj.CellStart = sqlReader.GetInt32(3);
                        if (!sqlReader.IsDBNull(4))
                            dataObj.CellEnd = sqlReader.GetInt32(4);
                        objArray.Add(dataObj);
                    }
                    sqlReader.Close();

                    objs = new HEM_B_STAFF_HEADER[objArray.Count];
                    objArray.CopyTo(0, objs, 0, objs.Length);
                    return objs;
                }
                catch (Exception expt)
                {
                    throw expt;
                }
                finally
                {
                    connection.Close();
                }
            }
            return objs;
        }


        public static DataTable GetHem_Staff_Nyj_Gather(string staff_ids, out int succeed, out string msg)
        {
            DataTable dt = new DataTable();
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    OracleParameter p1 = new OracleParameter();
                    p1.ParameterName = "staff_type_ids";
                    p1.Direction = ParameterDirection.Input;
                    p1.Size = 5000;
                    p1.OracleType = OracleType.VarChar;
                    p1.Value = staff_ids;
                    cmd.Parameters.Add(p1);


                    OracleParameter p2 = new OracleParameter();
                    p2.ParameterName = "p_msg";
                    p2.Direction = ParameterDirection.Output;
                    p2.Size = 1024;
                    p2.OracleType = OracleType.VarChar;
                    cmd.Parameters.Add(p2);

                    OracleParameter p3 = new OracleParameter();
                    p3.ParameterName = "p_succeed";
                    p3.Direction = ParameterDirection.Output;
                    p3.OracleType = OracleType.Number;
                    cmd.Parameters.Add(p3);

                    OracleParameter p6 = new OracleParameter();
                    p6.ParameterName = "hem_staff_gather";
                    p6.Direction = ParameterDirection.Output;
                    p6.OracleType = OracleType.Cursor;
                    cmd.Parameters.Add(p6);

                    cmd.CommandText = "SP_HEM_STAFF_NYJ_DATA_GATHER";
                    ArrayList objArray = new ArrayList();
                    IDataReader sqlReader = cmd.ExecuteReader();

                    dt = ConvertDataReaderToDataTable(sqlReader);

                    msg = DBNull.Value.Equals(p2.Value) ? string.Empty : (string)p2.Value;
                    //succeed = DBNull.Value.Equals(p3.Value) ? 0 : (int)p2.Value;
                    succeed = 1;
                }
                catch (Exception expt)
                {
                    succeed = 0;
                    throw expt;
                }
                finally
                {
                    connection.Close();
                }
            }
            return dt;
        }

        public static HEM_B_STAFF_HEADER[] GetHem_Nyj_Header_Gather()
        {
            HEM_B_STAFF_HEADER[] objs = null;
            using (IDbConnection connection = IDALProvider.IDAL.PopConnection())
            {
                try
                {
                    IDbCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;

                    OracleParameter p6 = new OracleParameter();
                    p6.ParameterName = "hem_staff_header";
                    p6.Direction = ParameterDirection.Output;
                    p6.OracleType = OracleType.Cursor;
                    cmd.Parameters.Add(p6);

                    cmd.CommandText = "SP_HEM_STAFF_NYJ_HEADER_GATHER";
                    HEM_B_STAFF_HEADER dataObj = null;
                    ArrayList objArray = new ArrayList();
                    IDataReader sqlReader = cmd.ExecuteReader();

                    while (sqlReader.Read())
                    {
                        dataObj = new HEM_B_STAFF_HEADER();
                        if (!sqlReader.IsDBNull(0))
                            dataObj.HeaderName = sqlReader.GetString(0);
                        if (!sqlReader.IsDBNull(1))
                            dataObj.RowStart = sqlReader.GetInt32(1);
                        if (!sqlReader.IsDBNull(2))
                            dataObj.RowEnd = sqlReader.GetInt32(2);
                        if (!sqlReader.IsDBNull(3))
                            dataObj.CellStart = sqlReader.GetInt32(3);
                        if (!sqlReader.IsDBNull(4))
                            dataObj.CellEnd = sqlReader.GetInt32(4);
                        objArray.Add(dataObj);
                    }
                    sqlReader.Close();

                    objs = new HEM_B_STAFF_HEADER[objArray.Count];
                    objArray.CopyTo(0, objs, 0, objs.Length);
                    return objs;
                }
                catch (Exception expt)
                {
                    throw expt;
                }
                finally
                {
                    connection.Close();
                }
            }
            return objs;
        }
    }
}
