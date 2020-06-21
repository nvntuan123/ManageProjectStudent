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

namespace ManageProjectStudent_View
{
    public partial class frmManageStudentInformation : Form
    {
        private bool indicatorIcon = true;
        private IManageStudentInformation IMSI = Config.Container.Resolve<IManageStudentInformation>();
        public frmManageStudentInformation()
        {
            InitializeComponent();
            // Thong
            txtPhoneNumber.KeyPress += new KeyPressEventHandler(IMSI.txtPhoneNumber_KeyPress);
            txtID.KeyPress += new KeyPressEventHandler(IMSI.txtID_KeyPress);
            txtFullName.KeyPress += new KeyPressEventHandler(IMSI.txtFullName_KeyPress);
            txtEmail.KeyPress += new KeyPressEventHandler(IMSI.txtEmail_KeyPress);
            txtIDCard.KeyPress += new KeyPressEventHandler(IMSI.txtIDCard_KeyPress);
            txtAddress.KeyPress += new KeyPressEventHandler(IMSI.txtAddress_KeyPress);
            radNam.CheckedChanged += new EventHandler(IMSI.radNam_CheckedChanged);
            radNu.CheckedChanged += new EventHandler(IMSI.radNu_CheckedChanged);
            // Thong
            // Thu
            btnSaveStudent.Click += delegate { IMSI.btnSaveStudent_Click(txtID, txtFullName, dteBirthday, radNam, radNu, txtPhoneNumber, txtEmail, txtIDCard, txtAddress, radAvailable, radUnavailable, lkeCourse, lkeClass, lkeFaculty); };
            // Thu
        }

        // STT
        private void gv_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void gv_RowCountChanged(object sender, EventArgs e)
        {
            GridView gridview = ((GridView)sender);
            if (!gridview.GridControl.IsHandleCreated) return;
            Graphics gr = Graphics.FromHwnd(gridview.GridControl.Handle);
            SizeF size = gr.MeasureString(gridview.RowCount.ToString(), gridview.PaintAppearance.Row.GetFont());
            gridview.IndicatorWidth = Convert.ToInt32(size.Width + 0.999f) + GridPainter.Indicator.ImageSize.Width + 20;
        }
        // STT
    }
}
