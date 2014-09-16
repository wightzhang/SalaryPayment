﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public class PaydayTransaction:Transaction
    {
        private readonly DateTime payDate;
        private readonly Hashtable paychecks = new Hashtable();
        public PaydayTransaction(DateTime payDate)
        {
            this.payDate = payDate;
        }

        public void Execute()
        {
            ArrayList empIds = PayrollDatabase.GetAllEmployeeIds();
            foreach (int empId in empIds)
            {
                Employee employee = PayrollDatabase.GetEmployee(empId);
                if (employee.IsPayDate(payDate))
                {
                    DateTime startDate = employee.GetPayPeriodStartDate(payDate);
                    Paycheck pc = new Paycheck(startDate,payDate);
                    paychecks[empId] = pc;
                    employee.PayDay(pc);
                }
            }
        }

        public Paycheck GetPaycheck(int empId)
        {
            return paychecks[empId] as Paycheck;
        }
    }
}
