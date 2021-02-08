using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new UserValidationManager());
            userManager.SignUp(new User
            { 
                BirthYear = 1997, 
                FirstName = "Halef", 
                LastName = "Uludağ", 
                NationaltyId = 0001 
            });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign {Id=1,CampaignName="Kış İndirimi",CampaignDuration="2 Hafta" });

            OrderManager orderManager = new OrderManager();
            orderManager.Sale(new User{FirstName="Halef",LastName="Uludağ"}, new Product { ProductName = "GTA V" },
            new Campaign { CampaignName="Cyber Pazartesi"});

        }
    }
}
