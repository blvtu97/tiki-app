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
    public partial class tabProductSamples : UserControl
    {
        public SanPham sanPham { get; set; }

        private VIEW.OnClickListener view;

        public Bunifu.Framework.UI.BunifuImageButton ImageProduct
        {
            get
            {
                return imgProduct;
            }
            set
            {
                imgProduct = value;
            }
        }

        public tabProductSamples()
        {
            InitializeComponent();
        }

        public tabProductSamples(SanPham sanPham)
        {
            InitializeComponent();
            this.sanPham = sanPham;
            showInfoProduct();  
        }

        private void showInfoProduct()
        {
            lbNameProduct.Text = sanPham.TenSP;
            lbPriceCurrent.Text = "Giá hiện tại: " + sanPham.GiaSP + "đ";
            lbPriceOld.Text = "Giá cũ: " + sanPham.GiaTT + "đ";
            ratingProduct.Value = sanPham.Rate;
            imgProduct.Image = Image.FromFile(sanPham.UrlImage);
        }

        public tabProductSamples Clone()
        {
            tabProductSamples temp = new tabProductSamples()
            {
                sanPham = sanPham
            };

            temp.imgProduct.Image = Image.FromFile(temp.sanPham.UrlImage);
            return temp;
        }

        public void setOnClickListener(VIEW.OnClickListener view)
        {
            this.view = view;
        }

        private void product_Click(object sender, EventArgs e)
        {
            view.onClick(new VIEW
            {
                obj = this,
                Tag = Convert.ToInt32(this.Tag)
            });
        }
    }
}
