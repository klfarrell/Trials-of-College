using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Game
    {
        public string Name { get; set; }
        public int NumPlayers { get; set; }
        public Player[] Players { get; set; }
        public int CurrPlayer { get; set; }

        public Game(string name)
        {
            Name = name;
        }

    }
}