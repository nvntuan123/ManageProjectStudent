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
<<<<<<< HEAD
=======

>>>>>>> 3b8fef094b12103194859e67a1d5ed8d19da9f5e
namespace ManageProjectStudent_View
{
    public partial class frmManageLecturerInformation : Form
    {
        private IManageLecturerInformation IMLI = Config.Container.Resolve<IManageLecturerInformation>();
        public frmManageLecturerInformation()
        {
            InitializeComponent();
<<<<<<< HEAD
            btnSaveLecturer.Click += delegate { IMLI.btnSaveLecturer_Click(txtID, txtFullName, txtIDCard, dteBirthday, txtAddress, txtPhoneNumber, txtEmail, lkeFaculty, radNam, radNu, radAvailable, radUnavailable); };
        }

       
=======

            txtPhoneNumber.KeyPress += new KeyPressEventHandler(IMLI.txtPhoneNumber_KeyPress);
            txtID.KeyPress += new KeyPressEventHandler(IMLI.txtID_KeyPress);
            txtFullName.KeyPress += new KeyPressEventHandler(IMLI.txtFullName_KeyPress);
            txtEmail.KeyPress += new KeyPressEventHandler(IMLI.txtEmail_KeyPress);
            txtIDCard.KeyPress += new KeyPressEventHandler(IMLI.txtIDCard_KeyPress);
            txtAddress.KeyPress += new KeyPressEventHandler(IMLI.txtAddress_KeyPress);
            radNam.CheckedChanged += new EventHandler(IMLI.radNam_CheckedChanged);
            radNu.CheckedChanged += new EventHandler(IMLI.radNu_CheckedChanged);


        }

        
>>>>>>> 3b8fef094b12103194859e67a1d5ed8d19da9f5e
    }
}
