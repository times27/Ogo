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
            this.setWord = words;
            this.operationMode = operationMode;
            
            //    this.PersonStatistics = 
            this.Buttons = new Button[] { activeButton1, activeButton2, activeButton3, activeButton4, activeButton5, activeButton6, activeButton7, activeButton8, activeButton9, activeButton10, activeButton11, activeButton12, activeButton13, activeButton14, activeButton15, activeButton16 };
            FillButton();
            statisticVariableLabel1.Text = "0";
        }
        public PersonStatistic PersonStatistics { get; set; }
        public Random random = new Random();
        public int operationMode;
        string notActiveButtonText = "Не активная кнопка";
        string activeButtonText = "Активная кнопка";
        int usedButtons;
        int rightAnswer = 0;
        int wtongAnswer = 0;
        DateTime starTimes = new DateTime(0,0);
        List<Word> setWord;
        List<int> notUsedButtons;
        Button[] Buttons { get; set; }
        private void WordForRandomButton(Word word, string piece)
        {
            int numberRandomButton = random.Next(0, notUsedButtons.Count);
            Buttons[notUsedButtons[numberRandomButton]].Tag = piece + word.Piece1 + "-" + word.Piece2; //tag
            Buttons[notUsedButtons[numberRandomButton]].Text = activeButtonText;
            Buttons[notUsedButtons[numberRandomButton]].Enabled = true;
            notUsedButtons.Remove(notUsedButtons[numberRandomButton]);
        }
        public Word RandomWord(List<Word> words)
        {
            int numberRandom = random.Next(0, words.Count);
            return words[numberRandom];
        }
        private void FillButton()
        {
            notUsedButtons = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            usedButtons = 8 < this.setWord.Count ? 8 : this.setWord.Count;
            for (int i = 0; i < usedButtons; i++)
            {
                Word word = RandomWord(this.setWord);
                this.setWord.Remove(word);
                WordForRandomButton(word, "0");
                WordForRandomButton(word, "1");
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

        
        private void UsedButton(Button button)
        {
            raudaTime.Enabled = true;
            if (oldButton == null)
            {
                oldButton = button;
                if( operationMode != 0)
                {
                    NameButton(button);
                }
            }
            else
            {
                if (oldButton != button)
                {
                    if (operationMode != 0)
                    {
                        NameButton(button);
                    }
                    if (oldButton.Tag.ToString().IndexOf(button.Text) != -1)
                    {
                        ++rightAnswer;
                        statisticVariableLabel1.Text = rightAnswer.ToString();
                        statisticVariableLabel1.Focus();

                        --usedButtons;
                        oldButton.Enabled = false;
                        oldButton.Tag = notActiveButtonText;
                        button.Enabled = false;
                        button.Tag = notActiveButtonText;
                        if (usedButtons == 0)
                        {
                            FillButton();
                        }
                    }
                    else
                    {
                        if (operationMode == 0)
                        {
                            ++wtongAnswer;
                            statisticVariableLabel2.Text = wtongAnswer.ToString();
                            statisticVariableLabel2.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Слова скоро закроются");
                            oldButton.Text = activeButtonText;
                            button.Text = activeButtonText;
                        }
                    }
                    oldButton = null;
                }
            }
        }
        Button oldButton = null;
       
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttons_Click(object sender, EventArgs e)
        {
            UsedButton(sender as Button);
        }

        private void raudaTime_Tick(object sender, EventArgs e)
        {
            starTimes.AddSeconds(1);
            statisticVariableLabel2.Text = starTimes.ToString("mm:ss");
        }
    }

}
