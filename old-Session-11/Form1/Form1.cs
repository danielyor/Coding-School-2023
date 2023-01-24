
using Session_11.CarServiceLib;
using System;

namespace Form1
{
    public partial class Form1 : Form
    {

        private List<Manager> _managers = new List<Manager>();
        private List<Customer> _customers = new List<Customer>();
        private List<Car> _cars = new List<Car>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            PopulateCustomers();
            PopulateManagers();

            PopulateCars();
            PopulateEngineers();
            PopulateServiceTasks();


            //Code?
            //CreateTransaction(customerID,managerID,carID);
            //CreateTransactionLine(Guid transactionID, Guid engineerID, Guid serviceTaskID, decimal hours)
        }

        public void PopulateCustomers()
        {   
            Customer customer1 = new Customer();
            customer1.ID = Guid.NewGuid();
            customer1.Name = "Chris";
            customer1.Surname = "Typou";
            customer1.Phone = "6948192491";
            customer1.TIN = "123456789";
            _customers.Add(customer1);

            Customer customer2 = new Customer();
            customer2.ID = Guid.NewGuid();
            customer2.Name = "Nick";
            customer2.Surname = "Pappas";
            customer2.Phone = "69284820582";
            customer2.TIN = "What's this";
            _customers.Add(customer2);
        }
        public void PopulateManagers()
        {
            Manager manager1 = new Manager();
            manager1.ID = Guid.NewGuid();
            manager1.Name = "Jack";
            manager1.Surname = "Daniels";
            manager1.SalaryPerMonth = 2500;
            _managers.Add(manager1);

            Manager manager2 = new Manager();
            manager2.ID = Guid.NewGuid();
            manager2.Name = "Johnie";
            manager2.Surname = "Walker";
            manager2.SalaryPerMonth = 2200;
            _managers.Add(manager2);
        }


        public void PopulateServiceTasks() {
            ServiceTask serviceTask1 = new ServiceTask();
            serviceTask1.ID = Guid.NewGuid();
            serviceTask1.Description = "Brakes Change";
            serviceTask1.Hours = 2.3M;

            ServiceTask serviceTask2 = new ServiceTask();
            serviceTask1.ID = Guid.NewGuid();
            serviceTask1.Description = "Tires Change";
            serviceTask1.Hours = 1.5M;
            //serviceTask1.Code = "";
        }

        public void PopulateCars()
        {
            Car car1 = new Car();
            car1.ID = Guid.NewGuid();
            car1.Brand = "Ford";
            car1.Model = "Focus";
            car1.CarRegistrationNumber = "AI78839";
            _cars.Add(car1);

            Car car2 = new Car();
            car2.ID = Guid.NewGuid();
            car2.Brand = "Audi";
            car2.Model = "A4";
            car2.CarRegistrationNumber = "PI78542";
            _cars.Add(car2);
        }

        public void PopulateEngineers()
        {
            Engineer engineer1 = new Engineer();
            engineer1.ID = Guid.NewGuid();
            engineer1.Surname = "Nikou";
            engineer1.Name = "Nikos";
            engineer1.ManagerID = _managers[0].ID;
        }


        public void Transaction(Guid customerID, Guid managerID, Guid carID)
        {
            Transaction transaction1 = new Transaction();
            transaction1.ID = Guid.NewGuid();
            transaction1.Date = DateTime.Now;
            transaction1.CustomerID = customerID;
            transaction1.ManagerID = managerID;
            transaction1.CarID = carID;
        }
        public void TransactionLine(Guid transactionID, Guid engineerID, Guid serviceTaskID, decimal hours)
        {
            TransactionLine transactionLine1 = new TransactionLine();
            transactionLine1.ID = Guid.NewGuid();
            transactionLine1.TransactionID = transactionID;
            transactionLine1.Hours = hours;
            transactionLine1.PricePerHour = 45.5M;
            transactionLine1.EngineerID = engineerID;
            transactionLine1.ServiceTaskID = serviceTaskID;

        }

        
        public void CreateMonthlyLedger()
        {
            MonthlyLedger monthlyLedger1 = new MonthlyLedger();
            monthlyLedger1.Month = DateTime.Parse(DateTime.Now.Month.ToString());
            monthlyLedger1.Year = DateTime.Parse(DateTime.Now.Year.ToString());
            //monthlyLedger1.Income
            //monthlyLedger1.Expenses    
            //monthlyLedger1.Total

        }
        //public TransactionLine CalculatePrice(TransactionLine transactionline)
        //{
        //    transactionLine.Price = transactionLine.PricePerHour * TransactionLine.Hours;

        //    return transactionLine;
        //}
    }
}