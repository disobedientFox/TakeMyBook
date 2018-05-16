using System;
using System.Linq;
using System.Windows.Forms;
using TakeMyBook;

namespace TakeMyBook
{
    public partial class TakeControl : UserControl
    {
        //public List<Book> Books { get; set; }

        //public List<Book> books { get { return Books; } set { Books = value;} }

        public TakeControl()
        {
            InitializeComponent();

            using (var ctx = new BooksContext())
            {
                if (!ctx.Database.Exists())
                {
                    var books = ctx.Books.ToList();
                    bookBindingSource.DataSource = books;
                }
            }

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TakeControl_Load(object sender, EventArgs e)
        {
            /*if(booksDataGridView.Rows.Count == 0)
            {
                using (var ctx = new BooksContext())
                {
                    var books = ctx.Books.ToList();
                    booksDataGridView.DataSource = books;
                }
            }*/
        }

    }
}
