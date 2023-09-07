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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void changespassowrd_Click(object sender, EventArgs e)
        {
            var usernameBb = "";
            var passwordDb = "";

            if (UserNameText .Text == "")
            {
                required.Visible = true;
                return;
            }
            if (oldPassword .TextLength < 8)
            {
                minLenght.Visible = true;
                return;
            }
            if (newpassword .TextLength < 8)
            {
                minLenght.Visible = true;
                return;
            }
            using (var dbContext = new BooksDbContext())
            {
                usernameBb = dbContext.users.First().UserName;
                passwordDb = dbContext.users.First().Password;
            }
            if (usernameBb == UserNameText.Text && passwordDb == oldPassword.Text)
            {

                using (var dbContext = new BooksDbContext())
                {
                    var user = dbContext.users.First(u => u.UserName == usernameBb);
                    user.Password = newpassword.Text;
                    dbContext.SaveChanges();
                }

                MessageBox.Show("Password changed successfully ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UserNameText.Text = string.Empty;
            oldPassword.Text = string.Empty;
            newpassword.Text = string.Empty;
        }

        private void changespassowrd_MouseHover(object sender, EventArgs e)
        {
            changespassowrd.BackColor = Color.FromArgb(125, 86, 131);
        }

        private void changespassowrd_MouseLeave(object sender, EventArgs e)
        {
            changespassowrd.BackColor = Color.FromArgb(64, 33, 88);
        }

        private void closewindw_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserNameText_TextChanged(object sender, EventArgs e)
        {
            if (UserNameText .Text != "")
            {
                required.Visible = false;
            }
        }

        private void oldPassword_TextChanged(object sender, EventArgs e)
        {
            if (oldPassword.TextLength > 7)
            {
                minLenght.Visible = false;
            }
            else
            {
                minLenght.Visible = true;
            }
        }

        private void newpassword_TextChanged(object sender, EventArgs e)
        {
            if (newpassword .TextLength > 7)
            {
                minLenghtnewpassword.Visible = false;
              

            }
            else
            {
                minLenghtnewpassword.Visible = true;
            }
        }
    }
}
