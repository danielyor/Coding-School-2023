namespace FuelStation.WinForms.Forms {
    partial class TransactionLineCreateForm {
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
            this.itemIdUpDown = new System.Windows.Forms.NumericUpDown();
            this.lineItemIdUpDown = new System.Windows.Forms.Label();
            this.editLabel = new System.Windows.Forms.Label();
            this.quantityUpDown = new System.Windows.Forms.NumericUpDown();
            this.lineQuantityUpDown = new System.Windows.Forms.Label();
            this.addLineBtn = new System.Windows.Forms.Button();
            this.removeLineBtn = new System.Windows.Forms.Button();
            this.linesGrd = new System.Windows.Forms.DataGridView();
            this.finishBtn = new System.Windows.Forms.Button();
            this.linesBS = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.itemIdUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesGrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesBS)).BeginInit();
            this.SuspendLayout();
            // 
            // itemIdUpDown
            // 
            this.itemIdUpDown.Location = new System.Drawing.Point(77, 338);
            this.itemIdUpDown.Name = "itemIdUpDown";
            this.itemIdUpDown.Size = new System.Drawing.Size(200, 23);
            this.itemIdUpDown.TabIndex = 42;
            // 
            // lineItemIdUpDown
            // 
            this.lineItemIdUpDown.AutoSize = true;
            this.lineItemIdUpDown.Location = new System.Drawing.Point(12, 340);
            this.lineItemIdUpDown.Name = "lineItemIdUpDown";
            this.lineItemIdUpDown.Size = new System.Drawing.Size(48, 15);
            this.lineItemIdUpDown.TabIndex = 41;
            this.lineItemIdUpDown.Text = "Item ID:";
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Location = new System.Drawing.Point(12, 9);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(398, 15);
            this.editLabel.TabIndex = 40;
            this.editLabel.Text = "You are creating a new set of Transaction Lines for the Transaction with ID: ";
            // 
            // quantityUpDown
            // 
            this.quantityUpDown.Location = new System.Drawing.Point(77, 367);
            this.quantityUpDown.Name = "quantityUpDown";
            this.quantityUpDown.Size = new System.Drawing.Size(200, 23);
            this.quantityUpDown.TabIndex = 44;
            // 
            // lineQuantityUpDown
            // 
            this.lineQuantityUpDown.AutoSize = true;
            this.lineQuantityUpDown.Location = new System.Drawing.Point(12, 369);
            this.lineQuantityUpDown.Name = "lineQuantityUpDown";
            this.lineQuantityUpDown.Size = new System.Drawing.Size(59, 15);
            this.lineQuantityUpDown.TabIndex = 43;
            this.lineQuantityUpDown.Text = "Quantity: ";
            // 
            // addLineBtn
            // 
            this.addLineBtn.Location = new System.Drawing.Point(12, 403);
            this.addLineBtn.Name = "addLineBtn";
            this.addLineBtn.Size = new System.Drawing.Size(100, 23);
            this.addLineBtn.TabIndex = 45;
            this.addLineBtn.Text = "Add Line";
            this.addLineBtn.UseVisualStyleBackColor = true;
            this.addLineBtn.Click += new System.EventHandler(this.addLineBtn_Click);
            // 
            // removeLineBtn
            // 
            this.removeLineBtn.Location = new System.Drawing.Point(118, 403);
            this.removeLineBtn.Name = "removeLineBtn";
            this.removeLineBtn.Size = new System.Drawing.Size(100, 23);
            this.removeLineBtn.TabIndex = 46;
            this.removeLineBtn.Text = "Remove Line";
            this.removeLineBtn.UseVisualStyleBackColor = true;
            this.removeLineBtn.Click += new System.EventHandler(this.removeLineBtn_Click);
            // 
            // linesGrd
            // 
            this.linesGrd.AllowUserToAddRows = false;
            this.linesGrd.AllowUserToDeleteRows = false;
            this.linesGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.linesGrd.Location = new System.Drawing.Point(12, 38);
            this.linesGrd.Name = "linesGrd";
            this.linesGrd.ReadOnly = true;
            this.linesGrd.RowTemplate.Height = 25;
            this.linesGrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.linesGrd.Size = new System.Drawing.Size(788, 283);
            this.linesGrd.TabIndex = 47;
            // 
            // finishBtn
            // 
            this.finishBtn.Location = new System.Drawing.Point(725, 403);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(75, 23);
            this.finishBtn.TabIndex = 48;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = true;
            // 
            // TransactionLineCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 438);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.linesGrd);
            this.Controls.Add(this.removeLineBtn);
            this.Controls.Add(this.addLineBtn);
            this.Controls.Add(this.quantityUpDown);
            this.Controls.Add(this.lineQuantityUpDown);
            this.Controls.Add(this.itemIdUpDown);
            this.Controls.Add(this.lineItemIdUpDown);
            this.Controls.Add(this.editLabel);
            this.Name = "TransactionLineCreateForm";
            this.Text = "Create Transaction Lines";
            this.Load += new System.EventHandler(this.TransactionLineCreateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemIdUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesGrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown itemIdUpDown;
        private Label lineItemIdUpDown;
        private Label editLabel;
        private NumericUpDown quantityUpDown;
        private Label lineQuantityUpDown;
        private Button addLineBtn;
        private Button removeLineBtn;
        private DataGridView linesGrd;
        private Button finishBtn;
        private BindingSource linesBS;
    }
}