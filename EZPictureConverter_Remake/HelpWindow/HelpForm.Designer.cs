namespace EZPictureConverter_Remake.HelpWindow
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Linklabel_Github_Link = new System.Windows.Forms.LinkLabel();
            this.Linklabel_Project_Link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotkeys:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "- Ctrl + O opens a file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "- Ctrl + S Saves a file";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "- Ctrl + H Shows the help window";
            // 
            // Linklabel_Github_Link
            // 
            this.Linklabel_Github_Link.AutoSize = true;
            this.Linklabel_Github_Link.LinkColor = System.Drawing.Color.DodgerBlue;
            this.Linklabel_Github_Link.Location = new System.Drawing.Point(61, 74);
            this.Linklabel_Github_Link.Name = "Linklabel_Github_Link";
            this.Linklabel_Github_Link.Size = new System.Drawing.Size(52, 13);
            this.Linklabel_Github_Link.TabIndex = 4;
            this.Linklabel_Github_Link.TabStop = true;
            this.Linklabel_Github_Link.Text = "MyGithub";
            this.Linklabel_Github_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Linklabel_Github_Link_LinkClicked);
            // 
            // Linklabel_Project_Link
            // 
            this.Linklabel_Project_Link.AutoSize = true;
            this.Linklabel_Project_Link.LinkColor = System.Drawing.Color.DodgerBlue;
            this.Linklabel_Project_Link.Location = new System.Drawing.Point(120, 74);
            this.Linklabel_Project_Link.Name = "Linklabel_Project_Link";
            this.Linklabel_Project_Link.Size = new System.Drawing.Size(59, 13);
            this.Linklabel_Project_Link.TabIndex = 5;
            this.Linklabel_Project_Link.TabStop = true;
            this.Linklabel_Project_Link.Text = "Project link";
            this.Linklabel_Project_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Linklabel_Project_Link_LinkClicked);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(244, 95);
            this.Controls.Add(this.Linklabel_Project_Link);
            this.Controls.Add(this.Linklabel_Github_Link);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HelpForm";
            this.Text = "Help";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HelpForm_FormClosing);
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel Linklabel_Github_Link;
        private System.Windows.Forms.LinkLabel Linklabel_Project_Link;
    }
}