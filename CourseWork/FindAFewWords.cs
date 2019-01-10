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
    public partial class FindAFewWords : Form
    {
        public FindAFewWords(List<Word> words, int operationMode)
        {
            InitializeComponent();
            this.UsedWords = new List<Word>();
            this.Words = words;
            this.notUsedButtons = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            this.Buttons = new Button[] { activeButton1, activeButton2, activeButton3, activeButton4, activeButton5, activeButton6, activeButton7, activeButton8, activeButton9, activeButton10, activeButton11, activeButton12, activeButton13, activeButton14, activeButton15, activeButton16 };
            int UsedInitialButtons = 8 < this.Words.Count ? 8 : this.Words.Count;
            for (int i = 0; i < UsedInitialButtons; i++)
            {
                Word word = RandomWord(words);
                this.Words.Remove(word);
                RandomWordForButton(word, "0");
                RandomWordForButton(word, "1");
            }
            if (operationMode == 0)
            {
                for (int i = 0; i < Buttons.Length; i++)
                {
                    if (Buttons[i].Tag.ToString().Split()[0] == "0")
                    {
                        Buttons[i].Text = Buttons[i].Tag.ToString().Split()[1];
                    }
                    else
                    {
                        Buttons[i].Text = Buttons[i].Tag.ToString().Split()[2];
                    }

                }
            }
        }
        public Random random = new Random();
        string notActiveButtonText = "Не активная кнопка";
        List<Word> UsedWords { get; set; }
        List<int> notUsedButtons { get; set; }
        List<Word> Words { get; set; }
        Button[] Buttons { get; set; }

        private Word RandomWord(List<Word> words)
        {
            int numberRandom = random.Next(0, words.Count);
            return words[numberRandom];
        }
        private void RandomWordForButton(Word word, string a)
        {
            int numberRandomButton = random.Next(0, notUsedButtons.Count);
            Buttons[notUsedButtons[numberRandomButton]].Tag = a + " " + word.Piece1 + " " + word.Piece2; //tag
            notUsedButtons.Remove(notUsedButtons[numberRandomButton]);
        }
        Button oldButton = new Button();
        private void UsedButton(Button button)
        {
            if (oldButton == null)
            {
                if (oldButton.Tag.ToString().IndexOf(button.Text) != null)
                {
                    MessageBox.Show("dsd");
                    oldButton = null;
                }
                else
                {
                    oldButton = button;
                }
            }
            else
            {
                oldButton = button;
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void activeButton1_Click(object sender, EventArgs e)
        {
            UsedButton(activeButton1);
        }
        private void activeButton2_Click(object sender, EventArgs e)
        {
            UsedButton(activeButton2);
        }
        private void activeButton3_Click(object sender, EventArgs e)
        {
            UsedButton(activeButton3);
        }
        private void activeButton4_Click(object sender, EventArgs e)
        {
            UsedButton(activeButton4);
        }
        private void activeButton5_Click(object sender, EventArgs e)
        {
            UsedButton(activeButton5);
        }
        private void activeButton6_Click(object sender, EventArgs e)
        {
            UsedButton(activeButton6);
        }
        private void activeButton7_Click(object sender, EventArgs e)
        {
            UsedButton(activeButton7);
        }
        private void activeButton8_Click(object sender, EventArgs e)
        {
            UsedButton(activeButton8);
        }
        private void activeButton9_Click(object sender, EventArgs e)
        {
            UsedButton(activeButton9);
        }
        private void activeButton10_Click(object sender, EventArgs e)
        {
            UsedButton(activeButton10);
        }
        private void activeButton11_Click(object sender, EventArgs e)
        {
            UsedButton(activeButton11);
        }
        private void activeButton12_Click(object sender, EventArgs e)
        {
            UsedButton(activeButton12);
        }
        private void activeButton13_Click(object sender, EventArgs e)
        {
            UsedButton(activeButton13);
        }
        private void activeButton14_Click(object sender, EventArgs e)
        {
            UsedButton(activeButton14);
        }
        private void activeButton15_Click(object sender, EventArgs e)
        {
            UsedButton(activeButton15);
        }
        private void activeButton16_Click(object sender, EventArgs e)
        {
            UsedButton(activeButton16);
        }
    }
}
