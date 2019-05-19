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
using Tiki_app.DTO;

namespace Tiki_app
{
    public partial class tabFilterProducts : UserControl
    {
        public FilterProduct filterProduct = new FilterProduct();

        private VIEW.OnClickListener view;

        public tabFilterProducts()
        {
            InitializeComponent();
            
        }

        public void setOnClickListener(VIEW.OnClickListener view)
        {
            this.view = view;
        }

        private void findPrice_Click(object sender, EventArgs e)
        {
            filterProduct.price1 = Convert.ToDouble(txtRangeFrom.Text.Trim());
            filterProduct.price2 = Convert.ToDouble(txtRangeTo.Text.Trim());
            view.onClick(new VIEW
            {
                obj = this,
                Tag = Convert.ToInt32(btnFindPrice.Tag)
            });
        }

        private void ratingStart1_Click(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuRating rating =
                sender as Bunifu.Framework.UI.BunifuRating;
            filterProduct.rate = rating.Value;
            view.onClick(new VIEW
            {
                obj = this,
                Tag = Convert.ToInt32(rating.Tag)
            });

        }

    }
}
