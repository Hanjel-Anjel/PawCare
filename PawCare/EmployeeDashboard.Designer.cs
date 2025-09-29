namespace PawCare
{
    partial class EmployeeDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboard));
            CustomerBtn = new CuoreUI.Controls.cuiButton();
            ViewCustomerBtn = new CuoreUI.Controls.cuiButton();
            ViewPetBtn = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // CustomerBtn
            // 
            CustomerBtn.BackColor = Color.Transparent;
            CustomerBtn.CheckButton = false;
            CustomerBtn.Checked = false;
            CustomerBtn.CheckedBackground = Color.FromArgb(255, 106, 0);
            CustomerBtn.CheckedForeColor = Color.White;
            CustomerBtn.CheckedImageTint = Color.White;
            CustomerBtn.CheckedOutline = Color.FromArgb(255, 106, 0);
            CustomerBtn.Content = "+";
            CustomerBtn.DialogResult = DialogResult.None;
            CustomerBtn.Font = new Font("Poppins", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerBtn.ForeColor = Color.White;
            CustomerBtn.HoverBackground = Color.White;
            CustomerBtn.HoverForeColor = Color.Black;
            CustomerBtn.HoverImageTint = Color.White;
            CustomerBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            CustomerBtn.Image = null;
            CustomerBtn.ImageAutoCenter = true;
            CustomerBtn.ImageExpand = new Point(0, 0);
            CustomerBtn.ImageOffset = new Point(0, 0);
            CustomerBtn.Location = new Point(582, 448);
            CustomerBtn.Margin = new Padding(3, 2, 3, 2);
            CustomerBtn.Name = "CustomerBtn";
            CustomerBtn.NormalBackground = Color.FromArgb(54, 214, 206);
            CustomerBtn.NormalForeColor = Color.White;
            CustomerBtn.NormalImageTint = Color.White;
            CustomerBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            CustomerBtn.OutlineThickness = 1F;
            CustomerBtn.PressedBackground = Color.WhiteSmoke;
            CustomerBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            CustomerBtn.PressedImageTint = Color.White;
            CustomerBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            CustomerBtn.Rounding = new Padding(50);
            CustomerBtn.Size = new Size(112, 110);
            CustomerBtn.TabIndex = 0;
            CustomerBtn.TextAlignment = StringAlignment.Center;
            CustomerBtn.TextOffset = new Point(0, 0);
            CustomerBtn.Click += CustomerBtn_Click;
            // 
            // ViewCustomerBtn
            // 
            ViewCustomerBtn.BackColor = Color.Transparent;
            ViewCustomerBtn.BackgroundImage = (Image)resources.GetObject("ViewCustomerBtn.BackgroundImage");
            ViewCustomerBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ViewCustomerBtn.CheckButton = false;
            ViewCustomerBtn.Checked = false;
            ViewCustomerBtn.CheckedBackground = Color.Transparent;
            ViewCustomerBtn.CheckedForeColor = Color.Transparent;
            ViewCustomerBtn.CheckedImageTint = Color.Transparent;
            ViewCustomerBtn.CheckedOutline = Color.Transparent;
            ViewCustomerBtn.Content = "Customer";
            ViewCustomerBtn.DialogResult = DialogResult.None;
            ViewCustomerBtn.Font = new Font("Poppins", 12F);
            ViewCustomerBtn.ForeColor = Color.White;
            ViewCustomerBtn.HoverBackground = Color.Transparent;
            ViewCustomerBtn.HoverForeColor = Color.Transparent;
            ViewCustomerBtn.HoverImageTint = Color.Transparent;
            ViewCustomerBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            ViewCustomerBtn.Image = null;
            ViewCustomerBtn.ImageAutoCenter = true;
            ViewCustomerBtn.ImageExpand = new Point(0, 0);
            ViewCustomerBtn.ImageOffset = new Point(0, 0);
            ViewCustomerBtn.Location = new Point(415, 471);
            ViewCustomerBtn.Name = "ViewCustomerBtn";
            ViewCustomerBtn.NormalBackground = Color.Transparent;
            ViewCustomerBtn.NormalForeColor = Color.White;
            ViewCustomerBtn.NormalImageTint = Color.Transparent;
            ViewCustomerBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            ViewCustomerBtn.OutlineThickness = 1F;
            ViewCustomerBtn.PressedBackground = Color.Transparent;
            ViewCustomerBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            ViewCustomerBtn.PressedImageTint = Color.Transparent;
            ViewCustomerBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            ViewCustomerBtn.RightToLeft = RightToLeft.No;
            ViewCustomerBtn.Rounding = new Padding(8);
            ViewCustomerBtn.Size = new Size(111, 98);
            ViewCustomerBtn.TabIndex = 1;
            ViewCustomerBtn.TextAlignment = StringAlignment.Center;
            ViewCustomerBtn.TextOffset = new Point(0, 0);
            ViewCustomerBtn.Click += ViewCustomerBtn_Click;
            // 
            // ViewPetBtn
            // 
            ViewPetBtn.BackColor = Color.Transparent;
            ViewPetBtn.BackgroundImage = (Image)resources.GetObject("ViewPetBtn.BackgroundImage");
            ViewPetBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ViewPetBtn.CheckButton = false;
            ViewPetBtn.Checked = false;
            ViewPetBtn.CheckedBackground = Color.Transparent;
            ViewPetBtn.CheckedForeColor = Color.Transparent;
            ViewPetBtn.CheckedImageTint = Color.Transparent;
            ViewPetBtn.CheckedOutline = Color.Transparent;
            ViewPetBtn.Content = "Customer";
            ViewPetBtn.DialogResult = DialogResult.None;
            ViewPetBtn.Font = new Font("Poppins", 12F);
            ViewPetBtn.ForeColor = Color.White;
            ViewPetBtn.HoverBackground = Color.Transparent;
            ViewPetBtn.HoverForeColor = Color.Transparent;
            ViewPetBtn.HoverImageTint = Color.Transparent;
            ViewPetBtn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            ViewPetBtn.Image = null;
            ViewPetBtn.ImageAutoCenter = true;
            ViewPetBtn.ImageExpand = new Point(0, 0);
            ViewPetBtn.ImageOffset = new Point(0, 0);
            ViewPetBtn.Location = new Point(741, 471);
            ViewPetBtn.Name = "ViewPetBtn";
            ViewPetBtn.NormalBackground = Color.Transparent;
            ViewPetBtn.NormalForeColor = Color.White;
            ViewPetBtn.NormalImageTint = Color.Transparent;
            ViewPetBtn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            ViewPetBtn.OutlineThickness = 1F;
            ViewPetBtn.PressedBackground = Color.Transparent;
            ViewPetBtn.PressedForeColor = Color.FromArgb(32, 32, 32);
            ViewPetBtn.PressedImageTint = Color.Transparent;
            ViewPetBtn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            ViewPetBtn.RightToLeft = RightToLeft.No;
            ViewPetBtn.Rounding = new Padding(8);
            ViewPetBtn.Size = new Size(111, 98);
            ViewPetBtn.TabIndex = 2;
            ViewPetBtn.TextAlignment = StringAlignment.Center;
            ViewPetBtn.TextOffset = new Point(0, 0);
            ViewPetBtn.Click += ViewPetBtn_Click;
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1223, 581);
            Controls.Add(ViewPetBtn);
            Controls.Add(ViewCustomerBtn);
            Controls.Add(CustomerBtn);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmployeeDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeDashboard";
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiButton CustomerBtn;
        private CuoreUI.Controls.cuiButton ViewCustomerBtn;
        private CuoreUI.Controls.cuiButton ViewPetBtn;
    }
}