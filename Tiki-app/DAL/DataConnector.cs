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
        //const string ADRRESS = "localhost";
        //const string IPENDPOINT = "192.168.1.5";
        //const int PORT = 100;
        //ASCIIEncoding encoding = new ASCIIEncoding();
        //IPAddress[] ipAddress;
        //IPEndPoint ipEnd;
        //Socket clientSock;
        private static readonly Socket ClientSocket = new Socket
            (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private const int PORT = 5656;

        public DataConnector()
        {
        }

        public static void ConnectToServer()
        {
            int attempts = 0;

            while (!ClientSocket.Connected)
            {
                try
                {
                    attempts++;
                    Debug.WriteLine("Connection attempt " + attempts);
                    // Change IPAddress.Loopback to a remote IP to connect to a remote host.
                    ClientSocket.Connect(IPAddress.Loopback, PORT);
                }
                catch (SocketException sk)
                {
                    //Console.Clear();
                    Debug.WriteLine(sk);
                }
            }

            Debug.WriteLine("Connected");
        }

        public static void Exit()
        {
            SendString("exit"); // Tell the server we are exiting
            ClientSocket.Shutdown(SocketShutdown.Both);
            ClientSocket.Close();
            Environment.Exit(0);
        }
        public static void SendRequest(string mess)
        {
            SendString(mess);

            if (mess.Trim().ToLower() == "exit")
            {
                Exit();
            }
        }

        private static void SendString(string text)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(text);
            ClientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        public static DataTable ReceiveResponse()
        {
            var buffer = new byte[2048];
            int received = ClientSocket.Receive(buffer, SocketFlags.None);
            if (received == 0) return null;
            byte[] data = new byte[received];
            Array.Copy(buffer, data, received);
            //string text = Encoding.ASCII.GetString(data);
            //Console.WriteLine(text);
            
            int listSize = (int)DeserializeData(data);
            List<DataTable> myData = new List<DataTable>();
            //get list
            for (int i = 0; i < listSize; i++)
            {
                var buffers = new byte[10000*10000];
                int rec = ClientSocket.Receive(buffer, SocketFlags.None);
                if (rec == 0) return null;
                byte[] datas = new byte[rec];
                Array.Copy(buffers, datas, rec);
                myData.Add((DataTable)DeserializeData(data));
            }
            DataTable result = MergeTable(myData);
            if (result != null)   //kiểm tra gán table thành công
            {
                return result;
            }
            return null;
        }

        //Giải mã mảng byte thành object ban đầu
        static private object DeserializeData(byte[] theByteArray)
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
            //try
            //{
            //    IPAddress[] ipAddress = Dns.GetHostAddresses(ADRRESS);
            //    IPEndPoint ipEnd = new IPEndPoint(IPAddress.Parse(IPENDPOINT), PORT);
            //    Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            //    clientSock.Connect(ipEnd);

            //    //Send 
            //    clientSock.Send(encoding.GetBytes("MASSAGE :"+massege));

            //    clientSock.Close();
            //}
            //catch (Exception ex)
            //{
            //    Debug.WriteLine("Can't Send Massage To Server!\n\n" + ex);
            //}
        }
    }
}
