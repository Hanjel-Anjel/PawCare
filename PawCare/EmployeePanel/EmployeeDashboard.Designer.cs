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
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            pawcareLabel = new Label();
            logoutBtn = new Button();
            vetlistBtn = new Button();
            petlistBtn = new Button();
            customerlistBtn = new Button();
            addnewpatientBtn = new Button();
            employeenameLabel = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(4, 11, 77);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1223, 45);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(531, 13);
            label1.Name = "label1";
            label1.Size = new Size(158, 16);
            label1.TabIndex = 11;
            label1.Text = "Employee Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pawcareLabel);
            panel1.Controls.Add(logoutBtn);
            panel1.Controls.Add(vetlistBtn);
            panel1.Controls.Add(petlistBtn);
            panel1.Controls.Add(customerlistBtn);
            panel1.Controls.Add(addnewpatientBtn);
            panel1.Controls.Add(employeenameLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 716);
            panel1.TabIndex = 6;
            // 
            // pawcareLabel
            // 
            pawcareLabel.AutoSize = true;
            pawcareLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pawcareLabel.ForeColor = Color.White;
            pawcareLabel.Location = new Point(65, 694);
            pawcareLabel.Name = "pawcareLabel";
            pawcareLabel.Size = new Size(88, 13);
            pawcareLabel.TabIndex = 10;
            pawcareLabel.Text = "PawCare @2025";
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.Firebrick;
            logoutBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Location = new Point(12, 624);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(200, 40);
            logoutBtn.TabIndex = 9;
            logoutBtn.Text = "Logout";
            logoutBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click_1;
            // 
            // vetlistBtn
            // 
            vetlistBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vetlistBtn.ImageAlign = ContentAlignment.MiddleLeft;
            vetlistBtn.Location = new Point(12, 423);
            vetlistBtn.Name = "vetlistBtn";
            vetlistBtn.Size = new Size(200, 40);
            vetlistBtn.TabIndex = 8;
            vetlistBtn.Text = "Vet List";
            vetlistBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            vetlistBtn.UseVisualStyleBackColor = true;
            vetlistBtn.Click += vetlistBtn_Click;
            // 
            // petlistBtn
            // 
            petlistBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            petlistBtn.ImageAlign = ContentAlignment.MiddleLeft;
            petlistBtn.Location = new Point(12, 377);
            petlistBtn.Name = "petlistBtn";
            petlistBtn.Size = new Size(200, 40);
            petlistBtn.TabIndex = 6;
            petlistBtn.Text = "Pet List";
            petlistBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            petlistBtn.UseVisualStyleBackColor = true;
            petlistBtn.Click += petlistBtn_Click;
            // 
            // customerlistBtn
            // 
            customerlistBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerlistBtn.ImageAlign = ContentAlignment.MiddleLeft;
            customerlistBtn.Location = new Point(12, 331);
            customerlistBtn.Name = "customerlistBtn";
            customerlistBtn.Size = new Size(200, 40);
            customerlistBtn.TabIndex = 5;
            customerlistBtn.Text = "Customer List";
            customerlistBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            customerlistBtn.UseVisualStyleBackColor = true;
            customerlistBtn.Click += customerlistBtn_Click;
            // 
            // addnewpatientBtn
            // 
            addnewpatientBtn.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addnewpatientBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addnewpatientBtn.Location = new Point(12, 285);
            addnewpatientBtn.Name = "addnewpatientBtn";
            addnewpatientBtn.Size = new Size(200, 40);
            addnewpatientBtn.TabIndex = 4;
            addnewpatientBtn.Text = "Add New Patient";
            addnewpatientBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addnewpatientBtn.UseVisualStyleBackColor = true;
            addnewpatientBtn.Click += addnewpatientBtn_Click;
            // 
            // employeenameLabel
            // 
            employeenameLabel.AutoSize = true;
            employeenameLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeenameLabel.ForeColor = Color.White;
            employeenameLabel.Location = new Point(61, 193);
            employeenameLabel.Name = "employeenameLabel";
            employeenameLabel.Size = new Size(97, 13);
            employeenameLabel.TabIndex = 2;
            employeenameLabel.Text = "Employee Name";
            employeenameLabel.Click += employeenameLabel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(35, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 211, 221);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1223, 761);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "EmployeeDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeDashboard";
            Load += EmployeeDashboard_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label employeenameLabel;
        private Button addnewpatientBtn;
        private Button customerlistBtn;
        private Button petlistBtn;
        private Button vetlistBtn;
        private Button logoutBtn;
        private Label pawcareLabel;
        private Label label1;
    }
}