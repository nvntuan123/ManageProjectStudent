namespace ManageProjectStudent_View
{
    partial class frmManageClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageClass));
            this.gvClassList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColClassName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrainingProgram = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaculty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEdit4 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit3 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDClass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnExitForm = new System.Windows.Forms.Button();
            this.btnManageStudentInformation = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvClassList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvClassList
            // 
            this.gvClassList.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvClassList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvClassList.Appearance.EvenRow.Options.UseFont = true;
            this.gvClassList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvClassList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvClassList.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvClassList.Appearance.OddRow.Options.UseBackColor = true;
            this.gvClassList.Appearance.OddRow.Options.UseFont = true;
            this.gvClassList.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvClassList.Appearance.Row.Options.UseBackColor = true;
            this.gvClassList.Appearance.Row.Options.UseFont = true;
            this.gvClassList.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvClassList.Appearance.SelectedRow.Options.UseFont = true;
            this.gvClassList.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvClassList.Appearance.ViewCaption.Options.UseFont = true;
            this.gvClassList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.ColClassName,
            this.gridColumn1,
            this.colTrainingProgram,
            this.colRoom,
            this.colFaculty});
            this.gvClassList.GridControl = this.gridControl1;
            this.gvClassList.Name = "gvClassList";
            this.gvClassList.OptionsSelection.MultiSelect = true;
            this.gvClassList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvClassList.OptionsView.EnableAppearanceOddRow = true;
            this.gvClassList.OptionsView.ShowAutoFilterRow = true;
            this.gvClassList.OptionsView.ShowGroupPanel = false;
            this.gvClassList.OptionsView.ShowViewCaption = true;
            this.gvClassList.ViewCaption = "Danh sách lớp";
            // 
            // colID
            // 
            this.colID.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colID.AppearanceCell.Options.UseFont = true;
            this.colID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colID.AppearanceHeader.Options.UseFont = true;
            this.colID.Caption = "Mã lớp";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // ColClassName
            // 
            this.ColClassName.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ColClassName.AppearanceCell.Options.UseFont = true;
            this.ColClassName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ColClassName.AppearanceHeader.Options.UseFont = true;
            this.ColClassName.Caption = "Tên lớp";
            this.ColClassName.Name = "ColClassName";
            this.ColClassName.Visible = true;
            this.ColClassName.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridColumn1.AppearanceCell.Options.UseFont = true;
            this.gridColumn1.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gridColumn1.AppearanceHeader.Options.UseFont = true;
            this.gridColumn1.Caption = "Giáo viên";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            // 
            // colTrainingProgram
            // 
            this.colTrainingProgram.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colTrainingProgram.AppearanceCell.Options.UseFont = true;
            this.colTrainingProgram.Caption = "Chương trình ĐT";
            this.colTrainingProgram.Name = "colTrainingProgram";
            this.colTrainingProgram.Visible = true;
            this.colTrainingProgram.VisibleIndex = 3;
            // 
            // colRoom
            // 
            this.colRoom.Caption = "Phòng";
            this.colRoom.Name = "colRoom";
            this.colRoom.Visible = true;
            this.colRoom.VisibleIndex = 4;
            // 
            // colFaculty
            // 
            this.colFaculty.Caption = "Khoa";
            this.colFaculty.Name = "colFaculty";
            this.colFaculty.Visible = true;
            this.colFaculty.VisibleIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(180, 417);
            this.gridControl1.MainView = this.gvClassList;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1008, 220);
            this.gridControl1.TabIndex = 49;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClassList});
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(573, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 67;
            this.label8.Text = "Phòng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(573, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 66;
            this.label9.Text = "Khoa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(573, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "Giáo viên CN";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(281, 42);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(167, 21);
            this.txtClassName.TabIndex = 74;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(123, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 17);
            this.label10.TabIndex = 65;
            this.label10.Text = "Chương trình ĐT";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton6);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.btnLuu);
            this.groupControl1.Controls.Add(this.lookUpEdit4);
            this.groupControl1.Controls.Add(this.lookUpEdit3);
            this.groupControl1.Controls.Add(this.lookUpEdit2);
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtIDClass);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.txtClassName);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Location = new System.Drawing.Point(180, 93);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1008, 318);
            this.groupControl1.TabIndex = 50;
            this.groupControl1.Text = "Nhập thông tin";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Silver;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.simpleButton2.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton2.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton2.AppearanceHovered.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.Location = new System.Drawing.Point(761, 265);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(127, 28);
            this.simpleButton2.TabIndex = 121;
            this.simpleButton2.TabStop = false;
            this.simpleButton2.Text = "Lưu";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton6.Appearance.BackColor = System.Drawing.Color.Silver;
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton6.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton6.Appearance.Options.UseBackColor = true;
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.Appearance.Options.UseForeColor = true;
            this.simpleButton6.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.simpleButton6.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton6.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton6.AppearanceHovered.Options.UseFont = true;
            this.simpleButton6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton6.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton6.Location = new System.Drawing.Point(572, 265);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(127, 28);
            this.simpleButton6.TabIndex = 120;
            this.simpleButton6.TabStop = false;
            this.simpleButton6.Text = "Sửa ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Silver;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.simpleButton1.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.AppearanceHovered.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.Location = new System.Drawing.Point(382, 265);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(127, 28);
            this.simpleButton1.TabIndex = 119;
            this.simpleButton1.TabStop = false;
            this.simpleButton1.Text = "Xóa";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Appearance.Options.UseBackColor = true;
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnLuu.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.AppearanceHovered.Options.UseBackColor = true;
            this.btnLuu.AppearanceHovered.Options.UseFont = true;
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnLuu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLuu.Location = new System.Drawing.Point(180, 265);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(127, 28);
            this.btnLuu.TabIndex = 118;
            this.btnLuu.TabStop = false;
            this.btnLuu.Text = "Thêm";
            // 
            // lookUpEdit4
            // 
            this.lookUpEdit4.Location = new System.Drawing.Point(729, 192);
            this.lookUpEdit4.Name = "lookUpEdit4";
            this.lookUpEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit4.Size = new System.Drawing.Size(167, 20);
            this.lookUpEdit4.TabIndex = 80;
            // 
            // lookUpEdit3
            // 
            this.lookUpEdit3.Location = new System.Drawing.Point(729, 119);
            this.lookUpEdit3.Name = "lookUpEdit3";
            this.lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit3.Size = new System.Drawing.Size(167, 20);
            this.lookUpEdit3.TabIndex = 79;
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(729, 39);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Size = new System.Drawing.Size(167, 20);
            this.lookUpEdit2.TabIndex = 78;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(281, 195);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(167, 20);
            this.lookUpEdit1.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(123, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 75;
            this.label2.Text = "Mã lớp";
            // 
            // txtIDClass
            // 
            this.txtIDClass.Location = new System.Drawing.Point(281, 115);
            this.txtIDClass.Name = "txtIDClass";
            this.txtIDClass.Size = new System.Drawing.Size(167, 21);
            this.txtIDClass.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(123, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "Tên lớp";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnExitForm);
            this.panelMenu.Controls.Add(this.btnManageStudentInformation);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(174, 640);
            this.panelMenu.TabIndex = 51;
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
            this.panelLogo.TabIndex = 7;
            // 
            // btnExitForm
            // 
            this.btnExitForm.FlatAppearance.BorderSize = 0;
            this.btnExitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitForm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitForm.ForeColor = System.Drawing.Color.White;
            this.btnExitForm.Image = ((System.Drawing.Image)(resources.GetObject("btnExitForm.Image")));
            this.btnExitForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitForm.Location = new System.Drawing.Point(3, 152);
            this.btnExitForm.Name = "btnExitForm";
            this.btnExitForm.Size = new System.Drawing.Size(171, 50);
            this.btnExitForm.TabIndex = 6;
            this.btnExitForm.Text = "Thoát";
            this.btnExitForm.UseVisualStyleBackColor = true;
            // 
            // btnManageStudentInformation
            // 
            this.btnManageStudentInformation.FlatAppearance.BorderSize = 0;
            this.btnManageStudentInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStudentInformation.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStudentInformation.ForeColor = System.Drawing.Color.White;
            this.btnManageStudentInformation.Image = ((System.Drawing.Image)(resources.GetObject("btnManageStudentInformation.Image")));
            this.btnManageStudentInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageStudentInformation.Location = new System.Drawing.Point(0, 93);
            this.btnManageStudentInformation.Name = "btnManageStudentInformation";
            this.btnManageStudentInformation.Size = new System.Drawing.Size(174, 50);
            this.btnManageStudentInformation.TabIndex = 2;
            this.btnManageStudentInformation.Text = "Quản lí thông tin";
            this.btnManageStudentInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageStudentInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageStudentInformation.UseVisualStyleBackColor = true;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleBar.Location = new System.Drawing.Point(174, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1026, 87);
            this.panelTitleBar.TabIndex = 52;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 87);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(385, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý lớp";
            // 
            // frmManageClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 640);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageClass";
            this.Text = "frmManageClass";
            ((System.ComponentModel.ISupportInitialize)(this.gvClassList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gvClassList;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn ColClassName;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDClass;
        private System.Windows.Forms.Label label5;
        
        
        private DevExpress.XtraGrid.Columns.GridColumn colTrainingProgram;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colRoom;
        private DevExpress.XtraGrid.Columns.GridColumn colFaculty;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnExitForm;
        private System.Windows.Forms.Button btnManageStudentInformation;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit4;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}