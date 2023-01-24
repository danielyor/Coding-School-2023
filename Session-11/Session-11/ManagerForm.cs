using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11 {
    public partial class ManagerForm : Form {
        public ManagerForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            DummyCarMech data = new();
            MessageBox.Show(data.managers[0].Name, "Wowowww", MessageBoxButtons.OK);
        }
    }
}
