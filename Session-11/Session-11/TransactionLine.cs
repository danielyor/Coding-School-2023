﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11 {
    public class TransactionLine {

        public Guid ID { get; set; }  

        public Guid TransactionID { get; set; }

        public Guid ServiceTaskID { get; set; }

        public Guid EngineerID { get; set; }

        public decimal Hours { get; set; }

        public decimal PricePerHour { get; set; }  

        public decimal Price { get; set; }

        public TransactionLine() {

        }
    }
}
