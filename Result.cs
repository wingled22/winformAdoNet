﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PelayoFirstApp
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }


        public Result(string x) : this()
        {
            lblOutput.Text = x;

        }


        private void Result_Load(object sender, EventArgs e)
        {
;
        }
    }
}
