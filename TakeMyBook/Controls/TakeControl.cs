using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TakeMyBook
{
    public partial class TakeControl : UserControl
    {
        public List<Book> Books { get; set; }
        public List<Department> departments { get; set; }
        BooksContext context = new BooksContext();

        public TakeControl()
        {
            InitializeComponent();

            try
            {
                Books = context.Books.ToList();
                booksDataGridView.DataSource = Books;
                departments = context.Departments.ToList();
            }
            catch { }

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Books == null)
                Books = context.Books.ToList();

            if (searchTextBox.Text.Length != 0)
            {
                switch (columnComboBox.SelectedIndex)
                {
                    case 0:
                        booksDataGridView.DataSource =
                            Books.Where(b => b.title.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
                        break;
                    case 1:
                        booksDataGridView.DataSource =
                            Books.Where(b => b.author.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
                        break;
                    case 2:
                        booksDataGridView.DataSource =
                            Books.Where(b => b.publishingHouse.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
                        break;
                    case 3:
                        booksDataGridView.DataSource =
                            Books.Where(b => b.publishYear.Equals(Convert.ToInt32(searchTextBox.Text.ToLower()))).ToList();
                        break;
                    case 4:
                        booksDataGridView.DataSource =
                            Books.Where(b => b.pagesCount > Convert.ToInt32(searchTextBox.Text)).ToList();
                        break;
                    case 5:
                        booksDataGridView.DataSource =
                            Books.Where(b => b.pagesCount < Convert.ToInt32(searchTextBox.Text)).ToList();
                        break;
                }
            }
            else
            {
                booksDataGridView.DataSource = Books;
            }
        }

        private void takeButton_Click(object sender, EventArgs e)
        {
            if (booksDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please, select at least one book, sir", "Something went wrong :c");
            }
            else if (booksDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please, select only one book, sir", "Something went wrong :c");
            }
            else
            {
                if (ReaderInfo.departmentReader != null)
                    MessageBox.Show("You need enter the department in the settings tab. Just do it, sir", "Something went wrong :c");
                else
                {
                    // NEED TO CLEAN
                    ReaderInfo.departmentReader = departments.Where(d => d.id == 5).Single();
                    //------------------------

                    int idBook = Convert.ToInt32(booksDataGridView.SelectedRows[0].Cells[0].Value.ToString());

                    Trade trade = new Trade
                    {
                        date = DateTime.Today,
                        book = context.Books.Where(b => b.id.Equals(idBook)).Single(),
                        reader = context.Readers.Where(r => r.nickname.Equals(ReaderInfo.nicknameReader)).Single(),
                        department = context.Departments.Where(d => d.id.Equals(ReaderInfo.departmentReader.id)).Single(),
                        IsGiven = false
                    };

                    context.Trades.Add(trade);

                    var entity = context.Books.Single(b => b.id == idBook);
                    context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;

                    context.SaveChanges();

                    MessageBox.Show("Pick up your book within a week :)", "Congrats!");

                    Books = context.Books.ToList();
                    booksDataGridView.DataSource = Books;
                }
            }
        }

        private void columnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
        }
    }
}
