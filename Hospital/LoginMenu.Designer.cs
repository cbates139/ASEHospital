
namespace Hospital
{
    partial class LoginMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageLogo = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStaffId = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPassword = new System.Windows.Forms.MaskedTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageLogo
            // 
            this.imageLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imageLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.imageLogo.Location = new System.Drawing.Point(255, 22);
            this.imageLogo.Name = "imageLogo";
            this.imageLogo.Size = new System.Drawing.Size(100, 100);
            this.imageLogo.TabIndex = 0;
            this.imageLogo.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonLogin.Location = new System.Drawing.Point(267, 301);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(72, 33);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.imageLogo);
            this.groupBox1.Controls.Add(this.textBoxStaffId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonLogin);
            this.groupBox1.Location = new System.Drawing.Point(332, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 542);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(170, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Staff ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(170, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // textBoxStaffId
            // 
            this.textBoxStaffId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxStaffId.Location = new System.Drawing.Point(314, 168);
            this.textBoxStaffId.Mask = "00000";
            this.textBoxStaffId.Name = "textBoxStaffId";
            this.textBoxStaffId.Size = new System.Drawing.Size(157, 23);
            this.textBoxStaffId.TabIndex = 4;
            this.textBoxStaffId.ValidatingType = typeof(int);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxPassword.Location = new System.Drawing.Point(314, 225);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(157, 23);
            this.textBoxPassword.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(509, 233);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(88, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Reset Password";
            // 
            // pageMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "pageMainMenu";
            this.Text = "ASE Hospital | Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageLogo;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textBoxPassword;
        private System.Windows.Forms.MaskedTextBox textBoxStaffId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

