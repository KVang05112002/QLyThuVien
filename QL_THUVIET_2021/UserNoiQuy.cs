﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_THUVIET_2021
{
    public partial class UserNoiQuy : UserControl
    {
        public UserNoiQuy()
        {
            InitializeComponent();
        }

        private void UserNoiQuy_Load(object sender, EventArgs e)
        {
            txtnoiquy.ReadOnly = true;
        }
    }
}
