using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using WinForms;

namespace FuelStation.WinForms.Forms {
    public partial class ItemEditForm : Form {
        int Id { get; set; }
        ItemDto item { get; set; }
        public ItemEditForm(int id) {
            InitializeComponent();
            Id = id;
            SetItemProps(Id);
        }

        public async void SetItemProps(int id) {
            item = await Program.httpClient.GetFromJsonAsync<ItemDto>($"api/item/{id}");
            itemCodeTextBox.Text = item.Code;
            itemDescriptionTextBox.Text = item.Description;
            itemTypeComboBox.Text = item.Type.ToString();
            priceUpDown.Text = item.Price.ToString();
            costUpDown.Text = item.Cost.ToString();
        }

        private void ItemEditForm_Load(object sender, EventArgs e) {
            editLabel.Text += Id;
        }

        private async void okButton_Click(object sender, EventArgs e) {
            bool enumCheck = Enum.TryParse(itemTypeComboBox.Text, out ItemType itemType);
            bool priceCheck = decimal.TryParse(priceUpDown.Text, out decimal price);
            bool costCheck = decimal.TryParse(costUpDown.Text, out decimal cost);
            ItemDto item = new() {
                Id = this.Id,
                Code = itemCodeTextBox.Text,
                Description = itemDescriptionTextBox.Text,
                Type = itemType,
                Price = price,
                Cost = cost
            };

            List<string> errorList = new();
            if (item.Code == String.Empty) {
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
                response = await Program.httpClient.PutAsJsonAsync("api/item", item);

                this.DialogResult = DialogResult.OK;
                Close();
            }
            else {
                string msg = string.Join("\n", errorList.ToArray());
                MessageBox.Show(msg, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ItemEditForm_Load_1(object sender, EventArgs e) {

        }
    }
}
