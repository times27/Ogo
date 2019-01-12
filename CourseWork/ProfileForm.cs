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
    public partial class ProfileForm : Form
    {
        public ProfileForm(Person person)
        {
            InitializeComponent();
            Person = person;
            lastNameTextBox.Text = person.LastName;
            firstNameTextBox.Text = person.FirstName;
            loginLabel.Text = "Логин: " + person.Login;
            label1.Text = person.StatisticsToday().DateStatistics.ToShortDateString();
        }

        public Person Person { get; set; }
        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void editProfileButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Enabled == false)
            {
                firstNameTextBox.Enabled = true;
                lastNameTextBox.Enabled = true;
                editProfileButton.Text = "Подтвердить изменения";
            }
            else
            {
                Person person = new Person()
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    Login = loginLabel.Text.Split()[1]
                };
                PersonStorage personStorage = new PersonStorage();
                List<Person> persons = personStorage.EditPerson(Person,person);
                personStorage.SavePersons();
                firstNameTextBox.Enabled = false;
                lastNameTextBox.Enabled = false;
                editProfileButton.Text = "Изменить данные";
                MessageBox.Show("Изменения вступят после перезагрузки");
            }

        }

        private void deletePersonButton_Click(object sender, EventArgs e)
        {
            PersonStorage personStorage = new PersonStorage();
            List<Person> persons = personStorage.DeletePerson(Person); 
            personStorage.SavePersons();
            Person.FirstName = null;
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
