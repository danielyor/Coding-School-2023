﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Model
{
    public class MonthlyLedger
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }

        MonthlyLedger() 
        {
            DateTime now = DateTime.Now;
            Year = now.Year;
            Month = now.Month;
            Total = Income - Expenses;
        }

    }
}
