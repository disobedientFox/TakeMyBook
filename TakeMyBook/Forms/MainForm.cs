using System;
using System.Drawing;
using System.Windows.Forms;

namespace TakeMyBook
{

    public partial class MainForm : Form
    {
        private bool mouseIsDown = false;
        private Point firstPoint;

        private DepartmentsControl departmentsControl = new DepartmentsControl();
        private TradesControl tradesControl = new TradesControl();
        private GiveControl giveControl;
        private TakeControl takeControl;
        private SettingsControl settingsControl = new SettingsControl();

        public MainForm()
        {
            InitializeComponent();
            scoreBtn.Text = ReaderInfo.score.ToString();

            giveControl = new GiveControl(scoreBtn);
            takeControl = new TakeControl(scoreBtn);


            departmentsControl.Size = new System.Drawing.Size(800, 360);
            departmentsControl.Location = new System.Drawing.Point(0, 91);
            Controls.Add(departmentsControl);

            tradesControl.Size = new System.Drawing.Size(800, 360);
            tradesControl.Location = new System.Drawing.Point(0, 91);
            Controls.Add(tradesControl);

            giveControl.Size = new System.Drawing.Size(800, 360);
            giveControl.Location = new System.Drawing.Point(0, 91);
            Controls.Add(giveControl);

            takeControl.Size = new System.Drawing.Size(800, 360);
            takeControl.Location = new System.Drawing.Point(0, 91);
            Controls.Add(takeControl);

            settingsControl.Size = new System.Drawing.Size(800, 360);
            settingsControl.Location = new System.Drawing.Point(0, 91);
            Controls.Add(settingsControl);

            settingsControl.Visible = false;
            giveControl.Visible = false;
            tradesControl.Visible = false;
            departmentsControl.Visible = false;
            takeControl.Visible = false;
        }
        
        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        
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
            takeControl.updateBooks();
            pictureBox2.SendToBack();
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
            pictureBox2.SendToBack();
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
            tradesControl.updateTrades();
            pictureBox2.SendToBack();
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
            pictureBox2.SendToBack();
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
            pictureBox2.SendToBack();
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

        public void ChangeScore()
        {
            scoreBtn.Text = ReaderInfo.score.ToString();
        }
    }
}
