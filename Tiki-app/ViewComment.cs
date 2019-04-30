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
    public partial class ViewComment : UserControl
    {

        public int RatingProduct
        {
            get
            {
                return ratingProduct.Value;
            }
            set
            {
                ratingProduct.Value = value;
            }
        }

        public String ReactionProduct
        {
            get
            {
                return lbReactionProduct.Text;
            }
            set
            {
                lbReactionProduct.Text = value;
            }
        }

        public String IsBuyProduct
        {
            get
            {
                return lbIsBuyProduct.Text;
            }
            set
            {
                lbIsBuyProduct.Text = value;
            }
        }

        public String CommentProduct
        {
            get
            {
                return lbCommentProduct.Text;
            }
            set
            {
                lbCommentProduct.Text = value;
            }
        }

        public String NameCustomer
        {
            get
            {
                return lbNameCustomer.Text;
            }
            set
            {
                lbNameCustomer.Text = value;
            }
        }

        public String DayCommentProduct
        {
            get
            {
                return lbDayCommentProduct.Text;
            }
            set
            {
                lbDayCommentProduct.Text = value;
            }
        }

        public Image ImageCustomer
        {
            get
            {
                return imgCustomer.Image;
            }
            set
            {
                imgCustomer.Image = value;
            }
        }

        public ViewComment()
        {
            InitializeComponent();
        }
    }
}
