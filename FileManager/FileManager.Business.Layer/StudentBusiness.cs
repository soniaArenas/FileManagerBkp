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
            student.Name = Name;
            student.Surname = Surname;
            student.AgeOfBirth = AgeOfBirth.ToString();
            IFile studenCreator = FactoryProvider.GetFactory(type).Creator(type);
            studenCreator.Add(student);
        }
        public void Delete(string Name, string Surname, DateTime AgeOfBirth, string StudentId, string typo)
        {
            Student student = new Student();
            student.Name = Name;
            student.Surname = Surname;
            student.AgeOfBirth = AgeOfBirth.ToString();
            student.StudentId = Int32.Parse(StudentId);
            IFile studenCreator = FactoryProvider.GetFactory(type).Creator(type);
            studenCreator.Delete(student);
        }
        public void Update(string Name, string Surname, DateTime AgeOfBirth, string StudentId, string typo)
        {
            Student student = new Student();
            student.Name = Name;
            student.Surname = Surname;
            student.AgeOfBirth = AgeOfBirth.ToString();
            student.StudentId = Int32.Parse(StudentId);
            StudentDao studenCreator = FactoryProvider.GetFactory(typo).Creator(typo);
            studenCreator.Update(student);
        }
    }
}
