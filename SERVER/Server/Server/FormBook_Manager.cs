using Server.BLL;
using Server.BLL.CATEGORY;
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
    public partial class FormBook_Manager : Form
    {
        static public DataManager dataType; // To hand load table
        private List<Control> controls;     // To handle enable
        private DataTable table;            // To handle insert, remove, repair
        private DataTable tableImage;       // Use for table need manager image
        private OnClickListener eventClick; // To hand event click for all button
        private string err;
        private bool isInsert;
        public FormBook_Manager()
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
            Panel[] panelsControl = { pnlProductBook, pnlDetailBook, pnlCategoryBook };
            foreach (var p in panelsControl)
            {
                p.Enabled = false;
                p.SendToBack();
            }

            eventClick = new OnClickListener(dataType);
            switch (dataType)
            {
                case DataManager.CATEGORY_BOOK:
                    controls = new List<Control>() { txbCatBookLoai, btnCatBookChangeImg };
                    btnCatBookSua.Enabled = btnCatBookLuu.Enabled = btnCatBookHuy.Enabled = btnCatBookXoa.Enabled = false;
                    table = new BLCategory_Book().GetData().Tables[0];
                    pnlCategoryBook.Enabled = true;
                    pnlCategoryBook.BringToFront();
                    break;
                case DataManager.DETAILBOOK:
                    controls = new List<Control>() { txbDetBookMaSP, txbDetBookNXB, txbDetBookNgayXB, txbDetCarLoaiBia, txbDetBookSoTrang, txbDetBookDichGia };
                    btnDetBookSua.Enabled = btnDetBookLuu.Enabled = btnDetBookHuy.Enabled = btnDetBookXoa.Enabled = false;
                    table = new BLDetailBook().GetData().Tables[0];
                    pnlDetailBook.Enabled = true;
                    pnlDetailBook.BringToFront();
                    break;
                case DataManager.PRODUCTBOOK:
                    controls = new List<Control>() { txbProBookMaSP, txbProBookTenSP, txbProBookTacGia, cbbProBookLoai, nmrProBookRate,
                                                    txbProBookGiaSP, txbProBookGiaTT, btnProBookThayAnh1, btnProBookThayAnh2, btnProBookThayAnh3, btnProBookThayAnh4 };
                    btnProBookSua.Enabled = btnProBookLuu.Enabled = btnProBookHuy.Enabled = btnProBookXoa.Enabled = false;
                    tableImage = new BLImageBook().GetData().Tables[0];
                    table = new BLProductBook().GetData().Tables[0];
                    pnlProductBook.Enabled = true;
                    pnlProductBook.BringToFront();
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
                case DataManager.PRODUCTBOOK:
                    btnProBookSua.Enabled = btnProBookXoa.Enabled = true;

                    txbProBookMaSP.Text = dgvData.Rows[row].Cells[0].Value.ToString();
                    txbProBookTenSP.Text = dgvData.Rows[row].Cells[1].Value.ToString();
                    txbProBookTacGia.Text = dgvData.Rows[row].Cells[2].Value.ToString();

                    cbbProBookLoai.Text = dgvData.Rows[row].Cells[3].Value.ToString();
                    txbProBookGiaSP.Text = dgvData.Rows[row].Cells[4].Value.ToString();
                    txbProBookGiaTT.Text = dgvData.Rows[row].Cells[5].Value.ToString();
                    nmrProBookRate.Value = (int)dgvData.Rows[row].Cells[6].Value;

                    DataRow rowTableImg = new BLImageBook().FindImageByID(txbProBookMaSP.Text.Trim());
                    MemoryStream mem = new MemoryStream((byte[])rowTableImg[1]);
                    ptbProBookImage1.Image = Image.FromStream(mem);

                    mem = new MemoryStream((byte[])rowTableImg[2]);
                    ptbProBookImage2.Image = Image.FromStream(mem);

                    mem = new MemoryStream((byte[])rowTableImg[3]);
                    ptbProBookImage3.Image = Image.FromStream(mem);

                    mem = new MemoryStream((byte[])rowTableImg[4]);
                    ptbProBookImage4.Image = Image.FromStream(mem);

                    break;
                case DataManager.DETAILBOOK:
                    btnDetBookSua.Enabled = btnDetBookXoa.Enabled = true;

                    txbDetBookMaSP.Text = dgvData.Rows[row].Cells[0].Value.ToString();
                    txbDetBookNXB.Text = dgvData.Rows[row].Cells[1].Value.ToString();
                    txbDetBookNgayXB.Text = dgvData.Rows[row].Cells[2].Value.ToString();
                    txbDetBookSoTrang.Text = dgvData.Rows[row].Cells[3].Value.ToString();
                    
                    txbDetCarLoaiBia.Text = dgvData.Rows[row].Cells[4].Value.ToString();
                    txbDetBookDichGia.Text = dgvData.Rows[row].Cells[5].Value.ToString();

                    break;
                case DataManager.CATEGORY_BOOK:
                    btnCatBookSua.Enabled = btnCatBookXoa.Enabled = true;
                    txbCatBookLoai.Text = dgvData.Rows[row].Cells[0].Value.ToString();

                    //DataRow rowTable = new BLCATEGORY_BOOK().FindImageByID(txbProSmartMaSP.Text.Trim());
                    MemoryStream ms = new MemoryStream((byte[])dgvData.Rows[row].Cells[1].Value);
                    btnCatBookChangeImg.Image = Image.FromStream(ms);
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
                case DataManager.PRODUCTBOOK:
                    btnProBookLuu.Enabled = btnProBookHuy.Enabled = true;
                    btnProBookXoa.Enabled = btnProBookSua.Enabled = btnProBookThem.Enabled = false;
                    break;
                case DataManager.DETAILBOOK:
                    btnDetBookLuu.Enabled = btnDetBookHuy.Enabled = true;
                    btnDetBookXoa.Enabled = btnDetBookSua.Enabled = btnDetBookThem.Enabled = false;
                    break;
                case DataManager.CATEGORY_BOOK:
                    btnCatBookLuu.Enabled = btnCatBookHuy.Enabled = true;
                    btnCatBookXoa.Enabled = btnCatBookSua.Enabled = btnCatBookThem.Enabled = false;
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
                case DataManager.PRODUCTBOOK:
                    txbProBookMaSP.Enabled = false;
                    btnProBookSua.Enabled = btnProBookThem.Enabled = false;
                    btnProBookLuu.Enabled = btnProBookHuy.Enabled = true;
                    break;
                case DataManager.DETAILBOOK:
                    txbDetBookMaSP.Enabled = false;
                    btnDetBookSua.Enabled = btnDetBookThem.Enabled = false;
                    btnDetBookLuu.Enabled = btnDetBookHuy.Enabled = true;
                    break;
                case DataManager.CATEGORY_BOOK:
                    txbCatBookLoai.Enabled = false;
                    btnCatBookSua.Enabled = btnCatBookThem.Enabled = false;
                    btnCatBookLuu.Enabled = btnCatBookHuy.Enabled = true;
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
                case DataManager.PRODUCTBOOK:
                    btnProBookHuy.Enabled = btnProBookLuu.Enabled = false;
                    btnProBookThem.Enabled = true;
                    break;
                case DataManager.DETAILBOOK:
                    btnDetBookHuy.Enabled = btnDetBookLuu.Enabled = false;
                    btnDetBookThem.Enabled = true;
                    break;
                case DataManager.CATEGORY_BOOK:
                    btnCatBookHuy.Enabled = btnCatBookLuu.Enabled = false;
                    btnCatBookThem.Enabled = true;
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
                case DataManager.PRODUCTBOOK:
                    if (isInsert)
                    {
                        if (!eventClick.Insert(txbProBookMaSP.Text.Trim(), txbProBookTenSP.Text, txbProBookTacGia.Text, cbbProBookLoai.Text,
                            txbProBookGiaSP.Text, txbProBookGiaTT.Text, nmrProBookRate.Value.ToString(), txbProBookMaSP.Text, ptbProBookImage1.Image,
                            ptbProBookImage2.Image, ptbProBookImage3.Image, ptbProBookImage4.Image, DateTime.Now.Date, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Thêm Thành Công!!!");
                    }
                    else
                    {
                        if (!eventClick.Update(txbProBookMaSP.Text.Trim(), txbProBookTenSP.Text, txbProBookTacGia.Text, cbbProBookLoai.Text,
                            txbProBookGiaSP.Text, txbProBookGiaTT.Text, nmrProBookRate.Value.ToString(), txbProBookMaSP.Text, ptbProBookImage1.Image,
                            ptbProBookImage2.Image, ptbProBookImage3.Image, ptbProBookImage4.Image, DateTime.Now.Date, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Sửa Thành Công!!!");
                    }
                    ClockControls(true);
                    btnProBookHuy.Enabled = btnProBookLuu.Enabled = false;
                    btnProBookThem.Enabled = true;
                    ClearControlsContent();
                    dgvData.DataSource = eventClick.Reload();
                    break;
                case DataManager.DETAILBOOK:
                    if (isInsert)
                    {
                        if (!eventClick.Insert(txbDetBookMaSP.Text, txbDetBookNXB.Text, txbDetBookSoTrang.Text,
                                            int.Parse(txbDetBookNgayXB.Text), txbDetCarLoaiBia.Text, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Thêm Thành Công!!!");
                    }
                    else
                    {
                        if (!eventClick.Insert(txbDetBookMaSP.Text, txbDetBookNXB.Text, txbDetBookSoTrang.Text,
                                            int.Parse(txbDetBookNgayXB.Text), txbDetCarLoaiBia.Text, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Sửa Thành Công!!!");
                    }
                    ClockControls(true);
                    btnDetBookHuy.Enabled = btnDetBookLuu.Enabled = false;
                    btnDetBookThem.Enabled = true;
                    ClearControlsContent();
                    dgvData.DataSource = eventClick.Reload();
                    break;
                case DataManager.CATEGORY_BOOK:
                    if (isInsert)
                    {
                        if (!eventClick.Insert(txbCatBookLoai.Text, btnCatBookChangeImg.Image, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Thêm Thành Công!!!");
                    }
                    else
                    {
                        if (!eventClick.Update(txbCatBookLoai.Text, btnCatBookChangeImg.Image, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Sửa Thành Công!!!");
                    }
                    ClockControls(true);
                    btnCatBookHuy.Enabled = btnCatBookLuu.Enabled = false;
                    btnCatBookThem.Enabled = true;
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
                case DataManager.PRODUCTBOOK:

                    if (!eventClick.Delete(txbProBookMaSP.Text.Trim(), ref err))
                        MessageBox.Show(err);
                    else
                    {
                        MessageBox.Show("Xóa Thành Công!!!");
                        ClockControls(true);
                        btnProBookXoa.Enabled = btnProBookSua.Enabled = btnProBookHuy.Enabled = btnProBookLuu.Enabled = false;
                        btnProBookThem.Enabled = true;
                        ClearControlsContent();
                        dgvData.DataSource = eventClick.Reload();
                    }

                    break;
                case DataManager.DETAILBOOK:
                    if (!eventClick.Delete(txbDetBookMaSP.Text.Trim(), ref err))
                        MessageBox.Show(err);
                    else
                    {
                        MessageBox.Show("Xóa Thành Công!!!");
                        ClockControls(true);
                        btnDetBookXoa.Enabled = btnDetBookSua.Enabled = btnDetBookHuy.Enabled = btnDetBookLuu.Enabled = false;
                        btnDetBookThem.Enabled = true;
                        ClearControlsContent();
                        dgvData.DataSource = eventClick.Reload();
                    }
                    break;
                case DataManager.CATEGORY_BOOK:
                    if (!eventClick.Delete(txbCatBookLoai.Text, ref err))
                        MessageBox.Show(err);
                    else
                    {
                        MessageBox.Show("Xóa Thành Công!!!");
                        ClockControls(true);
                        btnCatBookXoa.Enabled = btnCatBookSua.Enabled = btnCatBookHuy.Enabled = btnCatBookLuu.Enabled = false;
                        btnCatBookThem.Enabled = true;
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
                case DataManager.PRODUCTBOOK:
                    Bunifu.UI.WinForms.BunifuButton.BunifuButton t = (Bunifu.UI.WinForms.BunifuButton.BunifuButton)sender;

                    if (path != "")
                    {
                        switch (t.Tag.ToString())
                        {
                            case "1":
                                ptbProBookImage1.Image = Image.FromFile(path);
                                break;
                            case "2":
                                ptbProBookImage2.Image = Image.FromFile(path);
                                break;
                            case "3":
                                ptbProBookImage3.Image = Image.FromFile(path);
                                break;
                            case "4":
                                ptbProBookImage4.Image = Image.FromFile(path);
                                break;
                        }
                    }
                    break;
                case DataManager.CATEGORY_BOOK:
                    if (path != "")
                        btnCatBookChangeImg.Image = Image.FromFile(path);
                    break;
            }
        }
        #endregion
    }
}
