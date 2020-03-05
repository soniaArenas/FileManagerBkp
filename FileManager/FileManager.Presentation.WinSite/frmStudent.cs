using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileManager.Business.Layer;
using FileManager.Common.Layer;
using FileManager.DataAccess.Data;
using FileManager.DataAccess.Data.AbstractFactory;
using log4net;

namespace FileManager.Presentation.WinSite
{
   
    public partial class frmStudent : Form

    { private static readonly ILog logger = LogManager.GetLogger(typeof(frmStudent));
     
        public frmStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            var TypeOfFile = CmbFiles.SelectedItem.ToString();
            Student student = new Student(Convert.ToInt32(txtId.Text), txtBoxName.Text, txtBoxSurname.Text, dtAge.Value);
            StudentBusiness.Add(student, TypeOfFile);
        }


    }
}
