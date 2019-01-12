namespace CourseWork
{
    partial class WordsForm
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
            this.wordsListBox = new System.Windows.Forms.ListBox();
            this.Piece1TextBox = new System.Windows.Forms.TextBox();
            this.Piece2TextBox = new System.Windows.Forms.TextBox();
            this.addWordButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wordsListBox
            // 
            this.wordsListBox.FormattingEnabled = true;
            this.wordsListBox.ItemHeight = 16;
            this.wordsListBox.Location = new System.Drawing.Point(12, 12);
            this.wordsListBox.Name = "wordsListBox";
            this.wordsListBox.Size = new System.Drawing.Size(311, 420);
            this.wordsListBox.TabIndex = 0;
            // 
            // Piece1TextBox
            // 
            this.Piece1TextBox.Location = new System.Drawing.Point(329, 12);
            this.Piece1TextBox.Name = "Piece1TextBox";
            this.Piece1TextBox.Size = new System.Drawing.Size(229, 22);
            this.Piece1TextBox.TabIndex = 1;
            // 
            // Piece2TextBox
            // 
            this.Piece2TextBox.Location = new System.Drawing.Point(564, 12);
            this.Piece2TextBox.Name = "Piece2TextBox";
            this.Piece2TextBox.Size = new System.Drawing.Size(229, 22);
            this.Piece2TextBox.TabIndex = 2;
            // 
            // addWordButton
            // 
            this.addWordButton.Location = new System.Drawing.Point(329, 40);
            this.addWordButton.Name = "addWordButton";
            this.addWordButton.Size = new System.Drawing.Size(464, 42);
            this.addWordButton.TabIndex = 3;
            this.addWordButton.Text = "Добавить слово";
            this.addWordButton.UseVisualStyleBackColor = true;
            this.addWordButton.Click += new System.EventHandler(this.addWordButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(329, 88);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(464, 42);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Удалить слово";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(329, 390);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(464, 42);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // WordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addWordButton);
            this.Controls.Add(this.Piece2TextBox);
            this.Controls.Add(this.Piece1TextBox);
            this.Controls.Add(this.wordsListBox);
            this.Name = "WordsForm";
            this.Text = "WordsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox wordsListBox;
        private System.Windows.Forms.TextBox Piece1TextBox;
        private System.Windows.Forms.TextBox Piece2TextBox;
        private System.Windows.Forms.Button addWordButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button backButton;
    }
}