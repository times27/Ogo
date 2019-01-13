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
            
            foreach (var item in person.PersonStatistics)
            {
                mode1Chart.Series[0].Points.AddXY(item.DateStatistics,item.StatisticsMode1s.RightAnswer);
                mode1Chart.Series[1].Points.AddXY(item.DateStatistics, item.StatisticsMode1s.WtongAnswer);
            }
            foreach (var item in person.PersonStatistics)
            {
                double checkTo0 = item.StatisticsMode2s.StarTimes.Minute == 0 ? 1 : item.StatisticsMode2s.StarTimes.Minute;
                double quantityPerMinute = item.StatisticsMode2s.RightAnswer / (checkTo0*60) ;
                mode2Chart.Series[0].Points.AddXY(item.DateStatistics, quantityPerMinute);
            }
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

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
