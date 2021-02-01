using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapxepIcomparer
{
    class SortTen : IComparer
    {
        public int Compare(object x, object y)
        {
            //ép kiểu về đối tượng so sánh
            SinhVien sv1 = x as SinhVien;
            SinhVien sv2 = y as SinhVien;

            if (sv1 == null || sv2 == null)
            {
                throw new NotImplementedException();
            }
            else
            //sắp xếp tăng dần theo Tên
            //return string.Compare(sv1.Ten, sv2.Ten); 
            //sắp xếp giảm dần theo Tên
            {
                if (sv1.Ten.CompareTo(sv2.Ten) == 1) return -1;
                else if (sv1.Ten.CompareTo(sv2.Ten) == -1) return 1;
                else return 0;
            }
        }
    }
}
