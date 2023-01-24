namespace Session_11 {
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
            this.grvEngineers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColEngineerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColEngineerSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdColEngineerManager = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repManagers = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repManagersView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColEngineerSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdServiceTasks = new DevExpress.XtraGrid.GridControl();
            this.grvServiceTasks = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colServiceTaskCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceTaskDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceTaskHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdTransactions = new DevExpress.XtraGrid.GridControl();
            this.grvTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdManager = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvManagers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdManagers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEngineers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEngineers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repManagers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repManagersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiceTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvServiceTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            // 
            // grvManagers
            // 
            this.grvManagers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColName,
            this.grdColSurname,
            this.grdColSalary});
            this.grvManagers.DetailHeight = 437;
            this.grvManagers.GridControl = this.grdManagers;
            this.grvManagers.Name = "grvManagers";
            // 
            // grdColName
            // 
            this.grdColName.Caption = "Name";
            this.grdColName.FieldName = "Name";
            this.grdColName.MinWidth = 31;
            this.grdColName.Name = "grdColName";
            this.grdColName.Visible = true;
            this.grdColName.VisibleIndex = 0;
            this.grdColName.Width = 117;
            // 
            // grdColSurname
            // 
            this.grdColSurname.Caption = "Surname";
            this.grdColSurname.FieldName = "Surname";
            this.grdColSurname.MinWidth = 31;
            this.grdColSurname.Name = "grdColSurname";
            this.grdColSurname.Visible = true;
            this.grdColSurname.VisibleIndex = 1;
            this.grdColSurname.Width = 117;
            // 
            // grdColSalary
            // 
            this.grdColSalary.Caption = "Month Salary";
            this.grdColSalary.FieldName = "SalaryPerMonth";
            this.grdColSalary.MinWidth = 31;
            this.grdColSalary.Name = "grdColSalary";
            this.grdColSalary.Visible = true;
            this.grdColSalary.VisibleIndex = 2;
            this.grdColSalary.Width = 117;
            // 
            // grdManagers
            // 
            this.grdManagers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdManagers.Location = new System.Drawing.Point(4, 4);
            this.grdManagers.MainView = this.grvManagers;
            this.grdManagers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdManagers.Name = "grdManagers";
            this.grdManagers.Size = new System.Drawing.Size(625, 312);
            this.grdManagers.TabIndex = 1;
            this.grdManagers.UseEmbeddedNavigator = true;
            this.grdManagers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvManagers});
            // 
            // grdEngineers
            // 
            this.grdEngineers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdEngineers.Location = new System.Drawing.Point(4, 328);
            this.grdEngineers.MainView = this.grvEngineers;
            this.grdEngineers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdEngineers.Name = "grdEngineers";
            this.grdEngineers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repManagers});
            this.grdEngineers.Size = new System.Drawing.Size(625, 312);
            this.grdEngineers.TabIndex = 3;
            this.grdEngineers.UseEmbeddedNavigator = true;
            this.grdEngineers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvEngineers});
            // 
            // grvEngineers
            // 
            this.grvEngineers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColEngineerName,
            this.grdColEngineerSurname,
            this.grdColEngineerManager,
            this.grdColEngineerSalary});
            this.grvEngineers.DetailHeight = 437;
            this.grvEngineers.GridControl = this.grdEngineers;
            this.grvEngineers.Name = "grvEngineers";
            // 
            // grdColEngineerName
            // 
            this.grdColEngineerName.Caption = "Name";
            this.grdColEngineerName.FieldName = "Name";
            this.grdColEngineerName.MinWidth = 31;
            this.grdColEngineerName.Name = "grdColEngineerName";
            this.grdColEngineerName.Visible = true;
            this.grdColEngineerName.VisibleIndex = 0;
            this.grdColEngineerName.Width = 117;
            // 
            // grdColEngineerSurname
            // 
            this.grdColEngineerSurname.Caption = "Surname";
            this.grdColEngineerSurname.FieldName = "Surname";
            this.grdColEngineerSurname.MinWidth = 31;
            this.grdColEngineerSurname.Name = "grdColEngineerSurname";
            this.grdColEngineerSurname.Visible = true;
            this.grdColEngineerSurname.VisibleIndex = 1;
            this.grdColEngineerSurname.Width = 117;
            // 
            // grdColEngineerManager
            // 
            this.grdColEngineerManager.Caption = "Manager";
            this.grdColEngineerManager.ColumnEdit = this.repManagers;
            this.grdColEngineerManager.FieldName = "ManagerID";
            this.grdColEngineerManager.MinWidth = 31;
            this.grdColEngineerManager.Name = "grdColEngineerManager";
            this.grdColEngineerManager.Visible = true;
            this.grdColEngineerManager.VisibleIndex = 2;
            this.grdColEngineerManager.Width = 117;
            // 
            // repManagers
            // 
            this.repManagers.AutoHeight = false;
            this.repManagers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repManagers.Name = "repManagers";
            this.repManagers.PopupView = this.repManagersView;
            // 
            // repManagersView
            // 
            this.repManagersView.DetailHeight = 437;
            this.repManagersView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repManagersView.Name = "repManagersView";
            this.repManagersView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repManagersView.OptionsView.ShowGroupPanel = false;
            // 
            // grdColEngineerSalary
            // 
            this.grdColEngineerSalary.Caption = "Month Salary";
            this.grdColEngineerSalary.FieldName = "SalaryPerMonth";
            this.grdColEngineerSalary.MinWidth = 31;
            this.grdColEngineerSalary.Name = "grdColEngineerSalary";
            this.grdColEngineerSalary.Visible = true;
            this.grdColEngineerSalary.VisibleIndex = 3;
            this.grdColEngineerSalary.Width = 117;
            // 
            // grdServiceTasks
            // 
            this.grdServiceTasks.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdServiceTasks.Location = new System.Drawing.Point(709, 4);
            this.grdServiceTasks.MainView = this.grvServiceTasks;
            this.grdServiceTasks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grdServiceTasks.Name = "grdServiceTasks";
            this.grdServiceTasks.Size = new System.Drawing.Size(625, 312);
            this.grdServiceTasks.TabIndex = 4;
            this.grdServiceTasks.UseEmbeddedNavigator = true;
            this.grdServiceTasks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvServiceTasks});
            // 
            // grvServiceTasks
            // 
            this.grvServiceTasks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colServiceTaskCode,
            this.colServiceTaskDescription,
            this.colServiceTaskHours});
            this.grvServiceTasks.DetailHeight = 437;
            this.grvServiceTasks.GridControl = this.grdServiceTasks;
            this.grvServiceTasks.Name = "grvServiceTasks";
            this.grvServiceTasks.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvServiceTasks_CellValueChanging);
            // 
            // colServiceTaskCode
            // 
            this.colServiceTaskCode.Caption = "Code";
            this.colServiceTaskCode.FieldName = "Code";
            this.colServiceTaskCode.MinWidth = 31;
            this.colServiceTaskCode.Name = "colServiceTaskCode";
            this.colServiceTaskCode.Visible = true;
            this.colServiceTaskCode.VisibleIndex = 0;
            this.colServiceTaskCode.Width = 117;
            // 
            // colServiceTaskDescription
            // 
            this.colServiceTaskDescription.Caption = "Description";
            this.colServiceTaskDescription.FieldName = "Description";
            this.colServiceTaskDescription.MinWidth = 31;
            this.colServiceTaskDescription.Name = "colServiceTaskDescription";
            this.colServiceTaskDescription.Visible = true;
            this.colServiceTaskDescription.VisibleIndex = 1;
            this.colServiceTaskDescription.Width = 117;
            // 
            // colServiceTaskHours
            // 
            this.colServiceTaskHours.Caption = "Hours";
            this.colServiceTaskHours.FieldName = "Hours";
            this.colServiceTaskHours.MinWidth = 31;
            this.colServiceTaskHours.Name = "colServiceTaskHours";
            this.colServiceTaskHours.Visible = true;
            this.colServiceTaskHours.VisibleIndex = 2;
            this.colServiceTaskHours.Width = 117;
            // 
            // grdTransactions
            // 
            this.grdTransactions.Location = new System.Drawing.Point(709, 328);
            this.grdTransactions.MainView = this.grvTransactions;
            this.grdTransactions.Name = "grdTransactions";
            this.grdTransactions.Size = new System.Drawing.Size(625, 312);
            this.grdTransactions.TabIndex = 5;
            this.grdTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactions});
            // 
            // grvTransactions
            // 
            this.grvTransactions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdDate,
            this.grdCustomerName,
            this.grdCar,
            this.grdManager,
            this.grdTotalPrice});
            this.grvTransactions.GridControl = this.grdTransactions;
            this.grvTransactions.Name = "grvTransactions";
            // 
            // grdDate
            // 
            this.grdDate.Caption = "Date";
            this.grdDate.FieldName = "Date";
            this.grdDate.MinWidth = 30;
            this.grdDate.Name = "grdDate";
            this.grdDate.Visible = true;
            this.grdDate.VisibleIndex = 0;
            this.grdDate.Width = 112;
            // 
            // grdCustomerName
            // 
            this.grdCustomerName.Caption = "Customer Name";
            this.grdCustomerName.FieldName = "CustomerID";
            this.grdCustomerName.MinWidth = 30;
            this.grdCustomerName.Name = "grdCustomerName";
            this.grdCustomerName.Visible = true;
            this.grdCustomerName.VisibleIndex = 1;
            this.grdCustomerName.Width = 112;
            // 
            // grdCar
            // 
            this.grdCar.Caption = "Car";
            this.grdCar.FieldName = "CarID";
            this.grdCar.MinWidth = 30;
            this.grdCar.Name = "grdCar";
            this.grdCar.Visible = true;
            this.grdCar.VisibleIndex = 2;
            this.grdCar.Width = 112;
            // 
            // grdManager
            // 
            this.grdManager.Caption = "Manager";
            this.grdManager.FieldName = "ManagerID";
            this.grdManager.MinWidth = 30;
            this.grdManager.Name = "grdManager";
            this.grdManager.Visible = true;
            this.grdManager.VisibleIndex = 3;
            this.grdManager.Width = 112;
            // 
            // grdTotalPrice
            // 
            this.grdTotalPrice.Caption = "Total Price";
            this.grdTotalPrice.FieldName = "TotalPrice";
            this.grdTotalPrice.MinWidth = 30;
            this.grdTotalPrice.Name = "grdTotalPrice";
            this.grdTotalPrice.Visible = true;
            this.grdTotalPrice.VisibleIndex = 4;
            this.grdTotalPrice.Width = 112;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1850, 956);
            this.Controls.Add(this.grdTransactions);
            this.Controls.Add(this.grdServiceTasks);
            this.Controls.Add(this.grdEngineers);
            this.Controls.Add(this.grdManagers);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.grvManagers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdManagers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEngineers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEngineers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repManagers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repManagersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiceTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvServiceTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView grvEngineers;
        private DevExpress.XtraGrid.Columns.GridColumn grdColEngineerName;
        private DevExpress.XtraGrid.Columns.GridColumn grdColEngineerSurname;
        private DevExpress.XtraGrid.Columns.GridColumn grdColEngineerManager;
        private DevExpress.XtraGrid.Columns.GridColumn grdColEngineerSalary;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repManagers;
        private DevExpress.XtraGrid.Views.Grid.GridView repManagersView;
        private DevExpress.XtraGrid.GridControl grdServiceTasks;
        private DevExpress.XtraGrid.Views.Grid.GridView grvServiceTasks;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceTaskCode;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceTaskDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceTaskHours;
        private DevExpress.XtraGrid.GridControl grdTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTransactions;
        private DevExpress.XtraGrid.Columns.GridColumn grdDate;
        private DevExpress.XtraGrid.Columns.GridColumn grdCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn grdCar;
        private DevExpress.XtraGrid.Columns.GridColumn grdManager;
        private DevExpress.XtraGrid.Columns.GridColumn grdTotalPrice;
    }
}