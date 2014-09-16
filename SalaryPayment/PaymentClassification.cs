using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public abstract class PaymentClassification
    {
        public abstract double CalculatePay(Paycheck paycheck);


        protected static bool IsInPayPeriod(DateTime theDate, Paycheck paycheck)
        {
            DateTime end = paycheck.PayDate;
            DateTime start = paycheck.StartDate;

            return (theDate >= start) && theDate <= end;
        }
    }
}
