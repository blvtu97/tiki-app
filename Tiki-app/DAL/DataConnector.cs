using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using Tiki_app.DTO;

namespace Tiki_app.DAL
{
    public class DataConnector
    {
        //The connection string is placed in the app.config file
        private string stringConnection =
         "Server = DESKTOP-BSUQ8EF; Database = DBTIKI; UID = sa; PWD = 123456";

        private SqlCommand cmd;

        private SqlConnection conn;

        private SqlDataAdapter da;

        public DataConnector()
        {
            conn = new SqlConnection(stringConnection);
        }

        /// <summary>
        /// This is the method of opening the connection and throwing an exception 
        /// if an error occurs
        /// </summary>
        public void OpenConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This is the method of closing the connection and throwing an exception 
        /// if an error occurs
        /// </summary>
        public void CloseConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// This is method takes data from any table
        /// </summary>
        /// <param name="name">name of table</param>
        /// <returns>DataTable</returns>
        public DataTable getDataTable(string name)
        {
            DataTable dt = null;
            try
            {
                string query = "SELECT * FROM " + name;
                cmd = new SqlCommand(query, conn);
                OpenConnection();
                dt = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (SqlException e)
            {
                throw e;
            }
            return dt;
        }

        /// <summary>
        /// This is method takes data from any table
        /// </summary>
        /// <param name="tableName">name of table</param>
        /// <returns>data has type SqlDataReader</returns>
        public SqlDataReader getDataReader(DataType type)
        {
            SqlDataReader dr;
            try
            {
                string query = "SELECT * FROM " + type.ToString();
                cmd = new SqlCommand(query);
                cmd.Connection = conn;
                OpenConnection();
                dr = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return dr;
        }

        public SqlDataReader getDataReader(string[] tables, string[] args1)
        {
            string table = formatArgs(tables);
            string arg = formatArgs(args1);
            SqlDataReader dr;
            try
            {
                string query = "SELECT " + arg + "FROM " + tables;
                cmd = new SqlCommand(query);
                cmd.Connection = conn;
                OpenConnection();
                dr = cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return dr;
        }

        private string formatArgs(string[] var)
        {
            string temp = "";
            for (int i = 0; i < var.Count(); i++)
            {
                temp += var[i] + ",";
            }
            if (!temp.Equals(""))
            {
                temp.Remove(temp.Length - 1);
            }
            return temp;
        }

        /// <summary>
        /// This is the method of executing a query to the database
        /// </summary>
        /// <param name="query">query statement</param>
        /// <returns>true if the query succeeds, if not returned false</returns>
        public bool MyExcuteNonquery(string query)
        {
            try
            {
                cmd = new SqlCommand(query, conn);
                OpenConnection();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
