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
    public partial class frmLogin_Test : Form
    {
        private IGarena _IG = Config.Container.Resolve<IGarena>();
        public frmLogin_Test()
        {
            InitializeComponent();
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_IG._checkCharacterNumber(e.KeyChar))
            {
                e.Handled = true;
                txtPhoneNumber.Focus();
                string _STRMesge = "Không được nhập ký tự chữ, chỉ được nhập số.";
                MessageBox.Show(_STRMesge, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
