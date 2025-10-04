namespace PawCare.AdminPanel
{
    partial class AddPetOwnerName
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
            SearchBtn = new CuoreUI.Controls.cuiButton();
            SearchtxtBox = new CuoreUI.Controls.cuiTextBox();
            CustomerTableData = new DataGridView();
            LnametxtBox = new CuoreUI.Controls.cuiTextBox();
            MnametxtBox = new CuoreUI.Controls.cuiTextBox();
            FnametxtBox = new CuoreUI.Controls.cuiTextBox();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            CustomerNameLabel = new CuoreUI.Controls.cuiLabel();
            NextBtn = new CuoreUI.Controls.cuiButton();
            CancelBtn = new CuoreUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)CustomerTableData).BeginInit();
            SuspendLayout();
            // 
            // SearchBtn
            // 
            SearchBtn.CheckButton = false;
            SearchBtn.Checked = false;
            SearchBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            SearchBtn.CheckedForeColor = Color.White;
            SearchBtn.CheckedImageTint = Color.White;
            SearchBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            SearchBtn.Content = "Search";
            SearchBtn.DialogResult = DialogResult.None;
            SearchBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            SearchBtn.ForeColor = Color.Black;
            SearchBtn.HoverBackground = Color.White;
            SearchBtn.HoverForeColor = Color.Black;
            SearchBtn.HoverImageTint = Color.White;
            SearchBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            SearchBtn.Image = null;
            SearchBtn.ImageAutoCenter = true;
            SearchBtn.ImageExpand = new Point(0, 0);
            SearchBtn.ImageOffset = new Point(0, 0);
            SearchBtn.Location = new Point(367, 16);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.NormalBackground = Color.White;
            SearchBtn.NormalForeColor = Color.Black;
            SearchBtn.NormalImageTint = Color.White;
            SearchBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            SearchBtn.OutlineThickness = 1F;
            SearchBtn.PressedBackground = Color.WhiteSmoke;
            SearchBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            SearchBtn.PressedImageTint = Color.White;
            SearchBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            SearchBtn.Rounding = new Padding(8);
            SearchBtn.Size = new Size(76, 31);
            SearchBtn.TabIndex = 10;
            SearchBtn.TextAlignment = StringAlignment.Center;
            SearchBtn.TextOffset = new Point(0, 0);
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SearchtxtBox
            // 
            SearchtxtBox.BackgroundColor = Color.White;
            SearchtxtBox.Content = "";
            SearchtxtBox.FocusBackgroundColor = Color.White;
            SearchtxtBox.FocusImageTint = Color.White;
            SearchtxtBox.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            SearchtxtBox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchtxtBox.ForeColor = Color.Gray;
            SearchtxtBox.Image = null;
            SearchtxtBox.ImageExpand = new Point(0, 0);
            SearchtxtBox.ImageOffset = new Point(0, 0);
            SearchtxtBox.Location = new Point(32, 13);
            SearchtxtBox.Margin = new Padding(4);
            SearchtxtBox.Multiline = false;
            SearchtxtBox.Name = "SearchtxtBox";
            SearchtxtBox.NormalImageTint = Color.White;
            SearchtxtBox.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            SearchtxtBox.Padding = new Padding(15, 12, 15, 0);
            SearchtxtBox.PasswordChar = false;
            SearchtxtBox.PlaceholderColor = SystemColors.WindowText;
            SearchtxtBox.PlaceholderText = "";
            SearchtxtBox.Rounding = new Padding(8);
            SearchtxtBox.Size = new Size(328, 38);
            SearchtxtBox.TabIndex = 9;
            SearchtxtBox.TextOffset = new Size(0, 0);
            SearchtxtBox.UnderlinedStyle = false;
            SearchtxtBox.ContentChanged += SearchtxtBox_ContentChanged;
            // 
            // CustomerTableData
            // 
            CustomerTableData.AllowUserToAddRows = false;
            CustomerTableData.AllowUserToDeleteRows = false;
            CustomerTableData.BackgroundColor = Color.White;
            CustomerTableData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CustomerTableData.GridColor = Color.Black;
            CustomerTableData.Location = new Point(32, 58);
            CustomerTableData.Name = "CustomerTableData";
            CustomerTableData.ReadOnly = true;
            CustomerTableData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            CustomerTableData.Size = new Size(423, 432);
            CustomerTableData.TabIndex = 11;
            CustomerTableData.CellContentClick += CustomerTableData_CellContentClick;
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
            LnametxtBox.Location = new Point(529, 321);
            LnametxtBox.Margin = new Padding(4, 3, 4, 3);
            LnametxtBox.Multiline = false;
            LnametxtBox.Name = "LnametxtBox";
            LnametxtBox.NormalImageTint = Color.White;
            LnametxtBox.OutlineColor = Color.Black;
            LnametxtBox.Padding = new Padding(17, 14, 17, 0);
            LnametxtBox.PasswordChar = false;
            LnametxtBox.PlaceholderColor = SystemColors.WindowText;
            LnametxtBox.PlaceholderText = "";
            LnametxtBox.Rounding = new Padding(8);
            LnametxtBox.Size = new Size(308, 45);
            LnametxtBox.TabIndex = 31;
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
            MnametxtBox.Location = new Point(529, 237);
            MnametxtBox.Margin = new Padding(4, 3, 4, 3);
            MnametxtBox.Multiline = false;
            MnametxtBox.Name = "MnametxtBox";
            MnametxtBox.NormalImageTint = Color.White;
            MnametxtBox.OutlineColor = Color.Black;
            MnametxtBox.Padding = new Padding(17, 14, 17, 0);
            MnametxtBox.PasswordChar = false;
            MnametxtBox.PlaceholderColor = SystemColors.WindowText;
            MnametxtBox.PlaceholderText = "";
            MnametxtBox.Rounding = new Padding(8);
            MnametxtBox.Size = new Size(308, 45);
            MnametxtBox.TabIndex = 30;
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
            FnametxtBox.Location = new Point(529, 161);
            FnametxtBox.Margin = new Padding(4, 3, 4, 3);
            FnametxtBox.Multiline = false;
            FnametxtBox.Name = "FnametxtBox";
            FnametxtBox.NormalImageTint = Color.White;
            FnametxtBox.OutlineColor = Color.Black;
            FnametxtBox.Padding = new Padding(17, 14, 17, 0);
            FnametxtBox.PasswordChar = false;
            FnametxtBox.PlaceholderColor = SystemColors.WindowText;
            FnametxtBox.PlaceholderText = "";
            FnametxtBox.Rounding = new Padding(8);
            FnametxtBox.Size = new Size(308, 45);
            FnametxtBox.TabIndex = 29;
            FnametxtBox.TextOffset = new Size(0, 0);
            FnametxtBox.UnderlinedStyle = false;
            FnametxtBox.ContentChanged += FnametxtBox_ContentChanged;
            // 
            // cuiLabel3
            // 
            cuiLabel3.BackColor = Color.Transparent;
            cuiLabel3.Content = "Last\\ Name\\*";
            cuiLabel3.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiLabel3.ForeColor = Color.MidnightBlue;
            cuiLabel3.HorizontalAlignment = StringAlignment.Near;
            cuiLabel3.Location = new Point(529, 288);
            cuiLabel3.Margin = new Padding(4);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(122, 26);
            cuiLabel3.TabIndex = 28;
            cuiLabel3.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.Transparent;
            cuiLabel2.Content = "Middle\\ Name\\*";
            cuiLabel2.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiLabel2.ForeColor = Color.MidnightBlue;
            cuiLabel2.HorizontalAlignment = StringAlignment.Near;
            cuiLabel2.Location = new Point(529, 213);
            cuiLabel2.Margin = new Padding(4);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(122, 26);
            cuiLabel2.TabIndex = 27;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "First\\ Name\\*";
            cuiLabel1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiLabel1.ForeColor = Color.MidnightBlue;
            cuiLabel1.HorizontalAlignment = StringAlignment.Near;
            cuiLabel1.Location = new Point(529, 138);
            cuiLabel1.Margin = new Padding(4);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(122, 26);
            cuiLabel1.TabIndex = 26;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.BackColor = Color.Transparent;
            CustomerNameLabel.Content = "Customer\\ Name";
            CustomerNameLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CustomerNameLabel.ForeColor = Color.MidnightBlue;
            CustomerNameLabel.HorizontalAlignment = StringAlignment.Center;
            CustomerNameLabel.Location = new Point(575, 101);
            CustomerNameLabel.Margin = new Padding(4);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(212, 29);
            CustomerNameLabel.TabIndex = 25;
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
            NextBtn.Location = new Point(697, 426);
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
            NextBtn.TabIndex = 33;
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
            CancelBtn.Location = new Point(529, 426);
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
            CancelBtn.TabIndex = 32;
            CancelBtn.TextAlignment = StringAlignment.Center;
            CancelBtn.TextOffset = new Point(0, 0);
            CancelBtn.Click += CancelBtn_Click;
            // 
            // AddPetOwnerName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 535);
            Controls.Add(NextBtn);
            Controls.Add(CancelBtn);
            Controls.Add(LnametxtBox);
            Controls.Add(MnametxtBox);
            Controls.Add(FnametxtBox);
            Controls.Add(cuiLabel3);
            Controls.Add(cuiLabel2);
            Controls.Add(cuiLabel1);
            Controls.Add(CustomerNameLabel);
            Controls.Add(CustomerTableData);
            Controls.Add(SearchBtn);
            Controls.Add(SearchtxtBox);
            Name = "AddPetOwnerName";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPetOwnerName";
            Load += AddPetOwnerName_Load;
            ((System.ComponentModel.ISupportInitialize)CustomerTableData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiButton SearchBtn;
        private CuoreUI.Controls.cuiTextBox SearchtxtBox;
        private DataGridView CustomerTableData;
        private CuoreUI.Controls.cuiTextBox LnametxtBox;
        private CuoreUI.Controls.cuiTextBox MnametxtBox;
        private CuoreUI.Controls.cuiTextBox FnametxtBox;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel CustomerNameLabel;
        private CuoreUI.Controls.cuiButton NextBtn;
        private CuoreUI.Controls.cuiButton CancelBtn;
    }
}