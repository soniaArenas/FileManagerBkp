using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileManager.Common.Layer;
using FileManager.DataAccess.Data;
using FileManager.DataAccess.Data.AbstractFactory;

namespace FileManager.Presentation.WinSite
{
    public partial class frmStudent : Form
    {
     
        public frmStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            var TypeOfFile = CmbFiles.SelectedItem.ToString();
            Student student = new Student(txtId.Text, txtBoxName.Text, txtBoxSurname.Text, txtBoxAge.Text);
            IAbstractFactory FileCreate = FactoryProvider.GetFactory(TypeOfFile);
            DataAccess.Data.AbstractProduct.IFile Return = FileCreate.CreateFile(TypeOfFile);
            Return.Create(student);
         
        }


    }
}
