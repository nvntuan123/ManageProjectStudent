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
using ManageProjectStudent_Interface;
using Unity;
using DevExpress.XtraGrid.Views.Layout;

namespace ManageProjectStudent_View
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            random = new Random();
        }
        #region Properties
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private IStudent _Student = Config.Container.Resolve<IStudent>();
        private IStaffType _StaffType = Config.Container.Resolve<IStaffType>();
        BindingList<StaffTypeModel> lstStaffType = new BindingList<StaffTypeModel>();
        bool BStatusLogin = false;
        #endregion
        #region Method
        private void setStatusLogin(bool bStatus, StudentModel student, StaffModel staff)
        {
            BStatusLogin = bStatus;
            if (bStatus)
            {
                if (student != null)
                {
                    lblDisplayName.Text = student.StrStudentName;
                    lblType.Text = "Sinh viên";
                }
                else
                {
                    lblDisplayName.Text = staff.StrStaffName;
                    if (lstStaffType == null)
                        lstStaffType = new BindingList<StaffTypeModel>();

                    lstStaffType = _StaffType.loadStaffType();

                    foreach (StaffTypeModel staffType in lstStaffType)
                    {
                        if (staff.StrStaffTypeID == staffType.StrStaffTypeID)
                        {
                            lblType.Text = staffType.StrStaffTypeName;
                            break;
                        }
                    }
                }
            }
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
        #endregion
        #region Event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (!BStatusLogin)
            {
                frmLogin frm = new frmLogin();
                frm.login = setStatusLogin;
                frm.ShowDialog();
            }
            else
            {
                setStatusLogin(false, null, null);
            }
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
           
        }

        private void itemDecentralization_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
           
        }

        private void itemManageStudent_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            
        }

        private void itemManageLecturer_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
           
        }

        private void itemManageFaculty_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            
        }

        private void itemManageProject_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            
        }

        private void itemManagSubject_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            
        }

        private void itemManageGroup_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            
        }

        private void frmHome_Load(object sender, EventArgs e)
        {    
            
        }

        private void itemManageClass_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            
        }
        #endregion
    }
}
