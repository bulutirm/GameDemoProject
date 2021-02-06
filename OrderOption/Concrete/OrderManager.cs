using System;
using GameDemoProject.OrderOption.Abstract;
using GameDemoProject.OrderOption.Entity;

namespace GameDemoProject.OrderOption.Concrete
{
    public class OrderManager : IOrderService
    {
        public void Add(Order order)
        {
            Console.WriteLine("Order owner: " +order.FirstName +order.LastName);
            Console.WriteLine("The order was added.");
        }

        public void Verify(Order order)
        {
            Console.WriteLine("Order owner: " + order.FirstName + order.LastName);
            Console.WriteLine("The order was verified");
        }
    }
}
