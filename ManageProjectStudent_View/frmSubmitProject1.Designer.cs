namespace ManageProjectStudent_View
{
    partial class frmSubmitProject1
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
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNextListProject = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(59, 131);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(865, 165);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Danh sách đồ án ";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên môn học";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên đồ án";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // btnNextListProject
            // 
            this.btnNextListProject.AnimationHoverSpeed = 0.07F;
            this.btnNextListProject.AnimationSpeed = 0.03F;
            this.btnNextListProject.BaseColor = System.Drawing.Color.White;
            this.btnNextListProject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnNextListProject.BorderSize = 1;
            this.btnNextListProject.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNextListProject.FocusedColor = System.Drawing.Color.Empty;
            this.btnNextListProject.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextListProject.ForeColor = System.Drawing.Color.Black;
            this.btnNextListProject.Image = null;
            this.btnNextListProject.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNextListProject.Location = new System.Drawing.Point(385, 354);
            this.btnNextListProject.Name = "btnNextListProject";
            this.btnNextListProject.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(231)))), ((int)(((byte)(250)))));
            this.btnNextListProject.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnNextListProject.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnNextListProject.OnHoverImage = null;
            this.btnNextListProject.OnPressedColor = System.Drawing.Color.Empty;
            this.btnNextListProject.OnPressedDepth = 100;
            this.btnNextListProject.Size = new System.Drawing.Size(169, 27);
            this.btnNextListProject.TabIndex = 7;
            this.btnNextListProject.Text = "Kế tiếp";
            this.btnNextListProject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmSubmitProject1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 513);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnNextListProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSubmitProject1";
            this.Text = "frmSubmitProject1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private Guna.UI.WinForms.GunaButton btnNextListProject;
    }
}