using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_oop
{
    public interface Searcher
    {
        List<Student> Search(string pathToXml, Student stud);
    }
}
