namespace ManageProjectStudent_GUI
{
    partial class frmDecentralization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDecentralization));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnExitFormManageLecturer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.colMenu = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAdd = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colEdit = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDelete = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDisabled = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.gcPhanQuyen = new DevExpress.XtraGrid.GridControl();
            this.gvPhanQuyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLoaiNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucNang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_Frm = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colFull = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit_Full = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colThem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit_Them = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colSua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit_Sua = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit_Xoa = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colXem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit_Xem = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.grpNguoiSungDung = new DevExpress.XtraEditors.GroupControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Frm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Full)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Them)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Sua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Xem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNguoiSungDung)).BeginInit();
            this.grpNguoiSungDung.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(174, 564);
            this.panelMenu.TabIndex = 4;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(174, 87);
            this.panelLogo.TabIndex = 5;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.panelTitleBar.Controls.Add(this.btnExitFormManageLecturer);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleBar.Location = new System.Drawing.Point(174, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1044, 87);
            this.panelTitleBar.TabIndex = 5;
            // 
            // btnExitFormManageLecturer
            // 
            this.btnExitFormManageLecturer.FlatAppearance.BorderSize = 0;
            this.btnExitFormManageLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormManageLecturer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFormManageLecturer.ForeColor = System.Drawing.Color.White;
            this.btnExitFormManageLecturer.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFormManageLecturer.Image")));
            this.btnExitFormManageLecturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitFormManageLecturer.Location = new System.Drawing.Point(974, 0);
            this.btnExitFormManageLecturer.Name = "btnExitFormManageLecturer";
            this.btnExitFormManageLecturer.Size = new System.Drawing.Size(70, 84);
            this.btnExitFormManageLecturer.TabIndex = 7;
            this.btnExitFormManageLecturer.UseVisualStyleBackColor = true;
            this.btnExitFormManageLecturer.Click += new System.EventHandler(this.btnExitFormManageLecturer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(436, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(124, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Phân Quyền";
            // 
            // colMenu
            // 
            this.colMenu.Caption = "Menu";
            this.colMenu.FieldName = "Menu";
            this.colMenu.Name = "colMenu";
            this.colMenu.Visible = true;
            this.colMenu.VisibleIndex = 0;
            this.colMenu.Width = 78;
            // 
            // colAdd
            // 
            this.colAdd.Caption = "Add";
            this.colAdd.FieldName = "Thêm";
            this.colAdd.Name = "colAdd";
            this.colAdd.Visible = true;
            this.colAdd.VisibleIndex = 1;
            this.colAdd.Width = 82;
            // 
            // colEdit
            // 
            this.colEdit.Caption = "Edit";
            this.colEdit.FieldName = "Sửa";
            this.colEdit.Name = "colEdit";
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 2;
            this.colEdit.Width = 82;
            // 
            // colDelete
            // 
            this.colDelete.Caption = "Delete";
            this.colDelete.FieldName = "Xóa";
            this.colDelete.Name = "colDelete";
            this.colDelete.Visible = true;
            this.colDelete.VisibleIndex = 3;
            this.colDelete.Width = 81;
            // 
            // colDisabled
            // 
            this.colDisabled.Caption = "Disabled";
            this.colDisabled.FieldName = "Vô hiệu hóa";
            this.colDisabled.Name = "colDisabled";
            this.colDisabled.Visible = true;
            this.colDisabled.VisibleIndex = 4;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Menu";
            this.treeListColumn1.FieldName = "Menu";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 78;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Add";
            this.treeListColumn2.FieldName = "Thêm";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 82;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Edit";
            this.treeListColumn3.FieldName = "Sửa";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.Visible = true;
            this.treeListColumn3.VisibleIndex = 2;
            this.treeListColumn3.Width = 82;
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Delete";
            this.treeListColumn4.FieldName = "Xóa";
            this.treeListColumn4.Name = "treeListColumn4";
            this.treeListColumn4.Visible = true;
            this.treeListColumn4.VisibleIndex = 3;
            this.treeListColumn4.Width = 81;
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "Disabled";
            this.treeListColumn5.FieldName = "Vô hiệu hóa";
            this.treeListColumn5.Name = "treeListColumn5";
            this.treeListColumn5.Visible = true;
            this.treeListColumn5.VisibleIndex = 4;
            // 
            // gcPhanQuyen
            // 
            this.gcPhanQuyen.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            gridLevelNode1.RelationName = "Level1";
            this.gcPhanQuyen.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcPhanQuyen.Location = new System.Drawing.Point(448, 128);
            this.gcPhanQuyen.MainView = this.gvPhanQuyen;
            this.gcPhanQuyen.Margin = new System.Windows.Forms.Padding(4);
            this.gcPhanQuyen.Name = "gcPhanQuyen";
            this.gcPhanQuyen.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit_Them,
            this.repositoryItemCheckEdit_Sua,
            this.repositoryItemCheckEdit_Xoa,
            this.repositoryItemCheckEdit_Xem,
            this.repositoryItemLookUpEdit_Frm,
            this.repositoryItemCheckEdit_Full});
            this.gcPhanQuyen.Size = new System.Drawing.Size(762, 383);
            this.gcPhanQuyen.TabIndex = 15;
            this.gcPhanQuyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhanQuyen});
            // 
            // gvPhanQuyen
            // 
            this.gvPhanQuyen.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvPhanQuyen.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhanQuyen.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvPhanQuyen.Appearance.EvenRow.Options.UseFont = true;
            this.gvPhanQuyen.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhanQuyen.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvPhanQuyen.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvPhanQuyen.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhanQuyen.Appearance.OddRow.Options.UseBackColor = true;
            this.gvPhanQuyen.Appearance.OddRow.Options.UseFont = true;
            this.gvPhanQuyen.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhanQuyen.Appearance.Row.Options.UseFont = true;
            this.gvPhanQuyen.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhanQuyen.Appearance.TopNewRow.Options.UseFont = true;
            this.gvPhanQuyen.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvPhanQuyen.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhanQuyen.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gvPhanQuyen.Appearance.ViewCaption.Options.UseFont = true;
            this.gvPhanQuyen.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLoaiNV,
            this.colChucNang,
            this.colFull,
            this.colThem,
            this.colSua,
            this.colXoa,
            this.colXem});
            this.gvPhanQuyen.GridControl = this.gcPhanQuyen;
            this.gvPhanQuyen.Name = "gvPhanQuyen";
            this.gvPhanQuyen.NewItemRowText = "Thêm Mới";
            this.gvPhanQuyen.OptionsSelection.MultiSelect = true;
            this.gvPhanQuyen.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPhanQuyen.OptionsView.EnableAppearanceOddRow = true;
            this.gvPhanQuyen.OptionsView.ShowGroupPanel = false;
            this.gvPhanQuyen.OptionsView.ShowViewCaption = true;
            this.gvPhanQuyen.ViewCaption = "Phân Quyền";
            // 
            // colMaLoaiNV
            // 
            this.colMaLoaiNV.Caption = "Mã Loại Nhân Viên";
            this.colMaLoaiNV.FieldName = "strMaLoaiNV";
            this.colMaLoaiNV.Name = "colMaLoaiNV";
            // 
            // colChucNang
            // 
            this.colChucNang.AppearanceCell.Options.UseTextOptions = true;
            this.colChucNang.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colChucNang.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colChucNang.Caption = "Chức Năng";
            this.colChucNang.ColumnEdit = this.repositoryItemLookUpEdit_Frm;
            this.colChucNang.FieldName = "strMaFrm";
            this.colChucNang.Name = "colChucNang";
            this.colChucNang.OptionsColumn.AllowEdit = false;
            this.colChucNang.Visible = true;
            this.colChucNang.VisibleIndex = 0;
            this.colChucNang.Width = 227;
            // 
            // repositoryItemLookUpEdit_Frm
            // 
            this.repositoryItemLookUpEdit_Frm.AutoHeight = false;
            this.repositoryItemLookUpEdit_Frm.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_Frm.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colMaFrm", "Mã Form"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colTenFrm", "Chức Năng")});
            this.repositoryItemLookUpEdit_Frm.DisplayMember = "strTenFrm";
            this.repositoryItemLookUpEdit_Frm.Name = "repositoryItemLookUpEdit_Frm";
            this.repositoryItemLookUpEdit_Frm.NullText = "Chức Năng";
            this.repositoryItemLookUpEdit_Frm.ValueMember = "strMaFrm";
            // 
            // colFull
            // 
            this.colFull.Caption = "Full";
            this.colFull.ColumnEdit = this.repositoryItemCheckEdit_Full;
            this.colFull.FieldName = "bFull";
            this.colFull.Name = "colFull";
            // 
            // repositoryItemCheckEdit_Full
            // 
            this.repositoryItemCheckEdit_Full.AutoHeight = false;
            this.repositoryItemCheckEdit_Full.Name = "repositoryItemCheckEdit_Full";
            // 
            // colThem
            // 
            this.colThem.AppearanceCell.BackColor = System.Drawing.Color.Transparent;
            this.colThem.AppearanceCell.Options.UseBackColor = true;
            this.colThem.AppearanceHeader.BackColor = System.Drawing.Color.Transparent;
            this.colThem.AppearanceHeader.Options.UseBackColor = true;
            this.colThem.Caption = "Thêm";
            this.colThem.ColumnEdit = this.repositoryItemCheckEdit_Them;
            this.colThem.FieldName = "bThem";
            this.colThem.Name = "colThem";
            this.colThem.Visible = true;
            this.colThem.VisibleIndex = 1;
            this.colThem.Width = 131;
            // 
            // repositoryItemCheckEdit_Them
            // 
            this.repositoryItemCheckEdit_Them.AutoHeight = false;
            this.repositoryItemCheckEdit_Them.Name = "repositoryItemCheckEdit_Them";
            this.repositoryItemCheckEdit_Them.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colSua
            // 
            this.colSua.Caption = "Sửa";
            this.colSua.ColumnEdit = this.repositoryItemCheckEdit_Sua;
            this.colSua.FieldName = "bSua";
            this.colSua.Name = "colSua";
            this.colSua.Visible = true;
            this.colSua.VisibleIndex = 3;
            this.colSua.Width = 131;
            // 
            // repositoryItemCheckEdit_Sua
            // 
            this.repositoryItemCheckEdit_Sua.AutoHeight = false;
            this.repositoryItemCheckEdit_Sua.Name = "repositoryItemCheckEdit_Sua";
            this.repositoryItemCheckEdit_Sua.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colXoa
            // 
            this.colXoa.Caption = "Xóa";
            this.colXoa.ColumnEdit = this.repositoryItemCheckEdit_Xoa;
            this.colXoa.FieldName = "bXoa";
            this.colXoa.Name = "colXoa";
            this.colXoa.Visible = true;
            this.colXoa.VisibleIndex = 2;
            this.colXoa.Width = 131;
            // 
            // repositoryItemCheckEdit_Xoa
            // 
            this.repositoryItemCheckEdit_Xoa.AutoHeight = false;
            this.repositoryItemCheckEdit_Xoa.Name = "repositoryItemCheckEdit_Xoa";
            this.repositoryItemCheckEdit_Xoa.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colXem
            // 
            this.colXem.Caption = "Xem";
            this.colXem.ColumnEdit = this.repositoryItemCheckEdit_Xem;
            this.colXem.FieldName = "bXem";
            this.colXem.Name = "colXem";
            this.colXem.Visible = true;
            this.colXem.VisibleIndex = 4;
            this.colXem.Width = 131;
            // 
            // repositoryItemCheckEdit_Xem
            // 
            this.repositoryItemCheckEdit_Xem.AutoHeight = false;
            this.repositoryItemCheckEdit_Xem.Name = "repositoryItemCheckEdit_Xem";
            this.repositoryItemCheckEdit_Xem.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // grpNguoiSungDung
            // 
            this.grpNguoiSungDung.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpNguoiSungDung.Appearance.Options.UseFont = true;
            this.grpNguoiSungDung.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpNguoiSungDung.AppearanceCaption.Options.UseFont = true;
            this.grpNguoiSungDung.Controls.Add(this.comboBox1);
            this.grpNguoiSungDung.Location = new System.Drawing.Point(181, 129);
            this.grpNguoiSungDung.Margin = new System.Windows.Forms.Padding(4);
            this.grpNguoiSungDung.Name = "grpNguoiSungDung";
            this.grpNguoiSungDung.Size = new System.Drawing.Size(261, 383);
            this.grpNguoiSungDung.TabIndex = 16;
            this.grpNguoiSungDung.Text = "Người Sử Dụng";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 26);
            this.comboBox1.TabIndex = 0;
            // 
            // frmDecentralization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 564);
            this.Controls.Add(this.gcPhanQuyen);
            this.Controls.Add(this.grpNguoiSungDung);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDecentralization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDecentralization";
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_Frm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Full)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Them)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Sua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit_Xem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNguoiSungDung)).EndInit();
            this.grpNguoiSungDung.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colMenu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAdd;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colEdit;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDelete;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDisabled;
        private System.Windows.Forms.Button btnExitFormManageLecturer;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraGrid.GridControl gcPhanQuyen;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhanQuyen;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiNV;
        private DevExpress.XtraGrid.Columns.GridColumn colChucNang;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_Frm;
        private DevExpress.XtraGrid.Columns.GridColumn colFull;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_Full;
        private DevExpress.XtraGrid.Columns.GridColumn colThem;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_Them;
        private DevExpress.XtraGrid.Columns.GridColumn colSua;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_Sua;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_Xoa;
        private DevExpress.XtraGrid.Columns.GridColumn colXem;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit_Xem;
        private DevExpress.XtraEditors.GroupControl grpNguoiSungDung;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}