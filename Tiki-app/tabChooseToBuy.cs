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
    public partial class tabChooseToBuy : UserControl
    {
        private VIEW.OnClickListener view;

        public String TitleProduct
        {
            get
            {
                return lbTitle.Text;
            }
            set
            {
                lbTitle.Text = value;
            }
        }

        public String TypeProduct1
        {
            get
            {
                return btnContent1.ButtonText;
            }
            set
            {
                btnContent1.ButtonText = value;
            }
        }

        public String TypeProduct2
        {
            get
            {
                return btnContent2.ButtonText;
            }
            set
            {
                btnContent2.ButtonText = value;
            }
        }

        public String TypeProduct3
        {
            get
            {
                return btnContent3.ButtonText;
            }
            set
            {
                btnContent3.ButtonText = value;
            }
        }

        public String CountProduct
        {
            get
            {
                return edtCountProduct.Text;
            }
            set
            {
                edtCountProduct.Text = value;
            }
        }

        public Bunifu.Framework.UI.BunifuFlatButton ButtonBuy
        {
            get
            {
                return btnBuyProduct;
            }
        }

        public tabChooseToBuy()
        {
            InitializeComponent();
        }

        public void setOnClickListener(VIEW.OnClickListener view){
            this.view = view;
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(edtCountProduct.Text);
            if (count >= 0) count++;
            edtCountProduct.Text = count.ToString();

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(edtCountProduct.Text);
            if (count == 0) return;
            count--;
            edtCountProduct.Text = count.ToString();
        }

        private void edtCountProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuyProduct_Click(object sender, EventArgs e)
        {
            view.onClick(new VIEW
            { 
                obj = btnBuyProduct,
                Tag = Convert.ToInt32(btnBuyProduct.Tag)
            });
        }
    }
}
