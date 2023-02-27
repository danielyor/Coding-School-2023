using FuelStation.Model.Enums;

namespace FuelStation.Model
{
    public class Employee
    {
        public Employee() { }
        public Employee(string name, string surname, int salaryPerMonth, DateTime startDate, EmployeeType employeeType) {
            Name = name;
            Surname = surname;
            SalaryPerMonth = salaryPerMonth;
            HireDateStart = startDate;
            Type = employeeType;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; }
        public int SalaryPerMonth { get; set; }
        public EmployeeType Type { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; } = new();
    }
}
