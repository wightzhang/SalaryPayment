﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public class SalesReceipt
    {
        private readonly DateTime date;
        private readonly double amount;

        public SalesReceipt(DateTime date, double amount)
        {
            this.date = date;
            this.amount = amount;
        }

        public DateTime Date
        {
            get { return date; }
        }

        public double Amount
        {
            get { return amount; }
        }

    }
}
