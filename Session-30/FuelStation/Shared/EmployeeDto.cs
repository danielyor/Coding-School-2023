using FuelStation.Model.Enums;

namespace FuelStation.Shared {
    public class EmployeeDto {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        public int SalaryPerMonth { get; set; }
        public EmployeeType Type { get; set; }

    }
}
