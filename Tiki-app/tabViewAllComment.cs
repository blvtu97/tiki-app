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
    public partial class tabViewAllComment : UserControl
    {
        public tabViewOneComment ViewCommentCustomer
        {
            get
            {
                return viewComment1;
            }
            set
            {
                viewComment1 = value;
            }
        }
        public tabViewAllComment()
        {
            InitializeComponent();
        }
    }
}
