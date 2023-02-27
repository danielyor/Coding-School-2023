using FuelStation.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.RegularExpressions;
using WinForms;

namespace FuelStation.WinForms.Forms {
    public partial class CustomerEditForm : Form {
        int Id { get; set; }
        CustomerDto customer { get; set; }
        public CustomerEditForm(int id) {
            InitializeComponent();
            Id = id;
            SetCustomerProps(Id);
        }

        public async void SetCustomerProps(int id) {
            customer = await Program.httpClient.GetFromJsonAsync<CustomerDto>($"api/customer/{id}");
            customerNameTextBox.Text = customer.Name;
            customerSurnameTextBox.Text = customer.Surname;
            customerCardNumberTextBox.Text = customer.CardNumber;
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void okButton_ClickAsync(object sender, EventArgs e) {
            customer = new() {
                Id = this.Id,
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
                response = await Program.httpClient.PutAsJsonAsync("api/customer", customer);

                this.DialogResult = DialogResult.OK;
                Close();
            }
            else {
                string msg = string.Join("\n", errorList.ToArray());
                MessageBox.Show(msg, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerEditForm_Load(object sender, EventArgs e) {
            editLabel.Text += Id;
        }

    }
}
