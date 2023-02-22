using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories
{
    public class ItemRepo : IEntityRepo<Item>
    {
        public void Create(Item entity)
        {
            using var context = new FuelStationDbContext();
            context.Items.Add(entity);
            context.SaveChanges();
        }

        public IList<Item> GetAll()
        {
            using var context = new FuelStationDbContext();
            return context.Items.ToList();

        }
        public Item? GetById(int id)
        {
            using var context = new FuelStationDbContext();
            return context.Items.Where(item => item.Id == id).SingleOrDefault();
        }


        public void Update(int id, Item entity)
        {
            using var context = new FuelStationDbContext();
            var foundItem = context.Items.SingleOrDefault(item => item.Id == id);
            if (foundItem is null)
                return;

            foundItem.Code = entity.Code;
            foundItem.Description = entity.Description;
            foundItem.Type = entity.Type;
            foundItem.Price = entity.Price;
            foundItem.Cost = entity.Cost;
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new FuelStationDbContext();
            var foundItem = context.Items.SingleOrDefault(item => item.Id == id);
            if (foundItem is null)
                return;

            context.Items.Remove(foundItem);
            context.SaveChanges();
        }
    }

}