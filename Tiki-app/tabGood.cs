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
    public partial class tabGood : UserControl
    {
        public SanPham sanPham { get; set; }

        public bool isRemove { get; set; }

        private VIEW.OnChangeListener viewChange;

        private VIEW.OnClickListener viewClick;

        public tabGood()
        {
            InitializeComponent();
        }

        public tabGood(SanPham sanPham)
        {
            InitializeComponent();
            this.sanPham = sanPham;
            showInfoProduct();
        }

        public void setOnChangeListener(VIEW.OnChangeListener viewChange)
        {
            this.viewChange = viewChange;
        }

        public void setOnClickListener(VIEW.OnClickListener viewClick)
        {
            this.viewClick = viewClick;
        }

        private void showInfoProduct()
        {
            lbNameProduct.Text = sanPham.TenSP;
            edtCountProduct.Text = sanPham.Count.ToString();
            edtCountProduct.TextChanged += edtCountProduct_TextChanged;
            imgProduct.Image = sanPham.Image[0];
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            sanPham.Count = Convert.ToInt32(edtCountProduct.Text);
            if (sanPham.Count == 0) return;
            sanPham.Count--;
            edtCountProduct.Text = sanPham.Count.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            sanPham.Count = Convert.ToInt32(edtCountProduct.Text);
            if (sanPham.Count >= 0) sanPham.Count++;
            edtCountProduct.Text = sanPham.Count.ToString();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            sanPham.Count = 0;
            isRemove = true;
            viewClick.onClick(new VIEW
            {
                obj = this,
                Tag = Convert.ToInt32(this.Tag)
            });
        }

        private void btnBuyLater_Click(object sender, EventArgs e)
        {
            viewClick.onClick(new VIEW
            {
                obj = this,
                Tag = Convert.ToInt32(this.Tag)
            });
        }

        private void edtCountProduct_TextChanged(object sender, EventArgs e)
        {
            viewChange.onChange(new VIEW
            {
                obj = edtCountProduct,
                Tag = Convert.ToInt32(edtCountProduct.Tag)
            });
        }

    }
}
