using LibCarService;
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
    public partial class EngineerForm : Form {
        public EngineerForm() {
            InitializeComponent();
            SetControlProperties();
        }
        private void SetControlProperties()
        {
            DummyCarMech data = new();

           
            BindingList<Engineer> engineers = new BindingList<Engineer>(data.engineers);
            grdEngineers.DataSource = new BindingSource() { DataSource = engineers };
            BindingList<ServiceTask> serviceTasks = new BindingList<ServiceTask>(data.serviceTasks);
            grdServiceTasks.DataSource = new BindingSource() { DataSource = serviceTasks };
        }
            private void EngineerForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxServiceTaskTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
