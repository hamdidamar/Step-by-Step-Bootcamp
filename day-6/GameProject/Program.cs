using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, FirstName = "gamer1" ,LastName="blalba",BirthYear=1900,IdentityNumber="123"});
            gamerManager.Add(new Gamer { Id = 1, FirstName = "gamer2" ,LastName="blalba",BirthYear=1900,IdentityNumber="123"});
        }
    }
}
