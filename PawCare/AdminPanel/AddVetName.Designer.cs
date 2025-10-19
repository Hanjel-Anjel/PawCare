namespace PawCare.AdminPanel
{
    partial class AddVetName
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
            NextBtn = new CuoreUI.Controls.cuiButton();
            CancelBtn = new CuoreUI.Controls.cuiButton();
            suffixCbox = new CuoreUI.Controls.cuiComboBox();
            LnametxtBox = new CuoreUI.Controls.cuiTextBox();
            MnametxtBox = new CuoreUI.Controls.cuiTextBox();
            FnametxtBox = new CuoreUI.Controls.cuiTextBox();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            SuspendLayout();
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.BackColor = Color.Transparent;
            CustomerNameLabel.Content = "Veterinarian\\ Name";
            CustomerNameLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerNameLabel.ForeColor = Color.MidnightBlue;
            CustomerNameLabel.HorizontalAlignment = StringAlignment.Near;
            CustomerNameLabel.Location = new Point(183, 55);
            CustomerNameLabel.Margin = new Padding(4);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(235, 29);
            CustomerNameLabel.TabIndex = 34;
            CustomerNameLabel.VerticalAlignment = StringAlignment.Near;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.Transparent;
            NextBtn.CheckButton = false;
            NextBtn.Checked = false;
            NextBtn.CheckedBackground = Color.FromArgb(15, 28, 243);
            NextBtn.CheckedForeColor = Color.White;
            NextBtn.CheckedImageTint = Color.White;
            NextBtn.CheckedOutline = Color.FromArgb(15, 28, 243);
            NextBtn.Content = "Next";
            NextBtn.DialogResult = DialogResult.None;
            NextBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NextBtn.ForeColor = Color.White;
            NextBtn.HoverBackground = Color.FromArgb(15, 28, 243);
            NextBtn.HoverForeColor = Color.Black;
            NextBtn.HoverImageTint = Color.White;
            NextBtn.HoverOutline = Color.Black;
            NextBtn.Image = null;
            NextBtn.ImageAutoCenter = true;
            NextBtn.ImageExpand = new Point(0, 0);
            NextBtn.ImageOffset = new Point(0, 0);
            NextBtn.Location = new Point(318, 436);
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
            NextBtn.Rounding = new Padding(10);
            NextBtn.Size = new Size(140, 40);
            NextBtn.TabIndex = 44;
            NextBtn.TextAlignment = StringAlignment.Center;
            NextBtn.TextOffset = new Point(0, 0);
            NextBtn.Click += NextBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.Transparent;
            CancelBtn.CheckButton = false;
            CancelBtn.Checked = false;
            CancelBtn.CheckedBackground = Color.FromArgb(15, 28, 243);
            CancelBtn.CheckedForeColor = Color.White;
            CancelBtn.CheckedImageTint = Color.White;
            CancelBtn.CheckedOutline = Color.FromArgb(15, 28, 243);
            CancelBtn.Content = "Cancel";
            CancelBtn.DialogResult = DialogResult.None;
            CancelBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelBtn.ForeColor = Color.Black;
            CancelBtn.HoverBackground = Color.Red;
            CancelBtn.HoverForeColor = Color.Black;
            CancelBtn.HoverImageTint = Color.White;
            CancelBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            CancelBtn.Image = null;
            CancelBtn.ImageAutoCenter = true;
            CancelBtn.ImageExpand = new Point(0, 0);
            CancelBtn.ImageOffset = new Point(0, 0);
            CancelBtn.Location = new Point(150, 436);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.NormalBackground = Color.White;
            CancelBtn.NormalForeColor = Color.Black;
            CancelBtn.NormalImageTint = Color.White;
            CancelBtn.NormalOutline = Color.Black;
            CancelBtn.OutlineThickness = 1F;
            CancelBtn.PressedBackground = Color.WhiteSmoke;
            CancelBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            CancelBtn.PressedImageTint = Color.White;
            CancelBtn.PressedOutline = Color.Black;
            CancelBtn.Rounding = new Padding(10);
            CancelBtn.Size = new Size(140, 40);
            CancelBtn.TabIndex = 43;
            CancelBtn.TextAlignment = StringAlignment.Center;
            CancelBtn.TextOffset = new Point(0, 0);
            CancelBtn.Click += CancelBtn_Click;
            // 
            // suffixCbox
            // 
            suffixCbox.BackColor = Color.Transparent;
            suffixCbox.BackgroundColor = Color.FromArgb(255, 255, 255);
            suffixCbox.ButtonCursor = Cursors.Arrow;
            suffixCbox.ButtonHoverBackground = Color.FromArgb(15, 28, 243);
            suffixCbox.ButtonHoverOutline = Color.Empty;
            suffixCbox.ButtonNormalBackground = Color.FromArgb(15, 28, 243);
            suffixCbox.ButtonNormalOutline = Color.Empty;
            suffixCbox.ButtonPressedBackground = Color.FromArgb(15, 28, 243);
            suffixCbox.ButtonPressedOutline = Color.Empty;
            suffixCbox.DropDownBackgroundColor = Color.White;
            suffixCbox.DropDownOutlineColor = Color.Black;
            suffixCbox.ExpandArrowColor = Color.Gray;
            suffixCbox.ForeColor = Color.Gray;
            suffixCbox.Location = new Point(150, 374);
            suffixCbox.Margin = new Padding(4);
            suffixCbox.Name = "suffixCbox";
            suffixCbox.NoSelectionDropdownText = "Empty";
            suffixCbox.NoSelectionText = "None";
            suffixCbox.OutlineColor = Color.Black;
            suffixCbox.OutlineThickness = 1F;
            suffixCbox.Rounding = 8;
            suffixCbox.Size = new Size(308, 43);
            suffixCbox.TabIndex = 42;
            suffixCbox.SelectedIndexChanged += suffixCbox_SelectedIndexChanged;
            // 
            // LnametxtBox
            // 
            LnametxtBox.BackColor = Color.Transparent;
            LnametxtBox.BackgroundColor = Color.White;
            LnametxtBox.Content = "";
            LnametxtBox.FocusBackgroundColor = Color.White;
            LnametxtBox.FocusImageTint = Color.White;
            LnametxtBox.FocusOutlineColor = Color.FromArgb(15, 28, 243);
            LnametxtBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            LnametxtBox.ForeColor = Color.Black;
            LnametxtBox.Image = null;
            LnametxtBox.ImageExpand = new Point(0, 0);
            LnametxtBox.ImageOffset = new Point(0, 0);
            LnametxtBox.Location = new Point(150, 281);
            LnametxtBox.Margin = new Padding(4, 3, 4, 3);
            LnametxtBox.Multiline = false;
            LnametxtBox.Name = "LnametxtBox";
            LnametxtBox.NormalImageTint = Color.White;
            LnametxtBox.OutlineColor = Color.Black;
            LnametxtBox.Padding = new Padding(17, 13, 17, 0);
            LnametxtBox.PasswordChar = false;
            LnametxtBox.PlaceholderColor = SystemColors.WindowText;
            LnametxtBox.PlaceholderText = "";
            LnametxtBox.Rounding = new Padding(8);
            LnametxtBox.Size = new Size(308, 43);
            LnametxtBox.TabIndex = 41;
            LnametxtBox.TextOffset = new Size(0, 0);
            LnametxtBox.UnderlinedStyle = false;
            LnametxtBox.ContentChanged += LnametxtBox_ContentChanged;
            // 
            // MnametxtBox
            // 
            MnametxtBox.BackColor = Color.Transparent;
            MnametxtBox.BackgroundColor = Color.White;
            MnametxtBox.Content = "";
            MnametxtBox.FocusBackgroundColor = Color.White;
            MnametxtBox.FocusImageTint = Color.White;
            MnametxtBox.FocusOutlineColor = Color.FromArgb(15, 28, 243);
            MnametxtBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            MnametxtBox.ForeColor = Color.Black;
            MnametxtBox.Image = null;
            MnametxtBox.ImageExpand = new Point(0, 0);
            MnametxtBox.ImageOffset = new Point(0, 0);
            MnametxtBox.Location = new Point(150, 197);
            MnametxtBox.Margin = new Padding(4, 3, 4, 3);
            MnametxtBox.Multiline = false;
            MnametxtBox.Name = "MnametxtBox";
            MnametxtBox.NormalImageTint = Color.White;
            MnametxtBox.OutlineColor = Color.Black;
            MnametxtBox.Padding = new Padding(17, 13, 17, 0);
            MnametxtBox.PasswordChar = false;
            MnametxtBox.PlaceholderColor = SystemColors.WindowText;
            MnametxtBox.PlaceholderText = "";
            MnametxtBox.Rounding = new Padding(8);
            MnametxtBox.Size = new Size(308, 43);
            MnametxtBox.TabIndex = 40;
            MnametxtBox.TextOffset = new Size(0, 0);
            MnametxtBox.UnderlinedStyle = false;
            MnametxtBox.ContentChanged += MnametxtBox_ContentChanged;
            // 
            // FnametxtBox
            // 
            FnametxtBox.BackColor = Color.Transparent;
            FnametxtBox.BackgroundColor = Color.White;
            FnametxtBox.Content = "";
            FnametxtBox.FocusBackgroundColor = Color.White;
            FnametxtBox.FocusImageTint = Color.White;
            FnametxtBox.FocusOutlineColor = Color.FromArgb(15, 28, 243);
            FnametxtBox.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FnametxtBox.ForeColor = Color.Black;
            FnametxtBox.Image = null;
            FnametxtBox.ImageExpand = new Point(0, 0);
            FnametxtBox.ImageOffset = new Point(0, 0);
            FnametxtBox.Location = new Point(150, 121);
            FnametxtBox.Margin = new Padding(4, 3, 4, 3);
            FnametxtBox.Multiline = false;
            FnametxtBox.Name = "FnametxtBox";
            FnametxtBox.NormalImageTint = Color.White;
            FnametxtBox.OutlineColor = Color.Black;
            FnametxtBox.Padding = new Padding(17, 13, 17, 0);
            FnametxtBox.PasswordChar = false;
            FnametxtBox.PlaceholderColor = SystemColors.WindowText;
            FnametxtBox.PlaceholderText = "";
            FnametxtBox.Rounding = new Padding(8);
            FnametxtBox.Size = new Size(308, 43);
            FnametxtBox.TabIndex = 39;
            FnametxtBox.TextOffset = new Size(0, 0);
            FnametxtBox.UnderlinedStyle = false;
            FnametxtBox.ContentChanged += FnametxtBox_ContentChanged;
            // 
            // cuiLabel4
            // 
            cuiLabel4.BackColor = Color.Transparent;
            cuiLabel4.Content = "Suffix";
            cuiLabel4.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiLabel4.ForeColor = Color.MidnightBlue;
            cuiLabel4.HorizontalAlignment = StringAlignment.Near;
            cuiLabel4.Location = new Point(150, 341);
            cuiLabel4.Margin = new Padding(4);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(122, 24);
            cuiLabel4.TabIndex = 38;
            cuiLabel4.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel3
            // 
            cuiLabel3.BackColor = Color.Transparent;
            cuiLabel3.Content = "Last\\ Name\\*";
            cuiLabel3.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiLabel3.ForeColor = Color.MidnightBlue;
            cuiLabel3.HorizontalAlignment = StringAlignment.Near;
            cuiLabel3.Location = new Point(150, 248);
            cuiLabel3.Margin = new Padding(4);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(122, 24);
            cuiLabel3.TabIndex = 37;
            cuiLabel3.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.Transparent;
            cuiLabel2.Content = "Middle\\ Name\\*";
            cuiLabel2.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiLabel2.ForeColor = Color.MidnightBlue;
            cuiLabel2.HorizontalAlignment = StringAlignment.Near;
            cuiLabel2.Location = new Point(150, 173);
            cuiLabel2.Margin = new Padding(4);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(122, 24);
            cuiLabel2.TabIndex = 36;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "First\\ Name\\*";
            cuiLabel1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiLabel1.ForeColor = Color.MidnightBlue;
            cuiLabel1.HorizontalAlignment = StringAlignment.Near;
            cuiLabel1.Location = new Point(150, 98);
            cuiLabel1.Margin = new Padding(4);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(122, 24);
            cuiLabel1.TabIndex = 35;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // AddVetName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 520);
            Controls.Add(NextBtn);
            Controls.Add(CancelBtn);
            Controls.Add(suffixCbox);
            Controls.Add(LnametxtBox);
            Controls.Add(MnametxtBox);
            Controls.Add(FnametxtBox);
            Controls.Add(cuiLabel4);
            Controls.Add(cuiLabel3);
            Controls.Add(cuiLabel2);
            Controls.Add(cuiLabel1);
            Controls.Add(CustomerNameLabel);
            Name = "AddVetName";
            Text = "AddVeterinarian";
            Load += AddVeterinarian_Load;
            ResumeLayout(false);
        }

        #endregion
        private CuoreUI.Controls.cuiLabel CustomerNameLabel;
        private CuoreUI.Controls.cuiButton NextBtn;
        private CuoreUI.Controls.cuiButton CancelBtn;
        private CuoreUI.Controls.cuiComboBox suffixCbox;
        private CuoreUI.Controls.cuiTextBox LnametxtBox;
        private CuoreUI.Controls.cuiTextBox MnametxtBox;
        private CuoreUI.Controls.cuiTextBox FnametxtBox;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
    }
}