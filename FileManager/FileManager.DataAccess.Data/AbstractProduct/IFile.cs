using FileManager.Common.Layer;

namespace FileManager.DataAccess.Data.AbstractProduct
{
    public abstract class IFile
    {
      
       
        public abstract void Create(Student student);
        public abstract void Read(int StudentForRead);
        public abstract void Update(int IdStudentForUpdate);
        public abstract void Delete(int IdStudentForDelete);

    }
}
