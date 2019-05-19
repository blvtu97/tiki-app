using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tiki_app.GUI;

namespace Tiki_app
{
    public partial class tabThankyou : UserControl
    {
        private VIEW.OnClickListener view;

        public String ProductCode
        {
            set
            {
                lbProductCode.Text = value;
            }
        }

        public String MailCustomer
        {
            set
            {
                lbMailCustomer.Text = value;
            }
        }
        public tabThankyou()
        {
            InitializeComponent();
        }

        public Bunifu.Framework.UI.BunifuThinButton2 ButtonBack
        {
            get
            {
                return btnBack;
            }
        }

        public Bunifu.Framework.UI.BunifuThinButton2 ButtonHomePage
        {
            get
            {
                return btnHomePage;
            }
        }

        public void setOnClickListener(VIEW.OnClickListener view)
        {
            this.view = view;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            view.onClick(new VIEW
            {
                obj = this,
                Tag = Convert.ToInt32(btnHomePage.Tag)
            });
        }
    }
}
