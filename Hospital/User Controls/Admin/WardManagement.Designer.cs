
namespace Hospital.User_Controls.Admin
{
    partial class WardManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ddWard = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWardID = new System.Windows.Forms.TextBox();
            this.txtWardDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ddBuilding = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWardSpecialty = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ddWard
            // 
            this.ddWard.FormattingEnabled = true;
            this.ddWard.Location = new System.Drawing.Point(206, 87);
            this.ddWard.Name = "ddWard";
            this.ddWard.Size = new System.Drawing.Size(151, 28);
            this.ddWard.TabIndex = 0;
            this.ddWard.SelectedIndexChanged += new System.EventHandler(this.ddWard_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ward";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "WardID";
            // 
            // txtWardID
            // 
            this.txtWardID.Location = new System.Drawing.Point(206, 187);
            this.txtWardID.Name = "txtWardID";
            this.txtWardID.ReadOnly = true;
            this.txtWardID.Size = new System.Drawing.Size(125, 27);
            this.txtWardID.TabIndex = 3;
            // 
            // txtWardDescription
            // 
            this.txtWardDescription.Location = new System.Drawing.Point(351, 187);
            this.txtWardDescription.Name = "txtWardDescription";
            this.txtWardDescription.Size = new System.Drawing.Size(125, 27);
            this.txtWardDescription.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ward Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ward Building";
            // 
            // ddBuilding
            // 
            this.ddBuilding.FormattingEnabled = true;
            this.ddBuilding.Location = new System.Drawing.Point(495, 187);
            this.ddBuilding.Name = "ddBuilding";
            this.ddBuilding.Size = new System.Drawing.Size(151, 28);
            this.ddBuilding.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(664, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ward Specialty";
            // 
            // txtWardSpecialty
            // 
            this.txtWardSpecialty.Location = new System.Drawing.Point(664, 188);
            this.txtWardSpecialty.Name = "txtWardSpecialty";
            this.txtWardSpecialty.Size = new System.Drawing.Size(125, 27);
            this.txtWardSpecialty.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSave.Location = new System.Drawing.Point(817, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.ForeColor = System.Drawing.Color.DarkRed;
            this.btnDelete.Location = new System.Drawing.Point(928, 188);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // WardManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtWardSpecialty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ddBuilding);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWardDescription);
            this.Controls.Add(this.txtWardID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddWard);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "WardManagement";
            this.Size = new System.Drawing.Size(1110, 540);
            this.Load += new System.EventHandler(this.WardManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddWard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWardID;
        private System.Windows.Forms.TextBox txtWardDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddBuilding;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWardSpecialty;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}
