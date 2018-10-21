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

            var newGame = new Game("OofusBoofus");

            Console.WriteLine("Saving yeah");
            XYSaveData savesavesave = new XYSaveData(saveX, saveY);
            using (StreamWriter file = File.CreateText("\\Saveysavey.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                
                serializer.Serialize(file, savesavesave);
            }
        }

        private void loadData() {
            XYSaveData data;
            using (StreamReader file = File.OpenText("\\Saveysavey.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();

                data = (XYSaveData)serializer.Deserialize(file, typeof(XYSaveData));
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
    public class Game
    {
        public string Name { get; set; }
        public int NumPlayers { get; set; }
        public Player[] Players { get; set; }
        public int CurrPlayer {get; set;}

        public Game(string name)
        {
            Name = name;
        }

    }

    public class Player
    {
        public string playerName { get; set; }
        public string playerColor { get; set; }
        public uint boardPosition { get; set; }
        public int numLoans { get; set; }
        public int numFriends { get; set; }
        public int numCredits { get; set; }
        public bool isCommunityCollege { get; set; }
        public bool isGraduated { get; set; }
    }
}
