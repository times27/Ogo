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
            profileLink.Text = person.FirstName+ " " + person.LastName;
        }

        Person person = new Person();
        LibraryStorage libraryStorage = new LibraryStorage();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WordLibraryForm_Load(object sender, EventArgs e)
        {

        }

        private void createWorldLibraryButton_Click(object sender, EventArgs e)
        {
            WordStorage wordStorage = new WordStorage();
            libraryStorage.AddLibrary(wordStorage);
            foreach (var item in libraryStorage.id)
            {
                worldLibraryListBox.Text += item;
            }

        }
    }
}
