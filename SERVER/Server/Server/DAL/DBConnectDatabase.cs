using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Server.DAL
{
    class DBConnectDatabase
    {
        string ConnStr = "Data Source=DESKTOP-BSUQ8EF;" +
            "Initial Catalog=DBTIKI;" +
            "Integrated Security=True";
        public SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DBConnectDatabase()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close(); conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds); return ds;
        }

        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close(); conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        // Use for insert, update image
        public void AddParameters(string parameterName, SqlDbType sqlDbType, byte[] img)
        {
            comm.Parameters.Add(parameterName, sqlDbType).Value = img;
        }
        public void AddParameters(string parameterName, SqlDbType sqlDbType, string value)
        {
            comm.Parameters.Add(parameterName, sqlDbType).Value = value;
        }
    }
}
