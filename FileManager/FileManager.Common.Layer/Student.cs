using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileManager.Common.Layer
{
    public class Student
    {
        [XmlElement("ID")]
        public string StudentId { get; set; }
        [XmlElement("Name")]
        public string StudentName { get; set; }
        [XmlElement("Surname")]
        public string StudentSurname { get; set; }
        [XmlElement("Age of birth")]
        public string studentAge { get; set; }

        public static List<Student> students = new List<Student>();
        public Student (string Id,string name, string surname, string age)
        {
            
        StudentId = Id;
            StudentName = name;
            StudentSurname = surname;
            studentAge = age;
        }
        public Student()
        {

            StudentId = StudentId;
            StudentName = StudentName;
            StudentSurname = StudentSurname;
            studentAge = studentAge;
        }

    }
}
