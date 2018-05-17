using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeMyBook
{
    public partial class GiveControl : UserControl
    {
        BooksContext context = new BooksContext();
        public List<Department> departments { get; set; }

        public GiveControl()
        {
            InitializeComponent();
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
                if (ReaderInfo.departmentReader != null)
                    MessageBox.Show("You need enter the department in the settings tab. Just do it, sir", "Something went wrong :c");
                else
                {
                    // NEED TO CLEAN
                    ReaderInfo.departmentReader = departments.Single(d => d.id == 5);
                    //------------------------



                    Book newBook = new Book
                    {
                        title = titleTextBox.Text,
                        author = authorTextBox.Text,
                        publishingHouse = pubHouseTextBox.Text,
                        publishYear = Convert.ToInt32(yearTextBox.Text),
                        pagesCount = (int)pagesCountNumericUpDown.Value
                    };

                    context.Books.Add(newBook);

                    Trade trade = new Trade
                    {
                        date = DateTime.Today,
                        book = newBook,
                        reader = context.Readers.Where(r => r.nickname.Equals(ReaderInfo.nicknameReader)).Single(),
                        department = context.Departments.Where(d => d.id.Equals(ReaderInfo.departmentReader.id)).Single(),
                        IsGiven = true
                    };

                    context.Trades.Add(trade);
                    

                    context.SaveChanges();
                }
            }
        }
    }
}
