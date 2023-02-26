namespace WinForms {
    partial class LoginForm {
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
            this.ManagerLoginBtn = new System.Windows.Forms.Button();
            this.CashierLoginBtn = new System.Windows.Forms.Button();
            this.StaffLoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManagerLoginBtn
            // 
            this.ManagerLoginBtn.Location = new System.Drawing.Point(295, 240);
            this.ManagerLoginBtn.Name = "ManagerLoginBtn";
            this.ManagerLoginBtn.Size = new System.Drawing.Size(75, 23);
            this.ManagerLoginBtn.TabIndex = 0;
            this.ManagerLoginBtn.Text = "Manager";
            this.ManagerLoginBtn.UseVisualStyleBackColor = true;
            this.ManagerLoginBtn.Click += new System.EventHandler(this.ManagerLoginBtn_Click);
            // 
            // CashierLoginBtn
            // 
            this.CashierLoginBtn.Location = new System.Drawing.Point(376, 240);
            this.CashierLoginBtn.Name = "CashierLoginBtn";
            this.CashierLoginBtn.Size = new System.Drawing.Size(75, 23);
            this.CashierLoginBtn.TabIndex = 1;
            this.CashierLoginBtn.Text = "Cashier";
            this.CashierLoginBtn.UseVisualStyleBackColor = true;
            this.CashierLoginBtn.Click += new System.EventHandler(this.CashierLoginBtn_Click);
            // 
            // StaffLoginBtn
            // 
            this.StaffLoginBtn.Location = new System.Drawing.Point(457, 240);
            this.StaffLoginBtn.Name = "StaffLoginBtn";
            this.StaffLoginBtn.Size = new System.Drawing.Size(75, 23);
            this.StaffLoginBtn.TabIndex = 2;
            this.StaffLoginBtn.Text = "Staff";
            this.StaffLoginBtn.UseVisualStyleBackColor = true;
            this.StaffLoginBtn.Click += new System.EventHandler(this.StaffLoginBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StaffLoginBtn);
            this.Controls.Add(this.CashierLoginBtn);
            this.Controls.Add(this.ManagerLoginBtn);
            this.Name = "LoginForm";
            this.Text = "Fuel Station Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button ManagerLoginBtn;
        private Button CashierLoginBtn;
        private Button StaffLoginBtn;
    }
}