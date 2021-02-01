using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapxepIComparable
{
    class TestIComparable
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Student> LStudent = new List<Student>();
            LStudent.Add(new Student(1, "Binh", 8.6f));
            LStudent.Add(new Student(3, "An", 8.1f));
            LStudent.Add(new Student(2, "Nam", 9.9f));

            Console.WriteLine("Danh sách chưa sắp xếp");
            foreach (Student sv in LStudent)
            {
                Console.WriteLine(sv);
            }
        
            LStudent.Sort();

            Console.WriteLine("Danh sách sau khi sắp xếp theo DIEMTB");

            foreach (Student sv in LStudent)
            {
                Console.WriteLine(sv.ToString());
            }
            Console.ReadLine();
        }
    }
}
