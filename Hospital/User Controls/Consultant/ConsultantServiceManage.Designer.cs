
namespace Hospital.User_Controls
{
    partial class ConsultantServiceManage
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
            this.viewService_button = new System.Windows.Forms.Button();
            this.editService_button = new System.Windows.Forms.Button();
            this.createService_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewService_button
            // 
            this.viewService_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewService_button.Location = new System.Drawing.Point(539, 474);
            this.viewService_button.Name = "viewService_button";
            this.viewService_button.Size = new System.Drawing.Size(230, 96);
            this.viewService_button.TabIndex = 5;
            this.viewService_button.Text = "View Service";
            this.viewService_button.UseVisualStyleBackColor = true;
            // 
            // editService_button
            // 
            this.editService_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editService_button.Location = new System.Drawing.Point(539, 343);
            this.editService_button.Name = "editService_button";
            this.editService_button.Size = new System.Drawing.Size(230, 103);
            this.editService_button.TabIndex = 4;
            this.editService_button.Text = "Edit Service";
            this.editService_button.UseVisualStyleBackColor = true;
            // 
            // createService_button
            // 
            this.createService_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createService_button.Location = new System.Drawing.Point(539, 217);
            this.createService_button.Name = "createService_button";
            this.createService_button.Size = new System.Drawing.Size(230, 103);
            this.createService_button.TabIndex = 3;
            this.createService_button.Text = "Create Service";
            this.createService_button.UseVisualStyleBackColor = true;
            // 
            // ConsultantServiceManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewService_button);
            this.Controls.Add(this.editService_button);
            this.Controls.Add(this.createService_button);
            this.Name = "ConsultantServiceManage";
            this.Size = new System.Drawing.Size(1672, 915);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewService_button;
        private System.Windows.Forms.Button editService_button;
        private System.Windows.Forms.Button createService_button;
    }
}
