﻿using System;
using AgileSoftwareDevelopment.Payroll.Domain;

namespace AgileSoftwareDevelopment.Payroll.Schedules {
    public class MonthlySchedule : PayrollSchedule {
        public bool IsPayDate(DateTime payDate) {
            return DateUtil.IsLastDayOfMonth(payDate);
        }

        public DateTime GetPayPeriodStartDate(DateTime date) {
            return date.AddDays(-date.Day + 1);
        }
    }
}
