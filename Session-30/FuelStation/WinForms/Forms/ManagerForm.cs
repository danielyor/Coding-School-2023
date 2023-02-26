using FuelStation.Shared;
using System.Net.Http;
using System.Net.Http.Json;

namespace WinForms {
    public partial class ManagerForm : Form {
        private List<CustomerDto> CustomerList = new();
        private List<ItemDto> ItemList = new();
        private List<TransactionDto> TransactionList = new();

        public ManagerForm() {
            InitializeComponent();
        }

        private async void ManagerForm_Load(object sender, EventArgs e) {
            CustomerList = await Program.httpClient.GetFromJsonAsync<List<CustomerDto>>("api/customer");
            customersBS.DataSource = CustomerList;
            customersGrd.DataSource = customersBS;

            ItemList = await Program.httpClient.GetFromJsonAsync<List<ItemDto>>("api/item");
            itemsBS.DataSource = ItemList;
            itemsGrd.DataSource = itemsBS;

            TransactionList = await Program.httpClient.GetFromJsonAsync<List<TransactionDto>>("api/transaction");
            transactionsBS.DataSource = TransactionList;
            transactionsGrd.DataSource = transactionsBS;
        }

    }
}