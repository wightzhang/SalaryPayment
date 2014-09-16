using System;
using System.Windows.Forms;

namespace SalaryPaymentUI
{
    public partial class PaymentWindow : Form,PaymentView
    {
        private PaymentPresenter present;
        public PaymentWindow()
        {
            InitializeComponent();
        }

        public PaymentPresenter Presnet
        {
            get { return present; }
            set { present = value; }
        }

        private void addEmployeeButton_Click(
            object sender, EventArgs e)
        {
            present.AddEmployeeActionInvoked();
        }


        public string TransactionsText
        {
            set { transcationsTextBox.Text = value; }
        }

        public string EmployeesText
        {
            set
            {
                employeeTextBox.Text = value;
                employeesListBox.Items.Clear();
                employeesListBox.Items.Add(value);
            }
        }

        public PaymentPresenter Presenter
        {
            get { return present; }
            set { present=value; }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            present.RunTransactions();
        }

        private void addSalesReceiptbutton_Click(object sender, EventArgs e)
        {
            present.AddSelesReceiptActionInvoked();
        }


    }
}
