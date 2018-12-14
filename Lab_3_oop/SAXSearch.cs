using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab_3_oop
{
    class SAXSearch : Searcher
    {
        public List<Student> Search(string pathToXml, Student stud)
        {
            List<Student> AllResult = new List<Student>();
            var xmlReader = new XmlTextReader(pathToXml);

            while (xmlReader.Read())
            {
                if (xmlReader.HasAttributes)
                {
                    while (xmlReader.MoveToNextAttribute())
                    {
                        string Surname = "",Name = "", Fathers = "", Mark = "", Faculty = "", Cathedra = "";
                        if (xmlReader.Name == "Surname" && (xmlReader.Value == stud.Surname || stud.Surname == String.Empty))
                        {
                            Surname = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();
                            if (xmlReader.Name == "Name" && (xmlReader.Value == stud.Name || stud.Name == String.Empty))
                            {
                                Name = xmlReader.Value;
                                xmlReader.MoveToNextAttribute();
                                if (xmlReader.Name == "Pathers" && (xmlReader.Value == stud.Pathers || stud.Pathers == String.Empty))
                                {
                                    Fathers = xmlReader.Value;
                                    xmlReader.MoveToNextAttribute();
                                    if (xmlReader.Name == "Faculty" && (xmlReader.Value == stud.Faculty || stud.Faculty == String.Empty))
                                    {
                                        Faculty = xmlReader.Value;
                                        xmlReader.MoveToNextAttribute();
                                        if (xmlReader.Name == "Cathedra" && (xmlReader.Value == stud.Cathedra || stud.Cathedra == String.Empty))
                                        {
                                            Cathedra = xmlReader.Value;
                                            xmlReader.MoveToNextAttribute();
                                            if (xmlReader.Name == "Mark" && (xmlReader.Value == stud.Mark || stud.Mark == String.Empty))
                                            {
                                                Mark = xmlReader.Value;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (Surname != "" && Name != "" && Fathers != "" && Mark != "" && Faculty != "" && Cathedra != "")
{
                            Student myStudent = new Student();
                            myStudent.Surname = Surname;
                            myStudent.Name = Name;
                            myStudent.Pathers = Fathers;
                            myStudent.Mark = Mark;
                            myStudent.Cathedra = Cathedra;
                            myStudent.Faculty = Faculty;
                            AllResult.Add(myStudent);
                        }
                    }
                }
            }
            xmlReader.Close();
            return AllResult;
        }
    }
}
