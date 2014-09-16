using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public class CommissionClassification:PaymentClassification
    {
        private readonly double baseRate;
        private readonly double commissionRate;
        private readonly Hashtable salesReceipts = new Hashtable();
        public CommissionClassification(double baseRate, double commissionRate)
        {
            this.baseRate = baseRate;
            this.commissionRate = commissionRate;
        }

        public double BaseRate
        {
            get { return baseRate; }
        }

        public double CommissionRate
        {
            get { return commissionRate; }
        }

        public void AddSalesReceipt(SalesReceipt receipt)
        {
            salesReceipts[receipt.Date] = receipt;
        }

        public SalesReceipt GetSalesReceipt(DateTime date)
        {
            return salesReceipts[date] as SalesReceipt;
        }

        public override double CalculatePay(Paycheck paycheck)
        {
            double salesTotal = 0.0;
            foreach (SalesReceipt receipt in salesReceipts.Values)
            {
                if (IsInPayPeriod(paycheck.StartDate,paycheck))
                    salesTotal += receipt.Amount;
            }
            return baseRate + (salesTotal * commissionRate * 0.01);
        }

        public override string ToString()
        {
            return String.Format("${0} + {1}% sales commission", baseRate, commissionRate);
        }
    }
}
