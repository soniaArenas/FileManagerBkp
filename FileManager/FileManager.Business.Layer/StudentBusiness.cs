using System;
using FileManager.Common.Layer;
using FileManager.DataAccess.Data;
using FileManager.DataAccess.Data.AbstractProduct;

namespace FileManager.Business.Layer
{
    public class StudentBusiness
    {
        public static void Add(Student student, string TypeFile)
        {
            IFile studenCreator = FactoryProvider.GetFactory(TypeFile).CreateFile(TypeFile);
            studenCreator.Create(student);
        }
        public void Delete(Student student, string TypeFile)
        {
            
            IFile studenCreator = FactoryProvider.GetFactory(TypeFile).CreateFile(TypeFile);
            studenCreator.Delete(student);
        }
        public void Update(Student student, string TypeFile)
        {
           
            IFile studenCreator = FactoryProvider.GetFactory(TypeFile).CreateFile(TypeFile);
            studenCreator.Update(student);
        }
    }
}
