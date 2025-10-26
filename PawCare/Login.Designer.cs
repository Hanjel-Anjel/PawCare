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
            LoginLabel = new CuoreUI.Controls.cuiLabel();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Content = "Username:";
            usernameLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.HorizontalAlignment = StringAlignment.Near;
            usernameLabel.Location = new Point(236, 198);
            usernameLabel.Margin = new Padding(4);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(141, 15);
            usernameLabel.TabIndex = 0;
            usernameLabel.VerticalAlignment = StringAlignment.Near;
            usernameLabel.Load += usernameLabel_Load;
            // 
            // PasswordLabel
            // 
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Content = "Password:";
            PasswordLabel.Font = new Font("Microsoft Sans Serif", 9.75F);
            PasswordLabel.HorizontalAlignment = StringAlignment.Near;
            PasswordLabel.Location = new Point(236, 272);
            PasswordLabel.Margin = new Padding(4);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(141, 12);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.VerticalAlignment = StringAlignment.Near;
            PasswordLabel.Load += PasswordLabel_Load;
            // 
            // UsernameTextbox
            // 
            UsernameTextbox.BackColor = Color.Transparent;
            UsernameTextbox.BackgroundColor = Color.White;
            UsernameTextbox.Content = "";
            UsernameTextbox.Cursor = Cursors.IBeam;
            UsernameTextbox.FocusBackgroundColor = Color.White;
            UsernameTextbox.FocusImageTint = Color.White;
            UsernameTextbox.FocusOutlineColor = Color.FromArgb(15, 28, 243);
            UsernameTextbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameTextbox.ForeColor = Color.Black;
            UsernameTextbox.Image = null;
            UsernameTextbox.ImageExpand = new Point(0, 0);
            UsernameTextbox.ImageOffset = new Point(0, 0);
            UsernameTextbox.Location = new Point(237, 220);
            UsernameTextbox.Margin = new Padding(4, 3, 4, 3);
            UsernameTextbox.Multiline = false;
            UsernameTextbox.Name = "UsernameTextbox";
            UsernameTextbox.NormalImageTint = Color.White;
            UsernameTextbox.OutlineColor = Color.Black;
            UsernameTextbox.Padding = new Padding(16, 12, 16, 0);
            UsernameTextbox.PasswordChar = false;
            UsernameTextbox.PlaceholderColor = SystemColors.WindowText;
            UsernameTextbox.PlaceholderText = "";
            UsernameTextbox.Rounding = new Padding(8);
            UsernameTextbox.Size = new Size(308, 40);
            UsernameTextbox.TabIndex = 2;
            UsernameTextbox.TextOffset = new Size(0, 0);
            UsernameTextbox.UnderlinedStyle = false;
            UsernameTextbox.ContentChanged += UsernameTextbox_ContentChanged;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.BackColor = Color.Transparent;
            PasswordTextbox.BackgroundColor = Color.White;
            PasswordTextbox.Content = "";
            PasswordTextbox.Cursor = Cursors.IBeam;
            PasswordTextbox.FocusBackgroundColor = Color.White;
            PasswordTextbox.FocusImageTint = Color.White;
            PasswordTextbox.FocusOutlineColor = Color.FromArgb(15, 28, 243);
            PasswordTextbox.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTextbox.ForeColor = Color.Black;
            PasswordTextbox.Image = null;
            PasswordTextbox.ImageExpand = new Point(0, 0);
            PasswordTextbox.ImageOffset = new Point(0, 0);
            PasswordTextbox.Location = new Point(237, 291);
            PasswordTextbox.Margin = new Padding(4, 3, 4, 3);
            PasswordTextbox.Multiline = false;
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.NormalImageTint = Color.White;
            PasswordTextbox.OutlineColor = Color.Black;
            PasswordTextbox.Padding = new Padding(16, 12, 16, 0);
            PasswordTextbox.PasswordChar = true;
            PasswordTextbox.PlaceholderColor = SystemColors.WindowText;
            PasswordTextbox.PlaceholderText = "";
            PasswordTextbox.Rounding = new Padding(8);
            PasswordTextbox.Size = new Size(308, 40);
            PasswordTextbox.TabIndex = 3;
            PasswordTextbox.TextOffset = new Size(0, 0);
            PasswordTextbox.UnderlinedStyle = false;
            PasswordTextbox.ContentChanged += PasswordTextbox_ContentChanged;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Transparent;
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
            LoginButton.Location = new Point(286, 372);
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
            LoginButton.Size = new Size(218, 40);
            LoginButton.TabIndex = 4;
            LoginButton.TextAlignment = StringAlignment.Center;
            LoginButton.TextOffset = new Point(0, 0);
            LoginButton.Click += LoginButton_Click;
            // 
            // ShowPasswordCheckbox
            // 
            ShowPasswordCheckbox.BackColor = Color.FromArgb(210, 211, 221);
            ShowPasswordCheckbox.BackgroundImageLayout = ImageLayout.None;
            ShowPasswordCheckbox.Checked = false;
            ShowPasswordCheckbox.CheckedForeground = Color.FromArgb(15, 28, 243);
            ShowPasswordCheckbox.CheckedOutlineColor = Color.FromArgb(15, 28, 243);
            ShowPasswordCheckbox.CheckedSymbolColor = Color.White;
            ShowPasswordCheckbox.Content = "Show Password";
            ShowPasswordCheckbox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPasswordCheckbox.Location = new Point(436, 336);
            ShowPasswordCheckbox.Margin = new Padding(3, 2, 3, 2);
            ShowPasswordCheckbox.MinimumSize = new Size(14, 12);
            ShowPasswordCheckbox.Name = "ShowPasswordCheckbox";
            ShowPasswordCheckbox.OutlineStyle = true;
            ShowPasswordCheckbox.OutlineThickness = 1F;
            ShowPasswordCheckbox.Rounding = 4;
            ShowPasswordCheckbox.ShowSymbols = true;
            ShowPasswordCheckbox.Size = new Size(107, 15);
            ShowPasswordCheckbox.TabIndex = 5;
            ShowPasswordCheckbox.Text = "Show Password";
            ShowPasswordCheckbox.UncheckedForeground = Color.Empty;
            ShowPasswordCheckbox.UncheckedOutlineColor = Color.Gray;
            ShowPasswordCheckbox.UncheckedSymbolColor = Color.Empty;
            ShowPasswordCheckbox.CheckedChanged += ShowPasswordCheckbox_CheckedChanged;
            // 
            // LoginLabel
            // 
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.Content = "Login";
            LoginLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLabel.HorizontalAlignment = StringAlignment.Center;
            LoginLabel.Location = new Point(237, 173);
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
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(774, 483);
            Controls.Add(usernameLabel);
            Controls.Add(LoginLabel);
            Controls.Add(ShowPasswordCheckbox);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextbox);
            Controls.Add(UsernameTextbox);
            Controls.Add(PasswordLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
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
        private CuoreUI.Controls.cuiLabel LoginLabel;
    }
}
