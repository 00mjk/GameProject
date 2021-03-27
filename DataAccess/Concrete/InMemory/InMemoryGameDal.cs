using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryGameDal : IGameDal
    {
        private List<Game> _games;

        public InMemoryGameDal()
        {
            _games = new List<Game>
            {
                new Game{Id = 123,Name = "Pubg",Price = 90},
                new Game{Id = 123,Name = "CSGO",Price = 30}
            };
        }

        public void Add(Game game)
        {
            _games.Add(game);
        }

        public void Update(Game game)
        {
            var gameToUpdate = _games.SingleOrDefault(g => g.Id == game.Id);
            if (gameToUpdate != null)
            {
                gameToUpdate.Name = game.Name;
                gameToUpdate.Price = game.Price;
            }
        }

        public void Delete(int gameId)
        {
            var gameToDelete = _games.SingleOrDefault(g => g.Id == gameId);
            _games.Remove(gameToDelete);
        }

        public List<Game> GetAll()
        {
            return _games;
        }
    }
}
