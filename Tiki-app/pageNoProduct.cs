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
    public partial class pageNoProduct : UserControl
    {
        private VIEW.OnClickListener view;

        public Bunifu.Framework.UI.BunifuThinButton2 ButtonContinue
        {
            get
            {
                return btnContinue;
            }
        }

        public pageNoProduct()
        {
            InitializeComponent();
        }

        public void setOnClickListener(VIEW.OnClickListener view)
        {
            this.view = view;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            view.onClick(new VIEW
            {
                obj = btnContinue,
                Tag = Convert.ToInt32(btnContinue.Tag)
            });
        }
    }
}
