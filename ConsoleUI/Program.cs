using System;
using Business.Concrete;
using DataAccess.Adapters;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new InMemoryGamerDal());

            gamerManager.Delete(125);

            gamerManager.Update(new Gamer
            {
                Id = 124,
                FirstName = "Yağmur",
                LastName = "-",
                BirthYear = 1997,
                IdentityNumber = 123123222
            });

            gamerManager.Add(new Gamer
            {
                Id = 126,
                FirstName = "Şevval",
                LastName = "-",
                BirthYear = 1999,
                IdentityNumber = 122112344
            });

            foreach (var gamer in gamerManager.GetAll())
            {
                Console.WriteLine(gamer.FirstName);
            }
        }
    }
}
