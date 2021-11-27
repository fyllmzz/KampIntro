using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.NationalityId = "11656188196";
            gamer1.FirstName = "Dinçer";
            gamer1.LastName = "Dinç";
            gamer1.DateOfBirth = new DateTime(2000, 8, 25);

            IGamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer1);

            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "Euro Truck Simulator 2";
            game1.Price = 40;
            game1.Category = "Simülasyon";

            IGameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Game game2 = new Game();
            game2.GameId = 1;
            game2.GameName = "Counter Strike Global Offensive";
            game2.Price = 20;
            game2.Category = "FPS";

            gameManager.Add(game2);

            Campaign campaign1 = new Campaign();
            campaign1.Id = 1;
            campaign1.Name = "Yılbaşı Kampanyası";
            campaign1.Discount = 60;

            ICampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(game1, gamer1, campaign1);
            saleManager.Sale(game2, gamer1);

            campaignManager.Delete(campaign1);
            gameManager.Delete(game1);
            Console.ReadLine();
        }
    }
}
