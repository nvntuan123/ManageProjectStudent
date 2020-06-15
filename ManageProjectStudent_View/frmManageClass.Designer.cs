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
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.gvClassList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNameClass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNameFaculty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.listBoxControl2 = new DevExpress.XtraEditors.ListBoxControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvClassList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.Location = new System.Drawing.Point(525, 232);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(130, 23);
            this.simpleButton7.TabIndex = 48;
            this.simpleButton7.Text = "Xóa lớp";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Location = new System.Drawing.Point(90, 232);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(136, 23);
            this.simpleButton4.TabIndex = 46;
            this.simpleButton4.Text = "Tạo lớp";
            // 
            // gvClassList
            // 
            this.gvClassList.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvClassList.Appearance.EvenRow.Options.UseFont = true;
            this.gvClassList.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvClassList.Appearance.OddRow.Options.UseFont = true;
            this.gvClassList.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvClassList.Appearance.SelectedRow.Options.UseFont = true;
            this.gvClassList.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvClassList.Appearance.ViewCaption.Options.UseFont = true;
            this.gvClassList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColID,
            this.ColNameClass,
            this.ColNameFaculty});
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
            // ColID
            // 
            this.ColID.Caption = "ID";
            this.ColID.Name = "ColID";
            this.ColID.Visible = true;
            this.ColID.VisibleIndex = 0;
            // 
            // ColNameClass
            // 
            this.ColNameClass.Caption = "Tên lớp";
            this.ColNameClass.Name = "ColNameClass";
            this.ColNameClass.Visible = true;
            this.ColNameClass.VisibleIndex = 1;
            // 
            // ColNameFaculty
            // 
            this.ColNameFaculty.Caption = "Tên khoa";
            this.ColNameFaculty.Name = "ColNameFaculty";
            this.ColNameFaculty.Visible = true;
            this.ColNameFaculty.VisibleIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(11, 40);
            this.gridControl1.MainView = this.gvClassList;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(675, 220);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClassList});
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControl1);
            this.groupControl3.Location = new System.Drawing.Point(21, 273);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(706, 285);
            this.groupControl3.TabIndex = 45;
            this.groupControl3.Text = "Quản lí lớp";
            // 
            // listBoxControl2
            // 
            this.listBoxControl2.Location = new System.Drawing.Point(5, 37);
            this.listBoxControl2.Name = "listBoxControl2";
            this.listBoxControl2.Size = new System.Drawing.Size(212, 163);
            this.listBoxControl2.TabIndex = 0;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Location = new System.Drawing.Point(307, 232);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(130, 23);
            this.simpleButton5.TabIndex = 47;
            this.simpleButton5.Text = "Sửa lớp";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.listBoxControl2);
            this.groupControl2.Location = new System.Drawing.Point(408, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(222, 205);
            this.groupControl2.TabIndex = 44;
            this.groupControl2.Text = "Danh sách lớp";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.listBoxControl1);
            this.groupControl1.Location = new System.Drawing.Point(106, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(213, 205);
            this.groupControl1.TabIndex = 43;
            this.groupControl1.Text = "Danh sách khoa";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(5, 32);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(203, 168);
            this.listBoxControl1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(766, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(665, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Năm đào tạo";
            // 
            // frmManageClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 572);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageClass";
            this.Text = "frmManageClass";
            ((System.ComponentModel.ISupportInitialize)(this.gvClassList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClassList;
        private DevExpress.XtraGrid.Columns.GridColumn ColID;
        private DevExpress.XtraGrid.Columns.GridColumn ColNameClass;
        private DevExpress.XtraGrid.Columns.GridColumn ColNameFaculty;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}