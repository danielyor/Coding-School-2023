namespace Session_11 {
    partial class EngineerForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.grdEngineers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridEngineerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridEngineerSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridSalaryPerMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdServiceTasks = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridHours = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdEngineers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiceTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdEngineers
            // 
            this.grdEngineers.Location = new System.Drawing.Point(12, 12);
            this.grdEngineers.MainView = this.gridView1;
            this.grdEngineers.Name = "grdEngineers";
            this.grdEngineers.Size = new System.Drawing.Size(738, 216);
            this.grdEngineers.TabIndex = 0;
            this.grdEngineers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridEngineerName,
            this.gridEngineerSurname,
            this.gridSalaryPerMonth});
            this.gridView1.GridControl = this.grdEngineers;
            this.gridView1.Name = "gridView1";
            // 
            // gridEngineerName
            // 
            this.gridEngineerName.Caption = "Name";
            this.gridEngineerName.FieldName = "Name";
            this.gridEngineerName.MinWidth = 30;
            this.gridEngineerName.Name = "gridEngineerName";
            this.gridEngineerName.Visible = true;
            this.gridEngineerName.VisibleIndex = 0;
            this.gridEngineerName.Width = 112;
            // 
            // gridEngineerSurname
            // 
            this.gridEngineerSurname.Caption = "Surname";
            this.gridEngineerSurname.FieldName = "Surname";
            this.gridEngineerSurname.MinWidth = 30;
            this.gridEngineerSurname.Name = "gridEngineerSurname";
            this.gridEngineerSurname.Visible = true;
            this.gridEngineerSurname.VisibleIndex = 1;
            this.gridEngineerSurname.Width = 112;
            // 
            // gridSalaryPerMonth
            // 
            this.gridSalaryPerMonth.Caption = "Salary";
            this.gridSalaryPerMonth.FieldName = "SalaryPerMonth";
            this.gridSalaryPerMonth.MinWidth = 30;
            this.gridSalaryPerMonth.Name = "gridSalaryPerMonth";
            this.gridSalaryPerMonth.Visible = true;
            this.gridSalaryPerMonth.VisibleIndex = 2;
            this.gridSalaryPerMonth.Width = 112;
            // 
            // grdServiceTasks
            // 
            this.grdServiceTasks.Location = new System.Drawing.Point(12, 252);
            this.grdServiceTasks.MainView = this.gridView2;
            this.grdServiceTasks.Name = "grdServiceTasks";
            this.grdServiceTasks.Size = new System.Drawing.Size(738, 186);
            this.grdServiceTasks.TabIndex = 1;
            this.grdServiceTasks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridCode,
            this.Description,
            this.gridHours});
            this.gridView2.GridControl = this.grdServiceTasks;
            this.gridView2.Name = "gridView2";
            // 
            // gridCode
            // 
            this.gridCode.Caption = "Code";
            this.gridCode.MinWidth = 30;
            this.gridCode.Name = "gridCode";
            this.gridCode.Visible = true;
            this.gridCode.VisibleIndex = 0;
            this.gridCode.Width = 112;
            // 
            // Description
            // 
            this.Description.Caption = "Description";
            this.Description.FieldName = "Description";
            this.Description.MinWidth = 30;
            this.Description.Name = "Description";
            this.Description.Visible = true;
            this.Description.VisibleIndex = 1;
            this.Description.Width = 112;
            // 
            // gridHours
            // 
            this.gridHours.Caption = "Hours";
            this.gridHours.FieldName = "Hours";
            this.gridHours.MinWidth = 30;
            this.gridHours.Name = "gridHours";
            this.gridHours.Visible = true;
            this.gridHours.VisibleIndex = 2;
            this.gridHours.Width = 112;
            // 
            // EngineerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdServiceTasks);
            this.Controls.Add(this.grdEngineers);
            this.Name = "EngineerForm";
            this.Text = "EngineerForm";
            this.Load += new System.EventHandler(this.EngineerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEngineers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiceTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdEngineers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridEngineerName;
        private DevExpress.XtraGrid.Columns.GridColumn gridEngineerSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gridSalaryPerMonth;
        private DevExpress.XtraGrid.GridControl grdServiceTasks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridCode;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn gridHours;
    }
}