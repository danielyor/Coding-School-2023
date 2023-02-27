using FuelStation.Model.Enums;

namespace FuelStation.Model
{
    public class Transaction
    {
        public Transaction() { }
        public Transaction(int empId, int cusId, PaymentMethod paymentMethod, decimal totalValue)
        {
            Date = DateTime.Now;
            EmployeeId = empId;
            CustomerId = cusId;
            PayMethod = paymentMethod;
            TotalValue = totalValue;
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalValue { get; set; }
        public PaymentMethod PayMethod { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = null!;

        public List<TransactionLine> TransactionLines { get; set; } = new();
    }
}
