using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TakeMyBook.Forms
{
    /// <summary>
    /// Class for login form
    /// </summary>
    public partial class LoginForm : Form
    {
        private bool mouseIsDown = false;
        private Point firstPoint;

        BooksContext context = new BooksContext();

        public LoginForm()
        {
            InitializeComponent();
            MainForm mainForm = new MainForm();
        }

        // Login button logic
        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                var reader = context.Readers.ToList().Single(r => r.nickname == nicknameTextBox.Text); // Find current user
                context.Entry(reader).Reference(r => r.department).Load();
                if (PasswordManager.VerifyHashedPassword(reader.password, passwordTtextBox.Text)) // Check the password
                {
                    ReaderInfo.nicknameReader = reader.nickname;
                    if(reader.department != null)
                        ReaderInfo.departmentReader = reader.department.id;
                    ReaderInfo.score = reader.receivedPoints - reader.spentPoints;
                    ReaderInfo.idReader = reader.id;


                    // Go to main form
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect password", "Something went wrong :c"); 
                }
            }
            catch
            {
                MessageBox.Show("User with login " + nicknameTextBox.Text + " doesn't exist", "Something went wrong :c");
            }
        }

        // Go to Register form
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
