using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageProjectStudent_Interface
{
    public interface IManageLecturerInformation
    {
        void txtID_KeyPress(object sender, KeyPressEventArgs e);
        void txtFullName_KeyPress(object sender, KeyPressEventArgs e);
        void txtIDCard_KeyPress(object sender, KeyPressEventArgs e);
        void txtAddress_KeyPress(object sender, KeyPressEventArgs e);
        void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e);
        void txtEmail_KeyPress(object sender, KeyPressEventArgs e);

        void radNam_CheckedChanged(object sender, EventArgs e);
        void radNu_CheckedChanged(object sender, EventArgs e);

    }
}
