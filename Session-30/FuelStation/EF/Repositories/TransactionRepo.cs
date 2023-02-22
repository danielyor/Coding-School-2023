using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories
{
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        public void Create(Transaction entity)
        {
            using var context = new FuelStationDbContext();
            context.Transactions.Add(entity);
            context.SaveChanges();
        }

        public IList<Transaction> GetAll()
        {
            using var context = new FuelStationDbContext();
            return context.Transactions
                .Include(trans => trans.Customer)
                .Include(trans => trans.Employee)
                .Include(trans => trans.TransactionLines)
                .ThenInclude(tl => tl.Item).ToList();
        }

        public Transaction? GetById(int id)
        {
            using var context = new FuelStationDbContext();
            return context.Transactions.Where(trans => trans.Id == id)
                .Include(trans => trans.Customer)
                .Include(trans => trans.Employee)
                .Include(trans => trans.TransactionLines)
                .ThenInclude(tl => tl.Item).SingleOrDefault();
        }

        public void Update(int id, Transaction entity)
        {
            using var context = new FuelStationDbContext();
            var foundTrans = context.Transactions.SingleOrDefault(trans => trans.Id == id);
            if (foundTrans is null)
                return;

            foundTrans.Date = entity.Date;
            foundTrans.EmployeeId = entity.EmployeeId;
            foundTrans.CustomerId = entity.CustomerId;
            foundTrans.PayMethod = entity.PayMethod;
            foundTrans.TotalValue = entity.TotalValue;
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new FuelStationDbContext();
            var foundTrans = context.Transactions.SingleOrDefault(trans => trans.Id == id);
            if (foundTrans is null)
                return;

            context.Transactions.Remove(foundTrans);
            context.SaveChanges();
        }
    }
}
