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
using ManageProjectStudent_ViewModel;
using ManageProjectStudent_Model;

namespace ManageProjectStudent_View
{
    public partial class frmManageLecturerInformation : Form
    {
        private bool indicatorIcon = true;
        private IManageLecturerInformation IMLI = Config.Container.Resolve<IManageLecturerInformation>();
        public frmManageLecturerInformation()
        {
            InitializeComponent();
        }
        #region Properties
        private int _IStatusForm = 0;
        private StaffModel _LecturerModelNow = null;
        private StaffModel _LecturerLogin = null;
        private BindingList<StaffModel> _lstLecturer = new BindingList<StaffModel>();
        private BindingList<FacultyModel> _lstFaculty = new BindingList<FacultyModel>();
        #endregion
        #region Method
        private void _setStatusForm()
        {
            //txtID.ReadOnly = true;
            switch (_IStatusForm)
            {
                case 0: // View
                    grpInformationLecturer.Enabled = false;
                    //btnSave.Enabled = false;
                    dteBirthday.Enabled = true;
                    //if (_LecturerModelNow == null)
                    //{
                    //    btnUpdate.Enabled = false;
                    //    btnDelete.Enabled = false;
                    //}
                    //else
                    //{
                    //    btnUpdate.Enabled = true;
                    //    btnDelete.Enabled = true;
                    //}
                    break;
                case 1: // Add.
                    txtID.Text = string.Empty;
                    txtFullName.Text = string.Empty;
                    txtIDCard.Text = string.Empty;
                    dteBirthday.EditValue = null;
                    txtAddress.Text = string.Empty;
                    txtPhoneNumber.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    lkeFaculty.EditValue = null;
                    radNam.Checked = false;
                    radNu.Checked = false;
                    radAvailable.Checked = false;
                    radUnavailable.Checked = false;

                    grpInformationLecturer.Enabled = true;

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    break;
                case 2: // Update
                    grpInformationLecturer.Enabled = true;
                    btnSave.Enabled = true;
                    break;
            }
        }

        private void _loadData()
        {
            if (_LecturerModelNow==null)
            {
                txtID.Text = string.Empty;
                txtFullName.Text = string.Empty;
                txtIDCard.Text = string.Empty;
                dteBirthday.EditValue = null;
                txtAddress.Text = string.Empty;
                txtPhoneNumber.Text = string.Empty;
                txtEmail.Text = string.Empty;
                lkeFaculty.EditValue = null;
                radNam.Checked = false;
                radNu.Checked = false;
                radAvailable.Checked = false;
                radUnavailable.Checked = false;
            }   
            else
            {
                txtID.Text = _LecturerModelNow.StrStaffID;
                txtFullName.Text = _LecturerModelNow.StrStaffName;
                txtIDCard.Text = _LecturerModelNow.StrCardID;
                dteBirthday.EditValue = _LecturerModelNow.DtBirthDay.Date;
                txtAddress.Text = _LecturerModelNow.StrAddress;
                txtPhoneNumber.Text = _LecturerModelNow.StrPhone;
                txtEmail.Text = _LecturerModelNow.StrEmail;
                lkeFaculty.EditValue = _LecturerModelNow.StrFacultyID;
                if (_LecturerModelNow.StrSex == "Nam")
                {
                    radNam.Checked = true;
                    radNu.Checked = false;
                }
                else
                {
                    radNam.Checked = false;
                    radNu.Checked = true;
                }
                if (_LecturerModelNow.BStatus == true)
                {
                    radAvailable.Checked = true;
                    radUnavailable.Checked = false;
                }
                else
                {

                    radAvailable.Checked = false;
                    radUnavailable.Checked = true;
                }
            }    
        }

        private void _getData()
        {
            if (_LecturerModelNow == null)
            {
                _LecturerModelNow = new StaffModel();
            }
            _LecturerModelNow.StrStaffID = txtID.Text;
            _LecturerModelNow.StrStaffName = txtFullName.Text;
            _LecturerModelNow.StrCardID = txtIDCard.Text;
            _LecturerModelNow.DtBirthDay = (DateTime)dteBirthday.EditValue;
            _LecturerModelNow.StrAddress = txtAddress.Text;
            _LecturerModelNow.StrPhone = txtPhoneNumber.Text;
            _LecturerModelNow.StrEmail = txtEmail.Text;
            _LecturerModelNow.StrFacultyID = lkeFaculty.GetColumnValue("StrFacultyID").ToString();
            if (radNam.Checked)
            {
                _LecturerModelNow.StrSex = radNam.Text;
            }
            else if (radNu.Checked)
            {
                _LecturerModelNow.StrSex = radNu.Text;
            }

            if (radAvailable.Checked)
            {
                _LecturerModelNow.BStatus = true;
            }
            else
            {
                _LecturerModelNow.BStatus = false;
            }
        }
        private void _lstLoadListLecturer()
        {
            _lstLecturer = StaffViewModel.LoadStaff();
            if(_lstLecturer.Count>0)
            {
                foreach(StaffModel lt in _lstLecturer)
                {
                    if (lt.StrStaffID == "LT1")
                    {
                        _lstLecturer.Remove(lt);
                        break;
                    }
                }
            }
            gcListLecturer.DataSource = _lstLecturer;
        }

        #endregion
        #region Event
        //load
        private void frmManageLecturerInformation_Load(object sender, EventArgs e)
        {
            dteBirthday.EditValue = DateTime.Now.Date;

            _lstFaculty = FacultyViewModel.LoadFaculty();
            lkeFaculty.Properties.ValueMember = "StrFacultyID";
            lkeFaculty.Properties.DisplayMember = "StrFacultyName";
            lkeFaculty.Properties.DataSource = _lstFaculty;
            lkeFaculty.Properties.Columns["colFacultyID"].FieldName = "StrFacultyID";
            lkeFaculty.Properties.Columns["colFacultyName"].FieldName = "StrFacultyName";

            ///*GridView*/
            _lstLecturer = StaffViewModel.LoadStaff();

            LookUpEdit_Faculty.DataSource = _lstFaculty;
            LookUpEdit_Faculty.Columns["colFacultyID"].FieldName = "StrFacultyID";
            LookUpEdit_Faculty.Columns["colFacultyName"].FieldName = "StrFacultyName";
            gcListLecturer.DataSource = _lstLecturer;
            _setStatusForm();
        }

        //selection changed
        private void gvLecturerList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if(gvLecturerList.SelectedRowsCount>0)
                _LecturerModelNow = (StaffModel)gvLecturerList.GetRow(gvLecturerList.FocusedRowHandle);
            else
                _LecturerModelNow = null;

            _loadData();
            _IStatusForm = 0;
            _setStatusForm();
        }
        //stt
        private void gvLecturerList_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void gvLecturerList_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 20;
        }

        //click
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                string _STRMesge = "Bạn chưa nhập tên Giảng viên";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtIDCard.Text == "")
            {
                string _STRMesge = "Bạn chưa nhập Chứng minh nhân dân";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteBirthday.EditValue == null)
            {
                string _STRMesge = "Bạn chưa chọn Ngày sinh";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtAddress.Text == "")
            {
                string _STRMesge = "Bạn chưa nhập ĐịaS chỉ";
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
            else if (lkeFaculty.EditValue == null)
            {
                string _STRMesge = "Bạn chưa chọn Khoa";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!(radNam.Checked) && !(radNu.Checked))
            {
                string _STRMesge = "Bạn chưa chọn Giới tính";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!(radAvailable.Checked) && !(radUnavailable.Checked))
            {
                string _STRMesge = "Bạn chưa chọn Trạng thái";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _getData();
                bool bresult = false;
                if(_IStatusForm == 1)
                {
                    bresult = StaffViewModel.AddNewStaff(_LecturerModelNow);

                }
                else
                {
                    bresult = StaffViewModel.UpdateCurrentStafff(_LecturerModelNow);
                }

                if(!bresult)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _lstLoadListLecturer();
                    _IStatusForm = 0;
                    _setStatusForm();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }    
        }

        private void btnExitFormManageLecturer_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome frmHome = new frmHome();
            frmHome.ShowDialog();
            this.Close();
        }

        //key press

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GarenaViewModel._checkCharacterNumber(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                string _STRMesge = "Không được nhập ký tự chữ, chỉ được nhập số.";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

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

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GarenaViewModel._checkCharacterNumber(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                string _STRMesge = "Không được nhập ký tự chữ, chỉ được nhập số.";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //checked changed
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _LecturerModelNow = null;
            _IStatusForm = 1;
            _setStatusForm();
            //txtID.Text = StaffViewModel.GetByIDMaxLecturer();
            txtFullName.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _IStatusForm = 2;
            _setStatusForm();
            txtFullName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(_LecturerModelNow != null)
            {
                if (StaffViewModel.DeleteCurrentStaff(_LecturerModelNow))
                {
                    _lstLoadListLecturer();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_lstLecturer.Count == 0)
                    {
                        _LecturerModelNow = null;
                        _IStatusForm = 0;
                        _setStatusForm();
                    }
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion
        //Thu

    }
}
