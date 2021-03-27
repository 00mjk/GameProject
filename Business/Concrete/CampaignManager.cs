using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CampaignManager : ICampaignService
    {
        private ICampaignDal _campaignDal;

        public CampaignManager(ICampaignDal campaignDal)
        {
            _campaignDal = campaignDal;
        }
        public void Add(Campaign campaign)
        {
            _campaignDal.Add(campaign);
        }

        public void Update(Campaign campaign)
        {
            _campaignDal.Update(campaign);
        }

        public void Delete(int campaignId)
        {
            _campaignDal.Delete(campaignId);
        }

        public List<Campaign> GetAll()
        {
            return _campaignDal.GetAll();
        }
    }
}
