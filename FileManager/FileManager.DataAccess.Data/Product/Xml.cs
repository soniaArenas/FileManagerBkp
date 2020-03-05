using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.DataAccess.Data.AbstractProduct;
using System.Xml;
using FileManager.Common.Layer;
using System.IO;
using System.Xml.Serialization;
using System.Configuration;

namespace FileManager.DataAccess.Data.Product
{
    public class Xml : IFile
    {
        public string name;
        public override void Create(Student student)
        {
            studentAdd(student);
            XmlUtility.checkFile();
            XmlUtility.Serialize(Student.students );

        }
        private void studentAdd(Student student)
        {
            Student.students.Add(student);
        }
      
        public override void Delete(int IdStudentForDelete)
        {
            XmlUtility.Deserialize();
            var StudentDelete = XmlUtility.GetStudentById(IdStudentForDelete);
                Student.students.Remove(StudentDelete);
            XmlUtility.Serialize(Student.students);
        }

        public override void Read(int StudentForRead)
        {
            throw new NotImplementedException();
        }

        public override void Update(int IdStudentForUpdate)
        {
            throw new NotImplementedException();
        }


    }
}
