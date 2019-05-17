using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Server.BLL;
namespace Server
{
    public partial class frmServer : Form
    {
        private static Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static List<Socket> clientSockets = new List<Socket>();
        private const int BUFFER_SIZE = 2048;
        private const int PORT = 5656;
        private static byte[] buffer = new byte[BUFFER_SIZE];
        private static Socket clientSocket;
        public frmServer()
        {
            InitializeComponent();
            this.Focus();

        }
        /// <summary>
        /// Close all connected client (we do not need to shutdown the server socket as its connections
        /// are already closed with the clients).
        /// </summary>
        private static void CloseAllSockets()
        {
            foreach (Socket socket in clientSockets)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }

            serverSocket.Close();
        }
        #region Thread Process Server
        //Stop Thread Server
        private void StopServer()
        {
            //isRunning = false;
            //if (sock != null)
            //    sock.Close();
            //btnStop.Enabled = false;
            //btnStartServer.Enabled = true;
            //btnStartServer.ButtonText = "Restart Server";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopServer();
        }

        //Run Thread Server
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Setting up server...");
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, PORT));
            serverSocket.Listen(200);
            clientSocket = serverSocket.Accept();

            serverSocket.BeginAccept(AcceptCallback, null);
            Debug.WriteLine("Server setup complete");
            //isRunning = true;
            btnStartServer.ButtonText = "In process...";
            btnStartServer.Enabled = false;
            //btnStop.Enabled = true;
            //serviceSocketThread = new Thread(RunningServer);
            CloseAllSockets();
            //serviceSocketThread.Start();
        }

        //Waiting Request From Client
        private void RunningServer()
        {
            //while (isRunning)
            //{
            //    try
            //    {
            //        ipEnd = new IPEndPoint(IPAddress.Any, 5656);
            //        sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            //        sock.Bind(ipEnd);
            //        sock.Listen(100);
            //        clientSock = sock.Accept();

            //        byte[] data = new byte[1024];
            //        clientSock.Receive(data);
            //        string str = encoding.GetString(data).Trim().Replace("\0", string.Empty);    //Loại kí tự trống và \0
            //        if (str.Contains("MESSAGE"))
            //            CheckMessage(str);
            //        else   //request
            //        {
            //            int count = 0;
            //            int begin = 0;
            //            int end = 10;
            //            bool flag = true;
            //            List<DataTable> sendBack = new List<DataTable>();
            //            while (flag)
            //            {
            //                DataTable dt = GetDatabase(begin, end, out flag, str);
            //                if (dt != null)
            //                {
            //                    ++count;
            //                    sendBack.Add(dt);
            //                    begin = end;
            //                    end += 10;
            //                }
            //            }
            //            clientSock.Send(SerializeData(count));
            //            foreach (DataTable table in sendBack)
            //            {
            //                clientSock.Send(SerializeData(table));
            //                clientSock.Receive(data);
            //            }


            //        }
            //        sock.Close();
            //        clientSock.Close();
            //        Application.DoEvents();
            //    }
            //    catch (Exception e)
            //    {
            //        sock.Close();
            //        clientSock.Close();
            //        Application.DoEvents();
            //    }
            //}
        }

        private void CheckMessage(string str)
        {
            MessageBox.Show(str);
        }

        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopServer();
        }
        #endregion

        #region Functions Get And Endcode Database
        //Encode object to byte array
        static public byte[] SerializeData(Object o)
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, o);
            return ms.ToArray();
        }

        // Chia bảng ra nhiều lần get, một lần get (end - begin) item
        static private DataTable GetDatabase(int begin, int end, out bool flag, string nameTable)
        {
            flag = true;
            DataSet dt = null;
            switch (nameTable.Trim())
            {
                case "IMAGE_PHONE":
                    dt = new BLImageSmartPhone().GetData();
                    break;
                case "PRODUCT_PHONE":
                    dt = new BLProductSmart().GetData();
                    break;
                case "DETAIL_PHONE":
                    dt = new BLDetailSmartPhone().GetData();
                    break;
                case "CATEGORY_PHONE":
                    dt = new BLCategory_Smartphone_Tablet().GetData();
                    break;
                default:
                    MessageBox.Show("Table not create yet!");
                    flag = false;
                    return null;
            }

            DataTable table = dt.Tables[0];
            if (table.Rows.Count <= end)
            {
                end = table.Rows.Count;
                flag = false;
            }
            DataTable resulrSplip = table.AsEnumerable().Skip(begin).Take(end - begin).CopyToDataTable();
            //myData[0].AsEnumerable().Take(10).CopyToDataTable();
            return resulrSplip;
        }

        #endregion

        #region Thread Process Manager Database
        //Run Form To Add, Remove, Repair Database
        private void Menu_Click(object sender, EventArgs e)
        {
            //List<DataTable> tables = GetDatabase();
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;
            FormPhone_Manager formPhone_Manager = new FormPhone_Manager();
            FormLaptop_Manager formLaptop_Manager = new FormLaptop_Manager();
            FormFashion_Manager formFashion_Manager = new FormFashion_Manager();
            FormCar_Manager formCar_Manager = new FormCar_Manager();
            FormBook_Manager formBook_Manager = new FormBook_Manager();
            switch (menu.Tag.ToString())
            {
                case "CUSTOMER":
                    FormPhone_Manager.dataType = DataManager.CUSTOMER;
                    this.Hide();
                    formPhone_Manager.ShowDialog();
                    break;

                case "DETAILSMART":
                    FormPhone_Manager.dataType = DataManager.DETAILSMARTPHONE;
                    this.Hide();
                    formPhone_Manager.ShowDialog();
                    break;
                case "PRODUCTSMART":
                    FormPhone_Manager.dataType = DataManager.PRODUCTSMARTPHONE;
                    this.Hide();
                    formPhone_Manager.ShowDialog();
                    break;
                case "CATEGORYSMART":
                    FormPhone_Manager.dataType = DataManager.CATEGORY_SMARTPHONE_TABLET;
                    this.Hide();
                    formPhone_Manager.ShowDialog();
                    break;

                case "DETAILLAPTOP":
                    FormLaptop_Manager.dataType = DataManager.DETAILLAPTOP;
                    this.Hide();
                    formLaptop_Manager.ShowDialog();
                    break;
                case "PRODUCTLAPTOP":
                    FormLaptop_Manager.dataType = DataManager.PRODUCTLAPTOP;
                    this.Hide();
                    formLaptop_Manager.ShowDialog();
                    break;
                case "CATEGORYLAPTOP":
                    FormLaptop_Manager.dataType = DataManager.CATEGORY_LAPTOP;
                    this.Hide();
                    formLaptop_Manager.ShowDialog();
                    break;

                case "DETAILFASHION":
                    FormFashion_Manager.dataType = DataManager.DETAILFASHION;
                    this.Hide();
                    formFashion_Manager.ShowDialog();
                    break;
                case "PRODUCTFASHION":
                    FormFashion_Manager.dataType = DataManager.PRODUCTFASHION;
                    this.Hide();
                    formFashion_Manager.ShowDialog();
                    break;
                case "CATEGORYFASHION":
                    FormFashion_Manager.dataType = DataManager.CATEGORY_FASHION;
                    this.Hide();
                    formFashion_Manager.ShowDialog();
                    break;

                case "DETAILCAR":
                    FormCar_Manager.dataType = DataManager.DETAILCAR;
                    this.Hide();
                    formCar_Manager.ShowDialog();
                    break;
                case "PRODUCTCAR":
                    FormCar_Manager.dataType = DataManager.PRODUCTCAR;
                    this.Hide();
                    formCar_Manager.ShowDialog();
                    break;
                case "CATEGORYCAR":
                    FormCar_Manager.dataType = DataManager.CATEGORY_CAR;
                    this.Hide();
                    formCar_Manager.ShowDialog();
                    break;

                case "DETAILBOOK":
                    FormBook_Manager.dataType = DataManager.DETAILBOOK;
                    this.Hide();
                    formBook_Manager.ShowDialog();
                    break;
                case "PRODUCTBOOK":
                    FormBook_Manager.dataType = DataManager.PRODUCTBOOK;
                    this.Hide();
                    formBook_Manager.ShowDialog();
                    break;
                case "CATEGORYBOOK":
                    FormBook_Manager.dataType = DataManager.CATEGORY_BOOK;
                    this.Hide();
                    formBook_Manager.ShowDialog();
                    break;

                default:
                    MessageBox.Show(menu.Tag.ToString());
                    break;
            }

            this.Show();
        }

        #endregion

        /** New **/
        private static void AcceptCallback(IAsyncResult AR)
        {
            Socket socket;

            try
            {
                socket = serverSocket.EndAccept(AR);
            }
            catch (ObjectDisposedException) // I cannot seem to avoid this (on exit when properly closing sockets)
            {
                return;
            }

            clientSockets.Add(socket);
            socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, socket);
            Debug.WriteLine("Client connected : waiting for request...");
            serverSocket.BeginAccept(AcceptCallback, null);
        }

        private static void ReceiveCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;

            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {
                Debug.WriteLine("Client forcefully disconnected");
                // Don't shutdown because the socket may be disposed and its disconnected anyway.
                current.Close();
                clientSockets.Remove(current);
                return;
            }

            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);
            string text = Encoding.ASCII.GetString(recBuf);
            Debug.WriteLine("Received Text: " + text);

            if (text.Contains("MASSEAGE")) // Client requested time
            {
                
            }
            else if (text.ToLower() == "exit") // Client wants to exit gracefully
            {
                // Always Shutdown before closing
                current.Shutdown(SocketShutdown.Both);
                current.Close();
                clientSockets.Remove(current);
                Debug.WriteLine("Client disconnected");
                return;
            }
            else
            {
                text = text.Trim().Replace("\0", string.Empty);
                //Console.WriteLine("Text is an invalid request");
                //byte[] data = Encoding.ASCII.GetBytes("Invalid request");
                //current.Send(data);
                int count = 0;
                int begin = 0;
                int end = 10;
                bool flag = true;
                List<DataTable> sendBack = new List<DataTable>();
                while (flag)
                {
                    DataTable dt = GetDatabase(begin, end, out flag, text);
                    if (dt != null)
                    {
                        ++count;
                        sendBack.Add(dt);
                        begin = end;
                        end += 10;
                    }
                }
                current.Send(SerializeData(count));
                foreach (DataTable table in sendBack)
                {
                    current.Send(SerializeData(table));
                    current.Receive(new byte[8]);
                }
            }

            current.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);
        }

    }
}