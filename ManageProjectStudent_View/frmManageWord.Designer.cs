﻿namespace ManageProjectStudent_View
{
    partial class frmManageWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageWord));
            this.panelMenu = new System.Windows.Forms.Panel();
<<<<<<< HEAD
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnExitFormManageLecturer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtIDLanguage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gcListStudent = new DevExpress.XtraGrid.GridControl();
            this.gvStudentList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWordID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWordName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Class = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Class)).BeginInit();
=======
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpInformationLanguage = new DevExpress.XtraEditors.GroupControl();
            this.cmbModifyLanguage = new DevExpress.XtraEditors.LookUpEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDefaultLanguage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMean = new System.Windows.Forms.TextBox();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.gcListLecturer = new DevExpress.XtraGrid.GridControl();
            this.gvWordList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLanguageID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit_LanguageID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colWordID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMean = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Faculty = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationLanguage)).BeginInit();
            this.grpInformationLanguage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbModifyLanguage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListLecturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWordList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_LanguageID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Faculty)).BeginInit();
>>>>>>> design form Word, KeyWord, Language
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(77)))));
<<<<<<< HEAD
            this.panelMenu.Controls.Add(this.btnUpdate);
            this.panelMenu.Controls.Add(this.btnDelete);
            this.panelMenu.Controls.Add(this.panelLogo);
=======
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnUpdate);
            this.panelMenu.Controls.Add(this.btnDelete);
>>>>>>> design form Word, KeyWord, Language
            this.panelMenu.Controls.Add(this.btnAdd);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
<<<<<<< HEAD
            this.panelMenu.Size = new System.Drawing.Size(174, 552);
            this.panelMenu.TabIndex = 47;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.panelMenu.Size = new System.Drawing.Size(174, 562);
            this.panelMenu.TabIndex = 6;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(174, 94);
            this.panelLogo.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> design form Word, KeyWord, Language
            this.btnUpdate.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Appearance.Options.UseBackColor = true;
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Appearance.Options.UseForeColor = true;
            this.btnUpdate.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnUpdate.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.AppearanceHovered.Options.UseBackColor = true;
            this.btnUpdate.AppearanceHovered.Options.UseFont = true;
            this.btnUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
<<<<<<< HEAD
            this.btnUpdate.Location = new System.Drawing.Point(0, 384);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(171, 54);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Sửa Từ";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.btnUpdate.Location = new System.Drawing.Point(0, 373);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(174, 69);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Sửa";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> design form Word, KeyWord, Language
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnDelete.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelete.AppearanceHovered.Options.UseBackColor = true;
            this.btnDelete.AppearanceHovered.Options.UseFont = true;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
<<<<<<< HEAD
            this.btnDelete.Location = new System.Drawing.Point(0, 470);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 54);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Xóa từ";
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
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
=======
            this.btnDelete.Location = new System.Drawing.Point(0, 465);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(174, 69);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Xóa";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> design form Word, KeyWord, Language
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnAdd.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAdd.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnAdd.AppearanceHovered.Options.UseBackColor = true;
            this.btnAdd.AppearanceHovered.Options.UseFont = true;
            this.btnAdd.AppearanceHovered.Options.UseForeColor = true;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
<<<<<<< HEAD
            this.btnAdd.Location = new System.Drawing.Point(0, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(171, 54);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Thêm Từ";
=======
            this.btnAdd.Location = new System.Drawing.Point(0, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(174, 69);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Thêm";
>>>>>>> design form Word, KeyWord, Language
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
<<<<<<< HEAD
            this.panelTitleBar.Controls.Add(this.btnReLoad);
            this.panelTitleBar.Controls.Add(this.btnExitFormManageLecturer);
=======
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.btnReLoad);
>>>>>>> design form Word, KeyWord, Language
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleBar.Location = new System.Drawing.Point(174, 0);
            this.panelTitleBar.Name = "panelTitleBar";
<<<<<<< HEAD
            this.panelTitleBar.Size = new System.Drawing.Size(764, 87);
            this.panelTitleBar.TabIndex = 48;
=======
            this.panelTitleBar.Size = new System.Drawing.Size(712, 94);
            this.panelTitleBar.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(642, -2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 94);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = true;
>>>>>>> design form Word, KeyWord, Language
            // 
            // btnReLoad
            // 
            this.btnReLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReLoad.FlatAppearance.BorderSize = 0;
            this.btnReLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReLoad.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.ForeColor = System.Drawing.Color.White;
            this.btnReLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnReLoad.Image")));
            this.btnReLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReLoad.Location = new System.Drawing.Point(0, 0);
            this.btnReLoad.Name = "btnReLoad";
<<<<<<< HEAD
            this.btnReLoad.Size = new System.Drawing.Size(70, 87);
            this.btnReLoad.TabIndex = 7;
            this.btnReLoad.UseVisualStyleBackColor = true;
            // 
            // btnExitFormManageLecturer
            // 
            this.btnExitFormManageLecturer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitFormManageLecturer.FlatAppearance.BorderSize = 0;
            this.btnExitFormManageLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormManageLecturer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFormManageLecturer.ForeColor = System.Drawing.Color.White;
            this.btnExitFormManageLecturer.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFormManageLecturer.Image")));
            this.btnExitFormManageLecturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitFormManageLecturer.Location = new System.Drawing.Point(694, 0);
            this.btnExitFormManageLecturer.Name = "btnExitFormManageLecturer";
            this.btnExitFormManageLecturer.Size = new System.Drawing.Size(70, 87);
            this.btnExitFormManageLecturer.TabIndex = 6;
            this.btnExitFormManageLecturer.UseVisualStyleBackColor = true;
            // 
=======
            this.btnReLoad.Size = new System.Drawing.Size(70, 94);
            this.btnReLoad.TabIndex = 7;
            this.btnReLoad.UseVisualStyleBackColor = true;
            // 
>>>>>>> design form Word, KeyWord, Language
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.lblTitle.Location = new System.Drawing.Point(319, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(106, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý từ";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.textBox2);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.textBox1);
            this.groupControl2.Controls.Add(this.btnSave);
            this.groupControl2.Controls.Add(this.txtIDLanguage);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Location = new System.Drawing.Point(193, 102);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(733, 178);
            this.groupControl2.TabIndex = 49;
            this.groupControl2.Text = "Thông Tin";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 21);
            this.textBox1.TabIndex = 122;
=======
            this.lblTitle.Location = new System.Drawing.Point(294, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Từ";
            // 
            // grpInformationLanguage
            // 
            this.grpInformationLanguage.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpInformationLanguage.Appearance.Options.UseFont = true;
            this.grpInformationLanguage.AppearanceCaption.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpInformationLanguage.AppearanceCaption.Options.UseFont = true;
            this.grpInformationLanguage.Controls.Add(this.cmbModifyLanguage);
            this.grpInformationLanguage.Controls.Add(this.label7);
            this.grpInformationLanguage.Controls.Add(this.lblDefaultLanguage);
            this.grpInformationLanguage.Controls.Add(this.label8);
            this.grpInformationLanguage.Controls.Add(this.label4);
            this.grpInformationLanguage.Controls.Add(this.label3);
            this.grpInformationLanguage.Controls.Add(this.label2);
            this.grpInformationLanguage.Controls.Add(this.txtMean);
            this.grpInformationLanguage.Controls.Add(this.lookUpEdit1);
            this.grpInformationLanguage.Controls.Add(this.txtWord);
            this.grpInformationLanguage.Controls.Add(this.btnSave);
            this.grpInformationLanguage.Location = new System.Drawing.Point(180, 98);
            this.grpInformationLanguage.Name = "grpInformationLanguage";
            this.grpInformationLanguage.Size = new System.Drawing.Size(697, 153);
            this.grpInformationLanguage.TabIndex = 9;
            this.grpInformationLanguage.Text = "Thông Tin Ngôn Ngữ";
            // 
            // cmbModifyLanguage
            // 
            this.cmbModifyLanguage.Location = new System.Drawing.Point(426, 75);
            this.cmbModifyLanguage.Name = "cmbModifyLanguage";
            this.cmbModifyLanguage.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbModifyLanguage.Properties.Appearance.Options.UseFont = true;
            this.cmbModifyLanguage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbModifyLanguage.Size = new System.Drawing.Size(222, 24);
            this.cmbModifyLanguage.TabIndex = 158;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 157;
            this.label7.Text = "Ngôn Ngữ";
            // 
            // lblDefaultLanguage
            // 
            this.lblDefaultLanguage.AutoSize = true;
            this.lblDefaultLanguage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDefaultLanguage.Location = new System.Drawing.Point(422, 37);
            this.lblDefaultLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDefaultLanguage.Name = "lblDefaultLanguage";
            this.lblDefaultLanguage.Size = new System.Drawing.Size(56, 17);
            this.lblDefaultLanguage.TabIndex = 156;
            this.lblDefaultLanguage.Text = "English";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 155;
            this.label8.Text = "Ngôn Ngữ Mặc Định";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 126;
            this.label4.Text = "Mô hình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 125;
            this.label3.Text = "Nghĩa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 124;
            this.label2.Text = "Từ";
            // 
            // txtMean
            // 
            this.txtMean.Location = new System.Drawing.Point(82, 74);
            this.txtMean.Margin = new System.Windows.Forms.Padding(4);
            this.txtMean.Name = "txtMean";
            this.txtMean.Size = new System.Drawing.Size(190, 25);
            this.txtMean.TabIndex = 123;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(82, 118);
            this.lookUpEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(190, 24);
            this.lookUpEdit1.TabIndex = 122;
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(82, 29);
            this.txtWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(190, 25);
            this.txtWord.TabIndex = 121;
>>>>>>> design form Word, KeyWord, Language
            // 
            // btnSave
            // 
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
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
<<<<<<< HEAD
            this.btnSave.Location = new System.Drawing.Point(285, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 36);
            this.btnSave.TabIndex = 121;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Lưu";
            // 
            // txtIDLanguage
            // 
            this.txtIDLanguage.Location = new System.Drawing.Point(293, 36);
            this.txtIDLanguage.Name = "txtIDLanguage";
            this.txtIDLanguage.Size = new System.Drawing.Size(209, 21);
            this.txtIDLanguage.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Từ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã từ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(293, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 21);
            this.textBox2.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 123;
            this.label1.Text = "Module";
            // 
            // gcListStudent
            // 
            this.gcListStudent.Location = new System.Drawing.Point(193, 286);
            this.gcListStudent.MainView = this.gvStudentList;
            this.gcListStudent.Name = "gcListStudent";
            this.gcListStudent.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_Class});
            this.gcListStudent.Size = new System.Drawing.Size(733, 240);
            this.gcListStudent.TabIndex = 50;
            this.gcListStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStudentList});
            // 
            // gvStudentList
            // 
            this.gvStudentList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvStudentList.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvStudentList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvStudentList.Appearance.EvenRow.Options.UseFont = true;
            this.gvStudentList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvStudentList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvStudentList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvStudentList.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvStudentList.Appearance.OddRow.Options.UseBackColor = true;
            this.gvStudentList.Appearance.OddRow.Options.UseFont = true;
            this.gvStudentList.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvStudentList.Appearance.Row.Options.UseFont = true;
            this.gvStudentList.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvStudentList.Appearance.ViewCaption.Options.UseFont = true;
            this.gvStudentList.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvStudentList.AppearancePrint.Row.Options.UseFont = true;
            this.gvStudentList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWordID,
            this.colWordName,
            this.colModule});
            this.gvStudentList.DetailHeight = 377;
            this.gvStudentList.GridControl = this.gcListStudent;
            this.gvStudentList.Name = "gvStudentList";
            this.gvStudentList.OptionsBehavior.Editable = false;
            this.gvStudentList.OptionsSelection.MultiSelect = true;
            this.gvStudentList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvStudentList.OptionsView.EnableAppearanceOddRow = true;
            this.gvStudentList.OptionsView.ShowAutoFilterRow = true;
            this.gvStudentList.OptionsView.ShowGroupPanel = false;
            this.gvStudentList.OptionsView.ShowViewCaption = true;
            this.gvStudentList.ViewCaption = "Danh sách từ";
            // 
            // colWordID
            // 
            this.colWordID.Caption = "Mã từ";
            this.colWordID.Name = "colWordID";
            this.colWordID.Visible = true;
            this.colWordID.VisibleIndex = 0;
            // 
            // colWordName
            // 
            this.colWordName.Caption = "Tên từ";
            this.colWordName.Name = "colWordName";
            this.colWordName.Visible = true;
            this.colWordName.VisibleIndex = 1;
            // 
            // colModule
            // 
            this.colModule.Caption = "Module";
            this.colModule.Name = "colModule";
            this.colModule.Visible = true;
            this.colModule.VisibleIndex = 2;
            // 
            // LookUpEdit_Class
            // 
            this.LookUpEdit_Class.AutoHeight = false;
            this.LookUpEdit_Class.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Class.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colClassName", "Tên lớp"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colClassID", "Mã Lớp", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.LookUpEdit_Class.DisplayMember = "StrClassName";
            this.LookUpEdit_Class.Name = "LookUpEdit_Class";
            this.LookUpEdit_Class.ValueMember = "StrClassID";
            // 
            // frmManageWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 552);
            this.Controls.Add(this.gcListStudent);
            this.Controls.Add(this.groupControl2);
=======
            this.btnSave.Location = new System.Drawing.Point(426, 112);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 35);
            this.btnSave.TabIndex = 120;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Lưu";
            // 
            // gcListLecturer
            // 
            this.gcListLecturer.Location = new System.Drawing.Point(180, 257);
            this.gcListLecturer.MainView = this.gvWordList;
            this.gcListLecturer.Name = "gcListLecturer";
            this.gcListLecturer.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_Faculty,
            this.repositoryItemLookUpEdit_LanguageID});
            this.gcListLecturer.Size = new System.Drawing.Size(697, 300);
            this.gcListLecturer.TabIndex = 11;
            this.gcListLecturer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvWordList});
            // 
            // gvWordList
            // 
            this.gvWordList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvWordList.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvWordList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvWordList.Appearance.EvenRow.Options.UseFont = true;
            this.gvWordList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvWordList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvWordList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvWordList.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvWordList.Appearance.OddRow.Options.UseBackColor = true;
            this.gvWordList.Appearance.OddRow.Options.UseFont = true;
            this.gvWordList.Appearance.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvWordList.Appearance.Row.Options.UseFont = true;
            this.gvWordList.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvWordList.Appearance.ViewCaption.Options.UseFont = true;
            this.gvWordList.AppearancePrint.Row.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvWordList.AppearancePrint.Row.Options.UseFont = true;
            this.gvWordList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLanguageID,
            this.colWordID,
            this.colMean,
            this.colStatus});
            this.gvWordList.DetailHeight = 406;
            this.gvWordList.GridControl = this.gcListLecturer;
            this.gvWordList.Name = "gvWordList";
            this.gvWordList.OptionsBehavior.Editable = false;
            this.gvWordList.OptionsSelection.MultiSelect = true;
            this.gvWordList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvWordList.OptionsView.EnableAppearanceOddRow = true;
            this.gvWordList.OptionsView.ShowAutoFilterRow = true;
            this.gvWordList.OptionsView.ShowGroupPanel = false;
            this.gvWordList.OptionsView.ShowViewCaption = true;
            this.gvWordList.ViewCaption = "Danh Sách Từ";
            // 
            // colLanguageID
            // 
            this.colLanguageID.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colLanguageID.AppearanceCell.Options.UseFont = true;
            this.colLanguageID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLanguageID.AppearanceHeader.Options.UseFont = true;
            this.colLanguageID.Caption = "Ngôn Ngữ";
            this.colLanguageID.ColumnEdit = this.repositoryItemLookUpEdit_LanguageID;
            this.colLanguageID.FieldName = "StrLanguageID";
            this.colLanguageID.Name = "colLanguageID";
            this.colLanguageID.Visible = true;
            this.colLanguageID.VisibleIndex = 0;
            this.colLanguageID.Width = 68;
            // 
            // repositoryItemLookUpEdit_LanguageID
            // 
            this.repositoryItemLookUpEdit_LanguageID.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.repositoryItemLookUpEdit_LanguageID.Appearance.Options.UseFont = true;
            this.repositoryItemLookUpEdit_LanguageID.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.repositoryItemLookUpEdit_LanguageID.AppearanceDropDown.Options.UseFont = true;
            this.repositoryItemLookUpEdit_LanguageID.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.repositoryItemLookUpEdit_LanguageID.AppearanceDropDownHeader.Options.UseFont = true;
            this.repositoryItemLookUpEdit_LanguageID.AutoHeight = false;
            this.repositoryItemLookUpEdit_LanguageID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit_LanguageID.DisplayMember = "StrLanguageName";
            this.repositoryItemLookUpEdit_LanguageID.Name = "repositoryItemLookUpEdit_LanguageID";
            this.repositoryItemLookUpEdit_LanguageID.ValueMember = "StrLanguageID";
            // 
            // colWordID
            // 
            this.colWordID.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colWordID.AppearanceCell.Options.UseFont = true;
            this.colWordID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colWordID.AppearanceHeader.Options.UseFont = true;
            this.colWordID.Caption = "Từ";
            this.colWordID.FieldName = "StrLanguageName";
            this.colWordID.Name = "colWordID";
            this.colWordID.Visible = true;
            this.colWordID.VisibleIndex = 1;
            this.colWordID.Width = 68;
            // 
            // colMean
            // 
            this.colMean.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colMean.AppearanceCell.Options.UseFont = true;
            this.colMean.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMean.AppearanceHeader.Options.UseFont = true;
            this.colMean.Caption = "Nghĩa";
            this.colMean.FieldName = "BDefault";
            this.colMean.Name = "colMean";
            this.colMean.Visible = true;
            this.colMean.VisibleIndex = 2;
            this.colMean.Width = 68;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Trạng thái";
            this.colStatus.FieldName = "BStatus";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            // 
            // LookUpEdit_Faculty
            // 
            this.LookUpEdit_Faculty.AutoHeight = false;
            this.LookUpEdit_Faculty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpEdit_Faculty.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colFacultyName", "Tên khoa"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("colFacultyID", "Mã khoa", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.LookUpEdit_Faculty.DisplayMember = "StrFacultyName";
            this.LookUpEdit_Faculty.Name = "LookUpEdit_Faculty";
            this.LookUpEdit_Faculty.ValueMember = "StrFacultyID";
            // 
            // frmManageWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 562);
            this.Controls.Add(this.gcListLecturer);
            this.Controls.Add(this.grpInformationLanguage);
>>>>>>> design form Word, KeyWord, Language
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageWord";
<<<<<<< HEAD
            this.Text = "frmManageWord";
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Class)).EndInit();
=======
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageLecturerInformation";
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationLanguage)).EndInit();
            this.grpInformationLanguage.ResumeLayout(false);
            this.grpInformationLanguage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbModifyLanguage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListLecturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWordList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit_LanguageID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Faculty)).EndInit();
>>>>>>> design form Word, KeyWord, Language
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
<<<<<<< HEAD
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.Panel panelLogo;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnReLoad;
        private System.Windows.Forms.Button btnExitFormManageLecturer;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TextBox txtIDLanguage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gcListStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStudentList;
        private DevExpress.XtraGrid.Columns.GridColumn colWordID;
        private DevExpress.XtraGrid.Columns.GridColumn colWordName;
        private DevExpress.XtraGrid.Columns.GridColumn colModule;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Class;
=======
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraEditors.GroupControl grpInformationLanguage;
        private DevExpress.XtraGrid.GridControl gcListLecturer;
        private DevExpress.XtraGrid.Views.Grid.GridView gvWordList;
        private DevExpress.XtraGrid.Columns.GridColumn colLanguageID;
        private DevExpress.XtraGrid.Columns.GridColumn colWordID;
        private DevExpress.XtraGrid.Columns.GridColumn colMean;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Faculty;
        private System.Windows.Forms.Button btnReLoad;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMean;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.TextBox txtWord;
        private DevExpress.XtraEditors.LookUpEdit cmbModifyLanguage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDefaultLanguage;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit_LanguageID;
>>>>>>> design form Word, KeyWord, Language
    }
}