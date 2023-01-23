﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11.CarServiceLib
{
    public class Transaction
    {

        public Guid ID { get; set; }

        public DateTime Date { get; set; }

        public Guid CustomerID { get; set; }

        public Guid CarID { get; set; }

        public Guid ManagerID { get; set; }

        public decimal TotalPrice { get; set; }

        public Transaction()
        {

        }
    }
}