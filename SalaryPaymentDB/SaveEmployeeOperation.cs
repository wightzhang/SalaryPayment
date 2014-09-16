using System;
using SalaryPayment;
using System.Data.SQLite;

namespace SalaryPaymentDB
{
    public class SaveEmployeeOperation
    {
        private readonly Employee employee;

        private string insertEmployeeSql;
        private object[] employeeParameters;

        private string methodCode;
        private string insertPaymentMethodSql;
        private object[] methodParameters;

        private string classificationCode;
        private string insertClassificationSql;
        object[] classificationParameters;

        public SaveEmployeeOperation(Employee employee)
        {
            this.employee = employee;
        }

        public void Execute()
        {
            SetPaymentMethod();
            SetPaymentClassification();
            SetSaveEmployeeCommond();

            SQLiteTransaction transaction = SqliteHelper.Conn.BeginTransaction();

            try
            {
                SqliteHelper.ExecuteNonQuery(
                    transaction, insertEmployeeSql, employeeParameters);
                SqliteHelper.ExecuteNonQuery(
                    transaction, insertPaymentMethodSql, methodParameters);
                SqliteHelper.ExecuteNonQuery(
                    transaction, insertClassificationSql, classificationParameters);
                transaction.Commit();
            }
            catch (Exception e)
            {
                transaction.Rollback();
                throw e;
            }
        }

        void SetSaveEmployeeCommond()
        {
            insertEmployeeSql = "insert into Employee values (" +
                "@EmpId, @Name, @Address, @ScheduleType, " +
                "@PaymentMethodType, @PaymentClassificationType)";

            employeeParameters = new object[]
            {
                employee.EmpId, 
                employee.Name, 
                employee.Address,
                ScheduleCode(),
                methodCode,
                classificationCode
            };
        }

        private void SetPaymentMethod()
        {
            PaymentMethod method = employee.Method;

            if (method is HoldMethod)
                methodCode = "Hold";
            else if (method is MailMethod)
                methodCode = "Mail";
            else if (method is DirectDepositMethod)
            {
                methodCode = "direct deposit";
                DirectDepositMethod ddMethod = method as DirectDepositMethod;
                insertPaymentMethodSql = 
                    "insert into DirectDepositAccount values " +
                    "(@Bank, @Account, @EmpId)";
                methodParameters =new object[]  
                {
                    ddMethod.Bank,
                    ddMethod.AccountNumber,
                    employee.EmpId
                };
            }
            else
                methodCode="unknown";
        }

        private void SetPaymentClassification()
        {
            PaymentClassification classification = employee.Classfication;
            if (classification is HourlyClassification)
            {
                classificationCode = "hourly";
                HourlyClassification hourlyClassification = 
                    classification as HourlyClassification;
                insertClassificationSql = 
                    "insert into HourlyClassification values " +
                    "(@HourlyRate, @EmpId)";
                classificationParameters = new object[]
                {
                    hourlyClassification.HourlyRate,
                    employee.EmpId
                };
            }
            else if (classification is SalariedClassification)
            {
                classificationCode = "salary";
                SalariedClassification salariedClassification = 
                    classification as SalariedClassification;
                insertClassificationSql = 
                    "insert into SalariedClassification values (@Salary, @EmpId)";
                classificationParameters = new object[]
                {
                    salariedClassification.Salary,
                    employee.EmpId
                };
            }
            else if (classification is CommissionClassification)
            {
                classificationCode = "commission";
                CommissionClassification commissionClassification = 
                    classification as CommissionClassification;
                insertClassificationSql = 
                    "insert into CommissionedClassification values " +
                    "(@Salary, @Commission, @EmpId)";
                classificationParameters = new object[]
                {
                    commissionClassification.BaseRate,
                    commissionClassification.CommissionRate,
                    employee.EmpId
                };

            }
            else
                classificationCode = "unknown";
        }

        private string ScheduleCode()
        {
            PaymentSchedule schedule = employee.Schedule;
            if (schedule is MonthlySchedule)
                return "monthly";
            if (schedule is WeeklySchedule)
                return "weekly";
            if (schedule is BiweeklySchedule)
                return "biweekly";
            return "unknown";
        }

    }
}
