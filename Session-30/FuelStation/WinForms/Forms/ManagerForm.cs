using FuelStation.Model;
using FuelStation.Shared;
using FuelStation.WinForms.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;

namespace WinForms {
    public partial class ManagerForm : Form {
        private List<CustomerDto> CustomerList = new();
        private List<ItemDto> ItemList = new();
        private List<TransactionDto> TransactionList = new();

        public async void LoadCustomers() {
            CustomerList = await Program.httpClient.GetFromJsonAsync<List<CustomerDto>>("api/customer");
            customersBS.DataSource = CustomerList;
            customersGrd.DataSource = customersBS;
        }

        public async void LoadItems() {
            ItemList = await Program.httpClient.GetFromJsonAsync<List<ItemDto>>("api/item");
            itemsBS.DataSource = ItemList;
            itemsGrd.DataSource = itemsBS;
        }

        public async void LoadTransactions() {
            TransactionList = await Program.httpClient.GetFromJsonAsync<List<TransactionDto>>("api/transaction");
            transactionsBS.DataSource = TransactionList;
            transactionsGrd.DataSource = transactionsBS;
        }

        public ManagerForm() {
            InitializeComponent();
        }

        private async void ManagerForm_Load(object sender, EventArgs e) {
            LoadCustomers();
            LoadItems();
            LoadTransactions();
        }

        // Customer Buttons
        private async void addCustomerBtn_Click(object sender, EventArgs e) {
            CustomerCreateForm form = new();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK) {
                LoadCustomers();
            }
        }

        private async void editCustomerBtn_Click(object sender, EventArgs e) {
            DataGridViewRow row = customersGrd.SelectedRows[0];
            var rowId = row.Cells["Id"].Value;
            if (customersGrd.SelectedRows.Count == 1 && rowId is int) {
                CustomerEditForm form = new((int)rowId);
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK) {
                    LoadCustomers();
                }
            }
        }

        private async void deleteCustomerBtn_Click(object sender, EventArgs e) {
            DataGridViewRow row = customersGrd.SelectedRows[0];
            var rowId = row.Cells["Id"].Value;
            if (customersGrd.SelectedRows.Count == 1 && rowId is int) {
                DialogResult result = MessageBox.Show("Selected Customer will be deleted!", "Delete Customer", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK) {
                    var response = await Program.httpClient.DeleteAsync($"api/customer/{rowId}");
                    if (response.StatusCode == HttpStatusCode.OK) {
                        customersGrd.Rows.Remove(row);
                    }
                    else {
                        MessageBox.Show("Something went wrong! Delete failed.", "Alert");
                    }
                }
            }
        }

        // Items Buttons
        private async void addItemBtn_Click(object sender, EventArgs e) {
            ItemCreateForm form = new();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK) {
                LoadItems();
            }
        }

        private async void editItemBtn_Click(object sender, EventArgs e) {
            DataGridViewRow row = itemsGrd.SelectedRows[0];
            var rowId = row.Cells["Id"].Value;
            if (itemsGrd.SelectedRows.Count == 1 && rowId is int) {
                ItemEditForm form = new((int)rowId);
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK) {
                    LoadItems();
                }
            }
        }

        private async void deleteItemBtn_Click(object sender, EventArgs e) {
            DataGridViewRow row = itemsGrd.SelectedRows[0];
            var rowId = row.Cells["Id"].Value;
            if (itemsGrd.SelectedRows.Count == 1 && rowId is int) {
                DialogResult result = MessageBox.Show("Selected Item will be deleted!", "Delete Item", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK) {
                    var response = await Program.httpClient.DeleteAsync($"api/item/{rowId}");
                    if (response.StatusCode == HttpStatusCode.OK) {
                        itemsGrd.Rows.Remove(row);
                    }
                    else {
                        MessageBox.Show("Something went wrong! Delete failed.", "Alert");
                    }
                }
            }
        }


        // Transactions Buttons
        private async void addTransactionBtn_Click(object sender, EventArgs e) {
            TransactionCreateForm form = new();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK) {
                LoadTransactions();
            }
        }

        private async void editTransactionsBtn_Click(object sender, EventArgs e) {
            DataGridViewRow row = transactionsGrd.SelectedRows[0];
            var rowId = row.Cells["Id"].Value;
            if (transactionsGrd.SelectedRows.Count == 1 && rowId is int) {
                TransactionEditForm form = new((int)rowId);
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK) {
                    LoadTransactions();
                }
            }
        }

        private async void deleteTransactionsBtn_Click(object sender, EventArgs e) {
            DataGridViewRow row = transactionsGrd.SelectedRows[0];
            var rowId = row.Cells["Id"].Value;
            if (transactionsGrd.SelectedRows.Count == 1 && rowId is int) {
                DialogResult result = MessageBox.Show("Selected Transaction will be deleted!", "Delete Item", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK) {
                    var response = await Program.httpClient.DeleteAsync($"api/transaction/{rowId}");
                    if (response.StatusCode == HttpStatusCode.OK) {
                        transactionsGrd.Rows.Remove(row);
                    }
                    else {
                        MessageBox.Show("Something went wrong! Delete failed.", "Alert");
                    }
                }
            }
        }
    }
}