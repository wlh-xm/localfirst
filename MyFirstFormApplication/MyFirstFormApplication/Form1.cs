﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gobutton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(new Uri(comboBox1.SelectedItem.ToString()));
        }

        private void 主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome(); 
        }

        private void 前进ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward(); 
        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            webBrowser1.GoHome(); 
        }
    }
}
