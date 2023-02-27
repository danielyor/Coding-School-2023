using FuelStation.Model.Enums;
using FuelStation.Shared;
using System.Net.Http.Json;
using WinForms;

namespace FuelStation.WinForms.Forms {
    public partial class TransactionEditForm : Form {
        int Id { get; set; }
        TransactionDto transaction { get; set; }
        bool foundCustomer = false;

        public TransactionEditForm(int id) {
            InitializeComponent();
            Id = id;
            SetTransactionProp(Id);
        }

        private void TransactionEditForm_Load(object sender, EventArgs e) {
            editLabel.Text += Id;
        }

        private async void SetTransactionProp(int id) {
            transaction = await Program.httpClient.GetFromJsonAsync<TransactionDto>($"api/transaction/{id}");
            empIdUpDown.Text = transaction.EmployeeId.ToString();
            var cus = await Program.httpClient.GetFromJsonAsync<CustomerDto>($"api/customer/{transaction.CustomerId}");
            cusCardNumTextBox.Text = cus.CardNumber.ToString();
            payMethodComboBox.Text = transaction.PayMethod.ToString();
            totalValueUpDown.Text = transaction.TotalValue.ToString();

        }

        private async void okButton_Click(object sender, EventArgs e) {
            bool idCheck = int.TryParse(empIdUpDown.Text, out int id);
            bool payCheck = Enum.TryParse(payMethodComboBox.Text, out PaymentMethod payMethod);

            transaction.EmployeeId = id;
            transaction.PayMethod = payMethod;
            // calc totalvalue from lines

            List<string> errorList = new();

            List<EmployeeDto> empList = await Program.httpClient.GetFromJsonAsync<List<EmployeeDto>>("api/employee");
            EmployeeDto found = empList.Find(i => i.Id == id);

            if (found == null) {
                errorList.Add("- No Employee found with the specified ID.");
            }
            if (foundCustomer == false) {
                errorList.Add("- No valid Customer selected.");
            }
            if (payCheck == false) {
                errorList.Add("- The Payment Method field is required.");
            }

            if (errorList.Count == 0) {
                HttpResponseMessage? response = await Program.httpClient.PutAsJsonAsync("api/transaction", transaction);

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

        private async void findCusBtn_Click(object sender, EventArgs e) {
            List<CustomerDto> customers = await Program.httpClient.GetFromJsonAsync<List<CustomerDto>>("api/customer");
            var found = customers.Find(c => c.CardNumber == cusCardNumTextBox.Text);
            if (found == null) {
                foundCustomer = false;
                DialogResult result = MessageBox.Show("No Customer found! Create?", "Alert", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    CustomerCreateForm form = new();
                    form.ShowDialog();
                }
            }
            else {
                MessageBox.Show("Added Customer with ID: " + found.Id, "Customer Added");
                cusCardNumTextBox.Text = found.CardNumber;
                cusCardNumTextBox.ReadOnly = true;
                transaction.CustomerId = found.Id;
                foundCustomer = true;
            }
        }
    }
}
