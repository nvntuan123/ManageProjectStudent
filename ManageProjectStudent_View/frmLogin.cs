using ManageProjectStudent_Interface;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Unity;
using ManageProjectStudent_Model;
using ManageProjectStudent_ViewModel;
using System.Drawing;

namespace ManageProjectStudent_View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();


        }
        #region Properties
        public static IStudent Student = Config.Container.Resolve<IStudent>();
        public static IStaff Lecturer = Config.Container.Resolve<IStaff>();
        #endregion

        #region Event

        #endregion

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            Util.EndAnimate(this, Util.Effect.Center, 150, 180);

            txtUsers.TabIndex = 0;
            txtPassword.TabIndex = 1;
            btnLogin.TabIndex = 2;
            btnExit.TabIndex = 3;

            lblError.Visible = false;
            txtUsers.Focus();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Student.checkStudentID(txtUsers.Text)==true && Student.checkCardID(txtPassword.Text)==true)
            {

            }    
        }
    }
}
