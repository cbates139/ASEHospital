
namespace Hospital
{
    partial class AdminForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NavBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logout_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.home_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.patientManagement_button = new System.Windows.Forms.Button();
            this.staffManagement_button = new System.Windows.Forms.Button();
            this.wardManagement_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.NavBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 60);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NavBar
            // 
            this.NavBar.BackColor = System.Drawing.SystemColors.GrayText;
            this.NavBar.Controls.Add(this.label1);
            this.NavBar.Controls.Add(this.pictureBox1);
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavBar.Location = new System.Drawing.Point(0, 0);
            this.NavBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(1264, 90);
            this.NavBar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // logout_button
            // 
            this.logout_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logout_button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logout_button.Location = new System.Drawing.Point(2, 2);
            this.logout_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(206, 94);
            this.logout_button.TabIndex = 7;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // back_button
            // 
            this.back_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back_button.Location = new System.Drawing.Point(2, 198);
            this.back_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(206, 94);
            this.back_button.TabIndex = 6;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // home_button
            // 
            this.home_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home_button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.home_button.Location = new System.Drawing.Point(2, 100);
            this.home_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(206, 94);
            this.home_button.TabIndex = 5;
            this.home_button.Text = "Home";
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 591);
            this.panel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.back_button, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.logout_button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.home_button, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.patientManagement_button, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.staffManagement_button, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.wardManagement_button, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(210, 591);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // patientManagement_button
            // 
            this.patientManagement_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientManagement_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patientManagement_button.Location = new System.Drawing.Point(2, 296);
            this.patientManagement_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientManagement_button.Name = "patientManagement_button";
            this.patientManagement_button.Size = new System.Drawing.Size(206, 94);
            this.patientManagement_button.TabIndex = 8;
            this.patientManagement_button.Text = "Patient Management";
            this.patientManagement_button.UseVisualStyleBackColor = true;
            this.patientManagement_button.Click += new System.EventHandler(this.patients_button_Click);
            // 
            // staffManagement_button
            // 
            this.staffManagement_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffManagement_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.staffManagement_button.Location = new System.Drawing.Point(2, 394);
            this.staffManagement_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.staffManagement_button.Name = "staffManagement_button";
            this.staffManagement_button.Size = new System.Drawing.Size(206, 94);
            this.staffManagement_button.TabIndex = 9;
            this.staffManagement_button.Text = "Staff Management";
            this.staffManagement_button.UseVisualStyleBackColor = true;
            this.staffManagement_button.Click += new System.EventHandler(this.staffManagement_button_Click);
            // 
            // wardManagement_button
            // 
            this.wardManagement_button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wardManagement_button.Location = new System.Drawing.Point(2, 492);
            this.wardManagement_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wardManagement_button.Name = "wardManagement_button";
            this.wardManagement_button.Size = new System.Drawing.Size(206, 50);
            this.wardManagement_button.TabIndex = 10;
            this.wardManagement_button.Text = "Ward Management";
            this.wardManagement_button.UseVisualStyleBackColor = true;
            this.wardManagement_button.Click += new System.EventHandler(this.wardManagement_button_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(210, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1054, 591);
            this.panel2.TabIndex = 6;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NavBar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "AdminForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.NavBar.ResumeLayout(false);
            this.NavBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel NavBar;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button patientManagement_button;
        private System.Windows.Forms.Button staffManagement_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button wardManagement_button;
    }
}