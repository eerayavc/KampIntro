using System;

namespace MyGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1985,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                IdentityNumber = 12345
            });

            CampainManager campainManager = new CampainManager();
            campainManager.CampainAdd(new Campain { Id = 1, CampainName = " Yılbaşı" });
            Console.Read();

            
        }
    }
}
