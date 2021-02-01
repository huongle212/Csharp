using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapxepIcomparer
{
    class TestIcomparer
    {
        static void Main(string[] args)
        {
            //Sắp xếp trên List các giá trị
            Console.OutputEncoding = Encoding.UTF8;

            ArrayList MangSinhVien = new ArrayList();
            MangSinhVien.Add(new SinhVien(1, "Binh", 8.6f));
            MangSinhVien.Add(new SinhVien(3, "An", 9.2f));
            MangSinhVien.Add(new SinhVien(2, "Nam", 9.9f));

            //ArrayList có thể truy cập qua các chỉ số giống mảng
            Console.WriteLine(MangSinhVien[2]);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Danh sách chưa sắp xếp");
            foreach (SinhVien sv in MangSinhVien)
            {
                Console.WriteLine(sv);
            }
            //ArrayList có thể truy cập qua các chỉ số giống mảng
            
            MangSinhVien.Sort(new SortTen());

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Danh sách sau khi sắp xếp theo TÊN");

            foreach (SinhVien sv in MangSinhVien)
            {
                Console.WriteLine(sv.ToString());
            }
            Console.ReadLine();
        }
    }
}
