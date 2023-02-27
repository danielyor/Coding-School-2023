using FuelStation.Model.Enums;
using FuelStation.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms;

namespace FuelStation.WinForms.Forms {
    public partial class TransactionEditForm : Form {
        int Id { get; set; }
        TransactionDto transaction { get; set; }
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
            empIdTextBox.Text = transaction.EmployeeId.ToString();
            var cus = await Program.httpClient.GetFromJsonAsync<CustomerDto>($"api/customer/{transaction.CustomerId}");
            cusCardNumTextBox.Text = cus.CardNumber.ToString();
            payMethodComboBox.Text = transaction.PayMethod.ToString();
            totalValueTextBox.Text = transaction.TotalValue.ToString();

        }

        private async void okButton_Click(object sender, EventArgs e) {
            transaction.EmployeeId = int.Parse(empIdTextBox.Text);
            Enum.TryParse(payMethodComboBox.Text, out PaymentMethod payMethod);
            transaction.PayMethod = payMethod;

            HttpResponseMessage? response = await Program.httpClient.PutAsJsonAsync("api/transaction", transaction);

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void findCusBtn_Click(object sender, EventArgs e) {
            List<CustomerDto> customers = await Program.httpClient.GetFromJsonAsync<List<CustomerDto>>("api/customer");
            var found = customers.Find(c => c.CardNumber == cusCardNumTextBox.Text);
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
