using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalaryPaymentUI
{
    public partial class AddEmployeeWindow : Form,AddEmployeeView
    {
        private AddEmployeePresenter presenter;

        public AddEmployeeWindow()
        {
            InitializeComponent();
        }

        public AddEmployeePresenter Presenter
        {
            get { return presenter; }
            set { presenter = value; }
        }

        private void hourlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            hourlyRateTextBox.Enabled = hourlyRadioButton.Checked;
            presenter.IsHourly = hourlyRadioButton.Checked;
        }

        private void salaryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            salaryTextBox.Enabled = salaryRadioButton.Checked;
            presenter.IsSalary = salaryRadioButton.Checked;
        }

        private void commissionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            commissionRateTextBox.Enabled = commissionRadioButton.Checked;

            commissiomTextBox.Enabled = commissionRadioButton.Checked;
            presenter.IsCommission = commissionRadioButton.Checked;
        }


        private void empIdTextBox_TextChanged(object sender, EventArgs e)
        {
            presenter.EmpId = AsInt(empIdTextBox.Text);
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            presenter.Name = nameTextBox.Text;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            presenter.Address = addressTextBox.Text;
        }

        private void hourlyRateTextBox_TextChanged(object sender, EventArgs e)
        {
            presenter.HourlyRate = AsDouble(hourlyRateTextBox.Text);
        }

        private void salaryTextBox_TextChanged(object sender, EventArgs e)
        {
            presenter.Salary = AsDouble(salaryTextBox.Text);
        }

        private void commissionRateTextBox_TextChanged(object sender, EventArgs e)
        {
            presenter.CommissionSalary = AsDouble(commissionRateTextBox.Text);
        }

        private void commissiomTextBox_TextChanged(object sender, EventArgs e)
        {
            presenter.Commission = AsDouble(commissiomTextBox.Text);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            presenter.AddEmployee();
            this.Close();
        }

        private double AsDouble(string text)
        {
            try
            {
                return Double.Parse(text);
            }
            catch (Exception)
            {
                return 0.0;
            }
        }

        private int AsInt(string text)
        {
            try
            {
                return Int32.Parse(text);
            }
            catch (Exception)
            {
                return 0;
            }
        }


        public bool SubmitEnable
        {
            set { submitButton.Enabled = value; }
        }

    }
}
