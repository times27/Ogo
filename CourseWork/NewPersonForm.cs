﻿using System;
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
    public partial class NewPersonForm : Form
    {
        public NewPersonForm()
        {
            InitializeComponent();
            Persons = personStorage.LoadPersons();
        }

        PersonStorage personStorage = new PersonStorage();
        public List<Person> Persons { get; set; }
        private void newPersonButton_Click(object sender, EventArgs e)
        {
            Person person = new Person()
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Login = loginTextBox.Text
            };
            if (!personStorage.LoginInStorage(person.Login))
            {
                Persons = personStorage.AddPerson(person);
                personStorage.SavePersons(Persons);
                MessageBox.Show("Пользователь добавлен.");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Такой логин уже существует, измените логин!");
            }
        }

        private void PersonForm_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }
    }
}