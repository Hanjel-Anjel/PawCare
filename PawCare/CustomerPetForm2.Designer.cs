namespace PawCare
{
    partial class CustomerPetForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPetForm2));
            BackBtn = new CuoreUI.Controls.cuiButton();
            PetGendertxtBox = new CuoreUI.Controls.cuiComboBox();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            CustomerNameLabel = new CuoreUI.Controls.cuiLabel();
            cuiComboBox1 = new CuoreUI.Controls.cuiComboBox();
            cuiLabel6 = new CuoreUI.Controls.cuiLabel();
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            PetPicBox = new CuoreUI.Controls.cuiPictureBox();
            SaveBtn = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
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
            BackBtn.Location = new Point(122, 649);
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
            BackBtn.TabIndex = 39;
            BackBtn.TextAlignment = StringAlignment.Center;
            BackBtn.TextOffset = new Point(0, 0);
            BackBtn.Click += BackBtn_Click;
            // 
            // PetGendertxtBox
            // 
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
            PetGendertxtBox.Location = new Point(113, 327);
            PetGendertxtBox.Margin = new Padding(4);
            PetGendertxtBox.Name = "PetGendertxtBox";
            PetGendertxtBox.NoSelectionDropdownText = "Empty";
            PetGendertxtBox.NoSelectionText = "None";
            PetGendertxtBox.OutlineColor = Color.Black;
            PetGendertxtBox.OutlineThickness = 1F;
            PetGendertxtBox.Rounding = 8;
            PetGendertxtBox.Size = new Size(410, 64);
            PetGendertxtBox.TabIndex = 38;
            // 
            // cuiLabel4
            // 
            cuiLabel4.Content = "Upload\\ Pet\\ Image";
            cuiLabel4.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel4.HorizontalAlignment = StringAlignment.Near;
            cuiLabel4.Location = new Point(113, 411);
            cuiLabel4.Margin = new Padding(4);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(152, 26);
            cuiLabel4.TabIndex = 35;
            cuiLabel4.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel3
            // 
            cuiLabel3.Content = "Assigned\\ Veterinarian";
            cuiLabel3.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel3.HorizontalAlignment = StringAlignment.Near;
            cuiLabel3.Location = new Point(113, 299);
            cuiLabel3.Margin = new Padding(4);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(178, 26);
            cuiLabel3.TabIndex = 34;
            cuiLabel3.VerticalAlignment = StringAlignment.Near;
            cuiLabel3.Load += cuiLabel3_Load;
            // 
            // cuiLabel2
            // 
            cuiLabel2.Content = "Weight";
            cuiLabel2.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel2.HorizontalAlignment = StringAlignment.Near;
            cuiLabel2.Location = new Point(113, 204);
            cuiLabel2.Margin = new Padding(4);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(122, 26);
            cuiLabel2.TabIndex = 33;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.Content = "Customer\\ Pet\\ Information";
            CustomerNameLabel.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerNameLabel.HorizontalAlignment = StringAlignment.Center;
            CustomerNameLabel.Location = new Point(97, 46);
            CustomerNameLabel.Margin = new Padding(4);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(369, 40);
            CustomerNameLabel.TabIndex = 31;
            CustomerNameLabel.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiComboBox1
            // 
            cuiComboBox1.BackgroundColor = Color.FromArgb(255, 255, 255);
            cuiComboBox1.ButtonCursor = Cursors.Arrow;
            cuiComboBox1.ButtonHoverBackground = Color.FromArgb(15, 28, 243);
            cuiComboBox1.ButtonHoverOutline = Color.Empty;
            cuiComboBox1.ButtonNormalBackground = Color.FromArgb(15, 28, 243);
            cuiComboBox1.ButtonNormalOutline = Color.Empty;
            cuiComboBox1.ButtonPressedBackground = Color.FromArgb(15, 28, 243);
            cuiComboBox1.ButtonPressedOutline = Color.Empty;
            cuiComboBox1.DropDownBackgroundColor = Color.White;
            cuiComboBox1.DropDownOutlineColor = Color.Black;
            cuiComboBox1.ExpandArrowColor = Color.Gray;
            cuiComboBox1.ForeColor = Color.Gray;
            cuiComboBox1.Location = new Point(113, 132);
            cuiComboBox1.Margin = new Padding(4);
            cuiComboBox1.Name = "cuiComboBox1";
            cuiComboBox1.NoSelectionDropdownText = "Empty";
            cuiComboBox1.NoSelectionText = "None";
            cuiComboBox1.OutlineColor = Color.Black;
            cuiComboBox1.OutlineThickness = 1F;
            cuiComboBox1.Rounding = 8;
            cuiComboBox1.Size = new Size(410, 64);
            cuiComboBox1.TabIndex = 44;
            // 
            // cuiLabel6
            // 
            cuiLabel6.Content = "Type\\ of\\ Service";
            cuiLabel6.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel6.HorizontalAlignment = StringAlignment.Near;
            cuiLabel6.Location = new Point(113, 98);
            cuiLabel6.Margin = new Padding(4);
            cuiLabel6.Name = "cuiLabel6";
            cuiLabel6.Size = new Size(122, 26);
            cuiLabel6.TabIndex = 46;
            cuiLabel6.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.BackgroundColor = Color.White;
            cuiTextBox1.Content = "";
            cuiTextBox1.FocusBackgroundColor = Color.White;
            cuiTextBox1.FocusImageTint = Color.White;
            cuiTextBox1.FocusOutlineColor = Color.FromArgb(15, 28, 243);
            cuiTextBox1.Font = new Font("Poppins", 10.8F);
            cuiTextBox1.ForeColor = Color.Black;
            cuiTextBox1.Image = null;
            cuiTextBox1.ImageExpand = new Point(0, 0);
            cuiTextBox1.ImageOffset = new Point(0, 0);
            cuiTextBox1.Location = new Point(113, 234);
            cuiTextBox1.Margin = new Padding(4, 3, 4, 3);
            cuiTextBox1.Multiline = false;
            cuiTextBox1.Name = "cuiTextBox1";
            cuiTextBox1.NormalImageTint = Color.White;
            cuiTextBox1.OutlineColor = Color.Black;
            cuiTextBox1.Padding = new Padding(22, 18, 22, 0);
            cuiTextBox1.PasswordChar = false;
            cuiTextBox1.PlaceholderColor = SystemColors.WindowText;
            cuiTextBox1.PlaceholderText = "";
            cuiTextBox1.Rounding = new Padding(8);
            cuiTextBox1.Size = new Size(410, 58);
            cuiTextBox1.TabIndex = 47;
            cuiTextBox1.TextOffset = new Size(0, 0);
            cuiTextBox1.UnderlinedStyle = false;
            // 
            // PetPicBox
            // 
            PetPicBox.BackgroundImage = (Image)resources.GetObject("PetPicBox.BackgroundImage");
            PetPicBox.BackgroundImageLayout = ImageLayout.Stretch;
            PetPicBox.BorderStyle = BorderStyle.FixedSingle;
            PetPicBox.Content = null;
            PetPicBox.ImageTint = Color.White;
            PetPicBox.Location = new Point(198, 444);
            PetPicBox.Margin = new Padding(4, 3, 4, 3);
            PetPicBox.Name = "PetPicBox";
            PetPicBox.OutlineThickness = 1F;
            PetPicBox.PanelOutlineColor = Color.Empty;
            PetPicBox.Rotation = 0;
            PetPicBox.Rounding = new Padding(8);
            PetPicBox.Size = new Size(224, 151);
            PetPicBox.TabIndex = 48;
            // 
            // SaveBtn
            // 
            SaveBtn.CheckButton = false;
            SaveBtn.Checked = false;
            SaveBtn.CheckedBackground = Color.FromArgb(15, 28, 243);
            SaveBtn.CheckedForeColor = Color.White;
            SaveBtn.CheckedImageTint = Color.White;
            SaveBtn.CheckedOutline = Color.FromArgb(15, 28, 243);
            SaveBtn.Content = "Save";
            SaveBtn.DialogResult = DialogResult.None;
            SaveBtn.Font = new Font("Poppins", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.HoverBackground = Color.FromArgb(15, 28, 243);
            SaveBtn.HoverForeColor = Color.Black;
            SaveBtn.HoverImageTint = Color.White;
            SaveBtn.HoverOutline = Color.Black;
            SaveBtn.Image = null;
            SaveBtn.ImageAutoCenter = true;
            SaveBtn.ImageExpand = new Point(0, 0);
            SaveBtn.ImageOffset = new Point(0, 0);
            SaveBtn.Location = new Point(342, 649);
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
            SaveBtn.Rounding = new Padding(20);
            SaveBtn.Size = new Size(156, 50);
            SaveBtn.TabIndex = 49;
            SaveBtn.TextAlignment = StringAlignment.Center;
            SaveBtn.TextOffset = new Point(0, 0);
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CustomerPetForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(629, 727);
            Controls.Add(SaveBtn);
            Controls.Add(PetPicBox);
            Controls.Add(cuiTextBox1);
            Controls.Add(cuiLabel6);
            Controls.Add(cuiComboBox1);
            Controls.Add(BackBtn);
            Controls.Add(PetGendertxtBox);
            Controls.Add(cuiLabel4);
            Controls.Add(cuiLabel3);
            Controls.Add(cuiLabel2);
            Controls.Add(CustomerNameLabel);
            Name = "CustomerPetForm2";
            Text = "CustomerPetForm2";
            ResumeLayout(false);
        }

        #endregion
        private CuoreUI.Controls.cuiButton BackBtn;
        private CuoreUI.Controls.cuiComboBox PetGendertxtBox;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel CustomerNameLabel;
        private CuoreUI.Controls.cuiComboBox cuiComboBox1;
        private CuoreUI.Controls.cuiLabel cuiLabel6;
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private CuoreUI.Controls.cuiPictureBox PetPicBox;
        private CuoreUI.Controls.cuiButton SaveBtn;
    }
}