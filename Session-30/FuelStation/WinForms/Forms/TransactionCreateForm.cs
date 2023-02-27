using FuelStation.Model.Enums;
using FuelStation.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using WinForms;

namespace FuelStation.WinForms.Forms {
    public partial class TransactionCreateForm : Form {
        TransactionDto transaction { get; set; } = new();
        public TransactionCreateForm() {
            InitializeComponent();
        }

        private void TransactionCreateForm_Load(object sender, EventArgs e) {
            totalValueTextBox.Text = transaction.TotalValue.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void okButton_Click(object sender, EventArgs e) {
            transaction.EmployeeId = int.Parse(empIdTextBox.Text);
            Enum.TryParse(payMethodComboBox.Text, out PaymentMethod payMethod);
            transaction.PayMethod = payMethod;

            HttpResponseMessage? response = await Program.httpClient.PostAsJsonAsync("api/transaction", transaction);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private async void findCusBtn_Click(object sender, EventArgs e) {
            List<CustomerDto> customers = await Program.httpClient.GetFromJsonAsync<List<CustomerDto>>("api/customer");
            var found = customers.Find(c => c.CardNumber == cusCardNumTextBox.Text );
            if (found == null) {
                DialogResult result = MessageBox.Show("No Customer found! Create?", "Alert", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    CustomerCreateForm form = new();
                    form.ShowDialog();
                }
            }
            else {
                MessageBox.Show("Added Customer with ID:" + found.Id, "Customer Added");
                cusCardNumTextBox.Text = found.CardNumber;
                cusCardNumTextBox.ReadOnly = true;
                transaction.CustomerId = found.Id;
            }
        }
    }
}

