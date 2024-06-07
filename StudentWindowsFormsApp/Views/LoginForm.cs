using StudentWindowsFormsApp.Controllers;
using StudentWindowsFormsApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWindowsFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            LoginController loginController = new LoginController();

            if (loginController.Login(email, password))
            {
                this.Hide();
                UserForm userForm = new UserForm();
                userForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }
    }
}
