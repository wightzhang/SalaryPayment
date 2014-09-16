using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public class HourlyClassification : PaymentClassification
    {
        private readonly double hourlyRate;
        private readonly Hashtable timeCards = new Hashtable();
        public HourlyClassification(double hourlyRate)
        {
            this.hourlyRate = hourlyRate;
        }

        public double HourlyRate
        {
            get { return hourlyRate; }
        }

        public void AddTimeCard(TimeCard tc)
        {
            timeCards[tc.Date] = tc.Hours;
        }

        public TimeCard GetTimeCard(DateTime date)
        {
            return timeCards[date] as TimeCard;
        }

        public override double CalculatePay(Paycheck paycheck)
        {
            var total = from TimeCard timeCard in timeCards.Values
                        where IsInPayPeriod(paycheck.StartDate, paycheck)
                        select CalculatePayForTimeCard(timeCard);

            return total.Sum();
        }

        private double CalculatePayForTimeCard(TimeCard card)
        {
            double overtime = Math.Max(0.0, card.Hours - 8);
            double normal = card.Hours - overtime;

            return hourlyRate*normal + hourlyRate*1.5*overtime;
        }

        public override string ToString()
        {
            return String.Format("${0}/hr", hourlyRate);
        }
    }
}
