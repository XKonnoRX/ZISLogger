using BotTemplait;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZISLogger
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void AuthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MainForm.user == null)
                Application.Exit();
        }
        private void loginBox_Enter(object sender, EventArgs e)
        {
            if (loginBox.Text == "Login")
                loginBox.Text = "";
        }

        private void loginBox_Leave(object sender, EventArgs e)
        {
            if (loginBox.Text == "")
                loginBox.Text = "Login";
        }

        private void passBox_Enter(object sender, EventArgs e)
        {
            if (passBox.Text == "Password")
            {
                passBox.PasswordChar = '*';
                passBox.Text = "";
            }
        }

        private void passBox_Leave(object sender, EventArgs e)
        {
            if (passBox.Text == "")
            {
                passBox.PasswordChar = char.MinValue;
                passBox.Text = "Password";
            }
        }

        private void Validation(string password)
        {
            if (password.Length < 6)
            {
                MessageBox.Show("Внимание! Ваш пароль не соответсвует политикам безопасности. \nСмените его в ближайшее время!");
                DataBase.Log($"Warn: User \"{loginBox.Text}\" have weak password.", 2);
            }
        }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            var reader = DataBase.Read($"SELECT * FROM zis_logger.users where login = '{loginBox.Text}' and password = SHA2('{passBox.Text}',256);");
            if (reader != null)
            {
                MainForm.user = new User(reader);
                DataBase.Log($"Info: User \"{loginBox.Text}\" logged in.", 1);
                Validation(passBox.Text);
                this.Close();
            }
            else
            {
                incorrectLabel.Visible = true;
                DataBase.Log("Info: Incorrect user data.", 1);
            }
        }

    }
}
