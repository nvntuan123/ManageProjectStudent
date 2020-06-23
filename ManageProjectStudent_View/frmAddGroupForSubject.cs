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
    public partial class frmAddGroupForSubject : Form
    {
        // Thong
        private IAddGroupForSubject IAGFS = Config.Container.Resolve<IAddGroupForSubject>();
        // Thong
        public frmAddGroupForSubject()
        {
            InitializeComponent();
            // Thong
            txtGroupName.KeyPress += new KeyPressEventHandler(IAGFS.txtGroupName_KeyPress);
            txtIDGroup.KeyPress += new KeyPressEventHandler(IAGFS.txtGroupName_KeyPress);
            // Thong
        }
    }
}
