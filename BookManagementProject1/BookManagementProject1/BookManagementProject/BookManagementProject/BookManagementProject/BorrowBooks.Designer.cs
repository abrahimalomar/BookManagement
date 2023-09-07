
namespace BookManagementProject
{
    partial class BorrowBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.DateTime = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Borrow = new System.Windows.Forms.Button();
            this.AddPerson = new System.Windows.Forms.Button();
            this.AddBook = new System.Windows.Forms.Button();
            this.numberofbook = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.comboxbooks = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboxcustomers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberofbook)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(244, 284);
            this.DateTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(175, 30);
            this.DateTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number Of Copies";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "DateTime borrowing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Book";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "borrower Person";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 48);
            this.panel1.TabIndex = 9;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(459, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(52, 48);
            this.close.TabIndex = 0;
            this.close.Text = "X";
            this.close.UseSelectable = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Borrow);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 177);
            this.panel2.TabIndex = 10;
            // 
            // Borrow
            // 
            this.Borrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(33)))), ((int)(((byte)(88)))));
            this.Borrow.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Borrow.ForeColor = System.Drawing.Color.White;
            this.Borrow.Location = new System.Drawing.Point(214, 30);
            this.Borrow.Name = "Borrow";
            this.Borrow.Size = new System.Drawing.Size(94, 48);
            this.Borrow.TabIndex = 5;
            this.Borrow.Text = "Borrow";
            this.Borrow.UseVisualStyleBackColor = false;
            this.Borrow.Click += new System.EventHandler(this.Borrow_Click);
            this.Borrow.MouseLeave += new System.EventHandler(this.Borrow_MouseLeave);
            this.Borrow.MouseHover += new System.EventHandler(this.Borrow_MouseHover);
            // 
            // AddPerson
            // 
            this.AddPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(33)))), ((int)(((byte)(88)))));
            this.AddPerson.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddPerson.ForeColor = System.Drawing.Color.White;
            this.AddPerson.Location = new System.Drawing.Point(440, 222);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(59, 30);
            this.AddPerson.TabIndex = 7;
            this.AddPerson.Text = "Add";
            this.AddPerson.UseVisualStyleBackColor = false;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            this.AddPerson.MouseLeave += new System.EventHandler(this.AddPerson_MouseLeave);
            this.AddPerson.MouseHover += new System.EventHandler(this.AddPerson_MouseHover);
            // 
            // AddBook
            // 
            this.AddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(33)))), ((int)(((byte)(88)))));
            this.AddBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBook.ForeColor = System.Drawing.Color.White;
            this.AddBook.Location = new System.Drawing.Point(440, 158);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(59, 30);
            this.AddBook.TabIndex = 11;
            this.AddBook.Text = "Add";
            this.AddBook.UseVisualStyleBackColor = false;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            this.AddBook.MouseLeave += new System.EventHandler(this.AddBook_MouseLeave);
            this.AddBook.MouseHover += new System.EventHandler(this.AddBook_MouseHover);
            // 
            // numberofbook
            // 
            this.numberofbook.BackColor = System.Drawing.Color.Transparent;
            this.numberofbook.BorderRadius = 20;
            this.numberofbook.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numberofbook.CustomizableEdges = customizableEdges1;
            this.numberofbook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberofbook.Location = new System.Drawing.Point(244, 85);
            this.numberofbook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numberofbook.Name = "numberofbook";
            this.numberofbook.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.numberofbook.Size = new System.Drawing.Size(175, 36);
            this.numberofbook.TabIndex = 27;
            // 
            // comboxbooks
            // 
            this.comboxbooks.BackColor = System.Drawing.Color.Transparent;
            this.comboxbooks.BorderRadius = 20;
            this.comboxbooks.CustomizableEdges = customizableEdges3;
            this.comboxbooks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboxbooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxbooks.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboxbooks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboxbooks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboxbooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboxbooks.ItemHeight = 30;
            this.comboxbooks.Location = new System.Drawing.Point(244, 152);
            this.comboxbooks.Name = "comboxbooks";
            this.comboxbooks.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.comboxbooks.Size = new System.Drawing.Size(175, 36);
            this.comboxbooks.TabIndex = 28;
            // 
            // comboxcustomers
            // 
            this.comboxcustomers.BackColor = System.Drawing.Color.Transparent;
            this.comboxcustomers.BorderRadius = 20;
            this.comboxcustomers.CustomizableEdges = customizableEdges5;
            this.comboxcustomers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboxcustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxcustomers.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboxcustomers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboxcustomers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboxcustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboxcustomers.ItemHeight = 30;
            this.comboxcustomers.Location = new System.Drawing.Point(244, 216);
            this.comboxcustomers.Name = "comboxcustomers";
            this.comboxcustomers.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.comboxcustomers.Size = new System.Drawing.Size(175, 36);
            this.comboxcustomers.TabIndex = 29;
            // 
            // BorrowBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(191)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(511, 530);
            this.Controls.Add(this.comboxcustomers);
            this.Controls.Add(this.DateTime);
            this.Controls.Add(this.comboxbooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberofbook);
            this.Controls.Add(this.AddBook);
            this.Controls.Add(this.AddPerson);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BorrowBooks";
            this.Load += new System.EventHandler(this.BorrowBooks_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numberofbook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroDateTime DateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Borrow;
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.Button AddBook;
        private Guna.UI2.WinForms.Guna2NumericUpDown numberofbook;
        private Guna.UI2.WinForms.Guna2ComboBox comboxbooks;
        private Guna.UI2.WinForms.Guna2ComboBox comboxcustomers;
    }
}