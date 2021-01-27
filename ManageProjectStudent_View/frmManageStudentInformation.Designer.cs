namespace ManageProjectStudent_View
{
    partial class frmManageStudentInformation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageStudentInformation));
            this.LookUpEdit_Faculty = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.dteBirthday = new DevExpress.XtraEditors.DateEdit();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpInformationStudent = new DevExpress.XtraEditors.GroupControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radAvailable = new System.Windows.Forms.RadioButton();
            this.radUnavailable = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.dteStartYear = new DevExpress.XtraEditors.DateEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lkeFaculty = new DevExpress.XtraEditors.LookUpEdit();
            this.lkeClass = new DevExpress.XtraEditors.LookUpEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gcListStudent = new DevExpress.XtraGrid.GridControl();
            this.gvStudentList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colStudentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCard = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LookUpEdit_Class = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colFaculty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnReLoad = new System.Windows.Forms.Button();
            this.btnExitFormManageStudent = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Faculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBirthday.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBirthday.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationStudent)).BeginInit();
            this.grpInformationStudent.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartYear.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeFaculty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Class)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // LookUpEdit_Faculty
            // 
            resources.ApplyResources(this.LookUpEdit_Faculty, "LookUpEdit_Faculty");
            this.LookUpEdit_Faculty.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.LookUpEdit_Faculty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("LookUpEdit_Faculty.Buttons"))))});
            this.LookUpEdit_Faculty.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("LookUpEdit_Faculty.Columns"), resources.GetString("LookUpEdit_Faculty.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("LookUpEdit_Faculty.Columns2"), resources.GetString("LookUpEdit_Faculty.Columns3"), ((int)(resources.GetObject("LookUpEdit_Faculty.Columns4"))), ((DevExpress.Utils.FormatType)(resources.GetObject("LookUpEdit_Faculty.Columns5"))), resources.GetString("LookUpEdit_Faculty.Columns6"), ((bool)(resources.GetObject("LookUpEdit_Faculty.Columns7"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("LookUpEdit_Faculty.Columns8"))), ((DevExpress.Data.ColumnSortOrder)(resources.GetObject("LookUpEdit_Faculty.Columns9"))), ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("LookUpEdit_Faculty.Columns10"))))});
            this.LookUpEdit_Faculty.DisplayMember = "StrFacultyName";
            this.LookUpEdit_Faculty.Name = "LookUpEdit_Faculty";
            this.LookUpEdit_Faculty.ValueMember = "StrFacultyID";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txtAddress
            // 
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.txtAddress.Name = "txtAddress";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // txtPhoneNumber
            // 
            resources.ApplyResources(this.txtPhoneNumber, "txtPhoneNumber");
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // txtIDCard
            // 
            resources.ApplyResources(this.txtIDCard, "txtIDCard");
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCard_KeyPress);
            // 
            // dteBirthday
            // 
            resources.ApplyResources(this.dteBirthday, "dteBirthday");
            this.dteBirthday.Name = "dteBirthday";
            this.dteBirthday.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dteBirthday.Properties.Buttons"))))});
            this.dteBirthday.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dteBirthday.Properties.CalendarTimeProperties.Buttons"))))});
            this.dteBirthday.Properties.CalendarTimeProperties.Mask.EditMask = resources.GetString("dteBirthday.Properties.CalendarTimeProperties.Mask.EditMask");
            this.dteBirthday.Properties.Mask.EditMask = resources.GetString("dteBirthday.Properties.Mask.EditMask");
            // 
            // txtFullName
            // 
            resources.ApplyResources(this.txtFullName, "txtFullName");
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtID
            // 
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.Name = "txtID";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // grpInformationStudent
            // 
            resources.ApplyResources(this.grpInformationStudent, "grpInformationStudent");
            this.grpInformationStudent.Controls.Add(this.panel2);
            this.grpInformationStudent.Controls.Add(this.panel1);
            this.grpInformationStudent.Controls.Add(this.dteStartYear);
            this.grpInformationStudent.Controls.Add(this.label10);
            this.grpInformationStudent.Controls.Add(this.btnSave);
            this.grpInformationStudent.Controls.Add(this.lkeFaculty);
            this.grpInformationStudent.Controls.Add(this.lkeClass);
            this.grpInformationStudent.Controls.Add(this.label12);
            this.grpInformationStudent.Controls.Add(this.label11);
            this.grpInformationStudent.Controls.Add(this.label9);
            this.grpInformationStudent.Controls.Add(this.txtAddress);
            this.grpInformationStudent.Controls.Add(this.label8);
            this.grpInformationStudent.Controls.Add(this.txtIDCard);
            this.grpInformationStudent.Controls.Add(this.txtEmail);
            this.grpInformationStudent.Controls.Add(this.txtPhoneNumber);
            this.grpInformationStudent.Controls.Add(this.dteBirthday);
            this.grpInformationStudent.Controls.Add(this.txtFullName);
            this.grpInformationStudent.Controls.Add(this.label7);
            this.grpInformationStudent.Controls.Add(this.label6);
            this.grpInformationStudent.Controls.Add(this.label5);
            this.grpInformationStudent.Controls.Add(this.label4);
            this.grpInformationStudent.Controls.Add(this.label3);
            this.grpInformationStudent.Controls.Add(this.label2);
            this.grpInformationStudent.Controls.Add(this.txtID);
            this.grpInformationStudent.Controls.Add(this.label1);
            this.grpInformationStudent.Name = "grpInformationStudent";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.radAvailable);
            this.panel2.Controls.Add(this.radUnavailable);
            this.panel2.Name = "panel2";
            // 
            // radAvailable
            // 
            resources.ApplyResources(this.radAvailable, "radAvailable");
            this.radAvailable.Name = "radAvailable";
            this.radAvailable.TabStop = true;
            this.radAvailable.UseVisualStyleBackColor = true;
            this.radAvailable.CheckedChanged += new System.EventHandler(this.radAvailable_CheckedChanged);
            // 
            // radUnavailable
            // 
            resources.ApplyResources(this.radUnavailable, "radUnavailable");
            this.radUnavailable.Name = "radUnavailable";
            this.radUnavailable.TabStop = true;
            this.radUnavailable.UseVisualStyleBackColor = true;
            this.radUnavailable.CheckedChanged += new System.EventHandler(this.radUnavailable_CheckedChanged);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.radNam);
            this.panel1.Controls.Add(this.radNu);
            this.panel1.Name = "panel1";
            // 
            // radNam
            // 
            resources.ApplyResources(this.radNam, "radNam");
            this.radNam.Name = "radNam";
            this.radNam.TabStop = true;
            this.radNam.UseVisualStyleBackColor = true;
            this.radNam.CheckedChanged += new System.EventHandler(this.radNam_CheckedChanged);
            // 
            // radNu
            // 
            resources.ApplyResources(this.radNu, "radNu");
            this.radNu.Name = "radNu";
            this.radNu.TabStop = true;
            this.radNu.UseVisualStyleBackColor = true;
            this.radNu.CheckedChanged += new System.EventHandler(this.radNu_CheckedChanged);
            // 
            // dteStartYear
            // 
            resources.ApplyResources(this.dteStartYear, "dteStartYear");
            this.dteStartYear.Name = "dteStartYear";
            this.dteStartYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dteStartYear.Properties.Buttons"))))});
            this.dteStartYear.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("dteStartYear.Properties.CalendarTimeProperties.Buttons"))))});
            this.dteStartYear.Properties.CalendarTimeProperties.Mask.EditMask = resources.GetString("dteStartYear.Properties.CalendarTimeProperties.Mask.EditMask");
            this.dteStartYear.Properties.Mask.EditMask = resources.GetString("dteStartYear.Properties.Mask.EditMask");
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnSave.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnSave.Appearance.Font")));
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnSave.AppearanceHovered.Font = ((System.Drawing.Font)(resources.GetObject("btnSave.AppearanceHovered.Font")));
            this.btnSave.AppearanceHovered.Options.UseBackColor = true;
            this.btnSave.AppearanceHovered.Options.UseFont = true;
            this.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.Name = "btnSave";
            this.btnSave.TabStop = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lkeFaculty
            // 
            resources.ApplyResources(this.lkeFaculty, "lkeFaculty");
            this.lkeFaculty.Name = "lkeFaculty";
            this.lkeFaculty.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lkeFaculty.Properties.Appearance.Font")));
            this.lkeFaculty.Properties.Appearance.Options.UseFont = true;
            this.lkeFaculty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("lkeFaculty.Properties.Buttons"))))});
            this.lkeFaculty.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("lkeFaculty.Properties.Columns"), resources.GetString("lkeFaculty.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("lkeFaculty.Properties.Columns2"), resources.GetString("lkeFaculty.Properties.Columns3"), ((int)(resources.GetObject("lkeFaculty.Properties.Columns4"))), ((DevExpress.Utils.FormatType)(resources.GetObject("lkeFaculty.Properties.Columns5"))), resources.GetString("lkeFaculty.Properties.Columns6"), ((bool)(resources.GetObject("lkeFaculty.Properties.Columns7"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("lkeFaculty.Properties.Columns8"))), ((DevExpress.Data.ColumnSortOrder)(resources.GetObject("lkeFaculty.Properties.Columns9"))), ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("lkeFaculty.Properties.Columns10"))))});
            this.lkeFaculty.Properties.NullText = resources.GetString("lkeFaculty.Properties.NullText");
            // 
            // lkeClass
            // 
            resources.ApplyResources(this.lkeClass, "lkeClass");
            this.lkeClass.Name = "lkeClass";
            this.lkeClass.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lkeClass.Properties.Appearance.Font")));
            this.lkeClass.Properties.Appearance.Options.UseFont = true;
            this.lkeClass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("lkeClass.Properties.Buttons"))))});
            this.lkeClass.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("lkeClass.Properties.Columns"), resources.GetString("lkeClass.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("lkeClass.Properties.Columns2"), resources.GetString("lkeClass.Properties.Columns3"))});
            this.lkeClass.Properties.NullText = resources.GetString("lkeClass.Properties.NullText");
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // gcListStudent
            // 
            resources.ApplyResources(this.gcListStudent, "gcListStudent");
            this.gcListStudent.EmbeddedNavigator.AccessibleDescription = resources.GetString("gcListStudent.EmbeddedNavigator.AccessibleDescription");
            this.gcListStudent.EmbeddedNavigator.AccessibleName = resources.GetString("gcListStudent.EmbeddedNavigator.AccessibleName");
            this.gcListStudent.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("gcListStudent.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.gcListStudent.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gcListStudent.EmbeddedNavigator.Anchor")));
            this.gcListStudent.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gcListStudent.EmbeddedNavigator.BackgroundImage")));
            this.gcListStudent.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("gcListStudent.EmbeddedNavigator.BackgroundImageLayout")));
            this.gcListStudent.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gcListStudent.EmbeddedNavigator.ImeMode")));
            this.gcListStudent.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("gcListStudent.EmbeddedNavigator.MaximumSize")));
            this.gcListStudent.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("gcListStudent.EmbeddedNavigator.TextLocation")));
            this.gcListStudent.EmbeddedNavigator.ToolTip = resources.GetString("gcListStudent.EmbeddedNavigator.ToolTip");
            this.gcListStudent.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("gcListStudent.EmbeddedNavigator.ToolTipIconType")));
            this.gcListStudent.EmbeddedNavigator.ToolTipTitle = resources.GetString("gcListStudent.EmbeddedNavigator.ToolTipTitle");
            this.gcListStudent.MainView = this.gvStudentList;
            this.gcListStudent.Name = "gcListStudent";
            this.gcListStudent.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LookUpEdit_Class});
            this.gcListStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStudentList});
            // 
            // gvStudentList
            // 
            this.gvStudentList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvStudentList.Appearance.EvenRow.Font = ((System.Drawing.Font)(resources.GetObject("gvStudentList.Appearance.EvenRow.Font")));
            this.gvStudentList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvStudentList.Appearance.EvenRow.Options.UseFont = true;
            this.gvStudentList.Appearance.HeaderPanel.Font = ((System.Drawing.Font)(resources.GetObject("gvStudentList.Appearance.HeaderPanel.Font")));
            this.gvStudentList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvStudentList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvStudentList.Appearance.OddRow.Font = ((System.Drawing.Font)(resources.GetObject("gvStudentList.Appearance.OddRow.Font")));
            this.gvStudentList.Appearance.OddRow.Options.UseBackColor = true;
            this.gvStudentList.Appearance.OddRow.Options.UseFont = true;
            this.gvStudentList.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("gvStudentList.Appearance.Row.Font")));
            this.gvStudentList.Appearance.Row.Options.UseFont = true;
            this.gvStudentList.Appearance.ViewCaption.Font = ((System.Drawing.Font)(resources.GetObject("gvStudentList.Appearance.ViewCaption.Font")));
            this.gvStudentList.Appearance.ViewCaption.Options.UseFont = true;
            this.gvStudentList.AppearancePrint.Row.Font = ((System.Drawing.Font)(resources.GetObject("gvStudentList.AppearancePrint.Row.Font")));
            this.gvStudentList.AppearancePrint.Row.Options.UseFont = true;
            resources.ApplyResources(this.gvStudentList, "gvStudentList");
            this.gvStudentList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStudentID,
            this.colFullName,
            this.colBirthday,
            this.colStartYear,
            this.ColSex,
            this.colPhoneNumber,
            this.colEmail,
            this.colIDCard,
            this.colAddress,
            this.colStatus,
            this.colClass,
            this.colFaculty});
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
            this.gvStudentList.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gvStudentList_CustomDrawRowIndicator);
            this.gvStudentList.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gvStudentList_SelectionChanged);
            this.gvStudentList.RowCountChanged += new System.EventHandler(this.gvStudentList_RowCountChanged);
            // 
            // colStudentID
            // 
            this.colStudentID.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colStudentID.AppearanceCell.Font")));
            this.colStudentID.AppearanceCell.Options.UseFont = true;
            this.colStudentID.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colStudentID.AppearanceHeader.Font")));
            this.colStudentID.AppearanceHeader.Options.UseFont = true;
            resources.ApplyResources(this.colStudentID, "colStudentID");
            this.colStudentID.FieldName = "StrStudentID";
            this.colStudentID.Name = "colStudentID";
            // 
            // colFullName
            // 
            this.colFullName.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colFullName.AppearanceCell.Font")));
            this.colFullName.AppearanceCell.Options.UseFont = true;
            this.colFullName.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colFullName.AppearanceHeader.Font")));
            this.colFullName.AppearanceHeader.Options.UseFont = true;
            resources.ApplyResources(this.colFullName, "colFullName");
            this.colFullName.FieldName = "StrStudentName";
            this.colFullName.Name = "colFullName";
            // 
            // colBirthday
            // 
            this.colBirthday.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colBirthday.AppearanceCell.Font")));
            this.colBirthday.AppearanceCell.Options.UseFont = true;
            resources.ApplyResources(this.colBirthday, "colBirthday");
            this.colBirthday.FieldName = "DtBirthDay";
            this.colBirthday.Name = "colBirthday";
            // 
            // colStartYear
            // 
            resources.ApplyResources(this.colStartYear, "colStartYear");
            this.colStartYear.FieldName = "DtStartYear";
            this.colStartYear.Name = "colStartYear";
            // 
            // ColSex
            // 
            this.ColSex.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("ColSex.AppearanceCell.Font")));
            this.ColSex.AppearanceCell.Options.UseFont = true;
            this.ColSex.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("ColSex.AppearanceHeader.Font")));
            this.ColSex.AppearanceHeader.Options.UseFont = true;
            resources.ApplyResources(this.ColSex, "ColSex");
            this.ColSex.FieldName = "StrSex";
            this.ColSex.Name = "ColSex";
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colPhoneNumber.AppearanceCell.Font")));
            this.colPhoneNumber.AppearanceCell.Options.UseFont = true;
            this.colPhoneNumber.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colPhoneNumber.AppearanceHeader.Font")));
            this.colPhoneNumber.AppearanceHeader.Options.UseFont = true;
            resources.ApplyResources(this.colPhoneNumber, "colPhoneNumber");
            this.colPhoneNumber.FieldName = "StrPhone";
            this.colPhoneNumber.Name = "colPhoneNumber";
            // 
            // colEmail
            // 
            this.colEmail.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colEmail.AppearanceCell.Font")));
            this.colEmail.AppearanceCell.Options.UseFont = true;
            this.colEmail.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colEmail.AppearanceHeader.Font")));
            this.colEmail.AppearanceHeader.Options.UseFont = true;
            resources.ApplyResources(this.colEmail, "colEmail");
            this.colEmail.FieldName = "StrEmail";
            this.colEmail.Name = "colEmail";
            // 
            // colIDCard
            // 
            this.colIDCard.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colIDCard.AppearanceCell.Font")));
            this.colIDCard.AppearanceCell.Options.UseFont = true;
            this.colIDCard.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colIDCard.AppearanceHeader.Font")));
            this.colIDCard.AppearanceHeader.Options.UseFont = true;
            resources.ApplyResources(this.colIDCard, "colIDCard");
            this.colIDCard.FieldName = "StrCardID";
            this.colIDCard.Name = "colIDCard";
            // 
            // colAddress
            // 
            this.colAddress.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colAddress.AppearanceCell.Font")));
            this.colAddress.AppearanceCell.Options.UseFont = true;
            this.colAddress.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colAddress.AppearanceHeader.Font")));
            this.colAddress.AppearanceHeader.Options.UseFont = true;
            resources.ApplyResources(this.colAddress, "colAddress");
            this.colAddress.FieldName = "StrAddress";
            this.colAddress.Name = "colAddress";
            // 
            // colStatus
            // 
            this.colStatus.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colStatus.AppearanceCell.Font")));
            this.colStatus.AppearanceCell.Options.UseFont = true;
            this.colStatus.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colStatus.AppearanceHeader.Font")));
            this.colStatus.AppearanceHeader.Options.UseFont = true;
            resources.ApplyResources(this.colStatus, "colStatus");
            this.colStatus.FieldName = "BStatus";
            this.colStatus.Name = "colStatus";
            // 
            // colClass
            // 
            this.colClass.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colClass.AppearanceCell.Font")));
            this.colClass.AppearanceCell.Options.UseFont = true;
            this.colClass.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colClass.AppearanceHeader.Font")));
            this.colClass.AppearanceHeader.Options.UseFont = true;
            resources.ApplyResources(this.colClass, "colClass");
            this.colClass.ColumnEdit = this.LookUpEdit_Class;
            this.colClass.FieldName = "StrClassID";
            this.colClass.Name = "colClass";
            // 
            // LookUpEdit_Class
            // 
            resources.ApplyResources(this.LookUpEdit_Class, "LookUpEdit_Class");
            this.LookUpEdit_Class.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("LookUpEdit_Class.Buttons"))))});
            this.LookUpEdit_Class.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("LookUpEdit_Class.Columns"), resources.GetString("LookUpEdit_Class.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("LookUpEdit_Class.Columns2"), resources.GetString("LookUpEdit_Class.Columns3"), ((int)(resources.GetObject("LookUpEdit_Class.Columns4"))), ((DevExpress.Utils.FormatType)(resources.GetObject("LookUpEdit_Class.Columns5"))), resources.GetString("LookUpEdit_Class.Columns6"), ((bool)(resources.GetObject("LookUpEdit_Class.Columns7"))), ((DevExpress.Utils.HorzAlignment)(resources.GetObject("LookUpEdit_Class.Columns8"))), ((DevExpress.Data.ColumnSortOrder)(resources.GetObject("LookUpEdit_Class.Columns9"))), ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("LookUpEdit_Class.Columns10"))))});
            this.LookUpEdit_Class.DisplayMember = "StrClassName";
            this.LookUpEdit_Class.Name = "LookUpEdit_Class";
            this.LookUpEdit_Class.ValueMember = "StrClassID";
            // 
            // colFaculty
            // 
            this.colFaculty.AppearanceCell.Font = ((System.Drawing.Font)(resources.GetObject("colFaculty.AppearanceCell.Font")));
            this.colFaculty.AppearanceCell.Options.UseFont = true;
            this.colFaculty.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("colFaculty.AppearanceHeader.Font")));
            this.colFaculty.AppearanceHeader.Options.UseFont = true;
            resources.ApplyResources(this.colFaculty, "colFaculty");
            this.colFaculty.ColumnEdit = this.LookUpEdit_Faculty;
            this.colFaculty.FieldName = "StrFacultyID";
            this.colFaculty.Name = "colFaculty";
            // 
            // panelMenu
            // 
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.btnUpdate);
            this.panelMenu.Controls.Add(this.btnDelete);
            this.panelMenu.Controls.Add(this.btnAdd);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Name = "panelMenu";
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnUpdate.Appearance.Font")));
            this.btnUpdate.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Appearance.Options.UseBackColor = true;
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Appearance.Options.UseForeColor = true;
            this.btnUpdate.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnUpdate.AppearanceHovered.Font = ((System.Drawing.Font)(resources.GetObject("btnUpdate.AppearanceHovered.Font")));
            this.btnUpdate.AppearanceHovered.Options.UseBackColor = true;
            this.btnUpdate.AppearanceHovered.Options.UseFont = true;
            this.btnUpdate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnDelete.Appearance.Font")));
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnDelete.AppearanceHovered.Font = ((System.Drawing.Font)(resources.GetObject("btnDelete.AppearanceHovered.Font")));
            this.btnDelete.AppearanceHovered.Options.UseBackColor = true;
            this.btnDelete.AppearanceHovered.Options.UseFont = true;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnAdd.Appearance.Font")));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnAdd.AppearanceHovered.Font = ((System.Drawing.Font)(resources.GetObject("btnAdd.AppearanceHovered.Font")));
            this.btnAdd.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnAdd.AppearanceHovered.Options.UseBackColor = true;
            this.btnAdd.AppearanceHovered.Options.UseFont = true;
            this.btnAdd.AppearanceHovered.Options.UseForeColor = true;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelLogo
            // 
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.panelLogo.Name = "panelLogo";
            // 
            // panelTitleBar
            // 
            resources.ApplyResources(this.panelTitleBar, "panelTitleBar");
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.panelTitleBar.Controls.Add(this.btnReLoad);
            this.panelTitleBar.Controls.Add(this.btnExitFormManageStudent);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Name = "panelTitleBar";
            // 
            // btnReLoad
            // 
            resources.ApplyResources(this.btnReLoad, "btnReLoad");
            this.btnReLoad.FlatAppearance.BorderSize = 0;
            this.btnReLoad.ForeColor = System.Drawing.Color.White;
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.UseVisualStyleBackColor = true;
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
            // 
            // btnExitFormManageStudent
            // 
            resources.ApplyResources(this.btnExitFormManageStudent, "btnExitFormManageStudent");
            this.btnExitFormManageStudent.FlatAppearance.BorderSize = 0;
            this.btnExitFormManageStudent.Name = "btnExitFormManageStudent";
            this.btnExitFormManageStudent.UseVisualStyleBackColor = true;
            this.btnExitFormManageStudent.Click += new System.EventHandler(this.btnExitFormManageStudent_Click);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            // 
            // btnImport
            // 
            resources.ApplyResources(this.btnImport, "btnImport");
            this.btnImport.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnImport.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnImport.Appearance.Font")));
            this.btnImport.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnImport.Appearance.Options.UseBackColor = true;
            this.btnImport.Appearance.Options.UseFont = true;
            this.btnImport.Appearance.Options.UseForeColor = true;
            this.btnImport.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnImport.AppearanceHovered.Font = ((System.Drawing.Font)(resources.GetObject("btnImport.AppearanceHovered.Font")));
            this.btnImport.AppearanceHovered.Options.UseBackColor = true;
            this.btnImport.AppearanceHovered.Options.UseFont = true;
            this.btnImport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnImport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnImport.Name = "btnImport";
            this.btnImport.TabStop = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            resources.ApplyResources(this.btnExport, "btnExport");
            this.btnExport.Appearance.BackColor = System.Drawing.Color.Silver;
            this.btnExport.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnExport.Appearance.Font")));
            this.btnExport.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnExport.Appearance.Options.UseBackColor = true;
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Appearance.Options.UseForeColor = true;
            this.btnExport.AppearanceHovered.BackColor = System.Drawing.Color.Gray;
            this.btnExport.AppearanceHovered.Font = ((System.Drawing.Font)(resources.GetObject("btnExport.AppearanceHovered.Font")));
            this.btnExport.AppearanceHovered.Options.UseBackColor = true;
            this.btnExport.AppearanceHovered.Options.UseFont = true;
            this.btnExport.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnExport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExport.Name = "btnExport";
            this.btnExport.TabStop = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmManageStudentInformation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.gcListStudent);
            this.Controls.Add(this.grpInformationStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageStudentInformation";
            this.Load += new System.EventHandler(this.frmManageStudentInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Faculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBirthday.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBirthday.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpInformationStudent)).EndInit();
            this.grpInformationStudent.ResumeLayout(false);
            this.grpInformationStudent.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartYear.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteStartYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeFaculty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcListStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit_Class)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtIDCard;
        private DevExpress.XtraEditors.DateEdit dteBirthday;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl grpInformationStudent;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radUnavailable;
        private System.Windows.Forms.RadioButton radAvailable;
        private DevExpress.XtraEditors.LookUpEdit lkeFaculty;
        private DevExpress.XtraEditors.LookUpEdit lkeClass;
        private DevExpress.XtraGrid.GridControl gcListStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStudentList;
        private DevExpress.XtraGrid.Columns.GridColumn colStudentID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthday;
        private DevExpress.XtraGrid.Columns.GridColumn ColSex;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCard;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colClass;
        private DevExpress.XtraGrid.Columns.GridColumn colFaculty;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnExitFormManageStudent;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Faculty;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LookUpEdit_Class;
        private System.Windows.Forms.Button btnReLoad;
        private DevExpress.XtraEditors.DateEdit dteStartYear;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraGrid.Columns.GridColumn colStartYear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.SimpleButton btnExport;
    }
}