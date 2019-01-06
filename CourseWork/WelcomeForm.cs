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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }
        public List<Person> Persons { get; set; }
        public PersonStorage personStorage = new PersonStorage();

        private void loginButton_Click(object sender, EventArgs e)
        {
            Persons = personStorage.LoadPersons();
            if (personStorage.LoginInStorage(loginTextBox.Text))
            {
                WordLibraryForm wordLibraryForm = new WordLibraryForm(Persons[Persons.FindIndex((u)=>u.Login==loginTextBox.Text)]);
                this.Hide();
                wordLibraryForm.ShowDialog();
                this.Show();
                
            }
            else
            {
                MessageBox.Show("Ваш логин не зарегистрирован");
            }
        }

        private void newPersonButton_Click(object sender, EventArgs e)
        {
            NewPersonForm personForm = new NewPersonForm();
            personForm.ShowDialog();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
