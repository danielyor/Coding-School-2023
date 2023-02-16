using CoffeeShop.Model.Enums;


namespace CoffeeShop.Blazor.Shared {
    public class ProductCategoryEditDto {

        public int Id { get; set; }
        public String Code { get; set; } = null!;
        public String Description { get; set; } = null!;
        public ProductType ProductType { get; set; }
    }
}