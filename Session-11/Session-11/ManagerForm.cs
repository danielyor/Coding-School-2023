using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using LibCarService;
using LibSerializer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        }
       
        private void PopulateCarCenter() {

            carServiceCenter = new CarServiceCenter();
            DummyCarMech data = new();
            carServiceCenter.Customers = data.Customers;
            carServiceCenter.Cars = data.Cars;
            carServiceCenter.Managers = data.Managers;
            carServiceCenter.Engineers = data.Engineers;
            carServiceCenter.ServiceTasks = data.ServiceTasks;
            carServiceCenter.Transactions = data.Transactions;
            carServiceCenter.TransactionLines = data.TransactionLines;

        }
        private void SetFormGrids() {
            BindingList<Manager> managers = new BindingList<Manager>(carServiceCenter.Managers);
            grdManagers.DataSource = new BindingSource() { DataSource = managers };
            
            BindingList<Engineer> engineers = new BindingList<Engineer>(carServiceCenter.Engineers);
            grdEngineers.DataSource = new BindingSource() { DataSource = engineers };

            repManagers.DataSource = new BindingSource() { DataSource = managers };
            repManagers.DisplayMember = "Name";
            repManagers.ValueMember = "ID";
            repManagersView.Assign(grdManagers.MainView, false);

            BindingList<ServiceTask> serviceTasks = new BindingList<ServiceTask>(carServiceCenter.ServiceTasks);
            grdServiceTasks.DataSource = new BindingSource() { DataSource = serviceTasks };

            BindingList<LibCarService.Transaction> transactions = new BindingList<LibCarService.Transaction>(carServiceCenter.Transactions);
            grdTransactions.DataSource = new BindingSource() { DataSource = transactions };

            BindingList<Car> cars = new BindingList<Car>(carServiceCenter.Cars);
            repCars.DataSource = new BindingSource() { DataSource = cars };
            repCars.DisplayMember = "Model";
            repCars.ValueMember = "ID";

            BindingList<Customer> customers = new BindingList<Customer>(carServiceCenter.Customers);
            repCustomers.DataSource = new BindingSource() { DataSource = customers };
            repCustomers.DisplayMember = "Surname";
            repCustomers.ValueMember = "ID";
            
            

            repManagers2.DataSource = new BindingSource() { DataSource = managers };
            repManagers2.DisplayMember = "Surname";
            repManagers2.ValueMember = "ID";
            gridView2.Assign(grdManagers.MainView, false);

            
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
            
            List<TransactionLine> allTransactionLines = new List<TransactionLine>(carServiceCenter.TransactionLines);
            int row = grvTransactions.GetFocusedDataSourceRowIndex();
            Guid currentTranstactionID = (Guid)grvTransactions.GetRowCellValue(row, "ID");
            List<TransactionLine> currentTransactionLines = new List<TransactionLine>();
            currentTransactionLines = allTransactionLines.FindAll(c =>c.TransactionID == currentTranstactionID).ToList();

            grdTransactionLines.DataSource = currentTransactionLines;
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            string fileName = "carServiceCenter.json";

            Serializer serializer = new Serializer();

            if (File.Exists(fileName)) {
                carServiceCenter = serializer.Deserialize<CarServiceCenter>("carServiceCenter.json");
                if (carServiceCenter != null) {
                    SetFormGrids();
                }
                else {
                    MessageBox.Show("File is empty");
                }
            }
            else {
                MessageBox.Show("File not Found");
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(carServiceCenter, "carServiceCenter.json");

            MessageBox.Show("Data Saved!");
        }

        private void btnPopulate_Click(object sender, EventArgs e) {
            PopulateCarCenter();
            SetFormGrids();
        }
    }
}
