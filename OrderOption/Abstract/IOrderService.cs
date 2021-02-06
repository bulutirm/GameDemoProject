using System;
using GameDemoProject.OrderOption.Entity;

namespace GameDemoProject.OrderOption.Abstract
{
    public interface IOrderService
    {
        void Add(Order order);
        void Verify(Order order);

    }
}
