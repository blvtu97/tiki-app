using Server.BLL;
using Server.BLL.CATEGORY;
using Server.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FormCar_Manager : Form
    {
        static public DataManager dataType; // To hand load table
        private List<Control> controls;     // To handle enable
        private DataTable table;            // To handle insert, remove, repair
        private DataTable tableImage;       // Use for table need manager image
        private OnClickListener eventClick; // To hand event click for all button
        private string err;
        private bool isInsert;
        public FormCar_Manager()
        {
            InitializeComponent();
        }

        // Set Enable or Unenable Controls
        private void ClockControls(bool isClock)
        {
            if (controls != null)
                foreach (Control c in controls)
                    c.Enabled = !isClock;
        }
        private void ClearControlsContent()
        {
            foreach (Control c in controls)
            {
                if (c is Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox btnBunifu)
                    btnBunifu.DefaultText = "";
                else if (c is Bunifu.UI.WinForms.BunifuPictureBox ptbBunifu)
                    ptbBunifu.Image = null;
                else if (c is CheckBox ckb)
                    ckb.Checked = false;
                else
                    c.ResetText();
            }
        }

        // Load Data Correctly With Management
        private void FormManagement_Load(object sender, EventArgs e)
        {
            Panel[] panelsControl = { pnlProductCar, pnlDetailCar, pnlCategoryCar };
            foreach (var p in panelsControl)
            {
                p.Enabled = false;
                p.SendToBack();
            }

            eventClick = new OnClickListener(dataType);
            switch (dataType)
            {
                case DataManager.CATEGORY_CAR:
                    controls = new List<Control>() { txbCatCarLoai, btnCatCarChangeImg };
                    btnCatCarSua.Enabled = btnCatCarLuu.Enabled = btnCatCarHuy.Enabled = btnCatCarXoa.Enabled = false;
                    table = new BLCategory_Car().GetData().Tables[0];
                    pnlCategoryCar.Enabled = true;
                    pnlCategoryCar.BringToFront();
                    break;
                case DataManager.DETAILCAR:
                    controls = new List<Control>() { txbDetCarMaSP, txbDetCarMau, txbDetCarXilanh, txbDetCarLoai, txbDetCarXang };
                    btnDetCarSua.Enabled = btnDetCarLuu.Enabled = btnDetCarHuy.Enabled = btnDetCarXoa.Enabled = false;
                    table = new BLDetailCar().GetData().Tables[0];
                    pnlDetailCar.Enabled = true;
                    pnlDetailCar.BringToFront();
                    break;
                case DataManager.PRODUCTCAR:
                    controls = new List<Control>() { txbProCarMaSP, txbProCarTenSP, txbProCarThuongHieu, cbbProCarLoai, nmrProCarRate,
                                                    txbProCarGiaSP, txbProCarGiaTT, btnProCarThayAnh1, btnProCarThayAnh2, btnProCarThayAnh3, btnProCarThayAnh4 };
                    btnProCarSua.Enabled = btnProCarLuu.Enabled = btnProCarHuy.Enabled = btnProCarXoa.Enabled = false;
                    tableImage = new BLImageCar().GetData().Tables[0];
                    table = new BLProductCar().GetData().Tables[0];
                    pnlProductCar.Enabled = true;
                    pnlProductCar.BringToFront();
                    break;
                default:
                    MessageBox.Show("Can't identify database");
                    break;
            }
            if (table != null)
                dgvData.DataSource = table;
            ClockControls(true);
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvData.CurrentCell.RowIndex;
            switch (dataType)
            {
                case DataManager.PRODUCTCAR:
                    btnProCarSua.Enabled = btnProCarXoa.Enabled = true;

                    txbProCarMaSP.Text = dgvData.Rows[row].Cells[0].Value.ToString();
                    txbProCarTenSP.Text = dgvData.Rows[row].Cells[1].Value.ToString();
                    txbProCarThuongHieu.Text = dgvData.Rows[row].Cells[2].Value.ToString();

                    cbbProCarLoai.Text = dgvData.Rows[row].Cells[3].Value.ToString();
                    txbProCarGiaSP.Text = dgvData.Rows[row].Cells[4].Value.ToString();
                    txbProCarGiaTT.Text = dgvData.Rows[row].Cells[5].Value.ToString();
                    nmrProCarRate.Value = (int)dgvData.Rows[row].Cells[6].Value;

                    DataRow rowTableImg = new BLImageCar().FindImageByID(txbProCarMaSP.Text.Trim());
                    MemoryStream mem = new MemoryStream((byte[])rowTableImg[1]);
                    ptbProCarImage1.Image = Image.FromStream(mem);

                    mem = new MemoryStream((byte[])rowTableImg[2]);
                    ptbProCarImage2.Image = Image.FromStream(mem);

                    mem = new MemoryStream((byte[])rowTableImg[3]);
                    ptbProCarImage3.Image = Image.FromStream(mem);

                    mem = new MemoryStream((byte[])rowTableImg[4]);
                    ptbProCarImage4.Image = Image.FromStream(mem);

                    break;
                case DataManager.DETAILCAR:
                    btnDetCarSua.Enabled = btnDetCarXoa.Enabled = true;

                    txbDetCarMaSP.Text = dgvData.Rows[row].Cells[0].Value.ToString();
                    txbDetCarMau.Text = dgvData.Rows[row].Cells[1].Value.ToString();

                    txbDetCarXang.Text = dgvData.Rows[row].Cells[2].Value.ToString();
                    txbDetCarXilanh.Text = dgvData.Rows[row].Cells[3].Value.ToString();
                    txbDetCarLoai.Text = dgvData.Rows[row].Cells[4].Value.ToString();

                    break;
                case DataManager.CATEGORY_CAR:
                    btnCatCarSua.Enabled = btnCatCarXoa.Enabled = true;
                    txbCatCarLoai.Text = dgvData.Rows[row].Cells[0].Value.ToString();

                    //DataRow rowTable = new BLCATEGORY_CAR().FindImageByID(txbProSmartMaSP.Text.Trim());
                    MemoryStream ms = new MemoryStream((byte[])dgvData.Rows[row].Cells[1].Value);
                    btnCatCarChangeImg.Image = Image.FromStream(ms);
                    break;


            }
        }

        #region Group Controls Manipulation Buttons
        private void btnThem_Click(object sender, EventArgs e)
        {
            isInsert = true;
            ClockControls(false);
            ClearControlsContent();
            switch (dataType)
            {
                case DataManager.PRODUCTCAR:
                    btnProCarLuu.Enabled = btnProCarHuy.Enabled = true;
                    btnProCarXoa.Enabled = btnProCarSua.Enabled = btnProCarThem.Enabled = false;
                    break;
                case DataManager.DETAILCAR:
                    btnDetCarLuu.Enabled = btnDetCarHuy.Enabled = true;
                    btnDetCarXoa.Enabled = btnDetCarSua.Enabled = btnDetCarThem.Enabled = false;
                    break;
                case DataManager.CATEGORY_CAR:
                    btnCatCarLuu.Enabled = btnCatCarHuy.Enabled = true;
                    btnCatCarXoa.Enabled = btnCatCarSua.Enabled = btnCatCarThem.Enabled = false;
                    break;
                default:
                    MessageBox.Show("Table Not Created");
                    break;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            isInsert = false;
            ClockControls(false);
            switch (dataType)
            {
                case DataManager.PRODUCTCAR:
                    txbProCarMaSP.Enabled = false;
                    btnProCarSua.Enabled = btnProCarThem.Enabled = false;
                    btnProCarLuu.Enabled = btnProCarHuy.Enabled = true;
                    break;
                case DataManager.DETAILCAR:
                    txbDetCarMaSP.Enabled = false;
                    btnDetCarSua.Enabled = btnDetCarThem.Enabled = false;
                    btnDetCarLuu.Enabled = btnDetCarHuy.Enabled = true;
                    break;
                case DataManager.CATEGORY_CAR:
                    txbCatCarLoai.Enabled = false;
                    btnCatCarSua.Enabled = btnCatCarThem.Enabled = false;
                    btnCatCarLuu.Enabled = btnCatCarHuy.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Table Not Created");
                    break;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClockControls(true);
            ClearControlsContent();
            switch (dataType)
            {
                case DataManager.PRODUCTCAR:
                    btnProCarHuy.Enabled = btnProCarLuu.Enabled = false;
                    btnProCarThem.Enabled = true;
                    break;
                case DataManager.DETAILCAR:
                    btnDetCarHuy.Enabled = btnDetCarLuu.Enabled = false;
                    btnDetCarThem.Enabled = true;
                    break;
                case DataManager.CATEGORY_CAR:
                    btnCatCarHuy.Enabled = btnCatCarLuu.Enabled = false;
                    btnCatCarThem.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Table Not Created");
                    break;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (dataType)
            {
                case DataManager.PRODUCTCAR:
                    if (isInsert)
                    {
                        if (!eventClick.Insert(txbProCarMaSP.Text.Trim(), txbProCarTenSP.Text, txbProCarThuongHieu.Text, cbbProCarLoai.Text,
                            txbProCarGiaSP.Text, txbProCarGiaTT.Text, nmrProCarRate.Value.ToString(), txbProCarMaSP.Text, ptbProCarImage1.Image,
                            ptbProCarImage2.Image, ptbProCarImage3.Image, ptbProCarImage4.Image, DateTime.Now.Date, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Thêm Thành Công!!!");
                    }
                    else
                    {
                        if (!eventClick.Update(txbProCarMaSP.Text.Trim(), txbProCarTenSP.Text, txbProCarThuongHieu.Text, cbbProCarLoai.Text,
                            txbProCarGiaSP.Text, txbProCarGiaTT.Text, nmrProCarRate.Value.ToString(), txbProCarMaSP.Text, ptbProCarImage1.Image,
                            ptbProCarImage2.Image, ptbProCarImage3.Image, ptbProCarImage4.Image, DateTime.Now.Date, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Sửa Thành Công!!!");
                    }
                    ClockControls(true);
                    btnProCarHuy.Enabled = btnProCarLuu.Enabled = false;
                    btnProCarThem.Enabled = true;
                    ClearControlsContent();
                    dgvData.DataSource = eventClick.Reload();
                    break;
                case DataManager.DETAILCAR:
                    if (isInsert)
                    {
                        if (!eventClick.Insert(txbDetCarMaSP.Text, txbDetCarMau.Text, txbDetCarXang.Text, 
                                            int.Parse(txbDetCarXilanh.Text), txbDetCarLoai.Text, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Thêm Thành Công!!!");
                    }
                    else
                    {
                        if (!eventClick.Insert(txbDetCarMaSP.Text, txbDetCarMau.Text, txbDetCarXang.Text, 
                                            int.Parse(txbDetCarXilanh.Text), txbDetCarLoai.Text, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Sửa Thành Công!!!");
                    }
                    ClockControls(true);
                    btnDetCarHuy.Enabled = btnDetCarLuu.Enabled = false;
                    btnDetCarThem.Enabled = true;
                    ClearControlsContent();
                    dgvData.DataSource = eventClick.Reload();
                    break;
                case DataManager.CATEGORY_CAR:
                    if (isInsert)
                    {
                        if (!eventClick.Insert(txbCatCarLoai.Text, btnCatCarChangeImg.Image, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Thêm Thành Công!!!");
                    }
                    else
                    {
                        if (!eventClick.Update(txbCatCarLoai.Text, btnCatCarChangeImg.Image, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Sửa Thành Công!!!");
                    }
                    ClockControls(true);
                    btnCatCarHuy.Enabled = btnCatCarLuu.Enabled = false;
                    btnCatCarThem.Enabled = true;
                    ClearControlsContent();
                    dgvData.DataSource = eventClick.Reload();
                    break;

                default:
                    MessageBox.Show("Table Not Created");
                    break;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            switch (dataType)
            {
                case DataManager.PRODUCTCAR:

                    if (!eventClick.Delete(txbProCarMaSP.Text.Trim(), ref err))
                        MessageBox.Show(err);
                    else
                    {
                        MessageBox.Show("Xóa Thành Công!!!");
                        ClockControls(true);
                        btnProCarXoa.Enabled = btnProCarSua.Enabled = btnProCarHuy.Enabled = btnProCarLuu.Enabled = false;
                        btnProCarThem.Enabled = true;
                        ClearControlsContent();
                        dgvData.DataSource = eventClick.Reload();
                    }

                    break;
                case DataManager.DETAILCAR:
                    if (!eventClick.Delete(txbDetCarMaSP.Text.Trim(), ref err))
                        MessageBox.Show(err);
                    else
                    {
                        MessageBox.Show("Xóa Thành Công!!!");
                        ClockControls(true);
                        btnDetCarXoa.Enabled = btnDetCarSua.Enabled = btnDetCarHuy.Enabled = btnDetCarLuu.Enabled = false;
                        btnDetCarThem.Enabled = true;
                        ClearControlsContent();
                        dgvData.DataSource = eventClick.Reload();
                    }
                    break;
                case DataManager.CATEGORY_CAR:
                    if (!eventClick.Delete(txbCatCarLoai.Text, ref err))
                        MessageBox.Show(err);
                    else
                    {
                        MessageBox.Show("Xóa Thành Công!!!");
                        ClockControls(true);
                        btnCatCarXoa.Enabled = btnCatCarSua.Enabled = btnCatCarHuy.Enabled = btnCatCarLuu.Enabled = false;
                        btnCatCarThem.Enabled = true;
                        ClearControlsContent();
                        dgvData.DataSource = eventClick.Reload();
                    }
                    break;
                default:
                    MessageBox.Show("Table Not Created");
                    break;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ClearControlsContent();
            ClockControls(true);
            dgvData.DataSource = eventClick.Reload();
        }

        private void ChangeImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Png Image (.png)|*.png|JPEG Image (.jpeg)|*.jpeg";
            of.ShowDialog();
            var path = of.FileName;
            switch (dataType)
            {
                case DataManager.PRODUCTCAR:
                    Bunifu.UI.WinForms.BunifuButton.BunifuButton t = (Bunifu.UI.WinForms.BunifuButton.BunifuButton)sender;

                    if (path != "")
                    {
                        switch (t.Tag.ToString())
                        {
                            case "1":
                                ptbProCarImage1.Image = Image.FromFile(path);
                                break;
                            case "2":
                                ptbProCarImage2.Image = Image.FromFile(path);
                                break;
                            case "3":
                                ptbProCarImage3.Image = Image.FromFile(path);
                                break;
                            case "4":
                                ptbProCarImage4.Image = Image.FromFile(path);
                                break;
                        }
                    }
                    break;
                case DataManager.CATEGORY_CAR:
                    if (path != "")
                        btnCatCarChangeImg.Image = Image.FromFile(path);
                    break;
            }
        }
        #endregion
    }
}
