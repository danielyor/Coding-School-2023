namespace FuelStation.WinForms.Forms {
    partial class ItemCreateForm {
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
            this.itemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.itemCodeTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.itemTypeLabel = new System.Windows.Forms.Label();
            this.itemDescriptionLabel = new System.Windows.Forms.Label();
            this.itemCodeLabel = new System.Windows.Forms.Label();
            this.editLabel = new System.Windows.Forms.Label();
            this.itemPriceLabel = new System.Windows.Forms.Label();
            this.itemCostLabel = new System.Windows.Forms.Label();
            this.itemTypeComboBox = new System.Windows.Forms.ComboBox();
            this.priceUpDown = new System.Windows.Forms.NumericUpDown();
            this.costUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.priceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(100, 74);
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(200, 23);
            this.itemDescriptionTextBox.TabIndex = 16;
            // 
            // itemCodeTextBox
            // 
            this.itemCodeTextBox.Location = new System.Drawing.Point(100, 45);
            this.itemCodeTextBox.Name = "itemCodeTextBox";
            this.itemCodeTextBox.Size = new System.Drawing.Size(200, 23);
            this.itemCodeTextBox.TabIndex = 15;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(397, 201);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(316, 201);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 13;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // itemTypeLabel
            // 
            this.itemTypeLabel.AutoSize = true;
            this.itemTypeLabel.Location = new System.Drawing.Point(12, 106);
            this.itemTypeLabel.Name = "itemTypeLabel";
            this.itemTypeLabel.Size = new System.Drawing.Size(34, 15);
            this.itemTypeLabel.TabIndex = 12;
            this.itemTypeLabel.Text = "Type:";
            // 
            // itemDescriptionLabel
            // 
            this.itemDescriptionLabel.AutoSize = true;
            this.itemDescriptionLabel.Location = new System.Drawing.Point(12, 77);
            this.itemDescriptionLabel.Name = "itemDescriptionLabel";
            this.itemDescriptionLabel.Size = new System.Drawing.Size(70, 15);
            this.itemDescriptionLabel.TabIndex = 11;
            this.itemDescriptionLabel.Text = "Description:";
            // 
            // itemCodeLabel
            // 
            this.itemCodeLabel.AutoSize = true;
            this.itemCodeLabel.Location = new System.Drawing.Point(12, 48);
            this.itemCodeLabel.Name = "itemCodeLabel";
            this.itemCodeLabel.Size = new System.Drawing.Size(38, 15);
            this.itemCodeLabel.TabIndex = 10;
            this.itemCodeLabel.Text = "Code:";
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Location = new System.Drawing.Point(12, 9);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(220, 15);
            this.editLabel.TabIndex = 9;
            this.editLabel.Text = "You are creating a new Customer entity. ";
            // 
            // itemPriceLabel
            // 
            this.itemPriceLabel.AutoSize = true;
            this.itemPriceLabel.Location = new System.Drawing.Point(12, 135);
            this.itemPriceLabel.Name = "itemPriceLabel";
            this.itemPriceLabel.Size = new System.Drawing.Size(36, 15);
            this.itemPriceLabel.TabIndex = 18;
            this.itemPriceLabel.Text = "Price:";
            // 
            // itemCostLabel
            // 
            this.itemCostLabel.AutoSize = true;
            this.itemCostLabel.Location = new System.Drawing.Point(12, 164);
            this.itemCostLabel.Name = "itemCostLabel";
            this.itemCostLabel.Size = new System.Drawing.Size(34, 15);
            this.itemCostLabel.TabIndex = 20;
            this.itemCostLabel.Text = "Cost:";
            // 
            // itemTypeComboBox
            // 
            this.itemTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemTypeComboBox.FormattingEnabled = true;
            this.itemTypeComboBox.Items.AddRange(new object[] {
            "Fuel",
            "Product",
            "Service"});
            this.itemTypeComboBox.Location = new System.Drawing.Point(100, 103);
            this.itemTypeComboBox.Name = "itemTypeComboBox";
            this.itemTypeComboBox.Size = new System.Drawing.Size(200, 23);
            this.itemTypeComboBox.TabIndex = 22;
            // 
            // priceUpDown
            // 
            this.priceUpDown.Location = new System.Drawing.Point(100, 132);
            this.priceUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.priceUpDown.Name = "priceUpDown";
            this.priceUpDown.Size = new System.Drawing.Size(200, 23);
            this.priceUpDown.TabIndex = 23;
            // 
            // costUpDown
            // 
            this.costUpDown.Location = new System.Drawing.Point(100, 161);
            this.costUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.costUpDown.Name = "costUpDown";
            this.costUpDown.Size = new System.Drawing.Size(200, 23);
            this.costUpDown.TabIndex = 24;
            // 
            // ItemCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 236);
            this.Controls.Add(this.costUpDown);
            this.Controls.Add(this.priceUpDown);
            this.Controls.Add(this.itemTypeComboBox);
            this.Controls.Add(this.itemCostLabel);
            this.Controls.Add(this.itemPriceLabel);
            this.Controls.Add(this.itemDescriptionTextBox);
            this.Controls.Add(this.itemCodeTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.itemTypeLabel);
            this.Controls.Add(this.itemDescriptionLabel);
            this.Controls.Add(this.itemCodeLabel);
            this.Controls.Add(this.editLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemCreateForm";
            this.Text = "Item Create";
            this.Load += new System.EventHandler(this.ItemCreateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox itemDescriptionTextBox;
        private TextBox itemCodeTextBox;
        private Button cancelButton;
        private Button okButton;
        private Label itemTypeLabel;
        private Label itemDescriptionLabel;
        private Label itemCodeLabel;
        private Label editLabel;
        private Label itemPriceLabel;
        private Label itemCostLabel;
        private ComboBox itemTypeComboBox;
        private NumericUpDown priceUpDown;
        private NumericUpDown costUpDown;
    }
}