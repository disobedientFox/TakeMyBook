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
    public partial class LoginForm : Form
    {
        BooksContext context = new BooksContext();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                var reader = context.Readers.ToList().Single(r => r.nickname == nicknameTextBox.Text);
                if (PasswordManager.VerifyHashedPassword(reader.password, passwordTtextBox.Text))
                {
                    ReaderInfo.nicknameReader = reader.nickname;
                    ReaderInfo.departmentReader = reader.department;
                    ReaderInfo.score = reader.receivedPoints - reader.spentPoints;
                    ReaderInfo.idReader = reader.id;
                    this.Close();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    Hide();
                }
            }
            catch
            {
                MessageBox.Show("User with login " + nicknameTextBox.Text + " doesn't exist", "Something went wrong :c");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            Hide();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
