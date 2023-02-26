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
    }
}