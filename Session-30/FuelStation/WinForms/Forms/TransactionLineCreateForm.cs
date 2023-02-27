using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms;

namespace FuelStation.WinForms.Forms {
    public partial class TransactionLineCreateForm : Form {
        TransactionDto transaction;
        TransactionLineDto line { get; set; } = new();
        public TransactionLineCreateForm(TransactionDto transaction) {
            InitializeComponent();
            this.transaction = transaction;

            UpdateGrid();
        }

        private void UpdateGrid() {
            linesBS.DataSource = transaction.TransactionLines;
            linesGrd.DataSource = linesBS;
        }

        private void TransactionLineCreateForm_Load(object sender, EventArgs e) {
            editLabel.Text += transaction.Id.ToString();
        }

        private async void removeLineBtn_Click(object sender, EventArgs e) {
            DataGridViewRow row = linesGrd.SelectedRows[0];
            var rowId = row.Cells["Id"].Value;
            if (linesGrd.SelectedRows.Count == 1 && rowId is int) {
                DialogResult result = MessageBox.Show("Selected Line will be deleted!", "Delete Line", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK) {
                    var response = await Program.httpClient.DeleteAsync($"api/transactionline/{rowId}");
                    if (response.StatusCode == HttpStatusCode.OK) {
                        linesGrd.Rows.Remove(row);
                    }
                    else {
                        MessageBox.Show("Something went wrong! Delete failed.", "Alert");
                    }
                }
            }
        }

        private async void addLineBtn_Click(object sender, EventArgs e) {
            int itemId = (int)itemIdUpDown.Value;
            int quantity = (int)quantityUpDown.Value;
            TransactionLineDto line = new(transaction.Id, itemId, quantity);

            var item = await Program.httpClient.GetFromJsonAsync<ItemDto>($"api/item/{line.ItemId}");

            line.ItemPrice = item.Price;
            line.NetValue = line.Quantity * item.Price;
            if (item.Type == ItemType.Fuel && line.NetValue > 20) {
                line.DiscountPercent = 0.1M;
            }
            line.DiscountValue = line.NetValue * line.DiscountPercent;
            line.TotalValue = line.NetValue - line.DiscountValue;



            MessageBox.Show($"Id: {line.Id}\nTrans Id: {line.TransactionId}\nItem Id: {line.ItemId}\nQuantity: {line.Quantity}\nItem Price: {line.ItemPrice}\n{line.NetValue}\nDiscount %: {line.DiscountPercent}\nDiscount Value: {line.DiscountValue}\nTotal Value: {line.TotalValue}\n");

            HttpResponseMessage? response = null;
            response = await Program.httpClient.PostAsJsonAsync("api/transactionline", line);

            MessageBox.Show(response.StatusCode.ToString());

            UpdateGrid();
        }
    }
}
