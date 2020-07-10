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
        BindingList<StudentModel> lstStudent = new BindingList<StudentModel>();
        BindingList<StaffModel> lstLecturer = new BindingList<StaffModel>();
        public static StudentModel studentSelected = null;
        public static StaffModel lecturerSelected = null;
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

            lstStudent = Student.loadStudent();
            lstLecturer = Lecturer.loadStaff();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsers.Text == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                lblError.Location = new Point(555, 135);
                lblError.Visible = true;
                txtUsers.Focus();
            }  
            else if(txtPassword.Text == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                lblError.Location = new Point(555, 222);
                lblError.Visible = true;
                txtPassword.Focus();
            }   
            else
            {
                lblError.Visible = false;

                studentSelected = new StudentModel();
                lecturerSelected = new StaffModel();
                bool bCheckUser = false;
                bool bCheckPass = false;
                //bool bCheckStudent = false;
                //bool bCheckLecturer = false;

                if(Student.checkStudentID(txtUsers.Text) == true)
                {
                    bCheckUser = true;
                    if(Student.checkCardID(txtPassword.Text) == true)
                    {
                        bCheckPass = true;
                        studentSelected = Student.getStudentSelected(txtUsers.Text);
                        frmHome f = new frmHome(1,studentSelected);
                        f.StudentModel = studentSelected;
                        f.ShowDialog();
                        this.Hide();
                        this.Close();
                    }
                }
                if (Lecturer.checkStaffID(txtUsers.Text) == true)
                {
                    bCheckUser = true;
                    if (Lecturer.checkCardID(txtPassword.Text) == true)
                    {
                        bCheckPass = true;
                        lecturerSelected = Lecturer.getStaffSelected(txtUsers.Text);
                        this.Hide();
                        frmHome f = new frmHome(2,lecturerSelected);
                        f.StaffModel = lecturerSelected;
                        f.ShowDialog();
                        this.Close();
                    }
                }

                else if (bCheckUser == false)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Sai Tài Khoản!", "Thông Báo");
                    lblError.Visible = true;
                    lblError.Location = new Point(555, 135);
                    txtUsers.Focus();
                } 
                else if(bCheckPass == false)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Sai Mật Khẩu!", "Thông Báo");
                    lblError.Visible = true;
                    lblError.Visible = true;
                    txtPassword.Focus();
                }    
            }    
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
