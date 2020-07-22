using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using ManageProjectStudent_Interface;
using Unity;
using ManageProjectStudent_ViewModel;
using ManageProjectStudent_Model;
using DevExpress.XtraPrinting;
using DevExpress.Export;
using DevExpress.XtraPrinting.DataNodes;

namespace ManageProjectStudent_View
{
    public partial class frmDecentralization : Form
    {
        public frmDecentralization()
        {
            InitializeComponent();
        }
        #region Properties
        private BindingList<StaffTypeModel> _lstStaffType = new BindingList<StaffTypeModel>();
        private IStaffType _StaffType = Config.Container.Resolve<IStaffType>();

        private BindingList<FormModel> _lstForm = new BindingList<FormModel>();
        private IForm _Form = Config.Container.Resolve<IForm>();

        private StaffModel _StaffModel = null;
        private IDecentralize _Decen = Config.Container.Resolve<IDecentralize>();
        private DecentralizeModel _Decentralize = null;
        private BindingList<DecentralizeModel> _lstDecentralizeModels = new BindingList<DecentralizeModel>();


        bool _BAdd = true;
        bool _BDelete = true;
        bool _BEdit = true;
        bool _BView = true;

        #endregion
        #region Method
        private bool editDecen(BindingList<DecentralizeModel> _lstDecens)
        {
            foreach (DecentralizeModel decen in _lstDecens)
            {
                if (_Decen.updateCurrentDecentralizes(decen) == false)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        private void frmDecentralization_Load(object sender, EventArgs e)
        {
            _StaffModel = frmHome.staffModel;
            if (frmHome.lstDecent != null)
            {
                foreach (DecentralizeModel decen in frmHome.lstDecent)
                {
                    if (_StaffModel.StrStaffTypeID == decen.StrStaffTypeID && this.Name == decen.StrFormID)
                    {
                        _Decentralize = _Decen.getDecentralizeStaffIdForm(decen.StrStaffTypeID, decen.StrFormID);
                        //lookup-edit
                        _lstStaffType = _StaffType.loadStaffType();
                        lkeStaffType.Properties.ValueMember = "StrStaffTypeID";
                        lkeStaffType.Properties.DisplayMember = "StrStaffTypeName";
                        lkeStaffType.Properties.DataSource = _lstStaffType;
                        lkeStaffType.Properties.Columns["colStaffTypeID"].FieldName = "StrStaffTypeID";
                        lkeStaffType.Properties.Columns["colStaffTypeName"].FieldName = "StrStaffTypeName";

                        //Grid-view
                        _lstForm = _Form.loadForm();
                        LookUpEdit_Function.DataSource = _lstForm;
                        LookUpEdit_Function.Columns["colFormID"].FieldName = "StrFormID";
                        LookUpEdit_Function.Columns["colFormName"].FieldName = "StrFormName";
                        gcListFunction.DataSource = _lstForm;
                        break;
                    }
                }
            }
        }

        private void lkeStaffType_EditValueChanged(object sender, EventArgs e)
        {
            if (lkeStaffType.EditValue != null)
            {
                string _STR_StaffTypeID = lkeStaffType.EditValue.ToString();
                if (_STR_StaffTypeID == _StaffModel.StrStaffTypeID)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Không Cần Phân Quyền Cho Chính Mình", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lkeStaffType.EditValue = null;
                }
                else
                {
                    _lstDecentralizeModels = _Decen.getListDecentralizeStaff(lkeStaffType.EditValue.ToString());

                    if (_lstDecentralizeModels != null && _StaffModel != null)
                    {
                        if (_StaffModel != null)
                        {
                            gcListFunction.DataSource = _lstDecentralizeModels;
                            for (int i = 0; i < gvListFunction.RowCount; i++)
                            {
                                if ((bool)gvListFunction.GetRowCellValue(i, "BAdd") == false)
                                {
                                    _BAdd = false;
                                }
                                if ((bool)gvListFunction.GetRowCellValue(i, "BDelete") == false)
                                {
                                    _BDelete = false;
                                }
                                if ((bool)gvListFunction.GetRowCellValue(i, "BEdit") == false)
                                {
                                    _BEdit = false;
                                }
                                if ((bool)gvListFunction.GetRowCellValue(i, "BView") == false)
                                {
                                    _BView = false;
                                }
                            }
                        }
                    }
                    else
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lkeStaffType.EditValue != null)
            {
                BindingList<DecentralizeModel> _lstDecentralizes = new BindingList<DecentralizeModel>();
                for (int i = 0; i < gvListFunction.RowCount; i++)
                {
                    DecentralizeModel _Decen = new DecentralizeModel();
                    _Decen.StrStaffTypeID = gvListFunction.GetRowCellValue(i, "StrStaffTypeID").ToString();
                    _Decen.StrFormID = gvListFunction.GetRowCellValue(i, "StrFormID").ToString();
                    _Decen.BAdd = (bool)gvListFunction.GetRowCellValue(i, "BAdd");
                    _Decen.BDelete = (bool)gvListFunction.GetRowCellValue(i, "BDelete");
                    _Decen.BEdit = (bool)gvListFunction.GetRowCellValue(i, "BEdit");
                    _Decen.BView = (bool)gvListFunction.GetRowCellValue(i, "BView");
                    if (_Decen.BAdd && _Decen.BDelete && _Decen.BEdit && _Decen.BView)
                    {
                        _Decen.BFullFuncion = true;
                    }
                    _lstDecentralizes.Add(_Decen);
                }

                if (editDecen(_lstDecentralizes))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Lưu Thành Công");
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Bạn Chưa Chọn Loại Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lkeStaffType.Focus();
                }
            }
        }
    }
}

