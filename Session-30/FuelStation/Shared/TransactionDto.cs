using FuelStation.Model;
using FuelStation.Model.Enums;

namespace FuelStation.Shared {
    public class TransactionDto {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalValue { get; set; }
        public PaymentMethod PayMethod { get; set; }

        public List<TransactionLine> TransactionLines { get; set; } = new();
    
    }
}
