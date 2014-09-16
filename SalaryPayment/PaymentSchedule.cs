using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public interface PaymentSchedule
    {
        bool IsPayday(DateTime payDate);
        DateTime GetPayPeriodStartDate(DateTime date);
    }
}
