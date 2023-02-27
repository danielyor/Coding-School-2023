using FuelStation.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Shared {
    public class ItemDto {
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [RegularExpression("(Fuel|Service|Product)", ErrorMessage = "The Item Type field is required.")]
        public ItemType Type { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public decimal Cost { get; set; }

    }
}
