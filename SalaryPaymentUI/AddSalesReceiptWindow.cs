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
    public partial class AddSalesReceiptWindow : 
        Form,AddSalesReceiptView
    {
        private AddSalesReceiptPresenter presneter;
        public AddSalesReceiptWindow()
        {
            InitializeComponent();
        }

        public AddSalesReceiptPresenter Presenter
        {
            get { return presneter; }
            set { presneter = value; }
        }

        public bool SubmitEnable
        {
            set { submitButton.Enabled = value; }
        }

        private void empIdTextBox_TextChanged(
            object sender, EventArgs e)
        {
            presneter.EmpId = AsInt(empIdTextBox.Text);
        }

        private void amountTextBox_TextChanged(
            object sender, EventArgs e)
        {
            presneter.Amount = AsDouble(amountTextBox.Text);
        }

        private void SalesReceiptDateTimePicker_ValueChanged(
            object sender, EventArgs e)
        {
            presneter.SalesReceiptDate =
                SalesReceiptDateTimePicker.Value;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            presneter.AddSalesReceipt();
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
    }
}
