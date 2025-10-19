namespace PawCare.AdminPanel
{
    partial class ListOfVetAdmin
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
            BackBtn = new CuoreUI.Controls.cuiButton();
            ColumnSortCbx = new CuoreUI.Controls.cuiComboBox();
            SortCbx = new CuoreUI.Controls.cuiComboBox();
            SearchBtn = new CuoreUI.Controls.cuiButton();
            SearchtxtBox = new CuoreUI.Controls.cuiTextBox();
            VetTableData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)VetTableData).BeginInit();
            SuspendLayout();
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
            BackBtn.Content = "Back to Dashboard";
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
            BackBtn.Location = new Point(1045, 522);
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
            BackBtn.TabIndex = 29;
            BackBtn.TextAlignment = StringAlignment.Center;
            BackBtn.TextOffset = new Point(0, 0);
            BackBtn.Click += BackBtn_Click;
            // 
            // ColumnSortCbx
            // 
            ColumnSortCbx.BackColor = Color.Transparent;
            ColumnSortCbx.BackgroundColor = Color.FromArgb(255, 255, 255);
            ColumnSortCbx.ButtonCursor = Cursors.Arrow;
            ColumnSortCbx.ButtonHoverBackground = Color.FromArgb(192, 255, 106, 0);
            ColumnSortCbx.ButtonHoverOutline = Color.Empty;
            ColumnSortCbx.ButtonNormalBackground = Color.FromArgb(255, 106, 0);
            ColumnSortCbx.ButtonNormalOutline = Color.Empty;
            ColumnSortCbx.ButtonPressedBackground = Color.FromArgb(255, 106, 0);
            ColumnSortCbx.ButtonPressedOutline = Color.Empty;
            ColumnSortCbx.DropDownBackgroundColor = Color.White;
            ColumnSortCbx.DropDownOutlineColor = Color.FromArgb(30, 255, 255, 255);
            ColumnSortCbx.ExpandArrowColor = Color.Gray;
            ColumnSortCbx.ForeColor = Color.Gray;
            ColumnSortCbx.Location = new Point(838, 38);
            ColumnSortCbx.Margin = new Padding(4, 3, 4, 3);
            ColumnSortCbx.Name = "ColumnSortCbx";
            ColumnSortCbx.NoSelectionDropdownText = "Empty";
            ColumnSortCbx.NoSelectionText = "None";
            ColumnSortCbx.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            ColumnSortCbx.OutlineThickness = 1F;
            ColumnSortCbx.Rounding = 8;
            ColumnSortCbx.Size = new Size(157, 36);
            ColumnSortCbx.TabIndex = 28;
            ColumnSortCbx.SelectedIndexChanged += ColumnSortCbx_SelectedIndexChanged;
            // 
            // SortCbx
            // 
            SortCbx.BackColor = Color.Transparent;
            SortCbx.BackgroundColor = Color.FromArgb(255, 255, 255);
            SortCbx.ButtonCursor = Cursors.Arrow;
            SortCbx.ButtonHoverBackground = Color.FromArgb(192, 255, 106, 0);
            SortCbx.ButtonHoverOutline = Color.Empty;
            SortCbx.ButtonNormalBackground = Color.FromArgb(255, 106, 0);
            SortCbx.ButtonNormalOutline = Color.Empty;
            SortCbx.ButtonPressedBackground = Color.FromArgb(255, 106, 0);
            SortCbx.ButtonPressedOutline = Color.Empty;
            SortCbx.DropDownBackgroundColor = Color.White;
            SortCbx.DropDownOutlineColor = Color.FromArgb(30, 255, 255, 255);
            SortCbx.ExpandArrowColor = Color.Gray;
            SortCbx.ForeColor = Color.Gray;
            SortCbx.Location = new Point(1028, 38);
            SortCbx.Margin = new Padding(4, 3, 4, 3);
            SortCbx.Name = "SortCbx";
            SortCbx.NoSelectionDropdownText = "Empty";
            SortCbx.NoSelectionText = "None";
            SortCbx.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            SortCbx.OutlineThickness = 1F;
            SortCbx.Rounding = 8;
            SortCbx.Size = new Size(157, 36);
            SortCbx.TabIndex = 27;
            SortCbx.SelectedIndexChanged += SortCbx_SelectedIndexChanged;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.Transparent;
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
            SearchBtn.Location = new Point(239, 42);
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
            SearchBtn.TabIndex = 26;
            SearchBtn.TextAlignment = StringAlignment.Center;
            SearchBtn.TextOffset = new Point(0, 0);
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SearchtxtBox
            // 
            SearchtxtBox.BackColor = Color.Transparent;
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
            SearchtxtBox.Location = new Point(40, 38);
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
            SearchtxtBox.Size = new Size(192, 38);
            SearchtxtBox.TabIndex = 25;
            SearchtxtBox.TextOffset = new Size(0, 0);
            SearchtxtBox.UnderlinedStyle = false;
            SearchtxtBox.ContentChanged += SearchtxtBox_ContentChanged;
            // 
            // VetTableData
            // 
            VetTableData.AllowUserToAddRows = false;
            VetTableData.AllowUserToDeleteRows = false;
            VetTableData.BackgroundColor = Color.White;
            VetTableData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            VetTableData.GridColor = Color.Black;
            VetTableData.Location = new Point(40, 84);
            VetTableData.Name = "VetTableData";
            VetTableData.ReadOnly = true;
            VetTableData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            VetTableData.Size = new Size(1145, 432);
            VetTableData.TabIndex = 30;
            VetTableData.CellContentClick += VetTableData_CellContentClick;
            // 
            // ListOfVetAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LIST_BACKGROUND;
            ClientSize = new Size(1224, 601);
            Controls.Add(VetTableData);
            Controls.Add(BackBtn);
            Controls.Add(ColumnSortCbx);
            Controls.Add(SortCbx);
            Controls.Add(SearchBtn);
            Controls.Add(SearchtxtBox);
            Name = "ListOfVetAdmin";
            Text = "ListOfVetAdmin";
            Load += ListOfVetAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)VetTableData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiButton BackBtn;
        private CuoreUI.Controls.cuiComboBox ColumnSortCbx;
        private CuoreUI.Controls.cuiComboBox SortCbx;
        private CuoreUI.Controls.cuiButton SearchBtn;
        private CuoreUI.Controls.cuiTextBox SearchtxtBox;
        private DataGridView VetTableData;
    }
}