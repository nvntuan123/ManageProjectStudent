namespace ManageProjectStudent_View
{
    partial class frmManageSubjectMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageSubjectMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnManageInformationSubject = new System.Windows.Forms.Button();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnExitFormManageSubject = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.btnManageInformationSubject);
            this.panelMenu.Controls.Add(this.panelDesktopPane);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(174, 639);
            this.panelMenu.TabIndex = 6;
            // 
            // btnManageInformationSubject
            // 
            this.btnManageInformationSubject.FlatAppearance.BorderSize = 0;
            this.btnManageInformationSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageInformationSubject.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageInformationSubject.ForeColor = System.Drawing.Color.White;
            this.btnManageInformationSubject.Image = ((System.Drawing.Image)(resources.GetObject("btnManageInformationSubject.Image")));
            this.btnManageInformationSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageInformationSubject.Location = new System.Drawing.Point(0, 93);
            this.btnManageInformationSubject.Name = "btnManageInformationSubject";
            this.btnManageInformationSubject.Size = new System.Drawing.Size(174, 50);
            this.btnManageInformationSubject.TabIndex = 7;
            this.btnManageInformationSubject.Text = "Quản lý môn học";
            this.btnManageInformationSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageInformationSubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageInformationSubject.UseVisualStyleBackColor = true;
            this.btnManageInformationSubject.Click += new System.EventHandler(this.btnManageInformationSubject_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.btnAddStudent);
            this.panelDesktopPane.Controls.Add(this.btnAddGroup);
            this.panelDesktopPane.Controls.Add(this.btnExitFormManageSubject);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(0, 87);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(174, 552);
            this.panelDesktopPane.TabIndex = 9;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.FlatAppearance.BorderSize = 0;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.Location = new System.Drawing.Point(0, 62);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(174, 50);
            this.btnAddStudent.TabIndex = 8;
            this.btnAddStudent.Text = "  Thêm sinh viên vào môn học";
            this.btnAddStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.FlatAppearance.BorderSize = 0;
            this.btnAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGroup.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroup.ForeColor = System.Drawing.Color.White;
            this.btnAddGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnAddGroup.Image")));
            this.btnAddGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGroup.Location = new System.Drawing.Point(0, 118);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(174, 50);
            this.btnAddGroup.TabIndex = 11;
            this.btnAddGroup.Text = "  Thêm nhóm cho môn học";
            this.btnAddGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnExitFormManageSubject
            // 
            this.btnExitFormManageSubject.FlatAppearance.BorderSize = 0;
            this.btnExitFormManageSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitFormManageSubject.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitFormManageSubject.ForeColor = System.Drawing.Color.White;
            this.btnExitFormManageSubject.Image = global::ManageProjectStudent_View.Properties.Resources.return_30px;
            this.btnExitFormManageSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitFormManageSubject.Location = new System.Drawing.Point(0, 174);
            this.btnExitFormManageSubject.Name = "btnExitFormManageSubject";
            this.btnExitFormManageSubject.Size = new System.Drawing.Size(174, 50);
            this.btnExitFormManageSubject.TabIndex = 10;
            this.btnExitFormManageSubject.Text = "Trở về";
            this.btnExitFormManageSubject.UseVisualStyleBackColor = true;
            this.btnExitFormManageSubject.Click += new System.EventHandler(this.btnExitFormManageSubject_Click);
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
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleBar.Location = new System.Drawing.Point(174, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(999, 87);
            this.panelTitleBar.TabIndex = 7;
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
            this.btnCloseChildForm.TabIndex = 7;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(413, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý môn học";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(174, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 552);
            this.panel1.TabIndex = 8;
            // 
            // frmManageSubjectMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 639);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageSubjectMain";
            this.Text = "frmSubject";
            this.panelMenu.ResumeLayout(false);
            this.panelDesktopPane.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnManageInformationSubject;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnExitFormManageSubject;
        private System.Windows.Forms.Button btnCloseChildForm;
    }
}