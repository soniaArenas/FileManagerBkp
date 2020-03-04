using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using FileManager.DataAccess.Data.AbstractFactory;
using FileManager.DataAccess.Data.AbstractProduct;
using FileManager.DataAccess.Data.Product;

namespace FileManager.DataAccess.Data.ConcretFactory
{
    class FileFactory: IAbstractFactory
    {

        public  IFile CreateFile(string TypeFile)
        {
            var MyAssembly = Assembly.GetExecutingAssembly();
            XElement root = XElement.Load("RepositoryConfiguration.xml");
            IEnumerable<XElement> repository =
                from element in root.Elements("Type")
                where (string)element.Attribute("Id") == TypeFile
                select element;
            var fileType = repository.First().Element("class").Value;
            Type newFileManager = MyAssembly.GetType(fileType);
            return Activator.CreateInstance(newFileManager) as IFile;
        }

        
    }
}
