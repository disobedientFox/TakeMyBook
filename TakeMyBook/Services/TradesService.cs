using System.Collections.Generic;
using System.Linq;

namespace TakeMyBook.Services
{
    public class TradesService
    {
        private BooksContext context { get; set; }

        public TradesService()
        {
            context = new BooksContext();
        }

        public IEnumerable<TradeView> GetTrades()
        {
            var trades = context.Trades.Where(t => t.reader.nickname == ReaderInfo.nicknameReader).ToList();

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

            return tradesView;
        }

        public IEnumerable<Department> GetDepartments()
        {
            return context.Departments.ToList();
        }

        public Reader GetReader(string nicknameReader)
        {
            return context.Readers
                .FirstOrDefault(r => r.nickname.Equals(nicknameReader));
        }

        public Book AddBook(Book entity)
        {
            var result = context.Books.Add(entity);
            context.SaveChanges();

            return result;
        }

        public Trade AddTrade(Trade entity)
        {
            var result = context.Trades.Add(entity);
            context.SaveChanges();

            return result;
        }
    }
}
