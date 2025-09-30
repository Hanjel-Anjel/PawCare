namespace PawCare
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            usernameLabel = new CuoreUI.Controls.cuiLabel();
            PasswordLabel = new CuoreUI.Controls.cuiLabel();
            UsernameTextbox = new CuoreUI.Controls.cuiTextBox();
            PasswordTextbox = new CuoreUI.Controls.cuiTextBox();
            LoginButton = new CuoreUI.Controls.cuiButton();
            ShowPasswordCheckbox = new CuoreUI.Controls.cuiCheckbox();
            cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            SignupBtn = new CuoreUI.Controls.cuiButton();
            LoginLabel = new CuoreUI.Controls.cuiLabel();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.Content = "Username";
            usernameLabel.Font = new Font("Microsoft Sans Serif", 14.25F);
            usernameLabel.HorizontalAlignment = StringAlignment.Near;
            usernameLabel.Location = new Point(393, 124);
            usernameLabel.Margin = new Padding(4);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(141, 29);
            usernameLabel.TabIndex = 0;
            usernameLabel.VerticalAlignment = StringAlignment.Near;
            usernameLabel.Load += usernameLabel_Load;
            // 
            // PasswordLabel
            // 
            PasswordLabel.Content = "Password";
            PasswordLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLabel.HorizontalAlignment = StringAlignment.Near;
            PasswordLabel.Location = new Point(392, 243);
            PasswordLabel.Margin = new Padding(4);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(141, 29);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.VerticalAlignment = StringAlignment.Near;
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
            UsernameTextbox.Location = new Point(393, 160);
            UsernameTextbox.Margin = new Padding(4, 3, 4, 3);
            UsernameTextbox.Multiline = false;
            UsernameTextbox.Name = "UsernameTextbox";
            UsernameTextbox.NormalImageTint = Color.White;
            UsernameTextbox.OutlineColor = Color.Black;
            UsernameTextbox.Padding = new Padding(16, 19, 16, 0);
            UsernameTextbox.PasswordChar = false;
            UsernameTextbox.PlaceholderColor = SystemColors.WindowText;
            UsernameTextbox.PlaceholderText = "";
            UsernameTextbox.Rounding = new Padding(8);
            UsernameTextbox.Size = new Size(308, 55);
            UsernameTextbox.TabIndex = 2;
            UsernameTextbox.TextOffset = new Size(0, 0);
            UsernameTextbox.UnderlinedStyle = false;
            UsernameTextbox.ContentChanged += UsernameTextbox_ContentChanged;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.BackgroundColor = Color.White;
            PasswordTextbox.Content = "";
            PasswordTextbox.FocusBackgroundColor = Color.White;
            PasswordTextbox.FocusImageTint = Color.White;
            PasswordTextbox.FocusOutlineColor = Color.FromArgb(15, 28, 243);
            PasswordTextbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTextbox.ForeColor = Color.Black;
            PasswordTextbox.Image = null;
            PasswordTextbox.ImageExpand = new Point(0, 0);
            PasswordTextbox.ImageOffset = new Point(0, 0);
            PasswordTextbox.Location = new Point(392, 279);
            PasswordTextbox.Margin = new Padding(4, 3, 4, 3);
            PasswordTextbox.Multiline = false;
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.NormalImageTint = Color.White;
            PasswordTextbox.OutlineColor = Color.Black;
            PasswordTextbox.Padding = new Padding(16, 19, 16, 0);
            PasswordTextbox.PasswordChar = false;
            PasswordTextbox.PlaceholderColor = SystemColors.WindowText;
            PasswordTextbox.PlaceholderText = "";
            PasswordTextbox.Rounding = new Padding(8);
            PasswordTextbox.Size = new Size(308, 55);
            PasswordTextbox.TabIndex = 3;
            PasswordTextbox.TextOffset = new Size(0, 0);
            PasswordTextbox.UnderlinedStyle = false;
            PasswordTextbox.ContentChanged += PasswordTextbox_ContentChanged;
            // 
            // LoginButton
            // 
            LoginButton.CheckButton = false;
            LoginButton.Checked = false;
            LoginButton.CheckedBackground = Color.FromArgb(15, 28, 243);
            LoginButton.CheckedForeColor = Color.White;
            LoginButton.CheckedImageTint = Color.White;
            LoginButton.CheckedOutline = Color.FromArgb(15, 28, 243);
            LoginButton.Content = "Login";
            LoginButton.DialogResult = DialogResult.None;
            LoginButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = Color.White;
            LoginButton.HoverBackground = Color.FromArgb(15, 28, 243);
            LoginButton.HoverForeColor = Color.Black;
            LoginButton.HoverImageTint = Color.White;
            LoginButton.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            LoginButton.Image = null;
            LoginButton.ImageAutoCenter = true;
            LoginButton.ImageExpand = new Point(0, 0);
            LoginButton.ImageOffset = new Point(0, 0);
            LoginButton.Location = new Point(433, 419);
            LoginButton.Margin = new Padding(3, 2, 3, 2);
            LoginButton.Name = "LoginButton";
            LoginButton.NormalBackground = Color.FromArgb(15, 28, 243);
            LoginButton.NormalForeColor = Color.White;
            LoginButton.NormalImageTint = Color.White;
            LoginButton.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            LoginButton.OutlineThickness = 1F;
            LoginButton.PressedBackground = Color.WhiteSmoke;
            LoginButton.PressedForeColor = Color.FromArgb(32, 32, 32);
            LoginButton.PressedImageTint = Color.White;
            LoginButton.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            LoginButton.Rounding = new Padding(8);
            LoginButton.Size = new Size(218, 53);
            LoginButton.TabIndex = 4;
            LoginButton.TextAlignment = StringAlignment.Center;
            LoginButton.TextOffset = new Point(0, 0);
            LoginButton.Click += LoginButton_Click;
            // 
            // ShowPasswordCheckbox
            // 
            ShowPasswordCheckbox.Checked = false;
            ShowPasswordCheckbox.CheckedForeground = Color.FromArgb(15, 28, 243);
            ShowPasswordCheckbox.CheckedOutlineColor = Color.FromArgb(15, 28, 243);
            ShowPasswordCheckbox.CheckedSymbolColor = Color.White;
            ShowPasswordCheckbox.Content = "Show Password";
            ShowPasswordCheckbox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPasswordCheckbox.Location = new Point(570, 369);
            ShowPasswordCheckbox.Margin = new Padding(3, 2, 3, 2);
            ShowPasswordCheckbox.MinimumSize = new Size(14, 12);
            ShowPasswordCheckbox.Name = "ShowPasswordCheckbox";
            ShowPasswordCheckbox.OutlineStyle = true;
            ShowPasswordCheckbox.OutlineThickness = 1F;
            ShowPasswordCheckbox.Rounding = 4;
            ShowPasswordCheckbox.ShowSymbols = true;
            ShowPasswordCheckbox.Size = new Size(130, 24);
            ShowPasswordCheckbox.TabIndex = 5;
            ShowPasswordCheckbox.Text = "Show Password";
            ShowPasswordCheckbox.UncheckedForeground = Color.Empty;
            ShowPasswordCheckbox.UncheckedOutlineColor = Color.Gray;
            ShowPasswordCheckbox.UncheckedSymbolColor = Color.Empty;
            ShowPasswordCheckbox.CheckedChanged += ShowPasswordCheckbox_CheckedChanged;
            // 
            // cuiPictureBox1
            // 
            cuiPictureBox1.Content = (Image)resources.GetObject("cuiPictureBox1.Content");
            cuiPictureBox1.ImageTint = Color.White;
            cuiPictureBox1.Location = new Point(13, 79);
            cuiPictureBox1.Margin = new Padding(4);
            cuiPictureBox1.Name = "cuiPictureBox1";
            cuiPictureBox1.OutlineThickness = 1F;
            cuiPictureBox1.PanelOutlineColor = Color.Empty;
            cuiPictureBox1.Rotation = 0;
            cuiPictureBox1.Rounding = new Padding(8);
            cuiPictureBox1.Size = new Size(345, 314);
            cuiPictureBox1.TabIndex = 6;
            // 
            // SignupBtn
            // 
            SignupBtn.CheckButton = false;
            SignupBtn.Checked = false;
            SignupBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            SignupBtn.CheckedForeColor = Color.White;
            SignupBtn.CheckedImageTint = Color.White;
            SignupBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            SignupBtn.Content = "Go to Admin";
            SignupBtn.DialogResult = DialogResult.None;
            SignupBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            SignupBtn.ForeColor = Color.Black;
            SignupBtn.HoverBackground = Color.White;
            SignupBtn.HoverForeColor = Color.Black;
            SignupBtn.HoverImageTint = Color.White;
            SignupBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            SignupBtn.Image = null;
            SignupBtn.ImageAutoCenter = true;
            SignupBtn.ImageExpand = new Point(0, 0);
            SignupBtn.ImageOffset = new Point(0, 0);
            SignupBtn.Location = new Point(393, 369);
            SignupBtn.Margin = new Padding(3, 2, 3, 2);
            SignupBtn.Name = "SignupBtn";
            SignupBtn.NormalBackground = Color.White;
            SignupBtn.NormalForeColor = Color.Black;
            SignupBtn.NormalImageTint = Color.White;
            SignupBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            SignupBtn.OutlineThickness = 1F;
            SignupBtn.PressedBackground = Color.WhiteSmoke;
            SignupBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            SignupBtn.PressedImageTint = Color.White;
            SignupBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            SignupBtn.Rounding = new Padding(8);
            SignupBtn.Size = new Size(103, 24);
            SignupBtn.TabIndex = 7;
            SignupBtn.TextAlignment = StringAlignment.Center;
            SignupBtn.TextOffset = new Point(0, 0);
            SignupBtn.Click += SignupBtn_Click;
            // 
            // LoginLabel
            // 
            LoginLabel.Content = "Login";
            LoginLabel.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLabel.HorizontalAlignment = StringAlignment.Center;
            LoginLabel.Location = new Point(392, 53);
            LoginLabel.Margin = new Padding(4);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(306, 40);
            LoginLabel.TabIndex = 8;
            LoginLabel.VerticalAlignment = StringAlignment.Near;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(774, 483);
            Controls.Add(LoginLabel);
            Controls.Add(SignupBtn);
            Controls.Add(cuiPictureBox1);
            Controls.Add(ShowPasswordCheckbox);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextbox);
            Controls.Add(UsernameTextbox);
            Controls.Add(PasswordLabel);
            Controls.Add(usernameLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiLabel usernameLabel;
        private CuoreUI.Controls.cuiLabel PasswordLabel;
        private CuoreUI.Controls.cuiTextBox UsernameTextbox;
        private CuoreUI.Controls.cuiTextBox PasswordTextbox;
        private CuoreUI.Controls.cuiButton LoginButton;
        private CuoreUI.Controls.cuiCheckbox ShowPasswordCheckbox;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiButton SignupBtn;
        private CuoreUI.Controls.cuiLabel LoginLabel;
    }
}
