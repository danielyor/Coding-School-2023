using LibCarService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11 {
    public class CarServiceCenter {

        public List<Manager> Managers { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Car> Cars { get; set; }
        public List<ServiceTask> ServiceTasks { get; set; }
        public List<Engineer> Engineers { get; set; }
        public List<Transaction> Transactions { get; set; }
        public List<TransactionLine> TransactionLines { get; set; }


        public CarServiceCenter() {
            //PopulateCustomers();
            //PopulateManagers();

            //PopulateCars();
            //PopulateEngineers();
            //PopulateServiceTasks();
            Managers = new List<Manager>();
            Customers = new List<Customer>();
            Cars = new List<Car>();
            ServiceTasks = new List<ServiceTask>();
            Engineers = new List<Engineer>();
            Transactions = new List<Transaction>();
            TransactionLines = new List<TransactionLine>();


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
            Customers.Add(customer1);

            Customer customer2 = new Customer();
            customer2.Name = "Nick";
            customer2.Surname = "Pappas";
            customer2.Phone = "69284820582";
            customer2.TIN = "8575896865";
            Customers.Add(customer2);
        }
        public void PopulateManagers() {
            Manager manager1 = new Manager();
            manager1.Name = "Jack";
            manager1.Surname = "Daniels";
            manager1.SalaryPerMonth = 2500;
            Managers.Add(manager1);

            Manager manager2 = new Manager();
            manager2.Name = "Johnie";
            manager2.Surname = "Walker";
            manager2.SalaryPerMonth = 2200;
            Managers.Add(manager2);
        }


        public void PopulateServiceTasks() {
            ServiceTask serviceTask1 = new ServiceTask();
            serviceTask1.Description = "Brakes Change";
            serviceTask1.Hours = 2.3M;
            ServiceTasks.Add(serviceTask1);

            ServiceTask serviceTask2 = new ServiceTask();
            serviceTask1.Description = "Tires Change";
            serviceTask1.Hours = 1.5M;
            ServiceTasks.Add(serviceTask1);
            //serviceTask1.Code = "";
        }

        public void PopulateCars() {
            Car car1 = new Car();
            car1.Brand = "Ford";
            car1.Model = "Focus";
            car1.CarRegistrationNumber = "AI78839";
            Cars.Add(car1);

            Car car2 = new Car();
            car2.Brand = "Audi";
            car2.Model = "A4";
            car2.CarRegistrationNumber = "PI78542";
            Cars.Add(car2);
        }

        public void PopulateEngineers() {
            Engineer engineer1 = new Engineer();
            engineer1.Surname = "Nikou";
            engineer1.Name = "Nikos";
            engineer1.ManagerID = Managers[0].ID;
            Engineers.Add(engineer1);

            Engineer engineer2 = new Engineer();
            engineer1.Surname = "Xariton";
            engineer1.Name = "Giotis";
            engineer1.ManagerID = Managers[0].ID;
            Engineers.Add(engineer1);

        }

        //Guid customerID, Guid managerID, Guid carID ->transaction parameters
        public void Transaction() {
            Transaction transaction1 = new Transaction();
            transaction1.Date = DateTime.Now;
            transaction1.CustomerID = Customers[0].ID;
            transaction1.ManagerID = Managers[0].ID;
            transaction1.CarID = Cars[0].ID;
            //transaction1.CustomerID = customerID;
            //transaction1.ManagerID = managerID;
            //transaction1.CarID = carID;
        }
        //Guid transactionID, Guid engineerID, Guid serviceTaskID, decimal hours
        public void TransactionLine() {
            TransactionLine transactionLine1 = new TransactionLine();
            transactionLine1.TransactionID = Transactions[0].ID;
            transactionLine1.Hours = ServiceTasks[0].Hours;
            transactionLine1.PricePerHour = 45.5M;
            transactionLine1.EngineerID = Engineers[0].ID;
            transactionLine1.ServiceTaskID = ServiceTasks[0].ID;
            TransactionLines.Add(transactionLine1);

            TransactionLine transactionLine2 = new TransactionLine();
            transactionLine1.TransactionID = Transactions[0].ID;
            transactionLine1.Hours = ServiceTasks[1].Hours;
            transactionLine1.PricePerHour = 45.5M;
            transactionLine1.EngineerID = Engineers[0].ID;
            transactionLine1.ServiceTaskID = ServiceTasks[1].ID;
            TransactionLines.Add(transactionLine2);
        }


        public void CreateMonthlyLedger() {
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
