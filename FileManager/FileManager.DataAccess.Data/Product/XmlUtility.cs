using FileManager.Common.Layer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace FileManager.DataAccess.Data
{
   public class XmlUtility
    {
        public static string getPath()
        {
            var path = ConfigurationManager.AppSettings["xml"].ToString();
            return path;
        }
        public static void checkFile()
        {

            if (File.Exists(getPath()))
            {
                Deserialize();
            }
        }
        public static Student GetStudentById(int Id)
        {
            Student studentId = new Student();
            foreach (Student student in Student.students)
            {
                if (student.StudentId == studentId.StudentId)
                {
                    studentId = student;
                }
            }
            return studentId;
        }
        public static void Serialize(List<Student> students)
        {
          
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student> ));
           
            using (TextWriter writer = new StreamWriter(getPath()))
            {
                serializer.Serialize(writer, students);
            }
           
          
        }

        public static void Deserialize()
        {
           
            XmlSerializer deserializer = new XmlSerializer(typeof(Student));
            TextReader reader = new StreamReader(getPath());
            object obj = deserializer.Deserialize(reader);
            Student XmlData = (Student)obj;
            reader.Close();
        }
    }
}
