using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Game currGame;
        public Form1()
        {
            InitializeComponent();

            //The solution to everything
            try {
                loadData();
            } catch (Exception e) { }

        }

        private void saveButtonClicked(object sender, EventArgs e) {

            String game_Name;
            int num_players = 0;

            if(this.gameNameText.Text == "")
            {
                Console.WriteLine("Enter your game name: ");
                game_Name = Console.ReadLine();
            }
            else
            {
                game_Name = this.gameNameText.Text;
            }
           
            if(this.playerNumText.Text == "")
            {
                Console.WriteLine("Enter the number of players, a number from 2-5:");
                num_players = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                num_players = Convert.ToInt32(this.playerNumText.Text);
            }
            
            var newGame = new Game(game_Name, num_players, 1);
            currGame = newGame;

            Console.WriteLine("Saving yeah");
            using (StreamWriter file = File.CreateText("\\SaveGame.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();

                serializer.Serialize(file, newGame);
            }
        }

        private void viewPlayerStats(object sender, EventArgs e)
        {
            string playerStats = "";
            int count = 1;
            this.Controls.Add(this.playerStatsLabel);
            this.Controls.Add(this.playerStatsText);
            this.Controls.Remove(this.statsButton);
            if (currGame != null)
            {
                foreach (Player player in currGame.players)
                {
                    playerStats += "Player " + count + ": Name: " + player.playerName +
                        "\r\nColor: " + player.playerColor + "\r\nLoans: " + player.numLoans.ToString() +
                        "\r\nFriends: " + player.numFriends.ToString() + "\r\nOCC Credit: " + player.numCredits.ToString() + "\r\n";
                    count++;
                }
                this.playerStatsText.Text = playerStats;
            }
            else
            {
                this.playerStatsText.Text = "Please either create a new game or load to view player stats.";
            }
            this.Controls.Add(this.closeStats);
        }

        private void closeStatsClick(object sender, EventArgs e)
        {
            this.Controls.Remove(this.playerStatsText);
            this.Controls.Remove(this.playerStatsLabel);
            this.Controls.Remove(this.closeStats);
            this.Controls.Add(this.statsButton);
        }

        private void viewGameRules(object sender, EventArgs e)
        {
            this.Controls.Add(this.gameRulesLabel);
            this.Controls.Add(this.gameRulesText);
            this.Controls.Remove(this.rulesButton);
            this.gameRulesText.Text = "\r\nWELCOME TO THE RULES PAGE\r\ni mean it's real simple, you begin your journey towards the rest of your life\r\n" +        
                "you know how CVS receipts are long as shit? you're working towards one of those except it costs $100,000.\r\n" +        
                "To play, you begin by selecting your character name, major, and school choice.\r\n" +               
                "The first player goes based on who has the lowest test score! You know who you are. Accept it.\r\n" +               
                "";
            this.Controls.Add(this.closeRules);
        }
        private void closeRulesClick(object sender, EventArgs e)
        {
            this.Controls.Remove(this.gameRulesText);
            this.Controls.Remove(this.gameRulesLabel);
            this.Controls.Remove(this.closeRules);
            this.Controls.Add(this.rulesButton);
        }

        private void loadData() {
            Game loadGame;

            using (StreamReader file = File.OpenText("\\SaveGame.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();

                loadGame = (Game)serializer.Deserialize(file, typeof(Game));
            }
            if( loadGame != null)
            {
                Console.Write("Last saved game is named:" + loadGame?.name);
            }

        }

    }
}
