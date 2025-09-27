namespace PawCare
{
    partial class CustomerContactForm
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
            CustomerNameLabel = new CuoreUI.Controls.cuiLabel();
            ContactNumbertxtBox = new CuoreUI.Controls.cuiTextBox();
            EmailtxtBox = new CuoreUI.Controls.cuiTextBox();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            NextBtn = new CuoreUI.Controls.cuiButton();
            BackBtn = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.Content = "Customer\\ Contacts";
            CustomerNameLabel.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerNameLabel.HorizontalAlignment = StringAlignment.Near;
            CustomerNameLabel.Location = new Point(122, 81);
            CustomerNameLabel.Margin = new Padding(4);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(306, 40);
            CustomerNameLabel.TabIndex = 3;
            CustomerNameLabel.VerticalAlignment = StringAlignment.Near;
            // 
            // ContactNumbertxtBox
            // 
            ContactNumbertxtBox.BackgroundColor = Color.White;
            ContactNumbertxtBox.Content = "";
            ContactNumbertxtBox.FocusBackgroundColor = Color.White;
            ContactNumbertxtBox.FocusImageTint = Color.White;
            ContactNumbertxtBox.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            ContactNumbertxtBox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContactNumbertxtBox.ForeColor = Color.Gray;
            ContactNumbertxtBox.Image = null;
            ContactNumbertxtBox.ImageExpand = new Point(0, 0);
            ContactNumbertxtBox.ImageOffset = new Point(0, 0);
            ContactNumbertxtBox.Location = new Point(122, 203);
            ContactNumbertxtBox.Margin = new Padding(4, 3, 4, 3);
            ContactNumbertxtBox.Multiline = false;
            ContactNumbertxtBox.Name = "ContactNumbertxtBox";
            ContactNumbertxtBox.NormalImageTint = Color.White;
            ContactNumbertxtBox.OutlineColor = Color.Black;
            ContactNumbertxtBox.Padding = new Padding(15, 18, 15, 0);
            ContactNumbertxtBox.PasswordChar = false;
            ContactNumbertxtBox.PlaceholderColor = SystemColors.WindowText;
            ContactNumbertxtBox.PlaceholderText = "";
            ContactNumbertxtBox.Rounding = new Padding(8);
            ContactNumbertxtBox.Size = new Size(362, 50);
            ContactNumbertxtBox.TabIndex = 4;
            ContactNumbertxtBox.TextOffset = new Size(0, 0);
            ContactNumbertxtBox.UnderlinedStyle = false;
            ContactNumbertxtBox.ContentChanged += ContactNumbertxtBox_ContentChanged;
            // 
            // EmailtxtBox
            // 
            EmailtxtBox.BackgroundColor = Color.White;
            EmailtxtBox.Content = "";
            EmailtxtBox.FocusBackgroundColor = Color.White;
            EmailtxtBox.FocusImageTint = Color.White;
            EmailtxtBox.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            EmailtxtBox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailtxtBox.ForeColor = Color.Gray;
            EmailtxtBox.Image = null;
            EmailtxtBox.ImageExpand = new Point(0, 0);
            EmailtxtBox.ImageOffset = new Point(0, 0);
            EmailtxtBox.Location = new Point(122, 294);
            EmailtxtBox.Margin = new Padding(4, 3, 4, 3);
            EmailtxtBox.Multiline = false;
            EmailtxtBox.Name = "EmailtxtBox";
            EmailtxtBox.NormalImageTint = Color.White;
            EmailtxtBox.OutlineColor = Color.Black;
            EmailtxtBox.Padding = new Padding(15, 18, 15, 0);
            EmailtxtBox.PasswordChar = false;
            EmailtxtBox.PlaceholderColor = SystemColors.WindowText;
            EmailtxtBox.PlaceholderText = "";
            EmailtxtBox.Rounding = new Padding(8);
            EmailtxtBox.Size = new Size(362, 50);
            EmailtxtBox.TabIndex = 5;
            EmailtxtBox.TextOffset = new Size(0, 0);
            EmailtxtBox.UnderlinedStyle = false;
            // 
            // cuiLabel4
            // 
            cuiLabel4.Content = "Contact\\ Number\\ ";
            cuiLabel4.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel4.HorizontalAlignment = StringAlignment.Near;
            cuiLabel4.Location = new Point(122, 171);
            cuiLabel4.Margin = new Padding(4);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(178, 26);
            cuiLabel4.TabIndex = 6;
            cuiLabel4.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Email\\ Address";
            cuiLabel1.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = StringAlignment.Near;
            cuiLabel1.Location = new Point(122, 267);
            cuiLabel1.Margin = new Padding(4);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(122, 21);
            cuiLabel1.TabIndex = 7;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // NextBtn
            // 
            NextBtn.CheckButton = false;
            NextBtn.Checked = false;
            NextBtn.CheckedBackground = Color.FromArgb(15, 28, 243);
            NextBtn.CheckedForeColor = Color.White;
            NextBtn.CheckedImageTint = Color.White;
            NextBtn.CheckedOutline = Color.FromArgb(15, 28, 243);
            NextBtn.Content = "Next";
            NextBtn.DialogResult = DialogResult.None;
            NextBtn.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NextBtn.ForeColor = Color.White;
            NextBtn.HoverBackground = Color.FromArgb(15, 28, 243);
            NextBtn.HoverForeColor = Color.Black;
            NextBtn.HoverImageTint = Color.White;
            NextBtn.HoverOutline = Color.Black;
            NextBtn.Image = null;
            NextBtn.ImageAutoCenter = true;
            NextBtn.ImageExpand = new Point(0, 0);
            NextBtn.ImageOffset = new Point(0, 0);
            NextBtn.Location = new Point(339, 431);
            NextBtn.Name = "NextBtn";
            NextBtn.NormalBackground = Color.FromArgb(15, 28, 243);
            NextBtn.NormalForeColor = Color.White;
            NextBtn.NormalImageTint = Color.White;
            NextBtn.NormalOutline = Color.Black;
            NextBtn.OutlineThickness = 1F;
            NextBtn.PressedBackground = Color.WhiteSmoke;
            NextBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            NextBtn.PressedImageTint = Color.White;
            NextBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            NextBtn.Rounding = new Padding(20);
            NextBtn.Size = new Size(156, 50);
            NextBtn.TabIndex = 16;
            NextBtn.TextAlignment = StringAlignment.Center;
            NextBtn.TextOffset = new Point(0, 0);
            NextBtn.Click += NextBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.CheckButton = false;
            BackBtn.Checked = false;
            BackBtn.CheckedBackground = Color.FromArgb(15, 28, 243);
            BackBtn.CheckedForeColor = Color.White;
            BackBtn.CheckedImageTint = Color.White;
            BackBtn.CheckedOutline = Color.FromArgb(15, 28, 243);
            BackBtn.Content = "Back";
            BackBtn.DialogResult = DialogResult.None;
            BackBtn.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackBtn.ForeColor = Color.Black;
            BackBtn.HoverBackground = Color.Red;
            BackBtn.HoverForeColor = Color.Black;
            BackBtn.HoverImageTint = Color.White;
            BackBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            BackBtn.Image = null;
            BackBtn.ImageAutoCenter = true;
            BackBtn.ImageExpand = new Point(0, 0);
            BackBtn.ImageOffset = new Point(0, 0);
            BackBtn.Location = new Point(113, 431);
            BackBtn.Name = "BackBtn";
            BackBtn.NormalBackground = Color.White;
            BackBtn.NormalForeColor = Color.Black;
            BackBtn.NormalImageTint = Color.White;
            BackBtn.NormalOutline = Color.Black;
            BackBtn.OutlineThickness = 1F;
            BackBtn.PressedBackground = Color.WhiteSmoke;
            BackBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            BackBtn.PressedImageTint = Color.White;
            BackBtn.PressedOutline = Color.Black;
            BackBtn.Rounding = new Padding(20);
            BackBtn.Size = new Size(156, 50);
            BackBtn.TabIndex = 15;
            BackBtn.TextAlignment = StringAlignment.Center;
            BackBtn.TextOffset = new Point(0, 0);
            BackBtn.Click += BackBtn_Click;
            // 
            // CustomerContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(629, 637);
            Controls.Add(NextBtn);
            Controls.Add(BackBtn);
            Controls.Add(cuiLabel1);
            Controls.Add(cuiLabel4);
            Controls.Add(EmailtxtBox);
            Controls.Add(ContactNumbertxtBox);
            Controls.Add(CustomerNameLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CustomerContactForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerContactForm";
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiLabel CustomerNameLabel;
        private CuoreUI.Controls.cuiTextBox ContactNumbertxtBox;
        private CuoreUI.Controls.cuiTextBox EmailtxtBox;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiButton NextBtn;
        private CuoreUI.Controls.cuiButton BackBtn;
    }
}