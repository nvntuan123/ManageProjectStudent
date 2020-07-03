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
        public frmLogin()
        {
            InitializeComponent();


        }
        #region Properties
        private IStaff _Staff = Config.Container.Resolve<IStaff>();
        private IStudent _Student = Config.Container.Resolve<IStudent>();

        #endregion
        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (_Staff.checkStaffID(this.txtUsers.Text) == true || _Student.checkStudentID(this.txtUsers.Text) == true)
            {
                if (_Staff.checkCardID(txtPassword.Text) == true || _Student.checkCardID(txtPassword.Text) == true)
                {
                    this.Close();
                    frmHome frmHome = new frmHome();
                    frmHome.ShowDialog();
                }
                else
                {
                    txtPassword.Clear();
                    MessageBox.Show("Sai Mat Khau");
                }
            }
            else
            {
                txtUsers.Clear();
                MessageBox.Show("Tên Đăng Nhập Sai");
            }
            // if(this.txtUsers.Text == "Admin" && txtPassword.Text ==)
        }
    }
}
