using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class PeopleForm : Form
    {
        List<PersonModel> people = new List<PersonModel>();

        public PeopleForm()
        {
            InitializeComponent();
            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            //people.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            //people.Add(new PersonModel { FirstName = "John", LastName = "Doe" });
            //people.Add(new PersonModel { FirstName = "Mary", LastName = "Smith" });
            people = SqliteDataAccess.LoadPeople();
            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            listPeopleListBox.DataSource = null;
            listPeopleListBox.DataSource = people;
            listPeopleListBox.DisplayMember = "FullName";
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text
            };

            //people.Add(p);
            //WireUpPeopleList();
            SqliteDataAccess.SavePerson(p);

            firstNameText.Clear();
            lastNameText.Clear();
        }

        private void RefreshListButton_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }
    }
}
