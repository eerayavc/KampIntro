using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameProject
{
    class OrderManager : IOrderService
    {
        ICampainService _campainService;

        public OrderManager(ICampainService campainService)
        {
            _campainService = campainService;
        }
        public void Order(Gamer gamer)
        {
            Console.WriteLine("Siparişiniz alınmıştır:" + gamer.FirstName);
        }
    }
}
