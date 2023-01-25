using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using LibCarService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static LibCarService.ServiceTask;

namespace Session_11 {
    public partial class ManagerForm : Form {

        CarServiceCenter carServiceCenter;
        public ManagerForm() {
            InitializeComponent();
            SetControlProperties();

            
        }
        //carServiceCenter = new CarServiceCenter();
        //DummyCarMech data = new();
        //carServiceCenter.Customers = data.Customers;
        //carServiceCenter.Cars = data.Cars;
        //carServiceCenter.Managers = data.Managers;
        //carServiceCenter.Engineers = data.Engineers;
        //carServiceCenter.ServiceTasks = data.ServiceTasks;
        //carServiceCenter.Transactions = data.Transactions;
        DummyCarMech data = new();
        private void SetControlProperties() {
            BindingList<Manager> managers = new BindingList<Manager>(data.Managers);
            grdManagers.DataSource = new BindingSource() { DataSource = managers };
            
            BindingList<Engineer> engineers = new BindingList<Engineer>(data.Engineers);
            grdEngineers.DataSource = new BindingSource() { DataSource = engineers };

            repManagers.DataSource = new BindingSource() { DataSource = managers };
            repManagers.DisplayMember = "Surname";
            repManagers.ValueMember = "ID";
            repManagersView.Assign(grdManagers.MainView, false);

            BindingList<ServiceTask> serviceTasks = new BindingList<ServiceTask>(data.ServiceTasks);
            grdServiceTasks.DataSource = new BindingSource() { DataSource = serviceTasks };

            BindingList<LibCarService.Transaction> transactions = new BindingList<LibCarService.Transaction>(data.Transactions);
            grdTransactions.DataSource = new BindingSource() { DataSource = transactions };

            BindingList<Car> cars = new BindingList<Car>(data.Cars);
            repCars.DataSource = new BindingSource() { DataSource = cars };
            repCars.DisplayMember = "Model";
            repCars.ValueMember = "ID";

            BindingList<Customer> customers = new BindingList<Customer>(data.Customers);
            repCustomers.DataSource = new BindingSource() { DataSource = customers };
            repCustomers.DisplayMember = "Surname";
            repCustomers.ValueMember = "ID";
            
            

            repManagers2.DataSource = new BindingSource() { DataSource = managers };
            repManagers2.DisplayMember = "Surname";
            repManagers2.ValueMember = "ID";
            gridView2.Assign(grdManagers.MainView, false);

            //repManagerView.Columns = grdManagers.MainView;

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
            //var buttons = grdManagers.EmbeddedNavigator.Buttons;
        }


        private void grvServiceTasks_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e) {
            if (e.Column.Caption == "Code") {
                //MessageBox.Show(e.Value.ToString());

                switch (e.Value) {
                    case CodeEnum.OilChange:
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Description", "Change the oils");
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Hours", 1.5M);
                        break;
                    case CodeEnum.TireChange:
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Description", "Change the tire");
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Hours", 2.5M);
                        break;
                    case CodeEnum.BrokenWindow:
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Description", "Fix the broken window");
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Hours", 1.25M);
                        break;
                    case CodeEnum.EngineChange:
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Description", "Change the engine");
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Hours", 5M);
                        break;
                    case CodeEnum.MirrorReplacement:
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Description", "Replace the mirror");
                        grvServiceTasks.SetRowCellValue(e.RowHandle, "Hours", 0.5M);
                        break;
                    default:
                        break;
                }



            }
        }
        

        private void repTransactionLinesViewBtn_Click(object sender, EventArgs e) {
            /*
            List<TransactionLine> allTransactionLines = new List<TransactionLine>(data.TransactionLines);
            int row = grvTransactions.GetFocusedDataSourceRowIndex();
            Guid currentTranstactionID = (Guid)grvTransactions.GetRowCellValue(row, "ID");
            List<TransactionLine> currentTransactionLines = new List<TransactionLine>();
            currentTransactionLines = allTransactionLines.FindAll(c =>
                        c.TransactionID == currentTranstactionID).ToList();
            */
        }
    }
}
