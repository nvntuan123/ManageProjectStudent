using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageProjectStudent_Interface
{
    public interface IManageStudentInformation
    {
        void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e);
        void txtID_KeyPress(object sender, KeyPressEventArgs e);
        void txtFullName_KeyPress(object sender, KeyPressEventArgs e);
    }
}
