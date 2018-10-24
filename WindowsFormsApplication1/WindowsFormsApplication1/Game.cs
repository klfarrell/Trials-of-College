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
<<<<<<< HEAD
            players = new Player[numPlayers];
            int count = 1;
            string college;
            bool community;
            foreach(var Player in players)
            {
<<<<<<< HEAD
                string player_Name;
                string color;
                int loans = 3000;
=======
            players = new List<Player>();
            int count = 1;
            string college;
            bool community = false;
            for(int i = 0; i < _numPlayers; i++)
            {
                String player_Name;
                String color;
>>>>>>> fcf17610dc375d5c013d098efa0fb51be7d3ed22
                Console.WriteLine("Enter player:" + count);
=======
                String player_Name;
                String color;
                Console.Write("Enter player:" + count);
>>>>>>> parent of b28a282... Add textbox for game name
                player_Name = Console.ReadLine();

                Console.Write("What color is your back pack?");
                color = Console.ReadLine();

<<<<<<< HEAD
                Console.WriteLine("Are you going to community college or four year university, community for community, traditional for 4 year");
<<<<<<< HEAD
                college = Console.ReadLine();
=======
                Console.Write("Are you going to community college or four year university, community for community, traditional for 4 year");
               college = Console.ReadLine();
>>>>>>> parent of b28a282... Add textbox for game name

                if(college.toLower() == "community")
                {
<<<<<<< HEAD
                    count++;
                }
                
=======
               college = Console.ReadLine();

                if(college.ToLower() == "community")
                {
                    community = true;
                } 
                players.Add(new Player(player_Name, color, 0, 0, 0, 0, community, false));
                count++;
>>>>>>> fcf17610dc375d5c013d098efa0fb51be7d3ed22
=======
                    community = true;
                } 
                players[count] = Player(player_Name, color, 0, 0, 0, 0, community, false);
                count++;
>>>>>>> parent of b28a282... Add textbox for game name
            }
            currPlayer = _currPlayer;
        }



    }
}