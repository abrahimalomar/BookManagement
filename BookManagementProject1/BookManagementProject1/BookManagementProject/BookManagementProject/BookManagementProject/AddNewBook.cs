using BookManagementProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using System.IO;



namespace BookManagementProject
{
    public partial class AddNewBook : Form
    {
        Books book = new Books();
        public AddNewBook()
        {
            InitializeComponent();
            //Form2 form2 = new Form2();
            //form2.Text = Add.Text;
            //form2.BackColor = Add.BackColor;
            //form2.ForeColor = Add.ForeColor;
            //Controls.Remove(Add);
            //Controls.Add(form2);
        }
        OpenFileDialog dialog = new OpenFileDialog();
        private void addbook_Click(object sender, EventArgs e)
        {



            //  var dataList = dbContext.books.Include(b => b.categorie).Include(b => b.authers);

        }
        public void EmptyInTextBox()
        {
            TitileText.Text = string.Empty;
            DescrptionText.Text = string.Empty;
            PriceText.Value = 0;
            DateText.Value = DateTime.Now;
            comboBoxCategories.SelectedIndex = -1;
            comboBoxAuthers.SelectedIndex = -1;
            //evaluation = 10,        
            //ImagePath
        }
        private void AddNewBook_Activated(object sender, EventArgs e)
        {

        }

        private void AddNewBook_Load(object sender, EventArgs e)
        {
            using (var dbContext = new BooksDbContext())
            {

                var categoryList = dbContext.categories.ToList();
                var categoryNames = categoryList.Select(q => q.CategorieName).ToList();
                comboBoxCategories.Items.AddRange(categoryNames.ToArray());


                var AutherList = dbContext.authers.ToList();
                var AutherNames = AutherList.Select(q => q.AutherName).ToList();
                comboBoxAuthers.Items.AddRange(AutherNames.ToArray());
            }
        }

        private void AddCategorie_Click(object sender, EventArgs e)
        {

        }

        private void AddAuthers_Click(object sender, EventArgs e)
        {
            Form form = new AddAuther();
            form.Show();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                PIctureBox.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void Add_Book_MouseHover(object sender, EventArgs e)
        {
            Add_Book.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void Add_Book_MouseLeave(object sender, EventArgs e)
        {
            Add_Book.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void Add_Book_Click(object sender, EventArgs e)
        {
            //Add Book

            using (var dbContext = new BooksDbContext())
            {
                Image image = PIctureBox.Image;

                byte[] imageBytes = ImageToByteArray(image);


                int categorieId = dbContext.categories
               .Where(c => c.CategorieName == comboBoxCategories.SelectedItem.ToString())
               .Select(c => c.CategorieId)
               .FirstOrDefault();

                int AutherId = dbContext.authers
              .Where(c => c.AutherName == comboBoxAuthers.SelectedItem.ToString())
              .Select(c => c.AutherId)
              .FirstOrDefault();




                var data = new Books
                {
                    Title = TitileText.Text,
                    Descrption = DescrptionText.Text,
                    Price = Convert.ToInt32(PriceText.Value),
                    date = DateText.Value,

                    CategorieId = categorieId,
                    AutherId = AutherId,
                    Image = imageBytes


                };


                try
                {
                    DialogResult result = MessageBox.Show("Successful", "Title", MessageBoxButtons.OKCancel);

                    if (result == DialogResult.OK)
                    {
                        // Code to handle the OK button click

                        dbContext.books.Add(data);
                        dbContext.SaveChanges();
                        EmptyInTextBox();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        // Code to handle the Cancel button click
                        //  Console.WriteLine("Cancel button clicked");
                        EmptyInTextBox();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private void Add_MouseLeave(object sender, EventArgs e)
        {
            Add.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            Form form = new AddCategorie();
            form.Show();
        }

        private void add_auther_MouseLeave(object sender, EventArgs e)
        {
            add_auther.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void add_auther_MouseHover(object sender, EventArgs e)
        {
            add_auther.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void add_auther_Click(object sender, EventArgs e)
        {
            Form form = new AddAuther();
            form.Show();
        }

        private void Add_MouseHover(object sender, EventArgs e)
        {
            Add.BackColor = Color.FromArgb(125, 86, 131);
        }
        public AddNewBook(Books t, string title, string des, int price, DateTime dateTime, int catId, int autherId, byte[] img)
        {
            Image image = ByteArrayToImage(img);

            byte[] imageByte = ImageToByteArray(image);
            InitializeComponent();
            TitileText.Text = title;
            DescrptionText.Text = des;
            PriceText.Value = price;
            DateText.Value = dateTime;
            PIctureBox.Image = image;
            book = t;
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void Edit_Book_Click(object sender, EventArgs e)
        {
            //Edit Book


            Image image = PIctureBox.Image;

            byte[] imageByte = ImageToByteArray(image);



            if (book != null)
            {


                using (var dbContext = new BooksDbContext())
                {
                    int categorieId = dbContext.categories
                    .Where(c => c.CategorieName == comboBoxCategories.SelectedItem.ToString())
                    .Select(c => c.CategorieId)
                    .FirstOrDefault();
                    int AutherId = dbContext.authers
                    .Where(c => c.AutherName == comboBoxAuthers.SelectedItem.ToString())
                    .Select(c => c.AutherId)
                    .FirstOrDefault();

                    book.Title = TitileText.Text;
                    book.Descrption = DescrptionText.Text;
                    book.Price = Convert.ToInt32(PriceText.Value);
                    book.date = DateText.Value;
                    book.CategorieId = categorieId;
                    book.AutherId = AutherId;
                    book.Image = imageByte;


                    dbContext.books.Update(book);
                    dbContext.SaveChanges();
                    MessageBox.Show("Successful", "Title", MessageBoxButtons.OKCancel);
                }

            }
            else
            {
                MessageBox.Show("Errors");
            }



        }

        private void Edit_Book_MouseHover(object sender, EventArgs e)
        {
            Edit_Book.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void Edit_Book_MouseLeave(object sender, EventArgs e)
        {
            Edit_Book.BackColor = Color.FromArgb(64, 33, 88);

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
