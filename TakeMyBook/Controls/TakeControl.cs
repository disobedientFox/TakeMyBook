﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TakeMyBook
{
    public partial class TakeControl : UserControl
    {
        Label scoreLabel;
        public List<Book> Books { get; set; }
        public List<Department> departments { get; set; }
        BooksContext context = new BooksContext();


        public TakeControl(Label label)
        {
            InitializeComponent();

            scoreLabel = label;

            try
            {
                Books = context.Books.Where(b => b.inStock == true).ToList();
                bookBindingSource.DataSource = Books;
                //bookBindingSource.DataSource = Books;
                departments = context.Departments.ToList();
            }
            catch { }

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Books == null)
                Books = context.Books.Where(b => b.inStock == true).ToList();

            if (searchTextBox.Text.Length != 0)
            {
                switch (columnComboBox.SelectedIndex)
                {
                    case 0:
                        bookBindingSource.DataSource =
                            Books.Where(b => b.title.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
                        break;
                    case 1:
                        bookBindingSource.DataSource =
                            Books.Where(b => b.author.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
                        break;
                    case 2:
                        bookBindingSource.DataSource =
                            Books.Where(b => b.publishingHouse.ToLower().Contains(searchTextBox.Text.ToLower())).ToList();
                        break;
                    case 3:
                        bookBindingSource.DataSource =
                            Books.Where(b => b.publishYear.Equals(Convert.ToInt32(searchTextBox.Text.ToLower()))).ToList();
                        break;
                    case 4:
                        bookBindingSource.DataSource =
                            Books.Where(b => b.pagesCount > Convert.ToInt32(searchTextBox.Text)).ToList();
                        break;
                    case 5:
                        bookBindingSource.DataSource =
                            Books.Where(b => b.pagesCount < Convert.ToInt32(searchTextBox.Text)).ToList();
                        break;
                }
            }
            else
            {
                bookBindingSource.DataSource = context.Books.Where(b => b.inStock == true).ToList();
            }
        }

        private void takeButton_Click(object sender, EventArgs e)
        {
            if (booksDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please, select at least one book, sir", "Something went wrong :c");
            }
            else if (booksDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please, select only one book, sir", "Something went wrong :c");
            }
            else
            {
                if (ReaderInfo.score > Convert.ToInt32(booksDataGridView.SelectedRows[0].Cells[5].Value))
                {
                    if (ReaderInfo.departmentReader == 2000)
                        MessageBox.Show("You need enter the department in the settings tab. Just do it, sir", "Something went wrong :c");
                    else
                    {
                        int idBook = Convert.ToInt32(booksDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                        var currentBook = context.Books.Single(b => b.id.Equals(idBook));

                        Trade trade = new Trade
                        {
                            date = DateTime.Today,
                            book = currentBook,
                            reader = context.Readers.Where(r => r.nickname.Equals(ReaderInfo.nicknameReader)).Single(),
                            department = context.Departments.Where(d => d.id.Equals(ReaderInfo.departmentReader)).Single(),
                            IsGiven = false
                        };

                        context.Trades.Add(trade);
                        currentBook.inStock = false;

                        var reader = context.Readers.Single(r => r.nickname.Equals(ReaderInfo.nicknameReader));
                        reader.spentPoints += context.Books.Single(b => b.id.Equals(idBook)).pagesCount;

                        ReaderInfo.score = reader.receivedPoints - reader.spentPoints;
                        scoreLabel.Text = ReaderInfo.score.ToString();

                        context.SaveChanges();

                        MessageBox.Show("Pick up your book within a week :)", "Congrats!");

                        updateBooks();
                    }
                }
                else
                {
                    MessageBox.Show("Not enough pages T_T", "Something went wrong :c");
                }
            }
        }

        private void columnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
        }

        public void updateBooks()
        {
            Books = context.Books.Where(b => b.inStock == true).ToList();
            bookBindingSource.DataSource = Books;
        }
    }
}
