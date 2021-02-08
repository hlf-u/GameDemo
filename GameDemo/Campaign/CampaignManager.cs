using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+ " kampanyası başlatıldı" + " Süre: "+campaign.CampaignDuration );
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "kampanyası silindi.");
        }

        public void Uptade(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + "kampanyası güncellendi");
        }
    }
}
