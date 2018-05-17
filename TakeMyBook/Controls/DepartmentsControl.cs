using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TakeMyBook
{
    public partial class DepartmentsControl : UserControl
    {
        BooksContext context = new BooksContext();
        public List<Department> departments { get; set; } = null;

        public DepartmentsControl()
        {
            InitializeComponent();

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

        private void countryComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
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

        private void cityComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
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

        private void addressComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (departments == null)
                departments = context.Departments.ToList();

            var myDepartment = context.Departments.Single(d => d.country == countryComboBox.Text &&
                                                               d.city == cityComboBox.Text &&
                                                               d.address == addressComboBox.Text);
            openingHoursTextBox.Text = myDepartment.openingHours;
        }
    }
}
