using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCDCL
{
    public class TrongSoWord
    {
        public Dictionary<string, double> trongSo { get; set; }

        public double tinhTF (Dictionary<string,int> found,string key,int iNumberWord)
        {

            if(found.ContainsKey(key))
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
            
            foreach(var v in found)
            {
                if(!trongSo.ContainsKey(v.Key))
                {
                    try{
                        trongSo.Add(v.Key, tinhTF(found, v.Key, iNumberWord));
                    }
                    catch(Exception ex)
                    {
                        throw ex;
                    }
                }
                
                else
                {
                   
                }
            }
        }

        public void danhTrongSo(string input)
        {
            StopWordTool NLP = new StopWordTool();
            trongSo = new Dictionary<string, double>();
            NLP.RemoveStopwords(input);
            addTrongSo(NLP.found, NLP.iNumberWord);

        }
    }
}
