using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Layer;
using FileManager.DataAccess.Data.AbstractProduct;

namespace FileManager.DataAccess.Data.Product
{
    class Txt : IFile
    {
        public override void Create(Student student)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int IdStudentForDelete)
        {
            throw new NotImplementedException();
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
