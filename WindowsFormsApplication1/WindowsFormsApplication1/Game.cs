using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Game : DisplayableContext
    {
        public string name { get; set; }
        public int numPlayers { get; set; }
        public List<Player> players { get; set; }
        public int currPlayer { get; set; }
        public Board board = null;
        public Tile tile = null;
        private String _state = "";
        private String _usOkText = "";
        public String UsokText  {
            get{return _usOkText; }
            set
            {
                _usOkText = value;
                onChanged();
            }
        }

        public Game()
        {
            board = new Board(this);
        }

        public Game(List<Player> players) {
            this.players = players;
            board = new Board(this);
            State = "ExamSpin"; //This should be changed to "normal" when we have it

            //TODO other important things that need to be constructed
        }

        public Tile CurrentTile()
        {
            return board.getTileAt(players[currPlayer].boardPosition);
        }

        public Player CurrentPlayer()
        {
            return players[currPlayer];
        }

        public Game(string _name, int _numPlayers, int _currPlayer)
        {
            name = _name;
            numPlayers = _numPlayers;
            int count = 1;
            string college;
            bool community = false;
            players = new List<Player>();

            for(int i = 0; i < _numPlayers; i++)
            {
                string player_Name;
                string color;
                int numLoans = 3000;
                Console.Write("Enter player name:" + count);
                player_Name = Console.ReadLine();

                Console.Write("What color is your back pack?");
                color = Console.ReadLine();

                Console.WriteLine("Are you going to community college or four year university, community for community, traditional for 4 year");
                college = Console.ReadLine();
                
                if(college.ToLower() == "community")
                {
                    community = true;
                    numLoans = 2000;
                } 
                players.Add(new Player(player_Name, color, 0, numLoans, 0, 0, community, false));
                count++;
            }
            currPlayer = _currPlayer;
            takeTurn(players[0], 0);
        }

        public void takeTurn(Player currentPlayer, int position)
        {
            foreach(Player player in players) { 
                if (currentPlayer.isGraduated != true)
                    {
                        
                
                    Random rnd = new Random();
                    string message = "Click the button below to spin for your turn!";
                    var result = MessageBox.Show(message);
                    if(result == DialogResult.Yes)
                    {
                        int spinner = rnd.Next(1, 7);
                        Console.WriteLine("You rolled a :" + spinner);
                        uint spaces = (uint)spinner;
                        board.movePlayer(currentPlayer, spaces);
                        tile = board.getTileAt(currentPlayer.getBoardPosition());
                        tile.actOnCurrentPlayer();

                    }
                    else
                    {
                        int spinner = rnd.Next(1, 7);
                        Console.WriteLine("You rolled a :" + spinner);
                        uint spaces = (uint)spinner;
                        board.movePlayer(currentPlayer, spaces);
                        tile = board.getTileAt(currentPlayer.getBoardPosition());
                        tile.actOnCurrentPlayer();
                    }

                }
            }
        }

        public string State
        {
            get { return _state; }
            private set
            {
                _state = value;
                onChanged();
            }
        }

        public void setState( string newState )
        {
            _state = newState;
            onChanged();
        }

        //This needs to get called when anything changes
        public void onChanged()
        {
            UI.Instance.Update();
        }

        //event handlers!
        public void BackToNormal(object sender, EventArgs e)
        {
            // State = "Normal"; TODO change this back!!
            CurrentTile().actOnCurrentPlayer();
        }
    }
}