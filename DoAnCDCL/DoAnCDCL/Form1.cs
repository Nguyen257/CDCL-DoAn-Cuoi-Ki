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
        StopWordTool NLP;
        public Form1()
        {
            InitializeComponent();
            NLP   = new StopWordTool();
        }

        private void btnTranfer_Click(object sender, EventArgs e)
        {
            string path = @"./Data/0000002";
            if(File.Exists(path))
            {
                string str = File.ReadAllText(path);
                rtbIn.Text = str;

                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NLP = new StopWordTool();
            string output = NLP.RemoveStopwords(rtbIn.Text);
            
            rtbOut.Text = output;

            string str = "";
            foreach ( var v in NLP.found)
            {
                str += "Key : " + v.Key + " - Value : " + v.Value + "\n";
            }
            rtbFound.Text = str;
            txtNumberWord.Text = NLP.iNumberWord.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rtbIn_TextChanged(object sender, EventArgs e)
        {
            /*
            if(!string.IsNullOrEmpty(rtbIn.Text)){
            string output = NLP.RemoveStopwords(rtbIn.Text);
            rtbOut.Text = output;
            }*/
        }

        private void btnTrongSo_Click(object sender, EventArgs e)
        {
            TrongSoWord tSo = new TrongSoWord();
            tSo.danhTrongSo(rtbIn.Text);
            string output = "";
            foreach(var v in tSo.trongSo)
            {
                output += "Key : " + v.Key + " - TF : " + v.Value.ToString() + "\n";
            }
            rtbOut.Text = output;
            string str = "";
            
        }
    }
}
