﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace DoAnCDCL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTranfer_Click(object sender, EventArgs e)
        {
            string path = @"./Data/0000002";
            string pathout = @"./Data/out01";
            if(File.Exists(path))
            {
                string str = File.ReadAllText(path);
                rtbIn.Text = str;
                string output = StopWordTool.RemoveStopwords(str);

                rtbOut.Text = output;

            }
        }
    }
}