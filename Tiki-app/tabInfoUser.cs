using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Common;
using Tiki_app.DTO;
using Tiki_app.GUI;

namespace Tiki_app
{
    public partial class tabInfoUser : UserControl
    {
        public Customer customer { get; set; }

        public PictureBox imageCode { get; set; }

        public string stringCode { get; set; }

        private VIEW.OnClickListener view;

        private bool scanByCamera;

        public tabInfoUser()
        {
            InitializeComponent();
            initUI();
        }

        public void setOnClickListener(VIEW.OnClickListener view)
        {
            this.view = view;
        }
        private void initUI()
        {
            for (int i = 1900; i < 2020; i++)
            {
                cbYear.Items.Add(i.ToString());
            }
        }
        private void btnInfoUser_Click(object sender, EventArgs e)
        {
            pnInfo.BringToFront();
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            pnNotification.BringToFront();
        }

        private void btnManageBill_Click(object sender, EventArgs e)
        {
            pnManageBill.BringToFront();
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            pnAddress.BringToFront();
        }

        private void btnMyComment_Click(object sender, EventArgs e)
        {
            pnMyComment.BringToFront();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            pnQcode.BringToFront();
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
          
        }

        int k = -1;
        public void attachInfoUser(Customer customer)
        {

            this.customer = customer;
            txtName.Text = customer.HoTen;
            txtPhoneNumber.Text = customer.DienThoai;
            txtEmail.Text = customer.DiaChiEmail;
            lbName.Text = customer.HoTen;
            txtOldPassword.Text = customer.MatKhau;

            DateTime date = DateTime.Parse(customer.NgaySinh);
            cbDate.SelectedIndex = findIndex(cbDate, date.Day);
            k = cbDate.SelectedIndex;
            cbMonth.SelectedIndex = findIndex(cbMonth, date.Month);
            cbYear.SelectedIndex = findIndex(cbYear, date.Year);

            if (customer.sex)
            {
                rdMale.Checked = true;
            }
            else
            {
                rdFemale.Checked = true;
            }

            edtName.Text = customer.HoTen;
            edtPhoneNumber.Text = customer.DienThoai;
            edtAddress.Text = customer.DiaChi;
        }

        private void seeOldPassword_Click(object sender, EventArgs e)
        {
            txtOldPassword.isPassword = !txtOldPassword.isPassword;
        }

        private void seeNewPassword1_Click(object sender, EventArgs e)
        {
            txtNewPassword1.isPassword = !txtNewPassword1.isPassword;
        }

        private void seeNewPassword2_Click(object sender, EventArgs e)
        {
            txtNewPassword2.isPassword = !txtNewPassword2.isPassword;
        }

        private void formatDayMonthYear()
        {
            if (cbYear.SelectedIndex < 0) return;
            int y = Convert.ToInt32(cbYear.Items[cbYear.SelectedIndex]);
            int d = 31;
            if (y % 4 == 0 && y % 100 != 0)
            {
                if (cbMonth.Items[cbMonth.SelectedIndex].Equals("2"))
                {
                    d = 29;
                }
            }
            else
            {
                if (cbMonth.SelectedIndex < 0) return;
                int m = Convert.ToInt32(cbMonth.Items[cbMonth.SelectedIndex]);
                if (m == 2)
                {
                    d = 28;
                }
                else if (m == 4 || m == 6 || m == 9 || m == 11)
                {
                    d = 30;
                }
            }

            cbDate.Items.Clear();
            for (int j = 1; j <= d; j++)
            {
                cbDate.Items.Add(j.ToString());
            }
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            formatDayMonthYear();
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            formatDayMonthYear();
        }

        private int findIndex(ComboBox cb, int value)
        {
            for (int i = 0; i  <cb.Items.Count; i++)
            {
                if (Convert.ToInt32(cb.Items[i]) == value)
                {
                    return i;
                }
            }
            return -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string s1 = checkInfoUser();
            if (!s1.Equals(""))
            {
                MessageBox.Show(s1, "Cảnh báo", MessageBoxButtons.OK);
                return;
            }

            if (btnChecked.Checked)
            {
                string s2 = updatePassword();

                if (!s2.Equals(""))
                {
                    MessageBox.Show(s2, "Cảnh báo", MessageBoxButtons.OK);
                    return;
                }
            }
            
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            updateInfo();
            view.onClick(new VIEW
            {
                obj = this,
                Tag = Convert.ToInt32(btnUpdate.Tag)
            });
        }

        private string checkInfoUser()
        {

            if (isValidName(txtName.Text.Trim()))
                return  "Vui lòng nhập họ tên";

            else if (!isValidPhone(txtPhoneNumber.Text.Trim()))
                return "Vui lòng nhập một số điện thoại hợp lệ";

            else if (!isValidEmail(txtEmail.Text.Trim()))
                return "Vui lòng nhập một địa chỉ email hợp lệ";

            return "";
        }

        private string updatePassword()
        {
            if (!isValidPassword(txtNewPassword1.Text.Trim()))
            {
                return "Mật khẩu mới của bạn phải chứa ít nhất một chữ cái viết hoa và " +
                    "một chữ cái viết thường. Chứa ít nhất một chữ số và một kí tự. " +
                    "Tối thiểu 8 kí tự.";
            }
            else if (!txtNewPassword1.Text.Trim().Equals(txtNewPassword2.Text.Trim()))
            {
                return "Vui lòng nhập lại mật khẩu mới";
            }

            return "";
        }

        private bool isValidName(string value)
        {
            return txtName.Text.Trim().Equals("");
        }

        private bool isValidPhone(string value)
        {
            return Regex.IsMatch(value, @"^-*[0-9,\.?\-?\(?\)?\ ]+$");
        }

        private bool isValidEmail(string value)
        {
            return Regex.IsMatch(value, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                + "@"
                + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
        }

        private bool isValidPassword(string value)
        {
            return Regex.IsMatch(value, "(?!^[0-9]*$)(?!^[a-z]*$)(?!^[A-Z]*$)^(.{8,15})$");
        }

        public void showNotification()
        {
            pnNotification.BringToFront();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            view.onClick(new VIEW
            {
                obj = this,
                Tag = Convert.ToInt32(bunifuThinButton21.Tag)
            });
        }

        private void updateInfo()
        {
            customer = new Customer();
            customer.HoTen = txtName.Text.Trim();
            customer.DienThoai = txtPhoneNumber.Text.Trim();
            customer.DiaChiEmail = txtEmail.Text.Trim();
            if (rdMale.Checked) customer.sex = true;
            if (rdFemale.Checked) customer.sex = true;
            customer.NgaySinh =
                cbYear.Items[cbYear.SelectedIndex] + "-" +
                cbMonth.Items[cbMonth.SelectedIndex] + "-" +
                cbDate.Items[k];
            customer.TinhThanhPho = "";
            customer.QuanHuyen = "";
            customer.DiaChi = edtAddress.Text;
            if (btnChecked.Checked)
            {
                customer.MatKhau = txtNewPassword1.Text.Trim();
            }
            else
            {
                customer.MatKhau = txtOldPassword.Text.Trim();
            }
        }

        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            k = cbDate.SelectedIndex;
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            stringCode = txtCodeProduct.Text;
            view.onClick(new VIEW
            {
                obj = this,
                Tag = Convert.ToInt32(btnSearch2.Tag)
            });
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (scanByCamera)
            {
                timeScan.Start();
                if (stringCode != null)
                    DisconnectCamera();
            }
            else
            {
                imageCode = ptbCode;
                view.onClick(new VIEW
                {
                    obj = this,
                    Tag = Convert.ToInt32(btnSearch.Tag)
                });
            }
        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            btnSearch.Tag = 12345701;
            scanByCamera = false;
            DisconnectCamera();

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files(*.png;*.jpg; *.jpeg; *.gif; *.bmp)|*.png;*.jpg; *.jpeg; *.gif; *.bmp";
            openFile.CheckFileExists = true;
            openFile.CheckPathExists = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {

                ptbCode.Image = new Bitmap(openFile.FileName);

                BarcodeReader barcodeReader = new BarcodeReader();
                var result = barcodeReader.Decode((Bitmap)ptbCode.Image);

                if (result == null)
                {
                    MessageBox.Show("Không nhận diện được mã QR Code");
                }
                else
                {
                    stringCode = result.Text;
                }
            }
        }

        private FilterInfoCollection CaptureDevice; //Lấy Camera
        private VideoCaptureDevice FinalFrame;  //Lấy hình ảnh từ camera
        Timer timeScan = new Timer();

        private void btnCamera_Click(object sender, EventArgs e)
        {
            scanByCamera = true;
            ptbCode.Image = null;
            //Mở kết nối đến camera
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            FinalFrame = new VideoCaptureDevice(CaptureDevice[0].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();

            timeScan.Interval = 100;
            timeScan.Tick += tmrScan_Tick;

        }

        //Camera frame
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ptbCode.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void tmrScan_Tick(object sender, EventArgs e)
        {
            //Scan qua camera
            if (FinalFrame != null && FinalFrame.IsRunning == true)
            {
                BarcodeReader Reader = new BarcodeReader();
                //Lấy kêt quả từ camera thông qua picturebox
                Result result = Reader.Decode((Bitmap)ptbCode.Image);
                try
                {
                    string decoded = result.ToString().Trim();
                    timeScan.Stop();
                    stringCode = decoded;
                }
                catch (Exception ex)
                {
                    stringCode = "NULL";
                    timeScan.Stop();
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("Mã QR không đúng");
                }
            }
        }
        private void DisconnectCamera()
        {
            //Ngừng camera 
            if (FinalFrame != null && FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
            timeScan.Stop();
        }
    }
}
