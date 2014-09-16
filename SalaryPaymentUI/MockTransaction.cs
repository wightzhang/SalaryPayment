using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SalaryPayment;

namespace SalaryPaymentUI
{
    public class MockTransaction:Transaction
    {
        public bool wasExecuted;

        public MockTransaction()
        { }

        public void Execute()
        {
            wasExecuted = true;
        }
    }
}
