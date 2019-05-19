using Server.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server.BLL.CUSTOMER;
namespace Server
{
    public partial class FormUser_Manager : Form
    {
        static public DataManager dataType; // To hand load table
        private List<Control> controls;     // To handle enable
        private DataTable table;            // To handle insert, remove, repair
        private OnClickListener eventClick; // To hand event click for all button
        private string err;
        private bool isInsert;
        public FormUser_Manager()
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
            Panel[] panelsControl = { pnlCustomer, pnlComment, pnlDetailBill };
            foreach (var p in panelsControl)
            {
                p.Enabled = false;
                p.SendToBack();
            }

            eventClick = new OnClickListener(dataType);
            switch (dataType)
            {
                case DataManager.COMMENT:
                    controls = new List<Control>() { txbComMaSP, txbComHoTen, dtpComNgayComment, txbComNoiDung, nmrRate };
                    btnComSua.Enabled = btnComLuu.Enabled = btnComHuy.Enabled = btnComXoa.Enabled = false;
                    table = new BLComment().GetData().Tables[0];
                    pnlComment.Enabled = true;
                    pnlComment.BringToFront();
                    break;
                case DataManager.DETAILBILL:
                    controls = new List<Control>() { txbDetMaSP, txbDetKhachHang, txbDetSoLuong, dtpDetNgayMua }; ;
                    btnDetSua.Enabled = btnDetLuu.Enabled = btnDetHuy.Enabled = btnDetXoa.Enabled = false;
                    table = new BLDetailBill().GetData().Tables[0];
                    pnlDetailBill.Enabled = true;
                    pnlDetailBill.BringToFront();
                    break;
                case DataManager.CUSTOMER:
                    controls = new List<Control>() { txbCusHoTen, txbCusSoDT, txbCusEmail, txbCusPassword, dtpCusNgaySinh, ckbCusNam,
                                                     txbCusTinhThanh, txbCusQuanHuyen, txbCusDiaChi };
                    btnCusSua.Enabled = btnCusLuu.Enabled = btnCusHuy.Enabled = btnCusXoa.Enabled = false;
                    table = new BLCustomer().GetData().Tables[0];
                    pnlCustomer.Enabled = true;
                    pnlCustomer.BringToFront();
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
                case DataManager.CUSTOMER:
                    btnCusSua.Enabled = btnCusXoa.Enabled = true;

                    txbCusHoTen.Text = dgvData.Rows[row].Cells[0].Value.ToString();
                    txbCusSoDT.Text = dgvData.Rows[row].Cells[1].Value.ToString();
                    txbCusEmail.Text = dgvData.Rows[row].Cells[2].Value.ToString();

                    txbCusPassword.Text = dgvData.Rows[row].Cells[3].Value.ToString();
                    ckbCusNam.Checked = (bool)dgvData.Rows[row].Cells[4].Value;
                    dtpCusNgaySinh.Text = dgvData.Rows[row].Cells[5].Value.ToString();
                    txbCusTinhThanh.Text = dgvData.Rows[row].Cells[6].Value.ToString();
                    txbCusQuanHuyen.Text = dgvData.Rows[row].Cells[7].Value.ToString();
                    txbCusDiaChi.Text = dgvData.Rows[row].Cells[8].Value.ToString();

                    break;
                case DataManager.DETAILBILL:
                    btnDetSua.Enabled = btnDetXoa.Enabled = true;

                    txbDetMaSP.Text = dgvData.Rows[row].Cells[0].Value.ToString();
                    txbDetKhachHang.Text = dgvData.Rows[row].Cells[1].Value.ToString();
                    dtpDetNgayMua.Text = dgvData.Rows[row].Cells[2].Value.ToString();
                    txbDetSoLuong.Text = dgvData.Rows[row].Cells[3].Value.ToString();
                    break;
                case DataManager.COMMENT:
                    btnComSua.Enabled = btnComXoa.Enabled = true;

                    txbComMaSP.Text = dgvData.Rows[row].Cells[0].Value.ToString();
                    txbComHoTen.Text = dgvData.Rows[row].Cells[1].Value.ToString();
                    dtpComNgayComment.Text = dgvData.Rows[row].Cells[2].Value.ToString();
                    txbComNoiDung.Text = dgvData.Rows[row].Cells[3].Value.ToString();
                    nmrRate.Text = dgvData.Rows[row].Cells[4].Value.ToString();
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
                case DataManager.CUSTOMER:
                    btnCusLuu.Enabled = btnCusHuy.Enabled = true;
                    btnCusXoa.Enabled = btnCusSua.Enabled = btnCusThem.Enabled = false;
                    break;
                case DataManager.DETAILBILL:
                    btnDetLuu.Enabled = btnDetHuy.Enabled = true;
                    btnDetXoa.Enabled = btnDetSua.Enabled = btnDetThem.Enabled = false;
                    break;
                case DataManager.COMMENT:
                    btnComLuu.Enabled = btnComHuy.Enabled = true;
                    btnComXoa.Enabled = btnComSua.Enabled = btnComThem.Enabled = false;
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
                case DataManager.CUSTOMER:
                    txbCusEmail.Enabled = false;
                    btnCusSua.Enabled = btnCusThem.Enabled = false;
                    btnCusLuu.Enabled = btnCusHuy.Enabled = true;
                    break;
                case DataManager.DETAILBILL:
                    txbDetMaSP.Enabled = false;
                    btnDetSua.Enabled = btnDetThem.Enabled = false;
                    btnDetLuu.Enabled = btnDetHuy.Enabled = true;
                    break;
                case DataManager.COMMENT:
                    txbComMaSP.Enabled = false;
                    btnComSua.Enabled = btnComThem.Enabled = false;
                    btnComLuu.Enabled = btnComHuy.Enabled = true;
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
                    btnCusHuy.Enabled = btnCusLuu.Enabled = false;
                    btnCusThem.Enabled = true;
                    break;
                case DataManager.DETAILBILL:
                    btnDetHuy.Enabled = btnDetLuu.Enabled = false;
                    btnDetThem.Enabled = true;
                    break;
                case DataManager.COMMENT:
                    btnComHuy.Enabled = btnComLuu.Enabled = false;
                    btnComThem.Enabled = true;
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
                case DataManager.CUSTOMER:
                    if (isInsert)
                    {
                        if (!eventClick.Insert(txbCusHoTen.Text, txbCusSoDT.Text, txbCusEmail.Text, txbCusPassword.Text, ckbCusNam.Checked,
                                            dtpCusNgaySinh.Value, txbCusTinhThanh.Text, txbCusQuanHuyen.Text, txbCusDiaChi.Text, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Thêm Thành Công!!!");
                    }
                    else
                    {
                        if (!eventClick.Update(txbCusHoTen.Text, txbCusSoDT.Text, txbCusEmail.Text, txbCusPassword.Text, ckbCusNam.Checked,
                                             dtpCusNgaySinh.Value, txbCusTinhThanh.Text, txbCusQuanHuyen.Text, txbCusDiaChi.Text, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Sửa Thành Công!!!");
                    }
                    ClockControls(true);
                    btnCusHuy.Enabled = btnCusLuu.Enabled = false;
                    btnCusThem.Enabled = true;
                    ClearControlsContent();
                    dgvData.DataSource = eventClick.Reload();
                    break;
                case DataManager.DETAILBILL:
                    if (isInsert)
                    {
                        if (!eventClick.Insert(txbDetMaSP.Text, txbDetKhachHang.Text, dtpDetNgayMua.Value, txbDetSoLuong.Text, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Thêm Thành Công!!!");
                    }
                    else
                    {
                        if (!eventClick.Update(txbDetMaSP.Text, txbDetKhachHang.Text, txbDetSoLuong.Text, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Sửa Thành Công!!!");
                    }
                    ClockControls(true);
                    btnDetHuy.Enabled = btnDetLuu.Enabled = false;
                    btnDetThem.Enabled = true;
                    ClearControlsContent();
                    dgvData.DataSource = eventClick.Reload();
                    break;
                case DataManager.COMMENT:
                    if (isInsert)
                    {
                        if (!eventClick.Insert(txbComMaSP.Text, txbComHoTen.Text, dtpComNgayComment.Value, txbComNoiDung.Text, (int)nmrRate.Value, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Thêm Thành Công!!!");
                    }
                    else
                    {
                        if (!eventClick.Update(txbComMaSP.Text, txbComHoTen.Text, dtpComNgayComment.Value, txbComNoiDung.Text, (int)nmrRate.Value, ref err))
                        {
                            MessageBox.Show(err);
                            return;
                        }
                        else
                            MessageBox.Show("Sửa Thành Công!!!");
                    }
                    ClockControls(true);
                    btnComHuy.Enabled = btnComLuu.Enabled = false;
                    btnComThem.Enabled = true;
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
                case DataManager.CUSTOMER:

                    if (!eventClick.Delete(txbCusEmail.Text.Trim(), ref err))
                        MessageBox.Show(err);
                    else
                    {
                        MessageBox.Show("Xóa Thành Công!!!");
                        ClockControls(true);
                        btnCusXoa.Enabled = btnCusSua.Enabled = btnCusHuy.Enabled = btnCusLuu.Enabled = false;
                        btnCusThem.Enabled = true;
                        ClearControlsContent();
                        dgvData.DataSource = eventClick.Reload();
                    }

                    break;
                case DataManager.DETAILBILL:
                    if (!eventClick.Delete(txbDetMaSP.Text, txbDetKhachHang.Text, ref err))
                        MessageBox.Show(err);
                    else
                    {
                        MessageBox.Show("Xóa Thành Công!!!");
                        ClockControls(true);
                        btnDetXoa.Enabled = btnDetSua.Enabled = btnDetHuy.Enabled = btnDetLuu.Enabled = false;
                        btnDetThem.Enabled = true;
                        ClearControlsContent();
                        dgvData.DataSource = eventClick.Reload();
                    }
                    break;
                case DataManager.COMMENT:
                    if (!eventClick.Delete(txbComMaSP.Text, txbComHoTen.Text, ref err))
                        MessageBox.Show(err);
                    else
                    {
                        MessageBox.Show("Xóa Thành Công!!!");
                        ClockControls(true);
                        btnComXoa.Enabled = btnComSua.Enabled = btnComHuy.Enabled = btnComLuu.Enabled = false;
                        btnComThem.Enabled = true;
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportView view = new ReportView();
            ReportView.dataType = dataType;
            this.Hide();
            view.ShowDialog();
            this.Show();
        }
        #endregion

    }
}
