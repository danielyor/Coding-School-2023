namespace Session_10 {
    partial class UniversityForm {
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
            this.uniGroupBox = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.studentsGridView = new System.Windows.Forms.DataGridView();
            this.gradesGridView = new System.Windows.Forms.DataGridView();
            this.coursesGridView = new System.Windows.Forms.DataGridView();
            this.scheduledCoursesGridView = new System.Windows.Forms.DataGridView();
            this.uniGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledCoursesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uniGroupBox
            // 
            this.uniGroupBox.Controls.Add(this.scheduledCoursesGridView);
            this.uniGroupBox.Controls.Add(this.coursesGridView);
            this.uniGroupBox.Controls.Add(this.gradesGridView);
            this.uniGroupBox.Controls.Add(this.studentsGridView);
            this.uniGroupBox.Location = new System.Drawing.Point(12, 41);
            this.uniGroupBox.Name = "uniGroupBox";
            this.uniGroupBox.Size = new System.Drawing.Size(1006, 537);
            this.uniGroupBox.TabIndex = 0;
            this.uniGroupBox.TabStop = false;
            this.uniGroupBox.Text = "University Props";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(93, 12);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 2;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            // 
            // studentsGridView
            // 
            this.studentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsGridView.Location = new System.Drawing.Point(6, 22);
            this.studentsGridView.Name = "studentsGridView";
            this.studentsGridView.RowTemplate.Height = 25;
            this.studentsGridView.Size = new System.Drawing.Size(240, 150);
            this.studentsGridView.TabIndex = 0;
            // 
            // gradesGridView
            // 
            this.gradesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradesGridView.Location = new System.Drawing.Point(760, 22);
            this.gradesGridView.Name = "gradesGridView";
            this.gradesGridView.RowTemplate.Height = 25;
            this.gradesGridView.Size = new System.Drawing.Size(240, 150);
            this.gradesGridView.TabIndex = 1;
            // 
            // coursesGridView
            // 
            this.coursesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesGridView.Location = new System.Drawing.Point(6, 381);
            this.coursesGridView.Name = "coursesGridView";
            this.coursesGridView.RowTemplate.Height = 25;
            this.coursesGridView.Size = new System.Drawing.Size(240, 150);
            this.coursesGridView.TabIndex = 2;
            // 
            // scheduledCoursesGridView
            // 
            this.scheduledCoursesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduledCoursesGridView.Location = new System.Drawing.Point(760, 381);
            this.scheduledCoursesGridView.Name = "scheduledCoursesGridView";
            this.scheduledCoursesGridView.RowTemplate.Height = 25;
            this.scheduledCoursesGridView.Size = new System.Drawing.Size(240, 150);
            this.scheduledCoursesGridView.TabIndex = 3;
            // 
            // UniversityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 590);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.uniGroupBox);
            this.Name = "UniversityForm";
            this.Text = "UniversityForm";
            this.uniGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduledCoursesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox uniGroupBox;
        private DataGridView scheduledCoursesGridView;
        private DataGridView coursesGridView;
        private DataGridView gradesGridView;
        private DataGridView studentsGridView;
        private Button saveBtn;
        private Button loadBtn;
    }
}