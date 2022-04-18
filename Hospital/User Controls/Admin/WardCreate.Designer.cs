
namespace Hospital.User_Controls.Admin
{
    partial class WardCreate
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtWardSpecialty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ddBuilding = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWardDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSave.Location = new System.Drawing.Point(814, 268);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtWardSpecialty
            // 
            this.txtWardSpecialty.Location = new System.Drawing.Point(661, 268);
            this.txtWardSpecialty.Name = "txtWardSpecialty";
            this.txtWardSpecialty.Size = new System.Drawing.Size(125, 27);
            this.txtWardSpecialty.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(661, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ward Specialty";
            // 
            // ddBuilding
            // 
            this.ddBuilding.FormattingEnabled = true;
            this.ddBuilding.Location = new System.Drawing.Point(492, 267);
            this.ddBuilding.Name = "ddBuilding";
            this.ddBuilding.Size = new System.Drawing.Size(151, 28);
            this.ddBuilding.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ward Building";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ward Description";
            // 
            // txtWardDescription
            // 
            this.txtWardDescription.Location = new System.Drawing.Point(348, 267);
            this.txtWardDescription.Name = "txtWardDescription";
            this.txtWardDescription.Size = new System.Drawing.Size(125, 27);
            this.txtWardDescription.TabIndex = 13;
            // 
            // WardCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtWardSpecialty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ddBuilding);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWardDescription);
            this.Name = "WardCreate";
            this.Size = new System.Drawing.Size(1110, 540);
            this.Load += new System.EventHandler(this.WardCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtWardSpecialty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ddBuilding;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWardDescription;
    }
}
