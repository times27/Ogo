using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class WordsForm : Form
    {
        public WordsForm(WordStorage wordStorage)
        {
            InitializeComponent();
            this.wordStorage = wordStorage;
            if (wordStorage.Words != null)
            {
                foreach (var item in wordStorage.Words)
                {
                    wordsListBox.Items.Add(item.Piece1+" - "+item.Piece2);
                }
            }
        }
        WordStorage wordStorage;

        private void wordsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addWordButton_Click(object sender, EventArgs e)
        {
            if ((Piece1TextBox.Text.Length < 1) || (Piece2TextBox.Text.Length < 1))
            {
                MessageBox.Show("Добавьте обе части");
            }
            else
            {
                if ((Piece1TextBox.Text.Length < 1) || (Piece2TextBox.Text.Length<1))
                {
                    MessageBox.Show("Обе части должны состоять из 1 слова");
                }
                else
                {
                    wordStorage.AddWord(Piece1TextBox.Text, Piece2TextBox.Text);
                    wordsListBox.Items.Add(Piece1TextBox.Text + " - " + Piece2TextBox.Text);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string[] words = (wordsListBox.SelectedItem.ToString()).Split();
            wordStorage.DeleteWord(words[0], words[2]);
            wordsListBox.Items.Remove(wordsListBox.SelectedItem);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
