﻿using FuelStation.Model.Enums;
using FuelStation.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using WinForms;

namespace FuelStation.WinForms.Forms {
    public partial class ItemEditForm : Form {
        int Id { get; set; }
        public ItemEditForm(int id) {
            InitializeComponent();
            Id = id;
        }

        private void ItemEditForm_Load(object sender, EventArgs e) {
            editLabel.Text += Id;
        }

        private async void okButton_Click(object sender, EventArgs e) {
            Enum.TryParse(itemTypeComboBox.Text, out ItemType itemType);
            ItemDto item = new() {
                Id = this.Id,
                Code = itemCodeTextBox.Text,
                Description = itemDescriptionTextBox.Text,
                Type = itemType,
                Price = decimal.Parse(itemPriceTextBox.Text),
                Cost = decimal.Parse(itemCostTextBox.Text)
            };

            HttpResponseMessage? response = null;
            response = await Program.httpClient.PutAsJsonAsync("api/item", item);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ItemEditForm_Load_1(object sender, EventArgs e) {

        }
    }
}
