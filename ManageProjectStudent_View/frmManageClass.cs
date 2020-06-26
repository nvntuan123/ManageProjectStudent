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
    public partial class frmManageClass : Form
    {
        private IManageClass IMC = Config.Container.Resolve<IManageClass>();
        public frmManageClass()
        {
            InitializeComponent();
            txtClassName.KeyPress += new KeyPressEventHandler(IMC.txtClassName_KeyPress);
            txtIDClass.KeyPress += new KeyPressEventHandler(IMC.txtIDClass_KeyPress);
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
