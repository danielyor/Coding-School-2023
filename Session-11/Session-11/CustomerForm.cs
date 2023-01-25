using DevExpress.ClipboardSource.SpreadsheetML;
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
using System.Windows.Forms;
using static LibCarService.ServiceTask;

namespace Session_11 {
    public partial class CustomerForm : Form {

        CarServiceCenter carServiceCenter;
        public CustomerForm() {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e) {

        }

        public void CustomerForm_Load_1(object sender, EventArgs e) {

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


            PrintDataToGrid();

        }

        private void btnSend_Click(object sender, EventArgs e) {
            
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(carServiceCenter, "carServiceCenter.json");

            MessageBox.Show("Data Saved!");
        }

        private void btnLoad_Click(object sender, EventArgs e) {

            string fileName = "carServiceCenter.json";

            Serializer serializer = new Serializer();

            if (File.Exists(fileName)) {
                carServiceCenter = serializer.Deserialize<CarServiceCenter>("carServiceCenter.json");
                if(carServiceCenter != null) {
                    PrintDataToGrid();
                }
                else {
                    MessageBox.Show("File is empty");
                }
            }
            else {
                MessageBox.Show("File not Found");
            }
        }

        public void PrintDataToGrid() {
            BindingList<Customer> customers = new BindingList<Customer>(carServiceCenter.Customers);
            grdCustomers.DataSource = new BindingSource() { DataSource = customers };

            BindingList<Car> cars = new BindingList<Car>(carServiceCenter.Cars);
            grdCars.DataSource = new BindingSource() { DataSource = cars };

            BindingList<ServiceTask> serviceTasks = new BindingList<ServiceTask>(carServiceCenter.ServiceTasks);
            grdServiceTasks.DataSource = new BindingSource() { DataSource = serviceTasks };
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

        private void btnPopulate_Click(object sender, EventArgs e) {
            PopulateCarCenter();
            
        }
    }
}
