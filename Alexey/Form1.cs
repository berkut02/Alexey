﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alexey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alexeyDataSet.alexey' table. You can move, or remove it, as needed.
            this.alexeyTableAdapter.Fill(this.alexeyDataSet.alexey);

        }

        private void alexeyBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
