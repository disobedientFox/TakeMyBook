using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TakeMyBook;
using TakeMyBook.Services;

namespace TakeMyBookTest
{
    [TestClass]
    public class TradesTest
    {
        [TestMethod]
        public void GettingDepartmentsTest()
        {
            TradesService Trades = new TradesService();

            var result = Trades.GetDepartments();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AddABook()
        {
            TradesService Trades = new TradesService();

            var result = Trades.AddBook(new Book
            {
                author = "Test name",
                inStock = true,
                pagesCount = 0,
                publishingHouse = "Test house",
                publishYear = 0,
                title = "Test title"
            });

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void FailGettingUser()
        {
            TradesService Trades = new TradesService();

            var result = Trades.GetReader(null);

            Assert.IsNull(result);
        }
    }
}
