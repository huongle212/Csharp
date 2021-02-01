using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapxepIcomparer
{
    class SortMa : IComparer
    {
        public int Compare(object x, object y)
        {
            //ép kiểu về lớp cần so sánh
            //SinhVien sv1 = (SinhVien) x;
            SinhVien sv1 = x as SinhVien;
            SinhVien sv2 = (SinhVien) y;
            return sv1.Ma.CompareTo(sv2.Ma);
            
            //sắp xếp giảm dần
            //if (sv1 == null || sv2 == null)
            //{ throw new InvalidOperationException(); }
            //else
            //{
            //    if (sv1.Ma > sv2.Ma) return -1;
            //    else if (sv1.Ma == sv2.Ma) return 0;
            //    else return 1;
            //}
        }
    }
}
