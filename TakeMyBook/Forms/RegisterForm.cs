using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeMyBook.Forms
{
    public partial class RegisterForm : Form
    {
        BooksContext context = new BooksContext();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (context.Readers.ToList().Where(r => r.nickname == nicknameTextBox.Text).Count() == 0)
            {
                if (passwordTextBox.Text.Equals(confirmPasswordTextBox.Text))
                {
                    Reader reader = new Reader();
                    reader.name = nameTextBox.Text;
                    reader.nickname = nicknameTextBox.Text;
                    reader.password = PasswordManager.HashPassword(passwordTextBox.Text);
                    reader.spentPoints = 0;
                    reader.receivedPoints = 0;

                    using (var ctx = new BooksContext())
                    {
                        ctx.Readers.Add(reader);
                        ctx.SaveChanges();
                    }
                    MessageBox.Show("User was successfully created", "Congrats");
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Passwords don't match", "Pay attention");
                    passwordTextBox.Text = "";
                    confirmPasswordTextBox.Text = "";
                }
            }else
            {
                MessageBox.Show("User already exists", "Something went wrong :c");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }
    }
}
