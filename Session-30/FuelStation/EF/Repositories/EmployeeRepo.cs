using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories
{
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        public void Create(Employee entity)
        {
            using var context = new FuelStationDbContext();
            context.Employees.Add(entity);
            context.SaveChanges();
        }

        public IList<Employee> GetAll()
        {
            using var context = new FuelStationDbContext();
            return context.Employees.Include(customer => customer.Transactions).ToList();
        }

        public Employee? GetById(int id)
        {
            using var context = new FuelStationDbContext();
            return context.Employees.Where(employee => employee.Id == id).SingleOrDefault();
        }

        public void Update(int id, Employee entity)
        {
            using var context = new FuelStationDbContext();
            var foundEmployee = context.Employees.SingleOrDefault(employee => employee.Id == id);
            if (foundEmployee is null)
                return;

            foundEmployee.Name = entity.Name;
            foundEmployee.Surname = entity.Surname;
            foundEmployee.HireDateStart = entity.HireDateStart;
            foundEmployee.HireDateEnd = entity.HireDateEnd;
            foundEmployee.SalaryPerMonth = entity.SalaryPerMonth;
            foundEmployee.Type = entity.Type;
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new FuelStationDbContext();
            var foundEmployee = context.Employees.SingleOrDefault(employee => employee.Id == id);
            if (foundEmployee is null)
                return;

            context.Employees.Remove(foundEmployee);
            context.SaveChanges();
        }
    }
}
