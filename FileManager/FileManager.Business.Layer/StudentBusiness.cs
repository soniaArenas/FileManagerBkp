using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Layer;
using FileManager.DataAccess.Data;
using FileManager.DataAccess.Data.AbstractProduct;

namespace FileManager.Business.Layer
{
    class StudentBusiness
    {
        public void Add(string Name, string Surname, DateTime AgeOfBirth, string type)
        {
            Student student = new Student();
            student.StudentName = Name;
            student.StudentSurname = Surname;
            student.AgeOfBirth = AgeOfBirth;
            IFile studenCreator = FactoryProvider.GetFactory(type).CreateFile(type);
            studenCreator.Create(student);
        }
        public void Delete(string Name, string Surname, DateTime AgeOfBirth, string StudentId, string TypeFile)
        {
            Student student = new Student();
            student.StudentName = Name;
            student.StudentSurname = Surname;
            student.AgeOfBirth = AgeOfBirth;
            student.StudentId = Int32.Parse(StudentId);
            IFile studenCreator = FactoryProvider.GetFactory(TypeFile).CreateFile(TypeFile);
            studenCreator.Delete(student);
        }
        public void Update(string Name, string Surname, DateTime AgeOfBirth, int StudentId, string TypeFile)
        {
            Student student = new Student();
            student.StudentName = Name;
            student.StudentSurname = Surname;
            student.AgeOfBirth = AgeOfBirth;
            student.StudentId = StudentId;
            IFile studenCreator = FactoryProvider.GetFactory(TypeFile).CreateFile(TypeFile);
            studenCreator.Update(student);
        }
    }
}
