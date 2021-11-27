using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SaleManager : ISaleManager
    {
        public void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine(" Oyunu " + gamer.FirstName.ToUpper() + " " + gamer.LastName.ToUpper()
                + " Adlı Oyuncuya " + game.Price + " TL'ye satılmıştır.");
        }

        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(" Oyunu " + gamer.FirstName.ToUpper() + 
                " " + gamer.LastName.ToUpper() + " Adlı Oyuncuya " +
                (game.Price - (game.Price * campaign.Discount) / 100) + " TL'ye satılmıştır.");
        }
    }
}

        
    

