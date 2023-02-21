using FuelStation.Model.Enums;

namespace FuelStation.Model
{
    public class Item
    {
        public Item(string code, string description, ItemType itemType, decimal price, decimal cost)
        {
            Code = code;
            Description = description;
            Type = itemType;
            Price = price;
            Cost = cost;

            TransactionLines = new List<TransactionLine>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemType Type { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        public List<TransactionLine> TransactionLines { get; set; }
    }
}
