using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService
{
    public class Transaction
    {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public Customer CustomerObj { get; set; }
        public Car CarObj { get; set; }
        public Manager ManagerObj { get; set; }
        public decimal TotalPrice { get; set; }
        public List<TransactionLine> Lines { get; set; } = new List<TransactionLine>();


        public Transaction()
        {
            ID = Guid.NewGuid();
        }
    }
}
