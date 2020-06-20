namespace ManageProjectStudent_View
{
    partial class frmManageSubject
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLecturer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtNameCourse = new System.Windows.Forms.TextBox();
            this.txtIDCourse = new System.Windows.Forms.TextBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(26, 217);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(953, 323);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colDescription,
            this.colLecturer,
            this.colTime});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Danh sách môn học";
            // 
            // colID
            // 
            this.colID.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colID.AppearanceHeader.Options.UseFont = true;
            this.colID.Caption = "ID Môn Học";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 101;
            // 
            // colName
            // 
            this.colName.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colName.AppearanceHeader.Options.UseFont = true;
            this.colName.Caption = "Tên Môn Học";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 146;
            // 
            // colDescription
            // 
            this.colDescription.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDescription.AppearanceHeader.Options.UseFont = true;
            this.colDescription.Caption = "Mô Tả";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            this.colDescription.Width = 146;
            // 
            // colLecturer
            // 
            this.colLecturer.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colLecturer.AppearanceHeader.Options.UseFont = true;
            this.colLecturer.Caption = "Giảng Viên";
            this.colLecturer.Name = "colLecturer";
            this.colLecturer.Visible = true;
            this.colLecturer.VisibleIndex = 3;
            this.colLecturer.Width = 146;
            // 
            // colTime
            // 
            this.colTime.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTime.AppearanceHeader.Options.UseFont = true;
            this.colTime.Caption = "Thời Gian";
            this.colTime.Name = "colTime";
            this.colTime.Visible = true;
            this.colTime.VisibleIndex = 4;
            this.colTime.Width = 146;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtNameCourse);
            this.groupControl1.Controls.Add(this.txtIDCourse);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.btnLuu);
            this.groupControl1.Controls.Add(this.dateEdit2);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.dateEdit1);
            this.groupControl1.Controls.Add(this.textEdit5);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(26, 7);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(953, 204);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Thông Tin Môn Học";
            // 
            // txtNameCourse
            // 
            this.txtNameCourse.Location = new System.Drawing.Point(681, 43);
            this.txtNameCourse.Name = "txtNameCourse";
            this.txtNameCourse.Size = new System.Drawing.Size(182, 21);
            this.txtNameCourse.TabIndex = 102;
            this.txtNameCourse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameCourse_KeyPress);
            // 
            // txtIDCourse
            // 
            this.txtIDCourse.Location = new System.Drawing.Point(248, 43);
            this.txtIDCourse.Name = "txtIDCourse";
            this.txtIDCourse.Size = new System.Drawing.Size(182, 21);
            this.txtIDCourse.TabIndex = 101;
            this.txtIDCourse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDCourse_KeyPress);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.simpleButton3.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton3.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton3.AppearanceHovered.Options.UseFont = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton3.Location = new System.Drawing.Point(629, 162);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(117, 28);
            this.simpleButton3.TabIndex = 100;
            this.simpleButton3.TabStop = false;
            this.simpleButton3.Text = "Lưu";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.simpleButton2.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton2.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton2.AppearanceHovered.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.Location = new System.Drawing.Point(489, 162);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(117, 28);
            this.simpleButton2.TabIndex = 99;
            this.simpleButton2.TabStop = false;
            this.simpleButton2.Text = "Sửa ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.simpleButton1.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.AppearanceHovered.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.Location = new System.Drawing.Point(347, 162);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(117, 28);
            this.simpleButton1.TabIndex = 98;
            this.simpleButton1.TabStop = false;
            this.simpleButton1.Text = "Xóa";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Appearance.Options.UseBackColor = true;
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(71)))), ((int)(((byte)(100)))));
            this.btnLuu.AppearanceHovered.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLuu.AppearanceHovered.Options.UseBackColor = true;
            this.btnLuu.AppearanceHovered.Options.UseFont = true;
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnLuu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLuu.Location = new System.Drawing.Point(191, 162);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(117, 28);
            this.btnLuu.TabIndex = 97;
            this.btnLuu.TabStop = false;
            this.btnLuu.Text = "Thêm";
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(681, 109);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(182, 20);
            this.dateEdit2.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Thời Gian Bắt Đầu";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(248, 103);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(182, 20);
            this.dateEdit1.TabIndex = 44;
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(97, 333);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(157, 20);
            this.textEdit5.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Place";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Thời Gian Bắt Đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(527, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên Môn Học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Môn Học";
            // 
            // frmManageSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 552);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageSubject";
            this.Text = "frmManageSubject";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colLecturer;
        private DevExpress.XtraGrid.Columns.GridColumn colTime;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.TextBox txtNameCourse;
        private System.Windows.Forms.TextBox txtIDCourse;
    }
}