using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SalaryPayment;
namespace SalaryPaymentUI
{
    public class AddSalesReceiptPresenter
    {
        private readonly TransactionContainer transactionContainer;
        private AddSalesReceiptView view;
        private DateTime date;
        private double amount;
        private int empId;

        public AddSalesReceiptPresenter(AddSalesReceiptView view,
            TransactionContainer transactionContainer)
        {
            this.view = view;
            this.transactionContainer = transactionContainer;
        }

        public int EmpId
        {
            set
            {
                empId = value;
                UpdateView();
            }
        }

        public double Amount
        {
            set
            {
                amount = value;
                UpdateView();
            }
        }

        public DateTime SalesReceiptDate
        {
            set
            {
                date = value;
                UpdateView();
            }
        }

        public void AddSalesReceipt()
        {
            transactionContainer.Add(new SalesReceiptTransaction(
                date, amount, empId));
        }

        private void UpdateView()
        {
            view.SubmitEnable = AllInformtionIsCollected();
        }

        private bool AllInformtionIsCollected()
        {
            bool result = true;
            result &= empId > 0;
            result &= amount > 0;
            result &= date.Year != 1;
            return result;
        }


    }
}
