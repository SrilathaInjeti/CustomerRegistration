using Domain.Base;
using Domain.Departments;
using System;
using System.Collections.Generic;

namespace Domain.Users
{
    public partial class User : BaseEntity<int>
    {
        public User()
        {
            PaySlips = new HashSet<Payslip>();
        }
        public string id { get; set; }
        public string fullname { get; set; }
        public string address { get; set; }
        public string birthdate { get; set; }
        public string registrationdate { get; set; }
        public int active { get; set; }
        public virtual ICollection<Payslip> PaySlips { get; private set; }
    }
}