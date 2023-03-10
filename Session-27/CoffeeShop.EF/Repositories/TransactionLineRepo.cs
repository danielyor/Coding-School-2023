using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repositories
{
    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        public void Create(TransactionLine entity)
        {
            using var context = new CoffeeShopDbContext();
            context.TransactionLines.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new CoffeeShopDbContext();
            var foundTransactionLine = context.TransactionLines.SingleOrDefault(TransactionLine => TransactionLine.Id == id);
            if (foundTransactionLine is null)
                return;

            context.TransactionLines.Remove(foundTransactionLine);
            context.SaveChanges();
        }

        public IList<TransactionLine> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            return context.TransactionLines.Include(trl => trl.Product).
                Include(trl => trl.Transaction).ToList();
        }

        public TransactionLine? GetById(int id)
        {
            using var context = new CoffeeShopDbContext();
            return context.TransactionLines.Where(TransactionLine => TransactionLine.Id == id).Include(trl => trl.Product)
                .Include(trl => trl.Transaction).SingleOrDefault();
        }
    

        public void Update(int id, TransactionLine entity)
        {
            using var context = new CoffeeShopDbContext();
            var foundTransactionLine = context.TransactionLines.SingleOrDefault(TransactionLine => TransactionLine.Id == id);
            if (foundTransactionLine is null)
                return;

            foundTransactionLine.Quantity = entity.Quantity;
            foundTransactionLine.TotalPrice = entity.TotalPrice;
            foundTransactionLine.Product = entity.Product;
            foundTransactionLine.ProductId = entity.ProductId;
            foundTransactionLine.Discount = entity.Discount;
            foundTransactionLine.Price = entity.Price;
            context.SaveChanges();
        }
    }
}
