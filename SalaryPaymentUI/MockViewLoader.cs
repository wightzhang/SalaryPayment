using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPaymentUI
{
    public class MockViewLoader:ViewLoader
    {
        public bool addEmployeeViewWasLoaded;
        private bool payrollViewWasLoaded;

        public void LoadPaymentView()
        {
            payrollViewWasLoaded = true;
        }

        public void LoadAddEmployeeView(
            TransactionContainer transactionContainer)
        {
            addEmployeeViewWasLoaded = true;
        }

        public void LoadAddSalesReceiptView()
        {
            throw new NotImplementedException();
        }

        #region ViewLoader 成员


        public void LoadAddSalesReceiptView(TransactionContainer transactionContainer)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
