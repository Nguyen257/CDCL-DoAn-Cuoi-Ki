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
        public VectorWord trongSo { get; set; }
        public Dictionary<string, int> tapTuVung { get; set; }
        int iNumberDoc;
        public List<VectorWord> lDocument { get; set; }
        public int check;
        //public List<string> lKey { get; set; }

        public TrongSoWord()
        {
            trongSo = null;
            tapTuVung = null;
            iNumberDoc = 0;
            lDocument = null;
            check = -1;
        }


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
        public double getidf(string key)
        {
            double kq = 1;
            foreach (var v in tapTuVung)
            {
                if (tapTuVung.ContainsKey(key))
                {
                    kq = Math.Log10((double)iNumberDoc / tapTuVung[key]);
                }
                else
                {
                    kq = 1;
                }
            }
            return kq;
        }
        public void danhDF()
        {
            if (lDocument.Count > 0)
            {
                foreach (var doc in lDocument)
                {
                    foreach (var kv in doc.VectorW)
                    {
                        if (!tapTuVung.ContainsKey(kv.Key))
                        {
                            tapTuVung.Add(kv.Key, 1);
                            //lKey.Add(kv.Key);
                        }
                        else
                        {
                            tapTuVung[kv.Key] += 1;
                        }
                    }
                }
            }

        }
        public double getLengthDoc(VectorWord vec)
        {
            double kq = 0;
            double tong = 0;
            foreach (var v in vec.VectorW)
            {
                if (v.Value != 0)
                {
                    tong += v.Value * v.Value;
                }

            }
            kq = Math.Sqrt(tong);
            return kq;
        }
        public string GetSafeFilename(string filename)
        {

            return string.Join("_", filename.Split(System.IO.Path.GetInvalidFileNameChars()));

        }
        public double getWeight(string word,VectorWord vec)
        {
            double kq = 0;
            if(vec.VectorW.ContainsKey(word))
            {
                kq = vec.VectorW[word];
            }
            return kq;
        }

        public void XuLyVanBan(string input)
        {
            StopWordTool NLP = new StopWordTool();
            trongSo = new VectorWord();
            NLP.RemoveStopwords(input);
            addTrongSo(NLP.found, NLP.iNumberWord);
        }
        public void addTrongSo(Dictionary<string, int> found, int iNumberWord)
        {

            foreach (var v in found)
            {
                if (!trongSo.VectorW.ContainsKey(v.Key))
                {
                    try
                    {
                        trongSo.VectorW.Add(v.Key, tinhTF(found, v.Key, iNumberWord));
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


        
        
        /*public void IndexAllData()
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
            }
        }*/
        public void getAllData()
        {
            iNumberDoc = 0;
            lDocument = new List<VectorWord>();
            tapTuVung = new Dictionary<string, int>();
            string path = @"./Data";
            if (Directory.Exists(path))
            {

                string[] fPath = Directory.GetFiles(path);
                for (int i = 0; i < fPath.Count(); i++)
                {
                    if (File.Exists(fPath[i]))
                    {
                        string Doc = File.ReadAllText(fPath[i]);
                        //Xử lý văn bản và chuyển thành <key,TF> vào biến trongSo
                        XuLyVanBan(Doc);
                        trongSo.stt = i;
                        trongSo.urlDoc = fPath[i];
                        //Lưu vector trongSo vào list vector của tất cả văn bản
                        lDocument.Add(trongSo);
                        //Lưu ý vector lúc này có Value(double) chỉ mới là Tf của word thôi
                        iNumberDoc++;
                    }
                }
                // Đánh lại giá trị Value của vector để lưu thành tf-idf
                danhTrongSo();
                check = 1;
                writeOutput();
                
                

            }

        }

        public void writeOutput()
        {
            Directory.CreateDirectory("Output");
            foreach (var doc in lDocument)
            {
                double LengthDoc = getLengthDoc(doc);
                string strOut = "ID :" + doc.stt.ToString() +", LengthDoc=" + LengthDoc.ToString() + ";\n" + "Documentlink=" + doc.urlDoc + ";\n";
                foreach (var v in doc.VectorW)
                {
                    strOut += "Key=" + v.Key + ", TFIDF=" + v.Value.ToString() + ";\n";
                }
                try
                {

                    string[] temp = doc.urlDoc.Split(new string[] { "Data/", "\\" }, StringSplitOptions.None);
                    string outPath = "./Output/" + GetSafeFilename(temp[1].Trim());
                    System.IO.File.WriteAllText(outPath, strOut);
                }
                catch
                {
                    check = 0;
                }

            }

            string outPathListKey = "./Output/ListKey.txt";
            try
            {
                System.IO.File.WriteAllLines(outPathListKey, tapTuVung.Keys);
            }
            catch
            {
                check = -2;
            }
        }

        public void danhTrongSo()
        {
                //Dựa vào lTrongSo đã được chạy từng biến trong lTrongSo để đánh số lần xuất hiện của word đó trong tập từ vựng(ở đây 
                danhDF();

                //Đánh lại trọng số của mỗi Word trong VectorWord của mỗi Văn bản (lúc này là tf-idf)
                for (int i = 0; i < lDocument.Count;i++)
                {
                    for (int j = 0; j < lDocument[i].VectorW.Count;j++ )
                    {
                        var kv =lDocument[i].VectorW.ElementAt(j);
                        double value = kv.Value * Math.Log10((double)iNumberDoc / tapTuVung[kv.Key]);
                        lDocument[i].VectorW[kv.Key] = value;
                    }
                }
        }

       

        public VectorWord indexQuery(string input)
        {
            //Làm tương tự như data : xử lý ngôn ngữ, vector hóa
            StopWordTool NLP = new StopWordTool();
            NLP.RemoveStopwords(input);
            VectorWord kq = new VectorWord();
            foreach(var v in NLP.found)
            {
                double value = (double)v.Value / NLP.iNumberWord * getidf(v.Key);
                kq.VectorW.Add(v.Key, value);
            }
            return kq;
        }
        //Tính độ tương quan giữa Query và tất cả các văn bản
        public Dictionary<string,double> tinhCosin(string input)
        {
            Dictionary<string,double> kq = new Dictionary<string,double>();
            VectorWord vQuery = new VectorWord();
            vQuery = indexQuery(input);
            List<string> lKey = new List<string>(tapTuVung.Keys);
            foreach (var v in lDocument)
            {
                double tuso = 0;
                double mauso = 0;
                foreach (var k in lKey)
                {
                    //tử số sẽ là tf-idf của mỗi word(trong tập từ vựng) trong Query nhân với tf-idf mỗi word trong v(lúc này là một document)
                    tuso += getWeight(k, vQuery) * getWeight(k, v);
                }
                mauso = getLengthDoc(vQuery) * getLengthDoc(v);
                kq.Add(v.urlDoc, tuso / mauso);
            }

            return kq;
        }
    }
}
