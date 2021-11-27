using Game_Backend;
using GameProject.Abstract;
//using GameProject.Adapters;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : IGamerManager
    {
        private IGamerCheck gamerCheck;

        public GamerManager()
        {
            gamerCheck = new MernisAdapterService();
        }
        public void Add(Gamer gamer)
        {
            if (gamerCheck.Check(gamer))
            {
                Console.WriteLine(gamer.FirstName.ToUpper() + " " + gamer.LastName.ToUpper() + " Adlı Oyuncu Başarıyla Eklendi.");
            }
            else
            {
                throw new Exception("Oyuncu Doğrulanamadı");
            }
        }
    }
}
