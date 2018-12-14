using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_3_oop
{
    class LINQSearch : Searcher
    {
        public List<Student> Search(string pathToXml, Student stud)
        {
            List<Student> result = new List<Student>();
            XDocument doc = XDocument.Load(pathToXml);
            var res = from obj in doc.Descendants("student")
                      where
                      (
                      (obj.Attribute("Name").Value == stud.Name || stud.Name == String.Empty) &&
                      (obj.Attribute("Surname").Value == stud.Surname || stud.Surname == String.Empty) &&
                      (obj.Attribute("Pathers").Value == stud.Pathers || stud.Pathers == String.Empty) &&
                      (obj.Attribute("Faculty").Value == stud.Faculty || stud.Faculty == String.Empty) &&
                      (obj.Attribute("Cathedra").Value == stud.Cathedra || stud.Cathedra == String.Empty) &&
                      (obj.Attribute("Mark").Value == stud.Mark || stud.Mark == String.Empty)
                      )
                      select new
                      {
                          name = (string)obj.Attribute("Name"),
                          surname = (string)obj.Attribute("Surname"),
                          fathers = (string)obj.Attribute("Pathers"),
                          faculty = (string)obj.Attribute("Faculty"),
                          cathedra = (string)obj.Attribute("Cathedra"),
                          mark = (string)obj.Attribute("Mark")
                      };
            foreach (var n in res)
            {
                Student t = new Student();
                t.Name = n.name;
                t.Surname = n.surname;
                t.Faculty = n.faculty;
                t.Pathers = n.fathers;
                t.Cathedra = n.cathedra;
                t.Mark = n.mark;
                result.Add(t);
            }
            return result;
        }
    }
}
