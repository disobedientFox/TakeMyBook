using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TakeMyBook.Services;

namespace TakeMyBook
{
    /// <summary>
    /// Class for give control
    /// </summary>
    public partial class GiveControl : UserControl
    {
        Button scoreButton;

        public TradesService Trades { get; set; } = new TradesService();

        public GiveControl(Button button)
        {
            InitializeComponent();
            scoreButton = button;
        }

        // Give button logic
        private void giveButton_Click(object sender, EventArgs e)
        {
            var departments = Trades.GetDepartments();

            if (titleTextBox.Text.Equals(null) || yearTextBox.Text.Equals(null) ||
                pagesCountNumericUpDown.Value < 5 || authorLabel.Text.Equals(null) ||
                pubHouseTextBox.Text.Equals(null)) // Check the data
            {
                MessageBox.Show("It seems to me that little information is indicated. \nI ask you to correct this, sir", "Something went wrong :c");
            }
            else
            {
                if (ReaderInfo.departmentReader == 2000)
                    MessageBox.Show("You need enter the department in the settings tab. Just do it, sir", "Something went wrong :c");
                else
                {
                    var newBook = Trades.AddBook(new Book
                    {
                        title = titleTextBox.Text,
                        author = authorTextBox.Text,
                        publishingHouse = pubHouseTextBox.Text,
                        publishYear = Convert.ToInt32(yearTextBox.Text),
                        pagesCount = (int)pagesCountNumericUpDown.Value,
                        inStock = true
                    });

                    var reader = Trades.GetReader(ReaderInfo.nicknameReader);

                    Trades.AddTrade(new Trade
                    {
                        date = DateTime.Today,
                        book = newBook,
                        reader = reader,
                        department = departments.FirstOrDefault(d => d.id.Equals(ReaderInfo.departmentReader)),
                        IsGiven = true
                    });

                    reader.receivedPoints += (int)pagesCountNumericUpDown.Value;

                    ReaderInfo.score = reader.receivedPoints - reader.spentPoints;
                    scoreButton.Text = ReaderInfo.score.ToString();

                    MessageBox.Show("Thank you, sir, the points are already in your account!", "Congrats!");
                }
            }
        }
    }
}
