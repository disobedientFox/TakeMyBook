using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TakeMyBook
{
    //public delegate void changeScore(int score);


    public partial class GiveControl : UserControl
    {

        Label scoreLabel;
        BooksContext context = new BooksContext();
        public List<Department> departments { get; set; }

        public GiveControl(Label label)
        {
            InitializeComponent();
            scoreLabel = label;
        }

        private void giveButton_Click(object sender, EventArgs e)
        {
            try
            {
                departments = context.Departments.ToList();
            }
            catch { }

            if (titleTextBox.Text.Equals(null) || yearTextBox.Text.Equals(null) ||
                pagesCountNumericUpDown.Value < 5 || authorLabel.Text.Equals(null) ||
                pubHouseTextBox.Text.Equals(null))
            {
                MessageBox.Show("It seems to me that little information is indicated. \nI ask you to correct this, sir", "Something went wrong :c");
            }
            else
            {
                if (ReaderInfo.departmentReader == 2000)
                    MessageBox.Show("You need enter the department in the settings tab. Just do it, sir", "Something went wrong :c");
                else
                {
                    Book newBook = new Book
                    {
                        title = titleTextBox.Text,
                        author = authorTextBox.Text,
                        publishingHouse = pubHouseTextBox.Text,
                        publishYear = Convert.ToInt32(yearTextBox.Text),
                        pagesCount = (int)pagesCountNumericUpDown.Value,
                        inStock = true
                    };

                    context.Books.Add(newBook);

                    Trade trade = new Trade
                    {
                        date = DateTime.Today,
                        book = newBook,
                        reader = context.Readers.Where(r => r.nickname.Equals(ReaderInfo.nicknameReader)).Single(),
                        department = context.Departments.Where(d => d.id.Equals(ReaderInfo.departmentReader)).Single(),
                        IsGiven = true
                    };

                    context.Trades.Add(trade);

                    var reader = context.Readers.Single(r => r.nickname == ReaderInfo.nicknameReader);
                    reader.receivedPoints += (int)pagesCountNumericUpDown.Value;

                    ReaderInfo.score = reader.receivedPoints - reader.spentPoints;
                    scoreLabel.Text = ReaderInfo.score.ToString();

                    MessageBox.Show("Thank you, sir, the points are already in your account!", "Congrats!");

                    context.SaveChanges();
                }
            }
        }
    }
}
