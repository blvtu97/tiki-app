﻿using System;
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
    public partial class CategoryTemplate : UserControl
    {
        public string NameCategory
        {
            get
            {
                return lbNameCategory.Text;
            }
            set
            {
                lbNameCategory.Text = value;
            }
        }
        public CategoryTemplate()
        {
            InitializeComponent();
        }
    }
}