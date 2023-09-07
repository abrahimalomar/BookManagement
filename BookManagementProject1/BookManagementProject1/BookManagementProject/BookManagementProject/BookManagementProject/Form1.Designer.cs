
namespace BookManagementProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.minumize = new MetroFramework.Controls.MetroButton();
            this.zoomout = new MetroFramework.Controls.MetroButton();
            this.closewindw = new MetroFramework.Controls.MetroButton();
            this.PanelButton = new System.Windows.Forms.Panel();
            this.changepassword = new System.Windows.Forms.Button();
            this.Borrower_Book = new System.Windows.Forms.Button();
            this.AddBook = new System.Windows.Forms.Button();
            this.Edit_Book = new System.Windows.Forms.Button();
            this.Add_Customer = new System.Windows.Forms.Button();
            this.Borrow_Book = new System.Windows.Forms.Button();
            this.Remove_Book = new System.Windows.Forms.Button();
            this.PanelCenter = new System.Windows.Forms.Panel();
            this.DatametroGridView = new MetroFramework.Controls.MetroGrid();
            this.Idbook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricebook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datebook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autherbook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelTop.SuspendLayout();
            this.PanelButton.SuspendLayout();
            this.PanelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatametroGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(191)))), ((int)(((byte)(181)))));
            this.PanelTop.Controls.Add(this.label1);
            this.PanelTop.Controls.Add(this.minumize);
            this.PanelTop.Controls.Add(this.zoomout);
            this.PanelTop.Controls.Add(this.closewindw);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1130, 56);
            this.PanelTop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book Management Software";
            // 
            // minumize
            // 
            this.minumize.Location = new System.Drawing.Point(998, 8);
            this.minumize.Name = "minumize";
            this.minumize.Size = new System.Drawing.Size(57, 42);
            this.minumize.TabIndex = 2;
            this.minumize.Text = "--";
            this.minumize.UseSelectable = true;
            this.minumize.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // zoomout
            // 
            this.zoomout.Location = new System.Drawing.Point(935, 8);
            this.zoomout.Name = "zoomout";
            this.zoomout.Size = new System.Drawing.Size(57, 42);
            this.zoomout.TabIndex = 1;
            this.zoomout.Text = "[ ]";
            this.zoomout.UseSelectable = true;
            this.zoomout.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // closewindw
            // 
            this.closewindw.Location = new System.Drawing.Point(1061, 8);
            this.closewindw.Name = "closewindw";
            this.closewindw.Size = new System.Drawing.Size(57, 42);
            this.closewindw.TabIndex = 0;
            this.closewindw.Text = "X";
            this.closewindw.UseSelectable = true;
            this.closewindw.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // PanelButton
            // 
            this.PanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(191)))), ((int)(((byte)(181)))));
            this.PanelButton.Controls.Add(this.changepassword);
            this.PanelButton.Controls.Add(this.Borrower_Book);
            this.PanelButton.Controls.Add(this.AddBook);
            this.PanelButton.Controls.Add(this.Edit_Book);
            this.PanelButton.Controls.Add(this.Add_Customer);
            this.PanelButton.Controls.Add(this.Borrow_Book);
            this.PanelButton.Controls.Add(this.Remove_Book);
            this.PanelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelButton.Location = new System.Drawing.Point(0, 495);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Size = new System.Drawing.Size(1130, 81);
            this.PanelButton.TabIndex = 2;
            // 
            // changepassword
            // 
            this.changepassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(33)))), ((int)(((byte)(88)))));
            this.changepassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changepassword.ForeColor = System.Drawing.Color.White;
            this.changepassword.Location = new System.Drawing.Point(956, 14);
            this.changepassword.Name = "changepassword";
            this.changepassword.Size = new System.Drawing.Size(151, 55);
            this.changepassword.TabIndex = 26;
            this.changepassword.Text = "changePassword";
            this.changepassword.UseVisualStyleBackColor = false;
            this.changepassword.Click += new System.EventHandler(this.changepassword_Click);
            this.changepassword.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.changepassword.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // Borrower_Book
            // 
            this.Borrower_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(33)))), ((int)(((byte)(88)))));
            this.Borrower_Book.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Borrower_Book.ForeColor = System.Drawing.Color.White;
            this.Borrower_Book.Location = new System.Drawing.Point(7, 14);
            this.Borrower_Book.Name = "Borrower_Book";
            this.Borrower_Book.Size = new System.Drawing.Size(149, 55);
            this.Borrower_Book.TabIndex = 23;
            this.Borrower_Book.Text = "Borrowers";
            this.Borrower_Book.UseVisualStyleBackColor = false;
            this.Borrower_Book.Click += new System.EventHandler(this.Borrower_Book_Click);
            this.Borrower_Book.MouseLeave += new System.EventHandler(this.Borrower_Book_MouseLeave);
            this.Borrower_Book.MouseHover += new System.EventHandler(this.Borrower_Book_MouseHover);
            // 
            // AddBook
            // 
            this.AddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(33)))), ((int)(((byte)(88)))));
            this.AddBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBook.ForeColor = System.Drawing.Color.White;
            this.AddBook.Location = new System.Drawing.Point(798, 16);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(152, 54);
            this.AddBook.TabIndex = 25;
            this.AddBook.Text = "Add New Book";
            this.AddBook.UseVisualStyleBackColor = false;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            this.AddBook.MouseLeave += new System.EventHandler(this.AddBook_MouseLeave);
            this.AddBook.MouseHover += new System.EventHandler(this.AddBook_MouseHover);
            this.AddBook.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddBook_MouseMove);
            // 
            // Edit_Book
            // 
            this.Edit_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(33)))), ((int)(((byte)(88)))));
            this.Edit_Book.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Edit_Book.ForeColor = System.Drawing.Color.White;
            this.Edit_Book.Location = new System.Drawing.Point(476, 16);
            this.Edit_Book.Name = "Edit_Book";
            this.Edit_Book.Size = new System.Drawing.Size(146, 53);
            this.Edit_Book.TabIndex = 24;
            this.Edit_Book.Text = "Edit Book";
            this.Edit_Book.UseVisualStyleBackColor = false;
            this.Edit_Book.Click += new System.EventHandler(this.Edit_Book_Click);
            this.Edit_Book.MouseLeave += new System.EventHandler(this.Edit_Book_MouseLeave);
            this.Edit_Book.MouseHover += new System.EventHandler(this.Edit_Book_MouseHover);
            // 
            // Add_Customer
            // 
            this.Add_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(33)))), ((int)(((byte)(88)))));
            this.Add_Customer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_Customer.ForeColor = System.Drawing.Color.White;
            this.Add_Customer.Location = new System.Drawing.Point(162, 13);
            this.Add_Customer.Name = "Add_Customer";
            this.Add_Customer.Size = new System.Drawing.Size(157, 56);
            this.Add_Customer.TabIndex = 22;
            this.Add_Customer.Text = "Add Customer";
            this.Add_Customer.UseVisualStyleBackColor = false;
            this.Add_Customer.Click += new System.EventHandler(this.Add_Customer_Click);
            this.Add_Customer.MouseLeave += new System.EventHandler(this.Add_Customer_MouseLeave);
            this.Add_Customer.MouseHover += new System.EventHandler(this.Add_Customer_MouseHover);
            // 
            // Borrow_Book
            // 
            this.Borrow_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(33)))), ((int)(((byte)(88)))));
            this.Borrow_Book.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Borrow_Book.ForeColor = System.Drawing.Color.White;
            this.Borrow_Book.Location = new System.Drawing.Point(628, 16);
            this.Borrow_Book.Name = "Borrow_Book";
            this.Borrow_Book.Size = new System.Drawing.Size(164, 54);
            this.Borrow_Book.TabIndex = 20;
            this.Borrow_Book.Text = "Borrow";
            this.Borrow_Book.UseVisualStyleBackColor = false;
            this.Borrow_Book.Click += new System.EventHandler(this.Borrow_Book_Click);
            this.Borrow_Book.MouseLeave += new System.EventHandler(this.Borrow_Book_MouseLeave);
            this.Borrow_Book.MouseHover += new System.EventHandler(this.Borrow_Book_MouseHover);
            // 
            // Remove_Book
            // 
            this.Remove_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(33)))), ((int)(((byte)(88)))));
            this.Remove_Book.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Remove_Book.ForeColor = System.Drawing.Color.White;
            this.Remove_Book.Location = new System.Drawing.Point(325, 14);
            this.Remove_Book.Name = "Remove_Book";
            this.Remove_Book.Size = new System.Drawing.Size(145, 56);
            this.Remove_Book.TabIndex = 21;
            this.Remove_Book.Text = "Remove Book";
            this.Remove_Book.UseVisualStyleBackColor = false;
            this.Remove_Book.Click += new System.EventHandler(this.Remove_Book_Click);
            this.Remove_Book.MouseLeave += new System.EventHandler(this.Remove_Book_MouseLeave);
            this.Remove_Book.MouseHover += new System.EventHandler(this.Remove_Book_MouseHover);
            // 
            // PanelCenter
            // 
            this.PanelCenter.Controls.Add(this.DatametroGridView);
            this.PanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCenter.Location = new System.Drawing.Point(0, 56);
            this.PanelCenter.Name = "PanelCenter";
            this.PanelCenter.Size = new System.Drawing.Size(1130, 439);
            this.PanelCenter.TabIndex = 3;
            // 
            // DatametroGridView
            // 
            this.DatametroGridView.AllowUserToAddRows = false;
            this.DatametroGridView.AllowUserToDeleteRows = false;
            this.DatametroGridView.AllowUserToResizeRows = false;
            this.DatametroGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DatametroGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatametroGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DatametroGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.DatametroGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatametroGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DatametroGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatametroGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idbook,
            this.titile,
            this.descrption,
            this.pricebook,
            this.datebook,
            this.categories,
            this.autherbook,
            this.Imge});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatametroGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DatametroGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatametroGridView.EnableHeadersVisualStyles = false;
            this.DatametroGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DatametroGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DatametroGridView.Location = new System.Drawing.Point(0, 0);
            this.DatametroGridView.Name = "DatametroGridView";
            this.DatametroGridView.ReadOnly = true;
            this.DatametroGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatametroGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DatametroGridView.RowHeadersWidth = 51;
            this.DatametroGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DatametroGridView.RowTemplate.Height = 29;
            this.DatametroGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatametroGridView.Size = new System.Drawing.Size(1130, 439);
            this.DatametroGridView.TabIndex = 0;
            this.DatametroGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatametroGridView_CellContentClick);
            this.DatametroGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DatametroGridView_RowHeaderMouseClick);
            // 
            // Idbook
            // 
            this.Idbook.HeaderText = "IdBook";
            this.Idbook.MinimumWidth = 6;
            this.Idbook.Name = "Idbook";
            this.Idbook.ReadOnly = true;
            this.Idbook.Width = 125;
            // 
            // titile
            // 
            this.titile.HeaderText = "Title";
            this.titile.MinimumWidth = 6;
            this.titile.Name = "titile";
            this.titile.ReadOnly = true;
            this.titile.Width = 125;
            // 
            // descrption
            // 
            this.descrption.HeaderText = "Descrption";
            this.descrption.MinimumWidth = 6;
            this.descrption.Name = "descrption";
            this.descrption.ReadOnly = true;
            this.descrption.Width = 125;
            // 
            // pricebook
            // 
            this.pricebook.HeaderText = "Price";
            this.pricebook.MinimumWidth = 6;
            this.pricebook.Name = "pricebook";
            this.pricebook.ReadOnly = true;
            this.pricebook.Width = 125;
            // 
            // datebook
            // 
            this.datebook.HeaderText = "Date";
            this.datebook.MinimumWidth = 6;
            this.datebook.Name = "datebook";
            this.datebook.ReadOnly = true;
            this.datebook.Width = 125;
            // 
            // categories
            // 
            this.categories.HeaderText = "Categorie";
            this.categories.MinimumWidth = 6;
            this.categories.Name = "categories";
            this.categories.ReadOnly = true;
            this.categories.Width = 125;
            // 
            // autherbook
            // 
            this.autherbook.HeaderText = "Auther";
            this.autherbook.MinimumWidth = 6;
            this.autherbook.Name = "autherbook";
            this.autherbook.ReadOnly = true;
            this.autherbook.Width = 125;
            // 
            // Imge
            // 
            this.Imge.HeaderText = "Picture";
            this.Imge.MinimumWidth = 6;
            this.Imge.Name = "Imge";
            this.Imge.ReadOnly = true;
            this.Imge.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(191)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1130, 576);
            this.Controls.Add(this.PanelCenter);
            this.Controls.Add(this.PanelButton);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.PanelButton.ResumeLayout(false);
            this.PanelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatametroGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelButton;
        private System.Windows.Forms.Panel PanelCenter;
        private MetroFramework.Controls.MetroGrid DatametroGridView;
        private MetroFramework.Controls.MetroButton closewindw;
        private MetroFramework.Controls.MetroButton minumize;
        private MetroFramework.Controls.MetroButton zoomout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button Edit_Book;
        private System.Windows.Forms.Button Borrower_Book;
        private System.Windows.Forms.Button Add_Customer;
        private System.Windows.Forms.Button Remove_Book;
        private System.Windows.Forms.Button Borrow_Book;
        private System.Windows.Forms.Button changepassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idbook;
        private System.Windows.Forms.DataGridViewTextBoxColumn titile;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrption;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricebook;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebook;
        private System.Windows.Forms.DataGridViewTextBoxColumn categories;
        private System.Windows.Forms.DataGridViewTextBoxColumn autherbook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imge;
    }
}

