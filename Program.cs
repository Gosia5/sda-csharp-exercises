using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderItem item1 = new OrderItem("Bread", 5, 3.50M);
            OrderItemWithPackage item2 = new OrderItemWithPackage("Milk", 5, 2.20M, "Bottle", 1M);
            Order order = new Order();
            order.AddOrderItem(item1);
            order.AddOrderItem(item2);
            order.DisplayOrderItem();
        }
    }
}

