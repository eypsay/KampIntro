using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class NewStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
