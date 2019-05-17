using Server.BLL;
using Server.GUI;
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
    public partial class FormLaptop_Manager : Form
    {
        static public DataManager dataType; // To hand load table
        private List<Control> controls;     // To handle enable
        private DataTable table;            // To handle insert, remove, repair
        private DataTable tableImage;       // Use for table need manager image
        private OnClickListener eventClick; // To hand event click for all button
        private string err;
        private bool isInsert;
        public FormLaptop_Manager()
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
            Panel[] panelsControl = { pnlProductLaptop, pnlDetailLaptop, pnlCategoryLaptop };
            foreach (var p in panelsControl)
            {
                p.Enabled = false;
                p.SendToBack();
            }

            eventClick = new OnClickListener(dataType);
            switch (dataType)
            {
                case DataManager.CATEGORY_LAPTOP:
                    controls = new List<Control>() { txbCatLaptopLoai, btnCatLaptopChangeImg };
                    btnCatLaptopSua.Enabled = btnCatLaptopLuu.Enabled = btnCatLaptopHuy.Enabled = btnCatLaptopXoa.Enabled = false;
                    //NOTE
                    //table = new BLCA().GetData().Tables[0];
                    pnlCategoryLaptop.Enabled = true;
                    pnlCategoryLaptop.BringToFront();
                    break;
                case DataManager.DETAILLAPTOP:
                    controls = new List<Control>() { txbDetLaptopMaSP, txbDetLaptopManHinh, txbDetLaptopRam,
                                                    txbDetLaptopChip, txbDetLaptopPin, txbDetLaptopOCung, cbbDetLaptopHDH };
                    btnDetLaptopSua.Enabled = btnDetLaptopLuu.Enabled = btnDetLaptopHuy.Enabled = btnDetLaptopXoa.Enabled = false;
                    table = new BLDetailLaptop().GetData().Tables[0];
                    pnlDetailLaptop.Enabled = true;
                    pnlDetailLaptop.BringToFront();
                    break;
                case DataManager.PRODUCTLAPTOP:
                    controls = new List<Control>() { txbProLaptopMaSP, txbProLaptopTenSP, txbProLaptopThuongHieu, cbbProLaptopLoai, nmrProLaptopRate,
                                                    txbProLaptopGiaSP, txbProLaptopGiaTT, btnProLaptopThayAnh1, btnProLaptopThayAnh2, btnProLaptopThayAnh3, btnProLaptopThayAnh4 };
                    btnProLaptopSua.Enabled = btnProLaptopLuu.Enabled = btnProLaptopHuy.Enabled = btnProLaptopXoa.Enabled = false;
                    tableImage = new BLImageLaptop().GetData().Tables[0];
                    table = new BLProductLaptop().GetData().Tables[0];
                    pnlProductLaptop.Enabled = true;
                    pnlProductLaptop.BringToFront();
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
                case DataManager.PRODUCTLAPTOP:
                    btnProLaptopSua.Enabled = btnProLaptopXoa.Enabled = true;

                    txbProLaptopMaSP.Text = dgvData.Rows[row].Cells[0].Value.ToString();
                    txbProLaptopTenSP.Text = dgvData.Rows[row].Cells[1].Value.ToString();
                    txbProLaptopThuongHieu.Text = dgvData.Rows[row].Cells[2].Value.ToString();

                    cbbProLaptopLoai.Text = dgvData.Rows[row].Cells[3].Value.ToString();
                    txbProLaptopGiaSP.Text = dgvData.Rows[row].Cells[4].Value.ToString();
                    txbProLaptopGiaTT.Text = dgvData.Rows[row].Cells[5].Value.ToString();
                    nmrProLaptopRate.Value = (int)dgvData.Rows[row].Cells[6].Value;

                    DataRow rowTableImg = new BLImageLaptop().FindImageByID(txbProLaptopMaSP.Text.Trim());
                    MemoryStream mem = new MemoryStream((byte[])rowTableImg[1]);
                    ptbProLaptopImage1.Image = Image.FromStream(mem);

                    mem = new MemoryStream((byte[])rowTableImg[2]);
                    ptbProLapImage2.Image = Image.FromStream(mem);

                    mem = new MemoryStream((byte[])rowTableImg[3]);
                    ptbProLaptopImage3.Image = Image.FromStream(mem);

                    mem = new MemoryStream((byte[])rowTableImg[4]);
                    ptbProLaptopImage4.Image = Image.FromStream(mem);

                    break;
                case DataManager.DETAILLAPTOP:
                    btnDetLaptopSua.Enabled = btnDetLaptopXoa.Enabled = true;

                    txbDetLaptopMaSP.Text = dgvData.Rows[row].Cells[0].Value.ToString();
                    txbDetLaptopManHinh.Text = dgvData.Rows[row].Cells[1].Value.ToString();

                    txbDetLaptopRam.Text = dgvData.Rows[row].Cells[2].Value.ToString();
                    txbDetLaptopOCung.Text = dgvData.Rows[row].Cells[3].Value.ToString();

                    txbDetLaptopChip.Text = dgvData.Rows[row].Cells[4].Value.ToString();
                    cbbDetLaptopHDH.Text = dgvData.Rows[row].Cells[5].Value.ToString();

                    txbDetLaptopPin.Text = dgvData.Rows[row].Cells[6].Value.ToString();

                    break;
                case DataManager.CATEGORY_LAPTOP:
                    btnCatLaptopSua.Enabled = btnCatLaptopXoa.Enabled = true;
                    txbCatLaptopLoai.Text = dgvData.Rows[row].Cells[0].Value.ToString();

                    //DataRow rowTable = new BLCATEGORY_LAPTOP().FindImageByID(txbProSmartMaSP.Text.Trim());
                    MemoryStream ms = new MemoryStream((byte[])dgvData.Rows[row].Cells[1].Value);
                    btnCatLaptopChangeImg.Image = Image.FromStream(ms);
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
                case DataManager.PRODUCTLAPTOP:
                    btnProLaptopLuu.Enabled = btnProLaptopHuy.Enabled = true;
                    btnProLaptopXoa.Enabled = btnProLaptopSua.Enabled = btnProLaptopThem.Enabled = false;
                    break;
                case DataManager.DETAILLAPTOP:
                    btnDetLaptopLuu.Enabled = btnDetLaptopHuy.Enabled = true;
                    btnDetLaptopXoa.Enabled = btnDetLaptopSua.Enabled = btnDetLaptopThem.Enabled = false;
                    break;
                case DataManager.CATEGORY_LAPTOP:
                    btnCatLaptopLuu.Enabled = btnCatLaptopHuy.Enabled = true;
                    btnCatLaptopXoa.Enabled = btnCatLaptopSua.Enabled = btnCatLaptopThem.Enabled = false;
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
                case DataManager.PRODUCTLAPTOP:
                    txbProLaptopMaSP.Enabled = false;
                    btnProLaptopSua.Enabled = btnProLaptopThem.Enabled = false;
                    btnProLaptopLuu.Enabled = btnProLaptopHuy.Enabled = true;
                    break;
                case DataManager.DETAILLAPTOP:
                    txbDetLaptopMaSP.Enabled = false;
                    btnDetLaptopSua.Enabled = btnDetLaptopThem.Enabled = false;
                    btnDetLaptopLuu.Enabled = btnDetLaptopHuy.Enabled = true;
                    break;
                case DataManager.CATEGORY_LAPTOP:
                    txbCatLaptopLoai.Enabled = false;
                    btnCatLaptopSua.Enabled = btnCatLaptopThem.Enabled = false;
                    btnCatLaptopLuu.Enabled = btnCatLaptopHuy.Enabled = true;
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
                case DataManager.PRODUCTLAPTOP:
                    btnProLaptopHuy.Enabled = btnProLaptopLuu.Enabled = false;
                    btnProLaptopThem.Enabled = true;
                    break;
                case DataManager.DETAILLAPTOP:
                    btnDetLaptopHuy.Enabled = btnDetLaptopLuu.Enabled = false;
                    btnDetLaptopThem.Enabled = true;
                    break;
                case DataManager.CATEGORY_LAPTOP:
                    btnCatLaptopHuy.Enabled = btnCatLaptopLuu.Enabled = false;
                    btnCatLaptopThem.Enabled = true;
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
                case DataManager.PRODUCTLAPTOP:
                    if (isInsert)
                    {
                        if (!eventClick.Insert(txbProLaptopMaSP.Text.Trim(), txbProLaptopTenSP.Text, txbProLaptopThuongHieu.Text, cbbProLaptopLoai.Text,
                            txbProLaptopGiaSP.Text, txbProLaptopGiaTT.Text, nmrProLaptopRate.Value.ToString(), txbProLaptopMaSP.Text, ptbProLaptopImage1.Image,
                            ptbProLapImage2.Image, ptbProLaptopImage3.Image, ptbProLaptopImage4.Image, DateTime.Now.Date, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Thêm Thành Công!!!");
                    }
                    else
                    {
                        if (!eventClick.Update(txbProLaptopMaSP.Text.Trim(), txbProLaptopTenSP.Text, txbProLaptopThuongHieu.Text, cbbProLaptopLoai.Text,
                            txbProLaptopGiaSP.Text, txbProLaptopGiaTT.Text, nmrProLaptopRate.Value.ToString(), txbProLaptopMaSP.Text, ptbProLaptopImage1.Image,
                            ptbProLapImage2.Image, ptbProLaptopImage3.Image, ptbProLaptopImage4.Image, DateTime.Now.Date, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Sửa Thành Công!!!");
                    }
                    ClockControls(true);
                    btnProLaptopHuy.Enabled = btnProLaptopLuu.Enabled = false;
                    btnProLaptopThem.Enabled = true;
                    ClearControlsContent();
                    dgvData.DataSource = eventClick.Reload();
                    break;
                case DataManager.DETAILLAPTOP:
                    if (isInsert)
                    {
                        if (!eventClick.Insert(txbDetLaptopMaSP.Text, txbDetLaptopManHinh.Text, txbDetLaptopRam.Text, 
                            txbDetLaptopOCung.Text, txbDetLaptopChip.Text, cbbDetLaptopHDH.Text, txbDetLaptopPin.Text, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Thêm Thành Công!!!");
                    }
                    else
                    {
                        if (!eventClick.Update(txbDetLaptopMaSP.Text.Trim(), txbDetLaptopManHinh.Text, txbDetLaptopRam.Text, txbDetLaptopChip.Text, cbbDetLaptopHDH.Text, txbDetLaptopPin.Text,
                            txbDetLaptopOCung.Text, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Sửa Thành Công!!!");
                    }
                    ClockControls(true);
                    btnDetLaptopHuy.Enabled = btnDetLaptopLuu.Enabled = false;
                    btnDetLaptopThem.Enabled = true;
                    ClearControlsContent();
                    dgvData.DataSource = eventClick.Reload();
                    break;
                case DataManager.CATEGORY_LAPTOP:
                    if (isInsert)
                    {
                        if (!eventClick.Insert(txbCatLaptopLoai.Text, btnCatLaptopChangeImg.Image, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Thêm Thành Công!!!");
                    }
                    else
                    {
                        if (!eventClick.Update(txbCatLaptopLoai.Text, btnCatLaptopChangeImg.Image, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Sửa Thành Công!!!");
                    }
                    ClockControls(true);
                    btnCatLaptopHuy.Enabled = btnCatLaptopLuu.Enabled = false;
                    btnCatLaptopThem.Enabled = true;
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
                case DataManager.PRODUCTLAPTOP:

                    if (!eventClick.Delete(txbProLaptopMaSP.Text.Trim(), ref err))
                        MessageBox.Show(err);
                    else
                    {
                        MessageBox.Show("Xóa Thành Công!!!");
                        ClockControls(true);
                        btnProLaptopXoa.Enabled = btnProLaptopSua.Enabled = btnProLaptopHuy.Enabled = btnProLaptopLuu.Enabled = false;
                        btnProLaptopThem.Enabled = true;
                        ClearControlsContent();
                        dgvData.DataSource = eventClick.Reload();
                    }

                    break;
                case DataManager.DETAILLAPTOP:
                    if (!eventClick.Delete(txbDetLaptopMaSP.Text.Trim(), ref err))
                        MessageBox.Show(err);
                    else
                    {
                        MessageBox.Show("Xóa Thành Công!!!");
                        ClockControls(true);
                        btnDetLaptopXoa.Enabled = btnDetLaptopSua.Enabled = btnDetLaptopHuy.Enabled = btnDetLaptopLuu.Enabled = false;
                        btnDetLaptopThem.Enabled = true;
                        ClearControlsContent();
                        dgvData.DataSource = eventClick.Reload();
                    }
                    break;
                case DataManager.CATEGORY_LAPTOP:
                    if (!eventClick.Delete(txbCatLaptopLoai.Text, ref err))
                        MessageBox.Show(err);
                    else
                    {
                        MessageBox.Show("Xóa Thành Công!!!");
                        ClockControls(true);
                        btnCatLaptopXoa.Enabled = btnCatLaptopSua.Enabled = btnCatLaptopHuy.Enabled = btnCatLaptopLuu.Enabled = false;
                        btnCatLaptopThem.Enabled = true;
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
                case DataManager.PRODUCTLAPTOP:
                    Bunifu.UI.WinForms.BunifuButton.BunifuButton t = (Bunifu.UI.WinForms.BunifuButton.BunifuButton)sender;

                    if (path != "")
                    {
                        switch (t.Tag.ToString())
                        {
                            case "1":
                                ptbProLaptopImage1.Image = Image.FromFile(path);
                                break;
                            case "2":
                                ptbProLapImage2.Image = Image.FromFile(path);
                                break;
                            case "3":
                                ptbProLaptopImage3.Image = Image.FromFile(path);
                                break;
                            case "4":
                                ptbProLaptopImage4.Image = Image.FromFile(path);
                                break;
                        }
                    }
                    break;
                case DataManager.CATEGORY_LAPTOP:
                    if (path != "")
                        btnCatLaptopChangeImg.Image = Image.FromFile(path);
                    break;
            }
        }
        #endregion
    }
}
