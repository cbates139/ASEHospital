
namespace Hospital
{
    partial class EmergencyContact
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
            this.btnBack = new System.Windows.Forms.Button();
            this.tbERelation = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbEMobileNumber = new System.Windows.Forms.TextBox();
            this.tbEName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbELastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.imageLogo = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(193, 478);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 46);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbERelation
            // 
            this.tbERelation.Location = new System.Drawing.Point(422, 400);
            this.tbERelation.Name = "tbERelation";
            this.tbERelation.Size = new System.Drawing.Size(200, 23);
            this.tbERelation.TabIndex = 23;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(584, 478);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(146, 46);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbEMobileNumber
            // 
            this.tbEMobileNumber.Location = new System.Drawing.Point(422, 346);
            this.tbEMobileNumber.Name = "tbEMobileNumber";
            this.tbEMobileNumber.Size = new System.Drawing.Size(200, 23);
            this.tbEMobileNumber.TabIndex = 22;
            this.tbEMobileNumber.TextChanged += new System.EventHandler(this.tbEMobileNumber_TextChanged);
            // 
            // tbEName
            // 
            this.tbEName.Location = new System.Drawing.Point(422, 236);
            this.tbEName.Name = "tbEName";
            this.tbEName.Size = new System.Drawing.Size(200, 23);
            this.tbEName.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(238, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "Relation :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(238, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 30);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mobile Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(235, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 30);
            this.label1.TabIndex = 28;
            this.label1.Text = "First Name : ";
            // 
            // tbELastName
            // 
            this.tbELastName.Location = new System.Drawing.Point(422, 291);
            this.tbELastName.Name = "tbELastName";
            this.tbELastName.Size = new System.Drawing.Size(200, 23);
            this.tbELastName.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(235, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 30);
            this.label4.TabIndex = 42;
            this.label4.Text = "Last Name : ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(107, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 15);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            // 
            // imageLogo
            // 
            this.imageLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.imageLogo.Location = new System.Drawing.Point(1, 12);
            this.imageLogo.Name = "imageLogo";
            this.imageLogo.Size = new System.Drawing.Size(100, 100);
            this.imageLogo.TabIndex = 44;
            this.imageLogo.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(298, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 37);
            this.label7.TabIndex = 51;
            this.label7.Text = "All the fields must be filled";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(179, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(578, 50);
            this.label6.TabIndex = 50;
            this.label6.Text = "Emergency Contact Information";
            // 
            // EmergencyContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 613);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.imageLogo);
            this.Controls.Add(this.tbELastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbERelation);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbEMobileNumber);
            this.Controls.Add(this.tbEName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmergencyContact";
            this.Text = "EmergencyContact";
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbERelation;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbEMobileNumber;
        private System.Windows.Forms.TextBox tbEName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbELastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox imageLogo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}