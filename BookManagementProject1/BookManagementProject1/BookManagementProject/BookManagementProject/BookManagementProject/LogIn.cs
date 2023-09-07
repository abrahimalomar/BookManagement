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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogInUsers_Click(object sender, EventArgs e)
        {

            string UserName = "";
            string Password = "";
            if (UserNameTxt .Text == "")
            {
                required.Visible = true;
                return;
            }
            if (PasswordTxt .TextLength < 8)
            {
                minLenght.Visible = true;
                return;
            }


            using (var dbContext = new BooksDbContext())
            {
                UserName = dbContext.users .FirstOrDefault()?.UserName ?? "";
                Password = dbContext.users.FirstOrDefault()?.Password ?? "";
            }
            if (UserName == UserNameTxt.Text && Password == PasswordTxt.Text)
            {
                //MessageBox.Show("Success", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form Book = new Form1();
                Book.Show();
                this.Hide();

                UserNameTxt.Text = string.Empty;
                PasswordTxt.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Faild", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (PasswordTxt .PasswordChar == '*')
            {
                PasswordTxt.PasswordChar = '\0';
                showPassword .Checked = true;
            }
            else
            {
                PasswordTxt.PasswordChar = '*';
                showPassword.Checked = false;
            }
        }

        private void LogInUsers_MouseHover(object sender, EventArgs e)
        {
            LogInUsers.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void LogInUsers_MouseLeave(object sender, EventArgs e)
        {
            LogInUsers.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            using (var dbContext = new BooksDbContext())
            {
                var usercount = dbContext.users.Count();

                if (usercount==0)
                {
                    var user = new Users
                    {
                        UserName = "admin",
                        Password = "123456789",
                    };
                    dbContext.users.Add(user);
                    dbContext.SaveChanges();
                }
                    
                       
                        
                    
                
            }
        }

        private void closewindw_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (PasswordTxt.TextLength > 7)
            {
                minLenght.Visible = false;
            }
            else
            {
                minLenght.Visible = true;
            }
        }

        private void UserNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (UserNameTxt.Text!=null)
            {
                required.Visible = false;
            }
        }
    }
}
