using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileManager.Common.Layer
{
    [XmlRoot("Student")]
    public class Student
    {
        [XmlElement("ID")]
        public int StudentId { get; set; }
        [XmlElement("Name")]
        public string StudentName { get; set; }
        [XmlElement("Surname")]
        public string StudentSurname { get; set; }
        [XmlElement("Birth")]
        public DateTime AgeOfBirth { get; set; }

        public static List<Student> students = new List<Student>();
        public Student (int Id,string name, string surname, DateTime age)
        {
            
        StudentId = Id;
            StudentName = name;
            StudentSurname = surname;
            AgeOfBirth = age;
        }
        public Student()
        {

            StudentId = StudentId;
            StudentName = StudentName;
            StudentSurname = StudentSurname;
            AgeOfBirth = AgeOfBirth;
        }

    }
}
