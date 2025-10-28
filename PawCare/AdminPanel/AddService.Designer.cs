namespace PawCare.AdminPanel
{
    partial class AddService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddService));
            DescriptiontxtBox = new CuoreUI.Controls.cuiTextBox();
            ServiceNametxtBox = new CuoreUI.Controls.cuiTextBox();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            ServiceLabel = new CuoreUI.Controls.cuiLabel();
            PricetxtBox = new CuoreUI.Controls.cuiTextBox();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            SaveBtn = new CuoreUI.Controls.cuiButton();
            BackBtn = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // DescriptiontxtBox
            // 
            DescriptiontxtBox.BackColor = Color.Transparent;
            DescriptiontxtBox.BackgroundColor = Color.White;
            DescriptiontxtBox.Content = "";
            DescriptiontxtBox.FocusBackgroundColor = Color.White;
            DescriptiontxtBox.FocusImageTint = Color.White;
            DescriptiontxtBox.FocusOutlineColor = Color.FromArgb(15, 28, 243);
            DescriptiontxtBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            DescriptiontxtBox.ForeColor = Color.Black;
            DescriptiontxtBox.Image = null;
            DescriptiontxtBox.ImageExpand = new Point(0, 0);
            DescriptiontxtBox.ImageOffset = new Point(0, 0);
            DescriptiontxtBox.Location = new Point(238, 220);
            DescriptiontxtBox.Margin = new Padding(4, 3, 4, 3);
            DescriptiontxtBox.Multiline = false;
            DescriptiontxtBox.Name = "DescriptiontxtBox";
            DescriptiontxtBox.NormalImageTint = Color.White;
            DescriptiontxtBox.OutlineColor = Color.Black;
            DescriptiontxtBox.Padding = new Padding(17, 14, 17, 0);
            DescriptiontxtBox.PasswordChar = false;
            DescriptiontxtBox.PlaceholderColor = SystemColors.WindowText;
            DescriptiontxtBox.PlaceholderText = "";
            DescriptiontxtBox.Rounding = new Padding(8);
            DescriptiontxtBox.Size = new Size(308, 45);
            DescriptiontxtBox.TabIndex = 30;
            DescriptiontxtBox.TextOffset = new Size(0, 0);
            DescriptiontxtBox.UnderlinedStyle = false;
            DescriptiontxtBox.ContentChanged += DescriptiontxtBox_ContentChanged;
            // 
            // ServiceNametxtBox
            // 
            ServiceNametxtBox.BackColor = Color.Transparent;
            ServiceNametxtBox.BackgroundColor = Color.White;
            ServiceNametxtBox.Content = "";
            ServiceNametxtBox.FocusBackgroundColor = Color.White;
            ServiceNametxtBox.FocusImageTint = Color.White;
            ServiceNametxtBox.FocusOutlineColor = Color.FromArgb(15, 28, 243);
            ServiceNametxtBox.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ServiceNametxtBox.ForeColor = Color.Black;
            ServiceNametxtBox.Image = null;
            ServiceNametxtBox.ImageExpand = new Point(0, 0);
            ServiceNametxtBox.ImageOffset = new Point(0, 0);
            ServiceNametxtBox.Location = new Point(238, 144);
            ServiceNametxtBox.Margin = new Padding(4, 3, 4, 3);
            ServiceNametxtBox.Multiline = false;
            ServiceNametxtBox.Name = "ServiceNametxtBox";
            ServiceNametxtBox.NormalImageTint = Color.White;
            ServiceNametxtBox.OutlineColor = Color.Black;
            ServiceNametxtBox.Padding = new Padding(17, 14, 17, 0);
            ServiceNametxtBox.PasswordChar = false;
            ServiceNametxtBox.PlaceholderColor = SystemColors.WindowText;
            ServiceNametxtBox.PlaceholderText = "";
            ServiceNametxtBox.Rounding = new Padding(8);
            ServiceNametxtBox.Size = new Size(308, 45);
            ServiceNametxtBox.TabIndex = 29;
            ServiceNametxtBox.TextOffset = new Size(0, 0);
            ServiceNametxtBox.UnderlinedStyle = false;
            ServiceNametxtBox.ContentChanged += ServiceNametxtBox_ContentChanged;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.Transparent;
            cuiLabel2.Content = "Service\\ Description";
            cuiLabel2.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiLabel2.ForeColor = Color.MidnightBlue;
            cuiLabel2.HorizontalAlignment = StringAlignment.Near;
            cuiLabel2.Location = new Point(238, 196);
            cuiLabel2.Margin = new Padding(4);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(122, 26);
            cuiLabel2.TabIndex = 27;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Service\\ Name";
            cuiLabel1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiLabel1.ForeColor = Color.MidnightBlue;
            cuiLabel1.HorizontalAlignment = StringAlignment.Near;
            cuiLabel1.Location = new Point(238, 121);
            cuiLabel1.Margin = new Padding(4);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(122, 26);
            cuiLabel1.TabIndex = 26;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // ServiceLabel
            // 
            ServiceLabel.BackColor = Color.Transparent;
            ServiceLabel.Content = "Service";
            ServiceLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ServiceLabel.ForeColor = Color.MidnightBlue;
            ServiceLabel.HorizontalAlignment = StringAlignment.Center;
            ServiceLabel.Location = new Point(295, 67);
            ServiceLabel.Margin = new Padding(4);
            ServiceLabel.Name = "ServiceLabel";
            ServiceLabel.Size = new Size(212, 29);
            ServiceLabel.TabIndex = 32;
            ServiceLabel.VerticalAlignment = StringAlignment.Near;
            // 
            // PricetxtBox
            // 
            PricetxtBox.BackColor = Color.Transparent;
            PricetxtBox.BackgroundColor = Color.White;
            PricetxtBox.Content = "";
            PricetxtBox.FocusBackgroundColor = Color.White;
            PricetxtBox.FocusImageTint = Color.White;
            PricetxtBox.FocusOutlineColor = Color.FromArgb(15, 28, 243);
            PricetxtBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            PricetxtBox.ForeColor = Color.Black;
            PricetxtBox.Image = null;
            PricetxtBox.ImageExpand = new Point(0, 0);
            PricetxtBox.ImageOffset = new Point(0, 0);
            PricetxtBox.Location = new Point(238, 304);
            PricetxtBox.Margin = new Padding(4, 3, 4, 3);
            PricetxtBox.Multiline = false;
            PricetxtBox.Name = "PricetxtBox";
            PricetxtBox.NormalImageTint = Color.White;
            PricetxtBox.OutlineColor = Color.Black;
            PricetxtBox.Padding = new Padding(17, 14, 17, 0);
            PricetxtBox.PasswordChar = false;
            PricetxtBox.PlaceholderColor = SystemColors.WindowText;
            PricetxtBox.PlaceholderText = "";
            PricetxtBox.Rounding = new Padding(8);
            PricetxtBox.Size = new Size(308, 45);
            PricetxtBox.TabIndex = 31;
            PricetxtBox.TextOffset = new Size(0, 0);
            PricetxtBox.UnderlinedStyle = false;
            PricetxtBox.ContentChanged += PricetxtBox_ContentChanged;
            // 
            // cuiLabel3
            // 
            cuiLabel3.BackColor = Color.Transparent;
            cuiLabel3.Content = "Price";
            cuiLabel3.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiLabel3.ForeColor = Color.MidnightBlue;
            cuiLabel3.HorizontalAlignment = StringAlignment.Near;
            cuiLabel3.Location = new Point(238, 275);
            cuiLabel3.Margin = new Padding(4);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(122, 26);
            cuiLabel3.TabIndex = 33;
            cuiLabel3.VerticalAlignment = StringAlignment.Near;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Transparent;
            SaveBtn.CheckButton = false;
            SaveBtn.Checked = false;
            SaveBtn.CheckedBackground = Color.FromArgb(15, 28, 243);
            SaveBtn.CheckedForeColor = Color.White;
            SaveBtn.CheckedImageTint = Color.White;
            SaveBtn.CheckedOutline = Color.FromArgb(15, 28, 243);
            SaveBtn.Content = "Save";
            SaveBtn.DialogResult = DialogResult.None;
            SaveBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.HoverBackground = Color.FromArgb(15, 28, 243);
            SaveBtn.HoverForeColor = Color.Black;
            SaveBtn.HoverImageTint = Color.White;
            SaveBtn.HoverOutline = Color.Black;
            SaveBtn.Image = null;
            SaveBtn.ImageAutoCenter = true;
            SaveBtn.ImageExpand = new Point(0, 0);
            SaveBtn.ImageOffset = new Point(0, 0);
            SaveBtn.Location = new Point(406, 367);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.NormalBackground = Color.FromArgb(15, 28, 243);
            SaveBtn.NormalForeColor = Color.White;
            SaveBtn.NormalImageTint = Color.White;
            SaveBtn.NormalOutline = Color.Black;
            SaveBtn.OutlineThickness = 1F;
            SaveBtn.PressedBackground = Color.WhiteSmoke;
            SaveBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            SaveBtn.PressedImageTint = Color.White;
            SaveBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            SaveBtn.Rounding = new Padding(10);
            SaveBtn.Size = new Size(140, 40);
            SaveBtn.TabIndex = 50;
            SaveBtn.TextAlignment = StringAlignment.Center;
            SaveBtn.TextOffset = new Point(0, 0);
            SaveBtn.Click += SaveBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Transparent;
            BackBtn.CheckButton = false;
            BackBtn.Checked = false;
            BackBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            BackBtn.CheckedForeColor = Color.White;
            BackBtn.CheckedImageTint = Color.White;
            BackBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            BackBtn.Content = "Cancel";
            BackBtn.DialogResult = DialogResult.None;
            BackBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            BackBtn.ForeColor = Color.White;
            BackBtn.HoverBackground = Color.White;
            BackBtn.HoverForeColor = Color.Black;
            BackBtn.HoverImageTint = Color.White;
            BackBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            BackBtn.Image = null;
            BackBtn.ImageAutoCenter = true;
            BackBtn.ImageExpand = new Point(0, 0);
            BackBtn.ImageOffset = new Point(0, 0);
            BackBtn.Location = new Point(238, 367);
            BackBtn.Name = "BackBtn";
            BackBtn.NormalBackground = Color.Firebrick;
            BackBtn.NormalForeColor = Color.White;
            BackBtn.NormalImageTint = Color.White;
            BackBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            BackBtn.OutlineThickness = 1F;
            BackBtn.PressedBackground = Color.WhiteSmoke;
            BackBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            BackBtn.PressedImageTint = Color.White;
            BackBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            BackBtn.Rounding = new Padding(8);
            BackBtn.Size = new Size(140, 40);
            BackBtn.TabIndex = 51;
            BackBtn.TextAlignment = StringAlignment.Center;
            BackBtn.TextOffset = new Point(0, 0);
            BackBtn.Click += BackBtn_Click;
            // 
            // AddService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(774, 483);
            Controls.Add(BackBtn);
            Controls.Add(SaveBtn);
            Controls.Add(cuiLabel3);
            Controls.Add(ServiceLabel);
            Controls.Add(PricetxtBox);
            Controls.Add(DescriptiontxtBox);
            Controls.Add(ServiceNametxtBox);
            Controls.Add(cuiLabel2);
            Controls.Add(cuiLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddService";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddService";
            Load += AddService_Load;
            ResumeLayout(false);
        }

        #endregion
        private CuoreUI.Controls.cuiTextBox DescriptiontxtBox;
        private CuoreUI.Controls.cuiTextBox ServiceNametxtBox;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel ServiceLabel;
        private CuoreUI.Controls.cuiTextBox PricetxtBox;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiButton SaveBtn;
        private CuoreUI.Controls.cuiButton BackBtn;
    }
}