using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ManageProjectStudent_Interface
{
    public interface IManageProject
    {
        // Thong
        void txtIDProject_KeyPress(object sender, KeyPressEventArgs e);
        void txtProjectName_KeyPress(object sender, KeyPressEventArgs e);
        //Thong
    }
}
