using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using Tiki_app.DTO;

namespace Tiki_app
{
    public partial class frmRegister : Form
    {
        private RegisterCustomer register;

        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cbConfirm.Checked)
            {
                string s = checkInfoUser();
                if (s.Equals(""))
                {
                    register.onRegister(getCustomer());
                    this.Close();
                }
                else
                {
                    MessageBox.Show(s,
                  "Thông báo",
                  MessageBoxButtons.OKCancel,
                  MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chấp nhận điều khoản",
                    "Thông báo",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
            }
        }

        private string checkInfoUser()
        {
            string s = "";

            if (isValidName(txtName.Text.Trim()))
                s = "Vui lòng nhập họ tên";

            if (!isValidPhone(txtPhoneNumber.Text.Trim()))
                s = "Vui lòng nhập một số điện thoại hợp lệ";

            if (!isValidEmail(txtEmail.Text.Trim()))
                s = "Vui lòng nhập một địa chỉ email hợp lệ";

            if (!isValidPassword(txtPassword.Text))
            {
                s = "Mật khẩu của bạn phải chứa ít nhất một chữ cái viết hoa và " +
                    "một chữ cái viết thường. Chứa ít nhất một chữ số và một kí tự. " +
                    "Tối thiểu 8 kí tự.";
            }

            return s;
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

        private void frmRegister_Load(object sender, EventArgs e)
        {
            for (int i = 1900; i < 2020; i++)
            {
                cbYear.Items.Add(i.ToString());
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


        private void lbPassword_Click(object sender, EventArgs e)
        {
            lbPassword.Visible = false;
            txtPassword.Focus();
        }


        private void lbPhone_Click(object sender, EventArgs e)
        {
            lbPhone.Visible = false;
            txtPhoneNumber.Focus();
        }

        private void lbEmail_Click(object sender, EventArgs e)
        {
            lbEmail.Visible = false;
            txtEmail.Focus();
        }

        private void lbName_Click(object sender, EventArgs e)
        {
            lbName.Visible = false;
            txtName.Focus();
        }

        public interface RegisterCustomer
        {
            void onRegister(Customer customer);
        }


        public void setOnClickListener(RegisterCustomer register)
        {
            this.register = register;
        }

        private Customer getCustomer()
        {
            Customer cus = new Customer();
            cus.HoTen = txtName.Text.Trim();
            cus.DienThoai = txtPhoneNumber.Text.Trim();
            cus.DiaChiEmail = txtEmail.Text.Trim();
            cus.MatKhau = txtPassword.Text.Trim();
            if (rdMale.Checked) cus.sex = true;
            if (rdFemale.Checked) cus.sex = true;
            cus.NgaySinh = cbYear.Items[cbYear.SelectedIndex] + "-" +
                cbMonth.Items[cbMonth.SelectedIndex] + "-" +
                cbDate.Items[cbDate.SelectedIndex];
            return cus;
        }

        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
