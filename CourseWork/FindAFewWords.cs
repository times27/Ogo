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
        public FindAFewWords(Section section, int operationMode)
        {
            InitializeComponent();
            this.SetWords = new Section();
            this.SetWords.Words = section.Words;
            this.notUsedButtons = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            this.Buttons = new Button[] { activeButton1, activeButton2, activeButton3, activeButton4, activeButton5, activeButton6, activeButton7, activeButton8, activeButton9, activeButton10, activeButton11, activeButton12, activeButton13, activeButton14, activeButton15, activeButton16 };
            int UsedInitialButtons = 8 < this.SetWords.Words.Count ? 8 : this.SetWords.Words.Count;
            statisticVariableLabel1.Text = "0";
            for (int i = 0; i < UsedInitialButtons; i++)
            {
                Word word = SetWords.RandomWord(this.SetWords.Words);
                this.SetWords.DeleteWord(word.Piece1, word.Piece2);
                RandomWordForButton(word, "0");
                RandomWordForButton(word, "1");
            }
            if (operationMode == 0)
            {
                nameStatisticVariableLabel2.Text = "Не верные ответы";
                statisticVariableLabel2.Text = "0";
                for (int i = 0; i < Buttons.Length; i++)
                {
                    NameButton(Buttons[i]);
                }
            }
            else
            {
                statisticVariableLabel1.Text = "0";
                nameStatisticVariableLabel2.Text = "Время:";
            }
        }
        public Random random = new Random();
        string notActiveButtonText = "Не активная кнопка";
        Section SetWords { get; set; }
        List<int> notUsedButtons { get; set; }
        Button[] Buttons { get; set; }
        private void RandomWordForButton(Word word, string a)
        {
            int numberRandomButton = random.Next(0, notUsedButtons.Count);
            Buttons[notUsedButtons[numberRandomButton]].Tag = a + word.Piece1 + "-" + word.Piece2; //tag
            notUsedButtons.Remove(notUsedButtons[numberRandomButton]);
        }
        private void NameButton(Button button)
        {
            string nameButton = button.Tag.ToString();
            if (nameButton != notActiveButtonText)
            {
                if (nameButton[0] == '0')
                {
                    button.Text = nameButton.Remove(0, 1).Split('-')[0];
                }
                else
                {
                    button.Text = nameButton.Split('-')[1];
                }
            }
            else
            {
                button.Enabled = false;
            }
        }

        string oldButton = null;
        private void UsedButton(Button button)
        {

          
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttons_Click(object sender, EventArgs e)
        {
            UsedButton(sender as Button);
        }

    }

}
