namespace FuelStation.WinForms.Forms {
    partial class CustomerEditForm {
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
            this.customerCardNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerSurnameTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.customerCardNumberLabel = new System.Windows.Forms.Label();
            this.customerSurnameLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.editLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerCardNumberTextBox
            // 
            this.customerCardNumberTextBox.Location = new System.Drawing.Point(100, 103);
            this.customerCardNumberTextBox.Name = "customerCardNumberTextBox";
            this.customerCardNumberTextBox.Size = new System.Drawing.Size(200, 23);
            this.customerCardNumberTextBox.TabIndex = 17;
            // 
            // customerSurnameTextBox
            // 
            this.customerSurnameTextBox.Location = new System.Drawing.Point(100, 74);
            this.customerSurnameTextBox.Name = "customerSurnameTextBox";
            this.customerSurnameTextBox.Size = new System.Drawing.Size(200, 23);
            this.customerSurnameTextBox.TabIndex = 16;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(100, 45);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(200, 23);
            this.customerNameTextBox.TabIndex = 15;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(397, 151);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(316, 151);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 13;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_ClickAsync);
            // 
            // customerCardNumberLabel
            // 
            this.customerCardNumberLabel.AutoSize = true;
            this.customerCardNumberLabel.Location = new System.Drawing.Point(12, 106);
            this.customerCardNumberLabel.Name = "customerCardNumberLabel";
            this.customerCardNumberLabel.Size = new System.Drawing.Size(82, 15);
            this.customerCardNumberLabel.TabIndex = 12;
            this.customerCardNumberLabel.Text = "Card Number:";
            // 
            // customerSurnameLabel
            // 
            this.customerSurnameLabel.AutoSize = true;
            this.customerSurnameLabel.Location = new System.Drawing.Point(12, 77);
            this.customerSurnameLabel.Name = "customerSurnameLabel";
            this.customerSurnameLabel.Size = new System.Drawing.Size(57, 15);
            this.customerSurnameLabel.TabIndex = 11;
            this.customerSurnameLabel.Text = "Surname:";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(12, 48);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(42, 15);
            this.customerNameLabel.TabIndex = 10;
            this.customerNameLabel.Text = "Name:";
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Location = new System.Drawing.Point(12, 9);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(187, 15);
            this.editLabel.TabIndex = 9;
            this.editLabel.Text = "You are editing Customer with ID: ";
            // 
            // CustomerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 186);
            this.Controls.Add(this.customerCardNumberTextBox);
            this.Controls.Add(this.customerSurnameTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.customerCardNumberLabel);
            this.Controls.Add(this.customerSurnameLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.editLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerEditForm";
            this.Text = "Customer Edit";
            this.Load += new System.EventHandler(this.CustomerEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox customerCardNumberTextBox;
        private TextBox customerSurnameTextBox;
        private TextBox customerNameTextBox;
        private Button cancelButton;
        private Button okButton;
        private Label customerCardNumberLabel;
        private Label customerSurnameLabel;
        private Label customerNameLabel;
        private Label editLabel;
    }
}