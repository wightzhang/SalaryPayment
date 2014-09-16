using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SalaryPayment;

namespace SalaryPaymentUI
{
    public class TransactionContainer
    {
        public delegate void AddAction();
        private readonly IList<Transaction> transactions = new List<Transaction>();
        private readonly AddAction addAction;
        public IEnumerable<Transaction> Transactions
        {
            get { return transactions; }
        }

        public TransactionContainer(AddAction action)
        {
            addAction = action;
        }

        public void Add(Transaction transaction)
        {
            transactions.Add(transaction);
            if (addAction != null)
                addAction();
        }

        public void Clear()
        {
            transactions.Clear();
        }
    }
}
