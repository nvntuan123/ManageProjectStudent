namespace ManageProjectStudent_View
{
    partial class frmManageProjectMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageProjectMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExitForm = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnViewDeadlineLecturer = new System.Windows.Forms.Button();
            this.btnManageProjectLecturer = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(77)))));
            this.panelMenu.Controls.Add(this.btnExitForm);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnViewDeadlineLecturer);
            this.panelMenu.Controls.Add(this.btnManageProjectLecturer);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(174, 639);
            this.panelMenu.TabIndex = 1;
            // 
            // btnExitForm
            // 
            this.btnExitForm.FlatAppearance.BorderSize = 0;
            this.btnExitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitForm.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitForm.ForeColor = System.Drawing.Color.White;
            this.btnExitForm.Image = global::ManageProjectStudent_View.Properties.Resources.return_30px;
            this.btnExitForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitForm.Location = new System.Drawing.Point(0, 205);
            this.btnExitForm.Name = "btnExitForm";
            this.btnExitForm.Size = new System.Drawing.Size(174, 50);
            this.btnExitForm.TabIndex = 6;
            this.btnExitForm.Text = "Trở về";
            this.btnExitForm.UseVisualStyleBackColor = true;
            this.btnExitForm.Click += new System.EventHandler(this.btnExitForm_Click);
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
            // btnViewDeadlineLecturer
            // 
            this.btnViewDeadlineLecturer.FlatAppearance.BorderSize = 0;
            this.btnViewDeadlineLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDeadlineLecturer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDeadlineLecturer.ForeColor = System.Drawing.Color.White;
            this.btnViewDeadlineLecturer.Image = ((System.Drawing.Image)(resources.GetObject("btnViewDeadlineLecturer.Image")));
            this.btnViewDeadlineLecturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewDeadlineLecturer.Location = new System.Drawing.Point(0, 149);
            this.btnViewDeadlineLecturer.Name = "btnViewDeadlineLecturer";
            this.btnViewDeadlineLecturer.Size = new System.Drawing.Size(177, 50);
            this.btnViewDeadlineLecturer.TabIndex = 4;
            this.btnViewDeadlineLecturer.Text = "Xem hạn nộp";
            this.btnViewDeadlineLecturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewDeadlineLecturer.UseVisualStyleBackColor = true;
            this.btnViewDeadlineLecturer.Click += new System.EventHandler(this.btnViewDeadlineLecturer_Click);
            // 
            // btnManageProjectLecturer
            // 
            this.btnManageProjectLecturer.FlatAppearance.BorderSize = 0;
            this.btnManageProjectLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProjectLecturer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProjectLecturer.ForeColor = System.Drawing.Color.White;
            this.btnManageProjectLecturer.Image = ((System.Drawing.Image)(resources.GetObject("btnManageProjectLecturer.Image")));
            this.btnManageProjectLecturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProjectLecturer.Location = new System.Drawing.Point(0, 93);
            this.btnManageProjectLecturer.Name = "btnManageProjectLecturer";
            this.btnManageProjectLecturer.Size = new System.Drawing.Size(174, 50);
            this.btnManageProjectLecturer.TabIndex = 2;
            this.btnManageProjectLecturer.Text = "Quản Lý đồ án";
            this.btnManageProjectLecturer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageProjectLecturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageProjectLecturer.UseVisualStyleBackColor = true;
            this.btnManageProjectLecturer.Click += new System.EventHandler(this.btnManageProjectLecturer_Click);
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
            this.panelTitleBar.TabIndex = 2;
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
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(371, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(298, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Đồ Án Cho Giảng Viên";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(174, 87);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(999, 552);
            this.panelDesktopPane.TabIndex = 3;
            // 
            // frmManageProjectMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 639);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageProjectMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageProjectMain";
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnExitForm;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnViewDeadlineLecturer;
        private System.Windows.Forms.Button btnManageProjectLecturer;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
    }
}