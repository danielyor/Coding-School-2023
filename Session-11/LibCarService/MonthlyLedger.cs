﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService 
{
    public class MonthlyLedger
    {
        //to dateTime to vlepoume kai gia int

        // TODO: make properties private
        public DateTime Year { get; set; }

        public DateTime Month { get; set; }

        public decimal Income { get; set; }

        public decimal Expenses { get; set; }

        public decimal Total { get; set; }

        // TODO: implement Update() method to update the monthly ledger
    }
}

