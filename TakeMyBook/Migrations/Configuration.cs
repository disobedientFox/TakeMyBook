namespace TakeMyBook.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TakeMyBook.BooksContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TakeMyBook.BooksContext context)
        {
            /*
            context.Books.Add(
                new Book()
                {
                    title = "Denis <3",
                    author = "Alevtina",
                    pagesCount = 400,
                    publishingHouse = "WSIZ",
                    publishYear = 2018
                });

            context.Books.Add(
                new Book()
                {
                    title = "Alevtina <3",
                    author = "Denis",
                    pagesCount = 2003,
                    publishingHouse = "WSIZ",
                    publishYear = 2015
                });


            context.Departments.Add(
                new Department{
                    address = "Happyland 23/4",
                    country = "USA",
                    city = "Riverdale",
                    openingHours = "10:00 19:00"
            });

            context.Departments.Add(
                new Department
                {
                    address = "Kahd 23213",
                    country = "USA",
                    city = "Odsadl",
                    openingHours = "9:00 19:00"
                });

            context.Readers.Add(
                new Reader
                {
                    name = "Denis",
                    receivedPoints = 300,
                    spentPoints = 0
                });

            context.Readers.Add(
                new Reader
                {
                    name = "Alevtina",
                    receivedPoints = 600,
                    spentPoints = 300
                });

            context.SaveChanges();*/
        }
    }
}
