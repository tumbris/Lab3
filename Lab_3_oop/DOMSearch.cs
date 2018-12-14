using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab_3_oop
{
    class DOMSearch : Searcher
    {
        public List<Student> Search(string pathToXml, Student stud)
        {
            var result = new List<Student>();

            XmlDocument doc = new XmlDocument();
            doc.Load(pathToXml);
            XmlNode node = doc.DocumentElement;
            foreach (XmlNode nod in node.ChildNodes)
            {
                string name = "", surname = "", pathers = "", faculty = "", cathedra = "", mark = "";
                foreach (XmlAttribute attr in nod.Attributes)
                {
                    
                    if(attr.Name == "Surname")
                        if (attr.Value == stud.Surname || stud.Surname == String.Empty)
                            surname = attr.Value;
                    if (attr.Name == "Name")
                        if (attr.Value == stud.Name || stud.Name == String.Empty)
                            name = attr.Value;
                    if (attr.Name == "Pathers")
                        if (attr.Value == stud.Pathers || stud.Pathers == String.Empty)
                            pathers = attr.Value;
                    if (attr.Name == "Faculty")
                        if (attr.Value == stud.Faculty || stud.Faculty == String.Empty)
                            faculty = attr.Value;
                    if (attr.Name == "Cathedra")
                        if (attr.Value == stud.Cathedra || stud.Cathedra == String.Empty)
                            cathedra = attr.Value;
                    if (attr.Name == "Mark")
                        if (attr.Value == stud.Mark || stud.Mark == String.Empty)
                            mark = attr.Value;
                    
                    if (name != "" && surname != "" && pathers != "" && faculty != "" && cathedra != "" && mark != "")
                    {
                        Student t = new Student();
                        t.Name = name;
                        t.Surname = surname;
                        t.Pathers = pathers;
                        t.Faculty = faculty;
                        t.Cathedra = cathedra;
                        t.Mark = mark;
                        result.Add(t);
                    }
                }
            }

            return result;
        }
    }
}
