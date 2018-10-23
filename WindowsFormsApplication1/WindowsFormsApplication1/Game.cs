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
            int count = 1;
            string college;
            bool community;
            foreach(var Player in players)
            {
                String player_Name;
                String color;
                Console.Write("Enter player:" + count);
                player_Name = Console.ReadLine();

                Console.Write("What color is your back pack?");
                color = Console.ReadLine();

                Console.Write("Are you going to community college or four year university, community for community, traditional for 4 year");
               college = Console.ReadLine();

                if(college.toLower() == "community")
                {
                    community = true;
                } 
                players[count] = Player(player_Name, color, 0, 0, 0, 0, community, false);
                count++;
            }
            currPlayer = _currPlayer;
        }



    }
}