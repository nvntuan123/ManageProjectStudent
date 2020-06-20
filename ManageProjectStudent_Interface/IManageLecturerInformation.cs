using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ManageProjectStudent_Interface
{
    public interface IManageLecturerInformation
    {
        //Thu
        void btnSaveLecturer_Click(TextBox txtID, TextBox txtFullName, TextBox txtIDCard, DateEdit dteBirthday, TextBox txtAddress, TextBox txtPhoneNumber, TextBox txtEmail, LookUpEdit lkeFaculty, RadioButton radNam, RadioButton radNu, RadioButton radAvailable, RadioButton radUnavailable);
        //fish
        //Thong
        void txtID_KeyPress(object sender, KeyPressEventArgs e);
        void txtFullName_KeyPress(object sender, KeyPressEventArgs e);
        void txtIDCard_KeyPress(object sender, KeyPressEventArgs e);
        void txtAddress_KeyPress(object sender, KeyPressEventArgs e);
        void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e);
        void txtEmail_KeyPress(object sender, KeyPressEventArgs e);

        void radNam_CheckedChanged(object sender, EventArgs e);
        void radNu_CheckedChanged(object sender, EventArgs e);
        //Thong
    }
}
