namespace ManageProjectStudent_View
{
    partial class frmManageFaculty
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDFaculty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvFacultyList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameFaculty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.grbInformationFaculty = new System.Windows.Forms.GroupBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtFacultyName = new System.Windows.Forms.TextBox();
            this.dteYearFounded = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFacultyList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.grbInformationFaculty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteYearFounded.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteYearFounded.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(312, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 18);
            this.label8.TabIndex = 36;
            this.label8.Text = "Năm Thành Lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(312, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "Tên khoa";
            // 
            // txtIDFaculty
            // 
            this.txtIDFaculty.Location = new System.Drawing.Point(432, 52);
            this.txtIDFaculty.Name = "txtIDFaculty";
            this.txtIDFaculty.Size = new System.Drawing.Size(248, 20);
            this.txtIDFaculty.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(312, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "ID Khoa";
            // 
            // gvFacultyList
            // 
            this.gvFacultyList.Appearance.EvenRow.BackColor = System.Drawing.Color.Silver;
            this.gvFacultyList.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvFacultyList.Appearance.EvenRow.Options.UseFont = true;
            this.gvFacultyList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvFacultyList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvFacultyList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvFacultyList.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvFacultyList.Appearance.OddRow.Options.UseFont = true;
            this.gvFacultyList.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvFacultyList.Appearance.Row.Options.UseFont = true;
            this.gvFacultyList.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvFacultyList.Appearance.SelectedRow.Options.UseFont = true;
            this.gvFacultyList.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvFacultyList.Appearance.ViewCaption.Options.UseFont = true;
            this.gvFacultyList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colNameFaculty,
            this.colYear});
            this.gvFacultyList.GridControl = this.gridControl1;
            this.gvFacultyList.Name = "gvFacultyList";
            this.gvFacultyList.OptionsBehavior.Editable = false;
            this.gvFacultyList.OptionsSelection.MultiSelect = true;
            this.gvFacultyList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvFacultyList.OptionsView.EnableAppearanceOddRow = true;
            this.gvFacultyList.OptionsView.ShowAutoFilterRow = true;
            this.gvFacultyList.OptionsView.ShowGroupPanel = false;
            this.gvFacultyList.OptionsView.ShowViewCaption = true;
            this.gvFacultyList.ViewCaption = "Danh sách khoa";
            // 
            // colID
            // 
            this.colID.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colID.AppearanceCell.Options.UseFont = true;
            this.colID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colID.AppearanceHeader.Options.UseFont = true;
            this.colID.Caption = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colNameFaculty
            // 
            this.colNameFaculty.AppearanceHeader.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNameFaculty.AppearanceHeader.Options.UseFont = true;
            this.colNameFaculty.Caption = "Tên khoa";
            this.colNameFaculty.Name = "colNameFaculty";
            this.colNameFaculty.Visible = true;
            this.colNameFaculty.VisibleIndex = 1;
            // 
            // colYear
            // 
            this.colYear.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colYear.AppearanceCell.Options.UseFont = true;
            this.colYear.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colYear.AppearanceHeader.Options.UseFont = true;
            this.colYear.Caption = "Năm";
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(5, 26);
            this.gridControl1.MainView = this.gvFacultyList;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(924, 208);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFacultyList});
            // 
            // grbInformationFaculty
            // 
            this.grbInformationFaculty.Controls.Add(this.dteYearFounded);
            this.grbInformationFaculty.Controls.Add(this.txtFacultyName);
            this.grbInformationFaculty.Controls.Add(this.btnSave);
            this.grbInformationFaculty.Controls.Add(this.btnUpdate);
            this.grbInformationFaculty.Controls.Add(this.btnDelete);
            this.grbInformationFaculty.Controls.Add(this.btnAdd);
            this.grbInformationFaculty.Controls.Add(this.label8);
            this.grbInformationFaculty.Controls.Add(this.label4);
            this.grbInformationFaculty.Controls.Add(this.txtIDFaculty);
            this.grbInformationFaculty.Controls.Add(this.label1);
            this.grbInformationFaculty.Location = new System.Drawing.Point(12, 12);
            this.grbInformationFaculty.Name = "grbInformationFaculty";
            this.grbInformationFaculty.Size = new System.Drawing.Size(934, 327);
            this.grbInformationFaculty.TabIndex = 10;
            this.grbInformationFaculty.TabStop = false;
            this.grbInformationFaculty.Text = "Quản lí thông tin";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnSave.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.AppearanceHovered.Options.UseBackColor = true;
            this.btnSave.AppearanceHovered.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.Location = new System.Drawing.Point(710, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 28);
            this.btnSave.TabIndex = 125;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Lưu";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Appearance.Options.UseBackColor = true;
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Appearance.Options.UseForeColor = true;
            this.btnUpdate.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnUpdate.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.AppearanceHovered.Options.UseBackColor = true;
            this.btnUpdate.AppearanceHovered.Options.UseFont = true;
            this.btnUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnUpdate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnUpdate.Location = new System.Drawing.Point(521, 267);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 28);
            this.btnUpdate.TabIndex = 124;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Sửa ";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnDelete.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.AppearanceHovered.Options.UseBackColor = true;
            this.btnDelete.AppearanceHovered.Options.UseFont = true;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDelete.Location = new System.Drawing.Point(331, 267);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 28);
            this.btnDelete.TabIndex = 123;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Xóa";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnAdd.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.AppearanceHovered.Options.UseBackColor = true;
            this.btnAdd.AppearanceHovered.Options.UseFont = true;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAdd.Location = new System.Drawing.Point(129, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 28);
            this.btnAdd.TabIndex = 122;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Thêm";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 345);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(934, 248);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Danh sách ";
            // 
            // txtFacultyName
            // 
            this.txtFacultyName.Location = new System.Drawing.Point(432, 183);
            this.txtFacultyName.Name = "txtFacultyName";
            this.txtFacultyName.Size = new System.Drawing.Size(248, 20);
            this.txtFacultyName.TabIndex = 126;
            // 
            // dteYearFounded
            // 
            this.dteYearFounded.EditValue = null;
            this.dteYearFounded.Location = new System.Drawing.Point(432, 122);
            this.dteYearFounded.Name = "dteYearFounded";
            this.dteYearFounded.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteYearFounded.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteYearFounded.Size = new System.Drawing.Size(248, 20);
            this.dteYearFounded.TabIndex = 127;
            // 
            // frmManageFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 640);
            this.Controls.Add(this.grbInformationFaculty);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageFaculty";
            this.Text = "frmManageFaculty";
            ((System.ComponentModel.ISupportInitialize)(this.gvFacultyList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.grbInformationFaculty.ResumeLayout(false);
            this.grbInformationFaculty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dteYearFounded.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteYearFounded.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDFaculty;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colNameFaculty;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFacultyList;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.GroupBox grbInformationFaculty;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.TextBox txtFacultyName;
        private DevExpress.XtraEditors.DateEdit dteYearFounded;
    }
}