using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryPayment
{
    public class PayrollDatabase
    {
        private static readonly Hashtable employees = new Hashtable();

        private static readonly PayrollDatabase instance = 
            new PayrollDatabase();

        public void AddEmployee(Employee employee)
        {
            employees[employee.EmpId] = employee;
        }

        public static void AddEmployee_Static(Employee employee)
        {
            instance.AddEmployee(employee);
            
        }

        public static Employee GetEmployee(int id)
        {
            return employees[id] as Employee;
        }

        public static ArrayList GetAllEmployeeIds()
        {
            return new ArrayList(employees.Values);
        }

        public static void Clear()
        {
            employees.Clear();
        }

        public static Employee GetUnionMember(int memberId)
        {
            return null;
        }
    }
}
