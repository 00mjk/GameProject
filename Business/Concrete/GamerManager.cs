using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class GamerManager : IGamerService
    {
        private IGamerDal _gamerDal;

        public GamerManager(IGamerDal gamerDal)
        {
            _gamerDal = gamerDal;
        }


        public void Add(Gamer gamer)
        {
            _gamerDal.Add(gamer);
        }

        public void Delete(int gamerId)
        {
            _gamerDal.Delete(gamerId);
        }

        public void Update(Gamer gamer)
        {
            _gamerDal.Update(gamer);
        }

        public List<Gamer> GetAll()
        {
            return _gamerDal.GetAll();
        }
    }
}
