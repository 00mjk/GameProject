using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryGamerDal : IGamerDal
    {
        private List<Gamer> _gamers;

        public InMemoryGamerDal()
        {
            _gamers = new List<Gamer>
            {
                new Gamer{Id = 123,FirstName = "Zafer",LastName = "Çalışkan",
                    BirthYear = 1995,IdentityNumber = 1213123111},
                new Gamer{Id = 124,FirstName = "Hasan",LastName = "Çalışkan",
                    BirthYear = 1997,IdentityNumber = 1231231231},
                new Gamer{Id = 125,FirstName = "Süleyman",LastName = "Çalışkan",
                    BirthYear = 1974,IdentityNumber = 1232221222}
            };
        }

        public void Add(Gamer gamer)
        {
            _gamers.Add(gamer);
        }

        public void Delete(int gamerId)
        {
            var gamerToDelete = _gamers.SingleOrDefault(g => g.Id == gamerId);
            _gamers.Remove(gamerToDelete);
        }

        public void Update(Gamer gamer)
        {
            var gamerToUpdate = _gamers.SingleOrDefault(g => g.Id == gamer.Id);
            
            if (gamerToUpdate != null)
            {
                gamerToUpdate.BirthYear = gamer.BirthYear;
                gamerToUpdate.FirstName = gamer.FirstName;
                gamerToUpdate.LastName = gamer.LastName;
                gamerToUpdate.IdentityNumber = gamer.IdentityNumber;
            }
        }

        public List<Gamer> GetAll()
        {
            return _gamers;
        }
    }
}