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
using Server.BLL.CATEGORY;
using Server.DTO;
using Server.BLL.CUSTOMER;
namespace Server
{
    public partial class frmServer : Form
    {
        static ASCIIEncoding encoding = new ASCIIEncoding();
        TcpListener listener;
        ProcessManager proManager;
        public frmServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.Focus();
            proManager = new ProcessManager();
        }

        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseConnect();
            proManager.KillByPort(8989);
            Application.Exit();
        }

        private void CloseConnect()
        {
            if (listener != null)
            {
                listener.Stop();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            CloseConnect();
            btnStartServer.Enabled = true;
            btnStartServer.ButtonText = "Restart";
            btnStartServer.Focus();
            btnStop.Enabled = false;
        }
        private void btnStartServer_Click(object sender, EventArgs e)
        {
            listener = new TcpListener(IPAddress.Any, 8989);
            Thread thread = new Thread(Open);
            thread.Start();

            btnStartServer.Enabled = false;
            btnStartServer.ButtonText = "In Process";
            btnStop.Enabled = true;
            btnStop.Focus();

        }

        public void Open()
        {
            try
            {
                while (true)
                {
                    listener.Start();
                    Socket client = listener.AcceptSocket();
                    var childSocketThread = new Thread(() =>
                    {
                        while (true)
                        {
                            try
                            {
                                byte[] data = new byte[100];
                                try
                                {
                                    int size = client.Receive(data);
                                }
                                catch
                                {
                                    client.Close();
                                    Thread.CurrentThread.Abort();
                                }
                                string mess = encoding.GetString(data);
                                Receive(client, mess);
                            }
                            catch (SocketException)
                            {
                                client.Disconnect(true);
                                client.Close();
                                Thread.CurrentThread.Abort();
                            }
                        }
                    });
                    childSocketThread.Start();
                }
            }
            catch (SocketException)
            {
                listener = new TcpListener(IPAddress.Any, 8989);
            }
        }
        // Gửi Table
        public void Send(Socket client, DataTable table)
        {
            client.Send(SerializeData(table));
        }

        // Gửi Messsage
        public void Send(Socket client, int lengh)
        {
            client.Send(SerializeData(lengh));
        }

        public void Receive(Socket client, string mess)
        {
            try
            {
                if (mess.Contains("MASSAGE")) { }
                else
                {
                    mess = mess.Trim().Replace("\0", string.Empty);
                    int count = 0;
                    int begin = 0;
                    int end = 10;
                    bool flag = true;
                    List<DataTable> sendBack = new List<DataTable>();
                    while (flag)
                    {
                        DataTable dt = GetDatabase(begin, end, out flag, mess);
                        if (dt != null)
                        {
                            ++count;
                            sendBack.Add(dt);
                            begin = end;
                            end += 10;
                        }
                    }
                    if (sendBack.Count > 0)
                    {
                        Send(client, count);
                        for (int i = 0; i < count; i++)
                        {
                            Send(client, sendBack[i]);
                            client.Receive(new byte[4]);
                        }
                    }
                    else
                    {
                        client.Disconnect(true);
                        client.Close();
                    }
                }
            }
            catch (SocketException e)
            {
                Debug.WriteLine(e);
                CloseConnect();
                client.Disconnect(true);
                client.Close();
                listener = new TcpListener(IPAddress.Any, 8989);

            }
        }

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
            if(nameTable.Contains("IMAGE"))
                switch (nameTable.Trim())
                {
                    case "IMAGE_PHONE":
                        dt = new BLImageSmartPhone().GetData();
                        break;
                    case "IMAGE_LAPTOP":
                        dt = new BLImageLaptop().GetData();
                        break;
                    case "IMAGE_FASHION":
                        dt = new BLImageFahion().GetData();
                        break;
                    case "IMAGE_CAR":
                        dt = new BLImageCar().GetData();
                        break;
                    case "IMAGE_BOOK":
                        dt = new BLImageCar().GetData();
                        break;
                    default:
                        flag = false;
                        return null;
                }
            else if(nameTable.Contains("PRODUCT"))
                switch (nameTable.Trim())
                {
                    case "PRODUCT_PHONE":
                        dt = new BLProductSmart().GetData();
                        break;
                    case "PRODUCT_LAPTOP":
                        dt = new BLProductLaptop().GetData();
                        break;
                    case "PRODUCT_FASHION":
                        dt = new BLProductFashion().GetData();
                        break;
                    case "PRODUCT_CAR":
                        dt = new BLProductCar().GetData();
                        break;
                    case "PRODUCT_BOOK":
                        dt = new BLProductBook().GetData();
                        break;
                    default:
                        flag = false;
                        return null;
                }
            else if(nameTable.Contains("DETAIL"))
                switch (nameTable.Trim())
                {
                    case "DETAIL_PHONE":
                        dt = new BLDetailSmartPhone().GetData();
                        break;
                    case "DETAIL_LAPTOP":
                        dt = new BLDetailLaptop().GetData();
                        break;
                    case "DETAIL_FASHION":
                        dt = new BLDetailFashion().GetData();
                        break;
                    case "DETAIL_CAR":
                        dt = new BLDetailCar().GetData();
                        break;
                    case "DETAIL_BOOK":
                        dt = new BLDetailBook().GetData();
                        break;
                    default:
                        flag = false;
                        return null;
                }
            else if(nameTable.Contains("CATEGORY"))
                switch (nameTable.Trim())
                {
                    case "CATEGORY_PHONE":
                        dt = new BLCategory_Smartphone_Tablet().GetData();
                        break;
                    case "CATEGORY_LAPTOP":
                        dt = new BLCategory_Laptop().GetData();
                        break;
                    case "CATEGORY_FASHION":
                        dt = new BLCategory_Fashion().GetData();
                        break;
                    case "CATEGORY_CAR":
                        dt = new BLCategory_Car().GetData();
                        break;
                    case "CATEGORY_BOOK":
                        dt = new BLCategory_Book().GetData();
                        break;
                    default:
                        flag = false;
                        return null;
                }
            else
                switch (nameTable.Trim())
                {
                    case "CUSTOMER":
                        dt = new BLCustomer().GetData();
                        break;
                    case "COMMENT":
                        dt = new BLComment().GetData();
                        break;
                    case "BILL":
                        dt = new BLDetailBill().GetData();
                        break;
                    default:
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
            FormUser_Manager formUser_Manager = new FormUser_Manager();
            switch (menu.Tag.ToString())
            {
                case "CUSTOMER":
                    FormUser_Manager.dataType = DataManager.CUSTOMER;
                    this.Hide();
                    formUser_Manager.ShowDialog();
                    break;
                case "DETAILBILL":
                    FormUser_Manager.dataType = DataManager.DETAILBILL;
                    this.Hide();
                    formUser_Manager.ShowDialog();
                    break;
                case "COMMENT":
                    FormUser_Manager.dataType = DataManager.COMMENT;
                    this.Hide();
                    formUser_Manager.ShowDialog();
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

    }
}