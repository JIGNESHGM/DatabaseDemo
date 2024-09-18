using EmployeeBonusCalculateWebApplication.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeBonusCalculateWebApplication
{
    public partial class EmployeeBonus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            // Check if name is properly entered
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                lblNameError.Text = "Please enter a valid name";
                return;
            }
            else
            {
                lblNameError.Text = "";
            }

            // Check if salary is greater than 0
            if (string.IsNullOrWhiteSpace(txtSalary.Text) || !int.TryParse(txtSalary.Text, out int salary) || salary <= 0)
            {
                lblSalaryError.Text = "Please enter a valid salary greater than 0";
                return;
            }
            else
            {
                lblSalaryError.Text = "";
            }

            // Create an instance of the Employee class
            Employee employee = new Employee();

            // Set the Name and Salary properties from the text boxes
            employee.Name = txtName.Text;
            employee.Salary = int.Parse(txtSalary.Text);

            // Calculate the bonus
            employee.CalculateBonus();

            // Calculate the net salary
            employee.NetSalaryCalculate();

            // Get the data from the employee object
            var data = employee.GetData();

            // Set the text boxes with the calculated values
            txtBonus.Text = data.Item3.ToString();
            txtNetSalary.Text = data.Item4.ToString();
        }
    }
}