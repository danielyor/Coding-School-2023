using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11.CarServiceLib
{
    public class MonthlyLedger
    {
        //to dateTime to vlepoume kai gia int
        public DateTime Year { get; set; }

        public DateTime Month { get; set; }

        public decimal Income { get; set; }

        public decimal Expenses { get; set; }

        public decimal Total { get; set; }
    }
}
