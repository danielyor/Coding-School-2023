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
            this.gcCustomerOrder = new DevExpress.XtraGrid.GridControl();
            this.gcvCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerTIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsCustomerOrder = new System.Windows.Forms.BindingSource(this.components);
            this.dgv2CustomerOrder = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgv2Cars = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carRegistrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCars = new System.Windows.Forms.BindingSource(this.components);
            this.dgv2ServiceTask = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsServiceTask = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomerOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2CustomerOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2Cars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2ServiceTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServiceTask)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCustomerOrder
            // 
            this.gcCustomerOrder.DataSource = this.bsCustomerOrder;
            this.gcCustomerOrder.Location = new System.Drawing.Point(21, 23);
            this.gcCustomerOrder.MainView = this.gcvCustomer;
            this.gcCustomerOrder.Name = "gcCustomerOrder";
            this.gcCustomerOrder.Size = new System.Drawing.Size(748, 97);
            this.gcCustomerOrder.TabIndex = 0;
            this.gcCustomerOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcvCustomer});
            // 
            // gcvCustomer
            // 
            this.gcvCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerName,
            this.colCustomerSurname,
            this.colCustomerPhone,
            this.colCustomerTIN});
            this.gcvCustomer.GridControl = this.gcCustomerOrder;
            this.gcvCustomer.Name = "gcvCustomer";
            this.gcvCustomer.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gcvCustomer.OptionsView.ShowGroupPanel = false;
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
            // bsCustomerOrder
            // 
            this.bsCustomerOrder.DataSource = typeof(LibCarService.Customer);
            // 
            // dgv2CustomerOrder
            // 
            this.dgv2CustomerOrder.AutoGenerateColumns = false;
            this.dgv2CustomerOrder.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv2CustomerOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2CustomerOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.tINDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dgv2CustomerOrder.DataSource = this.bsCustomerOrder;
            this.dgv2CustomerOrder.Location = new System.Drawing.Point(21, 126);
            this.dgv2CustomerOrder.Name = "dgv2CustomerOrder";
            this.dgv2CustomerOrder.RowHeadersWidth = 51;
            this.dgv2CustomerOrder.RowTemplate.Height = 29;
            this.dgv2CustomerOrder.Size = new System.Drawing.Size(748, 135);
            this.dgv2CustomerOrder.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // tINDataGridViewTextBoxColumn
            // 
            this.tINDataGridViewTextBoxColumn.DataPropertyName = "TIN";
            this.tINDataGridViewTextBoxColumn.HeaderText = "TIN";
            this.tINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tINDataGridViewTextBoxColumn.Name = "tINDataGridViewTextBoxColumn";
            this.tINDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(835, 91);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 29);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(835, 32);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgv2Cars
            // 
            this.dgv2Cars.AutoGenerateColumns = false;
            this.dgv2Cars.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv2Cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2Cars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.carRegistrationNumberDataGridViewTextBoxColumn});
            this.dgv2Cars.DataSource = this.bsCars;
            this.dgv2Cars.Location = new System.Drawing.Point(21, 267);
            this.dgv2Cars.Name = "dgv2Cars";
            this.dgv2Cars.RowHeadersWidth = 51;
            this.dgv2Cars.RowTemplate.Height = 29;
            this.dgv2Cars.Size = new System.Drawing.Size(748, 134);
            this.dgv2Cars.TabIndex = 4;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            this.iDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // carRegistrationNumberDataGridViewTextBoxColumn
            // 
            this.carRegistrationNumberDataGridViewTextBoxColumn.DataPropertyName = "CarRegistrationNumber";
            this.carRegistrationNumberDataGridViewTextBoxColumn.HeaderText = "CarRegistrationNumber";
            this.carRegistrationNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carRegistrationNumberDataGridViewTextBoxColumn.Name = "carRegistrationNumberDataGridViewTextBoxColumn";
            this.carRegistrationNumberDataGridViewTextBoxColumn.Width = 180;
            // 
            // bsCars
            // 
            this.bsCars.DataSource = typeof(LibCarService.Car);
            // 
            // dgv2ServiceTask
            // 
            this.dgv2ServiceTask.AutoGenerateColumns = false;
            this.dgv2ServiceTask.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv2ServiceTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2ServiceTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.colCode,
            this.descriptionDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn});
            this.dgv2ServiceTask.DataSource = this.bsServiceTask;
            this.dgv2ServiceTask.Location = new System.Drawing.Point(21, 421);
            this.dgv2ServiceTask.Name = "dgv2ServiceTask";
            this.dgv2ServiceTask.RowHeadersWidth = 51;
            this.dgv2ServiceTask.RowTemplate.Height = 29;
            this.dgv2ServiceTask.Size = new System.Drawing.Size(748, 142);
            this.dgv2ServiceTask.TabIndex = 5;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.Visible = false;
            this.iDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "Service Task";
            this.colCode.MinimumWidth = 6;
            this.colCode.Name = "colCode";
            this.colCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCode.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "Hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "Hours";
            this.hoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            this.hoursDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsServiceTask
            // 
            this.bsServiceTask.DataSource = typeof(LibCarService.ServiceTask);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 636);
            this.Controls.Add(this.dgv2ServiceTask);
            this.Controls.Add(this.dgv2Cars);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.dgv2CustomerOrder);
            this.Controls.Add(this.gcCustomerOrder);
            this.Name = "CustomerForm";
            this.Text = "Customer Form";
            this.Load += new System.EventHandler(this.CustomerForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomerOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomerOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2CustomerOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2Cars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2ServiceTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServiceTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCustomerOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gcvCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerTIN;
        private BindingSource bsCustomerOrder;
        private DataGridView dgv2CustomerOrder;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tINDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private Button btnSend;
        private Button btnLoad;
        private DataGridView dgv2Cars;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carRegistrationNumberDataGridViewTextBoxColumn;
        private BindingSource bsCars;
        private DataGridView dgv2ServiceTask;
        private BindingSource bsServiceTask;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private DataGridViewComboBoxColumn colCode;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
    }
}