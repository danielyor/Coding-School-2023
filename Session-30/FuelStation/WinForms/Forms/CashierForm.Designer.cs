﻿namespace WinForms {
    partial class CashierForm {
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
            this.deleteCustomerBtn = new System.Windows.Forms.Button();
            this.editCustomerBtn = new System.Windows.Forms.Button();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.customersGrd = new System.Windows.Forms.DataGridView();
            this.TransactionsTab = new System.Windows.Forms.TabPage();
            this.transactionsGrd = new System.Windows.Forms.DataGridView();
            this.identityLabel = new System.Windows.Forms.Label();
            this.customersBS = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsBS = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.CustomersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrd)).BeginInit();
            this.TransactionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBS)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.CustomersTab);
            this.tabControl1.Controls.Add(this.TransactionsTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // CustomersTab
            // 
            this.CustomersTab.Controls.Add(this.deleteCustomerBtn);
            this.CustomersTab.Controls.Add(this.editCustomerBtn);
            this.CustomersTab.Controls.Add(this.addCustomerBtn);
            this.CustomersTab.Controls.Add(this.customersGrd);
            this.CustomersTab.Location = new System.Drawing.Point(4, 24);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTab.Size = new System.Drawing.Size(771, 419);
            this.CustomersTab.TabIndex = 0;
            this.CustomersTab.Text = "Customers";
            this.CustomersTab.UseVisualStyleBackColor = true;
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.Location = new System.Drawing.Point(168, 390);
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteCustomerBtn.TabIndex = 7;
            this.deleteCustomerBtn.Text = "Delete";
            this.deleteCustomerBtn.UseVisualStyleBackColor = true;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
            // 
            // editCustomerBtn
            // 
            this.editCustomerBtn.Location = new System.Drawing.Point(87, 390);
            this.editCustomerBtn.Name = "editCustomerBtn";
            this.editCustomerBtn.Size = new System.Drawing.Size(75, 23);
            this.editCustomerBtn.TabIndex = 6;
            this.editCustomerBtn.Text = "Edit";
            this.editCustomerBtn.UseVisualStyleBackColor = true;
            this.editCustomerBtn.Click += new System.EventHandler(this.editCustomerBtn_Click);
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Location = new System.Drawing.Point(6, 390);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(75, 23);
            this.addCustomerBtn.TabIndex = 5;
            this.addCustomerBtn.Text = "Add";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // customersGrd
            // 
            this.customersGrd.AllowUserToAddRows = false;
            this.customersGrd.AllowUserToDeleteRows = false;
            this.customersGrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGrd.Location = new System.Drawing.Point(3, 3);
            this.customersGrd.Name = "customersGrd";
            this.customersGrd.ReadOnly = true;
            this.customersGrd.RowTemplate.Height = 25;
            this.customersGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersGrd.Size = new System.Drawing.Size(765, 381);
            this.customersGrd.TabIndex = 4;
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
            this.identityLabel.Size = new System.Drawing.Size(158, 15);
            this.identityLabel.TabIndex = 1;
            this.identityLabel.Text = "You are logged in as: Cashier";
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 486);
            this.Controls.Add(this.identityLabel);
            this.Controls.Add(this.tabControl1);
            this.Name = "CashierForm";
            this.Text = "Fuel Station";
            this.Load += new System.EventHandler(this.CashierForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.CustomersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersGrd)).EndInit();
            this.TransactionsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage CustomersTab;
        private TabPage TransactionsTab;
        private Label identityLabel;
        private BindingSource customersBS;
        private DataGridView transactionsGrd;
        private BindingSource transactionsBS;
        private Button deleteCustomerBtn;
        private Button editCustomerBtn;
        private Button addCustomerBtn;
        private DataGridView customersGrd;
    }
}