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
            profileLink.Text = person.FirstName + person.FirstName;
        }

        private void profileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProfileForm profileForm = new ProfileForm();
            profileForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WordLibraryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
