using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiki_app
{
    public partial class BuyProduct : UserControl
    {
        public String titleProduct
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

        public String typeProduct1
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

        public String typeProduct2
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

        public String typeProduct3
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

        public String countProduct
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

        public BuyProduct()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(edtCountProduct.Text);
            if (count >= 0) count++;
            edtCountProduct.Text = "  " + count;

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(edtCountProduct.Text);
            if (count == 0) return;
            count--;
            edtCountProduct.Text = "  " + count;
        }

        private void edtCountProduct_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
