using FuelStation.Shared;
using System.Net.Http;
using System.Net.Http.Json;

namespace WinForms {
    public partial class StaffForm : Form {
        private List<ItemDto> ItemList = new();

        public StaffForm() {
            InitializeComponent();
        }

        private async void StaffForm_Load(object sender, EventArgs e) {
            ItemList = await Program.httpClient.GetFromJsonAsync<List<ItemDto>>("api/item");
            itemsBS.DataSource = ItemList;
            itemsGrd.DataSource = itemsBS;
        }


    }
}