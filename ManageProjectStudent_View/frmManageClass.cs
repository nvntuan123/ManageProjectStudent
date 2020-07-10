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
using DevExpress.XtraEditors.Filtering.Templates;
using System.Security.AccessControl;
using DevExpress.XtraPrinting;
using DevExpress.Export;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace ManageProjectStudent_View
{
    public partial class frmManageClass : Form
    {
        public frmManageClass()
        {
            InitializeComponent();
        }
        #region Properties
        private bool indicatorIcon = true;
        private int _IStatusForm = 0;
        private IClass _Class = Config.Container.Resolve<IClass>();
        private ClassModel _ClassModelNow = null;
        private BindingList<ClassModel> _lstClass = new BindingList<ClassModel>();
        private IFaculty _Faculty = Config.Container.Resolve<IFaculty>();
        private BindingList<FacultyModel> _lstFaculty = new BindingList<FacultyModel>();
        private ICourse _Course = Config.Container.Resolve<ICourse>();
        private BindingList<CourseModel> _lstCourse = new BindingList<CourseModel>();
        #endregion
        #region Mehtod
        private void _setStatusForm()
        {
            switch (_IStatusForm)
            {
                case 0:
                    grpInformationClass.Enabled = false;
                    if (_ClassModelNow != null)
                    {
                        btnDelete.Enabled = true;
                        btnUpdate.Enabled = true;
                    }
                    else
                    {
                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = false;
                    }
                    break;
                case 1:
                    txtClassID.Text = "";
                    txtClassName.Text = "";
                    lkeFaculty.EditValue = null;
                    lkeCourse.EditValue = null;

                    grpInformationClass.Enabled = true;

                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    break;
                case 2:
                    grpInformationClass.Enabled = true;
                    break;
            }
        }

        private void _loadData()
        {
            if (_ClassModelNow == null)
            {
                txtClassID.Text = "";
                txtClassName.Text = "";
                lkeFaculty.EditValue = null;
                lkeCourse.EditValue = null;
            }
            else
            {
                txtClassID.Text = _ClassModelNow.StrClassID;
                txtClassName.Text = _ClassModelNow.StrClassName;
                lkeFaculty.EditValue = _ClassModelNow.StrFacultyID;
                lkeCourse.EditValue = _ClassModelNow.StrCourseID;
            }
        }

        private void _getData()
        {
            if (_ClassModelNow == null)
            {
                _ClassModelNow = new ClassModel();
            }
            _ClassModelNow.StrClassID = txtClassID.Text;
            _ClassModelNow.StrClassName = txtClassName.Text;
            _ClassModelNow.StrFacultyID = lkeFaculty.GetColumnValue("StrFacultyID").ToString();
            _ClassModelNow.StrCourseID = lkeCourse.GetColumnValue("StrCourseID").ToString();
        }

        private void _lstLoadListClass()
        {
            _lstClass = _Class.loadClass();
            gcListClass.DataSource = _lstClass;
        }
        #endregion

        private void frmManageClass_Load(object sender, EventArgs e)
        {
            _lstFaculty = _Faculty.loadFaculty();
            lkeFaculty.Properties.ValueMember = "StrFacultyID";
            lkeFaculty.Properties.DisplayMember = "StrFacultyName";
            lkeFaculty.Properties.DataSource = _lstFaculty;
            lkeFaculty.Properties.Columns["colFacultyID"].FieldName = "StrFacultyID";
            lkeFaculty.Properties.Columns["colFacultyName"].FieldName = "StrFacultyName";

            _lstCourse = _Course.loadCourse();
            lkeCourse.Properties.ValueMember = "StrCourseID";
            lkeCourse.Properties.DisplayMember = "StrCourseID";
            lkeCourse.Properties.DataSource = _lstCourse;
            lkeCourse.Properties.Columns["colCourseID"].FieldName = "StrCourseID";

            ///*GridView*/
            _lstClass = _Class.loadClass();

            LookUpEdit_Faculty.DataSource = _lstFaculty;
            LookUpEdit_Faculty.Columns["colFacultyID"].FieldName = "StrFacultyID";
            LookUpEdit_Faculty.Columns["colFacultyName"].FieldName = "StrFacultyName";

            LookUpEdit_Course.DataSource = _lstCourse;
            LookUpEdit_Course.Columns["colCourseID"].FieldName = "StrCourseID";

            gcListClass.DataSource = _lstClass;
            _setStatusForm();
        }

        private void gvClassList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (gvClassList.SelectedRowsCount > 0)
                _ClassModelNow = (ClassModel)gvClassList.GetRow(gvClassList.FocusedRowHandle);
            else
                _ClassModelNow = null;

            _loadData();
            _IStatusForm = 0;
            _setStatusForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_ClassModelNow != null)
            {
                if (_Class.deleteCurrentClass(_ClassModelNow))
                {
                    _lstLoadListClass();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (_lstClass.Count == 0)
                    {
                        _ClassModelNow = null;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _ClassModelNow = null;
            _IStatusForm = 1;
            _setStatusForm();
            txtClassID.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtClassID.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Mã lớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtClassName.Text == "")
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa nhập Tên lớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lkeFaculty.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Khoa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lkeCourse.EditValue == null)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Bạn chưa chọn Khóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _getData();
                bool bresult = false;
                if (_IStatusForm == 1)
                {
                    bresult = _Class.addNewClass(_ClassModelNow);
                }
                else
                {
                    bresult = _Class.updateCurrentClass(_ClassModelNow);
                }

                if (!bresult)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _lstLoadListClass();
                    _IStatusForm = 0;
                    _setStatusForm();
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _IStatusForm = 2;
            _setStatusForm();
            txtClassID.Focus();
        }
    }
}
