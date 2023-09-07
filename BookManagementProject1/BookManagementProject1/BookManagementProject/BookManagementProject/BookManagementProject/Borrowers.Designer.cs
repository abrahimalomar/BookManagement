
namespace BookManagementProject
{
    partial class Borrowers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelTop = new MetroFramework.Controls.MetroPanel();
            this.Miunmize = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.DataGridViewBorrower = new MetroFramework.Controls.MetroGrid();
            this.Id_Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofbok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofborrower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelBouutom = new MetroFramework.Controls.MetroPanel();
            this.Remove = new System.Windows.Forms.Button();
            this.PanelTop.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBorrower)).BeginInit();
            this.PanelBouutom.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.Gray;
            this.PanelTop.Controls.Add(this.Miunmize);
            this.PanelTop.Controls.Add(this.metroButton1);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.HorizontalScrollbarBarColor = true;
            this.PanelTop.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelTop.HorizontalScrollbarSize = 10;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(800, 43);
            this.PanelTop.TabIndex = 1;
            this.PanelTop.VerticalScrollbarBarColor = true;
            this.PanelTop.VerticalScrollbarHighlightOnWheel = false;
            this.PanelTop.VerticalScrollbarSize = 10;
            // 
            // Miunmize
            // 
            this.Miunmize.Location = new System.Drawing.Point(706, 0);
            this.Miunmize.Name = "Miunmize";
            this.Miunmize.Size = new System.Drawing.Size(43, 43);
            this.Miunmize.TabIndex = 4;
            this.Miunmize.Text = "---";
            this.Miunmize.UseSelectable = true;
            this.Miunmize.Click += new System.EventHandler(this.Miunmize_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(755, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(45, 43);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "X";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.DataGridViewBorrower);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 43);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(800, 407);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // DataGridViewBorrower
            // 
            this.DataGridViewBorrower.AllowUserToResizeRows = false;
            this.DataGridViewBorrower.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(191)))), ((int)(((byte)(181)))));
            this.DataGridViewBorrower.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewBorrower.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridViewBorrower.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewBorrower.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewBorrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBorrower.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Data,
            this.numberofbok,
            this.dateofborrower,
            this.book,
            this.customer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewBorrower.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewBorrower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewBorrower.EnableHeadersVisualStyles = false;
            this.DataGridViewBorrower.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataGridViewBorrower.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewBorrower.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewBorrower.Name = "DataGridViewBorrower";
            this.DataGridViewBorrower.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewBorrower.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewBorrower.RowHeadersWidth = 51;
            this.DataGridViewBorrower.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridViewBorrower.RowTemplate.Height = 29;
            this.DataGridViewBorrower.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewBorrower.Size = new System.Drawing.Size(800, 407);
            this.DataGridViewBorrower.TabIndex = 2;
            this.DataGridViewBorrower.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewBorrower_RowHeaderMouseClick);
            // 
            // Id_Data
            // 
            this.Id_Data.HeaderText = "Id";
            this.Id_Data.MinimumWidth = 6;
            this.Id_Data.Name = "Id_Data";
            this.Id_Data.Width = 125;
            // 
            // numberofbok
            // 
            this.numberofbok.HeaderText = "NumberOfBook";
            this.numberofbok.MinimumWidth = 6;
            this.numberofbok.Name = "numberofbok";
            this.numberofbok.Width = 125;
            // 
            // dateofborrower
            // 
            this.dateofborrower.HeaderText = "DateOfBorrower";
            this.dateofborrower.MinimumWidth = 6;
            this.dateofborrower.Name = "dateofborrower";
            this.dateofborrower.Width = 125;
            // 
            // book
            // 
            this.book.HeaderText = "Book";
            this.book.MinimumWidth = 6;
            this.book.Name = "book";
            this.book.Width = 125;
            // 
            // customer
            // 
            this.customer.HeaderText = "Person";
            this.customer.MinimumWidth = 6;
            this.customer.Name = "customer";
            this.customer.Width = 125;
            // 
            // PanelBouutom
            // 
            this.PanelBouutom.Controls.Add(this.Remove);
            this.PanelBouutom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBouutom.HorizontalScrollbarBarColor = true;
            this.PanelBouutom.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelBouutom.HorizontalScrollbarSize = 10;
            this.PanelBouutom.Location = new System.Drawing.Point(0, 395);
            this.PanelBouutom.Name = "PanelBouutom";
            this.PanelBouutom.Size = new System.Drawing.Size(800, 55);
            this.PanelBouutom.TabIndex = 3;
            this.PanelBouutom.VerticalScrollbarBarColor = true;
            this.PanelBouutom.VerticalScrollbarHighlightOnWheel = false;
            this.PanelBouutom.VerticalScrollbarSize = 10;
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(33)))), ((int)(((byte)(88)))));
            this.Remove.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Remove.ForeColor = System.Drawing.Color.White;
            this.Remove.Location = new System.Drawing.Point(326, 14);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(94, 38);
            this.Remove.TabIndex = 6;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            this.Remove.MouseLeave += new System.EventHandler(this.Remove_MouseLeave);
            this.Remove.MouseHover += new System.EventHandler(this.Remove_MouseHover);
            // 
            // Borrowers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelBouutom);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Borrowers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrowers";
            this.Activated += new System.EventHandler(this.Borrowers_Activated);
            this.Load += new System.EventHandler(this.Borrowers_Load);
            this.PanelTop.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBorrower)).EndInit();
            this.PanelBouutom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel PanelTop;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid DataGridViewBorrower;
        private MetroFramework.Controls.MetroPanel PanelBouutom;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton Miunmize;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofbok;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofborrower;
        private System.Windows.Forms.DataGridViewTextBoxColumn book;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
    }
}