﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWFAmenus
{
    public partial class frmTela1 : Form
    {
        public frmTela1()
        {
            InitializeComponent();
        }

        private void ComeBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
