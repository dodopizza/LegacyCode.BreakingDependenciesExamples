using System.Collections.Generic;

namespace Dodo.LegacyCode.WrapClass
{
    public class SmsEmployee : Employee
    {
        private readonly Employee origin;

        public SmsEmployee(Employee origin)
        {
            this.origin = origin;
        }

        public void Pay(List<TimeEntry> timeEntries, PaymentService paymentService)
        {
            //
            
            origin.Pay(timeEntries, paymentService);
            
            //
        }
    }

    // 1st variant
    public class LoggingEmployee
    {
        private readonly Employee employee;

        public LoggingEmployee(Employee employee)
        {
            this.employee = employee;
        }

        public void Pay(List<TimeEntry> timeEntries, PaymentService paymentService)
        {
            LogPayment();
            
            employee.Pay(timeEntries, paymentService);

            LogPayment();
        }

        private void LogPayment()
        {
            //...
        }
    }

    public class Employee
    {
        private readonly int hourlyPayRateUsd;

        public Employee()
        {
            hourlyPayRateUsd = 35;
        }

        public void Pay(List<TimeEntry> timeEntries, PaymentService paymentService)
        {
            var totalAmount = new Money();
            foreach (var entry in timeEntries)
            {
                var amount = entry.Hours * hourlyPayRateUsd;
                totalAmount.Add(amount);
            }

            paymentService.Pay(this, totalAmount);
        }
    }
}