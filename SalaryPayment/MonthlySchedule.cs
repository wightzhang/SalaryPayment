using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public class MonthlySchedule:PaymentSchedule
    {
        private static bool IsLastDayOfMonth(DateTime date)
        {
            int m1 = date.Month;
            int m2 = date.AddDays(1).Month;
            return (m1 != m2);
        }

        public bool IsPayday(DateTime payDate)
        {
            return IsLastDayOfMonth(payDate);
        }

        public DateTime GetPayPeriodStartDate(DateTime date)
        {
            int days = 0;
            while (date.AddDays(days - 1).Month == date.Month)
                days--;

            return date.AddDays(days);
        }

        public override string ToString()
        {
            return "Monthly";
        }
    }
}
