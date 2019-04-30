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
    public partial class WriteComment : UserControl
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

        public String TitleComment
        {
            get
            {
                return edtTitleComment.Text;
            }
            set
            {
                edtTitleComment.Text = value;
            }
        }

        public String CustomerCommentText
        {
            get
            {
                return edtCommentProduct.Text;
            }
            set
            {
                edtCommentProduct.Text = value;
            }
        }

        public WriteComment()
        {
            InitializeComponent();
        }
    }
}
