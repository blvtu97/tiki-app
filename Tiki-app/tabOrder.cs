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
    public partial class tabOrder : UserControl
    {
        private VIEW.OnClickListener view;

        public String PriceTemporary
        {
            get
            {
                return lbMoney1.Text;
            }
            set
            {
                lbMoney1.Text = value;
            }
        }

        public String PriceReal
        {
            get
            {
                return lbMoney2.Text;
            }
            set
            {
                lbMoney2.Text = value;
            }
        }

        public Bunifu.Framework.UI.BunifuThinButton2 ButtonOrder
        {
            get
            {
                return btnOrder;
            }
        }

        public void setOnClickListener(VIEW.OnClickListener view)
        {
            this.view = view;
        }

        public tabOrder()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            view.onClick(new VIEW
            {
                obj = this,
                Tag = Convert.ToInt32(this.Tag)
            });
        }
    }
}
