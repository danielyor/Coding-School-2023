using FuelStation.Model.Enums;
using FuelStation.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using WinForms;

namespace FuelStation.WinForms.Forms {
    public partial class ItemCreateForm : Form {
        public ItemCreateForm() {
            InitializeComponent();
        }

        private void ItemCreateForm_Load(object sender, EventArgs e) {

        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void okButton_Click(object sender, EventArgs e) {
            Enum.TryParse(itemTypeComboBox.Text, out ItemType itemType);
            ItemDto item = new() {
                Code = itemCodeTextBox.Text,
                Description = itemDescriptionTextBox.Text,
                Type = itemType,
                Price = decimal.Parse(itemPriceTextBox.Text),
                Cost = decimal.Parse(itemCostTextBox.Text)
            };

            HttpResponseMessage? response = await Program.httpClient.PostAsJsonAsync("api/item", item);

            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
