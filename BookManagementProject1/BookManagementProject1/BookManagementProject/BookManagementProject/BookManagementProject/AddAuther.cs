using BookManagementProject.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class AddAuther : Form
    {
        public AddAuther()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void AddAuther_Load(object sender, EventArgs e)
        {

            GetDataAuther();
        }
        public void GetDataAuther()
        {
            using (var dbContext = new BooksDbContext())
            {
                DataGridViewAuther.Rows.Clear();

                // Refresh local data
                dbContext.authers.Load();

                var dataList = dbContext.authers.Local;
                foreach (var data in dataList)
                {
                    int indexRows = DataGridViewAuther.Rows.Add(); // Add a new row and get its index

                    DataGridViewAuther.Rows[indexRows].Cells[0].Value = data.AutherId; // Assign value to the first column (index 0)
                    DataGridViewAuther.Rows[indexRows].Cells[1].Value = data.AutherName; // Assign value to the second column (index 1)
                }
            }
        }
        private void addnewauther_Click(object sender, EventArgs e)
        {
         
        }
        int selectIndex = -1;
        private void DataGridViewAuther_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectIndex = e.RowIndex;
            InputAutherText.Text = DataGridViewAuther.Rows[selectIndex].Cells[1].Value.ToString();
        }

        private void removeauther_Click(object sender, EventArgs e)
        {
            
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            //Edit
            using (var dbContext=new BooksDbContext())
            {

                int autherId = Convert.ToInt32(DataGridViewAuther.Rows[selectIndex].Cells[0].Value);

                var Auther = dbContext.authers.FirstOrDefault(q => q.AutherId == autherId);
                if (Auther!=null)
                {
                    Auther.AutherName = InputAutherText.Text;

                    dbContext.authers.Update(Auther);
                    dbContext.SaveChanges();
                    GetDataAuther();
                    MessageBox.Show("Modified successfully");
                }
                else
                {
                    MessageBox.Show("Error not modified");
                }
               
            }
        }

        private void Edit_MouseHover(object sender, EventArgs e)
        {
            Edit.BackColor=Color.FromArgb(125, 86,131);
        }

        private void Edit_MouseLeave(object sender, EventArgs e)
        {
            Edit.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void AddCategorie_MouseHover(object sender, EventArgs e)
        {
            AddAuthers.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void AddAuthers_MouseLeave(object sender, EventArgs e)
        {
            AddAuthers.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void AddAuthers_Click(object sender, EventArgs e)
        {
            using (var dbContext = new BooksDbContext())
            {
                if (InputAutherText.Text != string.Empty)
                {
                    var data = new Authers
                    {
                        AutherName = InputAutherText.Text,
                    };
                    dbContext.authers.Add(data);
                    dbContext.SaveChanges();
                    MessageBox.Show("Sccussefull");
                    InputAutherText.Text = string.Empty;
                    AddAuther_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Errors");
                }

            }
        }

        private void RemoveCategorie_MouseLeave(object sender, EventArgs e)
        {
            RemoveCategorie. BackColor = Color.FromArgb(64, 33, 88);
        }

        private void RemoveCategorie_MouseMove(object sender, MouseEventArgs e)
        {
            RemoveCategorie.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void RemoveCategorie_Click(object sender, EventArgs e)
        {
            if (selectIndex >= 0 && selectIndex < DataGridViewAuther.Rows.Count)
            {
                using (var dbContext = new BooksDbContext())
                {

                    int autherId = Convert.ToInt32(DataGridViewAuther.Rows[selectIndex].Cells[0].Value);

                    var authers = dbContext.authers.FirstOrDefault(q => q.AutherId == autherId);
                    if (authers != null)
                    {
                        dbContext.authers.Remove(authers);
                        dbContext.SaveChanges();
                        
                        MessageBox.Show("Successful removed", "Title", MessageBoxButtons.OKCancel);

                        AddAuther_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error: Item not found");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error: Invalid index");
            }
        }

        private void DataGridViewAuther_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void closewindw_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
