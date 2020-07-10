using ManageProjectStudent_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageProjectStudent_Model;

namespace ManageProjectStudent_View
{
    public partial class frmHome : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private int _IStatusLogin;  // 1:student ;  2:leturer
        private StudentModel _studentModel;
        private StaffModel _staffModel;
        public int IStatusLogin { get => _IStatusLogin; set => _IStatusLogin = value; }
    
        public StudentModel StudentModel { get => _studentModel; set => _studentModel = value; }
        public StaffModel StaffModel { get => _staffModel; set => _staffModel = value; }

        public frmHome()
        {
            InitializeComponent();
            random = new Random();
        }
        public frmHome(int IStatus , StudentModel student)
        {
            InitializeComponent();
            IStatusLogin = IStatus;
            StudentModel = student;   
            random = new Random();
        }
        public frmHome(int IStatus, StaffModel staff)
        {
            InitializeComponent();
            IStatusLogin = IStatus;
            StaffModel = staff;
            random = new Random();
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Arial", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenuHome.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(10, 25, 77);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Arial", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Hide();
            frmLogin f = new frmLogin();
            f.ShowDialog();
            this.Close();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenuHome.Height == 647 & panelMenuHome.Width == 264)
            {
                panelMenuHome.Height = 647;
                panelMenuHome.Width = 56;
            }
            else
            {
                panelMenuHome.Height = 647;
                panelMenuHome.Width = 264;
            }
        }

        private void itemManageMultiLanguage_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Hide();
            if (IStatusLogin == 1)
            {
                frmManageLanguageMain frmManageLanguageMain = new frmManageLanguageMain(IStatusLogin,StudentModel);
                frmManageLanguageMain.ShowDialog();
            }
            else if (IStatusLogin == 2)
            {
                frmManageLanguageMain frmManageLanguageMain = new frmManageLanguageMain(IStatusLogin,StaffModel);
                frmManageLanguageMain.ShowDialog();
            }
            this.Close();
        }

        private void itemDecentralization_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            MessageBox.Show("Chức năng đang được phát triển");
            //if (BStatusLogin == true)
            //{
            //    this.Hide();
            //    frmDecentralization frmDecentralization = new frmDecentralization();
            //    frmDecentralization.ShowDialog();
            //    this.Close();
            //}    
            //else
            //{
            //    MessageBox.Show("Bạn không có quyền thực hiện chức năng này");
            //}
        }

        private void itemManageStudent_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (IStatusLogin == 1)
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này");
            }
            else if (IStatusLogin == 2)
            {
                this.Hide();
                frmManageStudentInformation f = new frmManageStudentInformation(IStatusLogin,StaffModel);
                f.ShowDialog();
                this.Close();
            }
        }

        private void itemManageLecturer_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (IStatusLogin == 1)
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này");
            }
            else if (IStatusLogin == 2)
            {
                this.Hide();
                frmManageLecturerInformation f = new frmManageLecturerInformation(IStatusLogin, StaffModel);
                f.ShowDialog();
                this.Close();
            }
        }

        private void itemManageFaculty_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (IStatusLogin == 1)
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này");
            }
            else if (IStatusLogin == 2)
            {
                this.Hide();
             //   frmManageFaculty f = new frmManageFaculty(IStatusLogin,StaffModel);
               // f.ShowDialog();
                this.Close();
            }
        }

        private void itemManageProject_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (IStatusLogin == 1)
            {
                this.Hide();
                frmManageProjectStudentMain f = new frmManageProjectStudentMain(IStatusLogin, StudentModel) ;
                f.ShowDialog();
                this.Close();
            }
            else if (IStatusLogin == 2)
            {
                this.Hide();
                frmManageProjectMain f = new frmManageProjectMain(IStatusLogin,StaffModel);
                f.ShowDialog();
                this.Close();
            }    
        }

        private void itemManagSubject_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (IStatusLogin == 1)
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này");
            }
            else if (IStatusLogin == 2)
            {
                this.Hide();
                frmManageSubjectMain f = new frmManageSubjectMain(IStatusLogin, StaffModel);
                f.ShowDialog();
                this.Close();
            }
        }

        private void itemManageGroup_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            MessageBox.Show("Đang trong quá trình phát triển");
        }

        private void frmHome_Load(object sender, EventArgs e)
        {    
            if (IStatusLogin == 1)
            {
                lblHienThi_Ten.Text = StudentModel.StrStudentName;
                lblHienThi_ChucVu.Text = "Sinh Viên";
            }
            else if (IStatusLogin == 2)
            {
                lblHienThi_Ten.Text = StaffModel.StrStaffName;
                lblHienThi_ChucVu.Text = "Giảng Viên";
            }
        }

        private void itemManageClass_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (IStatusLogin == 1)
            {
                MessageBox.Show("Bạn không có quyền thực hiện chức năng này");
            }
            else if (IStatusLogin == 2)
            {
                this.Hide();
                frmManageClass f = new frmManageClass(IStatusLogin, StaffModel);
                f.ShowDialog();
                this.Close();
            }
        }
    }
}
