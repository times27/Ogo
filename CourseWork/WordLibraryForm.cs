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
    public partial class WordLibraryForm : Form
    {
        public WordLibraryForm(Person person)
        {
            InitializeComponent();
            this.person = person;
            sectionStorage = libraryStorage.SearchLibrary(person.Login);
            if (sectionStorage.Sections != null)
            {
                foreach (var item in sectionStorage.Sections)
                {
                    sectionStorageListBox.Items.Add(item.nameSection);
                }
            }
            profileLink.Text = person.FirstName+ " " + person.LastName;
            
        }

        Person person = new Person();
        LibraryStorage libraryStorage = new LibraryStorage();
        SectionStorage sectionStorage = new SectionStorage();
        private void profileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ProfileForm profileForm = new ProfileForm(person);
            profileForm.ShowDialog();
            if (profileForm.Person.FirstName == null)
            {
                libraryStorage.DeleteLibrary(profileForm.Person.Login); 
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

        private void WordLibraryForm_Load(object sender, EventArgs e)
        {

        }

        private void createSectionButton_Click(object sender, EventArgs e)
        {
            var oldSectionStorage = sectionStorage;
            sectionStorage.AddSection();
            libraryStorage.EditLibrary(oldSectionStorage,sectionStorage);
            sectionStorageListBox.Items.Add(sectionStorage.Sections.Last().nameSection);
        }

        private void deleteSectionButton_Click(object sender, EventArgs e)
        {
            var oldSectionStorage = sectionStorage;
            sectionStorage.DeleteSection(sectionStorageListBox.SelectedItem.ToString());
            libraryStorage.EditLibrary(oldSectionStorage, sectionStorage);
            sectionStorageListBox.Items.Remove(sectionStorageListBox.SelectedItem);
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
            }
        }

        private void editNameSectionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
