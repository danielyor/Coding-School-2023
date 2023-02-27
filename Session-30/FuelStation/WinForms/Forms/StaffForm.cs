using FuelStation.Shared;
using FuelStation.WinForms.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;

namespace WinForms {
    public partial class StaffForm : Form {
        private List<ItemDto> ItemList = new();

        public async void LoadItems() {
            ItemList = await Program.httpClient.GetFromJsonAsync<List<ItemDto>>("api/item");
            itemsBS.DataSource = ItemList;
            itemsGrd.DataSource = itemsBS;
        }

        public StaffForm() {
            InitializeComponent();
        }

        private async void StaffForm_Load(object sender, EventArgs e) {
            LoadItems();
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
                DialogResult result = MessageBox.Show("Selected Item will be deleted!", "Delete Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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


    }
}