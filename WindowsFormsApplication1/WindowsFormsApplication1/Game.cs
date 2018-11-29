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
        public uint currSpin { get; set; }
        public Board board = null;
        private String _state = "";
        private String _usOkText = "";
        private Random rand = null;

        public String UsokText
        {
            get{return _usOkText; }
            set
            {
                _usOkText = value;
                onChanged();
            }
        }

        public Game(List<Player> _players)
        {
            this.players = _players;
            numPlayers = players.Count;
            currPlayer = 0;
            board = new Board(this);
            rand = new Random();
            State = "Normal";

            //TODO: any other constructor stuff? should we set the name of the game here too?
        }

        public Tile CurrentTile()
        {
            return board.getTileAt(players[currPlayer].boardPosition);
        }

        public Player CurrentPlayer()
        {
            return players[currPlayer];
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

        public void incrementPlayer()
        {
            currPlayer = (currPlayer + 1) % numPlayers;
        }

        //This needs to get called when anything changes
        public void onChanged()
        {
            UI.Instance.Update();
        }

        //event handlers!
        public void BackToNormal(object sender, EventArgs e)
        {
            State = "Normal";
        }

        public void ViewRules(object sender, EventArgs e)
        {
            //TODO: fill this in!!!
            System.Windows.Forms.MessageBox.Show("donut cheat kidz", "Wow whatta tight response", System.Windows.Forms.MessageBoxButtons.OK);
        }

        public void ViewStats(object sender, EventArgs e)
        {
            //TODO: fill this in!!!
            System.Windows.Forms.MessageBox.Show("sum stats 4 u", "Wow whatta tight response", System.Windows.Forms.MessageBoxButtons.OK);
        }

        public void SaveGame(object sender, EventArgs e)
        {
            //TODO: fill this in!!!
            System.Windows.Forms.MessageBox.Show("Saved!", "Wow whatta tight response", System.Windows.Forms.MessageBoxButtons.OK);
        }

        public void TakeTurn(object sender, EventArgs e)
        {
            if (players[currPlayer].isGraduated)
            {
                currPlayer = (currPlayer + 1) % numPlayers;
                return;
            }

            currSpin = (uint) rand.Next(6) + 1;
            Tile tile = board.movePlayer(players[currPlayer], currSpin);

            if (tile != null)
            {
                tile.actOnCurrentPlayer();
            }
            else
            {
                //this player has graduated check if game is finished
                players[currPlayer].isGraduated = true;
                bool gameFinished = true;
                foreach (Player p in players)
                {
                    if (!players[currPlayer].isGraduated)
                    {
                        gameFinished = false;
                        break;
                    }
                }
                if (gameFinished)
                {
                    //TODO: change state to graduate? call graduate method? idk something here
                    System.Windows.Forms.MessageBox.Show("All done!", "Wow such fun times", System.Windows.Forms.MessageBoxButtons.OK);
                }
                onChanged();
            }
        }
    }
}