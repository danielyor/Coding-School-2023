using FuelStation.Model.Enums;

namespace FuelStation.Shared {
    public class ItemDto {
        public int Id { get; set; }
        public string? Code { get; set; } = null;
        public string Description { get; set; } = string.Empty;
        public ItemType Type { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

    }
}
