namespace PawCare.AdminPanel
{
    partial class AddPetName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPetName));
            cuiLabel5 = new CuoreUI.Controls.cuiLabel();
            BdayDatepicker = new CuoreUI.Controls.cuiCalendarDatePicker();
            TypePettxtBox = new CuoreUI.Controls.cuiComboBox();
            NextBtn = new CuoreUI.Controls.cuiButton();
            BackBtn = new CuoreUI.Controls.cuiButton();
            PetGendertxtBox = new CuoreUI.Controls.cuiComboBox();
            BreedtxtBox = new CuoreUI.Controls.cuiTextBox();
            PetNametxtBox = new CuoreUI.Controls.cuiTextBox();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            CustomerNameLabel = new CuoreUI.Controls.cuiLabel();
            SuspendLayout();
            // 
            // cuiLabel5
            // 
            cuiLabel5.BackColor = Color.Transparent;
            cuiLabel5.Content = "Date\\ of\\ Birth\\*";
            cuiLabel5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel5.ForeColor = Color.MidnightBlue;
            cuiLabel5.HorizontalAlignment = StringAlignment.Near;
            cuiLabel5.Location = new Point(239, 195);
            cuiLabel5.Margin = new Padding(4);
            cuiLabel5.Name = "cuiLabel5";
            cuiLabel5.Size = new Size(122, 18);
            cuiLabel5.TabIndex = 43;
            cuiLabel5.VerticalAlignment = StringAlignment.Near;
            // 
            // BdayDatepicker
            // 
            BdayDatepicker.BackColor = Color.Transparent;
            BdayDatepicker.Content = new DateTime(2025, 9, 24, 0, 0, 0, 0);
            BdayDatepicker.EnableThemeChangeButton = true;
            BdayDatepicker.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BdayDatepicker.ForeColor = Color.Black;
            BdayDatepicker.HoverBackground = Color.White;
            BdayDatepicker.HoverOutline = Color.Blue;
            BdayDatepicker.Icon = (Image)resources.GetObject("BdayDatepicker.Icon");
            BdayDatepicker.IconTint = Color.Black;
            BdayDatepicker.Location = new Point(239, 213);
            BdayDatepicker.Margin = new Padding(5);
            BdayDatepicker.Name = "BdayDatepicker";
            BdayDatepicker.NormalBackground = Color.White;
            BdayDatepicker.NormalOutline = Color.Black;
            BdayDatepicker.OutlineThickness = 1.5F;
            BdayDatepicker.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            BdayDatepicker.PressedBackground = Color.FromArgb(15, 28, 243);
            BdayDatepicker.PressedOutline = Color.Black;
            BdayDatepicker.Rounding = 8;
            BdayDatepicker.ShowIcon = true;
            BdayDatepicker.Size = new Size(308, 45);
            BdayDatepicker.TabIndex = 42;
            BdayDatepicker.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            BdayDatepicker.Load += BdayDatepicker_Load;
            // 
            // TypePettxtBox
            // 
            TypePettxtBox.BackColor = Color.Transparent;
            TypePettxtBox.BackgroundColor = Color.FromArgb(255, 255, 255);
            TypePettxtBox.ButtonCursor = Cursors.Arrow;
            TypePettxtBox.ButtonHoverBackground = Color.FromArgb(15, 28, 243);
            TypePettxtBox.ButtonHoverOutline = Color.Empty;
            TypePettxtBox.ButtonNormalBackground = Color.FromArgb(15, 28, 243);
            TypePettxtBox.ButtonNormalOutline = Color.Empty;
            TypePettxtBox.ButtonPressedBackground = Color.FromArgb(15, 28, 243);
            TypePettxtBox.ButtonPressedOutline = Color.Empty;
            TypePettxtBox.DropDownBackgroundColor = Color.White;
            TypePettxtBox.DropDownOutlineColor = Color.Black;
            TypePettxtBox.ExpandArrowColor = Color.Gray;
            TypePettxtBox.ForeColor = Color.Gray;
            TypePettxtBox.Location = new Point(239, 150);
            TypePettxtBox.Margin = new Padding(4);
            TypePettxtBox.Name = "TypePettxtBox";
            TypePettxtBox.NoSelectionDropdownText = "Empty";
            TypePettxtBox.NoSelectionText = "None";
            TypePettxtBox.OutlineColor = Color.Black;
            TypePettxtBox.OutlineThickness = 1F;
            TypePettxtBox.Rounding = 8;
            TypePettxtBox.Size = new Size(308, 45);
            TypePettxtBox.TabIndex = 41;
            TypePettxtBox.SelectedIndexChanged += TypePettxtBox_SelectedIndexChanged;
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
            NextBtn.Location = new Point(402, 410);
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
            NextBtn.TabIndex = 40;
            NextBtn.TextAlignment = StringAlignment.Center;
            NextBtn.TextOffset = new Point(0, 0);
            NextBtn.Click += NextBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Transparent;
            BackBtn.CheckButton = false;
            BackBtn.Checked = false;
            BackBtn.CheckedBackground = Color.FromArgb(15, 28, 243);
            BackBtn.CheckedForeColor = Color.White;
            BackBtn.CheckedImageTint = Color.White;
            BackBtn.CheckedOutline = Color.FromArgb(15, 28, 243);
            BackBtn.Content = "Back";
            BackBtn.DialogResult = DialogResult.None;
            BackBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackBtn.ForeColor = Color.Black;
            BackBtn.HoverBackground = Color.Red;
            BackBtn.HoverForeColor = Color.Black;
            BackBtn.HoverImageTint = Color.White;
            BackBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            BackBtn.Image = null;
            BackBtn.ImageAutoCenter = true;
            BackBtn.ImageExpand = new Point(0, 0);
            BackBtn.ImageOffset = new Point(0, 0);
            BackBtn.Location = new Point(239, 410);
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
            BackBtn.Rounding = new Padding(10);
            BackBtn.Size = new Size(140, 40);
            BackBtn.TabIndex = 39;
            BackBtn.TextAlignment = StringAlignment.Center;
            BackBtn.TextOffset = new Point(0, 0);
            BackBtn.Click += BackBtn_Click;
            // 
            // PetGendertxtBox
            // 
            PetGendertxtBox.BackColor = Color.Transparent;
            PetGendertxtBox.BackgroundColor = Color.FromArgb(255, 255, 255);
            PetGendertxtBox.ButtonCursor = Cursors.Arrow;
            PetGendertxtBox.ButtonHoverBackground = Color.FromArgb(15, 28, 243);
            PetGendertxtBox.ButtonHoverOutline = Color.Empty;
            PetGendertxtBox.ButtonNormalBackground = Color.FromArgb(15, 28, 243);
            PetGendertxtBox.ButtonNormalOutline = Color.Empty;
            PetGendertxtBox.ButtonPressedBackground = Color.FromArgb(15, 28, 243);
            PetGendertxtBox.ButtonPressedOutline = Color.Empty;
            PetGendertxtBox.DropDownBackgroundColor = Color.White;
            PetGendertxtBox.DropDownOutlineColor = Color.Black;
            PetGendertxtBox.ExpandArrowColor = Color.Gray;
            PetGendertxtBox.ForeColor = Color.Gray;
            PetGendertxtBox.Location = new Point(239, 342);
            PetGendertxtBox.Margin = new Padding(4);
            PetGendertxtBox.Name = "PetGendertxtBox";
            PetGendertxtBox.NoSelectionDropdownText = "Empty";
            PetGendertxtBox.NoSelectionText = "None";
            PetGendertxtBox.OutlineColor = Color.Black;
            PetGendertxtBox.OutlineThickness = 1F;
            PetGendertxtBox.Rounding = 8;
            PetGendertxtBox.Size = new Size(308, 45);
            PetGendertxtBox.TabIndex = 38;
            PetGendertxtBox.SelectedIndexChanged += PetGendertxtBox_SelectedIndexChanged;
            // 
            // BreedtxtBox
            // 
            BreedtxtBox.BackColor = Color.Transparent;
            BreedtxtBox.BackgroundColor = Color.White;
            BreedtxtBox.Content = "";
            BreedtxtBox.FocusBackgroundColor = Color.White;
            BreedtxtBox.FocusImageTint = Color.White;
            BreedtxtBox.FocusOutlineColor = Color.FromArgb(15, 28, 243);
            BreedtxtBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            BreedtxtBox.ForeColor = Color.Black;
            BreedtxtBox.Image = null;
            BreedtxtBox.ImageExpand = new Point(0, 0);
            BreedtxtBox.ImageOffset = new Point(0, 0);
            BreedtxtBox.Location = new Point(239, 279);
            BreedtxtBox.Margin = new Padding(4, 3, 4, 3);
            BreedtxtBox.Multiline = false;
            BreedtxtBox.Name = "BreedtxtBox";
            BreedtxtBox.NormalImageTint = Color.White;
            BreedtxtBox.OutlineColor = Color.Black;
            BreedtxtBox.Padding = new Padding(17, 14, 17, 0);
            BreedtxtBox.PasswordChar = false;
            BreedtxtBox.PlaceholderColor = SystemColors.WindowText;
            BreedtxtBox.PlaceholderText = "";
            BreedtxtBox.Rounding = new Padding(8);
            BreedtxtBox.Size = new Size(308, 45);
            BreedtxtBox.TabIndex = 37;
            BreedtxtBox.TextOffset = new Size(0, 0);
            BreedtxtBox.UnderlinedStyle = false;
            BreedtxtBox.ContentChanged += BreedtxtBox_ContentChanged;
            // 
            // PetNametxtBox
            // 
            PetNametxtBox.BackColor = Color.Transparent;
            PetNametxtBox.BackgroundColor = Color.White;
            PetNametxtBox.Content = "";
            PetNametxtBox.FocusBackgroundColor = Color.White;
            PetNametxtBox.FocusImageTint = Color.White;
            PetNametxtBox.FocusOutlineColor = Color.FromArgb(15, 28, 243);
            PetNametxtBox.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PetNametxtBox.ForeColor = Color.Black;
            PetNametxtBox.Image = null;
            PetNametxtBox.ImageExpand = new Point(0, 0);
            PetNametxtBox.ImageOffset = new Point(0, 0);
            PetNametxtBox.Location = new Point(239, 85);
            PetNametxtBox.Margin = new Padding(4, 3, 4, 3);
            PetNametxtBox.Multiline = false;
            PetNametxtBox.Name = "PetNametxtBox";
            PetNametxtBox.NormalImageTint = Color.White;
            PetNametxtBox.OutlineColor = Color.Black;
            PetNametxtBox.Padding = new Padding(17, 14, 17, 0);
            PetNametxtBox.PasswordChar = false;
            PetNametxtBox.PlaceholderColor = SystemColors.WindowText;
            PetNametxtBox.PlaceholderText = "";
            PetNametxtBox.Rounding = new Padding(8);
            PetNametxtBox.Size = new Size(308, 45);
            PetNametxtBox.TabIndex = 36;
            PetNametxtBox.TextOffset = new Size(0, 0);
            PetNametxtBox.UnderlinedStyle = false;
            PetNametxtBox.ContentChanged += PetNametxtBox_ContentChanged;
            // 
            // cuiLabel4
            // 
            cuiLabel4.BackColor = Color.Transparent;
            cuiLabel4.Content = "Pet\\ Gender";
            cuiLabel4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel4.ForeColor = Color.MidnightBlue;
            cuiLabel4.HorizontalAlignment = StringAlignment.Near;
            cuiLabel4.Location = new Point(239, 327);
            cuiLabel4.Margin = new Padding(4);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(122, 19);
            cuiLabel4.TabIndex = 35;
            cuiLabel4.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel3
            // 
            cuiLabel3.BackColor = Color.Transparent;
            cuiLabel3.Content = "Breed\\ of\\ Pet";
            cuiLabel3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel3.ForeColor = Color.MidnightBlue;
            cuiLabel3.HorizontalAlignment = StringAlignment.Near;
            cuiLabel3.Location = new Point(239, 261);
            cuiLabel3.Margin = new Padding(4);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(122, 21);
            cuiLabel3.TabIndex = 34;
            cuiLabel3.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.Transparent;
            cuiLabel2.Content = "Type\\ of\\ Pet\\*";
            cuiLabel2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel2.ForeColor = Color.MidnightBlue;
            cuiLabel2.HorizontalAlignment = StringAlignment.Near;
            cuiLabel2.Location = new Point(239, 132);
            cuiLabel2.Margin = new Padding(4);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(122, 26);
            cuiLabel2.TabIndex = 33;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Name\\ of\\ Pet\\*";
            cuiLabel1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel1.ForeColor = Color.MidnightBlue;
            cuiLabel1.HorizontalAlignment = StringAlignment.Near;
            cuiLabel1.Location = new Point(239, 62);
            cuiLabel1.Margin = new Padding(4);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(122, 26);
            cuiLabel1.TabIndex = 32;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.BackColor = Color.Transparent;
            CustomerNameLabel.Content = "Customer\\ Pet\\ Information";
            CustomerNameLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerNameLabel.ForeColor = Color.MidnightBlue;
            CustomerNameLabel.HorizontalAlignment = StringAlignment.Center;
            CustomerNameLabel.Location = new Point(238, 35);
            CustomerNameLabel.Margin = new Padding(4);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(305, 29);
            CustomerNameLabel.TabIndex = 31;
            CustomerNameLabel.VerticalAlignment = StringAlignment.Near;
            // 
            // AddPetName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FILL_UP_FORM_PET_BACKGROUND;
            ClientSize = new Size(774, 483);
            Controls.Add(cuiLabel5);
            Controls.Add(BdayDatepicker);
            Controls.Add(TypePettxtBox);
            Controls.Add(NextBtn);
            Controls.Add(BackBtn);
            Controls.Add(PetGendertxtBox);
            Controls.Add(BreedtxtBox);
            Controls.Add(PetNametxtBox);
            Controls.Add(cuiLabel4);
            Controls.Add(cuiLabel3);
            Controls.Add(cuiLabel2);
            Controls.Add(cuiLabel1);
            Controls.Add(CustomerNameLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddPetName";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPetName";
            Load += AddPetName_Load;
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiLabel cuiLabel5;
        private CuoreUI.Controls.cuiCalendarDatePicker BdayDatepicker;
        private CuoreUI.Controls.cuiComboBox TypePettxtBox;
        private CuoreUI.Controls.cuiButton NextBtn;
        private CuoreUI.Controls.cuiButton BackBtn;
        private CuoreUI.Controls.cuiComboBox PetGendertxtBox;
        private CuoreUI.Controls.cuiTextBox BreedtxtBox;
        private CuoreUI.Controls.cuiTextBox PetNametxtBox;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel CustomerNameLabel;
    }
}