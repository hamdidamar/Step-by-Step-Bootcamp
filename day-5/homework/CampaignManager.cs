using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class CampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name+" added");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Id + " updated");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " deleted");
        }
    }
}
