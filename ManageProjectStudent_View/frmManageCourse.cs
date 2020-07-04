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
using ManageProjectStudent_Model;
using ManageProjectStudent_ViewModel;
using Unity;

namespace ManageProjectStudent_View
{
    public partial class frmManageCourse : Form
    {
        public frmManageCourse()
        {
            InitializeComponent();
        }
        #region Properties
        private ICourse _Course = Config.Container.Resolve<ICourse>();
        private IClass _Class = Config.Container.Resolve<IClass>();

        private int _IStatusForm = 0;
        private CourseModel _CourseModelNow;
        private BindingList<CourseModel> _lstCourse = new BindingList<CourseModel>();
        private BindingList<SubjectModel> _lstSubject = new BindingList<SubjectModel>();
        #endregion

          private void _setStatusForm()
        {
            //txtID.ReadOnly = true;
            switch (_IStatusForm)
            {
                case 0: // View
                    gcInformation.Enabled = false;
                    //btnSave.Enabled = false;
                    if (_CourseModelNow != null)
                    {
                        btnUpdate.Enabled =true;
                        btnDelete.Enabled = true;
                    }
                    else
                    {
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                    }    
                    break;
                case 1: // Add.
                    txtIDCourse.Text = string.Empty;
                    dtStartYear.EditValue = null;
                    dtEndYear.EditValue = null;

                    gcInformation.Enabled = true;

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    break;
                case 2: // Update
                    gcInformation.Enabled = true;
                    btnSave.Enabled = true;
                    break;
            }
        }
        private void _loadData()
        {
            if (_CourseModelNow == null)
            {
                txtIDCourse.Text = string.Empty;
                dtStartYear.EditValue = null;
                dtEndYear.EditValue = null; 
            }
            else
            {
                txtIDCourse.Text = _CourseModelNow.StrCourseID;
                dtStartYear.EditValue = _CourseModelNow.DtStartYear.Date;
                dtEndYear.EditValue = _CourseModelNow.DtEndYear.Date;
            }
        }
        private void _lstLoadListCourse()
        {
            _lstCourse = _Course.loadCourse();
            //if(_lstLecturer.Count>0)
            //{
            //    foreach(StaffModel lt in _lstLecturer)
            //    {
            //        if (lt.StrStaffID == "LT1")
            //        {
            //            _lstLecturer.Remove(lt);
            //            break;
            //        }
            //    }
            //}
           // gcListCourse.DataSource = _lstCourse;
        }
        private void _getData()
        {
            if (_CourseModelNow == null)
            {
                _CourseModelNow = new CourseModel();
            }
            _CourseModelNow.StrCourseID = txtIDCourse.Text;
            _CourseModelNow.DtEndYear = (DateTime)dtEndYear.EditValue;
            _CourseModelNow.DtStartYear = (DateTime)dtStartYear.EditValue;

        }

        private void frmManageCourse_Load(object sender, EventArgs e)
        {
            dtStartYear.EditValue = DateTime.Now.Date;
            dtEndYear.EditValue = DateTime.Now.Date;
            _lstCourse = _Course.loadCourse();

            ///*GridView*/
            _lstCourse = _Course.loadCourse();

            //LookUpEdit_Faculty.DataSource = _lstFaculty;
            //LookUpEdit_Faculty.Columns["colFacultyID"].FieldName = "StrFacultyID";
            //LookUpEdit_Faculty.Columns["colFacultyName"].FieldName = "StrFacultyName";

            //gcListLecturer.DataSource = _lstLecturer;
            _setStatusForm();
        }
    }
}
