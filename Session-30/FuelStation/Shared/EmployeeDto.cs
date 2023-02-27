using FuelStation.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Shared {
    public class EmployeeDto {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Surname { get; set; }
        
        [Required]
        public DateTime HireDateStart { get; set; }

        public DateTime? HireDateEnd { get; set; }
        
        [Required] 
        public int SalaryPerMonth { get; set; }
        
        [Required]
        [RegularExpression("(Manager|Staff|Cashier)", ErrorMessage = "The Employee Type field is required.")]
        public EmployeeType Type { get; set; }

    }
}
