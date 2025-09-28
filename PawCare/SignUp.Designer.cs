namespace PawCare
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            ShowPasswordCheckbox = new CuoreUI.Controls.cuiCheckbox();
            SignupBtn = new CuoreUI.Controls.cuiButton();
            PasswordTextbox = new CuoreUI.Controls.cuiTextBox();
            UsernameTextbox = new CuoreUI.Controls.cuiTextBox();
            PasswordLabel = new CuoreUI.Controls.cuiLabel();
            usernameLabel = new CuoreUI.Controls.cuiLabel();
            LoginBtn = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // cuiPictureBox1
            // 
            cuiPictureBox1.Content = (Image)resources.GetObject("cuiPictureBox1.Content");
            cuiPictureBox1.ImageTint = Color.White;
            cuiPictureBox1.Location = new Point(24, 29);
            cuiPictureBox1.Margin = new Padding(4, 4, 4, 4);
            cuiPictureBox1.Name = "cuiPictureBox1";
            cuiPictureBox1.OutlineThickness = 1F;
            cuiPictureBox1.PanelOutlineColor = Color.Empty;
            cuiPictureBox1.Rotation = 0;
            cuiPictureBox1.Rounding = new Padding(8);
            cuiPictureBox1.Size = new Size(345, 314);
            cuiPictureBox1.TabIndex = 13;
            // 
            // ShowPasswordCheckbox
            // 
            ShowPasswordCheckbox.Checked = false;
            ShowPasswordCheckbox.CheckedForeground = Color.FromArgb(15, 28, 243);
            ShowPasswordCheckbox.CheckedOutlineColor = Color.FromArgb(15, 28, 243);
            ShowPasswordCheckbox.CheckedSymbolColor = Color.White;
            ShowPasswordCheckbox.Content = "Show Password";
            ShowPasswordCheckbox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPasswordCheckbox.Location = new Point(535, 292);
            ShowPasswordCheckbox.Margin = new Padding(3, 2, 3, 2);
            ShowPasswordCheckbox.MinimumSize = new Size(14, 12);
            ShowPasswordCheckbox.Name = "ShowPasswordCheckbox";
            ShowPasswordCheckbox.OutlineStyle = true;
            ShowPasswordCheckbox.OutlineThickness = 1F;
            ShowPasswordCheckbox.Rounding = 4;
            ShowPasswordCheckbox.ShowSymbols = true;
            ShowPasswordCheckbox.Size = new Size(155, 24);
            ShowPasswordCheckbox.TabIndex = 12;
            ShowPasswordCheckbox.Text = "Show Password";
            ShowPasswordCheckbox.UncheckedForeground = Color.Empty;
            ShowPasswordCheckbox.UncheckedOutlineColor = Color.Gray;
            ShowPasswordCheckbox.UncheckedSymbolColor = Color.Empty;
            // 
            // SignupBtn
            // 
            SignupBtn.CheckButton = false;
            SignupBtn.Checked = false;
            SignupBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            SignupBtn.CheckedForeColor = Color.White;
            SignupBtn.CheckedImageTint = Color.White;
            SignupBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            SignupBtn.Content = "Sign Up";
            SignupBtn.DialogResult = DialogResult.None;
            SignupBtn.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignupBtn.ForeColor = Color.White;
            SignupBtn.HoverBackground = Color.FromArgb(15, 28, 243);
            SignupBtn.HoverForeColor = Color.Black;
            SignupBtn.HoverImageTint = Color.White;
            SignupBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            SignupBtn.Image = null;
            SignupBtn.ImageAutoCenter = true;
            SignupBtn.ImageExpand = new Point(0, 0);
            SignupBtn.ImageOffset = new Point(0, 0);
            SignupBtn.Location = new Point(423, 328);
            SignupBtn.Margin = new Padding(3, 2, 3, 2);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.NormalBackground = Color.FromArgb(15, 28, 243);
            SignupBtn.NormalForeColor = Color.White;
            SignupBtn.NormalImageTint = Color.White;
            SignupBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            SignupBtn.OutlineThickness = 1F;
            SignupBtn.PressedBackground = Color.WhiteSmoke;
            SignupBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            SignupBtn.PressedImageTint = Color.White;
            SignupBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            SignupBtn.Rounding = new Padding(8);
            SignupBtn.Size = new Size(191, 44);
            SignupBtn.TabIndex = 11;
            SignupBtn.TextAlignment = StringAlignment.Center;
            SignupBtn.TextOffset = new Point(0, 0);
            SignupBtn.Click += LoginButton_Click;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.BackgroundColor = Color.White;
            PasswordTextbox.Content = "";
            PasswordTextbox.FocusBackgroundColor = Color.White;
            PasswordTextbox.FocusImageTint = Color.White;
            PasswordTextbox.FocusOutlineColor = Color.FromArgb(15, 28, 243);
            PasswordTextbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTextbox.ForeColor = Color.Gray;
            PasswordTextbox.Image = null;
            PasswordTextbox.ImageExpand = new Point(0, 0);
            PasswordTextbox.ImageOffset = new Point(0, 0);
            PasswordTextbox.Location = new Point(375, 244);
            PasswordTextbox.Margin = new Padding(4, 3, 4, 3);
            PasswordTextbox.Multiline = false;
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.NormalImageTint = Color.White;
            PasswordTextbox.OutlineColor = Color.Black;
            PasswordTextbox.Padding = new Padding(16, 13, 16, 0);
            PasswordTextbox.PasswordChar = false;
            PasswordTextbox.PlaceholderColor = SystemColors.WindowText;
            PasswordTextbox.PlaceholderText = "";
            PasswordTextbox.Rounding = new Padding(8);
            PasswordTextbox.Size = new Size(290, 42);
            PasswordTextbox.TabIndex = 10;
            PasswordTextbox.TextOffset = new Size(0, 0);
            PasswordTextbox.UnderlinedStyle = true;
            // 
            // UsernameTextbox
            // 
            UsernameTextbox.BackgroundColor = Color.White;
            UsernameTextbox.Content = "";
            UsernameTextbox.FocusBackgroundColor = Color.White;
            UsernameTextbox.FocusImageTint = Color.White;
            UsernameTextbox.FocusOutlineColor = Color.FromArgb(15, 28, 243);
            UsernameTextbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameTextbox.ForeColor = Color.Black;
            UsernameTextbox.Image = null;
            UsernameTextbox.ImageExpand = new Point(0, 0);
            UsernameTextbox.ImageOffset = new Point(0, 0);
            UsernameTextbox.Location = new Point(375, 150);
            UsernameTextbox.Margin = new Padding(4, 3, 4, 3);
            UsernameTextbox.Multiline = false;
            UsernameTextbox.Name = "UsernameTextbox";
            UsernameTextbox.NormalImageTint = Color.White;
            UsernameTextbox.OutlineColor = Color.Black;
            UsernameTextbox.Padding = new Padding(16, 13, 16, 0);
            UsernameTextbox.PasswordChar = false;
            UsernameTextbox.PlaceholderColor = SystemColors.WindowText;
            UsernameTextbox.PlaceholderText = "";
            UsernameTextbox.Rounding = new Padding(8);
            UsernameTextbox.Size = new Size(290, 42);
            UsernameTextbox.TabIndex = 9;
            UsernameTextbox.TextOffset = new Size(0, 0);
            UsernameTextbox.UnderlinedStyle = true;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Content = "Password";
            PasswordLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordLabel.HorizontalAlignment = StringAlignment.Near;
            PasswordLabel.Location = new Point(375, 224);
            PasswordLabel.Margin = new Padding(4, 4, 4, 4);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(141, 29);
            PasswordLabel.TabIndex = 8;
            PasswordLabel.VerticalAlignment = StringAlignment.Near;
            // 
            // usernameLabel
            // 
            usernameLabel.Content = "Username";
            usernameLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.HorizontalAlignment = StringAlignment.Near;
            usernameLabel.Location = new Point(375, 127);
            usernameLabel.Margin = new Padding(4, 4, 4, 4);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(141, 29);
            usernameLabel.TabIndex = 7;
            usernameLabel.VerticalAlignment = StringAlignment.Near;
            usernameLabel.Load += usernameLabel_Load;
            // 
            // LoginBtn
            // 
            LoginBtn.CheckButton = false;
            LoginBtn.Checked = false;
            LoginBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            LoginBtn.CheckedForeColor = Color.White;
            LoginBtn.CheckedImageTint = Color.White;
            LoginBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            LoginBtn.Content = "Go to Login";
            LoginBtn.DialogResult = DialogResult.None;
            LoginBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            LoginBtn.ForeColor = Color.Black;
            LoginBtn.HoverBackground = Color.White;
            LoginBtn.HoverForeColor = Color.Black;
            LoginBtn.HoverImageTint = Color.White;
            LoginBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            LoginBtn.Image = null;
            LoginBtn.ImageAutoCenter = true;
            LoginBtn.ImageExpand = new Point(0, 0);
            LoginBtn.ImageOffset = new Point(0, 0);
            LoginBtn.Location = new Point(375, 295);
            LoginBtn.Margin = new Padding(3, 2, 3, 2);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.NormalBackground = Color.White;
            LoginBtn.NormalForeColor = Color.Black;
            LoginBtn.NormalImageTint = Color.White;
            LoginBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            LoginBtn.OutlineThickness = 1F;
            LoginBtn.PressedBackground = Color.WhiteSmoke;
            LoginBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            LoginBtn.PressedImageTint = Color.White;
            LoginBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            LoginBtn.Rounding = new Padding(8);
            LoginBtn.Size = new Size(115, 26);
            LoginBtn.TabIndex = 14;
            LoginBtn.TextAlignment = StringAlignment.Center;
            LoginBtn.TextOffset = new Point(0, 0);
            LoginBtn.Click += LoginBtn_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 389);
            Controls.Add(LoginBtn);
            Controls.Add(cuiPictureBox1);
            Controls.Add(ShowPasswordCheckbox);
            Controls.Add(SignupBtn);
            Controls.Add(PasswordTextbox);
            Controls.Add(UsernameTextbox);
            Controls.Add(PasswordLabel);
            Controls.Add(usernameLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiCheckbox ShowPasswordCheckbox;
        private CuoreUI.Controls.cuiButton SignupBtn;
        private CuoreUI.Controls.cuiTextBox PasswordTextbox;
        private CuoreUI.Controls.cuiTextBox UsernameTextbox;
        private CuoreUI.Controls.cuiLabel PasswordLabel;
        private CuoreUI.Controls.cuiLabel usernameLabel;
        private CuoreUI.Controls.cuiButton LoginBtn;
    }
}