namespace WinForms {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e) {

        }

        private void ManagerLoginBtn_Click(object sender, EventArgs e) {
            ManagerForm managerForm = new();
            managerForm.ShowDialog();
        }

        private void CashierLoginBtn_Click(object sender, EventArgs e) {
            CashierForm cashierForm = new();
            cashierForm.ShowDialog();
        }

        private void StaffLoginBtn_Click(object sender, EventArgs e) {
            StaffForm staffForm = new();
            staffForm.ShowDialog();
        }
    }
}