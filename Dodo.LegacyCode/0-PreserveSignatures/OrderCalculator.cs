using System.Collections.Generic;

namespace Dodo.LegacyCode
{
    public class OrderCalculator
    {
        public void Process(List<Order> orders,
                            int dailyTarget,
                            double interestRate,
                            int compensationPercent)
        {
            // some complicated logic goes here ...

            ProcessOrders(orders,
                          dailyTarget,
                          interestRate,
                          compensationPercent);
        }

        public void ProcessOrders(List<Order> orders,
                                  int dailyTarget,
                                  double interestRate,
                                  int compensationPercent)
        {
        }
    }
}