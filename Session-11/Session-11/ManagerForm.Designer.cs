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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.repCustomers = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdCar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCars = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdManager = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repManagers2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionsViewBtn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTransactionLinesViewBtn = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.grdTransactionLines = new DevExpress.XtraGrid.GridControl();
            this.grvTransactionLines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.repCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repManagers2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTransactionLinesViewBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).BeginInit();
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
            this.grdEngineers.Location = new System.Drawing.Point(3, 262);
            this.grdEngineers.MainView = this.grvEngineers;
            this.grdEngineers.Name = "grdEngineers";
            this.grdEngineers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repManagers});
            this.grdEngineers.Size = new System.Drawing.Size(500, 250);
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
            this.grvEngineers.GridControl = this.grdEngineers;
            this.grvEngineers.Name = "grvEngineers";
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
            this.grdColEngineerManager.ColumnEdit = this.repManagers;
            this.grdColEngineerManager.FieldName = "ManagerID";
            this.grdColEngineerManager.MinWidth = 25;
            this.grdColEngineerManager.Name = "grdColEngineerManager";
            this.grdColEngineerManager.Visible = true;
            this.grdColEngineerManager.VisibleIndex = 2;
            this.grdColEngineerManager.Width = 94;
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
            this.repManagersView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repManagersView.Name = "repManagersView";
            this.repManagersView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repManagersView.OptionsView.ShowGroupPanel = false;
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
            // grdServiceTasks
            // 
            this.grdServiceTasks.Location = new System.Drawing.Point(567, 3);
            this.grdServiceTasks.MainView = this.grvServiceTasks;
            this.grdServiceTasks.Name = "grdServiceTasks";
            this.grdServiceTasks.Size = new System.Drawing.Size(500, 250);
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
            this.grvServiceTasks.GridControl = this.grdServiceTasks;
            this.grvServiceTasks.Name = "grvServiceTasks";
            this.grvServiceTasks.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvServiceTasks_CellValueChanging);
            // 
            // colServiceTaskCode
            // 
            this.colServiceTaskCode.Caption = "Code";
            this.colServiceTaskCode.FieldName = "Code";
            this.colServiceTaskCode.MinWidth = 25;
            this.colServiceTaskCode.Name = "colServiceTaskCode";
            this.colServiceTaskCode.Visible = true;
            this.colServiceTaskCode.VisibleIndex = 0;
            this.colServiceTaskCode.Width = 94;
            // 
            // colServiceTaskDescription
            // 
            this.colServiceTaskDescription.Caption = "Description";
            this.colServiceTaskDescription.FieldName = "Description";
            this.colServiceTaskDescription.MinWidth = 25;
            this.colServiceTaskDescription.Name = "colServiceTaskDescription";
            this.colServiceTaskDescription.Visible = true;
            this.colServiceTaskDescription.VisibleIndex = 1;
            this.colServiceTaskDescription.Width = 94;
            // 
            // colServiceTaskHours
            // 
            this.colServiceTaskHours.Caption = "Hours";
            this.colServiceTaskHours.FieldName = "Hours";
            this.colServiceTaskHours.MinWidth = 25;
            this.colServiceTaskHours.Name = "colServiceTaskHours";
            this.colServiceTaskHours.Visible = true;
            this.colServiceTaskHours.VisibleIndex = 2;
            this.colServiceTaskHours.Width = 94;
            // 
            // grdTransactions
            // 
            this.grdTransactions.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grdTransactions.Location = new System.Drawing.Point(567, 262);
            this.grdTransactions.MainView = this.grvTransactions;
            this.grdTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.grdTransactions.Name = "grdTransactions";
            this.grdTransactions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repCars,
            this.repCustomers,
            this.repManagers2,
            this.repTransactionLinesViewBtn});
            this.grdTransactions.Size = new System.Drawing.Size(500, 363);
            this.grdTransactions.TabIndex = 5;
            this.grdTransactions.UseEmbeddedNavigator = true;
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
            this.grdTotalPrice,
            this.colTransactionsViewBtn});
            this.grvTransactions.DetailHeight = 280;
            this.grvTransactions.GridControl = this.grdTransactions;
            this.grvTransactions.Name = "grvTransactions";
            // 
            // grdDate
            // 
            this.grdDate.Caption = "Date";
            this.grdDate.FieldName = "Date";
            this.grdDate.MinWidth = 24;
            this.grdDate.Name = "grdDate";
            this.grdDate.Visible = true;
            this.grdDate.VisibleIndex = 0;
            this.grdDate.Width = 90;
            // 
            // grdCustomerName
            // 
            this.grdCustomerName.Caption = "Customer Name";
            this.grdCustomerName.ColumnEdit = this.repCustomers;
            this.grdCustomerName.FieldName = "CustomerID";
            this.grdCustomerName.MinWidth = 24;
            this.grdCustomerName.Name = "grdCustomerName";
            this.grdCustomerName.Visible = true;
            this.grdCustomerName.VisibleIndex = 1;
            this.grdCustomerName.Width = 90;
            // 
            // repCustomers
            // 
            this.repCustomers.AutoHeight = false;
            this.repCustomers.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCustomers.Name = "repCustomers";
            this.repCustomers.PopupView = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 280;
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // grdCar
            // 
            this.grdCar.Caption = "Car";
            this.grdCar.ColumnEdit = this.repCars;
            this.grdCar.FieldName = "CarID";
            this.grdCar.MinWidth = 24;
            this.grdCar.Name = "grdCar";
            this.grdCar.Visible = true;
            this.grdCar.VisibleIndex = 2;
            this.grdCar.Width = 90;
            // 
            // repCars
            // 
            this.repCars.AutoHeight = false;
            this.repCars.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCars.Name = "repCars";
            this.repCars.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.DetailHeight = 280;
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // grdManager
            // 
            this.grdManager.Caption = "Manager";
            this.grdManager.ColumnEdit = this.repManagers2;
            this.grdManager.FieldName = "ManagerID";
            this.grdManager.MinWidth = 24;
            this.grdManager.Name = "grdManager";
            this.grdManager.Visible = true;
            this.grdManager.VisibleIndex = 3;
            this.grdManager.Width = 90;
            // 
            // repManagers2
            // 
            this.repManagers2.AutoHeight = false;
            this.repManagers2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repManagers2.Name = "repManagers2";
            this.repManagers2.PopupView = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 280;
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // grdTotalPrice
            // 
            this.grdTotalPrice.Caption = "Total Price";
            this.grdTotalPrice.FieldName = "TotalPrice";
            this.grdTotalPrice.MinWidth = 24;
            this.grdTotalPrice.Name = "grdTotalPrice";
            this.grdTotalPrice.Visible = true;
            this.grdTotalPrice.VisibleIndex = 4;
            this.grdTotalPrice.Width = 90;
            // 
            // colTransactionsViewBtn
            // 
            this.colTransactionsViewBtn.Caption = "Actions";
            this.colTransactionsViewBtn.ColumnEdit = this.repTransactionLinesViewBtn;
            this.colTransactionsViewBtn.FieldName = "colTransactionsViewBtn";
            this.colTransactionsViewBtn.MinWidth = 25;
            this.colTransactionsViewBtn.Name = "colTransactionsViewBtn";
            this.colTransactionsViewBtn.UnboundDataType = typeof(object);
            this.colTransactionsViewBtn.Visible = true;
            this.colTransactionsViewBtn.VisibleIndex = 5;
            this.colTransactionsViewBtn.Width = 94;
            // 
            // repTransactionLinesViewBtn
            // 
            this.repTransactionLinesViewBtn.AdvancedModeOptions.Label = "Details";
            this.repTransactionLinesViewBtn.AutoHeight = false;
            this.repTransactionLinesViewBtn.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Details", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repTransactionLinesViewBtn.Name = "repTransactionLinesViewBtn";
            this.repTransactionLinesViewBtn.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // grdTransactionLines
            // 
            this.grdTransactionLines.Location = new System.Drawing.Point(1073, 12);
            this.grdTransactionLines.MainView = this.grvTransactionLines;
            this.grdTransactionLines.Name = "grdTransactionLines";
            this.grdTransactionLines.Size = new System.Drawing.Size(626, 331);
            this.grdTransactionLines.TabIndex = 6;
            this.grdTransactionLines.UseEmbeddedNavigator = true;
            this.grdTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactionLines});
            // 
            // grvTransactionLines
            // 
            this.grvTransactionLines.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.grvTransactionLines.GridControl = this.grdTransactionLines;
            this.grvTransactionLines.Name = "grvTransactionLines";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Transac";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1814, 765);
            this.Controls.Add(this.grdTransactionLines);
            this.Controls.Add(this.grdTransactions);
            this.Controls.Add(this.grdServiceTasks);
            this.Controls.Add(this.grdEngineers);
            this.Controls.Add(this.grdManagers);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            ((System.ComponentModel.ISupportInitialize)(this.repCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repManagers2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTransactionLinesViewBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionLines)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repCars;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repManagers2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl grdTransactionLines;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTransactionLines;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionsViewBtn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repTransactionLinesViewBtn;
    }
}