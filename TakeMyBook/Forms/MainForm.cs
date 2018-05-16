using System;
using System.Windows.Forms;

namespace TakeMyBook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
        private void takeLabel_Click(object sender, EventArgs e)
        {
            if (menuPanel.Visible == false)
                menuPanel.Visible = true;
            menuPanel.Width = takeLabel.Width;
            menuPanel.Left = takeLabel.Left;
            settingsControl.Visible = false;
            giveControl.Visible = false;
            tradesControl.Visible = false;
            departmentsControl.Visible = false;
            takeControl.Visible = true;
        }

        private void giveLabel_Click(object sender, EventArgs e)
        {
            if (menuPanel.Visible == false)
                menuPanel.Visible = true;
            menuPanel.Width = giveLabel.Width;
            menuPanel.Left = giveLabel.Left;
            settingsControl.Visible = false;
            tradesControl.Visible = false;
            departmentsControl.Visible = false;
            takeControl.Visible = false;
            giveControl.Visible = true;
        }

        private void tradesLabel_Click(object sender, EventArgs e)
        {
            if (menuPanel.Visible == false)
                menuPanel.Visible = true;
            menuPanel.Width = tradesLabel.Width;
            menuPanel.Left = tradesLabel.Left;
            settingsControl.Visible = false;
            departmentsControl.Visible = false;
            takeControl.Visible = false;
            giveControl.Visible = false;
            tradesControl.Visible = true;
        }

        private void departmentsLabel_Click(object sender, EventArgs e)
        {
            if (menuPanel.Visible == false)
                menuPanel.Visible = true;
            menuPanel.Width = departmentsLabel.Width;
            menuPanel.Left = departmentsLabel.Left;
            settingsControl.Visible = false;
            tradesControl.Visible = false;
            takeControl.Visible = false;
            giveControl.Visible = false;
            departmentsControl.Visible = true;
        }

        private void SettingsLabel_Click(object sender, EventArgs e)
        {
            if (menuPanel.Visible == false)
                menuPanel.Visible = true;
            menuPanel.Width = SettingsLabel.Width;
            menuPanel.Left = SettingsLabel.Left;
            tradesControl.Visible = false;
            departmentsControl.Visible = false;
            takeControl.Visible = false;
            giveControl.Visible = false;
            settingsControl.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*if (booksDataGridView.Rows.Count == 0)
            {
                using (var ctx = new BooksContext())
                {
                    var books = ctx.Books.ToList();
                    booksDataGridView.DataSource = books;
                }
            }
        }*/
    }
}
