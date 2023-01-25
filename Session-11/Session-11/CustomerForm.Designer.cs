namespace Session_11 {
    partial class CustomerForm {
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
            this.grdCustomers = new DevExpress.XtraGrid.GridControl();
            this.bsCustomerOrder = new System.Windows.Forms.BindingSource(this.components);
            this.grvCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerTIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.bsCars = new System.Windows.Forms.BindingSource(this.components);
            this.bsServiceTask = new System.Windows.Forms.BindingSource(this.components);
            this.grdCars = new DevExpress.XtraGrid.GridControl();
            this.gcvCars = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCarsBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarsModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarsRegistration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdServiceTasks = new DevExpress.XtraGrid.GridControl();
            this.grvServiceTasks = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colServiceTasksCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceTasksDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceTasksHours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPopulate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomerOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServiceTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcvCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiceTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvServiceTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCustomers
            // 
            this.grdCustomers.DataSource = this.bsCustomerOrder;
            this.grdCustomers.Location = new System.Drawing.Point(21, 4);
            this.grdCustomers.MainView = this.grvCustomers;
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(748, 207);
            this.grdCustomers.TabIndex = 0;
            this.grdCustomers.UseEmbeddedNavigator = true;
            this.grdCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCustomers});
            // 
            // bsCustomerOrder
            // 
            this.bsCustomerOrder.DataSource = typeof(LibCarService.Customer);
            // 
            // grvCustomers
            // 
            this.grvCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerName,
            this.colCustomerSurname,
            this.colCustomerPhone,
            this.colCustomerTIN});
            this.grvCustomers.GridControl = this.grdCustomers;
            this.grvCustomers.Name = "grvCustomers";
            this.grvCustomers.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.grvCustomers.OptionsView.ShowGroupPanel = false;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Name";
            this.colCustomerName.FieldName = "Name";
            this.colCustomerName.MinWidth = 25;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 0;
            this.colCustomerName.Width = 94;
            // 
            // colCustomerSurname
            // 
            this.colCustomerSurname.Caption = "Surname";
            this.colCustomerSurname.FieldName = "Surname";
            this.colCustomerSurname.MinWidth = 25;
            this.colCustomerSurname.Name = "colCustomerSurname";
            this.colCustomerSurname.Visible = true;
            this.colCustomerSurname.VisibleIndex = 1;
            this.colCustomerSurname.Width = 94;
            // 
            // colCustomerPhone
            // 
            this.colCustomerPhone.Caption = "Phone";
            this.colCustomerPhone.FieldName = "Phone";
            this.colCustomerPhone.MinWidth = 25;
            this.colCustomerPhone.Name = "colCustomerPhone";
            this.colCustomerPhone.Visible = true;
            this.colCustomerPhone.VisibleIndex = 2;
            this.colCustomerPhone.Width = 94;
            // 
            // colCustomerTIN
            // 
            this.colCustomerTIN.Caption = "TIN";
            this.colCustomerTIN.FieldName = "TIN";
            this.colCustomerTIN.MinWidth = 25;
            this.colCustomerTIN.Name = "colCustomerTIN";
            this.colCustomerTIN.Visible = true;
            this.colCustomerTIN.VisibleIndex = 3;
            this.colCustomerTIN.Width = 94;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(299, 669);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 36);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(199, 669);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 36);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // bsCars
            // 
            this.bsCars.DataSource = typeof(LibCarService.Car);
            // 
            // bsServiceTask
            // 
            this.bsServiceTask.DataSource = typeof(LibCarService.ServiceTask);
            // 
            // grdCars
            // 
            this.grdCars.Location = new System.Drawing.Point(21, 213);
            this.grdCars.MainView = this.gcvCars;
            this.grdCars.Name = "grdCars";
            this.grdCars.Size = new System.Drawing.Size(748, 207);
            this.grdCars.TabIndex = 6;
            this.grdCars.UseEmbeddedNavigator = true;
            this.grdCars.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcvCars});
            // 
            // gcvCars
            // 
            this.gcvCars.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCarsBrand,
            this.colCarsModel,
            this.colCarsRegistration});
            this.gcvCars.GridControl = this.grdCars;
            this.gcvCars.Name = "gcvCars";
            this.gcvCars.OptionsView.ShowGroupPanel = false;
            // 
            // colCarsBrand
            // 
            this.colCarsBrand.Caption = "Brand";
            this.colCarsBrand.FieldName = "Brand";
            this.colCarsBrand.MinWidth = 25;
            this.colCarsBrand.Name = "colCarsBrand";
            this.colCarsBrand.Visible = true;
            this.colCarsBrand.VisibleIndex = 1;
            this.colCarsBrand.Width = 94;
            // 
            // colCarsModel
            // 
            this.colCarsModel.Caption = "Model";
            this.colCarsModel.FieldName = "Model";
            this.colCarsModel.MinWidth = 25;
            this.colCarsModel.Name = "colCarsModel";
            this.colCarsModel.Visible = true;
            this.colCarsModel.VisibleIndex = 0;
            this.colCarsModel.Width = 94;
            // 
            // colCarsRegistration
            // 
            this.colCarsRegistration.Caption = "Registration";
            this.colCarsRegistration.FieldName = "CarRegistrationNumber";
            this.colCarsRegistration.MinWidth = 25;
            this.colCarsRegistration.Name = "colCarsRegistration";
            this.colCarsRegistration.Visible = true;
            this.colCarsRegistration.VisibleIndex = 2;
            this.colCarsRegistration.Width = 94;
            // 
            // grdServiceTasks
            // 
            this.grdServiceTasks.Location = new System.Drawing.Point(20, 426);
            this.grdServiceTasks.MainView = this.grvServiceTasks;
            this.grdServiceTasks.Name = "grdServiceTasks";
            this.grdServiceTasks.Size = new System.Drawing.Size(748, 207);
            this.grdServiceTasks.TabIndex = 7;
            this.grdServiceTasks.UseEmbeddedNavigator = true;
            this.grdServiceTasks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvServiceTasks});
            // 
            // grvServiceTasks
            // 
            this.grvServiceTasks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colServiceTasksCode,
            this.colServiceTasksDescription,
            this.colServiceTasksHours});
            this.grvServiceTasks.GridControl = this.grdServiceTasks;
            this.grvServiceTasks.Name = "grvServiceTasks";
            this.grvServiceTasks.OptionsView.ShowGroupPanel = false;
            this.grvServiceTasks.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grvServiceTasks_CellValueChanging);
            // 
            // colServiceTasksCode
            // 
            this.colServiceTasksCode.Caption = "Code";
            this.colServiceTasksCode.FieldName = "Code";
            this.colServiceTasksCode.MinWidth = 25;
            this.colServiceTasksCode.Name = "colServiceTasksCode";
            this.colServiceTasksCode.Visible = true;
            this.colServiceTasksCode.VisibleIndex = 0;
            this.colServiceTasksCode.Width = 94;
            // 
            // colServiceTasksDescription
            // 
            this.colServiceTasksDescription.Caption = "Description";
            this.colServiceTasksDescription.FieldName = "Description";
            this.colServiceTasksDescription.MinWidth = 25;
            this.colServiceTasksDescription.Name = "colServiceTasksDescription";
            this.colServiceTasksDescription.OptionsColumn.ReadOnly = true;
            this.colServiceTasksDescription.Visible = true;
            this.colServiceTasksDescription.VisibleIndex = 1;
            this.colServiceTasksDescription.Width = 94;
            // 
            // colServiceTasksHours
            // 
            this.colServiceTasksHours.Caption = "Hours";
            this.colServiceTasksHours.FieldName = "Hours";
            this.colServiceTasksHours.MinWidth = 25;
            this.colServiceTasksHours.Name = "colServiceTasksHours";
            this.colServiceTasksHours.OptionsColumn.ReadOnly = true;
            this.colServiceTasksHours.Visible = true;
            this.colServiceTasksHours.VisibleIndex = 2;
            this.colServiceTasksHours.Width = 94;
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(399, 669);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(94, 36);
            this.btnPopulate.TabIndex = 8;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 717);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.grdServiceTasks);
            this.Controls.Add(this.grdCars);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.grdCustomers);
            this.Name = "CustomerForm";
            this.Text = "Customer Form";
            this.Load += new System.EventHandler(this.CustomerForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomerOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServiceTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdServiceTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvServiceTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerTIN;
        private BindingSource bsCustomerOrder;
        private Button btnSend;
        private Button btnLoad;
        private BindingSource bsCars;
        private BindingSource bsServiceTask;
        private DevExpress.XtraGrid.GridControl grdCars;
        private DevExpress.XtraGrid.Views.Grid.GridView gcvCars;
        private DevExpress.XtraGrid.Columns.GridColumn colCarsBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colCarsModel;
        private DevExpress.XtraGrid.Columns.GridColumn colCarsRegistration;
        private DevExpress.XtraGrid.GridControl grdServiceTasks;
        private DevExpress.XtraGrid.Views.Grid.GridView grvServiceTasks;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceTasksCode;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceTasksDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceTasksHours;
        private DevExpress.XtraEditors.SimpleButton btnPopulate;
    }
}