using System;

namespace Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewStateUserValidationManager());
            gamerManager.add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "Eyyüp", LastName = "say", IdentityNumber = 12345 });
        }
    }


}
