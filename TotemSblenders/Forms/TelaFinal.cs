﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
namespace TelaSblenders
{
    public partial class TelaFinal : MaterialForm
    {
        public TelaFinal(string id)
        {
            InitializeComponent();
            materialLabel2.Text = id;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
