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
        public System.Drawing.Color _usOKLightColor = System.Drawing.Color.Moccasin;
        public System.Drawing.Color _usOKDarkColor = System.Drawing.Color.Orange;
        private Random rand = null;
        public int[] gradStats = null;

        public static String rules = "\r\nWELCOME TO THE RULES PAGE\r\ni mean it's real simple, you begin your journey towards the rest of your life\r\n" +
                "you know how CVS receipts are long as shit? you're working towards one of those except it costs $100,000.\r\n" +
                "To play, you begin by selecting your character name, major, and school choice.\r\n" +
                "The first player goes based on who has the lowest test score! You know who you are. Accept it.\r\n" +
                "You progress through the game by spinning the spinner and moving however many spaces you spin. Don't worry, you can't rip the spinner off the board *COUGH gameoflife COUGH* \r\n" +
                "As you make your way across the board, you will encounter different events that charge you loans, give you OCC credit, and even give you friends! (if only it was that easy) \r\n" +
                "When you reach the end of the game, you graduate (hopefully), and the player with the least amount of loans ends up being the 'winner'"; //TODO: WE SHOULD UPDATE THIS TO REFLECT THE RULES FOR GRADUATION OR WHATEVER

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

        public void Graduate()
        {
            gradStats = new int[numPlayers];
            int currPlayer = 0;
            foreach (Player p in players)
            {
                int loans = p.getLoans();
                int credits = p.getCredits();
                int friends = p.getFriends();
                var major = p.getMajor();
                int majorCash = major.getEarningPotential();
                var club = p.getClub();
                int majorClub = club.getEarningPotential();
                var capstone = p.getCapstone();
                int majorCapstone = major.getEarningPotential();
                int total = -loans + (credits * 1000) + (friends * 2000);
                gradStats[currPlayer] = total;
                currPlayer++;
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
            _usOKLightColor = System.Drawing.Color.Thistle;
            _usOKDarkColor = System.Drawing.Color.MediumPurple;
            _usOkText = Game.rules;
            setState("UnitedStatesOfOK");
        }

        public void ViewStats(object sender, EventArgs e)
        {
            setState("Stats");
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
                    if (!p.isGraduated)
                    {
                        gameFinished = false;
                        break;
                    }
                }
                if (gameFinished)
                {
                    Graduate();
                    int winner = gradStats.Max();
                    String myString = "";
                    foreach (Player p in players)
                    {
                        if(Convert.ToInt32(gradStats[currPlayer]).Equals(Convert.ToInt32(gradStats.Max())))
                        {
                            myString += ("Winner: " + currPlayer + " " + gradStats[currPlayer] + "\n");
                        }
                        else
                        {
                            myString += (" " + currPlayer + " " + gradStats[currPlayer] + "\n");
                        }
                        
                    }
                    UsokText = ("All done! Wow such fun times " +  myString);
                    State = "DisplayResults";
                    //TODO: change state to graduate? call graduate method? idk something here
                    //System.Windows.Forms.MessageBox.Show("All done!", "Wow such fun times", System.Windows.Forms.MessageBoxButtons.OK);
                }
                onChanged();
            }
        }

        public void GoToMainMenu(object sender, EventArgs e)
        {
            UI.Instance.SetDisplayContext(new Menu());
        }
    }
}