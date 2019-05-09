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

        private void showImageProduct(string urlImage)
        {
            string url;
            if (File.Exists(urlImage))
            {
                imgBigProduct.BackgroundImage = Image.FromFile(urlImage);
                btnSmallProduct1.Image = Image.FromFile(urlImage);
            }
            url = urlImage.Replace(".", "B.");
            if (File.Exists(url))
                btnSmallProduct2.Image = Image.FromFile(url);
            else
                btnSmallProduct2.Image = null;
            url = urlImage.Replace(".", "C.");
            if (File.Exists(url))
                btnSmallProduct3.Image = Image.FromFile(url);
            else
                btnSmallProduct3.Image = null;
            url = urlImage.Replace(".", "D.");
            if (File.Exists(url))
                btnSmallProduct4.Image = Image.FromFile(url);
            else
                btnSmallProduct4.Image = null;
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
            showImageProduct(sanPham.UrlImage);
            tabBuyProduct.Focus();
        }

        private void btnSmallProduct1_Click(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuImageButton imageButton = sender as Bunifu.Framework.UI.BunifuImageButton;
            imgBigProduct.BackgroundImage = imageButton.Image;
        }

    }
}
