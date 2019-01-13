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
    public partial class WordSectionsForm : Form
    {
        public WordSectionsForm(Person person)
        {
            InitializeComponent();
            this.person = person;
            this.person.LoadSections();
            if (this.person.Sections != null)
            {
                foreach (var item in this.person.Sections)
                {
                    sectionStorageListBox.Items.Add(item.nameSection);
                }
            }
            profileLink.Text = person.FirstName+ " " + person.LastName;
            
        }

        Person person = new Person();
        private void profileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProfileForm profileForm = new ProfileForm(person);
            profileForm.ShowDialog();
            if (profileForm.Person.FirstName == null)
            { 
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createSectionButton_Click(object sender, EventArgs e)
        {

            sectionStorageListBox.Items.Add(person.AddSection().nameSection);
        }

        private void deleteSectionButton_Click(object sender, EventArgs e)
        {
            sectionStorageListBox.Items.Remove(person.DeleteSection(sectionStorageListBox.SelectedItem.ToString()));
        }

        private void editNameSectionsButton_Click(object sender, EventArgs e)
        {
            if(matchingWordButton.Visible==true)
            {
                matchingWordButton.Hide();
                coupleWordButton.Hide();
                editNameSectionButton.Show();
                editNameSectionTextBox.Show();
                editNameSectionTextBox.Text = sectionStorageListBox.SelectedItem.ToString();
            }
            else
            {
                matchingWordButton.Show();
                coupleWordButton.Show();
                editNameSectionButton.Hide();
                editNameSectionTextBox.Hide();

                person.Sections[sectionStorageListBox.SelectedIndex].nameSection = editNameSectionTextBox.Text;
            }
        }


        private void editWordInLibrary_Click(object sender, EventArgs e)
        {
            WordsForm wordsForm = new WordsForm(person.SectionSearch(sectionStorageListBox.SelectedItem.ToString()));
            wordsForm.ShowDialog();
            person.SaveSections(person.Sections);
        }

        private void editNameSectionButton_Click(object sender, EventArgs e)
        {
            matchingWordButton.Show();
            coupleWordButton.Show();
            editNameSectionButton.Hide();
            editNameSectionTextBox.Hide();

            person.Sections[sectionStorageListBox.SelectedIndex].nameSection = editNameSectionTextBox.Text;
            person.SaveSections(person.Sections);
        }

        private void matchingWordButton_Click(object sender, EventArgs e)
        {
            PersonStatistic personStatistic = person.StatisticsToday();
            FindAFewWords findAFewWords = new FindAFewWords(person.SectionSearch(sectionStorageListBox.SelectedItem.ToString()).Words, personStatistic , 0);
            findAFewWords.ShowDialog();
            person.SaveStatistic(person.PersonStatistics);

        }

        private void coupleWordButton_Click(object sender, EventArgs e)
        {
            PersonStatistic personStatistic = person.StatisticsToday();
            FindAFewWords findAFewWords = new FindAFewWords(person.SectionSearch(sectionStorageListBox.SelectedItem.ToString()).Words, personStatistic , 1);
            findAFewWords.ShowDialog();
            person.SaveStatistic(person.PersonStatistics);
        }
    }
}
