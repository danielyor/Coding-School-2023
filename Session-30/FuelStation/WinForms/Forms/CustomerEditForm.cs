using FuelStation.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using WinForms;

namespace FuelStation.WinForms.Forms {
    public partial class CustomerEditForm : Form {
        int Id { get; set; }
        public CustomerEditForm(int id) {
            InitializeComponent();
            Id = id;
        }
        private void cancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void okButton_ClickAsync(object sender, EventArgs e) {
            CustomerDto customer = new() {
                Id = this.Id,
                Name = customerNameTextBox.Text,
                Surname = customerSurnameTextBox.Text,
                CardNumber = customerCardNumberTextBox.Text
            };

            HttpResponseMessage? response = null;
            response = await Program.httpClient.PutAsJsonAsync("api/customer", customer);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void CustomerEditForm_Load(object sender, EventArgs e) {
            editLabel.Text += Id;
        }

    }
}
