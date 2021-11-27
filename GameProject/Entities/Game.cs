using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string   Category { get; set; }
        public int GameId { get; internal set; }
        public string GameName { get; internal set; }
    }
}
