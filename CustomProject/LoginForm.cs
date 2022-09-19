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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        protected bool flag = false;
        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
      
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            var instance = SingleTonPattern.getInstance();
            flag = instance.CheckMembers(userName, password);

            if (flag)
            {
                this.Hide();
                ApplicationForm appInfoForm = new ApplicationForm();
                appInfoForm.Show();
            }
            else
            {
                MessageBox.Show("Login Credentials are incorrect");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm s1 = new SignUpForm();
            s1.Show();
        }
    }
}
