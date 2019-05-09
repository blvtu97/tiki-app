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

namespace Tiki_app
{
    public partial class pagePayProduct : UserControl
    {

        public Panel TabProducts
        {
            get
            {
                return ListProduct;
            }
        }

        public tabOrder TabOrder
        {
            get
            {
                return tabOrder;
            }
        }

        public pagePayProduct()
        {
            InitializeComponent();
        }

    }
}
