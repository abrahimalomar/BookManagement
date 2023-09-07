using BookManagementProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



using OfficeOpenXml;
using System;
using System.IO;
using System.Windows.Forms;


namespace BookManagementProject
{
    public partial class Borrowers : Form
    {
        public Borrowers()
        {
            InitializeComponent();
        }

        private void Borrowers_Activated(object sender, EventArgs e)
        {

        }

        private void Borrowers_Load(object sender, EventArgs e)
        {

            GetData();
        }
        public void GetData()
        {
            using (var dbContext = new BooksDbContext())
            {
                var query = from bk in dbContext.books
                            join cb in dbContext.customersBooks on bk.BookId equals cb.BookId
                            join cus in dbContext.customers on cb.CustomerId equals cus.CustomerId
                            select new
                            {
                                cb.CustomersBookId,
                                cb.NumberOfBook,
                                cb.dateTime,
                                bk.Title,
                                cus.CustomerName,

                            };

                DataGridViewBorrower.Rows.Clear();

                foreach (var item in query)
                {
                    DataGridViewBorrower.Rows.Add(item.CustomersBookId, item.NumberOfBook, item.dateTime, item.Title, item.CustomerName);
                }
            }
        }
    private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Miunmize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void ExportToExcel()
        {
            if (DataGridViewBorrower != null)
            {


                
                if (DataGridViewBorrower.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Books");

                      
                        for (int i = 0; i < DataGridViewBorrower.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = DataGridViewBorrower.Columns[i].HeaderText;
                        }

                      
                        for (int row = 0; row < DataGridViewBorrower.Rows.Count; row++)
                        {
                            for (int col = 0; col < DataGridViewBorrower.Columns.Count; col++)
                            {
                                worksheet.Cells[row + 2, col + 1].Value = DataGridViewBorrower.Rows[row].Cells[col].Value.ToString();
                            }
                        }

                      
                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "Excel Files|*.xlsx";
                        saveFileDialog.Title = "Save Excel File";
                        saveFileDialog.FileName = "Books.xlsx";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                            excelPackage.SaveAs(fileInfo);
                            MessageBox.Show("Data exported successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while exporting the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox. Show("Error DataGridViewBorrower is Empty");
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            using (var dbContext=new BooksDbContext())
            {
                int customerBookId = Convert.ToInt32(DataGridViewBorrower.Rows[selected].Cells[0].Value);

                var customerBook = dbContext.customersBooks.FirstOrDefault(q => q.CustomersBookId == customerBookId);
                if (customerBook!=null)
                {
                    dbContext.customersBooks.Remove(customerBook);
                    dbContext.SaveChanges();

                    MessageBox.Show("Successful", "Title", MessageBoxButtons.OKCancel);
                    GetData();
                }
                else
                {
                    MessageBox.Show("No Item Selected");
                }
               
            }
        }

        int selected = -1;
        private void DataGridViewBorrower_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selected = e.RowIndex;
        }

        private void Remove_MouseHover(object sender, EventArgs e)
        {
            Remove.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void Remove_MouseLeave(object sender, EventArgs e)
        {
            Remove.BackColor = Color.FromArgb(64, 33, 88);
        }
    }
}





