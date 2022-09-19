using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomProject
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void btnBackToSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm s1 = new SignUpForm();
            s1.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void AppInfoForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (rdGrocery.Checked)
            {
                this.Hide();
                GroceryApp grocery = new GroceryApp();
                grocery.Show();
            }

            if (rdCarRental.Checked)
            {
                this.Hide();
                CarRental cs_form = new CarRental();
                cs_form.Show();
            }

            if (rdDoctorAppointment.Checked)
            {
                this.Hide();
                DoctorAppointment doc_form = new DoctorAppointment();
                doc_form.Show();
            }
        }

        private void rdCarRental_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
