using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TakeMyBook.Forms
{
    /// <summary>
    /// Class for register form
    /// </summary>
    public partial class RegisterForm : Form
    {
        private bool mouseIsDown = false;
        private Point firstPoint;

        BooksContext context = new BooksContext();

        public RegisterForm()
        {
            InitializeComponent();
        }

        // Register button logic
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (context.Readers.ToList().Where(r => r.nickname == nicknameTextBox.Text).Count() == 0) // Сheck nick's uniqueness
            {
                if (passwordTextBox.Text.Equals(confirmPasswordTextBox.Text)) // Check the password 
                {
                    // Creating a new user
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

                    // Open Main Form
                    MessageBox.Show("User was successfully created", "Congrats");
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    Hide();
                }
                else // If passwords dont match
                {
                    MessageBox.Show("Passwords don't match", "Pay attention");
                    passwordTextBox.Text = "";
                    confirmPasswordTextBox.Text = "";
                }
            }else // If user already exists
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


        // Back to login form
        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                // Get the difference between the two points
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }
    }
}
