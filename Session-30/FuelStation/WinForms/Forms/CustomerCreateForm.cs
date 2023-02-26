using FuelStation.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using WinForms;

namespace FuelStation.WinForms.Forms {
    public partial class CustomerCreateForm : Form {
        public CustomerCreateForm() {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void okButton_ClickAsync(object sender, EventArgs e) {
            CustomerDto customer = new() {
                Name = customerNameTextBox.Text,
                Surname = customerSurnameTextBox.Text,
                CardNumber = customerCardNumberTextBox.Text
            };

            HttpResponseMessage? response = null;
            response = await Program.httpClient.PostAsJsonAsync("api/customer", customer);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void CustomerCreateForm_Load(object sender, EventArgs e) {

        }
    }

}
