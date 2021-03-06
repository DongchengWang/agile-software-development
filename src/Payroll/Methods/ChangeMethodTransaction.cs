﻿using AgileSoftwareDevelopment.Payroll.Domain;

namespace AgileSoftwareDevelopment.Payroll.Methods {
    public abstract class ChangeMethodTransaction : ChangeEmployeeTransaction {
        public ChangeMethodTransaction(int id) : base(id) {
        }

        protected override void Change(Employee e) {
            e.Method = Method;
        }

        protected abstract PayrollMethod Method { get; }
    }
}
