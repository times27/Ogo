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
        public FindAFewWords(WordStorage wordStorage,int operationMode)
        {
            InitializeComponent();
            this.UsedWords = new List<Word>();
            this.wordStorage = wordStorage;
            this.Buttons = new Button[] { activeButton1, activeButton2, activeButton3, activeButton4, activeButton5, activeButton6, activeButton7, activeButton8, activeButton9, activeButton10, activeButton11, activeButton12, activeButton13, activeButton14, activeButton15, activeButton16 };
            int UsedInitialButtons = 16 < wordStorage.Words.Count*2 ? 16 : wordStorage.Words.Count;
            for (int i = 0; i < UsedInitialButtons ; i++)
            {
                Random1WordForButton(wordStorage.RandomWord(wordStorage.Words));
            }
            if (operationMode == 0)
            {
                for (int i = 0; i < UsedInitialButtons; i++)
                {
                    if (Buttons[i].Text.Split()[0] == "0")
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
        WordStorage wordStorage { get; set; }
        Button[] Buttons { get; set; }

        private void Random1WordForButton(Word word)
        {
            int numberRandomButton = random.Next(0, Buttons.Length);
            if(Buttons[numberRandomButton].Tag.ToString() !=word.Piece1)
            {
                Buttons[numberRandomButton].Tag = 0 + " " + word.Piece1 + " " + word.Piece2;
                Random2WordForButton(word);
            }
            else
            {
                Random1WordForButton(word);
            }
        }
        private void Random2WordForButton(Word word)
        {
            int numberRandomButton = random.Next(0, Buttons.Length);

            if (Buttons[numberRandomButton].Tag.ToString() != word.Piece2)
            {
                Buttons[numberRandomButton].Tag = 1 + " " + word.Piece1 + " " + word.Piece2;
            }
            else
            {
                Random2WordForButton(word);
            }
        }

        public Word CheckUsedWord(Word word)
        {
            if (UsedWords.Find(u => u.Piece1 == word.Piece1) == null)
            {
                UsedWords.Add(word);
                return word;
            }
            else
            {
                Word newWord = wordStorage.RandomWord(wordStorage.Words);
                return CheckUsedWord(newWord);
            }
        }
        private void UsedButton(Button button)
        {
            if (activeButton2.CausesValidation)
            {
                MessageBox.Show("d");
               
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
