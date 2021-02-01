using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapxepIcomparer
{
    class SortDiem : IComparer
    {
        public int Compare(object x, object y)
        {
            SinhVien sv1 = x as SinhVien;
            SinhVien sv2 = y as SinhVien;
            return sv1.DiemTB.CompareTo(sv2.DiemTB);
        }
    }
}
