
namespace Hospital.User_Controls
{
    partial class ConsultantHome
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
            this.home_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // home_label
            // 
            this.home_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.home_label.AutoSize = true;
            this.home_label.Location = new System.Drawing.Point(335, 153);
            this.home_label.Name = "home_label";
            this.home_label.Size = new System.Drawing.Size(61, 25);
            this.home_label.TabIndex = 0;
            this.home_label.Text = "Home";
            // 
            // ConsultantHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.home_label);
            this.Name = "ConsultantHome";
            this.Size = new System.Drawing.Size(1121, 776);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label home_label;
    }
}
