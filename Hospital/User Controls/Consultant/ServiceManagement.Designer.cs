
namespace Hospital.User_Controls.Consultant
{
    partial class ServiceManagement
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
            this.dropdownConsultant1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dropdownConsultant2 = new System.Windows.Forms.ComboBox();
            this.buttonToLeft = new System.Windows.Forms.Button();
            this.buttonToRight = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dropdownConsultant1
            // 
            this.dropdownConsultant1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropdownConsultant1.FormattingEnabled = true;
            this.dropdownConsultant1.Location = new System.Drawing.Point(141, 93);
            this.dropdownConsultant1.Name = "dropdownConsultant1";
            this.dropdownConsultant1.Size = new System.Drawing.Size(252, 31);
            this.dropdownConsultant1.Sorted = true;
            this.dropdownConsultant1.TabIndex = 2;
            this.dropdownConsultant1.DropDown += new System.EventHandler(this.dropdownConsultant1_DropDown);
            this.dropdownConsultant1.SelectedIndexChanged += new System.EventHandler(this.dropdownConsultant1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultant";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(141, 140);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(252, 228);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 28;
            this.listBox2.Location = new System.Drawing.Point(759, 140);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(252, 228);
            this.listBox2.Sorted = true;
            this.listBox2.TabIndex = 7;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(759, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Consultant";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropdownConsultant2
            // 
            this.dropdownConsultant2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropdownConsultant2.FormattingEnabled = true;
            this.dropdownConsultant2.Location = new System.Drawing.Point(759, 93);
            this.dropdownConsultant2.Name = "dropdownConsultant2";
            this.dropdownConsultant2.Size = new System.Drawing.Size(252, 31);
            this.dropdownConsultant2.Sorted = true;
            this.dropdownConsultant2.TabIndex = 5;
            this.dropdownConsultant2.DropDown += new System.EventHandler(this.dropdownConsultant2_DropDown);
            this.dropdownConsultant2.SelectedIndexChanged += new System.EventHandler(this.dropdownConsultant2_SelectedIndexChanged);
            // 
            // buttonToLeft
            // 
            this.buttonToLeft.Enabled = false;
            this.buttonToLeft.Location = new System.Drawing.Point(495, 168);
            this.buttonToLeft.Name = "buttonToLeft";
            this.buttonToLeft.Size = new System.Drawing.Size(150, 40);
            this.buttonToLeft.TabIndex = 8;
            this.buttonToLeft.Text = "<<";
            this.buttonToLeft.UseVisualStyleBackColor = true;
            this.buttonToLeft.Click += new System.EventHandler(this.buttonToLeft_Click);
            // 
            // buttonToRight
            // 
            this.buttonToRight.Enabled = false;
            this.buttonToRight.Location = new System.Drawing.Point(495, 122);
            this.buttonToRight.Name = "buttonToRight";
            this.buttonToRight.Size = new System.Drawing.Size(150, 40);
            this.buttonToRight.TabIndex = 9;
            this.buttonToRight.Text = ">>";
            this.buttonToRight.UseVisualStyleBackColor = true;
            this.buttonToRight.Click += new System.EventHandler(this.buttonToRight_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(495, 289);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 40);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(495, 238);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(150, 40);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // ServiceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonToRight);
            this.Controls.Add(this.buttonToLeft);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dropdownConsultant2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dropdownConsultant1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ServiceManagement";
            this.Size = new System.Drawing.Size(1164, 477);
            this.Load += new System.EventHandler(this.ServiceManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox dropdownConsultant1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dropdownConsultant2;
        private System.Windows.Forms.Button buttonToLeft;
        private System.Windows.Forms.Button buttonToRight;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonReset;
    }
}
