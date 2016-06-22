using System;
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
        TrongSoWord tSo;
        public Form1()
        {
            InitializeComponent();
            NLP   = new StopWordTool();
            tSo = new TrongSoWord();
        }

        private void btnTranfer_Click(object sender, EventArgs e)
        {
            #region OldCode
            /*
            string path = @"./Data";
            if(Directory.Exists(path))
            {
                Directory.CreateDirectory("Output");
                string[] fPath = Directory.GetFiles(path);
                for(int i=0;i<fPath.Count();i++)
                {
                    if(File.Exists(fPath[i]))
                    {
                        string Doc = File.ReadAllText(fPath[i]);
                        string[] temp = fPath[i].Split(new string[] { "Data/","\\" }, StringSplitOptions.None);
                        temp[1].Trim();
                        string outPath ="./Output/"+GetSafeFilename(temp[1].Trim());
                        TrongSoWord tSo = new TrongSoWord();
                        tSo.danhTrongSo(Doc, outPath);
                        iNumberDoc++;
                    }
                }
            }*/
            #endregion
            tSo.getAllData();
            if (tSo.check == 1) MessageBox.Show("Lấy dữ liệu thành công !!!!");
            
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void indexQuery_Click(object sender, EventArgs e)
        {
            Dictionary<string, double> tinhTuongDong = new Dictionary<string, double>();
            if (!string.IsNullOrEmpty(rtbQuery.Text) && !string.IsNullOrWhiteSpace(rtbQuery.Text))
            {
                if (tSo.check == -1) MessageBox.Show("Hãy bấm vào GetData Trước");
                
                if(tSo.check == 1)
                {
                    tinhTuongDong = tSo.tinhCosin(rtbQuery.Text);
                    string output = "";
                    int i =1;
                    var sortedDict = from entry in tinhTuongDong orderby entry.Value descending select entry;
                    foreach (var v in sortedDict)
                    {
                        output += i.ToString() + ">> Văn bản link :" + v.Key + ", Độ tương đồng :" + v.Value.ToString() + ";\n";
                        i++;
                    }
                    rtbKetQua.Text = output;
                }
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@".\Output\"))
                System.Diagnostics.Process.Start(@".\Output\");
            else
                MessageBox.Show("Chưa có output!!!");
        }

        private void btnInputFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@".\Data\"))
                System.Diagnostics.Process.Start(@".\Data\");
            else
                MessageBox.Show("Chưa có Data!!!");
        }

      
    }
}
