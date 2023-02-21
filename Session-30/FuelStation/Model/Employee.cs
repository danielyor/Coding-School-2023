using FuelStation.Model.Enums;

namespace FuelStation.Model
{
    public class Employee
    {
        public Employee(string name, string surname, int salaryPerMonth, DateOnly startDate, EmployeeType employeeType) {
            Name = name;
            Surname = surname;
            SalaryPerMonth = salaryPerMonth;
            HireDateStart = startDate;
            Type = employeeType;

            Transactions = new List<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly HireDateStart { get; set; }
        public DateOnly? HireDateEnd { get; set; }
        public int SalaryPerMonth { get; set; }
        public EmployeeType Type { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}
