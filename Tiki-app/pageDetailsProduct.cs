using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tiki_app.DTO;

namespace Tiki_app
{
    public partial class pageDetailsProduct : UserControl
    {

        public Bunifu.Framework.UI.BunifuCustomDataGrid DatagridInfoProduct
        {
            get
            {
                return dataGridInfoProduct;
            }
            set
            {
                dataGridInfoProduct = value;
            }
        }

        public tabChooseToBuy TabChooseToBuy
        {
            get
            {
                return tabBuyProduct;
            }
        }

        public pageDetailsProduct()
        {
            InitializeComponent();
        }

        private void showImageProduct(Image[] image)
        {
            imgBigProduct.BackgroundImage = image[0];
            btnSmallProduct1.Image = image[0];

            btnSmallProduct2.Image = image[1];

            btnSmallProduct3.Image = image[2];

            btnSmallProduct4.Image = image[3];

        }

        public void attachInfoProduct(SanPham sanPham)
        {
            lbNameProduct.Text = "Điện thoại " + sanPham.TenSP;
            lbProductCode.Text = "Mã sản phẩm: " + sanPham.MaSP;
            lbTradeMarkProduct.Text = "Thương hiệu: " + sanPham.ThuongHieu;
            lbPriceUs.Text = "Giá sản phẩm: " + sanPham.GiaSP + "đ";
            lbPriceMarket.Text = "Giá thị trường: " + sanPham.GiaTT + "đ";
            ratingProduct.Value = sanPham.Rate;
            customerComment.RatingProduct = sanPham.Rate;
            customerComment.ScoreRating = sanPham.Rate + "/5";
            showImageProduct(sanPham.Image);
            tabBuyProduct.Focus();
        }

        private void btnSmallProduct1_Click(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuImageButton imageButton = sender as Bunifu.Framework.UI.BunifuImageButton;
            imgBigProduct.BackgroundImage = imageButton.Image;
        }

    }
}
