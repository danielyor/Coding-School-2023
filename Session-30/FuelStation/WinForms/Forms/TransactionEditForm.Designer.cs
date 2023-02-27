namespace FuelStation.WinForms.Forms {
    partial class TransactionEditForm {
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
            this.findCusBtn = new System.Windows.Forms.Button();
            this.editLinesBtn = new System.Windows.Forms.Button();
            this.payMethodComboBox = new System.Windows.Forms.ComboBox();
            this.transactionTotalValueLabel = new System.Windows.Forms.Label();
            this.transactionPayMethodLabel = new System.Windows.Forms.Label();
            this.cusCardNumTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.transactionCardNumberLabel = new System.Windows.Forms.Label();
            this.transactionEmpIdLabel = new System.Windows.Forms.Label();
            this.empIdUpDown = new System.Windows.Forms.NumericUpDown();
            this.totalValueUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.empIdUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalValueUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Location = new System.Drawing.Point(12, 9);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(195, 15);
            this.editLabel.TabIndex = 35;
            this.editLabel.Text = "You are editing Transaction with ID: ";
            // 
            // findCusBtn
            // 
            this.findCusBtn.Location = new System.Drawing.Point(332, 74);
            this.findCusBtn.Name = "findCusBtn";
            this.findCusBtn.Size = new System.Drawing.Size(75, 23);
            this.findCusBtn.TabIndex = 49;
            this.findCusBtn.Text = "Find";
            this.findCusBtn.UseVisualStyleBackColor = true;
            this.findCusBtn.Click += new System.EventHandler(this.findCusBtn_Click);
            // 
            // editLinesBtn
            // 
            this.editLinesBtn.Location = new System.Drawing.Point(12, 201);
            this.editLinesBtn.Name = "editLinesBtn";
            this.editLinesBtn.Size = new System.Drawing.Size(142, 23);
            this.editLinesBtn.TabIndex = 48;
            this.editLinesBtn.Text = "Edit Transaction Lines";
            this.editLinesBtn.UseVisualStyleBackColor = true;
            this.editLinesBtn.Click += new System.EventHandler(this.editLinesBtn_Click);
            // 
            // payMethodComboBox
            // 
            this.payMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payMethodComboBox.FormattingEnabled = true;
            this.payMethodComboBox.Items.AddRange(new object[] {
            "CreditCard",
            "Cash"});
            this.payMethodComboBox.Location = new System.Drawing.Point(126, 103);
            this.payMethodComboBox.Name = "payMethodComboBox";
            this.payMethodComboBox.Size = new System.Drawing.Size(200, 23);
            this.payMethodComboBox.TabIndex = 47;
            // 
            // transactionTotalValueLabel
            // 
            this.transactionTotalValueLabel.AutoSize = true;
            this.transactionTotalValueLabel.Location = new System.Drawing.Point(12, 135);
            this.transactionTotalValueLabel.Name = "transactionTotalValueLabel";
            this.transactionTotalValueLabel.Size = new System.Drawing.Size(66, 15);
            this.transactionTotalValueLabel.TabIndex = 45;
            this.transactionTotalValueLabel.Text = "Total Value:";
            // 
            // transactionPayMethodLabel
            // 
            this.transactionPayMethodLabel.AutoSize = true;
            this.transactionPayMethodLabel.Location = new System.Drawing.Point(12, 106);
            this.transactionPayMethodLabel.Name = "transactionPayMethodLabel";
            this.transactionPayMethodLabel.Size = new System.Drawing.Size(102, 15);
            this.transactionPayMethodLabel.TabIndex = 43;
            this.transactionPayMethodLabel.Text = "Payment Method:";
            // 
            // cusCardNumTextBox
            // 
            this.cusCardNumTextBox.Location = new System.Drawing.Point(126, 74);
            this.cusCardNumTextBox.Name = "cusCardNumTextBox";
            this.cusCardNumTextBox.Size = new System.Drawing.Size(200, 23);
            this.cusCardNumTextBox.TabIndex = 42;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(397, 201);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 41;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(316, 201);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 40;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // transactionCardNumberLabel
            // 
            this.transactionCardNumberLabel.AutoSize = true;
            this.transactionCardNumberLabel.Location = new System.Drawing.Point(12, 77);
            this.transactionCardNumberLabel.Name = "transactionCardNumberLabel";
            this.transactionCardNumberLabel.Size = new System.Drawing.Size(108, 15);
            this.transactionCardNumberLabel.TabIndex = 39;
            this.transactionCardNumberLabel.Text = "Cus. Card Number:";
            // 
            // transactionEmpIdLabel
            // 
            this.transactionEmpIdLabel.AutoSize = true;
            this.transactionEmpIdLabel.Location = new System.Drawing.Point(12, 48);
            this.transactionEmpIdLabel.Name = "transactionEmpIdLabel";
            this.transactionEmpIdLabel.Size = new System.Drawing.Size(76, 15);
            this.transactionEmpIdLabel.TabIndex = 38;
            this.transactionEmpIdLabel.Text = "Employee ID:";
            // 
            // empIdUpDown
            // 
            this.empIdUpDown.Location = new System.Drawing.Point(126, 45);
            this.empIdUpDown.Name = "empIdUpDown";
            this.empIdUpDown.Size = new System.Drawing.Size(200, 23);
            this.empIdUpDown.TabIndex = 51;
            // 
            // totalValueUpDown
            // 
            this.totalValueUpDown.Enabled = false;
            this.totalValueUpDown.Location = new System.Drawing.Point(126, 132);
            this.totalValueUpDown.Name = "totalValueUpDown";
            this.totalValueUpDown.ReadOnly = true;
            this.totalValueUpDown.Size = new System.Drawing.Size(200, 23);
            this.totalValueUpDown.TabIndex = 50;
            // 
            // TransactionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 236);
            this.Controls.Add(this.empIdUpDown);
            this.Controls.Add(this.totalValueUpDown);
            this.Controls.Add(this.findCusBtn);
            this.Controls.Add(this.editLinesBtn);
            this.Controls.Add(this.payMethodComboBox);
            this.Controls.Add(this.transactionTotalValueLabel);
            this.Controls.Add(this.transactionPayMethodLabel);
            this.Controls.Add(this.cusCardNumTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.transactionCardNumberLabel);
            this.Controls.Add(this.transactionEmpIdLabel);
            this.Controls.Add(this.editLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransactionEditForm";
            this.Text = "Edit Transaction";
            this.Load += new System.EventHandler(this.TransactionEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empIdUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalValueUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label editLabel;
        private Button findCusBtn;
        private Button editLinesBtn;
        private ComboBox payMethodComboBox;
        private Label transactionTotalValueLabel;
        private Label transactionPayMethodLabel;
        private TextBox cusCardNumTextBox;
        private Button cancelButton;
        private Button okButton;
        private Label transactionCardNumberLabel;
        private Label transactionEmpIdLabel;
        private NumericUpDown empIdUpDown;
        private NumericUpDown totalValueUpDown;
    }
}