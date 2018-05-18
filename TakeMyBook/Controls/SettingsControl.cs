using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeMyBook
{
    public partial class SettingsControl : UserControl
    {
        BooksContext context = new BooksContext();
        Department myDepartment;
        public List<Department> departments { get; set; } = null;

        public SettingsControl()
        {
            InitializeComponent();

            nicknameTextBox.Text = ReaderInfo.nicknameReader;

            try
            {
                departments = context.Departments.ToList();
                for (int i = 0; i < departments.Count; i++)
                {
                    if (!countryComboBox.Items.Contains(departments[i].country))
                        countryComboBox.Items.Add(departments[i].country);
                }
            }
            catch { }
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityComboBox.Enabled = true;
            if (departments == null)
                departments = context.Departments.ToList();

            cityComboBox.Items.Clear();
            addressComboBox.Items.Clear();
            cityComboBox.Text = "";
            addressComboBox.Text = "";
            openingHoursTextBox.Text = "";

            for (int i = 0; i < departments.Count; i++)
            {
                if (departments[i].country == countryComboBox.Text)
                    if (!cityComboBox.Items.Contains(departments[i].city))
                        cityComboBox.Items.Add(departments[i].city);
            }
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addressComboBox.Enabled = true;
            if (departments == null)
                departments = context.Departments.ToList();

            addressComboBox.Items.Clear();
            addressComboBox.Text = "";
            openingHoursTextBox.Text = "";

            for (int i = 0; i < departments.Count; i++)
            {
                if (departments[i].country == countryComboBox.Text)
                    if (departments[i].city == cityComboBox.Text)
                        if (!addressComboBox.Items.Contains(departments[i].address))
                            addressComboBox.Items.Add(departments[i].address);
            }
        }

        private void addressComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (departments == null)
                departments = context.Departments.ToList();

            myDepartment = context.Departments.Single(d => d.country == countryComboBox.Text &&
                                                               d.city == cityComboBox.Text &&
                                                               d.address == addressComboBox.Text);
            openingHoursTextBox.Text = myDepartment.openingHours;
        }

        private void changeNameButton_Click(object sender, EventArgs e)
        {
            var reader = context.Readers.Single(r => r.nickname == ReaderInfo.nicknameReader);
            reader.name = nameTextBox.Text;
            context.SaveChanges();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            var reader = context.Readers.Single(r => r.nickname == ReaderInfo.nicknameReader);

            if (PasswordManager.VerifyHashedPassword(reader.password, passwordTextBox.Text))
            {
                if (newPasswordTextBox.Text.Equals(confirmPasswordTextBox.Text))
                {
                    reader.password = PasswordManager.HashPassword(newPasswordTextBox.Text);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Passwords don't match", "Pay attention. sir");
                }
            }
            else
            {
                MessageBox.Show("Invalid current password", "Something went wrong :c");
            }

        }

        private void changeDepartmentButton_Click(object sender, EventArgs e)
        {
            if (addressComboBox.Text == "" || addressComboBox.SelectedItem == null)
            {
                MessageBox.Show("Choose a department", "Something went wrong :c");
            }
            else
            {
                var reader = context.Readers.Single(r => r.nickname == ReaderInfo.nicknameReader);
                reader.department = myDepartment;
                ReaderInfo.departmentReader = myDepartment.id;
                context.SaveChanges();
            }
        }
    }
}
