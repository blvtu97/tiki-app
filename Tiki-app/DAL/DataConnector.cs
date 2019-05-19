using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using Tiki_app.DTO;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

namespace Tiki_app.DAL
{
    public class DataConnector
    {
        const string ADRRESS = "localhost";

        const string IPENDPOINT = "127.0.0.1";


        const int PORT = 8989;

        ASCIIEncoding encoding = new ASCIIEncoding();

        static IPAddress[] ipAddress = Dns.GetHostAddresses(ADRRESS);

        static IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(IPENDPOINT), PORT);

        static Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

        private DataConnector()
        {
            conn = new SqlConnection(stringConnection);
        }

        public static DataConnector instance;

        public static DataConnector getInstance()
        {
            if (instance == null) instance = new DataConnector();
            return instance;
        }

        //Lấy dữ liệu
        public DataTable GetTable(string name, ref bool flag)
        {

            try
            {
                //Send 
                clientSock.Send(encoding.GetBytes(name));

                byte[] data = new byte[10000 * 10000];
                List<DataTable> myData = new List<DataTable>();

                //Nhận số size của list table gửi về
                clientSock.Receive(data);
                int listSize = (int)DeserializeData(data);

                //get list
                for (int i = 0; i < listSize; i++)
                {
                    clientSock.Receive(data);
                    myData.Add((DataTable)DeserializeData(data));
                    clientSock.Send(encoding.GetBytes(i.ToString()));
                }
                DataTable result = MergeTable(myData);
                if (result != null)   //kiểm tra gán table thành công
                {
                    flag = true;
                    return result;
                }
                //clientSock.Close();
            }
            catch (Exception ex)
            {
                ipAddress = Dns.GetHostAddresses(ADRRESS);
                ipEnd = new IPEndPoint(IPAddress.Parse(IPENDPOINT), PORT);
                clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                flag = false;
                //clientSock.Close();
                Debug.WriteLine("Can't Get Databae From Server!\n\n" + ex);
            }
            return null;
        }

        public void Connect()
        {
            if (!clientSock.Connected)
                clientSock.Connect(ipEnd);
        }

        public void CloseConnect()
        {
            clientSock.Disconnect(true);
        }

        //Giải mã mảng byte thành object ban đầu
        private object DeserializeData(byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);
        }


        // Nối nhiều table con lại thành một table lớn
        static private DataTable MergeTable(List<DataTable> child)
        {
            DataTable parent = new DataTable();
            parent = child[0].Copy();
            for (int i = 1; i < child.Count; i++)
            {
                parent.Merge(child[i]);
            }
            return parent;

        }

        //Gửi dữ liệu về server
        public void SendMessage(string massege)
        {
            try
            {
                IPAddress[] ipAddress = Dns.GetHostAddresses(ADRRESS);
                IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(IPENDPOINT), PORT);
                Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                clientSock.Connect(ipEnd);

                //Send 
                clientSock.Send(encoding.GetBytes("MASSAGE :" + massege));

                clientSock.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Can't Send Massage To Server!\n\n" + ex);
            }
        }


        string stringConnection = "Data Source = (local);" 
            + "Initial Catalog=DBTIKI;" 
            + "Integrated Security=True";

        private SqlCommand cmd;

        private SqlConnection conn;

        private SqlDataAdapter adapter;

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

        public DataTable getDataTable(string name)
        {
            DataTable dt = null;
            try
            {
                string query = "SELECT * FROM " + name;
                cmd = new SqlCommand(query, conn);
                OpenConnection();
                dt = new DataTable();
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (SqlException e)
            {
                throw e;
            }
            return dt;
        }

        public SqlDataReader getDataReader(string tableName)
        {
            SqlDataReader dr;
            try
            {
                string query = "SELECT * FROM " + tableName;
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
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
