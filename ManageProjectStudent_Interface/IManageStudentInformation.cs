using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ManageProjectStudent_Interface
{
    public interface IManageStudentInformation
    {
        void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e);
        void txtID_KeyPress(object sender, KeyPressEventArgs e);
        void txtFullName_KeyPress(object sender, KeyPressEventArgs e);
        void txtIDCard_KeyPress(object sender, KeyPressEventArgs e);
        void txtEmail_KeyPress(object sender, KeyPressEventArgs e);
        void radNam_CheckedChanged(object sender, EventArgs e);
        void radNu_CheckedChanged(object sender, EventArgs e);
<<<<<<< HEAD
        void btnSaveStudent_Click(TextBox txtID, TextBox txtFullName, DateEdit dteBirthday, RadioButton radNam, RadioButton radNu, TextBox txtPhoneNumber, TextBox txtEmail, TextBox txtIDCard, TextBox txtAddress, RadioButton radAvailable, RadioButton radUnavailable, LookUpEdit lkeCourse , LookUpEdit lkeClass, LookUpEdit lkeFaculty);
        void _setStatus(TextBox txtID, TextBox txtFullName, DateEdit dteBirthday, RadioButton radNam, RadioButton radNu, TextBox txtPhoneNumber, TextBox txtEmail, TextBox txtIDCard, TextBox txtAddress, RadioButton radAvailable, RadioButton radUnavailable, LookUpEdit lkeCourse, LookUpEdit lkeClass, LookUpEdit lkeFaculty);
=======
        void txtAddress_KeyPress(object sender, KeyPressEventArgs e);
>>>>>>> 3b8fef094b12103194859e67a1d5ed8d19da9f5e
    }
}
