using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        public void Create(Customer entity)
        {
            using var context = new FuelStationDbContext();
            context.Customers.Add(entity);
            context.SaveChanges();
        }

        public IList<Customer> GetAll()
        {
            using var context = new FuelStationDbContext();
            return context.Customers.Include(customer => customer.Transactions).ToList();
        }

        public Customer? GetById(int id)
        {
            using var context = new FuelStationDbContext();
            return context.Customers.Where(customer => customer.Id == id).Include(customer => customer.Transactions).SingleOrDefault();
        }

        public void Update(int id, Customer entity)
        {
            using var context = new FuelStationDbContext();
            var foundCustomer = context.Customers.Where(customer => customer.Id == id).Include(customer => customer.Transactions).SingleOrDefault();
            if (foundCustomer is null)
                return;

            foundCustomer.Name = entity.Name;
            foundCustomer.Surname = entity.Surname;
            foundCustomer.CardNumber = entity.CardNumber;
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new FuelStationDbContext();
            var foundCustomer = context.Customers.SingleOrDefault(customer => customer.Id == id);
            if (foundCustomer is null)
                return;

            context.Customers.Remove(foundCustomer);
            context.SaveChanges();
        }
    }
}
