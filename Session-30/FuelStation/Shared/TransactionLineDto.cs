using FuelStation.Model;
using FuelStation.Model.Enums;

namespace FuelStation.Shared {
    public class TransactionLineDto {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }
    
    }
}
