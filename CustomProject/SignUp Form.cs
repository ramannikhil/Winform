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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        protected bool flag = false;
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var userName = txtUserName.Text;
            var password = txtPassword.Text;

            var instance = SingleTonPattern.getInstance();
            flag = instance.AddMembers(userName, password);

            if (flag)
            {
                this.Hide();
                ApplicationForm app_form = new ApplicationForm();
                app_form.Show();
            }
            else
            {
                MessageBox.Show("User already exist");
            }
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form1 = new MainForm();
            form1.Show();
        }
    }
}
