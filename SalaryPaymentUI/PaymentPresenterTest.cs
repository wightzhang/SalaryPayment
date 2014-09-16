using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SalaryPayment;


namespace SalaryPaymentUI
{
    [TestFixture]
    public class PaymentPresenterTest
    {
        private MockPaymentView view;
        private PaymentPresenter presenter;
        private MockViewLoader viewLoader;

        [SetUp]
        public void SetUp()
        {
            view = new MockPaymentView();
            PayrollDatabase.Clear();
            viewLoader = new MockViewLoader();
            presenter = new PaymentPresenter(viewLoader)
            {
                View = view
            };
        }

        [Test]
        public void Creation()
        {
            Assert.AreSame(view, presenter.View);
            //Assert.AreSame(database, presenter.Database);
            Assert.IsNotNull(presenter.TransactionContainer);
        }

        [Test]
        public void AddAction()
        {
            TransactionContainer container =
                presenter.TransactionContainer;
            Transaction transaction = new MockTransaction();

            container.Add(transaction);

            string expected = transaction.ToString()
                + Environment.NewLine;
            Assert.AreEqual(expected, view.transactionsText);
        }

        [Test]
        public void AddEmployeeAction()
        {
            presenter.AddEmployeeActionInvoked();

            Assert.IsTrue(viewLoader.addEmployeeViewWasLoaded);
        }

        [Test]
        public void RunTransactions()
        {
            MockTransaction transaction = new MockTransaction();
            presenter.TransactionContainer.Add(transaction);
            Employee employee =
                new Employee(123, "John", "123 Baker St.");
            PayrollDatabase.AddEmployee_Static(employee);

            presenter.RunTransactions();

            Assert.IsTrue(transaction.wasExecuted);
            Assert.AreEqual("", view.transactionsText);
            string expectedEmployeeTest = employee.ToString()
                + Environment.NewLine;
            Assert.AreEqual(expectedEmployeeTest, view.employeesText);
        }

    }
}
