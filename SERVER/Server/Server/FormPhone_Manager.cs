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
using Server.BLL;
using Server.BLL.CATEGORY;
using Server.GUI;

namespace Server
{
    public partial class FormPhone_Manager : Form
    {
        static public DataManager dataType; // To hand load table
        private List<Control> controls;     // To handle enable
        private DataTable table;            // To handle insert, remove, repair
        private DataTable tableImage;       // Use for table need manager image
        private OnClickListener eventClick; // To hand event click for all button
        private string err;
        private bool isInsert;
        public FormPhone_Manager()
        {
            InitializeComponent();
        }

        // Set Enable or Unenable Controls
        private void ClockControls(bool isClock)
        {
            if(controls != null)
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
            Panel[] panelsControl = { pnlProductSmartPhone };
            foreach(var p in panelsControl)
            {
                p.Enabled = false;
                p.SendToBack();
            }

            eventClick = new OnClickListener(dataType);
            switch (dataType)
            {
                case DataManager.CATEGORY_SMARTPHONE_TABLET:
                    controls = new List<Control>() { txbCatSmartLoai, btnCatSmartChangeImg };
                    btnCatSmartSua.Enabled = btnCatSmartLuu.Enabled = btnCatSmartHuy.Enabled = btnCatSmartXoa.Enabled = false;
                    table = new BLCategory_Smartphone_Tablet().GetData().Tables[0];
                    pnlCategorySmartTablet.Enabled = true;
                    pnlCategorySmartTablet.BringToFront();
                    break;
                case DataManager.DETAILSMARTPHONE:
                    controls = new List<Control>() { txbDetSmartMaSP, txbDetSmartCamTruoc, txbDetSmartCamSau, ckbDetSmartFlash, ckbDetSmartNFC, ckbDetSmartFM,
                                                    txbDetSmartManHinh, txbDetSmartRam, txbDetSmartChip, txbDetSmartPin, txbDetSmartKetNoi, cbbDetSmartHDH, cbbDetSmartSim };
                    btnDetSmartSua.Enabled = btnDetSmartLuu.Enabled = btnDetSmartHuy.Enabled = btnDetSmartXoa.Enabled = false;
                    table = new BLDetailSmartPhone().GetData().Tables[0];
                    pnlDetailSmartPhone.Enabled = true;
                    pnlDetailSmartPhone.BringToFront();
                    break;
                case DataManager.PRODUCTSMARTPHONE:
                    controls = new List<Control>() { txbProSmartMaSP, txbProSmartTenSP, txbProSmartThuongHieu, cbbProSmartLoai, nmrProSmartRate,
                                                    txbProSmartGiaSP, txbProSmartGiaTT, btnProSmartThayAnh1, btnProSmartThayAnh2, btnProSmartThayAnh3, btnProSmartThayAnh4 };
                    btnProSmartSua.Enabled = btnProSmartLuu.Enabled = btnProSmartHuy.Enabled = btnProSmartXoa.Enabled = false;
                    tableImage = new BLImageSmartPhone().GetData().Tables[0];
                    table = new BLProductSmart().GetData().Tables[0];
                    pnlProductSmartPhone.Enabled = true;
                    pnlProductSmartPhone.BringToFront();
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
            switch(dataType)
            {
                case DataManager.PRODUCTSMARTPHONE:
                    btnProSmartSua.Enabled = btnProSmartXoa.Enabled = true;

                    txbProSmartMaSP.Text = dgvData.Rows[row].Cells[0].Value.ToString();
                    txbProSmartTenSP.Text = dgvData.Rows[row].Cells[1].Value.ToString();
                    txbProSmartThuongHieu.Text = dgvData.Rows[row].Cells[2].Value.ToString();

                    cbbProSmartLoai.Text = dgvData.Rows[row].Cells[3].Value.ToString();
                    txbProSmartGiaSP.Text = dgvData.Rows[row].Cells[4].Value.ToString();
                    txbProSmartGiaTT.Text = dgvData.Rows[row].Cells[5].Value.ToString();
                    nmrProSmartRate.Value = (int)dgvData.Rows[row].Cells[6].Value;

                    DataRow rowTableImg = new BLImageSmartPhone().FindImageByID(txbProSmartMaSP.Text.Trim());
                    MemoryStream mem = new MemoryStream((byte[])rowTableImg[1]);
                    ptbProSmartImage1.Image = Image.FromStream(mem);

                    mem = new MemoryStream((byte[])rowTableImg[2]);
                    ptbProSmartImage2.Image = Image.FromStream(mem);

                    mem = new MemoryStream((byte[])rowTableImg[3]);
                    ptbProSmartImage3.Image = Image.FromStream(mem);

                    mem = new MemoryStream((byte[])rowTableImg[4]);
                    ptbProSmartImage4.Image = Image.FromStream(mem);

                    break;
                case DataManager.DETAILSMARTPHONE:
                    btnDetSmartSua.Enabled = btnDetSmartXoa.Enabled = true;

                    txbDetSmartMaSP.Text = dgvData.Rows[row].Cells[0].Value.ToString();
                    txbDetSmartManHinh.Text = dgvData.Rows[row].Cells[1].Value.ToString();
                    txbDetSmartCamTruoc.Text = dgvData.Rows[row].Cells[2].Value.ToString();
                    txbDetSmartCamSau.Text = dgvData.Rows[row].Cells[3].Value.ToString();

                    ckbDetSmartFlash.Checked = (Boolean)dgvData.Rows[row].Cells[4].Value;
                    txbDetSmartRam.Text = dgvData.Rows[row].Cells[5].Value.ToString();
                    txbDetSmartChip.Text = dgvData.Rows[row].Cells[6].Value.ToString();
                    cbbDetSmartHDH.Text = dgvData.Rows[row].Cells[7].Value.ToString();

                    txbDetSmartPin.Text = dgvData.Rows[row].Cells[8].Value.ToString();
                    cbbDetSmartSim.Text = dgvData.Rows[row].Cells[9].Value.ToString();
                    txbDetSmartKetNoi.Text = dgvData.Rows[row].Cells[10].Value.ToString();

                    ckbDetSmartNFC.Checked = (Boolean)dgvData.Rows[row].Cells[11].Value;
                    ckbDetSmartFM.Checked = (Boolean)dgvData.Rows[row].Cells[12].Value;

                    break;
                case DataManager.CATEGORY_SMARTPHONE_TABLET:
                    btnCatSmartSua.Enabled = btnCatSmartXoa.Enabled = true;
                    txbCatSmartLoai.Text = dgvData.Rows[row].Cells[0].Value.ToString();

                    //DataRow rowTable = new BLCategory_Smartphone_Tablet().FindImageByID(txbProSmartMaSP.Text.Trim());
                    MemoryStream ms = new MemoryStream((byte[])dgvData.Rows[row].Cells[1].Value);
                    btnCatSmartChangeImg.Image = Image.FromStream(ms);
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
                case DataManager.PRODUCTSMARTPHONE:
                    btnProSmartLuu.Enabled = btnProSmartHuy.Enabled = true;
                    btnProSmartXoa.Enabled = btnProSmartSua.Enabled = btnProSmartThem.Enabled = false;
                    break;
                case DataManager.DETAILSMARTPHONE:
                    btnDetSmartLuu.Enabled = btnDetSmartHuy.Enabled = true;
                    btnDetSmartXoa.Enabled = btnDetSmartSua.Enabled = btnDetSmartThem.Enabled = false;
                    break;
                case DataManager.CATEGORY_SMARTPHONE_TABLET:
                    btnCatSmartLuu.Enabled = btnCatSmartHuy.Enabled = true;
                    btnCatSmartXoa.Enabled = btnCatSmartSua.Enabled = btnCatSmartThem.Enabled = false;
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
                case DataManager.PRODUCTSMARTPHONE:
                    txbProSmartMaSP.Enabled = false;
                    btnProSmartSua.Enabled = btnProSmartThem.Enabled = false;
                    btnProSmartLuu.Enabled = btnProSmartHuy.Enabled = true;
                    break;
                case DataManager.DETAILSMARTPHONE:
                    txbDetSmartMaSP.Enabled = false;
                    btnDetSmartSua.Enabled = btnDetSmartThem.Enabled = false;
                    btnDetSmartLuu.Enabled = btnDetSmartHuy.Enabled = true;
                    break;
                case DataManager.CATEGORY_SMARTPHONE_TABLET:
                    txbCatSmartLoai.Enabled = false;
                    btnCatSmartSua.Enabled = btnCatSmartThem.Enabled = false;
                    btnCatSmartLuu.Enabled = btnCatSmartHuy.Enabled = true;
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
                case DataManager.PRODUCTSMARTPHONE:
                    btnProSmartHuy.Enabled = btnProSmartLuu.Enabled = false;
                    btnProSmartThem.Enabled = true;
                    break;
                case DataManager.DETAILSMARTPHONE:
                    btnDetSmartHuy.Enabled = btnDetSmartLuu.Enabled = false;
                    btnDetSmartThem.Enabled = true;
                    break;
                case DataManager.CATEGORY_SMARTPHONE_TABLET:
                    btnCatSmartHuy.Enabled = btnCatSmartLuu.Enabled = false;
                    btnCatSmartThem.Enabled = true;
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
                case DataManager.PRODUCTSMARTPHONE:
                    if (isInsert)
                    {
                        if (!eventClick.Insert(txbProSmartMaSP.Text.Trim(), txbProSmartTenSP.Text, txbProSmartThuongHieu.Text, cbbProSmartLoai.Text,
                            txbProSmartGiaSP.Text, txbProSmartGiaTT.Text, nmrProSmartRate.Value.ToString(), txbProSmartMaSP.Text, ptbProSmartImage1.Image, 
                            ptbProSmartImage2.Image, ptbProSmartImage3.Image, ptbProSmartImage4.Image, DateTime.Now.Date, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Thêm Thành Công!!!");
                    }
                    else
                    {
                        if (!eventClick.Update(txbProSmartMaSP.Text.Trim(), txbProSmartTenSP.Text, txbProSmartThuongHieu.Text, cbbProSmartLoai.Text,
                            txbProSmartGiaSP.Text, txbProSmartGiaTT.Text, nmrProSmartRate.Value.ToString(), txbProSmartMaSP.Text, ptbProSmartImage1.Image,
                            ptbProSmartImage2.Image, ptbProSmartImage3.Image, ptbProSmartImage4.Image, DateTime.Now.Date, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Sửa Thành Công!!!");
                    }
                    ClockControls(true);
                    btnProSmartHuy.Enabled = btnProSmartLuu.Enabled = false;
                    btnProSmartThem.Enabled = true;
                    ClearControlsContent();
                    dgvData.DataSource = eventClick.Reload();
                    break;
                case DataManager.DETAILSMARTPHONE:
                    if (isInsert)
                    {
                        if (!eventClick.Insert(txbDetSmartMaSP.Text.Trim(), txbDetSmartManHinh.Text, txbDetSmartCamTruoc.Text, txbDetSmartCamSau.Text,
                            ckbDetSmartFlash.Checked, txbDetSmartRam.Text, txbDetSmartChip.Text, cbbDetSmartHDH.Text, txbDetSmartPin.Text, cbbDetSmartSim.Text,
                            txbDetSmartKetNoi.Text, ckbDetSmartNFC.Checked, ckbDetSmartFM.Checked, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Thêm Thành Công!!!");
                    }
                    else
                    {
                        if (!eventClick.Update(txbDetSmartMaSP.Text.Trim(), txbDetSmartManHinh.Text, txbDetSmartCamTruoc.Text, txbDetSmartCamSau.Text,
                            ckbDetSmartFlash.Checked, txbDetSmartRam.Text, txbDetSmartChip.Text, cbbDetSmartHDH.Text, txbDetSmartPin.Text, cbbDetSmartSim.Text,
                            txbDetSmartKetNoi.Text, ckbDetSmartNFC.Checked, ckbDetSmartFM.Checked, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Sửa Thành Công!!!");
                    }
                    ClockControls(true);
                    btnDetSmartHuy.Enabled = btnDetSmartLuu.Enabled = false;
                    btnDetSmartThem.Enabled = true;
                    ClearControlsContent();
                    dgvData.DataSource = eventClick.Reload();
                    break;
                case DataManager.CATEGORY_SMARTPHONE_TABLET:
                    if (isInsert)
                    {
                        if (!eventClick.Insert(txbCatSmartLoai.Text, btnCatSmartChangeImg.Image, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Thêm Thành Công!!!");
                    }
                    else
                    {
                        if (!eventClick.Update(txbCatSmartLoai.Text, btnCatSmartChangeImg.Image, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Sửa Thành Công!!!");
                    }
                    ClockControls(true);
                    btnCatSmartHuy.Enabled = btnCatSmartLuu.Enabled = false;
                    btnCatSmartThem.Enabled = true;
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
                case DataManager.PRODUCTSMARTPHONE:
                    
                    if (!eventClick.Delete(txbProSmartMaSP.Text.Trim(), ref err))
                        MessageBox.Show(err);
                    else
                    {
                        MessageBox.Show("Xóa Thành Công!!!");
                        ClockControls(true);
                        btnProSmartXoa.Enabled = btnProSmartSua.Enabled = btnProSmartHuy.Enabled = btnProSmartLuu.Enabled = false;
                        btnProSmartThem.Enabled = true;
                        ClearControlsContent();
                        dgvData.DataSource = eventClick.Reload();
                    }

                    break;
                case DataManager.DETAILSMARTPHONE:
                    if (!eventClick.Delete(txbDetSmartMaSP.Text.Trim(), ref err))
                        MessageBox.Show(err);
                    else
                    {
                        MessageBox.Show("Xóa Thành Công!!!");
                        ClockControls(true);
                        btnDetSmartXoa.Enabled = btnDetSmartSua.Enabled = btnDetSmartHuy.Enabled = btnDetSmartLuu.Enabled = false;
                        btnDetSmartThem.Enabled = true;
                        ClearControlsContent();
                        dgvData.DataSource = eventClick.Reload();
                    }
                    break;
                case DataManager.CATEGORY_SMARTPHONE_TABLET:
                    if (!eventClick.Delete(txbCatSmartLoai.Text,ref err))
                        MessageBox.Show(err);
                    else
                    {
                        MessageBox.Show("Xóa Thành Công!!!");
                        ClockControls(true);
                        btnCatSmartXoa.Enabled = btnCatSmartSua.Enabled = btnCatSmartHuy.Enabled = btnCatSmartLuu.Enabled = false;
                        btnCatSmartThem.Enabled = true;
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
                case DataManager.PRODUCTSMARTPHONE:
                    Bunifu.UI.WinForms.BunifuButton.BunifuButton t = (Bunifu.UI.WinForms.BunifuButton.BunifuButton)sender;
                    
                    if (path != "")
                    {
                        switch (t.Tag.ToString())
                        {
                            case "1":
                                ptbProSmartImage1.Image = Image.FromFile(path);
                                break;
                            case "2":
                                ptbProSmartImage2.Image = Image.FromFile(path);
                                break;
                            case "3":
                                ptbProSmartImage3.Image = Image.FromFile(path);
                                break;
                            case "4":
                                ptbProSmartImage4.Image = Image.FromFile(path);
                                break;
                        }
                    }
                    break;
                case DataManager.CATEGORY_SMARTPHONE_TABLET:
                    if (path != "")
                        btnCatSmartChangeImg.Image = Image.FromFile(path);
                    break;
            }
        }
        #endregion
    }
}
