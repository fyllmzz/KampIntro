using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ISaleManager
    {
        void Sale(Game game, Gamer gamer);
        void Sale(Game game, Gamer gamer, Campaign campaign);
    }
}
