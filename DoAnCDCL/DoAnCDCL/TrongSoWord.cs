using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace DoAnCDCL
{
    public class TrongSoWord
    {
        public Dictionary<string, double> trongSo { get; set; }
        public Dictionary<string, int> soVanBanChua { get; set; }
        int iNumberDoc;
        public List<Dictionary<string, double>> lTrongSo { get; set; }
        public double tinhTF(Dictionary<string, int> found, string key, int iNumberWord)
        {

            if (found.ContainsKey(key))
            {
                double kq = (double)found[key] / iNumberWord;
                return kq;
            }
            else
            {
                return 0;
            }
        }

        public void addTrongSo(Dictionary<string, int> found, int iNumberWord)
        {

            foreach (var v in found)
            {
                if (!trongSo.ContainsKey(v.Key))
                {
                    try
                    {
                        trongSo.Add(v.Key, tinhTF(found, v.Key, iNumberWord));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Loi AddTrongSo");
                    }
                }

                else
                {

                }
            }
        }

        public void danhTF(string input)
        {
            StopWordTool NLP = new StopWordTool();
            trongSo = new Dictionary<string, double>();
            NLP.RemoveStopwords(input);
            addTrongSo(NLP.found, NLP.iNumberWord);
        }
        public string GetSafeFilename(string filename)
        {

            return string.Join("_", filename.Split(System.IO.Path.GetInvalidFileNameChars()));

        }
        public void getAllData()
        {
            iNumberDoc = 0;
            lTrongSo = new List<Dictionary<string, double>>();
            soVanBanChua = new Dictionary<string, int>();
            string path = @"./Data";
            if (Directory.Exists(path))
            {

                string[] fPath = Directory.GetFiles(path);
                for (int i = 0; i < fPath.Count(); i++)
                {
                    if (File.Exists(fPath[i]))
                    {
                        string Doc = File.ReadAllText(fPath[i]);
                        danhTF(Doc);
                        lTrongSo.Add(trongSo);
                        iNumberDoc++;
                    }
                }
                danhTrongSo();
                Directory.CreateDirectory("Output");
                int iPath = 0;
                foreach (var doc in lTrongSo)
                {
                    
                    string strOut = "";
                    foreach (var v in doc)
                    {
                        strOut += "Key : " + v.Key + " - TF : " + v.Value.ToString() + "\n";
                    }
                    try
                    {

                        string[] temp = fPath[iPath].Split(new string[] { "Data/", "\\" }, StringSplitOptions.None);
                        string outPath = "./Output/" + GetSafeFilename(temp[1].Trim());
                        System.IO.File.WriteAllText(outPath, strOut);
                        iPath++;
                    }
                    catch
                    { }
                    
                }
            }

        }

        public void danhDF()
        {
             if (lTrongSo.Count > 0)
            {
                foreach (var doc in lTrongSo)
                {
                    foreach (var kv in doc)
                    {
                        if (!soVanBanChua.ContainsKey(kv.Key))
                        {
                            soVanBanChua.Add(kv.Key, 1);
                        }
                        else
                        {
                            soVanBanChua[kv.Key] += 1;
                        }
                    }
                }
             }

        }
        public void danhTrongSo()
        {
                danhDF();
                for (int i = 0; i < lTrongSo.Count;i++)
                {
                    for (int j = 0; j < lTrongSo[i].Count;j++ )
                    {
                        var kv =lTrongSo[i].ElementAt(j);
                        double value = kv.Value * Math.Log10((double)iNumberDoc / soVanBanChua[kv.Key]);
                        lTrongSo[i][kv.Key] = value;
                    }
                }
            }

        
    }
}
