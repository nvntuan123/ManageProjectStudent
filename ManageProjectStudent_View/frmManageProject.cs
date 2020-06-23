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
    public partial class frmManageProject : Form
    {
        // Thong
        private IManageProject IMP = Config.Container.Resolve<IManageProject>();
        // Thong
        public frmManageProject()
        {
            InitializeComponent();
            // Thong
            txtIDProject.KeyPress += new KeyPressEventHandler(IMP.txtIDProject_KeyPress);
            txtProjectName.KeyPress += new KeyPressEventHandler(IMP.txtProjectName_KeyPress);
            // Thong
        }
    }
}
