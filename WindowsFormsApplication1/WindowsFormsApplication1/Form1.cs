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

            updateSaveButtonData();
        }

        private void updateSaveButtonData() {
            this.button2.Text = "X: " + saveX + "Y: " + saveY;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Holy cow now successfully browned");
            moo_buttons_boi();
        }

        private void saveButtonClicked(object sender, EventArgs e) {
            saveX++;
            saveY = saveX * saveX;
            updateSaveButtonData();

            String game_Name;
            int num_players;

            game_Name = this.gameNameText.Text;
            if(game_Name == null)
            {
                Console.WriteLine("Enter your game name: ");
                game_Name = Console.ReadLine();
            }

            Console.WriteLine("Enter the number of players, a number from 2-5:");
            num_players = Convert.ToInt32(Console.ReadLine());

            var newGame = new Game(game_Name, num_players, 1);
            currGame = newGame;

            Console.WriteLine("Saving yeah");
            XYSaveData savesavesave = new XYSaveData(saveX, saveY);
            using (StreamWriter file = File.CreateText("\\Saveysavey.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();               
                serializer.Serialize(file, savesavesave);
            }

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

        private void loadData() {
            XYSaveData data;
            Game loadGame;
            using (StreamReader file = File.OpenText("\\Saveysavey.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();

                data = (XYSaveData)serializer.Deserialize(file, typeof(XYSaveData));
            }

            using (StreamReader file = File.OpenText("\\SaveGame.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();

                loadGame = (Game)serializer.Deserialize(file, typeof(Game));
            }
            if( loadGame != null)
            {
                Console.Write("Last saved game is named:" + loadGame?.name);
            }

            saveX = data.x;
            saveY = data.y;
        }

        // We like to have fun here
        private void moo_buttons_boi() {
            //To the right
            x += 200;

            var newButtonBoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mostly copied and pasted this shit from the auto generated stuff
            // 
            newButtonBoi.Location = new System.Drawing.Point(x, 78); 
            // ^ See what I did there? x is a variable that gets BIGGER and each button gets 
            // more RIGHTeous.
            newButtonBoi.Name = "booooooooooootin";
            newButtonBoi.Size = new System.Drawing.Size(190, 76);
            newButtonBoi.TabIndex = 0;
            newButtonBoi.Text = "Is YOUR holy cow not brown enough?";
            newButtonBoi.UseVisualStyleBackColor = true;
            // Ehh I'll keep this one the same
            newButtonBoi.Click += new System.EventHandler(this.button1_Click);
            this.Controls.Add(this.button1);

            // Dont forget to add this bitch in
            this.Controls.Add(newButtonBoi);
            // In C sharp, properties can be methods in disguise so we gotta do these again
            // because they do....... something......
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ResumeLayout(false);

        }

        private List<System.Windows.Forms.Button> moreButtons;
        private int x = 26;
        private int saveX = 0;
        private int saveY = 0;

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
