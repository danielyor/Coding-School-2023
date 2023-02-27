namespace FuelStation.WinForms.Forms {
    partial class TransactionCreateForm {
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
            this.payMethodComboBox = new System.Windows.Forms.ComboBox();
            this.transactionTotalValueLabel = new System.Windows.Forms.Label();
            this.transactionPayMethodLabel = new System.Windows.Forms.Label();
            this.cusCardNumTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.transactionCardNumberLabel = new System.Windows.Forms.Label();
            this.transactionEmpIdLabel = new System.Windows.Forms.Label();
            this.editLabel = new System.Windows.Forms.Label();
            this.editLinesBtn = new System.Windows.Forms.Button();
            this.findCusBtn = new System.Windows.Forms.Button();
            this.totalValueUpDown = new System.Windows.Forms.NumericUpDown();
            this.empIdUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.totalValueUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empIdUpDown)).BeginInit();
            this.SuspendLayout();
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
            this.payMethodComboBox.TabIndex = 35;
            // 
            // transactionTotalValueLabel
            // 
            this.transactionTotalValueLabel.AutoSize = true;
            this.transactionTotalValueLabel.Location = new System.Drawing.Point(12, 135);
            this.transactionTotalValueLabel.Name = "transactionTotalValueLabel";
            this.transactionTotalValueLabel.Size = new System.Drawing.Size(66, 15);
            this.transactionTotalValueLabel.TabIndex = 33;
            this.transactionTotalValueLabel.Text = "Total Value:";
            // 
            // transactionPayMethodLabel
            // 
            this.transactionPayMethodLabel.AutoSize = true;
            this.transactionPayMethodLabel.Location = new System.Drawing.Point(12, 106);
            this.transactionPayMethodLabel.Name = "transactionPayMethodLabel";
            this.transactionPayMethodLabel.Size = new System.Drawing.Size(102, 15);
            this.transactionPayMethodLabel.TabIndex = 31;
            this.transactionPayMethodLabel.Text = "Payment Method:";
            // 
            // cusCardNumTextBox
            // 
            this.cusCardNumTextBox.Location = new System.Drawing.Point(126, 74);
            this.cusCardNumTextBox.Name = "cusCardNumTextBox";
            this.cusCardNumTextBox.Size = new System.Drawing.Size(200, 23);
            this.cusCardNumTextBox.TabIndex = 30;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(397, 201);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 28;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(316, 201);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 27;
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
            this.transactionCardNumberLabel.TabIndex = 26;
            this.transactionCardNumberLabel.Text = "Cus. Card Number:";
            // 
            // transactionEmpIdLabel
            // 
            this.transactionEmpIdLabel.AutoSize = true;
            this.transactionEmpIdLabel.Location = new System.Drawing.Point(12, 48);
            this.transactionEmpIdLabel.Name = "transactionEmpIdLabel";
            this.transactionEmpIdLabel.Size = new System.Drawing.Size(76, 15);
            this.transactionEmpIdLabel.TabIndex = 25;
            this.transactionEmpIdLabel.Text = "Employee ID:";
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Location = new System.Drawing.Point(12, 9);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(228, 15);
            this.editLabel.TabIndex = 23;
            this.editLabel.Text = "You are creating a new Transaction entity. ";
            // 
            // editLinesBtn
            // 
            this.editLinesBtn.Location = new System.Drawing.Point(12, 201);
            this.editLinesBtn.Name = "editLinesBtn";
            this.editLinesBtn.Size = new System.Drawing.Size(142, 23);
            this.editLinesBtn.TabIndex = 36;
            this.editLinesBtn.Text = "Edit Transaction Lines";
            this.editLinesBtn.UseVisualStyleBackColor = true;
            // 
            // findCusBtn
            // 
            this.findCusBtn.Location = new System.Drawing.Point(332, 74);
            this.findCusBtn.Name = "findCusBtn";
            this.findCusBtn.Size = new System.Drawing.Size(75, 23);
            this.findCusBtn.TabIndex = 37;
            this.findCusBtn.Text = "Find";
            this.findCusBtn.UseVisualStyleBackColor = true;
            this.findCusBtn.Click += new System.EventHandler(this.findCusBtn_Click);
            // 
            // totalValueUpDown
            // 
            this.totalValueUpDown.Enabled = false;
            this.totalValueUpDown.Location = new System.Drawing.Point(126, 132);
            this.totalValueUpDown.Name = "totalValueUpDown";
            this.totalValueUpDown.ReadOnly = true;
            this.totalValueUpDown.Size = new System.Drawing.Size(200, 23);
            this.totalValueUpDown.TabIndex = 38;
            // 
            // empIdUpDown
            // 
            this.empIdUpDown.Location = new System.Drawing.Point(126, 45);
            this.empIdUpDown.Name = "empIdUpDown";
            this.empIdUpDown.Size = new System.Drawing.Size(200, 23);
            this.empIdUpDown.TabIndex = 39;
            // 
            // TransactionCreateForm
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
            this.Name = "TransactionCreateForm";
            this.Text = "Create Transaction";
            this.Load += new System.EventHandler(this.TransactionCreateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.totalValueUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empIdUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox payMethodComboBox;
        private Label transactionTotalValueLabel;
        private Label transactionPayMethodLabel;
        private TextBox cusCardNumTextBox;
        private Button cancelButton;
        private Button okButton;
        private Label transactionCardNumberLabel;
        private Label transactionEmpIdLabel;
        private Label editLabel;
        private Button editLinesBtn;
        private Button findCusBtn;
        private NumericUpDown totalValueUpDown;
        private NumericUpDown empIdUpDown;
    }
}