using BookManagementProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // تحديد حجم الخط المطلوب
            int fontSize = 12;

            // تحديد العمود الذي ترغب في تغيير حجم خط عناوينه
            int columnIndex = 0;

            // تغيير حجم خط عناوين العمود المحدد
            DatametroGridView.Columns[columnIndex].DefaultCellStyle.Font = new Font(DatametroGridView.Font.FontFamily, fontSize);

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            using (var dbContext = new BooksDbContext())
            {
                DatametroGridView.Rows.Clear();
                var dataList = dbContext.books.Include(b => b.categorie).Include(b => b.authers);
                foreach (var data in dataList)
                {
                    DatametroGridView.Rows.Add();
                    int indexRows = DatametroGridView.Rows.Count - 1;
                    DatametroGridView.Rows[indexRows].Cells[0].Value = data.BookId;
                    DatametroGridView.Rows[indexRows].Cells[1].Value = data.Title;
                    DatametroGridView.Rows[indexRows].Cells[2].Value = data.Descrption;
                    DatametroGridView.Rows[indexRows].Cells[3].Value = data.Price + "  $";
                    DatametroGridView.Rows[indexRows].Cells[4].Value = data.date;
                
                    DatametroGridView.Rows[indexRows].Cells[5].Value = data.categorie?.CategorieName;
                    DatametroGridView.Rows[indexRows].Cells[6].Value = data.authers?.AutherName;

                    //Display Image
                    if (data.Image != null)
                    {
                        Image image = ByteArrayToImage(data.Image);
                        DataGridViewImageCell imageCell = new DataGridViewImageCell();
                        imageCell.Value = image;
                        DatametroGridView.Rows[indexRows].Cells[7] = imageCell;
                    }

                }
            }

        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
        private void addnewbook_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int selectIndex = -1;
        private void DatametroGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectIndex = e.RowIndex;
        }
        private void deletebook_Click(object sender, EventArgs e)
        {
            
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            
        }

        private void Borrow_Click(object sender, EventArgs e)
        {
            
        }

        private void borrowers_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            //[]
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //--
            WindowState = FormWindowState.Minimized;
        }

        private void AddBook_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void AddBook_MouseHover(object sender, EventArgs e)
        {
            AddBook.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void AddBook_MouseLeave(object sender, EventArgs e)
        {
            AddBook.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            Form addnewbook = new AddNewBook();
            addnewbook.Show();
        }

        private void Edit_Book_MouseHover(object sender, EventArgs e)
        {
            Edit_Book.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void Edit_Book_MouseLeave(object sender, EventArgs e)
        {
            Edit_Book.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void Remove_Book_MouseHover(object sender, EventArgs e)
        {
            Remove_Book.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void Remove_Book_MouseLeave(object sender, EventArgs e)
        {
            Remove_Book.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void Remove_Book_Click(object sender, EventArgs e)
        {
            using (var dbContext = new BooksDbContext())
            {
                int bookId = Convert.ToInt32(DatametroGridView.Rows[selectIndex].Cells[0].Value);

                var classShcool = dbContext.books.FirstOrDefault(q => q.BookId == bookId);
                if (classShcool != null)
                {
                    dbContext.books.Remove(classShcool);
                    dbContext.SaveChanges();
                    MessageBox.Show("Successful", "Title", MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("Errors Removed");
                }

            }
        }

        private void Borrow_Book_MouseHover(object sender, EventArgs e)
        {
            Borrow_Book.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void Borrow_Book_MouseLeave(object sender, EventArgs e)
        {
            Borrow_Book.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void Borrow_Book_Click(object sender, EventArgs e)
        {
            Form form = new Borrowers();
            form.Show();
        }

        private void Add_Customer_MouseHover(object sender, EventArgs e)
        {
            Add_Customer.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void Add_Customer_MouseLeave(object sender, EventArgs e)
        {
            Add_Customer.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void Add_Customer_Click(object sender, EventArgs e)
        {
            Form form = new AddCustomer();
            form.Show();
        }

        private void Borrower_Book_MouseHover(object sender, EventArgs e)
        {
            ///
            Borrower_Book.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void Borrower_Book_MouseLeave(object sender, EventArgs e)
        {
            Borrower_Book.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void Borrower_Book_Click(object sender, EventArgs e)
        {
            Form form = new BorrowBooks();
            form.Show();
        }

        private void Edit_Book_Click(object sender, EventArgs e)
        {
            if (selectIndex != -1)
            {


                using (var dbContext = new BooksDbContext())
                {
                    int BookId = Convert.ToInt32(DatametroGridView.Rows[selectIndex].Cells[0].Value);

                    var Books = dbContext.books.FirstOrDefault(q => q.BookId == BookId);

                    if (Books != null)
                    {
                        AddNewBook addBook = new AddNewBook(Books, Books.Title, Books.Descrption, Books.Price, Books.date,Books.CategorieId,Books.AutherId,Books.Image);
                        addBook.Show();
                    }
                    else
                    {
                        MessageBox.Show("Errors");
                    }
                }

            }
            else
            {
                MessageBox.Show("Errors not Selected Row");
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            changepassword.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            changepassword.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void changepassword_Click(object sender, EventArgs e)
        {
            ChangePassword changepassword = new ChangePassword();
            changepassword.Show();
        }

        private void DatametroGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}