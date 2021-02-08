using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class OrderManager : IOrderService
    {
        public void Sale(User user, Product product, Campaign campaign )
        {
            Console.WriteLine(user.FirstName+" "+user.LastName+" "+ campaign.CampaignName+
                " "+"kampanyasından"+" " + product.ProductName+" "+"oyununu satın aldı.");
        }

        public void List(Campaign campaign, Product product)
        {
            Console.WriteLine(product.ProductName+" "+campaign.CampaignName+" kampanyasında listelendi.");
        }

        internal void Sale()
        {
            throw new NotImplementedException();
        }
    }
}
