using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCampaignDal : ICampaignDal
    {
        private List<Campaign> _campaigns;

        public InMemoryCampaignDal()
        {
            _campaigns = new List<Campaign>
            {
                new Campaign{Id = 123,Name = "Elli",DiscountAmount = 50},
                new Campaign{Id = 124,Name = "Otuz",DiscountAmount = 30}
            };
        }
        public void Add(Campaign campaign)
        {
            _campaigns.Add(campaign);
        }

        public void Update(Campaign campaign)
        {
            var campaignToUpdate = _campaigns.SingleOrDefault(c => c.Id == campaign.Id);

            if (campaignToUpdate != null)
            {
                campaignToUpdate.Name = campaign.Name;
                campaignToUpdate.DiscountAmount = campaign.DiscountAmount;
            }
        }

        public void Delete(int campaignId)
        {
            var campaignToDelete = _campaigns.SingleOrDefault(c => c.Id == campaignId);
            _campaigns.Remove(campaignToDelete);
        }

        public List<Campaign> GetAll()
        {
            return _campaigns;
        }
    }
}
