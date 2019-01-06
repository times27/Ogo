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
            this.worldLibraryListBox = new System.Windows.Forms.ListBox();
            this.profileLink = new System.Windows.Forms.LinkLabel();
            this.exitButton = new System.Windows.Forms.Button();
            this.createWorldLibraryButton = new System.Windows.Forms.Button();
            this.useWorldLibraryButton = new System.Windows.Forms.Button();
            this.EditWordInLibrary = new System.Windows.Forms.Button();
            this.deleteWorldLibraryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // worldLibraryListBox
            // 
            this.worldLibraryListBox.FormattingEnabled = true;
            this.worldLibraryListBox.ItemHeight = 16;
            this.worldLibraryListBox.Location = new System.Drawing.Point(12, 11);
            this.worldLibraryListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.worldLibraryListBox.Name = "worldLibraryListBox";
            this.worldLibraryListBox.Size = new System.Drawing.Size(329, 420);
            this.worldLibraryListBox.TabIndex = 0;
            // 
            // profileLink
            // 
            this.profileLink.AutoSize = true;
            this.profileLink.LinkColor = System.Drawing.Color.Black;
            this.profileLink.Location = new System.Drawing.Point(592, 23);
            this.profileLink.Name = "profileLink";
            this.profileLink.Size = new System.Drawing.Size(68, 17);
            this.profileLink.TabIndex = 1;
            this.profileLink.TabStop = true;
            this.profileLink.Text = "Профиль";
            this.profileLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.profileLink_LinkClicked);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(647, 333);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(141, 76);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // createWorldLibraryButton
            // 
            this.createWorldLibraryButton.Location = new System.Drawing.Point(347, 11);
            this.createWorldLibraryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createWorldLibraryButton.Name = "createWorldLibraryButton";
            this.createWorldLibraryButton.Size = new System.Drawing.Size(141, 76);
            this.createWorldLibraryButton.TabIndex = 3;
            this.createWorldLibraryButton.Text = "Создать библиотеку слов";
            this.createWorldLibraryButton.UseVisualStyleBackColor = true;
            // 
            // useWorldLibraryButton
            // 
            this.useWorldLibraryButton.Location = new System.Drawing.Point(347, 116);
            this.useWorldLibraryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.useWorldLibraryButton.Name = "useWorldLibraryButton";
            this.useWorldLibraryButton.Size = new System.Drawing.Size(141, 76);
            this.useWorldLibraryButton.TabIndex = 4;
            this.useWorldLibraryButton.Text = "Использовать библиотеку";
            this.useWorldLibraryButton.UseVisualStyleBackColor = true;
            // 
            // EditWordInLibrary
            // 
            this.EditWordInLibrary.Location = new System.Drawing.Point(347, 230);
            this.EditWordInLibrary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditWordInLibrary.Name = "EditWordInLibrary";
            this.EditWordInLibrary.Size = new System.Drawing.Size(141, 76);
            this.EditWordInLibrary.TabIndex = 5;
            this.EditWordInLibrary.Text = "Изменить набор слов в библиотеке";
            this.EditWordInLibrary.UseVisualStyleBackColor = true;
            // 
            // deleteWorldLibraryButton
            // 
            this.deleteWorldLibraryButton.Location = new System.Drawing.Point(347, 333);
            this.deleteWorldLibraryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteWorldLibraryButton.Name = "deleteWorldLibraryButton";
            this.deleteWorldLibraryButton.Size = new System.Drawing.Size(141, 76);
            this.deleteWorldLibraryButton.TabIndex = 6;
            this.deleteWorldLibraryButton.Text = "Удалить библиотеку";
            this.deleteWorldLibraryButton.UseVisualStyleBackColor = true;
            // 
            // WordLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteWorldLibraryButton);
            this.Controls.Add(this.EditWordInLibrary);
            this.Controls.Add(this.useWorldLibraryButton);
            this.Controls.Add(this.createWorldLibraryButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.profileLink);
            this.Controls.Add(this.worldLibraryListBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WordLibraryForm";
            this.Text = "Библиотеки";
            this.Load += new System.EventHandler(this.WordLibraryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox worldLibraryListBox;
        private System.Windows.Forms.LinkLabel profileLink;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button createWorldLibraryButton;
        private System.Windows.Forms.Button useWorldLibraryButton;
        private System.Windows.Forms.Button EditWordInLibrary;
        private System.Windows.Forms.Button deleteWorldLibraryButton;
    }
}