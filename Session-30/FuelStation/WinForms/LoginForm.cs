namespace WinForms {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e) {

        }


        private void ManagerLoginBtn_Click(object sender, EventArgs e) {
            ManagerForm managerForm = new();
            this.Hide();
            managerForm.ShowDialog();
            this.Show();
        }

        private void CashierLoginBtn_Click(object sender, EventArgs e) {
            CashierForm cashierForm = new();
            this.Hide();
            cashierForm.ShowDialog();
            this.Show();
        }

        private void StaffLoginBtn_Click(object sender, EventArgs e) {
            StaffForm staffForm = new();
            this.Hide();
            staffForm.ShowDialog();
            this.Show();
        }
    }
}