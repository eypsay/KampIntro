using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    interface IGamerService
    {
        void add(Gamer gamer);
        void update(Gamer gamer);
        void delete(Gamer gamer);
    }
}
