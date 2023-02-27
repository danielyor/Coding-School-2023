namespace FuelStation.WinForms.Forms {
    partial class ItemEditForm {
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
            this.editLabel = new System.Windows.Forms.Label();
            this.itemTypeComboBox = new System.Windows.Forms.ComboBox();
            this.itemCostLabel = new System.Windows.Forms.Label();
            this.itemPriceLabel = new System.Windows.Forms.Label();
            this.itemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.itemCodeTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.itemTypeLabel = new System.Windows.Forms.Label();
            this.itemDescriptionLabel = new System.Windows.Forms.Label();
            this.itemCodeLabel = new System.Windows.Forms.Label();
            this.costUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.costUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Location = new System.Drawing.Point(12, 9);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(159, 15);
            this.editLabel.TabIndex = 18;
            this.editLabel.Text = "You are editing Item with ID: ";
            // 
            // itemTypeComboBox
            // 
            this.itemTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemTypeComboBox.FormattingEnabled = true;
            this.itemTypeComboBox.Items.AddRange(new object[] {
            "Fuel",
            "Product",
            "Service"});
            this.itemTypeComboBox.Location = new System.Drawing.Point(100, 101);
            this.itemTypeComboBox.Name = "itemTypeComboBox";
            this.itemTypeComboBox.Size = new System.Drawing.Size(200, 23);
            this.itemTypeComboBox.TabIndex = 34;
            // 
            // itemCostLabel
            // 
            this.itemCostLabel.AutoSize = true;
            this.itemCostLabel.Location = new System.Drawing.Point(12, 162);
            this.itemCostLabel.Name = "itemCostLabel";
            this.itemCostLabel.Size = new System.Drawing.Size(34, 15);
            this.itemCostLabel.TabIndex = 32;
            this.itemCostLabel.Text = "Cost:";
            // 
            // itemPriceLabel
            // 
            this.itemPriceLabel.AutoSize = true;
            this.itemPriceLabel.Location = new System.Drawing.Point(12, 133);
            this.itemPriceLabel.Name = "itemPriceLabel";
            this.itemPriceLabel.Size = new System.Drawing.Size(36, 15);
            this.itemPriceLabel.TabIndex = 30;
            this.itemPriceLabel.Text = "Price:";
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(100, 72);
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(200, 23);
            this.itemDescriptionTextBox.TabIndex = 29;
            // 
            // itemCodeTextBox
            // 
            this.itemCodeTextBox.Location = new System.Drawing.Point(100, 43);
            this.itemCodeTextBox.Name = "itemCodeTextBox";
            this.itemCodeTextBox.Size = new System.Drawing.Size(200, 23);
            this.itemCodeTextBox.TabIndex = 28;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(397, 199);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 27;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(316, 199);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 26;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // itemTypeLabel
            // 
            this.itemTypeLabel.AutoSize = true;
            this.itemTypeLabel.Location = new System.Drawing.Point(12, 104);
            this.itemTypeLabel.Name = "itemTypeLabel";
            this.itemTypeLabel.Size = new System.Drawing.Size(34, 15);
            this.itemTypeLabel.TabIndex = 25;
            this.itemTypeLabel.Text = "Type:";
            // 
            // itemDescriptionLabel
            // 
            this.itemDescriptionLabel.AutoSize = true;
            this.itemDescriptionLabel.Location = new System.Drawing.Point(12, 75);
            this.itemDescriptionLabel.Name = "itemDescriptionLabel";
            this.itemDescriptionLabel.Size = new System.Drawing.Size(70, 15);
            this.itemDescriptionLabel.TabIndex = 24;
            this.itemDescriptionLabel.Text = "Description:";
            // 
            // itemCodeLabel
            // 
            this.itemCodeLabel.AutoSize = true;
            this.itemCodeLabel.Location = new System.Drawing.Point(12, 46);
            this.itemCodeLabel.Name = "itemCodeLabel";
            this.itemCodeLabel.Size = new System.Drawing.Size(38, 15);
            this.itemCodeLabel.TabIndex = 23;
            this.itemCodeLabel.Text = "Code:";
            // 
            // costUpDown
            // 
            this.costUpDown.Location = new System.Drawing.Point(100, 159);
            this.costUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.costUpDown.Name = "costUpDown";
            this.costUpDown.Size = new System.Drawing.Size(200, 23);
            this.costUpDown.TabIndex = 36;
            // 
            // priceUpDown
            // 
            this.priceUpDown.Location = new System.Drawing.Point(100, 130);
            this.priceUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.priceUpDown.Name = "priceUpDown";
            this.priceUpDown.Size = new System.Drawing.Size(200, 23);
            this.priceUpDown.TabIndex = 35;
            // 
            // ItemEditForm
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
            this.Name = "ItemEditForm";
            this.Text = "Item Edit";
            this.Load += new System.EventHandler(this.ItemEditForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.costUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label editLabel;
        private ComboBox itemTypeComboBox;
        private Label itemCostLabel;
        private Label itemPriceLabel;
        private TextBox itemDescriptionTextBox;
        private TextBox itemCodeTextBox;
        private Button cancelButton;
        private Button okButton;
        private Label itemTypeLabel;
        private Label itemDescriptionLabel;
        private Label itemCodeLabel;
        private NumericUpDown costUpDown;
        private NumericUpDown priceUpDown;
    }
}