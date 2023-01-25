﻿using LibCarService;
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
        //public List<TransactionLine> TransactionLines { get; set; }


        public CarServiceCenter() {
            Managers = new List<Manager>();
            Customers = new List<Customer>();
            Cars = new List<Car>();
            ServiceTasks = new List<ServiceTask>();
            Engineers = new List<Engineer>();
            Transactions = new List<Transaction>();
            //TransactionLines = new List<TransactionLine>();
        }


    }
}