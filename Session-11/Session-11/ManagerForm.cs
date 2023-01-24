using DevExpress.ClipboardSource.SpreadsheetML;
using LibCarService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11 {
    public partial class ManagerForm : Form {
        public ManagerForm() {
            InitializeComponent();
            SetControlProperties();
        }


        private void SetControlProperties() {
            DummyCarMech data = new();
            //grvStudents.AutoGenerateColumns = false;
            //grdManagersEngineers.AutoGenerateColumns = false;

            
            
            BindingList<Manager> managers = new BindingList<Manager>(data.managers);
            grdManagers.DataSource = new BindingSource() { DataSource = managers };

            BindingList<Engineer> engineers = new BindingList<Engineer>(data.engineers);
            grdEngineers.DataSource = new BindingSource() { DataSource = engineers };

            repManagers.DataSource = new BindingSource() { DataSource = managers };
            repManagers.DisplayMember = "Name";
            repManagers.ValueMember = "ID";
            //managers.AddNew();
            //grvEngineers.AutoGenerateColumns = false;
            //grvManagers.DataSource = data.managers;
            //grvEngineers.DataSource = data.engineers;


            //DataGridViewComboBoxColumn colGender = grvStudents.Columns["colGender"] as DataGridViewComboBoxColumn;
            //colGender.Items.Add(Student.GenderEnum.Male);
            //colGender.Items.Add(Student.GenderEnum.Female);
            //colGender.Items.Add(Student.GenderEnum.Other);

            //DataGridViewComboBoxColumn colUniversity1 = grvStudents.Columns["colUniversity"] as DataGridViewComboBoxColumn;
            //colUniversity1.DataSource = DataHelper.GetUniversities();
            //colUniversity1.DisplayMember = "Name";
            //colUniversity1.ValueMember = "ID";

            //var lookUpEdit = colUniversity.ColumnEdit as RepositoryItemLookUpEdit;
            //var lookUpEdit = repUniversity;
            //var lookUpEdit = grvStudents.Columns["UniverityID"].ColumnEdit as RepositoryItemLookUpEdit;
            //repUniversity.DataSource = DataHelper.GetUniversities();
            //repUniversity.DisplayMember = "Name";
            //repUniversity.ValueMember = "ID";



            //DataGridViewComboBoxColumn colSemester = grvStudentCourses.Columns["colSemester"] as DataGridViewComboBoxColumn;
            //colSemester.Items.Add(Course.SemesterEnum.Winter);
            //colSemester.Items.Add(Course.SemesterEnum.Spring);

            // grvStudents.CellContentClick += GrvStudents_CellContentClick;
            var buttons = grdManagers.EmbeddedNavigator.Buttons;
        }

        
    }
}
