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
        public List<Player> players { get; set; }
        public int currPlayer { get; set; }

        public Game(string _name, int _numPlayers, int _currPlayer)
        {
            name = _name;
            numPlayers = _numPlayers;
            players = new List<Player>();
            int count = 1;
            string college;
            bool community = false;
            for(int i = 0; i < _numPlayers; i++)
            {
                String player_Name;
                String color;
                Console.WriteLine("Enter player:" + count);
                player_Name = Console.ReadLine();

                Console.WriteLine("What color is your back pack?");
                color = Console.ReadLine();

                Console.WriteLine("Are you going to community college or four year university, community for community, traditional for 4 year");
               college = Console.ReadLine();

                if(college.ToLower() == "community")
                {
                    community = true;
                } 
                players.Add(new Player(player_Name, color, 0, 0, 0, 0, community, false));
                count++;
            }
            currPlayer = _currPlayer;
        }



    }
}