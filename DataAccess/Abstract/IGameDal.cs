using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IGameDal
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(int gameId);
        List<Game> GetAll();
    }
}
