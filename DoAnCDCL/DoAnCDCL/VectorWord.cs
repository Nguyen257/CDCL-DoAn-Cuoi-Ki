using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCDCL
{
    public class VectorWord
    {
        public int stt { get; set; }
        public string urlDoc { get; set; }
        public Dictionary<string, double> VectorW { get; set; }

        public VectorWord()
        {
            stt = 0 ;
            urlDoc = "";
            VectorW = new Dictionary<string, double>();
        }
    }
}
