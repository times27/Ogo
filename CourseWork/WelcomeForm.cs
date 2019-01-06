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
            Person = personStorage.LoadPersons();
        }
        public List<Person> Person { get; set; }
        public PersonStorage personStorage = new PersonStorage();
        private void loginButton_Click(object sender, EventArgs e)
        {
            if(personStorage.LoginInStorage(loginTextBox.Text))
            {
                WordLibraryForm wordLibraryForm = new WordLibraryForm(Person[Person.FindIndex((u)=>u.Login==loginTextBox.Text)]);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
