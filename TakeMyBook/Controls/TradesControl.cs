using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TakeMyBook
{
    public partial class TradesControl : UserControl
    {
        public List<Trade> trades { get; set; }
        BooksContext context = new BooksContext();
        public TradesControl()
        {
            InitializeComponent();
            try
            {
                trades = context.Trades.Where(t => t.reader.nickname == ReaderInfo.nicknameReader).ToList();
                tradeBindingSource.DataSource = trades;
                int tmp = 0;
                /*tradesDataGridView.Columns[0].HeaderText = "Trade id";
                tradesDataGridView.Columns[1].HeaderText = "Book";
                tradesDataGridView.Columns[2].Visible = false;
                tradesDataGridView.Columns[3].HeaderText = "Department";
                tradesDataGridView.Columns[4].HeaderText = "Date";
                tradesDataGridView.Columns[5].HeaderText = "is given";
                */
                foreach (DataGridViewRow i in tradesDataGridView.Rows)
                {
                    i.Cells[1].Value = trades[tmp].book.title;
                    i.Cells[3].Value = trades[tmp].department.address;
                    tmp++;
                }

            }
            catch { }
        }
    }
}
