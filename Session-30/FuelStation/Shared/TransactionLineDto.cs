using FuelStation.Model;
using FuelStation.Model.Enums;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Json;

namespace FuelStation.Shared {
    public class TransactionLineDto {
        public TransactionLineDto() { }
        public TransactionLineDto(int transId, int itemId, int quantity) {
            TransactionId = transId;
            ItemId = itemId;
            Quantity = quantity;

            updateProps();
        }

        public async void updateProps() {
            HttpClient httpClient = new HttpClient(new HttpClientHandler()) {
                BaseAddress = new Uri("https://localhost:7049")
            };
            var item = await httpClient.GetFromJsonAsync<ItemDto>($"api/item/{ItemId}");

            ItemPrice = item.Price;
            NetValue = Quantity * item.Price;
            if (item.Type == ItemType.Fuel && NetValue > 20) {
                DiscountPercent = 0.1M;
            }
            DiscountValue = NetValue * DiscountPercent;
            TotalValue = NetValue - DiscountValue;
        }

        public int Id { get; set; }

        [Required]
        public int TransactionId { get; set; }

        [Required]
        public int ItemId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal ItemPrice { get; set; }


        public decimal NetValue { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }
    
    }
}
