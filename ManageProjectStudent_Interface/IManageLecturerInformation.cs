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
        void btnSaveLecturer_Click(TextBox txtID, TextBox txtFullName, TextBox txtIDCard, DateEdit dteBirthday, TextBox txtAddress, TextBox txtPhoneNumber, TextBox txtEmail, LookUpEdit lkeFaculty, RadioButton radNam, RadioButton radNu, RadioButton radAvailable, RadioButton radUnavailable);
    }
}
