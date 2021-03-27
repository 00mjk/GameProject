using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IGamerDal
    {
        void Add(Gamer gamer);
        void Delete(int gamerId);
        void Update(Gamer gamer);
        List<Gamer> GetAll();
    }
}
