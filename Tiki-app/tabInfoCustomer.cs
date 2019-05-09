using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tiki_app.DTO;
using Tiki_app.GUI;

namespace Tiki_app
{
    public partial class tabInfoCustomer : UserControl
    {
        private VIEW.OnClickListener view;

        public Customer KhachHang { get; set; }

        public String NameCustomer
        {
            get
            {
                return edtName.Text;
            }
            set
            {
                edtName.Text = value;
            }
        }

        public String PhoneCustomer
        {
            get
            {
                return edtPhoneNumber.Text;
            }
            set
            {
                edtPhoneNumber.Text = value;
            }
        }

        public String AddressCustomer
        {
            get
            {
                return edtAddress.Text;
            }
            set
            {
                edtAddress.Text = value;
            }
        }
        public String CityCustomer
        {
            get
            {
                return ((String)cbCity.SelectedValue);
            }
        }

        public String DistrictCustomer
        {
            get
            {
                return ((String)cbDistrict.SelectedValue);
            }
        }

        public String WardCustomer
        {
            get
            {
                return ((String)cbWard.SelectedValue);
            }
        }

        public Bunifu.Framework.UI.BunifuThinButton2 ButtonBack
        {
            get
            {
                return btnBack;
            }
        }

        public Bunifu.Framework.UI.BunifuThinButton2 ButtonContinue
        {
            get
            {
                return btnContinue;
            }
        }
        public tabInfoCustomer()
        {
            InitializeComponent();
        }

        public void setOnClickListener(VIEW.OnClickListener view)
        {
            this.view = view;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            addInfoCustomer();
            view.onClick(new VIEW
            {
                obj = btnContinue,
                Tag = Convert.ToInt32(btnContinue.Tag)
            });
        }

        private void addInfoCustomer()
        {
            Customer cus = new Customer();
            cus.HoTen = edtName.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
