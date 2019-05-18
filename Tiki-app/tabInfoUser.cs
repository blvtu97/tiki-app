using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiki_app
{
    public partial class tabInfoUser : UserControl
    {
        public tabInfoUser()
        {
            InitializeComponent();
        }

        private void btnInfoUser_Click(object sender, EventArgs e)
        {
            pnInfo.BringToFront();
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            pnNotification.BringToFront();
        }

        private void btnManageBill_Click(object sender, EventArgs e)
        {
            pnManageBill.BringToFront();
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            pnAddress.BringToFront();
        }

        private void btnMyComment_Click(object sender, EventArgs e)
        {
            pnMyComment.BringToFront();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            pnQcode.BringToFront();
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
          
        }
    }
}
