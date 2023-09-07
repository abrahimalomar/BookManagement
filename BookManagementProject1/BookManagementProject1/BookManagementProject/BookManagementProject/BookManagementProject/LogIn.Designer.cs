
namespace BookManagementProject
{
    partial class LogIn
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
            this.PasswordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.LogInUsers = new System.Windows.Forms.Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.showPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.closewindw = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.required = new System.Windows.Forms.Label();
            this.minLenght = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BorderRadius = 20;
            this.PasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxt.CustomizableEdges = customizableEdges1;
            this.PasswordTxt.DefaultText = "";
            this.PasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxt.Location = new System.Drawing.Point(212, 291);
            this.PasswordTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.PlaceholderText = "";
            this.PasswordTxt.SelectedText = "";
            this.PasswordTxt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.PasswordTxt.Size = new System.Drawing.Size(197, 40);
            this.PasswordTxt.TabIndex = 23;
            this.PasswordTxt.TextChanged += new System.EventHandler(this.PasswordTxt_TextChanged);
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.BorderRadius = 20;
            this.UserNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTxt.CustomizableEdges = customizableEdges3;
            this.UserNameTxt.DefaultText = "";
            this.UserNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNameTxt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNameTxt.Location = new System.Drawing.Point(212, 215);
            this.UserNameTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.PasswordChar = '\0';
            this.UserNameTxt.PlaceholderText = "";
            this.UserNameTxt.SelectedText = "";
            this.UserNameTxt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.UserNameTxt.Size = new System.Drawing.Size(197, 40);
            this.UserNameTxt.TabIndex = 22;
            this.UserNameTxt.TextChanged += new System.EventHandler(this.UserNameTxt_TextChanged);
            // 
            // LogInUsers
            // 
            this.LogInUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(33)))), ((int)(((byte)(88)))));
            this.LogInUsers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogInUsers.ForeColor = System.Drawing.Color.White;
            this.LogInUsers.Location = new System.Drawing.Point(212, 393);
            this.LogInUsers.Name = "LogInUsers";
            this.LogInUsers.Size = new System.Drawing.Size(142, 45);
            this.LogInUsers.TabIndex = 24;
            this.LogInUsers.Text = "LogIn";
            this.LogInUsers.UseVisualStyleBackColor = false;
            this.LogInUsers.Click += new System.EventHandler(this.LogInUsers_Click);
            this.LogInUsers.MouseLeave += new System.EventHandler(this.LogInUsers_MouseLeave);
            this.LogInUsers.MouseHover += new System.EventHandler(this.LogInUsers_MouseHover);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(93, 230);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(88, 25);
            this.guna2HtmlLabel1.TabIndex = 25;
            this.guna2HtmlLabel1.Text = "User Name";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(99, 307);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(75, 25);
            this.guna2HtmlLabel2.TabIndex = 26;
            this.guna2HtmlLabel2.Text = "Password";
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showPassword.CheckedState.BorderRadius = 0;
            this.showPassword.CheckedState.BorderThickness = 0;
            this.showPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showPassword.Location = new System.Drawing.Point(421, 307);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(18, 17);
            this.showPassword.TabIndex = 27;
            this.showPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showPassword.UncheckedState.BorderRadius = 0;
            this.showPassword.UncheckedState.BorderThickness = 0;
            this.showPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // closewindw
            // 
            this.closewindw.Location = new System.Drawing.Point(503, 3);
            this.closewindw.Name = "closewindw";
            this.closewindw.Size = new System.Drawing.Size(57, 42);
            this.closewindw.TabIndex = 32;
            this.closewindw.Text = "X";
            this.closewindw.UseSelectable = true;
            this.closewindw.Click += new System.EventHandler(this.closewindw_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookManagementProject.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(212, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // required
            // 
            this.required.AutoSize = true;
            this.required.ForeColor = System.Drawing.Color.Red;
            this.required.Location = new System.Drawing.Point(259, 259);
            this.required.Name = "required";
            this.required.Size = new System.Drawing.Size(65, 20);
            this.required.TabIndex = 34;
            this.required.Text = "required";
            this.required.Visible = false;
            // 
            // minLenght
            // 
            this.minLenght.AutoSize = true;
            this.minLenght.ForeColor = System.Drawing.Color.Red;
            this.minLenght.Location = new System.Drawing.Point(230, 335);
            this.minLenght.Name = "minLenght";
            this.minLenght.Size = new System.Drawing.Size(152, 20);
            this.minLenght.TabIndex = 35;
            this.minLenght.Text = "Less than 8 characters";
            this.minLenght.Visible = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.minLenght);
            this.Controls.Add(this.required);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closewindw);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.LogInUsers);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.PasswordTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox PasswordTxt;
        private Guna.UI2.WinForms.Guna2TextBox UserNameTxt;
        private System.Windows.Forms.Button LogInUsers;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CheckBox showPassword;
        private MetroFramework.Controls.MetroButton closewindw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label required;
        private System.Windows.Forms.Label minLenght;
    }
}