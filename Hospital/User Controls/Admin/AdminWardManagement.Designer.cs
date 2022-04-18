
namespace Hospital.User_Controls
{
    partial class AdminWardManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.editWard_button = new System.Windows.Forms.Button();
            this.createWard_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 692);
            this.panel1.TabIndex = 10;
            // 
            // editWard_button
            // 
            this.editWard_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editWard_button.Location = new System.Drawing.Point(192, 4);
            this.editWard_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.editWard_button.Name = "editWard_button";
            this.editWard_button.Size = new System.Drawing.Size(184, 83);
            this.editWard_button.TabIndex = 8;
            this.editWard_button.Text = "Edit / Remove Ward";
            this.editWard_button.UseVisualStyleBackColor = true;
            // 
            // createWard_button
            // 
            this.createWard_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createWard_button.Location = new System.Drawing.Point(3, 4);
            this.createWard_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.createWard_button.Name = "createWard_button";
            this.createWard_button.Size = new System.Drawing.Size(184, 83);
            this.createWard_button.TabIndex = 7;
            this.createWard_button.Text = "Create Ward";
            this.createWard_button.UseVisualStyleBackColor = true;
            this.createWard_button.Click += new System.EventHandler(this.createWard_button_Click);
            // 
            // AdminWardManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editWard_button);
            this.Controls.Add(this.createWard_button);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximumSize = new System.Drawing.Size(1205, 788);
            this.MinimumSize = new System.Drawing.Size(1205, 788);
            this.Name = "AdminWardManagement";
            this.Size = new System.Drawing.Size(1205, 788);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button editWard_button;
        private System.Windows.Forms.Button createWard_button;
    }
}
