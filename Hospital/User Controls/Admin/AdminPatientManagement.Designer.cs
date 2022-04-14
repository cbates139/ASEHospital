
namespace Hospital.User_Controls.Admin
{
    partial class AdminPatientManagement
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
            this.btnRegisterPatient = new System.Windows.Forms.Button();
            this.btnUpdatePatientInfo = new System.Windows.Forms.Button();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegisterPatient
            // 
            this.btnRegisterPatient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegisterPatient.Location = new System.Drawing.Point(159, 84);
            this.btnRegisterPatient.Name = "btnRegisterPatient";
            this.btnRegisterPatient.Size = new System.Drawing.Size(263, 45);
            this.btnRegisterPatient.TabIndex = 1;
            this.btnRegisterPatient.Text = "Register Pation";
            this.btnRegisterPatient.UseVisualStyleBackColor = true;
            this.btnRegisterPatient.Click += new System.EventHandler(this.btnRegisterPatient_Click);
            // 
            // btnUpdatePatientInfo
            // 
            this.btnUpdatePatientInfo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdatePatientInfo.Location = new System.Drawing.Point(159, 148);
            this.btnUpdatePatientInfo.Name = "btnUpdatePatientInfo";
            this.btnUpdatePatientInfo.Size = new System.Drawing.Size(263, 45);
            this.btnUpdatePatientInfo.TabIndex = 2;
            this.btnUpdatePatientInfo.Text = "Update Patient Info";
            this.btnUpdatePatientInfo.UseVisualStyleBackColor = true;
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeletePatient.Location = new System.Drawing.Point(159, 217);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(263, 45);
            this.btnDeletePatient.TabIndex = 3;
            this.btnDeletePatient.Text = "Delete Patient";
            this.btnDeletePatient.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(143, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(315, 45);
            this.label8.TabIndex = 51;
            this.label8.Text = "Patient Managment";
            // 
            // AdminPatientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDeletePatient);
            this.Controls.Add(this.btnUpdatePatientInfo);
            this.Controls.Add(this.btnRegisterPatient);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminPatientManagement";
            this.Size = new System.Drawing.Size(648, 369);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegisterPatient;
        private System.Windows.Forms.Button btnUpdatePatientInfo;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.Label label8;
    }
}
