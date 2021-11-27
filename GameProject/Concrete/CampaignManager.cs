using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine( "  Kampanya Başarıyla Eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("  Kampanya Başarıyla Silindi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("  Kampanya Başarıyla Güncellendi.");
        }
    }
}
