using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICampaignDal
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(int campaignId);
        List<Campaign> GetAll();
    }
}
