using System.Data.Entity;

namespace TakeMyBook
{
    /// <summary>
    /// 
    /// </summary>
    public class BooksContext : DbContext
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public BooksContext() : base("DefaultConnection")
        {

        }

        #endregion

        public DbSet<Trade> Trades { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}