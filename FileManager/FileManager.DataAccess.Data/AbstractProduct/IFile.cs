using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.Common.Layer;

namespace FileManager.DataAccess.Data.AbstractProduct
{
    public abstract class IFile
    {
      
       
        public abstract void Create(Student student);
        public abstract void Read(Student student);
        public abstract void Update(Student student);
        public abstract void Delete(Student student);

    }
}
