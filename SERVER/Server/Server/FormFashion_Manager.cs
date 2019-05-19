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
    public partial class FormFashion_Manager : Form
    {
        static public DataManager dataType; // To hand load table
        private List<Control> controls;     // To handle enable
        private DataTable table;            // To handle insert, remove, repair
        private DataTable tableImage;       // Use for table need manager image
        private OnClickListener eventClick; // To hand event click for all button
        private string err;
        private bool isInsert;
        public FormFashion_Manager()
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
            Panel[] panelsControl = { pnlProductFashion, pnlDetailFashion, pnlCategoryFashion };
            foreach (var p in panelsControl)
            {
                p.Enabled = false;
                p.SendToBack();
            }

            eventClick = new OnClickListener(dataType);
            switch (dataType)
            {
                case DataManager.CATEGORY_FASHION:
                    controls = new List<Control>() { txbCatFashionLoai, btnCatFashionChangeImg };
                    table = new BLCategory_Fashion().GetData().Tables[0];
                    pnlCategoryFashion.Enabled = true;
                    pnlCategoryFashion.BringToFront();
                    break;
                case DataManager.DETAILFASHION:
                    controls = new List<Control>() { txbDetLaptopMaSP, txbDetFashionMauSac, txbDetFashionChatLieu,
                                                     txbDetFashionkieuDang, cbbDetFashionSize };
                    btnDetFashionSua.Enabled = btnDetFashionLuu.Enabled = btnDetFashionHuy.Enabled = btnDetFashionXoa.Enabled = false;
                    table = new BLDetailFashion().GetData().Tables[0];
                    pnlDetailFashion.Enabled = true;
                    pnlDetailFashion.BringToFront();
                    break;
                case DataManager.PRODUCTFASHION:
                    controls = new List<Control>() { txbProFashionMaSP, txbProFashionTenSP, txbProFashionThuongHieu, cbbProFashionLoai, nmrProFashionRate,
                                                    txbProFashionGiaSP, txbProFashionGiaTT, btnProFashionThayAnh1, btnProFashionThayAnh2, btnProFashionThayAnh3, btnProFashionThayAnh4 };
                    btnProLaptopSua.Enabled = btnProLaptopLuu.Enabled = btnProLaptopHuy.Enabled = btnProLaptopXoa.Enabled = false;
                    tableImage = new BLImageLaptop().GetData().Tables[0];
                    table = new BLProductFashion().GetData().Tables[0];
                    pnlProductFashion.Enabled = true;
                    pnlProductFashion.BringToFront();
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
                case DataManager.PRODUCTFASHION:
                    btnProLaptopSua.Enabled = btnProLaptopXoa.Enabled = true;

                    txbProFashionMaSP.Text = dgvData.Rows[row].Cells[0].Value.ToString();
                    txbProFashionTenSP.Text = dgvData.Rows[row].Cells[1].Value.ToString();
                    txbProFashionThuongHieu.Text = dgvData.Rows[row].Cells[2].Value.ToString();

                    cbbProFashionLoai.Text = dgvData.Rows[row].Cells[3].Value.ToString();
                    txbProFashionGiaSP.Text = dgvData.Rows[row].Cells[4].Value.ToString();
                    txbProFashionGiaTT.Text = dgvData.Rows[row].Cells[5].Value.ToString();
                    nmrProFashionRate.Value = (int)dgvData.Rows[row].Cells[6].Value;

                    DataRow rowTableImg = new BLImageFahion().FindImageByID(txbProFashionMaSP.Text.Trim());
                    MemoryStream mem = new MemoryStream((byte[])rowTableImg[1]);
                    ptbProFashionImage1.Image = Image.FromStream(mem);

                    mem = new MemoryStream((byte[])rowTableImg[2]);
                    ptbProFashionImage2.Image = Image.FromStream(mem);

                    mem = new MemoryStream((byte[])rowTableImg[3]);
                    ptbProFashionImage3.Image = Image.FromStream(mem);

                    mem = new MemoryStream((byte[])rowTableImg[4]);
                    ptbProFashionImage4.Image = Image.FromStream(mem);

                    break;
                case DataManager.DETAILFASHION:
                    btnDetFashionSua.Enabled = btnDetFashionXoa.Enabled = true;

                    txbDetLaptopMaSP.Text = dgvData.Rows[row].Cells[0].Value.ToString();
                    txbDetFashionMauSac.Text = dgvData.Rows[row].Cells[1].Value.ToString();
                    cbbDetFashionSize.Text = dgvData.Rows[row].Cells[2].Value.ToString();

                    txbDetFashionkieuDang.Text = dgvData.Rows[row].Cells[3].Value.ToString();
                    txbDetFashionChatLieu.Text = dgvData.Rows[row].Cells[4].Value.ToString();

                    break;
                case DataManager.CATEGORY_FASHION:
                    btnCatFashionSua.Enabled = btnCatFahionXoa.Enabled = true;
                    txbCatFashionLoai.Text = dgvData.Rows[row].Cells[0].Value.ToString();

                    //DataRow rowTable = new BLCATEGORY_LAPTOP().FindImageByID(txbProSmartMaSP.Text.Trim());
                    MemoryStream ms = new MemoryStream((byte[])dgvData.Rows[row].Cells[1].Value);
                    btnCatFashionChangeImg.Image = Image.FromStream(ms);
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
                case DataManager.PRODUCTFASHION:
                    btnProLaptopLuu.Enabled = btnProLaptopHuy.Enabled = true;
                    btnProLaptopXoa.Enabled = btnProLaptopSua.Enabled = btnProLaptopThem.Enabled = false;
                    break;
                case DataManager.DETAILFASHION:
                    btnDetFashionLuu.Enabled = btnDetFashionHuy.Enabled = true;
                    btnDetFashionXoa.Enabled = btnDetFashionSua.Enabled = btnDetFashionThem.Enabled = false;
                    break;
                case DataManager.CATEGORY_FASHION:
                    btnCatFashionLuu.Enabled = btnCatFashionHuy.Enabled = true;
                    btnCatFahionXoa.Enabled = btnCatFashionSua.Enabled = btnCatFashionThem.Enabled = false;
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
                case DataManager.PRODUCTFASHION:
                    txbProFashionMaSP.Enabled = false;
                    btnProLaptopSua.Enabled = btnProLaptopThem.Enabled = false;
                    btnProLaptopLuu.Enabled = btnProLaptopHuy.Enabled = true;
                    break;
                case DataManager.DETAILFASHION:
                    txbDetLaptopMaSP.Enabled = false;
                    btnDetFashionSua.Enabled = btnDetFashionThem.Enabled = false;
                    btnDetFashionLuu.Enabled = btnDetFashionHuy.Enabled = true;
                    break;
                case DataManager.CATEGORY_FASHION:
                    txbCatFashionLoai.Enabled = false;
                    btnCatFashionSua.Enabled = btnCatFashionThem.Enabled = false;
                    btnCatFashionLuu.Enabled = btnCatFashionHuy.Enabled = true;
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
                case DataManager.PRODUCTFASHION:
                    btnProLaptopHuy.Enabled = btnProLaptopLuu.Enabled = false;
                    btnProLaptopThem.Enabled = true;
                    break;
                case DataManager.DETAILFASHION:
                    btnDetFashionHuy.Enabled = btnDetFashionLuu.Enabled = false;
                    btnDetFashionThem.Enabled = true;
                    break;
                case DataManager.CATEGORY_FASHION:
                    btnCatFashionHuy.Enabled = btnCatFashionLuu.Enabled = false;
                    btnCatFashionThem.Enabled = true;
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
                case DataManager.PRODUCTFASHION:
                    if (isInsert)
                    {
                        if (!eventClick.Insert(txbProFashionMaSP.Text.Trim(), txbProFashionTenSP.Text, txbProFashionThuongHieu.Text, cbbProFashionLoai.Text,
                            txbProFashionGiaSP.Text, txbProFashionGiaTT.Text, nmrProFashionRate.Value.ToString(), txbProFashionMaSP.Text, ptbProFashionImage1.Image,
                            ptbProFashionImage2.Image, ptbProFashionImage3.Image, ptbProFashionImage4.Image, DateTime.Now.Date, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Thêm Thành Công!!!");
                    }
                    else
                    {
                        if (!eventClick.Update(txbProFashionMaSP.Text.Trim(), txbProFashionTenSP.Text, txbProFashionThuongHieu.Text, cbbProFashionLoai.Text,
                            txbProFashionGiaSP.Text, txbProFashionGiaTT.Text, nmrProFashionRate.Value.ToString(), txbProFashionMaSP.Text, ptbProFashionImage1.Image,
                            ptbProFashionImage2.Image, ptbProFashionImage3.Image, ptbProFashionImage4.Image, DateTime.Now.Date, ref err))
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
                case DataManager.DETAILFASHION:
                    if (isInsert)
                    {
                        if (!eventClick.Insert(txbDetLaptopMaSP.Text, txbDetFashionMauSac.Text, cbbDetFashionSize.Text, 
                                                txbDetFashionkieuDang.Text, txbDetFashionChatLieu.Text, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Thêm Thành Công!!!");
                    }
                    else
                    {
                        if (!eventClick.Insert(txbDetLaptopMaSP.Text, txbDetFashionMauSac.Text, cbbDetFashionSize.Text,
                                                txbDetFashionkieuDang.Text, txbDetFashionChatLieu.Text, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Sửa Thành Công!!!");
                    }
                    ClockControls(true);
                    btnDetFashionHuy.Enabled = btnDetFashionLuu.Enabled = false;
                    btnDetFashionThem.Enabled = true;
                    ClearControlsContent();
                    dgvData.DataSource = eventClick.Reload();
                    break;
                case DataManager.CATEGORY_FASHION:
                    if (isInsert)
                    {
                        if (!eventClick.Insert(txbCatFashionLoai.Text, btnCatFashionChangeImg.Image, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Thêm Thành Công!!!");
                    }
                    else
                    {
                        if (!eventClick.Update(txbCatFashionLoai.Text, btnCatFashionChangeImg.Image, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Sửa Thành Công!!!");
                    }
                    ClockControls(true);
                    btnCatFashionHuy.Enabled = btnCatFashionLuu.Enabled = false;
                    btnCatFashionThem.Enabled = true;
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
                case DataManager.PRODUCTFASHION:

                    if (!eventClick.Delete(txbProFashionMaSP.Text.Trim(), ref err))
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
                case DataManager.DETAILFASHION:
                    if (!eventClick.Delete(txbDetLaptopMaSP.Text.Trim(), ref err))
                        MessageBox.Show(err);
                    else
                    {
                        MessageBox.Show("Xóa Thành Công!!!");
                        ClockControls(true);
                        btnDetFashionXoa.Enabled = btnDetFashionSua.Enabled = btnDetFashionHuy.Enabled = btnDetFashionLuu.Enabled = false;
                        btnDetFashionThem.Enabled = true;
                        ClearControlsContent();
                        dgvData.DataSource = eventClick.Reload();
                    }
                    break;
                case DataManager.CATEGORY_FASHION:
                    if (!eventClick.Delete(txbCatFashionLoai.Text, ref err))
                        MessageBox.Show(err);
                    else
                    {
                        MessageBox.Show("Xóa Thành Công!!!");
                        ClockControls(true);
                        btnCatFahionXoa.Enabled = btnCatFashionSua.Enabled = btnCatFashionHuy.Enabled = btnCatFashionLuu.Enabled = false;
                        btnCatFashionThem.Enabled = true;
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
                case DataManager.PRODUCTFASHION:
                    Bunifu.UI.WinForms.BunifuButton.BunifuButton t = (Bunifu.UI.WinForms.BunifuButton.BunifuButton)sender;

                    if (path != "")
                    {
                        switch (t.Tag.ToString())
                        {
                            case "1":
                                ptbProFashionImage1.Image = Image.FromFile(path);
                                break;
                            case "2":
                                ptbProFashionImage2.Image = Image.FromFile(path);
                                break;
                            case "3":
                                ptbProFashionImage3.Image = Image.FromFile(path);
                                break;
                            case "4":
                                ptbProFashionImage4.Image = Image.FromFile(path);
                                break;
                        }
                    }
                    break;
                case DataManager.CATEGORY_FASHION:
                    if (path != "")
                        btnCatFashionChangeImg.Image = Image.FromFile(path);
                    break;
            }
        }
        #endregion
    }
}
