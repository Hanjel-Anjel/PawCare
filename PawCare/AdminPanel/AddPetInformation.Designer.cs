namespace PawCare.AdminPanel
{
    partial class AddPetInformation
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
            PetPicBox = new PictureBox();
            SaveBtn = new CuoreUI.Controls.cuiButton();
            WeighttxtBox = new CuoreUI.Controls.cuiTextBox();
            cuiLabel6 = new CuoreUI.Controls.cuiLabel();
            TypeServiceCbx = new CuoreUI.Controls.cuiComboBox();
            BackBtn = new CuoreUI.Controls.cuiButton();
            VetCbx = new CuoreUI.Controls.cuiComboBox();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            CustomerNameLabel = new CuoreUI.Controls.cuiLabel();
            ((System.ComponentModel.ISupportInitialize)PetPicBox).BeginInit();
            SuspendLayout();
            // 
            // PetPicBox
            // 
            PetPicBox.BackColor = Color.Transparent;
            PetPicBox.BorderStyle = BorderStyle.FixedSingle;
            PetPicBox.Location = new Point(446, 154);
            PetPicBox.Name = "PetPicBox";
            PetPicBox.Size = new Size(224, 195);
            PetPicBox.TabIndex = 61;
            PetPicBox.TabStop = false;
            PetPicBox.Click += PetPicBox_Click;
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
            SaveBtn.Location = new Point(488, 376);
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
            SaveBtn.TabIndex = 60;
            SaveBtn.TextAlignment = StringAlignment.Center;
            SaveBtn.TextOffset = new Point(0, 0);
            SaveBtn.Click += SaveBtn_Click;
            // 
            // WeighttxtBox
            // 
            WeighttxtBox.BackColor = Color.Transparent;
            WeighttxtBox.BackgroundColor = Color.White;
            WeighttxtBox.Content = "";
            WeighttxtBox.FocusBackgroundColor = Color.White;
            WeighttxtBox.FocusImageTint = Color.White;
            WeighttxtBox.FocusOutlineColor = Color.FromArgb(15, 28, 243);
            WeighttxtBox.Font = new Font("Microsoft Sans Serif", 10.8F);
            WeighttxtBox.ForeColor = Color.Black;
            WeighttxtBox.Image = null;
            WeighttxtBox.ImageExpand = new Point(0, 0);
            WeighttxtBox.ImageOffset = new Point(0, 0);
            WeighttxtBox.Location = new Point(98, 226);
            WeighttxtBox.Margin = new Padding(4, 3, 4, 3);
            WeighttxtBox.Multiline = false;
            WeighttxtBox.Name = "WeighttxtBox";
            WeighttxtBox.NormalImageTint = Color.White;
            WeighttxtBox.OutlineColor = Color.Black;
            WeighttxtBox.Padding = new Padding(17, 14, 17, 0);
            WeighttxtBox.PasswordChar = false;
            WeighttxtBox.PlaceholderColor = SystemColors.WindowText;
            WeighttxtBox.PlaceholderText = "";
            WeighttxtBox.Rounding = new Padding(8);
            WeighttxtBox.Size = new Size(308, 45);
            WeighttxtBox.TabIndex = 59;
            WeighttxtBox.TextOffset = new Size(0, 0);
            WeighttxtBox.UnderlinedStyle = false;
            WeighttxtBox.ContentChanged += WeighttxtBox_ContentChanged;
            // 
            // cuiLabel6
            // 
            cuiLabel6.BackColor = Color.Transparent;
            cuiLabel6.Content = "Type\\ of\\ Service\\*";
            cuiLabel6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel6.ForeColor = Color.MidnightBlue;
            cuiLabel6.HorizontalAlignment = StringAlignment.Near;
            cuiLabel6.Location = new Point(98, 130);
            cuiLabel6.Margin = new Padding(4);
            cuiLabel6.Name = "cuiLabel6";
            cuiLabel6.Size = new Size(122, 23);
            cuiLabel6.TabIndex = 58;
            cuiLabel6.VerticalAlignment = StringAlignment.Near;
            // 
            // TypeServiceCbx
            // 
            TypeServiceCbx.BackColor = Color.Transparent;
            TypeServiceCbx.BackgroundColor = Color.FromArgb(255, 255, 255);
            TypeServiceCbx.ButtonCursor = Cursors.Arrow;
            TypeServiceCbx.ButtonHoverBackground = Color.FromArgb(15, 28, 243);
            TypeServiceCbx.ButtonHoverOutline = Color.Empty;
            TypeServiceCbx.ButtonNormalBackground = Color.FromArgb(15, 28, 243);
            TypeServiceCbx.ButtonNormalOutline = Color.Empty;
            TypeServiceCbx.ButtonPressedBackground = Color.FromArgb(15, 28, 243);
            TypeServiceCbx.ButtonPressedOutline = Color.Empty;
            TypeServiceCbx.DropDownBackgroundColor = Color.White;
            TypeServiceCbx.DropDownOutlineColor = Color.Black;
            TypeServiceCbx.ExpandArrowColor = Color.Gray;
            TypeServiceCbx.ForeColor = Color.Gray;
            TypeServiceCbx.Location = new Point(98, 154);
            TypeServiceCbx.Margin = new Padding(4);
            TypeServiceCbx.Name = "TypeServiceCbx";
            TypeServiceCbx.NoSelectionDropdownText = "Empty";
            TypeServiceCbx.NoSelectionText = "None";
            TypeServiceCbx.OutlineColor = Color.Black;
            TypeServiceCbx.OutlineThickness = 1F;
            TypeServiceCbx.Rounding = 8;
            TypeServiceCbx.Size = new Size(308, 45);
            TypeServiceCbx.TabIndex = 57;
            TypeServiceCbx.SelectedIndexChanged += TypeServiceCbx_SelectedIndexChanged;
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
            BackBtn.Location = new Point(136, 376);
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
            BackBtn.TabIndex = 56;
            BackBtn.TextAlignment = StringAlignment.Center;
            BackBtn.TextOffset = new Point(0, 0);
            BackBtn.Click += BackBtn_Click;
            // 
            // VetCbx
            // 
            VetCbx.BackColor = Color.Transparent;
            VetCbx.BackgroundColor = Color.FromArgb(255, 255, 255);
            VetCbx.ButtonCursor = Cursors.Arrow;
            VetCbx.ButtonHoverBackground = Color.FromArgb(15, 28, 243);
            VetCbx.ButtonHoverOutline = Color.Empty;
            VetCbx.ButtonNormalBackground = Color.FromArgb(15, 28, 243);
            VetCbx.ButtonNormalOutline = Color.Empty;
            VetCbx.ButtonPressedBackground = Color.FromArgb(15, 28, 243);
            VetCbx.ButtonPressedOutline = Color.Empty;
            VetCbx.DropDownBackgroundColor = Color.White;
            VetCbx.DropDownOutlineColor = Color.Black;
            VetCbx.ExpandArrowColor = Color.Gray;
            VetCbx.ForeColor = Color.Gray;
            VetCbx.Location = new Point(98, 300);
            VetCbx.Margin = new Padding(4);
            VetCbx.Name = "VetCbx";
            VetCbx.NoSelectionDropdownText = "Empty";
            VetCbx.NoSelectionText = "None";
            VetCbx.OutlineColor = Color.Black;
            VetCbx.OutlineThickness = 1F;
            VetCbx.Rounding = 8;
            VetCbx.Size = new Size(308, 45);
            VetCbx.TabIndex = 55;
            VetCbx.SelectedIndexChanged += VetCbx_SelectedIndexChanged;
            // 
            // cuiLabel4
            // 
            cuiLabel4.BackColor = Color.Transparent;
            cuiLabel4.Content = "Upload\\ Pet\\ Image";
            cuiLabel4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel4.ForeColor = Color.MidnightBlue;
            cuiLabel4.HorizontalAlignment = StringAlignment.Near;
            cuiLabel4.Location = new Point(488, 130);
            cuiLabel4.Margin = new Padding(4);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(152, 23);
            cuiLabel4.TabIndex = 54;
            cuiLabel4.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel3
            // 
            cuiLabel3.BackColor = Color.Transparent;
            cuiLabel3.Content = "Assigned\\ Veterinarian\\*";
            cuiLabel3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel3.ForeColor = Color.MidnightBlue;
            cuiLabel3.HorizontalAlignment = StringAlignment.Near;
            cuiLabel3.Location = new Point(98, 278);
            cuiLabel3.Margin = new Padding(4);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(178, 20);
            cuiLabel3.TabIndex = 53;
            cuiLabel3.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.Transparent;
            cuiLabel2.Content = "Weight\\*";
            cuiLabel2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel2.ForeColor = Color.MidnightBlue;
            cuiLabel2.HorizontalAlignment = StringAlignment.Near;
            cuiLabel2.Location = new Point(98, 207);
            cuiLabel2.Margin = new Padding(4);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(122, 21);
            cuiLabel2.TabIndex = 52;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.BackColor = Color.Transparent;
            CustomerNameLabel.Content = "Customer\\ Pet\\ Information";
            CustomerNameLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerNameLabel.ForeColor = Color.MidnightBlue;
            CustomerNameLabel.HorizontalAlignment = StringAlignment.Center;
            CustomerNameLabel.Location = new Point(233, 38);
            CustomerNameLabel.Margin = new Padding(4);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(301, 34);
            CustomerNameLabel.TabIndex = 51;
            CustomerNameLabel.VerticalAlignment = StringAlignment.Near;
            // 
            // AddPetInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 483);
            Controls.Add(PetPicBox);
            Controls.Add(SaveBtn);
            Controls.Add(WeighttxtBox);
            Controls.Add(cuiLabel6);
            Controls.Add(TypeServiceCbx);
            Controls.Add(BackBtn);
            Controls.Add(VetCbx);
            Controls.Add(cuiLabel4);
            Controls.Add(cuiLabel3);
            Controls.Add(cuiLabel2);
            Controls.Add(CustomerNameLabel);
            Name = "AddPetInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPetInformation";
            Load += AddPetInformation_Load;
            ((System.ComponentModel.ISupportInitialize)PetPicBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PetPicBox;
        private CuoreUI.Controls.cuiButton SaveBtn;
        private CuoreUI.Controls.cuiTextBox WeighttxtBox;
        private CuoreUI.Controls.cuiLabel cuiLabel6;
        private CuoreUI.Controls.cuiComboBox TypeServiceCbx;
        private CuoreUI.Controls.cuiButton BackBtn;
        private CuoreUI.Controls.cuiComboBox VetCbx;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel CustomerNameLabel;
    }
}