
namespace BookManagementProject
{
    partial class ChangePassword
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
            this.UserNameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.oldPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.newpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.changespassowrd = new System.Windows.Forms.Button();
            this.closewindw = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.required = new System.Windows.Forms.Label();
            this.minLenght = new System.Windows.Forms.Label();
            this.minLenghtnewpassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserNameText
            // 
            this.UserNameText.BorderRadius = 20;
            this.UserNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameText.CustomizableEdges = customizableEdges1;
            this.UserNameText.DefaultText = "";
            this.UserNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UserNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UserNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UserNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNameText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserNameText.Location = new System.Drawing.Point(203, 173);
            this.UserNameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserNameText.Name = "UserNameText";
            this.UserNameText.PasswordChar = '\0';
            this.UserNameText.PlaceholderText = "";
            this.UserNameText.SelectedText = "";
            this.UserNameText.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.UserNameText.Size = new System.Drawing.Size(197, 40);
            this.UserNameText.TabIndex = 24;
            this.UserNameText.TextChanged += new System.EventHandler(this.UserNameText_TextChanged);
            // 
            // oldPassword
            // 
            this.oldPassword.BorderRadius = 20;
            this.oldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.oldPassword.CustomizableEdges = customizableEdges3;
            this.oldPassword.DefaultText = "";
            this.oldPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.oldPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.oldPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.oldPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.oldPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.oldPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oldPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.oldPassword.Location = new System.Drawing.Point(203, 257);
            this.oldPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.PasswordChar = '*';
            this.oldPassword.PlaceholderText = "";
            this.oldPassword.SelectedText = "";
            this.oldPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.oldPassword.Size = new System.Drawing.Size(197, 40);
            this.oldPassword.TabIndex = 25;
            this.oldPassword.TextChanged += new System.EventHandler(this.oldPassword_TextChanged);
            // 
            // newpassword
            // 
            this.newpassword.BorderRadius = 20;
            this.newpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newpassword.CustomizableEdges = customizableEdges5;
            this.newpassword.DefaultText = "";
            this.newpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newpassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newpassword.Location = new System.Drawing.Point(203, 335);
            this.newpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newpassword.Name = "newpassword";
            this.newpassword.PasswordChar = '*';
            this.newpassword.PlaceholderText = "";
            this.newpassword.SelectedText = "";
            this.newpassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.newpassword.Size = new System.Drawing.Size(197, 40);
            this.newpassword.TabIndex = 26;
            this.newpassword.TextChanged += new System.EventHandler(this.newpassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Old Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(57, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "New Password";
            // 
            // changespassowrd
            // 
            this.changespassowrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(33)))), ((int)(((byte)(88)))));
            this.changespassowrd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changespassowrd.ForeColor = System.Drawing.Color.White;
            this.changespassowrd.Location = new System.Drawing.Point(148, 450);
            this.changespassowrd.Name = "changespassowrd";
            this.changespassowrd.Size = new System.Drawing.Size(187, 43);
            this.changespassowrd.TabIndex = 30;
            this.changespassowrd.Text = "Change Password";
            this.changespassowrd.UseVisualStyleBackColor = false;
            this.changespassowrd.Click += new System.EventHandler(this.changespassowrd_Click);
            this.changespassowrd.MouseLeave += new System.EventHandler(this.changespassowrd_MouseLeave);
            this.changespassowrd.MouseHover += new System.EventHandler(this.changespassowrd_MouseHover);
            // 
            // closewindw
            // 
            this.closewindw.Location = new System.Drawing.Point(468, 0);
            this.closewindw.Name = "closewindw";
            this.closewindw.Size = new System.Drawing.Size(57, 42);
            this.closewindw.TabIndex = 31;
            this.closewindw.Text = "X";
            this.closewindw.UseSelectable = true;
            this.closewindw.Click += new System.EventHandler(this.closewindw_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookManagementProject.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(176, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // required
            // 
            this.required.AutoSize = true;
            this.required.ForeColor = System.Drawing.Color.Red;
            this.required.Location = new System.Drawing.Point(268, 217);
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
            this.minLenght.Location = new System.Drawing.Point(226, 301);
            this.minLenght.Name = "minLenght";
            this.minLenght.Size = new System.Drawing.Size(152, 20);
            this.minLenght.TabIndex = 35;
            this.minLenght.Text = "Less than 8 characters";
            this.minLenght.Visible = false;
            // 
            // minLenghtnewpassword
            // 
            this.minLenghtnewpassword.AutoSize = true;
            this.minLenghtnewpassword.ForeColor = System.Drawing.Color.Red;
            this.minLenghtnewpassword.Location = new System.Drawing.Point(226, 391);
            this.minLenghtnewpassword.Name = "minLenghtnewpassword";
            this.minLenghtnewpassword.Size = new System.Drawing.Size(152, 20);
            this.minLenghtnewpassword.TabIndex = 36;
            this.minLenghtnewpassword.Text = "Less than 8 characters";
            this.minLenghtnewpassword.Visible = false;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 532);
            this.Controls.Add(this.minLenghtnewpassword);
            this.Controls.Add(this.minLenght);
            this.Controls.Add(this.required);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closewindw);
            this.Controls.Add(this.changespassowrd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newpassword);
            this.Controls.Add(this.oldPassword);
            this.Controls.Add(this.UserNameText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox UserNameText;
        private Guna.UI2.WinForms.Guna2TextBox oldPassword;
        private Guna.UI2.WinForms.Guna2TextBox newpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button changespassowrd;
        private MetroFramework.Controls.MetroButton closewindw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label required;
        private System.Windows.Forms.Label minLenght;
        private System.Windows.Forms.Label minLenghtnewpassword;
    }
}