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
    public partial class pageProducts : UserControl
    {
        private VIEW.OnClickListener view;

        public pageProducts()
        {
            InitializeComponent();
        }

        public void setOnClickListener(VIEW.OnClickListener view)
        {
            this.view = view;
        }

        private void productTemplate1_Click(object sender, EventArgs e)
        {

        }

        public tabNews TabCategory
        {
            get
            {
                return tabCategory;
            }
        }

        public tabNews TabProducts
        {
            get
            {
                return tabProduct;
            }
        }

        public tabNews TabProductsSeen
        {
            get
            {
                return tabProductSeen;
            }
        }

        public Panel TabFilter
        {
            get
            {
                return tabFilter;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            bar.Width = ((Label)sender).Width;
            bar.Left = ((Label)sender).Left;
        }

        private void filter_Click(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            bar.Width = lb.Width;
            bar.Left = lb.Left;
            view.onClick(new VIEW 
            { 
                obj = lb,
                Tag = Convert.ToInt32(lb.Tag)
            });
        }
    }
}
