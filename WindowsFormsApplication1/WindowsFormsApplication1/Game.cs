using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Game
    {
        public string name { get; set; }
        public int numPlayers { get; set; }
        public Player[] players { get; set; }
        public int currPlayer { get; set; }

        public Game(string _name, int _numPlayers, int _currPlayer)
        {
            name = _name;
            numPlayers = _numPlayers;
            players = new Player[numPlayers];
            currPlayer = _currPlayer;
        }



    }
}