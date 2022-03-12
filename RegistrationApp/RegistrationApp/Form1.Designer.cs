namespace RegistrationApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.passwdTxt = new System.Windows.Forms.TextBox();
            this.confirmPasswdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.infoList = new System.Windows.Forms.ListBox();
            this.capsLockImg = new System.Windows.Forms.PictureBox();
            this.showPasswdImg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capsLockImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswdImg)).BeginInit();
            this.SuspendLayout();
            // 
            // mailTxt
            // 
            this.mailTxt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailTxt.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mailTxt.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.mailTxt.Location = new System.Drawing.Point(50, 50);
            this.mailTxt.MaxLength = 32;
            this.mailTxt.Multiline = true;
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(712, 46);
            this.mailTxt.TabIndex = 0;
            this.mailTxt.Text = "E-mail Address";
            this.mailTxt.Click += new System.EventHandler(this.mailTxt_Click);
            this.mailTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mailTxt_KeyDown);
            // 
            // userNameTxt
            // 
            this.userNameTxt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.userNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTxt.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameTxt.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.userNameTxt.Location = new System.Drawing.Point(50, 150);
            this.userNameTxt.MaxLength = 16;
            this.userNameTxt.Multiline = true;
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(564, 46);
            this.userNameTxt.TabIndex = 1;
            this.userNameTxt.Text = "Username";
            this.userNameTxt.Click += new System.EventHandler(this.userNameTxt_Click);
            this.userNameTxt.TextChanged += new System.EventHandler(this.userNameTxt_TextChanged);
            this.userNameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mailTxt_KeyDown);
            // 
            // passwdTxt
            // 
            this.passwdTxt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.passwdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwdTxt.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwdTxt.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.passwdTxt.Location = new System.Drawing.Point(50, 250);
            this.passwdTxt.MaxLength = 16;
            this.passwdTxt.Multiline = true;
            this.passwdTxt.Name = "passwdTxt";
            this.passwdTxt.Size = new System.Drawing.Size(566, 46);
            this.passwdTxt.TabIndex = 2;
            this.passwdTxt.Text = "Password";
            this.passwdTxt.Click += new System.EventHandler(this.passwdTxt_Click);
            this.passwdTxt.TextChanged += new System.EventHandler(this.passwdTxt_TextChanged);
            this.passwdTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwdTxt_KeyDown);
            // 
            // confirmPasswdTxt
            // 
            this.confirmPasswdTxt.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.confirmPasswdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmPasswdTxt.Font = new System.Drawing.Font("Modern No. 20", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmPasswdTxt.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.confirmPasswdTxt.Location = new System.Drawing.Point(50, 350);
            this.confirmPasswdTxt.MaxLength = 16;
            this.confirmPasswdTxt.Multiline = true;
            this.confirmPasswdTxt.Name = "confirmPasswdTxt";
            this.confirmPasswdTxt.Size = new System.Drawing.Size(564, 46);
            this.confirmPasswdTxt.TabIndex = 3;
            this.confirmPasswdTxt.Text = "Confirm Password";
            this.confirmPasswdTxt.Click += new System.EventHandler(this.confirmPasswdTxt_Click);
            this.confirmPasswdTxt.TextChanged += new System.EventHandler(this.confirmPasswdTxt_TextChanged);
            this.confirmPasswdTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.confirmPasswdTxt_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(430, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sign Up";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.infoList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 539);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 140);
            this.panel1.TabIndex = 5;
            // 
            // infoList
            // 
            this.infoList.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.infoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoList.Font = new System.Drawing.Font("Modern No. 20", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoList.FormattingEnabled = true;
            this.infoList.ItemHeight = 38;
            this.infoList.Location = new System.Drawing.Point(0, 0);
            this.infoList.Name = "infoList";
            this.infoList.Size = new System.Drawing.Size(974, 140);
            this.infoList.TabIndex = 0;
            // 
            // capsLockImg
            // 
            this.capsLockImg.Image = ((System.Drawing.Image)(resources.GetObject("capsLockImg.Image")));
            this.capsLockImg.Location = new System.Drawing.Point(375, 343);
            this.capsLockImg.Name = "capsLockImg";
            this.capsLockImg.Size = new System.Drawing.Size(60, 50);
            this.capsLockImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.capsLockImg.TabIndex = 6;
            this.capsLockImg.TabStop = false;
            // 
            // showPasswdImg
            // 
            this.showPasswdImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPasswdImg.Image = ((System.Drawing.Image)(resources.GetObject("showPasswdImg.Image")));
            this.showPasswdImg.Location = new System.Drawing.Point(455, 343);
            this.showPasswdImg.Name = "showPasswdImg";
            this.showPasswdImg.Size = new System.Drawing.Size(60, 50);
            this.showPasswdImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPasswdImg.TabIndex = 7;
            this.showPasswdImg.TabStop = false;
            this.showPasswdImg.Click += new System.EventHandler(this.showPasswdImg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(974, 679);
            this.Controls.Add(this.showPasswdImg);
            this.Controls.Add(this.capsLockImg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmPasswdTxt);
            this.Controls.Add(this.passwdTxt);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.mailTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.capsLockImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswdImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox mailTxt;
        private TextBox userNameTxt;
        private TextBox passwdTxt;
        private TextBox confirmPasswdTxt;
        private Label label1;
        private Panel panel1;
        private ListBox infoList;
        private PictureBox capsLockImg;
        private PictureBox showPasswdImg;
    }
}