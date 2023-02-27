using FuelStation.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.RegularExpressions;
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

            List<string> errorList = new();
            if (customer.Name == String.Empty) {
                errorList.Add("- The Name field is required.");
            }
            if (customer.Surname == String.Empty) {
                errorList.Add("- The Surname field is required.");
            }
            if (!Regex.Match(customer.CardNumber, "^A.\\d{0,}$").Success) {
                errorList.Add("- The Card Number field must begin with A, followed by any number of digits. Ex. 'A12345'.");
            }

            if (errorList.Count == 0) {
                HttpResponseMessage? response = null;
                response = await Program.httpClient.PostAsJsonAsync("api/customer", customer);

                this.DialogResult = DialogResult.OK;
                Close();
            }
            else {
                string msg = string.Join("\n", errorList.ToArray());
                MessageBox.Show(msg, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerCreateForm_Load(object sender, EventArgs e) {

        }
    }

}
