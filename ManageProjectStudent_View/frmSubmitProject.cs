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
        // Thong
        private ISubmitProject ISP = Config.Container.Resolve<ISubmitProject>();
        // Thong
        public frmSubmitProject()
        {
            InitializeComponent();
            // Thong
            txtName.KeyPress += new KeyPressEventHandler(ISP.txtName_KeyPress);
            txtAuthor.KeyPress += new KeyPressEventHandler(ISP.txtAuthor_KeyPress);
            // Thong
        }

        
    }
}
