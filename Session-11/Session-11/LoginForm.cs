using System;
using LibCarService;
using LibSerializer;

namespace Session_11 {
    public partial class LoginForm : Form {

        public List<Manager> managers = new List<Manager>();
        public List<Customer> customers = new List<Customer>();
        public List<Car> cars = new List<Car>();
        public List<ServiceTask> serviceTasks = new List<ServiceTask>();
        public List<Engineer> engineers = new List<Engineer>();
        public List<Transaction> transactions = new List<Transaction>();
        public List<TransactionLine> transactionLines = new List<TransactionLine>();
        public LoginForm() {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e) {
            PopulateCustomers();
            PopulateManagers();

            PopulateCars();
            PopulateEngineers();
            PopulateServiceTasks();


            //Code?
            //CreateTransaction(customerID,managerID,carID);
            //CreateTransactionLine(Guid transactionID, Guid engineerID, Guid serviceTaskID, decimal hours)
        }
        public void PopulateCustomers() {
            Customer customer1 = new Customer();
            customer1.Name = "Chris";
            customer1.Surname = "Typou";
            customer1.Phone = "6948192491";
            customer1.TIN = "123456789";
            customers.Add(customer1);

            Customer customer2 = new Customer();
            customer2.Name = "Nick";
            customer2.Surname = "Pappas";
            customer2.Phone = "69284820582";
            customer2.TIN = "8575896865";
            customers.Add(customer2);
        }
        public void PopulateManagers() {
            Manager manager1 = new Manager();
            manager1.Name = "Jack";
            manager1.Surname = "Daniels";
            manager1.SalaryPerMonth = 2500;
            managers.Add(manager1);

            Manager manager2 = new Manager();
            manager2.Name = "Johnie";
            manager2.Surname = "Walker";
            manager2.SalaryPerMonth = 2200;
            managers.Add(manager2);
        }


        public void PopulateServiceTasks() {
            ServiceTask serviceTask1 = new ServiceTask();
            serviceTask1.Description = "Brakes Change";
            serviceTask1.Hours = 2.3M;
            serviceTasks.Add(serviceTask1);

            ServiceTask serviceTask2 = new ServiceTask();
            serviceTask1.Description = "Tires Change";
            serviceTask1.Hours = 1.5M;
            serviceTasks.Add(serviceTask1);
            //serviceTask1.Code = "";
        }

        public void PopulateCars() {
            Car car1 = new Car();
            car1.Brand = "Ford";
            car1.Model = "Focus";
            car1.CarRegistrationNumber = "AI78839";
            cars.Add(car1);

            Car car2 = new Car();
            car2.Brand = "Audi";
            car2.Model = "A4";
            car2.CarRegistrationNumber = "PI78542";
            cars.Add(car2);
        }

        public void PopulateEngineers() {
            Engineer engineer1 = new Engineer();
            engineer1.Surname = "Nikou";
            engineer1.Name = "Nikos";
            engineer1.ManagerID = managers[0].ID;
            engineers.Add(engineer1);

            Engineer engineer2 = new Engineer();
            engineer1.Surname = "Xariton";
            engineer1.Name = "Giotis";
            engineer1.ManagerID = managers[0].ID;
            engineers.Add(engineer1);

        }

        //Guid customerID, Guid managerID, Guid carID ->transaction parameters
        public void Transaction() {
            Transaction transaction1 = new Transaction();
            transaction1.Date = DateTime.Now;
            transaction1.CustomerID = customers[0].ID;
            transaction1.ManagerID = managers[0].ID;
            transaction1.CarID = cars[0].ID;
            //transaction1.CustomerID = customerID;
            //transaction1.ManagerID = managerID;
            //transaction1.CarID = carID;
        }
        //Guid transactionID, Guid engineerID, Guid serviceTaskID, decimal hours
        public void TransactionLine() {
            TransactionLine transactionLine1 = new TransactionLine();
            transactionLine1.TransactionID = transactions[0].ID;
            transactionLine1.Hours = serviceTasks[0].Hours;
            transactionLine1.PricePerHour = 45.5M;
            transactionLine1.EngineerID = engineers[0].ID;
            transactionLine1.ServiceTaskID = serviceTasks[0].ID;
            transactionLines.Add(transactionLine1);

            TransactionLine transactionLine2 = new TransactionLine();
            transactionLine1.TransactionID = transactions[0].ID;
            transactionLine1.Hours = serviceTasks[1].Hours;
            transactionLine1.PricePerHour = 45.5M;
            transactionLine1.EngineerID = engineers[0].ID;
            transactionLine1.ServiceTaskID = serviceTasks[1].ID;
            transactionLines.Add(transactionLine2);
        }


        public void CreateMonthlyLedger() {
            MonthlyLedger monthlyLedger1 = new MonthlyLedger();
            monthlyLedger1.Month = DateTime.Parse(DateTime.Now.Month.ToString());
            monthlyLedger1.Year = DateTime.Parse(DateTime.Now.Year.ToString());
            //monthlyLedger1.Income
            //monthlyLedger1.Expenses    
            //monthlyLedger1.Total

        }

        public void LoginForm_Load(object sender, EventArgs e) {

        }

        public void btnCustomer_Click(object sender, EventArgs e) {
            CustomerForm customerForm = new();
            customerForm.ShowDialog();
        }

        public void btnManager_Click(object sender, EventArgs e) {
            ManagerForm managerForm = new();
            managerForm.ShowDialog();
        }

        public void btnEngineer_Click(object sender, EventArgs e) {
            EngineerForm engineerForm = new();
            engineerForm.ShowDialog();
        }
        //public TransactionLine CalculatePrice(TransactionLine transactionline)
        //{
        //    transactionLine.Price = transactionLine.PricePerHour * TransactionLine.Hours;

        //    return transactionLine;
        //}
    }
}