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
            this.sectionStorageListBox = new System.Windows.Forms.ListBox();
            this.profileLink = new System.Windows.Forms.LinkLabel();
            this.exitButton = new System.Windows.Forms.Button();
            this.createSectionButton = new System.Windows.Forms.Button();
            this.matchingWordButton = new System.Windows.Forms.Button();
            this.editWordInLibrary = new System.Windows.Forms.Button();
            this.deleteSectionButton = new System.Windows.Forms.Button();
            this.editNameSectionsButton = new System.Windows.Forms.Button();
            this.coupleWordButton = new System.Windows.Forms.Button();
            this.editNameSectionTextBox = new System.Windows.Forms.TextBox();
            this.editNameSectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sectionStorageListBox
            // 
            this.sectionStorageListBox.FormattingEnabled = true;
            this.sectionStorageListBox.ItemHeight = 16;
            this.sectionStorageListBox.Location = new System.Drawing.Point(12, 11);
            this.sectionStorageListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sectionStorageListBox.Name = "sectionStorageListBox";
            this.sectionStorageListBox.Size = new System.Drawing.Size(329, 420);
            this.sectionStorageListBox.TabIndex = 0;
            // 
            // profileLink
            // 
            this.profileLink.AutoSize = true;
            this.profileLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profileLink.LinkColor = System.Drawing.Color.Black;
            this.profileLink.Location = new System.Drawing.Point(592, 23);
            this.profileLink.Name = "profileLink";
            this.profileLink.Size = new System.Drawing.Size(70, 19);
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
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // createSectionButton
            // 
            this.createSectionButton.Location = new System.Drawing.Point(347, 91);
            this.createSectionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createSectionButton.Name = "createSectionButton";
            this.createSectionButton.Size = new System.Drawing.Size(141, 76);
            this.createSectionButton.TabIndex = 3;
            this.createSectionButton.Text = "Создать секцию слов";
            this.createSectionButton.UseVisualStyleBackColor = true;
            this.createSectionButton.Click += new System.EventHandler(this.createSectionButton_Click);
            // 
            // matchingWordButton
            // 
            this.matchingWordButton.Location = new System.Drawing.Point(558, 138);
            this.matchingWordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.matchingWordButton.Name = "matchingWordButton";
            this.matchingWordButton.Size = new System.Drawing.Size(141, 76);
            this.matchingWordButton.TabIndex = 4;
            this.matchingWordButton.Text = "Сопоставь";
            this.matchingWordButton.UseVisualStyleBackColor = true;
            this.matchingWordButton.Click += new System.EventHandler(this.matchingWordButton_Click);
            // 
            // editWordInLibrary
            // 
            this.editWordInLibrary.Location = new System.Drawing.Point(347, 171);
            this.editWordInLibrary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editWordInLibrary.Name = "editWordInLibrary";
            this.editWordInLibrary.Size = new System.Drawing.Size(141, 76);
            this.editWordInLibrary.TabIndex = 5;
            this.editWordInLibrary.Text = "Изменить набор слов в секции";
            this.editWordInLibrary.UseVisualStyleBackColor = true;
            this.editWordInLibrary.Click += new System.EventHandler(this.editWordInLibrary_Click);
            // 
            // deleteSectionButton
            // 
            this.deleteSectionButton.Location = new System.Drawing.Point(347, 331);
            this.deleteSectionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteSectionButton.Name = "deleteSectionButton";
            this.deleteSectionButton.Size = new System.Drawing.Size(141, 76);
            this.deleteSectionButton.TabIndex = 6;
            this.deleteSectionButton.Text = "Удалить секцию";
            this.deleteSectionButton.UseVisualStyleBackColor = true;
            this.deleteSectionButton.Click += new System.EventHandler(this.deleteSectionButton_Click);
            // 
            // editNameSectionsButton
            // 
            this.editNameSectionsButton.Location = new System.Drawing.Point(347, 251);
            this.editNameSectionsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editNameSectionsButton.Name = "editNameSectionsButton";
            this.editNameSectionsButton.Size = new System.Drawing.Size(141, 76);
            this.editNameSectionsButton.TabIndex = 7;
            this.editNameSectionsButton.Text = "Изменить имя секцию";
            this.editNameSectionsButton.UseVisualStyleBackColor = true;
            this.editNameSectionsButton.Click += new System.EventHandler(this.editNameSectionsButton_Click);
            // 
            // coupleWordButton
            // 
            this.coupleWordButton.Location = new System.Drawing.Point(559, 216);
            this.coupleWordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coupleWordButton.Name = "coupleWordButton";
            this.coupleWordButton.Size = new System.Drawing.Size(141, 76);
            this.coupleWordButton.TabIndex = 8;
            this.coupleWordButton.Text = "Найти парочки";
            this.coupleWordButton.UseVisualStyleBackColor = true;
            this.coupleWordButton.Click += new System.EventHandler(this.coupleWordButton_Click);
            // 
            // editNameSectionTextBox
            // 
            this.editNameSectionTextBox.Location = new System.Drawing.Point(559, 165);
            this.editNameSectionTextBox.Name = "editNameSectionTextBox";
            this.editNameSectionTextBox.Size = new System.Drawing.Size(140, 22);
            this.editNameSectionTextBox.TabIndex = 9;
            this.editNameSectionTextBox.Visible = false;
            // 
            // editNameSectionButton
            // 
            this.editNameSectionButton.Location = new System.Drawing.Point(559, 216);
            this.editNameSectionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editNameSectionButton.Name = "editNameSectionButton";
            this.editNameSectionButton.Size = new System.Drawing.Size(141, 76);
            this.editNameSectionButton.TabIndex = 10;
            this.editNameSectionButton.Text = "Подтвердить изменения";
            this.editNameSectionButton.UseVisualStyleBackColor = true;
            this.editNameSectionButton.Visible = false;
            this.editNameSectionButton.Click += new System.EventHandler(this.editNameSectionButton_Click);
            // 
            // WordLibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editNameSectionButton);
            this.Controls.Add(this.editNameSectionTextBox);
            this.Controls.Add(this.coupleWordButton);
            this.Controls.Add(this.editNameSectionsButton);
            this.Controls.Add(this.deleteSectionButton);
            this.Controls.Add(this.editWordInLibrary);
            this.Controls.Add(this.matchingWordButton);
            this.Controls.Add(this.createSectionButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.profileLink);
            this.Controls.Add(this.sectionStorageListBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WordLibraryForm";
            this.Text = "Библиотеки";
            this.Load += new System.EventHandler(this.WordLibraryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox sectionStorageListBox;
        private System.Windows.Forms.LinkLabel profileLink;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button createSectionButton;
        private System.Windows.Forms.Button matchingWordButton;
        private System.Windows.Forms.Button editWordInLibrary;
        private System.Windows.Forms.Button deleteSectionButton;
        private System.Windows.Forms.Button editNameSectionsButton;
        private System.Windows.Forms.Button coupleWordButton;
        private System.Windows.Forms.TextBox editNameSectionTextBox;
        private System.Windows.Forms.Button editNameSectionButton;
    }
}