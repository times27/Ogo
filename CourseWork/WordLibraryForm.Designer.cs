namespace CourseWork
{
    partial class WordLibraryForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.profileLink = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(353, 292);
            this.listBox1.TabIndex = 0;
            // 
            // profileLink
            // 
            this.profileLink.AutoSize = true;
            this.profileLink.LinkColor = System.Drawing.Color.Black;
            this.profileLink.Location = new System.Drawing.Point(548, 24);
            this.profileLink.Name = "profileLink";
            this.profileLink.Size = new System.Drawing.Size(0, 17);
            this.profileLink.TabIndex = 1;
            this.profileLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.profileLink_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WordLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.profileLink);
            this.Controls.Add(this.listBox1);
            this.Name = "WordLibraryForm";
            this.Text = "Библиотеки";
            this.Load += new System.EventHandler(this.WordLibraryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.LinkLabel profileLink;
        private System.Windows.Forms.Button button1;
    }
}