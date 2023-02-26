using FuelStation.Shared;
using System.Net.Http;
using System.Net.Http.Json;

namespace WinForms {
    public partial class CashierForm : Form {
        private List<CustomerDto> CustomerList = new();
        private List<TransactionDto> TransactionList = new();

        public CashierForm() {
            InitializeComponent();
        }

        private async void CashierForm_Load(object sender, EventArgs e) {
            CustomerList = await Program.httpClient.GetFromJsonAsync<List<CustomerDto>>("api/customer");
            customersBS.DataSource = CustomerList;
            customersGrd.DataSource = customersBS;

            TransactionList = await Program.httpClient.GetFromJsonAsync<List<TransactionDto>>("api/transaction");
            transactionsBS.DataSource = TransactionList;
            transactionsGrd.DataSource = transactionsBS;
        }

    }
}