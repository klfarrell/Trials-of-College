using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class StopTile : Tile
    {
        private PlayerCharacteristic[][] fourYrList;
        private PlayerCharacteristic[][] commList;
        public PlayerCharacteristic[] options = null;
        private Game gameRef;
        private Random rand;
        public int examSpinVal = -1;

        private void chooseCharacteristic( Player p )
        {
            int[] categories;
            if ( p.isCommunityCollege )
            {
                options = new PlayerCharacteristic[2];
                categories = new int[2];
                categories[0] = rand.Next(commList.Length);
                categories[1] = categories[0];
                while (categories[0] == categories[1])
                    categories[1] = rand.Next(commList.Length);

                for (int i = 0; i < 2; i++)
                    options[i] = commList[categories[i]][rand.Next(commList[categories[i]].Length)];
            }
            else
            {
                options = new PlayerCharacteristic[3];
                categories = new int[3];
                categories[0] = rand.Next(commList.Length);
                categories[1] = categories[2] = categories[0];
                while ( categories[0] == categories[1] )
                    categories[1] = rand.Next(commList.Length);
                while ( categories[0] == categories[2] || categories[1] == categories[2] )
                    categories[2] = rand.Next(commList.Length);

                for (int i = 0; i < 3; i++)
                    options[i] = fourYrList[categories[i]][rand.Next(fourYrList[categories[i]].Length)];
            }

            gameRef.setState("ChoosePC");  
        }

        public StopTile(int seed, Game theGame)
        {
            gameRef = theGame;
            rand = new Random();

            //create player characteristic lists
            switch( seed )
            {
                case 0: //pick major

                    fourYrList = new PlayerCharacteristic[5][];
                    commList = new PlayerCharacteristic[3][];

                    //Business Majors
                    PlayerCharacteristic[] businessMajors = new PlayerCharacteristic[6];
                    businessMajors[0] = new Major( "Equestrian Business", 30000 );
                    businessMajors[1] = new Major( "Accounting", 30000 );
                    businessMajors[2] = new Major( "International Business", 30000 );
                    businessMajors[3] = new Major( "Carrier Pigeon Transportation Management", 30000 );
                    businessMajors[4] = new Major( "Finance", 30000 );
                    businessMajors[5] = new Major( "Defense Against the Dark Arts", 30000 );
                    fourYrList[0] = commList[0] = businessMajors;

                    //Humanities Majors
                    PlayerCharacteristic[] humanitiesMajors = new PlayerCharacteristic[6];
                    humanitiesMajors[0] = new Major( "Wumbology", 20000 );
                    humanitiesMajors[1] = new Major( "Bird Portraiture", 20000 );
                    humanitiesMajors[2] = new Major( "Political Science", 20000 );
                    humanitiesMajors[3] = new Major( "Vocal Performance", 20000 );
                    humanitiesMajors[4] = new Major( "Art History", 20000 );
                    humanitiesMajors[5] = new Major( "Divination", 20000 );
                    fourYrList[1] = commList[1] = humanitiesMajors;

                    //Social Science Majors
                    PlayerCharacteristic[] socialMajors = new PlayerCharacteristic[6];
                    socialMajors[0] = new Major( "Bird Law", 20000 );
                    socialMajors[1] = new Major( "Psychology", 20000 );
                    socialMajors[2] = new Major( "Philosophy", 20000 );
                    socialMajors[3] = new Major( "Economics", 20000 );
                    socialMajors[4] = new Major( "Muggle Studies", 20000 );
                    socialMajors[5] = new Major( "Canadian Studies, Eh?", 20000 );
                    fourYrList[2] = commList[2] = socialMajors;

                    //Engineering Majors
                    PlayerCharacteristic[] engrMajors = new PlayerCharacteristic[6];
                    engrMajors[0] = new Major( "Computer Engineering", 60000 );
                    engrMajors[1] = new Major( "Mechanical Engineering", 60000 );
                    engrMajors[2] = new Major( "Chemical Engineering", 60000 );
                    engrMajors[3] = new Major( "Bio-Nuclear Engineering", 60000 );
                    engrMajors[4] = new Major( "Aviary Engineering", 60000 );
                    engrMajors[5] = new Major( "Arithmancy Engineering", 60000 );
                    fourYrList[3] = engrMajors;

                    //Science Majors
                    PlayerCharacteristic[] scienceMajors = new PlayerCharacteristic[6];
                    scienceMajors[0] = new Major( "Chemistry", 45000 );
                    scienceMajors[1] = new Major( "Biology", 45000 );
                    scienceMajors[2] = new Major( "Environmental Science", 45000 );
                    scienceMajors[3] = new Major( "Ornothology", 45000 );
                    scienceMajors[4] = new Major( "Bee Keeping", 45000 );
                    scienceMajors[5] = new Major( "Herbology", 45000 );
                    fourYrList[4] = scienceMajors;

                    break;

                case 1: //pick club

                    fourYrList = new PlayerCharacteristic[5][];
                    commList = new PlayerCharacteristic[3][];

                    //Misc Clubs
                    PlayerCharacteristic[] miscClubs = new PlayerCharacteristic[6];
                    miscClubs[0] = new Club("Wine Tasting Club", 1000);
                    miscClubs[1] = new Club("My Hero Academia Club", 1000);
                    miscClubs[2] = new Club("Doctor Who Club", 1000);
                    miscClubs[3] = new Club("Outdoors Club", 1000);
                    miscClubs[4] = new Club("Bird Watching Club", 1000);
                    miscClubs[5] = new Club("Volunteer Society", 3000);
                    fourYrList[0] = commList[0] = miscClubs;

                    //Intramural Sports
                    PlayerCharacteristic[] intrSports = new PlayerCharacteristic[4];
                    intrSports[0] = new Club( "Club Quidditch", 2000 );
                    intrSports[1] = new Club( "Intramural Golf", 2000 );
                    intrSports[2] = new Club( "Intramural Ultimate Frisbee", 2000 );
                    intrSports[3] = new Club( "Club Climbing", 2000 );
                    fourYrList[1] = commList[1] = intrSports;

                    //Music Clubs
                    PlayerCharacteristic[] music = new PlayerCharacteristic[6];
                    music[0] = new Club( "Jazz Band", 2000 );
                    music[1] = new Club( "African Drumming Ensemble", 2000 );
                    music[2] = new Club( "Choir", 2000 );
                    music[3] = new Club( "Handbell Ensemble", 20000 );
                    music[4] = new Club( "A Capella Ensemble", 2000 );
                    music[5] = new Club( "University Orchestra", 2000 );
                    fourYrList[2] = commList[2] = music;

                    //Academic Societies
                    PlayerCharacteristic[] academic = new PlayerCharacteristic[5];
                    academic[0] = new Club( "Chinese Language and Culture Club", 5000 );
                    academic[1] = new Club( "Women in Computer Science Club", 5000 );
                    academic[2] = new Club( "Philosophy of Science Club", 5000 );
                    academic[3] = new Club( "Video Game Creation Club", 5000 );
                    academic[4] = new Club( "Phi Beta Kappa Honor Society", 10000 );
                    fourYrList[3] = academic;

                    //D1 Sports
                    PlayerCharacteristic[] d1Sports = new PlayerCharacteristic[5];
                    d1Sports[0] = new Club( "D1 Football", 10000 );
                    d1Sports[1] = new Club( "D1 Basketball", 10000 );
                    d1Sports[2] = new Club( "D1 Wrestling", 10000 );
                    d1Sports[3] = new Club( "D1 Volleyball", 10000 );
                    d1Sports[4] = new Club( "D1 Cheerleading", 10000 );
                    fourYrList[4] = d1Sports;

                    break;

                case 2: //pick capstone

                    fourYrList = new PlayerCharacteristic[5][];
                    commList = new PlayerCharacteristic[3][];

                    //Research
                    PlayerCharacteristic[] research = new PlayerCharacteristic[6];
                    research[0] = new Capstone( "Research the effect of gender on political campaigning", 12500 );
                    research[1] = new Capstone( "Conduct research in a lab that sends stuff into space", 17000);
                    research[2] = new Capstone( "Research new antibiotics", 17000 );
                    research[3] = new Capstone( "Research String Theory", 15000 );
                    research[4] = new Capstone( "Research how eating copious amounts of ramen affects students' academic success", 10000 );
                    research[5] = new Capstone( "Conduct research in an attempt to correlate musical ability with affinity for cilantro", 10000 );
                    fourYrList[0] = commList[0] = research;

                    //Study Abroad
                    PlayerCharacteristic[] studyAbroad = new PlayerCharacteristic[10];
                    studyAbroad[0] = new Capstone( "Study abroad in Paris", 7000 );
                    studyAbroad[1] = new Capstone( "Study abroad in Tokyo", 7000 );
                    studyAbroad[2] = new Capstone( "Study abroad in Shanghai", 7000 );
                    studyAbroad[3] = new Capstone( "Study abroad in Toronto", 7000 );
                    studyAbroad[4] = new Capstone( "Study abroad in Morocco", 7000 );
                    studyAbroad[5] = new Capstone( "Study abroad in Rio de Janeiro", 7000 );
                    studyAbroad[6] = new Capstone( "Study abroad in Sydney, Australia", 7000 );
                    studyAbroad[7] = new Capstone( "Study abroad in South Africa", 7000 );
                    studyAbroad[8] = new Capstone( "Study abroad in Toronto", 5000 );
                    studyAbroad[9] = new Capstone( "\"Study abroad\" trip to visit significant sites in the history of the Mormon Church", 5000 );
                    fourYrList[1] = commList[1] = studyAbroad;

                    //Internship
                    PlayerCharacteristic[] internship = new PlayerCharacteristic[5];
                    internship[0] = new Capstone( "Internship at Google", 15000 );
                    internship[1] = new Capstone( "Internship at your Uncle's small business", 6000 );
                    internship[2] = new Capstone( "Internship at Boeing", 13000 );
                    internship[3] = new Capstone( "Internship at Disney", 13000 );
                    internship[4] = new Capstone( "\"Internship\" at a restaurant (i.e. bussing tables)", 4000 );
                    fourYrList[2] = commList[2] = internship;

                    //Thesis
                    PlayerCharacteristic[] thesis = new PlayerCharacteristic[3];
                    thesis[0] = new Capstone( "Write a 40-page thesis highly related to your major (and get published!)", 15000 );
                    thesis[1] = new Capstone( "Write a 30-page thesis loosely related to your major", 7000 );
                    thesis[2] = new Capstone( "Write a 20-page thesis not at all related to your major", 5000 );
                    fourYrList[3] = thesis;

                    //Independent Study
                    PlayerCharacteristic[] indepStudy = new PlayerCharacteristic[5];
                    indepStudy[0] = new Capstone( "Conduct an independent study of kookaburra migration patterns", 6000 );
                    indepStudy[1] = new Capstone( "Conduct an independent study on feminism in 1930's horror film", 7000 );
                    indepStudy[2] = new Capstone( "Conduct an independent study on satirical western film and race", 6500 );
                    indepStudy[3] = new Capstone( "Conduct an independent study on the role of cryptography in World War II", 7000 );
                    indepStudy[4] = new Capstone( "Conduct an independent study of civil engineering safety practices in the 19th century", 6000 );
                    fourYrList[4] = indepStudy;

                    break;
            }
        }

        public String getText()
        {
            return "";
        }

        public CharacteristicType getType()
        {
            return commList[0][0].getType();
        }

        public void actOnCurrentPlayer()
        {
            examSpinVal = -1;
            gameRef.setState("ExamSpin");
        }

        public bool isStopTile()
        {
            return true;
        }

        //add event handlers
        public void SetChosenCharacteristicA(object sender, EventArgs e)
        {
            SetChosenCharacteristic(0);
        }

        public void SetChosenCharacteristicB(object sender, EventArgs e)
        {
            SetChosenCharacteristic(1);
        }

        public void SetChosenCharacteristicC(object sender, EventArgs e)
        {
            SetChosenCharacteristic(2);
        }

        private void SetChosenCharacteristic(int index)
        {
            switch (options[index].getType())
            {
                case CharacteristicType.MAJOR:
                    gameRef.CurrentPlayer().major = options[index];
                    break;
                case CharacteristicType.CLUB:
                    gameRef.CurrentPlayer().club = options[index];
                    break;
                case CharacteristicType.CAPSTONE:
                    gameRef.CurrentPlayer().capstone = options[index];
                    break;
            }

            options = null;
            gameRef.setState("Normal");
        }

        public void GetExamSpin(object sender, EventArgs e)
        {
            examSpinVal = rand.Next(6) + 1;
            if (examSpinVal > 2)
            {
                gameRef.CurrentPlayer().passedLastExam = true;
                chooseCharacteristic(gameRef.CurrentPlayer());
            }
            else
            {
                gameRef.CurrentPlayer().passedLastExam = false;
                gameRef.incrementPlayer();
                gameRef._usOKLightColor = System.Drawing.Color.LightSteelBlue;
                gameRef._usOKDarkColor = System.Drawing.Color.RoyalBlue;
                gameRef.UsokText = "Oh, bother.  It looks like you only scored a ";
                gameRef.UsokText += examSpinVal + " out of 6 on your exams.  Take time to";
                gameRef.UsokText += " study up before next turn, because you'll have to";
                gameRef.UsokText += " take them again.  Better luck next time, kid, everyone";
                gameRef.UsokText += " will be cheering you on (as long as you didn't go to one of ";
                gameRef.UsokText += "those insanely competitive schools where classmates sabotoge ";
                gameRef.UsokText += "each other's work, but that's another game entirely). Anyway, get";
                gameRef.UsokText += " outta here and don't let me see you face again until you're";
                gameRef.UsokText += " holding up an A+ for me.";
                gameRef.setState("UnitedStatesOfOK");
            }
        }
    }
}