
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
            this.viewService_button.Location = new System.Drawing.Point(377, 284);
            this.viewService_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewService_button.Name = "viewService_button";
            this.viewService_button.Size = new System.Drawing.Size(161, 58);
            this.viewService_button.TabIndex = 5;
            this.viewService_button.Text = "View Service";
            this.viewService_button.UseVisualStyleBackColor = true;
            // 
            // editService_button
            // 
            this.editService_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editService_button.Location = new System.Drawing.Point(377, 206);
            this.editService_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editService_button.Name = "editService_button";
            this.editService_button.Size = new System.Drawing.Size(161, 62);
            this.editService_button.TabIndex = 4;
            this.editService_button.Text = "Edit Service";
            this.editService_button.UseVisualStyleBackColor = true;
            // 
            // createService_button
            // 
            this.createService_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createService_button.Location = new System.Drawing.Point(377, 130);
            this.createService_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createService_button.Name = "createService_button";
            this.createService_button.Size = new System.Drawing.Size(161, 62);
            this.createService_button.TabIndex = 3;
            this.createService_button.Text = "Create Service";
            this.createService_button.UseVisualStyleBackColor = true;
            // 
            // ConsultantServiceManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewService_button);
            this.Controls.Add(this.editService_button);
            this.Controls.Add(this.createService_button);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConsultantServiceManage";
            this.Size = new System.Drawing.Size(1170, 549);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewService_button;
        private System.Windows.Forms.Button editService_button;
        private System.Windows.Forms.Button createService_button;
    }
}
