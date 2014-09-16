using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public class WeeklySchedule:PaymentSchedule
    {
        public bool IsPayday(DateTime payDate)
        {
            return payDate.DayOfWeek == DayOfWeek.Friday;
        }

        public DateTime GetPayPeriodStartDate(DateTime date)
        {
            return date.AddDays(-6);
        }

        public override string ToString()
        {
            return "Weekly";
        }
    }
}
