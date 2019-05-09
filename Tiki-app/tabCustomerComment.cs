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
    public partial class tabCustomerComment : UserControl
    {
        public String ScoreRating
        {
            set
            {
                lbScoreRating.Text = value;
            }
        }

        public int RatingProduct
        {
            set
            {
                ratingProduct.Value = value;
            }
        }

        public String CountComment
        {
            set
            {
                lbCountComment.Text = value;
            }
        }

        public int ProgressStart5
        {
            set
            {
                pgrStar5.Value = value;
            }
        }

        public String PercentStart5
        {
            set
            {
                lbPercent5.Text = value;
            }
        }

        public int ProgressStart4
        {
            set
            {
                pgrStar4.Value = value;
            }
        }

        public String PercentStart4
        {
            set
            {
                lbPercent4.Text = value;
            }
        }

        public int ProgressStart3
        {
            set
            {
                pgrStar3.Value = value;
            }
        }

        public String PercentStart3
        {
            set
            {
                lbPercent3.Text = value;
            }
        }

        public int ProgressStart2
        {
            set
            {
                pgrStar2.Value = value;
            }
        }

        public String PercentStart2
        {
            set
            {
                lbPercent2.Text = value;
            }
        }

        public int ProgressStart1
        {
            set
            {
                pgrStar1.Value = value;
            }
        }

        public String PercentStart1
        {
            set
            {
                lbPercent1.Text = value;
            }
        }

        public tabCustomerComment()
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
