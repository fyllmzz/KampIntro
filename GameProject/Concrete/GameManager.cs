using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine( "  Oyun Başarıyla Eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("  Oyun Başarıyla Silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine( "  Oyun Başarıyla Güncellendi.");
        }
    }
}
