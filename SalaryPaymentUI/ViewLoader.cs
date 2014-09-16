using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPaymentUI
{
    public interface ViewLoader
    {
        void LoadPaymentView();
        void LoadAddEmployeeView(TransactionContainer transactionContainer);
        void LoadAddSalesReceiptView(TransactionContainer transactionContainer);
    }
}
