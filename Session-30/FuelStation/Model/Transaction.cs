using FuelStation.Model.Enums;

namespace FuelStation.Model
{
    public class Transaction
    {
        public Transaction() { }
        public Transaction(decimal totalValue, PaymentMethod paymentMethod)
        {
            Date = DateTime.Now;
            TotalValue = totalValue;
            PayMethod = paymentMethod;
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
