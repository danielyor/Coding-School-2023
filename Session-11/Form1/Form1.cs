
using Session_11.CarServiceLib;
using System;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateCustomer();
            CreateCar();

            //CreateEngineer(ManagerID);
            CreateManager();
            //Code?
            CreateServiceTask();
            //CreateTransaction(customerID,managerID,carID);
            //CreateTransactionLine(Guid transactionID, Guid engineerID, Guid serviceTaskID, decimal hours)
        }

        public void CreateCustomer()
        {
            Customer customer1 = new Customer();
            customer1.ID = Guid.NewGuid();
            customer1.Name = "Chris";
            customer1.Surname = "Typou";
            customer1.Phone = "6948192491";
            customer1.TIN = "What's this";
            Customer customer2 = new Customer();
            customer2.ID = Guid.NewGuid();
            customer2.Name = "Nick";
            customer2.Surname = "Pappas";
            customer2.Phone = "69284820582";
            customer2.TIN = "What's this";
        }
        public void CreateManager()
        {
            Manager manager1 = new Manager();
            manager1.ID = Guid.NewGuid();
            manager1.Name = "Jack";
            manager1.Surname = "Daniels";
        }

        public void CreateCar()
        {
            Car car1 = new Car();
            car1.ID = Guid.NewGuid();
            car1.Brand = "Ford";
            car1.Model = "Focus";
            car1.CarRegistrationNumber = "AI78839";
        }
        public void CreateEngineer(Guid managerID)
        {
            Engineer engineer1 = new Engineer();
            engineer1.ID = Guid.NewGuid();
            engineer1.Surname = "Nikou";
            engineer1.Name = "Nikos";
            engineer1.ManagerID = managerID;
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

        public void CreateServiceTask()
        {
            ServiceTask serviceTask1 = new ServiceTask();
            serviceTask1.ID = Guid.NewGuid();
            serviceTask1.Description = "Description";
            serviceTask1.Hours = 2;
            //serviceTask1.Code
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

    }
}