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
            XmlUtility.Serialize();

        }
        private void studentAdd(Student student)
        {
            Student.students.Add(student);
        }
        public void GetStudentById()
        {
        }
        public override void Delete(Student student)
        {
            throw new NotImplementedException();
        }

        public override void Read(Student student)
        {
            throw new NotImplementedException();
        }

        public override void Update(Student student)
        {
            throw new NotImplementedException();
        }


    }
}
