using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SalaryPayment;

namespace SalaryPaymentUI
{
    public class PaymentPresenter
    {
        private PaymentView view;
        private readonly ViewLoader viewLoader;
        private readonly TransactionContainer transactionContainer;

        public PaymentPresenter(ViewLoader viewLoader)
        {
            this.viewLoader = viewLoader;
            TransactionContainer.AddAction addAction= 
                new TransactionContainer.AddAction(TransactionAdded);
            transactionContainer = new TransactionContainer(addAction);
        }

        public PaymentView View
        {
            get { return view; }
            set { view = value; }
        }

        public TransactionContainer TransactionContainer
        {
            get { return transactionContainer; }
        }

        public void TransactionAdded()
        {
            UpdateTransactionTextBox();
        }

        void UpdateTransactionTextBox()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var transaction in 
                transactionContainer.Transactions)
            {
                builder.Append(transaction.ToString());
                builder.Append(Environment.NewLine);
            }
            view.TransactionsText = builder.ToString();
        }

        public virtual void AddEmployeeActionInvoked()
        {
            viewLoader.LoadAddEmployeeView(transactionContainer);
        }

        public void AddSelesReceiptActionInvoked()
        {
            viewLoader.LoadAddSalesReceiptView(transactionContainer);
        }

        public virtual void RunTransactions()
        {
            foreach (var transaction in transactionContainer.Transactions)
            {
                transaction.Execute();
            }

            transactionContainer.Clear();
            UpdateTransactionTextBox();
            UpdateEmployeeTextBox();
        }

        private void UpdateEmployeeTextBox()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var employee in PayrollDatabase.GetAllEmployeeIds())
            {
                builder.Append(employee);
                builder.Append(Environment.NewLine);
            }
            view.EmployeesText = builder.ToString();
        }

    }
}
