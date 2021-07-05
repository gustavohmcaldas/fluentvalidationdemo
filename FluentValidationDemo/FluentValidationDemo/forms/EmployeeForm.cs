using FluentValidation.Results;
using FluentValidationDemo.entities;
using FluentValidationDemo.validators;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FluentValidationDemo.forms
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
            cboTitle.Items.Add("");
            cboProvince.Items.Add("");
            cboTitle.SelectedItem = "";
            cboProvince.SelectedItem = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.FirstName = tbFirstName.Text;
            employee.LastName = tbLastName.Text;
            employee.Email = tbEmail.Text;
            employee.PhoneNumber = tbPhoneNumber.Text;
            employee.HiredDate = dtpHiredDate.Value;

            Job job = new Job();
            job.Title = cboTitle.SelectedItem.ToString();
            job.Salary = double.Parse(nupSalary.Value.ToString());
            employee.Job = job;

            Location location = new Location();
            location.Province = cboProvince.SelectedItem.ToString();
            location.City = tbCity.Text;
            location.Street = tbAddress.Text;
            employee.Location = location;

            //validate data
            EmployeeValidator validator = new EmployeeValidator();
            ValidationResult results = validator.Validate(employee);
            IList<ValidationFailure> failures = results.Errors;
            if (!results.IsValid)
            {
                foreach (ValidationFailure failure in failures)
                {
                    MessageBox.Show(failure.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmail.Text = "";
            tbPhoneNumber.Text = "";
            dtpHiredDate.Value = DateTime.Now;
            cboTitle.SelectedItem = "";
            nupSalary.Value = 0.00M;
            cboProvince.SelectedItem = "";
            tbCity.Text = "";
            tbAddress.Text = "";
        }
    }
}
