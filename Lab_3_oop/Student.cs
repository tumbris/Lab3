using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_oop
{
    public class Student
    {

        public Student()
        {
            Name = String.Empty;
            Surname = String.Empty;
            Pathers = String.Empty;
            Faculty = String.Empty;
            Cathedra = String.Empty;
            Mark = String.Empty;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pathers { get; set; }
        public string Faculty { get; set; }
        public string Cathedra { get; set; }
        public string Mark { get; set; }
    }
}
