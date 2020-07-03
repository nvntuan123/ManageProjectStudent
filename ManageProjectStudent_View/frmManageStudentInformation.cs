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

namespace ManageProjectStudent_View
{
    public partial class frmManageStudentInformation : Form
    {
        public frmManageStudentInformation()
        {
            InitializeComponent();
        }
        #region Properties
        private bool indicatorIcon = true;
        private IStudent _Student = Config.Container.Resolve<IStudent>();
        private int _IStatusForm = 0;
        private StudentModel _StudentModelNow = null;
        private BindingList<StudentModel> _lstStudent = new BindingList<StudentModel>();
        private BindingList<FacultyModel> _lstFaculty = new BindingList<FacultyModel>();
        private BindingList<ClassModel> _lstClass = new BindingList<ClassModel>();
        #endregion
        #region Method
        #endregion
        #region Event
        #endregion
    }
}
       
