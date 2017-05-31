using System.Collections.Generic;

namespace Dodo.LegacyCode
{
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