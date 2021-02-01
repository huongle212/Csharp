using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapxepIcomparer
{
    class SinhVien
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
        public float DiemTB { get; set; }
        public SinhVien(int Ma,string Ten, float DiemTB)
        {
            this.Ma = Ma;
            this.Ten = Ten;
            this.DiemTB = DiemTB;
        }
        public override string ToString()
        {
            return Ma+"\t"+Ten+"\t"+DiemTB;
        }
    }
}
