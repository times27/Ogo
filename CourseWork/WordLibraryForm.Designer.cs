﻿namespace CourseWork
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
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 67);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "libraryListBox";
            this.listBox1.Size = new System.Drawing.Size(266, 238);
            this.listBox1.TabIndex = 0;
            // 
            // profileLink
            // 
            this.profileLink.AutoSize = true;
            this.profileLink.LinkColor = System.Drawing.Color.Black;
            this.profileLink.Location = new System.Drawing.Point(411, 20);
            this.profileLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.profileLink.Name = "profileLink";
            this.profileLink.Size = new System.Drawing.Size(0, 13);
            this.profileLink.TabIndex = 1;
            this.profileLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.profileLink_LinkClicked);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(353, 180);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(106, 62);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // WordLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.profileLink);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WordLibraryForm";
            this.Text = "Библиотеки";
            this.Load += new System.EventHandler(this.WordLibraryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.LinkLabel profileLink;
        private System.Windows.Forms.Button exitButton;
    }
}