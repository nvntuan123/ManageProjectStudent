using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using ManageProjectStudent_Interface;
using Unity;
using ManageProjectStudent_Model;
using ManageProjectStudent_ViewModel;

namespace ManageProjectStudent_View
{
    public partial class frmManageStudentInformation : Form
    {
        private bool indicatorIcon = true;
        private IManageStudentInformation IMSI = Config.Container.Resolve<IManageStudentInformation>();
        public frmManageStudentInformation()
        {
            InitializeComponent();
        }

        #region Properties
        /*
         * Set status form: 0. View, 1. Add, 2. Update.
         */
        private int _IStatusForm = 0;
        private StudentModel _StudentModelNow = null;
        private BindingList<StudentModel> _LstStudent = null;

        #endregion

        #region Method
        private void _setStatusForm()
        {
            txtID.ReadOnly = true;
            switch (_IStatusForm)
            {
                case 0: // View
                    grpInformationStudent.Enabled = true;
                    btnSave.Enabled = false;
                    if(_StudentModelNow==null)
                    {
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                    break;
                case 1: // Add.
                    break;
                case 2: // Update
                    break;
            }
        }
        private void _loadData()
        {
            if(_StudentModelNow == null)
            {
                txtID.Text = string.Empty;
                txtFullName.Text = string.Empty;
                dteBirthday.EditValue = null;
                radNu.Checked = false;
                radNam.Checked = false;
                txtPhoneNumber.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtIDCard.Text = string.Empty;
                txtAddress.Text = string.Empty;
                radAvailable.Checked = false;
                radUnavailable.Checked = false;
                lkeClass.EditValue = null;
                lkeFaculty.EditValue = null;
            }
            else
            {
                txtID.Text = _StudentModelNow.StrStudentID;
                txtFullName.Text = _StudentModelNow.StrStudentName;
                dteBirthday.EditValue = _StudentModelNow.DtBirthDay.Date;
                if(_StudentModelNow.StrSex== "Nam")
                {
                    radNam.Checked = true;
                    radNu.Checked = false;
                }
                else
                {
                    radNam.Checked = false;
                    radNu.Checked = true;
                }
                txtPhoneNumber.Text = _StudentModelNow.StrPhone;
                txtEmail.Text = _StudentModelNow.StrEmail;
                txtIDCard.Text = _StudentModelNow.StrCardID;
                txtAddress.Text = _StudentModelNow.StrAddress;
                if(_StudentModelNow.BStatus== true)
                {
                    radAvailable.Checked = true;
                    radUnavailable.Checked = false;
                }
                else
                {

                    radAvailable.Checked = false;
                    radUnavailable.Checked = true;
                }
                lkeClass.EditValue = _StudentModelNow.StrClassID;
                lkeFaculty.EditValue = _StudentModelNow.StrFacultyID;
            }
        }

        private void _getData()
        {
            if(_StudentModelNow == null)
            {
                _StudentModelNow = new StudentModel();
            }
            _StudentModelNow.StrStudentID = txtID.Text;
            _StudentModelNow.StrStudentName = txtFullName.Text;
            _StudentModelNow.DtBirthDay = (DateTime)dteBirthday.EditValue;
            if(radNam.Checked)
            {
                _StudentModelNow.StrSex = radNam.Text;
            }
            else if (radNu.Checked)
            {
                _StudentModelNow.StrSex = radNu.Text;
            }
            _StudentModelNow.StrPhone = txtPhoneNumber.Text;
            _StudentModelNow.StrEmail = txtEmail.Text;
            _StudentModelNow.StrCardID = txtIDCard.Text;
            _StudentModelNow.StrAddress = txtAddress.Text;
            if(radAvailable.Checked)
            {
                _StudentModelNow.BStatus = true;
            }
            else if (radUnavailable.Checked)
            {
                _StudentModelNow.BStatus = false;
            }
            _StudentModelNow.StrClassID = lkeClass.Text;
            _StudentModelNow.StrFacultyID = lkeFaculty.Text;
        }
        #endregion

        #region Event
        //Thu
        //stt

        private void gvStudentList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            try
            {
                GridView view = (GridView)sender;
                if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                {
                    string sText = (e.RowHandle + 1).ToString();
                    Graphics gr = e.Info.Graphics;
                    gr.PageUnit = GraphicsUnit.Pixel;
                    GridView gridView = ((GridView)sender);
                    SizeF size = gr.MeasureString(sText, e.Info.Appearance.Font);
                    int nNewSize = Convert.ToInt32(size.Width) + GridPainter.Indicator.ImageSize.Width + 10;
                    if (gridView.IndicatorWidth < nNewSize)
                    {
                        gridView.IndicatorWidth = nNewSize;
                    }

                    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    e.Info.DisplayText = sText;
                }
                if (!indicatorIcon)
                    e.Info.ImageIndex = -1;

                if (e.RowHandle == GridControl.InvalidRowHandle)
                {
                    Graphics gr = e.Info.Graphics;
                    gr.PageUnit = GraphicsUnit.Pixel;
                    GridView gridView = ((GridView)sender);
                    SizeF size = gr.MeasureString("STT", e.Info.Appearance.Font);
                    int nNewSize = Convert.ToInt32(size.Width) + GridPainter.Indicator.ImageSize.Width + 10;
                    if (gridView.IndicatorWidth < nNewSize)
                    {
                        gridView.IndicatorWidth = nNewSize;
                    }

                    e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    e.Info.DisplayText = "STT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gvStudentList_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 20;
        }
        //stt

        //click
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                string _STRMesge = "Bạn chưa nhập tên Sinh viên";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteBirthday.EditValue == null)
            {
                string _STRMesge = "Bạn chưa chọn Ngày sinh";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!(radNam.Checked) && !(radNu.Checked))
            {
                string _STRMesge = "Bạn chưa chọn Giới tính";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPhoneNumber.Text == "")
            {
                string _STRMesge = "Bạn chưa nhập Số điện thoại";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtEmail.Text == "")
            {
                string _STRMesge = "Bạn chưa nhập Email";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtIDCard.Text == "")
            {
                string _STRMesge = "Bạn chưa nhập Chứng minh nhân dân";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtAddress.Text == "")
            {
                string _STRMesge = "Bạn chưa nhập Địa chỉ";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!(radAvailable.Checked) && !(radUnavailable.Checked))
            {
                string _STRMesge = "Bạn chưa chọn Trạng thái";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lkeClass.EditValue == null)
            {
                string _STRMesge = "Bạn chưa chọn Lớp học";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lkeFaculty.EditValue == null)
            {
                string _STRMesge = "Bạn chưa chọn Khoa";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }
        }

        private void btnExitFormManageStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome frmHome = new frmHome();
            frmHome.ShowDialog();
            this.Close();
        }

        //keypress
        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!GarenaViewModel._checkCharacterChar(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                string _STRMesge = "Không được nhập ký tự số, chỉ được nhập chữ.";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GarenaViewModel._checkCharacterNumber(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                string _STRMesge = "Không được nhập ký tự chữ, chỉ được nhập số.";
                MessageBox.Show(_STRMesge, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtIDCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GarenaViewModel._checkCharacterNumber(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                string _STRMesge = "Không được nhập ký tự chữ, chỉ được nhập số.";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //checkedchange
        private void radAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (radAvailable.Checked)
            {
                radUnavailable.Checked = false;
            }
        }

        private void radUnavailable_CheckedChanged(object sender, EventArgs e)
        {
            if (radUnavailable.Checked)
            {
                radAvailable.Checked = false;
            }
        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            if (radNam.Checked)
            {
                radNu.Checked = false;
            }
        }

        private void radNu_CheckedChanged(object sender, EventArgs e)
        {
            if (radNu.Checked)
            {
                radNam.Checked = false;
            }
        }

        //selectchange
        private void gvStudentList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvStudentList.SelectedRowsCount > 0)
            {
                _StudentModelNow = (StudentModel)gvStudentList.GetRow(gvStudentList.FocusedRowHandle);
            }
            else
            {
                _StudentModelNow = null;
            }
            _loadData();
            _IStatusForm = 0;
            _setStatusForm();
        }
        //Thu
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _StudentModelNow = null;
            _IStatusForm = 1;
            _setStatusForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
