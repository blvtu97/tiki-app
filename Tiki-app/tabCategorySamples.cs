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
    public partial class tabCategorySamples : UserControl
    {
        public DanhMucSanPham danhMuc { get; set; }

        private VIEW.OnClickListener view;

        public tabCategorySamples()
        {
            InitializeComponent();
        }

        public tabCategorySamples(DanhMucSanPham danhMuc)
        {
            InitializeComponent();
            this.danhMuc = danhMuc;
            showInfoCategory();  
        }

        public void setOnClickListener(VIEW.OnClickListener view)
        {
            this.view = view;
        }
        private void showInfoCategory()
        {
            this.BackgroundImage = danhMuc.Image;
        }

        private void tabCategorySamples_Click(object sender, EventArgs e)
        {
            view.onClick(new VIEW
            {
                obj = this,
                Tag = Convert.ToInt32(this.Tag)
            });
        }
    }
}
