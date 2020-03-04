using FileManager.Common.Layer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public static void Serialize()
        {
            Object[] array = Student.students.ToArray();
            XmlSerializer serializer = new XmlSerializer(typeof(Object[] ));
            using (TextWriter writer = new StreamWriter(getPath()))
            {
                serializer.Serialize(writer, array);
            }

        }

        public static void Deserialize()
        {
            object[] array = Student.students.ToArray();
            XmlSerializer deserializer = new XmlSerializer(typeof(object[]));
            TextReader reader = new StreamReader(getPath());
            object obj = deserializer.Deserialize(reader);
            Student XmlData = (Student)obj;
            reader.Close();

        }
    }
}
