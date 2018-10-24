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
            int count = 0;
            string college;
            bool community = false;
            foreach(var Player in players)
            {
                string player_Name;
                string color;
                int loans = 3000;
                Console.WriteLine("Enter player:" + count);
                player_Name = Console.ReadLine();

                Console.WriteLine("What color is your back pack?");
                color = Console.ReadLine();

                Console.WriteLine("Are you going to community college or four year university, community for community, traditional for 4 year");
                college = Console.ReadLine();

                //if(college.ToLower() == "community")
                //{
                //    community = true;
                //    loans = 2000;
                //} 
                players[count] = new Player(player_Name, color, 0, loans, 0, 0, community, false);
                if(count <= numPlayers)
                {
                    count++;
                }
                
            }
            currPlayer = _currPlayer;
        }



    }
}