using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService
{
    public class TransactionLine
    {
        public Guid ID { get; set; }
        public Transaction TransactionObj { get; set; }
        public ServiceTask ServiceTaskObj { get; set; }
        public Engineer EngineerObj { get; set; }
        public decimal Hours { get; set; }
        public decimal PricePerHour { get; set; }
        public decimal Price { get; set; }


        public TransactionLine()
        {
            ID = Guid.NewGuid();
        }
    }
}
