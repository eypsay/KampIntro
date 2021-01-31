using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class UserValidationManager : IUserValidationService

    {
        public bool Validate(Gamer gamer)
        {
            //
            if((gamer.BirthYear==1985) && (gamer.FirstName == "eyyüp") && (gamer.LastName == "say") && (gamer.IdentityNumber == 123))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
