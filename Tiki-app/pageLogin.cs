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
    public partial class pageLogin : UserControl
    {
        private VIEW.OnClickListener view;

        public pageLogin()
        {
            InitializeComponent();
        }

        public void setOnClickListener(VIEW.OnClickListener view)
        {
            this.view = view;
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            view.onClick(new VIEW
            {
                obj = this,
                Tag = Convert.ToInt32(lbRegister.Tag)
            });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            view.onClick(new VIEW
            {
                obj = this,
                Tag = Convert.ToInt32(btnLogin.Tag)
            });
        }
    }
}
