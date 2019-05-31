using System.Collections.Generic;
using System.Linq;

namespace TakeMyBook.Services
{
    public class TradesService
    {
        private BooksContext context { get; set; }

        public TradesService()
        {
            // context do bazy danncyh EF
            context = new BooksContext();
        }

        // pobieranie danych o moich oddanych książkach
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

        // pobieranie listy dostępnych punktów do oddania książek
        public IEnumerable<Department> GetDepartments()
        {
            return context.Departments.ToList();
        }

        // pobieranie danych użytkownika
        public Reader GetReader(string nicknameReader)
        {
            return context.Readers
                .FirstOrDefault(r => r.nickname.Equals(nicknameReader));
        }

        // dodawanie książki do bazy
        public Book AddBook(Book entity)
        {
            var result = context.Books.Add(entity);
            context.SaveChanges();

            return result;
        }

        // dodawanie wpisu o oddanej książce do bazy
        public Trade AddTrade(Trade entity)
        {
            var result = context.Trades.Add(entity);
            context.SaveChanges();

            return result;
        }
    }
}
