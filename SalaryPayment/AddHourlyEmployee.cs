using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public class AddHourlyEmployee:AddEmployeeTransaction
    {
        private readonly double hourlyRate;

        public AddHourlyEmployee(int id, string name, 
            string address, double hourlyRate)
            :base(id,name,address)
        {
            this.hourlyRate = hourlyRate;
        }

        protected override PaymentClassification MakeClassfication()
        {
            return new HourlyClassification(hourlyRate);
        }

        protected override PaymentSchedule MakeSchedule()
        {
            return new WeeklySchedule();
        }

    }
}
