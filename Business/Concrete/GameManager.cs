using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class GameManager : IGameService
    {
        private IGameDal _gameDal;

        public GameManager(IGameDal gameDal)
        {
            _gameDal = gameDal;
        }

        public void Add(Game game)
        {
            _gameDal.Add(game);
        }

        public void Update(Game game)
        {
            _gameDal.Update(game);
        }

        public void Delete(int gameId)
        {
            _gameDal.Delete(gameId);
        }

        public List<Game> GetAll()
        {
            return _gameDal.GetAll();
        }
    }
}
