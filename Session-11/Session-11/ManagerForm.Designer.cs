﻿namespace Session_11 {
    partial class ManagerForm {
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
            this.components = new System.ComponentModel.Container();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.grvManagers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdManagers = new DevExpress.XtraGrid.GridControl();
            this.grdEngineers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColEngineerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColEngineerSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColEngineerManager = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColEngineerSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvManagers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdManagers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEngineers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            // 
            // grvManagers
            // 
            this.grvManagers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColName,
            this.grdColSurname,
            this.grdColSalary});
            this.grvManagers.GridControl = this.grdManagers;
            this.grvManagers.Name = "grvManagers";
            // 
            // grdColName
            // 
            this.grdColName.Caption = "Name";
            this.grdColName.FieldName = "Name";
            this.grdColName.MinWidth = 25;
            this.grdColName.Name = "grdColName";
            this.grdColName.Visible = true;
            this.grdColName.VisibleIndex = 0;
            this.grdColName.Width = 94;
            // 
            // grdColSurname
            // 
            this.grdColSurname.Caption = "Surname";
            this.grdColSurname.FieldName = "Surname";
            this.grdColSurname.MinWidth = 25;
            this.grdColSurname.Name = "grdColSurname";
            this.grdColSurname.Visible = true;
            this.grdColSurname.VisibleIndex = 1;
            this.grdColSurname.Width = 94;
            // 
            // grdColSalary
            // 
            this.grdColSalary.Caption = "Month Salary";
            this.grdColSalary.FieldName = "SalaryPerMonth";
            this.grdColSalary.MinWidth = 25;
            this.grdColSalary.Name = "grdColSalary";
            this.grdColSalary.Visible = true;
            this.grdColSalary.VisibleIndex = 2;
            this.grdColSalary.Width = 94;
            // 
            // grdManagers
            // 
            this.grdManagers.Location = new System.Drawing.Point(3, 3);
            this.grdManagers.MainView = this.grvManagers;
            this.grdManagers.Name = "grdManagers";
            this.grdManagers.Size = new System.Drawing.Size(500, 250);
            this.grdManagers.TabIndex = 1;
            this.grdManagers.UseEmbeddedNavigator = true;
            this.grdManagers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvManagers});
            // 
            // grdEngineers
            // 
            this.grdEngineers.Location = new System.Drawing.Point(3, 273);
            this.grdEngineers.MainView = this.gridView1;
            this.grdEngineers.Name = "grdEngineers";
            this.grdEngineers.Size = new System.Drawing.Size(500, 250);
            this.grdEngineers.TabIndex = 3;
            this.grdEngineers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColEngineerName,
            this.grdColEngineerSurname,
            this.grdColEngineerManager,
            this.grdColEngineerSalary});
            this.gridView1.GridControl = this.grdEngineers;
            this.gridView1.Name = "gridView1";
            // 
            // grdColEngineerName
            // 
            this.grdColEngineerName.Caption = "Name";
            this.grdColEngineerName.FieldName = "Name";
            this.grdColEngineerName.MinWidth = 25;
            this.grdColEngineerName.Name = "grdColEngineerName";
            this.grdColEngineerName.Visible = true;
            this.grdColEngineerName.VisibleIndex = 0;
            this.grdColEngineerName.Width = 94;
            // 
            // grdColEngineerSurname
            // 
            this.grdColEngineerSurname.Caption = "Surname";
            this.grdColEngineerSurname.FieldName = "Surname";
            this.grdColEngineerSurname.MinWidth = 25;
            this.grdColEngineerSurname.Name = "grdColEngineerSurname";
            this.grdColEngineerSurname.Visible = true;
            this.grdColEngineerSurname.VisibleIndex = 1;
            this.grdColEngineerSurname.Width = 94;
            // 
            // grdColEngineerManager
            // 
            this.grdColEngineerManager.Caption = "Manager";
            this.grdColEngineerManager.FieldName = "ManagerID";
            this.grdColEngineerManager.MinWidth = 25;
            this.grdColEngineerManager.Name = "grdColEngineerManager";
            this.grdColEngineerManager.Visible = true;
            this.grdColEngineerManager.VisibleIndex = 2;
            this.grdColEngineerManager.Width = 94;
            // 
            // grdColEngineerSalary
            // 
            this.grdColEngineerSalary.Caption = "Month Salary";
            this.grdColEngineerSalary.FieldName = "SalaryPerMonth";
            this.grdColEngineerSalary.MinWidth = 25;
            this.grdColEngineerSalary.Name = "grdColEngineerSalary";
            this.grdColEngineerSalary.Visible = true;
            this.grdColEngineerSalary.VisibleIndex = 3;
            this.grdColEngineerSalary.Width = 94;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 600);
            this.Controls.Add(this.grdEngineers);
            this.Controls.Add(this.grdManagers);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.grvManagers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdManagers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEngineers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSalary;
        private DevExpress.XtraGrid.Views.Grid.GridView grvManagers;
        private DevExpress.XtraGrid.Columns.GridColumn grdColName;
        private DevExpress.XtraGrid.Columns.GridColumn grdColSurname;
        private DevExpress.XtraGrid.Columns.GridColumn grdColSalary;
        private DevExpress.XtraGrid.GridControl grdManagers;
        private DevExpress.XtraGrid.GridControl grdEngineers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grdColEngineerName;
        private DevExpress.XtraGrid.Columns.GridColumn grdColEngineerSurname;
        private DevExpress.XtraGrid.Columns.GridColumn grdColEngineerManager;
        private DevExpress.XtraGrid.Columns.GridColumn grdColEngineerSalary;
    }
}