using BookManagementProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BookManagementProject
{
    public partial class AddCategorie : Form
    {
        public AddCategorie()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //Add new Category
            using (var dbContext = new BooksDbContext())
            {
                if (textBox1.Text != string.Empty)
                {
                    var data = new Categories
                    {
                        CategorieName = textBox1.Text,
                    };
                    dbContext.categories.Add(data);
                    dbContext.SaveChanges();
                    MessageBox.Show("Sccussefull");
                    AddCategorie_Load(sender, e);


                }
                else
                {
                    MessageBox.Show("Errors");
                }

            }
        }

        private void AddCategorie_Load(object sender, EventArgs e)
        {
          
            //View Data Category
            using (var dbContext = new BooksDbContext())
            {
                DataGridViewCategory.Rows.Clear();

                // Refresh local data
                dbContext.categories.Load();

                var dataList = dbContext.categories.Local;
                foreach (var data in dataList)
                {
                    int indexRows = DataGridViewCategory.Rows.Add(); // Add a new row and get its index

                   DataGridViewCategory.Rows[indexRows].Cells[0].Value = data.CategorieId; // Assign value to the first column (index 0)
                    DataGridViewCategory.Rows[indexRows].Cells[1].Value = data.CategorieName; // Assign value to the second column (index 1)
                }
            }




        }
        int selectIndex = -1;
        private void DataGridViewCategory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DataGridViewCategory.Rows.Count)
            {
                selectIndex = e.RowIndex;
                textBox1.Text = DataGridViewCategory.Rows[selectIndex].Cells[1].Value.ToString();
                //label2.Text = selectIndex.ToString();
                // textBox1.Text = DataGridViewCategory.Rows[selectIndex].Cells[1].Value.ToString();
                // numericUpDown1.Value = Convert.ToInt32(dataGridView1.Rows[selectIndex].Cells[2].Value);
            }
            
        }

        
        private void removecategory_Click(object sender, EventArgs e)
        {



        }

        private void editcategory_Click(object sender, EventArgs e)
        {

        }

        private void AddCategorie_Activated(object sender, EventArgs e)
        {
            //add();
        }
 

        private void AddCategorie_ChangeUICues(object sender, UICuesEventArgs e)
        {
           
        }

        private void Add_Categorie_MouseHover(object sender, EventArgs e)
        {
            Add_Categorie.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void Add_Categorie_MouseLeave(object sender, EventArgs e)
        {
            Add_Categorie.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void Edit_Categorie_MouseLeave(object sender, EventArgs e)
        {
            Edit_Categorie.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void Edit_Categorie_MouseMove(object sender, MouseEventArgs e)
        {
            Edit_Categorie.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void Remove_Categorie_MouseHover(object sender, EventArgs e)
        {
            Remove_Categorie.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void Remove_Categorie_MouseLeave(object sender, EventArgs e)
        {
            Remove_Categorie.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void Add_Categorie_Click(object sender, EventArgs e)
        {
            //add new Categorie
            using (var dbContext = new BooksDbContext())
            {
                if (textBox1.Text != string.Empty)
                {
                    var data = new Categories
                    {
                        CategorieName = textBox1.Text,
                    };
                    dbContext.categories.Add(data);
                    dbContext.SaveChanges();
                    MessageBox.Show("Sccussefull");
                    textBox1.Text = string.Empty;
                    AddCategorie_Load(sender, e);


                }
                else
                {
                    MessageBox.Show("Errors");
                }

            }
        }

        private void Remove_Categorie_Click(object sender, EventArgs e)
        {
            //Remove a Categorie
            if (selectIndex >= 0 && selectIndex < DataGridViewCategory.Rows.Count)
            {
                using (var dbContext = new BooksDbContext())
                {

                    int classId = Convert.ToInt32(DataGridViewCategory.Rows[selectIndex].Cells[0].Value);

                    var classShcool = dbContext.categories.FirstOrDefault(q => q.CategorieId == classId);
                    if (classShcool != null)
                    {
                        dbContext.categories.Remove(classShcool);
                        dbContext.SaveChanges();
                    
                        MessageBox.Show("Successful removed", "Title", MessageBoxButtons.OKCancel);
                        AddCategorie_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error: Item not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error: Invalid index.");
            }
        }

        private void closewindw_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Edit_Categorie_Click(object sender, EventArgs e)
        {

            using (var dbContext = new BooksDbContext())
            {
                int classId = Convert.ToInt32(DataGridViewCategory.Rows[selectIndex].Cells[0].Value);

                var classShcool = dbContext.categories.FirstOrDefault(q => q.CategorieId == classId);


               

                if (classShcool != null)
                {
                    classShcool.CategorieName = textBox1.Text;


                    dbContext.categories.Update(classShcool);
                    dbContext.SaveChanges();
                    MessageBox.Show("Sccussefull");
                    textBox1.Text = string.Empty;
                    AddCategorie_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Errors");
                }
            }
            /*
             //Edit
             using (var dbContext = new BooksDbContext())
             {

                 int categorieId = Convert.ToInt32(DataGridViewCategory.Rows[selectIndex].Cells[0].Value);

                 var categorie = dbContext.categories.FirstOrDefault(q => q.CategorieId == categorieId);
                 if (categorie != null)
                 {
                     categorie.CategorieName =textBox1 .Text;

                     dbContext.categories.Update(categorie);
                     dbContext.SaveChanges();

                     MessageBox.Show("Modified successfully");
                 }
                 else
                 {
                     MessageBox.Show("Error not modified");
                 }

             }
             */
        }
    }
}
