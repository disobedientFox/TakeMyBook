using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TakeMyBook;

namespace MenuControls
{
    public partial class TakeControl: UserControl
    {
        //public List<Book> books { get; set; }

        public TakeControl()
        {
            InitializeComponent();
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
