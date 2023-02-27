using FuelStation.Model;
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
            bool enumCheck = Enum.TryParse(itemTypeComboBox.Text, out ItemType itemType);
            bool priceCheck = decimal.TryParse(priceUpDown.Text, out decimal price);
            bool costCheck = decimal.TryParse(costUpDown.Text, out decimal cost);
            ItemDto item = new() {
                Code = itemCodeTextBox.Text,
                Description = itemDescriptionTextBox.Text,
                Type = itemType,
                Price = price,
                Cost = cost
            };

            List<string> errorList = new();
            if  (item.Code == String.Empty) {
                errorList.Add("- The Code field is required.");
            }
            if (item.Description == String.Empty) {
                errorList.Add("- The Description field is required.");
            }
            if (enumCheck == false) {
                errorList.Add("- The Item Type field is required.");
            }
            if (priceCheck == false) {
                errorList.Add("- The Price field has invalid input.");
            }
            if (costCheck == false) {
                errorList.Add("- The Cost field has invalid input.");
            }

            if (errorList.Count == 0) {
                HttpResponseMessage? response = null;
                response = await Program.httpClient.PostAsJsonAsync("api/item", item);

                this.DialogResult = DialogResult.OK;
                Close();
            }
            else {
                string msg = string.Join("\n", errorList.ToArray());
                MessageBox.Show(msg, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
