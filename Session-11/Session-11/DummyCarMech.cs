using LibCarService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibCarService.ServiceTask;

namespace Session_11 {
    public partial class DummyCarMech : CarServiceCenter {

        public DummyCarMech() {
            PopulateCustomers();
            PopulateManagers();
            PopulateCars();
            PopulateEngineers();
            PopulateServiceTasks();
            Transaction();
            TransactionLine();
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
            serviceTask1.Code = ServiceTask.CodeEnum.BrokenWindow;
            ServiceTasks.Add(serviceTask1);

            ServiceTask serviceTask2 = new ServiceTask();
            serviceTask1.Code = ServiceTask.CodeEnum.TireChange;
            ServiceTasks.Add(serviceTask2);

            serviceTask1.UpdateInfo(serviceTask1.Code);
            serviceTask2.UpdateInfo(serviceTask2.Code);
            //Propably in a function/
            /*
            switch (serviceTask1.Code)
            {
                case CodeEnum.OilChange:
                    serviceTask1.Description = "Change the oils";
                    serviceTask1.Hours = 1.5M;
                    serviceTask1.Code = ServiceTask.CodeEnum.OilChange;
                    break;
                case CodeEnum.TireChange:
                    serviceTask1.Description = "Change the tire";
                    serviceTask1.Hours = 2.5M;
                    serviceTask1.Code = ServiceTask.CodeEnum.TireChange;
                    break;
                case CodeEnum.BrokenWindow:
                    serviceTask1.Description = "Fix the broken window";
                    serviceTask1.Hours = 1.25M;
                    serviceTask1.Code = ServiceTask.CodeEnum.BrokenWindow;
                    break;
                case CodeEnum.EngineChange:
                    serviceTask1.Description = "Change the engine";
                    serviceTask1.Hours = 2;
                    serviceTask1.Code = ServiceTask.CodeEnum.EngineChange;
                    break;
                case CodeEnum.MirrorReplacement:
                    serviceTask1.Description = "Replace the mirror";
                    serviceTask1.Hours = 0.5M;
                    serviceTask1.Code = ServiceTask.CodeEnum.MirrorReplacement;
                    break;
                default:
                    break;
            }*/


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
            engineer1.ManagerObj = Managers[0];
            engineer1.SalaryPerMonth = 1000;
            Engineers.Add(engineer1);

            Engineer engineer2 = new Engineer();
            engineer2.Surname = "Xariton";
            engineer2.Name = "Giotis";
            engineer2.ManagerObj = Managers[0];
            engineer2.SalaryPerMonth = 1100;
            Engineers.Add(engineer2);

        }

        //Guid customerID, Guid managerID, Guid carID ->transaction parameters
        public void Transaction() {
            Transaction transaction1 = new Transaction();
            transaction1.Date = DateTime.Now;
            transaction1.CustomerObj = Customers[0];
            transaction1.ManagerObj = Managers[0];
            transaction1.CarObj = Cars[0];
            transaction1.TotalPrice = 91;

            Transactions.Add(transaction1);

            Transaction transaction2 = new Transaction();
            transaction2.Date = DateTime.Now;
            transaction2.CustomerObj = Customers[1];
            transaction2.ManagerObj = Managers[1];
            transaction2.CarObj = Cars[1];
            transaction2.TotalPrice = 0;

            Transactions.Add(transaction2);

        }

        //Guid transactionID, Guid engineerID, Guid serviceTaskID, decimal hours
        public void TransactionLine() {
            TransactionLine transactionLine1 = new TransactionLine();
            transactionLine1.TransactionObj = Transactions[0];
            transactionLine1.Hours = ServiceTasks[0].Hours;
            transactionLine1.PricePerHour = 45.5M;
            transactionLine1.EngineerObj = Engineers[0];
            transactionLine1.ServiceTaskObj = ServiceTasks[0];
            //TransactionLines.Add(transactionLine1);

            TransactionLine transactionLine2 = new TransactionLine();
            transactionLine1.TransactionObj = Transactions[0];
            transactionLine1.Hours = ServiceTasks[1].Hours;
            transactionLine1.PricePerHour = 45.5M;
            transactionLine1.EngineerObj = Engineers[0];
            transactionLine1.ServiceTaskObj = ServiceTasks[1];
            //TransactionLines.Add(transactionLine2);

            Transactions[0].Lines.Add(transactionLine1);
            Transactions[0].Lines.Add(transactionLine2);
        }


        public void CreateMonthlyLedger() {
            
            DateTime date = DateTime.Now;
            MonthlyLedger monthlyLedger1 = new MonthlyLedger(date);
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
