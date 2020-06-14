using ManageProjectStudent_Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace ManageProjectStudent_View
{
    public partial class frmLogin : Form
    {
        private IGarena _IG = Config.Container.Resolve<IGarena>();
        public frmLogin()
        {
            InitializeComponent();


        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_IG._checkCharacterNumber(e.KeyChar))
            {
                e.Handled = true;
                gunaTextBox1.Focus();
                string _STRMesge = "Không được nhập ký tự chữ, chỉ được nhập số.";
                MessageBox.Show(_STRMesge, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
