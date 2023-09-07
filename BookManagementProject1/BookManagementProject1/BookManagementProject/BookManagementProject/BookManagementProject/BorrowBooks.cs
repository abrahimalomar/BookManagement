using BookManagementProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookManagementProject
{
    public partial class BorrowBooks : Form
    {
        public BorrowBooks()
        {
            InitializeComponent();
        }

        private void BorrowBooks_Load(object sender, EventArgs e)
        {
            using (var dbContext = new BooksDbContext())
            {

                var categoryList = dbContext.books.ToList();
                var categoryNames = categoryList.Select(q => q.Title).ToList();
                comboxbooks .Items.AddRange(categoryNames.ToArray());


                var AutherList = dbContext.customers  .ToList();
                var AutherNames = AutherList.Select(q => q.CustomerName).ToList();
                comboxcustomers .Items.AddRange(AutherNames.ToArray());
            }
        }

        private void borrowbook_Click(object sender, EventArgs e)
        {
           
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Borrow_MouseHover(object sender, EventArgs e)
        {
            Borrow.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void Borrow_MouseLeave(object sender, EventArgs e)
        {
            Borrow.BackColor= Color.FromArgb(64, 33, 88);
        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            using (var dbContext = new BooksDbContext())
            {
                int bookId = dbContext.books
               .Where(c => c.Title == comboxbooks.SelectedItem.ToString())
               .Select(c => c.BookId)
               .FirstOrDefault();

                int customerId = dbContext.customers
              .Where(c => c.CustomerName == comboxcustomers.SelectedItem.ToString())
              .Select(c => c.CustomerId)
              .FirstOrDefault();
                var customer = new CustomersBooks
                {
                 
                    NumberOfBook = Convert.ToInt32(numberofbook.Value),
                    dateTime = DateTime.Value,
                    BookId = bookId,
                    CustomerId = customerId,
                };
                if (customer!=null)
                {
                    dbContext.customersBooks.Add(customer);
                    dbContext.SaveChanges();
                    MessageBox.Show("Successful", "Title", MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("The fields are empty");
                }
                
            }
        }

        private void AddBook_MouseLeave(object sender, EventArgs e)
        {
            AddBook.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void AddBook_MouseHover(object sender, EventArgs e)
        {
            AddBook.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void AddPerson_MouseHover(object sender, EventArgs e)
        {
            AddPerson.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void AddPerson_MouseLeave(object sender, EventArgs e)
        {
            AddPerson.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            Form book = new AddNewBook();
            book.Show();
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            Form person = new AddCustomer();
            person.Show();
        }
    }
}
