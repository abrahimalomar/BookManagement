using BookManagementProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace BookManagementProject
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        public AddCustomer(string fullName,string address)
        {

            CustmerNameText.Text= fullName;
            CustomerAddressText.Text= address;
        }
        private void addcustomers_Click(object sender, EventArgs e)
        {
           
          
        }
        public void EmptyInTextBox()
        {
            CustmerNameText.Text = string.Empty;
            CustomerAddressText.Text = string.Empty;
        }

        private void add_customer_MouseLeave(object sender, EventArgs e)
        {
            add_customer.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void add_customer_MouseMove(object sender, MouseEventArgs e)
        {
            
            add_customer.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void add_customer_Click(object sender, EventArgs e)
        {
            using (var dbContex = new BooksDbContext())
            {
                if (CustmerNameText.Text != string.Empty && CustomerAddressText.Text != string.Empty)
                {


                    var data = new Customers
                    {
                        CustomerName = CustmerNameText.Text,
                        Address = CustmerNameText.Text,
                    };

                    dbContex.customers.Add(data);
                    dbContex.SaveChanges();
                    MessageBox.Show("Successful", "Title", MessageBoxButtons.OKCancel);
                    EmptyInTextBox();
                }
                else
                {
                    MessageBox.Show("Error ", "Title", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void ViewListPerson_MouseLeave(object sender, EventArgs e)
        {
            ViewListPerson.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void ViewListPerson_MouseMove(object sender, MouseEventArgs e)
        {
            ViewListPerson.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void ViewListPerson_Click(object sender, EventArgs e)
        {
            Form viewlstperson = new ViewListPerson();
            viewlstperson.Show();
        }

        private void closewindw_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
    }