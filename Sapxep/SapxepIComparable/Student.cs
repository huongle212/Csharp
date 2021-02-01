using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapxepIComparable
{
    class Student : IComparable<Student>
    {
        public int Ma { get; set; }
        public string Ten { get; set; }
        public float DiemTB { get; set; }
        //public int CompareTo(Student other)
        //{
        //    if (DiemTB > other.DiemTB) return -1;
        //    else if (DiemTB == other.DiemTB) return 0;
        //    else return 1;
        //}
        public int CompareTo(Student other)
        {
            if (other == null)
                throw new NotImplementedException();
            else
                return DiemTB.CompareTo(other.DiemTB);
        }
        public Student (int Ma, string Ten, float DiemTB)
        {
            this.Ma = Ma;
            this.Ten = Ten;
            this.DiemTB = DiemTB;
        }
        public override string ToString()
        {
            return Ma + "\t" + Ten + "\t" + DiemTB;
        }

   
    }
}
