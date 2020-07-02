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
    public partial class frmManageProject : Form
    {
        private bool indicatorIcon = true;
        // Thong
        private IManageProject IMP = Config.Container.Resolve<IManageProject>();
        // Thong
        public frmManageProject()
        {
            InitializeComponent();
        }
        #region Properties
        private int _IStatusForm = 0;
        private ProjectModel _ProjectModelNow;
        private BindingList<ProjectModel> _lstProject = new BindingList<ProjectModel>();
        private BindingList<SubjectModel> _lstSubject = new BindingList<SubjectModel>();
        #endregion
        #region Method
        private void _setStatusForm()
        {
            txtID.ReadOnly = true;
            switch (_IStatusForm)
            {
                case 0:
                    grpInformationProject.Enabled = false;
                    grpInformationProject.Enabled = true;
                    break;
                case 1:
                    txtID.Text = string.Empty;
                    txtProjectName.Text = string.Empty;
                    dteStartDay.EditValue = null;
                    dteEndDay.EditValue = null;

                    grpInformationProject.Enabled = true;

                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnSave.Enabled = true;
                    break;
                case 2:
                    grpInformationProject.Enabled = true;
                    break;
            }    
        }

        private void _loadData()
        {
            if(_ProjectModelNow==null)
            {
                txtID.Text = string.Empty;
                txtProjectName.Text = string.Empty;
                dteStartDay.EditValue = null;
                dteEndDay.EditValue = null;
            }
            else
            {
                txtID.Text = _ProjectModelNow.StrProjectID;
                txtProjectName.Text = _ProjectModelNow.StrProjectName;
                dteStartDay.EditValue = _ProjectModelNow.DtStartDay.Date;
                dteEndDay.EditValue = _ProjectModelNow.DtStartDay.Date;
            }    
        }

        private void _getData()
        {
            if (_ProjectModelNow == null)
            {
                _ProjectModelNow = new ProjectModel();
            }
            _ProjectModelNow.StrProjectID = txtID.Text;
            _ProjectModelNow.StrProjectName = txtProjectName.Text;

        }
        #endregion
        #region Event
        //load
        private void frmManageProject_Load(object sender, EventArgs e)
        {
            dteStartDay.EditValue = DateTime.Now.Date;
            dteEndDay.EditValue = DateTime.Now.Date;

            

        }

        //selection changed
        private void gvListProject_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

        }

        //exit form
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageProjectMain frmManageProjectMain = new frmManageProjectMain();
            frmManageProjectMain.ShowDialog();
            this.Close();
        }

        //click
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProjectName.Text == "")
            {
                string _STRMesge = "Bạn chưa nhập tên Project";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (lkeSubject.EditValue == null)
            {
                string _STRMesge = "Bạn chưa chọn Môn học";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteStartDay.EditValue == null)
            {
                string _STRMesge = "Bạn chưa chọn Ngày bắt đầu";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dteEndDay.EditValue == null)
            {
                string _STRMesge = "Bạn chưa chọn Ngày kết thúc";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        //keypress
        private void txtProjectName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!GarenaViewModel._checkCharacterChar(e.KeyChar))
            {
                e.Handled = true;
                ((TextBox)sender).Focus();
                string _STRMesge = "Không được nhập ký tự số, chỉ được nhập chữ.";
                MessageBox.Show(_STRMesge, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //stt
        private void gvListProject_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
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

        private void gvListProject_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 20;
        }
        #endregion
    }
}
