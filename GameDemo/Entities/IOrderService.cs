using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IOrderService
    {
        void Sale(User user, Product product,Campaign campaign);
        void List(Campaign campaign, Product product);

    }
}
