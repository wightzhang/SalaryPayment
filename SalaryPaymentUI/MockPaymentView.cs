using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPaymentUI
{
    public class MockPaymentView:PaymentView
    {
        public string transactionsText;
        public string employeesText;
        public PaymentPresenter presenter;

        public string TransactionsText
        {
            set { transactionsText = value; }
        }

        public string EmployeesText
        {
            set { employeesText = value; }
        }

        public PaymentPresenter Presenter
        {
            set { presenter = value; }
        }

    }
}
