using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Menu : DisplayableContext
    {
        private string _state;

        private int _numPlayers;
        private string _loadPath;
        private string _gameName;
        private string _playerName;
        private string _playerColor;
        private bool _playerPath;

        private int _currentPlayer;
        private List<Player> _players;

        public string State
        {
            get { return _state; }
            private set {
                _state = value;
                onChanged();
            }
        }

        public int NumPlayers
        {
            get { return _numPlayers; }
            private set
            {
                _numPlayers = value;
                onChanged();
            }
        }

        public string LoadPath
        {
            get { return _loadPath; }
            private set
            {
                _loadPath = value;
                onChanged();
            }
        }

        public Menu() {
            State = "Normal";
            ResetDetails();
        }

        public string GameName
        {
            get { return _gameName; }
            private set
            {
                _gameName = value;
                onChanged();
            }
        }

        public string PlayerName
        {
            get { return _playerName; }
            private set
            {
                _playerName = value;
                onChanged();
            }
        }

        public string PlayerColor
        {
            get { return _playerColor; }
            private set
            {
                _playerColor = value;
                onChanged();
            }
        }

        public bool PlayerPath
        {
            get { return _playerPath; }
            private set
            {
                _playerPath = value;
                onChanged();
            }
        }

        public int CurrentPlayer
        {
            get { return _currentPlayer; }
            private set
            {
                _currentPlayer = value;
                onChanged();
            }
        }

        // These are the methods the buttons will use to communicate to the model
        // They have to have these parameters so forms understands it
        // Notice that it is just changing the state and the properties with capital letters (see above)
        // Automatically update the UI

        // If it looks verbose, it can be made smaller by making a method to
        // Return any of these as a delegate, but I want to keep it as simple as possible for now
        public void Number2Clicked(object sender, EventArgs e)
        {
            NumPlayers = 2;
        }

        public void Number3Clicked(object sender, EventArgs e)
        {
            NumPlayers = 3;
        }

        public void Number4Clicked(object sender, EventArgs e)
        {
            NumPlayers = 4;
        }

        public void Number5Clicked(object sender, EventArgs e)
        {
            NumPlayers = 5;
        }

        public void NameNumberNextButtonClicked(object sender, EventArgs e)
        {
            _currentPlayer = 1;
            State = "CreatePlayer";
        }

        public void GameNameChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            _gameName = textBox.Text;
        }

        public void CeruleanButtonClicked(object sender, EventArgs e)
        {
            PlayerColor = "Cerulean";
        }

        public void VermillionButtonClicked(object sender, EventArgs e)
        {
            PlayerColor = "Vermillion";
        }

        public void SaffronButtonClicked(object sender, EventArgs e)
        {
            PlayerColor = "Saffron";
        }

        public void ViridianButtonClicked(object sender, EventArgs e)
        {
            PlayerColor = "Viridian";
        }

        public void IndigoButtonClicked(object sender, EventArgs e)
        {
            PlayerColor = "Indigo";
        }

        public void CommunityButtonClicked(object sender, EventArgs e)
        {
            PlayerPath = true;
        }

        public void FourYearButtonClicked(object sender, EventArgs e)
        {
            PlayerPath = false;
        }

        public void SubmitButtonClicked(object sender, EventArgs e)
        {
            _players.Add(new Player(PlayerName, PlayerColor, -1, PlayerPath ? 7000 : 10000, 0, 0, PlayerPath, false));
            if (CurrentPlayer == NumPlayers)
            {
                Game game = new Game(_players);
                UI.Instance.SetDisplayContext(game);
            }
            _playerColor = "Vermillion";
            _playerPath = false;
            _playerName = "";
            onChanged();
            CurrentPlayer++;
        }

        public void PlayerNameBoxChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            _playerName = textBox.Text;
        }

        public void CreateGameButtonPressed(object sender, EventArgs e)
        {
            State = "NameNumber";
        }

        public void LoadGameButtonPressed(object sender, EventArgs e)
        {
            State = "LoadGame";
        }

        public void ViewRulesButtonPressed(object sender, EventArgs e)
        {
            State = "Rules";
        }

        public void CancelButtonPressed(object sender, EventArgs e)
        {
            State = "Normal";
            ResetDetails();
        }

        private void ResetDetails()
        {
            _numPlayers = 2;
            _loadPath = "";
            _gameName = "Game1";
            _playerColor = "Vermillion";
            _playerPath = false;
            _playerName = "";
            _currentPlayer = 1;
            _players = new List<Player>();
            onChanged();
        }

        public void CompleteLoadButtonPressed(object sender, EventArgs e)
        {
            var game = LoadGame("\\SaveGame.txt");
            UI.Instance.SetDisplayContext(game);
        }

        // Justin's load game implementation
        private Game LoadGame(string path) {
            Game loadGame;

            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();

                loadGame = (Game)serializer.Deserialize(file, typeof(Game));
            }
            return loadGame;
        }

        //This needs to get called when anything changes
        public void onChanged()
        {
            UI.Instance.Update();
        }
    }

    


}
