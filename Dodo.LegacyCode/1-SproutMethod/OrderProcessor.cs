using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace Dodo.LegacyCode
{
    public class OrderProcessor
    {
        private readonly List<Order> orders;

        public OrderProcessor(List<Order> orders)
        {
            this.orders = orders;
        }

        public List<Order> GetAvailableOrdersFor(Customer customer)
        {
            var result = GetFilteredOrders(customer, orders);

            foreach (var order in result)
            {
                // ...

                order.Recalculate();
                result.Add(order);
            }

            return result;
        }

        public List<Order> GetFilteredOrders(Customer customer, List<Order> orders)
        {
            var result = new List<Order>();

            foreach (var order in orders)
            {
                if (customer.HasOrder(order) && order.Price > 1)
                {
                    result.Add(order);
                }
            }
            return result;
        }
    }
}