using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Board
    {
        private Tile[] gameTiles;

        public Board()
        {
            gameTiles = new Tile[64];

            // Orientation Week
            gameTiles[0] = new EventTile( "Go to the Activity Fair - Gain 1 OCC Credit", EventTileType.OCC, 1 );
            gameTiles[1] = new EventTile( "You go out to a party with Janet and Marty who live on the same floor as you." +
                "Janet drinks too much - you’re painfully sober.You forget about the Safe Rider pamphlet in your pocket and " +
                "call a taxi service to pick up Janet - Take $1000 in loans to pay for the ride", EventTileType.LOAN, 1000 );
            gameTiles[2] = new EventTile( "Your roommate also likes anime! Gain 1 Friend", EventTileType.FRIEND, 1 );
            gameTiles[3] = new EventTile( "Go to the first day of volleyball tryouts and realize how unathletic you are.  " +
                "Gain 1 OCC Credit for trying", EventTileType.OCC, 1 );
            gameTiles[4] = new EventTile( "You realize that you can use Meal Swipes at the Campus Corner Store before everyone" +
                " else does.  Save all your dining dollars and pay off $2000 of your loans", EventTileType.LOAN,-2000 );
            gameTiles[5] = new EventTile( "Your best friend who moved away from your hometown in third grade lives in your " +
                "building.  Run into them on the elevator on your way to get a Peppermint Patty from the vending machine.  " +
                "You have a long talk about your lives since the last time your saw each other 10 years ago.  You offer to share " +
                "your peppermint patty with them - Gain 1 friend", EventTileType.FRIEND, 1 );
            gameTiles[6] = new EventTile ( "You realize how much shit you forgot from home: a calculator, a duvet, toothpaste, " +
                "and your poster of two dogs on a surfboard - Take out $2000 more in loans to go to the store", EventTileType.LOAN, 
                2000 );

            // Year 1
            gameTiles[7] = new EventTile  ( "Your Intro to Communications professor makes the whole class do an ice breaker.  You" +
                " all groaned, but alas it worked.  Gain 1 Friend.", EventTileType.FRIEND, 1 );
            gameTiles[8] = new EventTile( "You enroll Chemistry Lab - Take $2000 in Loans to pay the lab fee", EventTileType.LOAN, 
                2000 );
            gameTiles[9] = new EventTile( "Join the Quidditch team - Gain 1 OCC Credit", EventTileType.OCC, 1 );
            gameTiles[10] = new EventTile ( "You get emotionally distraught over seeing sad puppies on a TV commercial for an Animal" +
                " Rescue service.  You immediately call to donate some of your funds. Damn you, Sarah Mclachlan - Take $1000 more in" +
                " loans.",  EventTileType.LOAN, 1000 );
            gameTiles[11] = new EventTile( "Your parents come for family weekend and take you to Costco.  You get them to buy you " +
                "14-lbs of cream cheese, 6 cases of Top Ramen (TM), a case of razors (that will probably cut you, but you don’t care " +
                "because they’re free), a gallon-size jar of peanut butter, a huge bag of Swedish Fish, and a king-size blanket (so " +
                "soft!).  Take $3000 dollars off your loans.", EventTileType.LOAN, -3000 );
            gameTiles[12] = new EventTile( "ou consensually ‘fall asleep’ in someone’s room on your floor - Gain 1 Friend (With " +
                "Benefits)", EventTileType.FRIEND, 1 );
            gameTiles[13] = new EventTile( "You are standing next to someone in the line for grilled chicken at the dining hall. " +
                " It’s taking so long that you get to talking and find out that you have a mutual passion for neurofunk - Gain 1 " +
                "friend.", EventTileType.FRIEND, 1 );
            gameTiles[14] = new EventTile( "You’ve been watching a lot of pirated TV shows on your laptop - you think you have a " +
                "virus, so you delete the System folder from your computer like your ‘friend’ tells you to, but it actually deletes " +
                "your kernel and destroys your laptop - Take out $7000 more in loans for your many calls with the IT desk and the " +
                "eventual cost of your new laptop.", EventTileType.LOAN, 7000 );
            gameTiles[15] = new EventTile ( "You go to your RA’s floor program because you feel guilty that everyone else stopped " +
                "going - Get all of the pizza and 1 OCC Credit", EventTileType.OCC, 1 );
            gameTiles[16] = new EventTile( "A senior gives you the Google Drive with all of the electronic copies of the textbooks " +
                "you need for the semester - Save money and pay off $2000 of your loans.", EventTileType.LOAN, -2000 );
            gameTiles[17] = new EventTile( "You aca-try out for an a capella group and you aca-suck - Gain 1 aca-pity OCC Credit for " +
                "trying", EventTileType.OCC, 1 );
            gameTiles[18] = new EventTile( "You go to the bathroom in the basement at a frat party, and some random bitch (note: " +
                "bitch does not imply any gender, it is simply a term of endearment for this new person you have met) comes in with" +
                " you, as though they were invited.  The song “Bop to the Top” from High School Musical (TM) comes on as joke and " +
                "you unironically sing along together - Gain 1 friend", EventTileType.FRIEND, 1 );
            gameTiles[19] = new EventTile( "You skip your manditory \"check-in conversation\" with your RA - lose 1 OCC credit", 
                EventTileType.OCC, -1 );
            gameTiles[20] = new EventTile( "You win a scholarship for your aspiring musical talents. Take $6000 off your loans.", 
                EventTileType.LOAN, -6000 );
            gameTiles[21] = new EventTile( "Attend the career fair! Your classmates are, like, super impressed that you, a lowly " +
                "Freshman, are going so early! You confidently walk up to a booth with your high school fast food job details laid " +
                "out on your resume, and the recruiter asks you a question that's WAY too hard for you to answer. You fumble around " +
                "with your words before excusing yourself from the table. ...Well at least he still has your resume \"on file.\" " +
                "Earn 1 OCC Credit for embarrassing yourself and getting blacklisted from this company", EventTileType.OCC, 1 );
            gameTiles[22] = new StopTile( 0 );

            // Year 2
            gameTiles[23] = new EventTile( "You walk down the hall and see someone eating a chocolate bar. You ask them what they " +
                "are eating and they scream, RECTANGLES. Gain one friend over your mutual love of spongebob", EventTileType.FRIEND, 1);
            gameTiles[24] = new EventTile( "Your high school ex sends you a snapchat. Okay...That's weird. It's been years since you " +
                "spoke. But fine. You decide (after waiting an appropriate amount of time so as to not seem too eager) to open it. " +
                "You click the snap and are faced with a horrible, awkward photo of you from your middle school yearbook captioned: \"Yikes.\" " +
                " Yikes indeed. Take out $1000 in loans to cover your ...juice bill as you try to forget about your problems.", EventTileType.LOAN, 1000 ); 
            gameTiles[25] = new EventTile( "Your RA hosts an information session about becoming an RA! You're walking back to your room after class and happen " +
                "to walk through the lounge to see them sitting there, alone. You say hi and they get so excited thinking that someone wanted to come to the event, that " +
                "you now feel obligated to stay. Earn one OCC Credit for making their miserable job a little better.", EventTileType.OCC, 1 );
            gameTiles[26] = new EventTile( "Your neighbor just can't seem to handle your passion for heavy metal bagpipping - lose " +
                "1 friend", EventTileType.FRIEND, -1 );
            gameTiles[27] = new EventTile( "Your roommate keeps a pecan pie leftover from Thanksgiving in your fridge. How nice of them! " +
                "It stays there until you move out in May. Take out $3000 in loans to buy a new fridge that's not infested with mold.", EventTileType.LOAN, 3000 );
            gameTiles[28] = new EventTile( "Your friends enter you into a waffle eating contest without your knowledge" +
                "you being the good sport you are decide to participate anyway. You absolutely devour the waffles and win" +
                "first place. Gain 1 OCC credit as everyone is so impressed by your skills", EventTileType.OCC, 1 ); 
            gameTiles[29] = new EventTile( "A new person on your floor stops into your room to say hi and sees you looking" +
                "at your newest DND character. You start to sweat as you didn't want people in your dorm to know." +
                "they look at you and start bonding over their love for dnd. Gain one friend", EventTileType.FRIEND, 1 ); 
            gameTiles[30] = new EventTile( "", EventTileType.LOAN, 1 ); //TODO: define this Event Tile //TODO: define this Event Tile
            gameTiles[31] = new EventTile( "", EventTileType.OCC, 1 ); //TODO: define this Event Tile
            gameTiles[32] = new EventTile( "You tell your friend your true feelings about their significant other - Lose 1 Friend", 
                EventTileType.FRIEND, -1 );
            gameTiles[33] = new EventTile( "You stub your toe while watering your spice garden.  You only cry for 20 minutes. " +
                " Gain 1 OCC credit for your emotional composure", EventTileType.OCC, 1 );
            gameTiles[34] = new EventTile( "You're walking down the hallway in Generic College Building Hall and you see something " +
                "written on a white board... You look closer and see the words \"$16.50 / hr for student work!Call 123 - 4567 for " +
                "details!\" YOU are a student! And YOU need work!! This offer seems enticing... You call the number where they " +
                "describe what sounds like a really fun summer of painting houses! Boom. You're hooked. You show up on your first " +
                "day, sign the contract, and find yourself bound to a pyramid scheme. Take out $4000 in loans to cover the cost of " +
                "all that goddamn paint.", EventTileType.LOAN, 4000 );
            gameTiles[35] = new EventTile( "You wake up from a weekend-long bender to find out from your roommate that you took a " +
                "leak on your RA’s door - lose 1 OCC credit", EventTileType.OCC, -1 );
            gameTiles[36] = new EventTile( "", EventTileType.LOAN, 1 ); //TODO: define this Event Tile
            gameTiles[37] = new StopTile( 1 );

            // Year 3
            gameTiles[38] = new EventTile( "Taxi Service Surge Pricing — Take $1000 in Loans", EventTileType.LOAN, 1000 );
            gameTiles[39] = new EventTile( "", EventTileType.OCC, 1 ); //TODO: define this Event Tile
            gameTiles[40] = new EventTile( "You go to a party! As soon as you walk in, you find yourself zip-tied to Austin. After " +
                "a while of str8 chillin, Austin tells you he really needs to use the restroom, but you're still zip-tied together! " +
                "You look for scissors but can only find steak knives. Your hands aren't steady enough for that shit! Gain one friend " +
                "through the bond of trying not to see their wang.", EventTileType.FRIEND, 1 );
            gameTiles[41] = new EventTile( "", EventTileType.LOAN, 1 ); //TODO: define this Event Tile
            gameTiles[42] = new EventTile( "", EventTileType.OCC, 1 ); //TODO: define this Event Tile
            gameTiles[43] = new EventTile( "", EventTileType.OCC, 1 ); //TODO: define this Event Tile
            gameTiles[44] = new EventTile( "Remember that Blue Light system that the campus tour guides talked so much about when" +
                " you were touring campus a few years ago? No? Well, you did remember them last night when you tried to use one and" +
                " found out the hard way that they don't actually work - Take out $1000 in loans to replace the contents of your " +
                "stolen backpack ", EventTileType.LOAN, 1000 ); 
            gameTiles[45] = new EventTile( "A friend of a friend has a couple of sour patch kids on the table. Feeling adventurous, " +
                "you take one when he's not looking. He notices one missing and has a surprised look on his face. You ask what's " +
                "the big deal. He tells you, \"It's gonna be a long eight hours, buddy\". Gain an OCC credit for writing the best " +
                "poem you have ever written.", EventTileType.OCC, 1 );
            gameTiles[46] = new EventTile("For the past 4.5 weeks, every time you see your housemate, they give you a new 30 minute " +
                "lecture on the Amway products that they are trying to sell. You tell them that you just can't take it anymore - " +
                "lose 1 friend ", EventTileType.FRIEND, -1 );
            gameTiles[47] = new EventTile( "", EventTileType.LOAN, 1 ); //TODO: define this Event Tile
            gameTiles[48] = new EventTile( "Your professor calls on you in class. You didn't even know they knew your name! You don't " +
                "go to office hours, you've never participated, and you sit in the back corner on your laptop the whole time. How " +
                "the hell did they figure out who you are? They ask you to go up in front of the class and explain your thoughts " +
                "on the current state of the union. You awkwardly walk towards the front of the class and say \"Well, I think the " +
                "current state is bad.\" Your professor asks why you think this and you immediately feel the zipper on your fanny " +
                "pack break open. YOUR SPAGHETTI IS FALLING ON THE FLOOR! You reach down and try to pick it up and put it back, " +
                "but like, it's spaghetti! The sauce is everywhere. Lose 1 OCC credit for making an absolute fool of yourself. " +
                "Again.", EventTileType.OCC, -1 );
            gameTiles[49] = new EventTile( "", EventTileType.FRIEND, 1 ); //TODO: define this Event Tile
            gameTiles[50] = new EventTile( "", EventTileType.LOAN, 1 ); //TODO: define this Event Tile
            gameTiles[51] = new StopTile( 2 );

            // Year 4
            gameTiles[52] = new EventTile( "It's super bowl sunday! Your friend invites you and your friends over and asks everyone " +
                "to bring different food and drinks, but it turns out only one friend brings food, so you're stuck with 3 pounds of " +
                "taco dip and 3 large bottles of \"silly juice\". Before the night is over, you've begun drinking an unsafe amount " +
                "of the juice! After waking up in the morning, you learn that on your way home you fell in mud, tripped up your " +
                "staircase, and tried to open your dorm room with your Giant Eagle advantage card. To make matters worse, the campus " +
                "police find you passed out in the hallway! Uh oh! You call your friend at 4:30am to pick you up from the hospital " +
                "even though he has to work at 7am. What a guy! Take out $5000 in loans to pay for the hospital bills, and to get " +
                "your friend some well deserved Chipotle.", EventTileType.LOAN, 5000 );
            gameTiles[53] = new EventTile( "", EventTileType.LOAN, 1 ); //TODO: define this Event Tile
            gameTiles[54] = new EventTile( "", EventTileType.OCC, 1 ); //TODO: define this Event Tile
            gameTiles[55] = new EventTile( "You find yourself implicated in a hazing investigation - lose 3 OCC credits", EventTileType.OCC, -3 );
            gameTiles[56] = new EventTile( "", EventTileType.FRIEND, 1 ); //TODO: define this Event Tile
            gameTiles[57] = new EventTile( "", EventTileType.FRIEND, 1 ); //TODO: define this Event Tile
            gameTiles[58] = new EventTile( "All of your friends signed leases without you last January, and you needed housing quick, " +
                "so you signed onto live with three people who you've never met before. The house is low quality, but livable for " +
                "the first month, but now it's October and the whole house is full of mice that continuoslly scurry through the " +
                "array of holes in your baseboards. You find out that you're allergic to the mice after having severe difficulty " +
                "breathing for three weeks and have to move out. Unfortunately, your landlord, or perhaps more appropriately " +
                "\"slumlord\", won't let you out of your lease. Take out $7000 in loans to pay for double housing for the remaining " +
                "8 months of your lease.", EventTileType.LOAN, 7000 ); 
            gameTiles[59] = new EventTile( "You and your two friends Drake and Josh decide to go to a house party. After a while, " +
                "you become very silly and find your way into the kitchen on a search for another beverage. Not thinking straight, " +
                "you find a gallon of soy sauce and start drinking it, thinking it is the drink you are looking for. Your friends " +
                "call an ambulance to take you to the ER for sodium poisoning. Take out $3000 dollars in loans to pay for your " +
                "hospital bills", EventTileType.LOAN, 3000 );
            gameTiles[60] = new EventTile( "You're a senior now, so you only took one house to pack all of your belongings to move in " +
                "for the semester. It turns out that the only utensils you remembered to pack were 6 pairs of chopsticks. Borrow " +
                "one fork and one spoon from the dining hall for the semester and gain one occ credit for your creativity", 
                EventTileType.OCC, 1 );
            gameTiles[61] = new EventTile( "", EventTileType.FRIEND, 1 ); //TODO: define this Event Tile
            gameTiles[62] = new EventTile( "", EventTileType.OCC, 1 ); //TODO: define this Event Tile
            gameTiles[63] = new EventTile( "", EventTileType.LOAN, 1 ); //TODO: define this Event Tile
        }

        public Tile getTileAt( uint position )
        {
            return ( position < gameTiles.Length ) ? gameTiles[position] : null;
        }

        // Note 1: does not call actOnPlayer
        // Note 2: if player is currently on a StopTile, returns the current tile
        // Note 3: if player reaches the end of the board, returns null
        public Tile movePlayer( Player p, uint numTiles )
        {
            uint numMoved = 0;
            for ( ; numMoved <= numTiles; numMoved++ )
            {
                if ( ( p.boardPosition + numMoved ) == gameTiles.Length || getTileAt( p.boardPosition + numMoved ).isStopTile() )
                    break;
            }
            p.boardPosition += numMoved;
            return p.boardPosition == gameTiles.Length ? null : getTileAt( p.boardPosition );
        }
    }


}