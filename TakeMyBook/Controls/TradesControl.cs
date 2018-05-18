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

                List<TradeView> tradesView = new List<TradeView>();

                foreach (Trade trade in trades)
                {
                    context.Entry(trade).Reference(x => x.book).Load();
                    context.Entry(trade).Reference(x => x.department).Load();

                    tradesView.Add(new TradeView
                    {
                        id = trade.id,
                        book = trade.book.title,
                        date = trade.date,
                        department = trade.department.address,
                        IsGiven = trade.IsGiven
                    });
                }

                tradeViewBindingSource.DataSource = tradesView;
            }
            catch { }
        }
    }
}
