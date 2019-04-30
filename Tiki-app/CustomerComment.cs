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
    public partial class CustomerComment : UserControl
    {
        public CustomerComment()
        {
            InitializeComponent();
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            if (btnComment.Tag.Equals("open"))
            {
                btnComment.ButtonText = "Đóng";
                btnComment.Tag = "close";
                writeComment1.BringToFront();
            }
            else
            {
                btnComment.ButtonText = "Viết nhận xét của bạn";
                btnComment.Tag = "open";
                viewAllComment1.BringToFront();
            }
        }
    }
}
