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
        }

        public Person Person {get;set;}
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
                firstNameTextBox.Enabled = false;
                lastNameTextBox.Enabled = false;
                editProfileButton.Text = "Изменить данные";
            }

        }

        private void deletePersonButton_Click(object sender, EventArgs e)
        {
            Person = null;
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
