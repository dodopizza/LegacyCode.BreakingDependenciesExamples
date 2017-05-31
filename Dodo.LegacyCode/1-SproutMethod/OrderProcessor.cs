using System.Collections.Generic;

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
            var result = new List<Order>();

            foreach (var order in orders)
            {
                order.Recalculate();
            }

            result.AddRange(orders);
            return result;
        }
    }

    public class Customer
    {
        public bool HasOrder(Order order)
        {
            // some logic here ...
            return false;
        }

        public void Refresh(Order order)
        {
            // some logic here...
        }
    }

    public class Order
    {
        public void Recalculate()
        {
            // some logic here ...
        }
    }
}