using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_oop
{
    public class Search
    {
        public static List<Student> GetResult(string path, Student stud, Searcher alg)
        {
            return alg.Search(path, stud);
        }
    }
}
