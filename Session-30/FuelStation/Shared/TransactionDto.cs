using FuelStation.Model;
using FuelStation.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Shared {
    public class TransactionDto {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        public decimal TotalValue { get; set; } = 0;

        [Required]
        [RegularExpression("(CreditCard|Cash)", ErrorMessage = "The Payment Method field is required.")]
        public PaymentMethod PayMethod { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public List<TransactionLine> TransactionLines { get; set; } = new();
    
    }
}
