﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileManager.DataAccess.Data.Product;

namespace FileManager.DataAccess.Data
{
    public class JsonFactory : IFileFactory
    {
       
        public ICreateFile CreateFile(string TypeFile)
        {
            return new CreateJson();
        }

       

        public IDeleteFile DeleteFile(string TypeFile)
        {
            return new DeleteJson();
        }

       

        public IReadFile ReadFile(string TypeFile)
        {
            return new ReadJson();
        }

        public IUpdateFile UpdateFile(string TypeFile)
        {
            return new UpdateJson();
        }
    }
}
