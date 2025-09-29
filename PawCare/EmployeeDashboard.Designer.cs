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
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1223, 581);
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
    }
}