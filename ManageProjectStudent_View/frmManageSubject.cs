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
    
    public partial class frmManageSubject : Form
    {
        private ISubject IMSub = Config.Container.Resolve<ISubject>();
        public frmManageSubject()
        {
            InitializeComponent();
            
        }

        private void txtIDCourse_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNameCourse_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
