namespace WinForms {
    partial class ManagerForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CustomersTab = new System.Windows.Forms.TabPage();
            this.customersGrd = new System.Windows.Forms.DataGridView();
            this.ItemsTab = new System.Windows.Forms.TabPage();
            this.itemsGrd = new System.Windows.Forms.DataGridView();
            this.TransactionsTab = new System.Windows.Forms.TabPage();
            this.transactionsGrd = new System.Windows.Forms.DataGridView();
            this.identityLabel = new System.Windows.Forms.Label();
            this.customersBS = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBS = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsBS = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.CustomersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrd)).BeginInit();
            this.ItemsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrd)).BeginInit();
            this.TransactionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBS)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.CustomersTab);
            this.tabControl1.Controls.Add(this.ItemsTab);
            this.tabControl1.Controls.Add(this.TransactionsTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // CustomersTab
            // 
            this.CustomersTab.Controls.Add(this.customersGrd);
            this.CustomersTab.Location = new System.Drawing.Point(4, 24);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTab.Size = new System.Drawing.Size(771, 419);
            this.CustomersTab.TabIndex = 0;
            this.CustomersTab.Text = "Customers";
            this.CustomersTab.UseVisualStyleBackColor = true;
            // 
            // customersGrd
            // 
            this.customersGrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGrd.Location = new System.Drawing.Point(3, 3);
            this.customersGrd.Name = "customersGrd";
            this.customersGrd.RowTemplate.Height = 25;
            this.customersGrd.Size = new System.Drawing.Size(765, 413);
            this.customersGrd.TabIndex = 0;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Controls.Add(this.itemsGrd);
            this.ItemsTab.Location = new System.Drawing.Point(4, 24);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTab.Size = new System.Drawing.Size(771, 419);
            this.ItemsTab.TabIndex = 1;
            this.ItemsTab.Text = "Items";
            this.ItemsTab.UseVisualStyleBackColor = true;
            // 
            // itemsGrd
            // 
            this.itemsGrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGrd.Location = new System.Drawing.Point(3, 3);
            this.itemsGrd.Name = "itemsGrd";
            this.itemsGrd.RowTemplate.Height = 25;
            this.itemsGrd.Size = new System.Drawing.Size(765, 413);
            this.itemsGrd.TabIndex = 1;
            // 
            // TransactionsTab
            // 
            this.TransactionsTab.Controls.Add(this.transactionsGrd);
            this.TransactionsTab.Location = new System.Drawing.Point(4, 24);
            this.TransactionsTab.Name = "TransactionsTab";
            this.TransactionsTab.Size = new System.Drawing.Size(771, 419);
            this.TransactionsTab.TabIndex = 2;
            this.TransactionsTab.Text = "Transactions";
            this.TransactionsTab.UseVisualStyleBackColor = true;
            // 
            // transactionsGrd
            // 
            this.transactionsGrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transactionsGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsGrd.Location = new System.Drawing.Point(3, 3);
            this.transactionsGrd.Name = "transactionsGrd";
            this.transactionsGrd.RowTemplate.Height = 25;
            this.transactionsGrd.Size = new System.Drawing.Size(765, 413);
            this.transactionsGrd.TabIndex = 1;
            // 
            // identityLabel
            // 
            this.identityLabel.AutoSize = true;
            this.identityLabel.Location = new System.Drawing.Point(12, 9);
            this.identityLabel.Name = "identityLabel";
            this.identityLabel.Size = new System.Drawing.Size(166, 15);
            this.identityLabel.TabIndex = 1;
            this.identityLabel.Text = "You are logged in as: Manager";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 486);
            this.Controls.Add(this.identityLabel);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManagerForm";
            this.Text = "Fuel Station";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.CustomersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersGrd)).EndInit();
            this.ItemsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrd)).EndInit();
            this.TransactionsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage CustomersTab;
        private TabPage ItemsTab;
        private TabPage TransactionsTab;
        private Label identityLabel;
        private DataGridView customersGrd;
        private BindingSource customersBS;
        private DataGridView itemsGrd;
        private DataGridView transactionsGrd;
        private BindingSource itemsBS;
        private BindingSource transactionsBS;
    }
}