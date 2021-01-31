using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    //MICROSERVICE
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void add(Gamer gamer)
        {
            //throw new NotImplementedException();
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt Oldu");
            }
            else
            {
                Console.WriteLine("DOGRULAAM BASARISIZ!!!");
            }
            
        }

        public void delete(Gamer gamer)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Kayıt Silind");
        }

        public void update(Gamer gamer)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
