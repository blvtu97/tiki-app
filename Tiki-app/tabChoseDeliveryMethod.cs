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
    public partial class tabChoseDeliveryMethod : UserControl
    {
        private VIEW.OnClickListener view;

        public Bunifu.Framework.UI.BunifuThinButton2 ButtonBack
        {
            get
            {
                return btnBack;
            }
        }

        public Bunifu.Framework.UI.BunifuThinButton2 ButtonBuyProduct
        {
            get
            {
                return btnBuyProduct;
            }
        }

        public tabChoseDeliveryMethod()
        {
            InitializeComponent();
        }

        public void setOnClickListener(VIEW.OnClickListener view)
        {
            this.view = view;
        }

        private void btnBuyProduct_Click(object sender, EventArgs e)
        {
            view.onClick(new VIEW
            {
                obj = btnBuyProduct,
                Tag = Convert.ToInt32(btnBuyProduct.Tag)
            });
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
