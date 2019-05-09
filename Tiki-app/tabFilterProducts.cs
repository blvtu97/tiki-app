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
    public partial class tabFilterProducts : UserControl
    {
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

        }

        private void ratingStart1_Click(object sender, EventArgs e)
        {

        }

    }
}
