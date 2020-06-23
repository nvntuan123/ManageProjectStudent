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
    public partial class frmManageMultiLanguage : Form
    {
        private IManageMultiLanguage IMML = Config.Container.Resolve<IManageMultiLanguage>();
        public frmManageMultiLanguage()
        {
            InitializeComponent();
            // Thong
            txtIDLanguage.KeyPress += new KeyPressEventHandler(IMML.txtIDLanguage_KeyPress);
            txtKeyword.KeyPress += new KeyPressEventHandler(IMML.txtKeyword_KeyPress);
            txtLanguageName.KeyPress += new KeyPressEventHandler(IMML.txtLanguageName_KeyPress);
            //Thong
        }

       
    }
}
