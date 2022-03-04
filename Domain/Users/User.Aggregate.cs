using Domain.Base;
using Domain.Departments;
using Domain.Entities.Users.Events;
using System;
using System.Linq;

namespace Domain.Users
{
    public partial class User: IAggregateRoot
    {
        public User(string fullName
            , string address
            , string birthdate
            , string registrationdate
            , int active)
        {
            //UserName = userName;

            this.Update(
                fullName
                , address
                , birthdate
                , registrationdate
                , active
            );
        }

        public void Update(string fullName
            , string address
            , string birthdate
            , string registrationdate
            , int active)
        {
            this.fullname = fullName;
            this.address = address;
            this.birthdate = birthdate;
            this.registrationdate = registrationdate;
            this.active = active;
        }

        //public void AddDepartment(int ActiveCustomer)
        //{
        //    ActiveCustomer = ActiveCustomer;
        //}

        public Payslip AddPayslip(DateTime date
            , float workingDays
            , decimal bonus
            , bool isPaid
            )
        {
            // Make sure there's only one payslip  per month
            var exist = PaySlips.Any(_ => _.Date.Month == date.Month && _.Date.Year == date.Year);
            if (exist)
                throw new Exception("Payslip for this month already exist.");

            var payslip = new Payslip(this.Id, date, workingDays, bonus);
            //if (isPaid)
            //{
            //    payslip.Pay(this.CoefficientsSalary);
            //}

            PaySlips.Add(payslip);

            var addEvent = new OnPayslipAddedDomainEvent()
            {
                Payslip = payslip
            };

            AddEvent(addEvent);

            return payslip;
        }
    }
}