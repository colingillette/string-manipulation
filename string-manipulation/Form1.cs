﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_manipulation
{
    public partial class Form1 : Form
    {
        private void cleanForm()
        {
            textBox.Clear();
            textBox.Focus();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void largestWordButton_Click(object sender, EventArgs e)
        {
            string str;

            StringAid stringAid = new StringAid(textBox.Text);
            str = stringAid.LongestWord();

            MessageBox.Show(str);
            cleanForm();
        }
    }
}
