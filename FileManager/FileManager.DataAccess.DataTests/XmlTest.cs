using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using System.Collections.Generic;
using System.IO;
using FileManager.DataAccess.Data.AbstractFactory;
using FileManager.DataAccess.Data.AbstractProduct;
using FileManager.DataAccess.Data.Product;
using FileManager.DataAccess.Data;
using FileManager.Common.Layer;

namespace FileManager.DataAccess.DataTests
{
    /// <summary>
    /// Descripción resumida de XmlTest
    /// </summary>
    [TestClass]
    public class XmlTest
    {

        [ClassInitialize]
        public static void TestFixtureSetup(TestContext context)
        {
            string path = ConfigurationManager.AppSettings["xml"].ToString();
            XmlUtility.Serialize();
        }
        [TestInitialize]
        public void Setup()
        {
            Xml NewXml = new Xml();
            Student student1 = new Student("1", "Pepe", "Pepe", "45");
            Student student2 = new Student("2", "Laura", "Laura", "20");
            Student student3 = new Student("3", "Cris", "Cris", "12");
            Student student4 = new Student("4", "Lolo", "Lolo", "15");
            NewXml.Create(student1);
            NewXml.Create(student2);
            NewXml.Create(student3);
            NewXml.Create(student4);
        }

        [TestCleanup]
        public void TearDown()
        {
            string path = ConfigurationManager.AppSettings["xml"].ToString();
            XmlUtility.Serialize();
        }
        /*  [ClassCleanup]
          public static void TestFixtureTearDown()
          {
              string path = ConfigurationManager.AppSettings["xml"].ToString();
              File.Delete(path);
          }*/


    }
}
