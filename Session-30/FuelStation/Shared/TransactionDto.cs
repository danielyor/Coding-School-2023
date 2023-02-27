using FuelStation.Model;
using FuelStation.Model.Enums;

namespace FuelStation.Shared {
    public class TransactionDto {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public decimal TotalValue { get; set; } = 0;
        public PaymentMethod PayMethod { get; set; }

        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public List<TransactionLine> TransactionLines { get; set; } = new();
    
    }
}
