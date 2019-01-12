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
        public WordsForm(Section section)
        {
            InitializeComponent();
            this.section = section;
            if (section.Words != null)
            {
                foreach (var item in section.Words)
                {
                    wordsListBox.Items.Add(item.Piece1 + " - " + item.Piece2);
                }
            }
        }
        Section section;

        private void addWordButton_Click(object sender, EventArgs e)
        {

            if ((Piece1TextBox.Text.Length < 1) || (Piece2TextBox.Text.Length < 1) || ((Piece1TextBox.Text + Piece2TextBox.Text).IndexOf("-") != -1))
            {
                MessageBox.Show("Обе части должны состоять из 1 слова и в словах не допустим символ \"-\" ");
            }
            else
            {
                section.AddWord(Piece1TextBox.Text, Piece2TextBox.Text);
                wordsListBox.Items.Add(Piece1TextBox.Text + " - " + Piece2TextBox.Text);
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string[] words = (wordsListBox.SelectedItem.ToString()).Split('-');
            section.DeleteWord(section.Words,words[0].Remove(words[0].Length-1,1), words[1].Remove(0,1));
            wordsListBox.Items.Remove(wordsListBox.SelectedItem);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
