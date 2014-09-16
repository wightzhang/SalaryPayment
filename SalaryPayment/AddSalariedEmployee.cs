﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public class AddSalariedEmployee:AddEmployeeTransaction
    {
        private readonly double salary;

        public AddSalariedEmployee(int id, string name, 
            string address, double salary)
            :base(id,name,address)
        {
            this.salary = salary;
        }

        protected override PaymentClassification MakeClassfication()
        {
            return new SalariedClassification(salary);
        }

        protected override PaymentSchedule MakeSchedule()
        {
            return new MonthlySchedule();
        }

        
    }
}
