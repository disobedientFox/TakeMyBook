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
                //tradesDataGridView.DataSource = trades;
                int tmp = 0;
                foreach(DataGridViewRow i in tradesDataGridView.Rows)
                {
                    i.Cells[0].Value = trades[tmp].id;
                    i.Cells[1].Value = trades[tmp].date;
                    i.Cells[2].Value = trades[tmp].book.title;
                    i.Cells[3].Value = trades[tmp].department.address;
                    i.Cells[4].Value = trades[tmp].IsGiven;
                }
            }
            catch { }
        }
    }
}
