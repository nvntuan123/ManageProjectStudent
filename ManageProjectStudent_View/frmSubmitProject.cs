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
    public partial class frmSubmitProject : Form
    {
        private ISubmitProject ISP = Config.Container.Resolve<ISubmitProject>();
        public frmSubmitProject()
        {
            InitializeComponent();
        }
    }
}
