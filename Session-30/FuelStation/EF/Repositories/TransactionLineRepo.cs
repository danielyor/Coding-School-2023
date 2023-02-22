using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories
{
    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        public void Create(TransactionLine entity)
        {
            using var context = new FuelStationDbContext();
            context.TransactionLines.Add(entity);
            context.SaveChanges();
        }

        public IList<TransactionLine> GetAll()
        {
            using var context = new FuelStationDbContext();
            return context.TransactionLines.Include(trl => trl.Item).Include(trl => trl.Transaction).ToList();
        }

        public TransactionLine? GetById(int id)
        {
            using var context = new FuelStationDbContext();
            return context.TransactionLines.Where(TransactionLine => TransactionLine.Id == id).Include(trl => trl.Item).Include(trl => trl.Transaction).SingleOrDefault();
        }
    

        public void Update(int id, TransactionLine entity)
        {
            using var context = new FuelStationDbContext();
            var foundTransactionLine = context.TransactionLines.SingleOrDefault(TransactionLine => TransactionLine.Id == id);
            if (foundTransactionLine is null)
                return;

            foundTransactionLine.TransactionId = entity.TransactionId;
            foundTransactionLine.ItemId = entity.ItemId;
            foundTransactionLine.Quantity = entity.Quantity;
            foundTransactionLine.ItemPrice = entity.ItemPrice;
            foundTransactionLine.NetValue = entity.NetValue;
            foundTransactionLine.DiscountPercent = entity.DiscountPercent;
            foundTransactionLine.DiscountValue = entity.DiscountValue;
            foundTransactionLine.TotalValue = entity.TotalValue; 
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new FuelStationDbContext();
            var foundTransactionLine = context.TransactionLines.SingleOrDefault(TransactionLine => TransactionLine.Id == id);
            if (foundTransactionLine is null)
                return;

            context.TransactionLines.Remove(foundTransactionLine);
            context.SaveChanges();
        }
    }
}
