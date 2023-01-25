using DevExpress.ClipboardSource.SpreadsheetML;
using LibCarService;
using LibSerializer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibCarService.ServiceTask;

namespace Session_11 {
    public partial class CustomerForm : Form {

        List<Customer> customers;
        public Customer customer;
        CarServiceCenter carServiceCenter;
        public CustomerForm() {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e) {

        }

        public void CustomerForm_Load_1(object sender, EventArgs e) {

            PopulateCarCenter();
            
        }

        private void PopulateCarCenter() {

            carServiceCenter = new CarServiceCenter();

            Customer customer1 = new Customer() {
                Name = "Chris",
                Surname = "Typou",
                Phone = "6948192491",
                TIN = "123456789",
            };

            carServiceCenter.Customers.Add(customer1);

            Customer customer2 = new Customer() {
                Name = "Nick",
                Surname = "Pappas",
                Phone = "69284820582",
                TIN = "8575896865",
            };

            carServiceCenter.Customers.Add(customer2);

            Car car1 = new Car() {
                Brand = "Ford",
                Model = "Focus",
                CarRegistrationNumber = "AI78839"
            };

            carServiceCenter.Cars.Add(car1);

            Car car2 = new Car() {
                Brand = "Audi",
                Model = "A4",
                CarRegistrationNumber = "PI78542"
            };

            carServiceCenter.Cars.Add(car2);

            ServiceTask serviceTask1 = new ServiceTask() {
                Description = "Change Tires",
                Hours = 2.3M,
                Code = ServiceTask.CodeEnum.MirrorReplacement

            };
            
            carServiceCenter.ServiceTasks.Add(serviceTask1);

            ServiceTask serviceTask2 = new ServiceTask() {
                Description = "Full Service",
                Hours = 1.5M,
                Code = ServiceTask.CodeEnum.EngineChange
            };

            carServiceCenter.ServiceTasks.Add(serviceTask2);


            DataGridViewComboBoxColumn colCode = dgv2ServiceTask.Columns["colCode"] as DataGridViewComboBoxColumn;
            colCode.Items.Add(ServiceTask.CodeEnum.MirrorReplacement);
            colCode.Items.Add(ServiceTask.CodeEnum.TireChange);
            colCode.Items.Add(ServiceTask.CodeEnum.OilChange);
            

            PrintDataToGrid();

        }

        private void btnSend_Click(object sender, EventArgs e) {
            
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(carServiceCenter, "customers.json");

            MessageBox.Show("Order Sent!");
        }

        private void btnLoad_Click(object sender, EventArgs e) {

            Serializer serializer = new Serializer();
            carServiceCenter = serializer.Deserialize<CarServiceCenter>("customers.json");

            PrintDataToGrid();

            MessageBox.Show("Customers Loaded!");
        }

        public void PrintDataToGrid() {
            BindingList<Customer> customers = new BindingList<Customer>(carServiceCenter.Customers);
            grdCustomers.DataSource = new BindingSource() { DataSource = customers };

            BindingList<Car> cars = new BindingList<Car>(carServiceCenter.Cars);
            grdCars.DataSource = new BindingSource() { DataSource = cars };

            BindingList<ServiceTask> serviceTasks = new BindingList<ServiceTask>(carServiceCenter.ServiceTasks);
            grdServiceTasks.DataSource = new BindingSource() { DataSource = serviceTasks };


            bsCustomerOrder.DataSource = carServiceCenter.Customers;
            dgv2CustomerOrder.DataSource = bsCustomerOrder;

            bsCars.DataSource = carServiceCenter.Cars;
            dgv2Cars.DataSource = bsCars;

            bsServiceTask.DataSource = carServiceCenter.ServiceTasks;
            dgv2ServiceTask.DataSource = bsServiceTask;
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
    }
}
