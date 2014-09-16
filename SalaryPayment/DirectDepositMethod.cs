﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public class DirectDepositMethod:PaymentMethod
    {
        private readonly string bank;
        private readonly string accountNumber;

        public DirectDepositMethod(string bank, string accountNumber)
        {
            this.bank = bank;
            this.accountNumber = accountNumber;
        }

        public string Bank
        {
            get { return bank; }
        }

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public override string ToString()
        {
            return String.Format("direct deposit into {0}:{1}", 
                bank, accountNumber); 
        }

        public void Pay(Paycheck paycheck)
        {
            paycheck.SetField("Disposition", "Direct");
        }


    }
}
