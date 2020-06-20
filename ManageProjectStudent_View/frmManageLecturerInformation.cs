using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageProjectStudent_Interface;
using Unity;
namespace ManageProjectStudent_View
{
    public partial class frmManageLecturerInformation : Form
    {
        private IManageLecturerInformation IMLI = Config.Container.Resolve<IManageLecturerInformation>();
        public frmManageLecturerInformation()
        {
            InitializeComponent();
            btnSaveLecturer.Click += delegate { IMLI.btnSaveLecturer_Click(txtID, txtFullName, txtIDCard, dteBirthday, txtAddress, txtPhoneNumber, txtEmail, lkeFaculty, radNam, radNu, radAvailable, radUnavailable); };
        }

       
    }
}
