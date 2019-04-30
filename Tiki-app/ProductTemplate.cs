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
    public partial class ProductTemplate : UserControl
    {

        public string nameProduct
        {
            get
            {
                return lbNameProduct.Text;
            }
            set
            {
                lbNameProduct.Text = value;
            }
        }

        public string priceCurrent
        {
            get
            {
                return lbPriceCurrent.Text;
            }
            set
            {
                lbPriceCurrent.Text = value;
            }
        }

        public string priceOld
        {
            get
            {
                return lbPriceOld.Text;
            }
            set
            {
                lbPriceOld.Text = value;
            }
        }

        public int ratingInfoProduct
        {
            get
            {
                return ratingProduct.Value;
            }
            set
            {
                ratingProduct.Value = value;
            }
        }

        public ProductTemplate()
        {
            InitializeComponent();
        }
    }
}
