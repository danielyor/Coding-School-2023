namespace WinForms {
    partial class StaffForm {
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
            this.ItemsTab = new System.Windows.Forms.TabPage();
            this.deleteItemBtn = new System.Windows.Forms.Button();
            this.editItemBtn = new System.Windows.Forms.Button();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.itemsGrd = new System.Windows.Forms.DataGridView();
            this.identityLabel = new System.Windows.Forms.Label();
            this.itemsBS = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.ItemsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBS)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.ItemsTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Controls.Add(this.deleteItemBtn);
            this.ItemsTab.Controls.Add(this.editItemBtn);
            this.ItemsTab.Controls.Add(this.addItemBtn);
            this.ItemsTab.Controls.Add(this.itemsGrd);
            this.ItemsTab.Location = new System.Drawing.Point(4, 24);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTab.Size = new System.Drawing.Size(771, 419);
            this.ItemsTab.TabIndex = 1;
            this.ItemsTab.Text = "Items";
            this.ItemsTab.UseVisualStyleBackColor = true;
            // 
            // deleteItemBtn
            // 
            this.deleteItemBtn.Location = new System.Drawing.Point(168, 390);
            this.deleteItemBtn.Name = "deleteItemBtn";
            this.deleteItemBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteItemBtn.TabIndex = 7;
            this.deleteItemBtn.Text = "Delete";
            this.deleteItemBtn.UseVisualStyleBackColor = true;
            this.deleteItemBtn.Click += new System.EventHandler(this.deleteItemBtn_Click);
            // 
            // editItemBtn
            // 
            this.editItemBtn.Location = new System.Drawing.Point(87, 390);
            this.editItemBtn.Name = "editItemBtn";
            this.editItemBtn.Size = new System.Drawing.Size(75, 23);
            this.editItemBtn.TabIndex = 6;
            this.editItemBtn.Text = "Edit";
            this.editItemBtn.UseVisualStyleBackColor = true;
            this.editItemBtn.Click += new System.EventHandler(this.editItemBtn_Click);
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(6, 390);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemBtn.TabIndex = 5;
            this.addItemBtn.Text = "Add";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // itemsGrd
            // 
            this.itemsGrd.AllowUserToAddRows = false;
            this.itemsGrd.AllowUserToDeleteRows = false;
            this.itemsGrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGrd.Location = new System.Drawing.Point(3, 3);
            this.itemsGrd.Name = "itemsGrd";
            this.itemsGrd.ReadOnly = true;
            this.itemsGrd.RowTemplate.Height = 25;
            this.itemsGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsGrd.Size = new System.Drawing.Size(765, 381);
            this.itemsGrd.TabIndex = 1;
            // 
            // identityLabel
            // 
            this.identityLabel.AutoSize = true;
            this.identityLabel.Location = new System.Drawing.Point(12, 9);
            this.identityLabel.Name = "identityLabel";
            this.identityLabel.Size = new System.Drawing.Size(143, 15);
            this.identityLabel.TabIndex = 1;
            this.identityLabel.Text = "You are logged in as: Staff";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 486);
            this.Controls.Add(this.identityLabel);
            this.Controls.Add(this.tabControl1);
            this.Name = "StaffForm";
            this.Text = "Fuel Station";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.ItemsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsGrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabControl1;
        private TabPage ItemsTab;
        private Label identityLabel;
        private DataGridView itemsGrd;
        private BindingSource itemsBS;
        private Button deleteItemBtn;
        private Button editItemBtn;
        private Button addItemBtn;
    }
}