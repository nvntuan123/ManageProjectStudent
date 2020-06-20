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
    public partial class frmManageStudentInformation : Form
    {
        private IManageStudentInformation IMSI = Config.Container.Resolve<IManageStudentInformation>();
        public frmManageStudentInformation()
        {
            InitializeComponent();

            txtPhoneNumber.KeyPress += new KeyPressEventHandler(IMSI.txtPhoneNumber_KeyPress);
            txtID.KeyPress += new KeyPressEventHandler(IMSI.txtID_KeyPress);
            txtFullName.KeyPress += new KeyPressEventHandler(IMSI.txtFullName_KeyPress);
            txtEmail.KeyPress += new KeyPressEventHandler(IMSI.txtEmail_KeyPress);
            txtIDCard.KeyPress += new KeyPressEventHandler(IMSI.txtIDCard_KeyPress);
            radNam.CheckedChanged += new EventHandler(IMSI.radNam_CheckedChanged);
            radNu.CheckedChanged += new EventHandler(IMSI.radNu_CheckedChanged);
            btnSaveStudent.Click += delegate { IMSI.btnSaveStudent_Click(txtID, txtFullName, dteBirthday, radNam, radNu, txtPhoneNumber, txtEmail, txtIDCard, txtAddress, radAvailable, radUnavailable, lkeCourse, lkeClass, lkeFaculty); };
            
        }

        
    }
}
