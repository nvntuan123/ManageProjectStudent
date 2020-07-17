namespace ManageProjectStudent_View
{
    partial class frmWorldList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gcListCourse = new DevExpress.XtraGrid.GridControl();
            this.gvListCourse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWordID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYearEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lookUpEdit2);
            this.panel1.Controls.Add(this.lookUpEdit1);
            this.panel1.Controls.Add(this.gcListCourse);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(84, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 489);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Module";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modify Language";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "English";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Default Language";
            // 
            // gcListCourse
            // 
            this.gcListCourse.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcListCourse.Location = new System.Drawing.Point(24, 238);
            this.gcListCourse.MainView = this.gvListCourse;
            this.gcListCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcListCourse.Name = "gcListCourse";
            this.gcListCourse.Size = new System.Drawing.Size(580, 247);
            this.gcListCourse.TabIndex = 126;
            this.gcListCourse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListCourse});
            // 
            // gvListCourse
            // 
            this.gvListCourse.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListCourse.Appearance.EvenRow.Options.UseFont = true;
            this.gvListCourse.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListCourse.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvListCourse.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gvListCourse.Appearance.OddRow.Options.UseFont = true;
            this.gvListCourse.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvListCourse.Appearance.ViewCaption.Options.UseFont = true;
            this.gvListCourse.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWordID,
            this.colYearStart,
            this.colYearEnd});
            this.gvListCourse.DetailHeight = 458;
            this.gvListCourse.FixedLineWidth = 3;
            this.gvListCourse.GridControl = this.gcListCourse;
            this.gvListCourse.Name = "gvListCourse";
            this.gvListCourse.OptionsBehavior.Editable = false;
            this.gvListCourse.OptionsSelection.MultiSelect = true;
            this.gvListCourse.OptionsView.EnableAppearanceEvenRow = true;
            this.gvListCourse.OptionsView.EnableAppearanceOddRow = true;
            this.gvListCourse.OptionsView.ShowAutoFilterRow = true;
            this.gvListCourse.OptionsView.ShowGroupPanel = false;
            this.gvListCourse.OptionsView.ShowViewCaption = true;
            this.gvListCourse.ViewCaption = "Danh sách khóa học";
            // 
            // colWordID
            // 
            this.colWordID.Caption = "ID";
            this.colWordID.FieldName = "StrCourseID";
            this.colWordID.MinWidth = 27;
            this.colWordID.Name = "colWordID";
            this.colWordID.Visible = true;
            this.colWordID.VisibleIndex = 0;
            this.colWordID.Width = 100;
            // 
            // colYearStart
            // 
            this.colYearStart.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colYearStart.AppearanceCell.Options.UseFont = true;
            this.colYearStart.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colYearStart.AppearanceHeader.Options.UseFont = true;
            this.colYearStart.Caption = "ID";
            this.colYearStart.FieldName = "DtStartYear";
            this.colYearStart.MinWidth = 27;
            this.colYearStart.Name = "colYearStart";
            this.colYearStart.Visible = true;
            this.colYearStart.VisibleIndex = 1;
            this.colYearStart.Width = 100;
            // 
            // colYearEnd
            // 
            this.colYearEnd.AppearanceCell.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colYearEnd.AppearanceCell.Options.UseFont = true;
            this.colYearEnd.AppearanceHeader.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.colYearEnd.AppearanceHeader.Options.UseFont = true;
            this.colYearEnd.Caption = "Năm kết thúc";
            this.colYearEnd.FieldName = "DtEndYear";
            this.colYearEnd.MinWidth = 27;
            this.colYearEnd.Name = "colYearEnd";
            this.colYearEnd.Visible = true;
            this.colYearEnd.VisibleIndex = 2;
            this.colYearEnd.Width = 100;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(241, 87);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(100, 20);
            this.lookUpEdit1.TabIndex = 127;
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Location = new System.Drawing.Point(241, 127);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Size = new System.Drawing.Size(100, 20);
            this.lookUpEdit2.TabIndex = 128;
            // 
            // frmWorldList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 588);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmWorldList";
            this.Text = "frmWorldList";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcListCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraGrid.GridControl gcListCourse;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListCourse;
        private DevExpress.XtraGrid.Columns.GridColumn colWordID;
        private DevExpress.XtraGrid.Columns.GridColumn colYearStart;
        private DevExpress.XtraGrid.Columns.GridColumn colYearEnd;
    }
}