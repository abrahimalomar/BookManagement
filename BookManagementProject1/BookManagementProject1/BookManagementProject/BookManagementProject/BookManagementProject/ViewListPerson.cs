using BookManagementProject;
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
    public partial class ViewListPerson : Form
    {
        public ViewListPerson()
        {
            InitializeComponent();
        }

        private void ViewListPerson_Load(object sender, EventArgs e)
        {
            GetDataPerson();
        }
        public void GetDataPerson()
        {
            using (var dbContext = new BooksDbContext())
            {
                DataGridViewPersonal.Rows.Clear();

                // Refresh local data
                dbContext.customers.Load();

                var dataList = dbContext.customers.Local;
                foreach (var data in dataList)
                {
                    int indexRows = DataGridViewPersonal.Rows.Add(); 

                    DataGridViewPersonal.Rows[indexRows].Cells[0].Value = data.CustomerId;
                    DataGridViewPersonal.Rows[indexRows].Cells[1].Value = data.CustomerName;
                    DataGridViewPersonal.Rows[indexRows].Cells[2].Value = data.Address;

                }
            }
        }
        private void DataGridViewPersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RemoveCategorie_MouseHover(object sender, EventArgs e)
        {
            //remove Person
            Remove.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void RemoveCategorie_MouseLeave(object sender, EventArgs e)
        {
            //remove Person
            Remove.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void Edit_MouseHover(object sender, EventArgs e)
        {
            //Edit Person
            //Edit.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
         
        }

        private void Edit_MouseLeave(object sender, EventArgs e)
        {
            //Edit Person
            //Edit.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void closewindw_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RemoveCategorie_Click(object sender, EventArgs e)
        {
            //Remove Person

            using (var dbContext = new BooksDbContext())
            {
                int CustomerId = Convert.ToInt32(DataGridViewPersonal.Rows[selectIndex].Cells[0].Value);

                var Person = dbContext.customers.FirstOrDefault(q => q.CustomerId== CustomerId);
                if (Person != null)
                {
                    dbContext.customers.Remove(Person);
                    dbContext.SaveChanges();
                   
                    MessageBox.Show("Successful", "Title", MessageBoxButtons.OKCancel);
                    GetDataPerson();
                }
                else
                {
                    MessageBox.Show("Errors Removed");
                }

            }
        }
        int selectIndex = -1;
        private void DataGridViewPersonal_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectIndex = e.RowIndex; 
        }
    }
}
