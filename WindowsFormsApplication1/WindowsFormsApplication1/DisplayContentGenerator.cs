using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class DisplayContentGenerator
    {
        private const int num_spaces = 65;
        private const int start_x = 14;
        private const int start_y = 80;
        private const int end_x = 130;
        private const int end_y = 576;
        private static int[] x_locs = { 119, 242, 358, 480, 601, 719, 843, 960, 1081, 1200, 1286,
                          1200, 1081, 960, 843, 719, 601, 480, 358, 242, 119, 31,
                          119, 242, 358, 480, 601, 719, 843, 960, 1081, 1200, 1286,
                          1200, 1081, 960, 843, 719, 601, 480, 358, 242, 119, 31,
                          119, 242, 358, 480, 601, 719, 843, 960, 1081, 1200, 1286,
                          1200, 1081, 960, 843, 719, 601, 480, 358, 242, 119 };
        private static int[] y_locs = { 80, 80, 80, 80, 80, 80, 80, 80, 80, 80, 127,
                          179, 179, 179, 179, 179, 179, 179, 179, 179, 179, 229,
                          278, 278, 278, 278, 278, 278, 278, 278, 278, 278, 332,
                          378, 378, 378, 378, 378, 378, 378, 378, 378, 378, 429,
                          479, 479, 479, 479, 479, 479, 479, 479, 479, 479, 531,
                          576, 576, 576, 576, 576, 576, 576, 576, 576, 576 };

        public static DisplayContent GenerateMenuContent(Menu menu, ref System.Drawing.Color color)
        {
            if (menu.State.Equals("Normal"))
                return GenerateNormalMenuContent(menu, ref color);
            else if (menu.State.Equals("Rules"))
                return GenerateRulesContent(menu, ref color);
            else if (menu.State.Equals("NameNumber"))
                return GenerateNameNumberContent(menu, ref color);
            else if (menu.State.Equals("CreatePlayer"))
                return GenerateCreatePlayerContent(menu, ref color);
            else if (menu.State.Equals("LoadGame"))
                return GenerateLoadGameContent();
            else
                return null;
        }


        public static DisplayContent GenerateGameContent(Game game, ref System.Drawing.Color color)
        {
            if (game.State.Equals("Normal"))
                return GenerateNormalGameContent(game, ref color);
            else if (game.State.Equals("UnitedStatesOfOK"))
                return GenerateUSOKContent(game, ref color);
            else if (game.State.Equals("ExamSpin"))
                return GenerateExamSpinContent(game, ref color);
            else if (game.State.Equals("ChoosePC"))
                return GenerateChoosePCContent(game, ref color);
            else if (game.State.Equals("DisplayResults"))
                return GenerateDisplayResultsContent();
            else
                return null;
        }

        //Private methods to make the shit above easier

        //MENU CONTENT
        private static DisplayContent GenerateNormalMenuContent(Menu menu, ref System.Drawing.Color color) {
            DisplayContent content = new DisplayContent();

            var button1 = new System.Windows.Forms.Button();
            var label1 = new System.Windows.Forms.Label();
            var button2 = new System.Windows.Forms.Button();
            var button3 = new System.Windows.Forms.Button();

            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(464, 175);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(335, 54);
            button1.TabIndex = 0;
            button1.Text = "Create Game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += menu.CreateGameButtonPressed;
            // 
            // label1
            // 
            //label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(168, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(966, 99);
            label1.TabIndex = 1;
            label1.Text = "Welcome to Trials of College, a coming of age tale of a game where \r\nyou can broa" +
    "den your world view with some of life\'s most \r\nacademic and hedonistic experienc" +
    "es!";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(464, 298);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(335, 54);
            button2.TabIndex = 2;
            button2.Text = "Load Game";
            button2.UseVisualStyleBackColor = true;
            button2.Click += menu.LoadGameButtonPressed;

            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(948, 219);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(292, 95);
            button3.TabIndex = 0;
            button3.Text = "What are the rules?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += menu.ViewRulesButtonPressed;
            

            content.AddControl(button1);
            content.AddControl(button2);
            content.AddControl(label1);
            content.AddControl(button3);

            color = System.Drawing.Color.Goldenrod;

            return content;
        }

        private static DisplayContent GenerateRulesContent(Menu menu, ref System.Drawing.Color color)
        {
            DisplayContent content = new DisplayContent();
            
            System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
            System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();

            //label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.LightGray;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(39, 39);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.MaximumSize = new System.Drawing.Size(640, 300);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(611, 56);
            label2.TabIndex = 3;
            label2.Text = "\r\nWELCOME TO THE RULES PAGE\r\ni mean it's real simple, you begin your journey towards the rest of your life\r\n" +
                "you know how CVS receipts are long as shit? you're working towards one of those except it costs $100,000.\r\n" +
                "To play, you begin by selecting your character name, major, and school choice.\r\n" +
                "The first player goes based on who has the lowest test score! You know who you are. Accept it.\r\n" +
                "";

            button1.BackColor = System.Drawing.Color.DarkSlateGray;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            button1.Location = new System.Drawing.Point(508, 301);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(142, 68);
            button1.TabIndex = 4;
            button1.Text = "Click To Continue";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(menu.CancelButtonPressed);

            color = System.Drawing.Color.Goldenrod;

            content.AddControl(button1);
            content.AddControl(label2);

            return content;         

            
        }

        private static DisplayContent GenerateNameNumberContent(Menu menu, ref System.Drawing.Color color)
        {
            DisplayContent content = new DisplayContent();
            color = System.Drawing.Color.Red;

            var button1 = new System.Windows.Forms.Button();
            var label1 = new System.Windows.Forms.Label();
            var textBox1 = new System.Windows.Forms.TextBox();
            var label2 = new System.Windows.Forms.Label();
            var button2 = new System.Windows.Forms.Button();
            var button3 = new System.Windows.Forms.Button();
            var button4 = new System.Windows.Forms.Button();
            var button5 = new System.Windows.Forms.Button();
            
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(161, 242);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(141, 43);
            button1.TabIndex = 0;
            button1.Text = "2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += menu.Number2Clicked;
            if(menu.NumPlayers == 2)
            {
                button1.BackColor = System.Drawing.Color.Lime;
                button1.UseVisualStyleBackColor = false;                
            }
            // 
            // label1
            // 
            //label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(93, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(465, 33);
            label1.TabIndex = 1;
            label1.Text = "What is the name of your game?";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(599, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(309, 40);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += menu.GameNameChanged;
            textBox1.Text = menu.GameName;
            // 
            // label2
            // 
            //label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(226, 163);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(587, 33);
            label2.TabIndex = 4;
            label2.Text = "How many players shall play your game?";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(343, 242);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(141, 43);
            button2.TabIndex = 5;
            button2.Text = "3";
            button2.UseVisualStyleBackColor = true;
            button2.Click += menu.Number3Clicked;
            if (menu.NumPlayers == 3)
            {
                button2.BackColor = System.Drawing.Color.Lime;
                button2.UseVisualStyleBackColor = false;
            }
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(523, 242);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(141, 43);
            button3.TabIndex = 6;
            button3.Text = "4";
            button3.UseVisualStyleBackColor = true;
            button3.Click += menu.Number4Clicked;
            if (menu.NumPlayers == 4)
            {
                button3.BackColor = System.Drawing.Color.Lime;
                button3.UseVisualStyleBackColor = false;
            }
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(706, 242);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(141, 43);
            button4.TabIndex = 7;
            button4.Text = "5";
            button4.UseVisualStyleBackColor = true;
            button4.Click += menu.Number5Clicked;
            if (menu.NumPlayers == 5)
            {
                button4.BackColor = System.Drawing.Color.Lime;
                button4.UseVisualStyleBackColor = false;
            }
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(403, 342);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(204, 77);
            button5.TabIndex = 8;
            button5.Text = "Next";
            button5.UseVisualStyleBackColor = true;
            button5.Click += menu.NameNumberNextButtonClicked;

            content.AddControl(button1);
            content.AddControl(button2);
            content.AddControl(button3);
            content.AddControl(button4);
            content.AddControl(button5);
            content.AddControl(label1);
            content.AddControl(label2);
            content.AddControl(textBox1);

            return content;
        }

        private static DisplayContent GenerateCreatePlayerContent(Menu menu, ref System.Drawing.Color color)
        {
            DisplayContent content = new DisplayContent();
            color = System.Drawing.Color.Red;

            var button1 = new System.Windows.Forms.Button();
            var label1 = new System.Windows.Forms.Label();
            var textBox1 = new System.Windows.Forms.TextBox();
            var label2 = new System.Windows.Forms.Label();
            var button5 = new System.Windows.Forms.Button();
            var label3 = new System.Windows.Forms.Label();
            var button2 = new System.Windows.Forms.Button();
            var button3 = new System.Windows.Forms.Button();
            var button4 = new System.Windows.Forms.Button();
            var button6 = new System.Windows.Forms.Button();
            var label4 = new System.Windows.Forms.Label();
            var button7 = new System.Windows.Forms.Button();
            var button8 = new System.Windows.Forms.Button();
            
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(139, 155);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(156, 48);
            button1.TabIndex = 0;
            button1.Text = "Cerulean";
            button1.UseVisualStyleBackColor = true;
            button1.Click += menu.CeruleanButtonClicked;
            //Check if button should be highlighted
            if (menu.PlayerColor.Equals("Cerulean"))
            {
                button1.BackColor = System.Drawing.Color.Lime;
                button1.UseVisualStyleBackColor = false;
            }
            // 
            // label1
            // 
            //label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 80);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(106, 33);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(152, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(309, 40);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += menu.PlayerNameBoxChanged;
            textBox1.Text = menu.PlayerName;
            // 
            // label2
            // 
            //label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 163);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 33);
            label2.TabIndex = 4;
            label2.Text = "Color:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(508, 350);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(204, 77);
            button5.TabIndex = 8;
            button5.Text = "Next Player";
            if(menu.CurrentPlayer == menu.NumPlayers)
            {
                button5.Text = "Begin the Game!";
            }
            button5.UseVisualStyleBackColor = true;
            button5.Click += menu.SubmitButtonClicked;
            // 
            // label3
            // 
            //label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(502, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(232, 33);
            label3.TabIndex = 9;
            label3.Text = "Create Player "+ menu.CurrentPlayer;
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(305, 155);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(165, 48);
            button2.TabIndex = 10;
            button2.Text = "Vermillion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += menu.VermillionButtonClicked;
            if (menu.PlayerColor.Equals("Vermillion"))
            {
                button2.BackColor = System.Drawing.Color.Lime;
                button2.UseVisualStyleBackColor = false;
            }
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(476, 155);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(156, 48);
            button3.TabIndex = 11;
            button3.Text = "Saffron";
            button3.UseVisualStyleBackColor = true;
            button3.Click += menu.SaffronButtonClicked;
            if (menu.PlayerColor.Equals("Saffron"))
            {
                button3.BackColor = System.Drawing.Color.Lime;
                button3.UseVisualStyleBackColor = false;
            }
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(647, 155);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(156, 48);
            button4.TabIndex = 12;
            button4.Text = "Viridian";
            button4.UseVisualStyleBackColor = true;
            button4.Click += menu.ViridianButtonClicked;
            if (menu.PlayerColor.Equals("Viridian"))
            {
                button4.BackColor = System.Drawing.Color.Lime;
                button4.UseVisualStyleBackColor = false;
            }
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(822, 155);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(156, 48);
            button6.TabIndex = 13;
            button6.Text = "Indigo";
            button6.UseVisualStyleBackColor = true;
            button6.Click += menu.IndigoButtonClicked;
            if (menu.PlayerColor.Equals("Indigo"))
            {
                button6.BackColor = System.Drawing.Color.Lime;
                button6.UseVisualStyleBackColor = false;
            }
            // 
            // label4
            // 
            //label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(16, 262);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(87, 33);
            label4.TabIndex = 14;
            label4.Text = "Path:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(139, 247);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(198, 48);
            button7.TabIndex = 15;
            button7.Text = "Four Year";
            button7.UseVisualStyleBackColor = true;
            button7.Click += menu.FourYearButtonClicked;
            if (!menu.PlayerPath)
            {
                button7.BackColor = System.Drawing.Color.Lime;
                button7.UseVisualStyleBackColor = false;
            }
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(403, 247);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(216, 48);
            button8.TabIndex = 16;
            button8.Text = "Community";
            button8.UseVisualStyleBackColor = true;
            button8.Click += menu.CommunityButtonClicked;
            if (menu.PlayerPath)
            {
                button8.BackColor = System.Drawing.Color.Lime;
                button8.UseVisualStyleBackColor = false;
            }

            content.AddControl(button1);
            content.AddControl(button2);
            content.AddControl(button3);
            content.AddControl(button4);
            content.AddControl(button5);
            content.AddControl(button6);
            content.AddControl(button7);
            content.AddControl(button8);
            content.AddControl(label1);
            content.AddControl(label2);
            content.AddControl(label3);
            content.AddControl(label4);
            content.AddControl(textBox1);

            return content;
        }

        private static DisplayContent GenerateLoadGameContent()
        {
            DisplayContent content = new DisplayContent();

            return content;
        }
        
        //GAME CONTENT
        private static DisplayContent GenerateNormalGameContent(Game game, ref System.Drawing.Color color)
        {
            DisplayContent content = new DisplayContent();
            
            System.Windows.Forms.PictureBox pictureBox1 = new System.Windows.Forms.PictureBox();
            System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();
            System.Windows.Forms.Button button2 = new System.Windows.Forms.Button();
            System.Windows.Forms.Button button3 = new System.Windows.Forms.Button();
            System.Windows.Forms.Button button4 = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();

            pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            try
            {
                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.game_board;
            }
            catch (Exception e)
            {
                pictureBox1.Image = null;
            }
            pictureBox1.Location = new System.Drawing.Point(14, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1355, 584);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;

            button1.BackColor = System.Drawing.Color.LightSkyBlue;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.Color.Black;
            button1.Location = new System.Drawing.Point(14, 9);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(121, 44);
            button1.TabIndex = 2;
            button1.Text = "View Rules";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(game.ViewRules);

            button2.BackColor = System.Drawing.Color.LightSkyBlue;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button2.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.ForeColor = System.Drawing.Color.Black;
            button2.Location = new System.Drawing.Point(141, 9);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(122, 44);
            button2.TabIndex = 3;
            button2.Text = "View Stats";
            button2.UseVisualStyleBackColor = false;
            button2.Click += new System.EventHandler(game.ViewStats);

            button3.BackColor = System.Drawing.Color.LightSkyBlue;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button3.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button3.ForeColor = System.Drawing.Color.Black;
            button3.Location = new System.Drawing.Point(269, 9);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(126, 44);
            button3.TabIndex = 4;
            button3.Text = "Save Game";
            button3.UseVisualStyleBackColor = false;
            button3.Click += new System.EventHandler(game.SaveGame);

            button4.BackColor = System.Drawing.Color.Firebrick;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button4.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button4.ForeColor = System.Drawing.Color.Black;
            button4.Location = new System.Drawing.Point(557, 671);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(288, 101);
            button4.TabIndex = 5;
            button4.Text = game.CurrentPlayer().getPlayerName();
            button4.Text += ", it's your turn - Spin!";
            button4.UseVisualStyleBackColor = false;
            button4.Click += new System.EventHandler(game.TakeTurn);

            for (int i = 0; i < game.numPlayers; i++)
            {
                Player p = game.players[i];
                System.Windows.Forms.PictureBox gamePiece = new System.Windows.Forms.PictureBox();
                ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
                gamePiece.BackColor = System.Drawing.Color.White;
                gamePiece.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                if(p.playerColor == "Cerulean")
                {
                    gamePiece.Image = global::WindowsFormsApplication1.Properties.Resources.blue_wings;
                }
                else if(p.playerColor == "Veridian")
                {
                    gamePiece.Image = global::WindowsFormsApplication1.Properties.Resources.green_dino;
                }
                else if(p.playerColor == "Saffron")
                {
                    gamePiece.Image = global::WindowsFormsApplication1.Properties.Resources.yellow_pika;
                }
                else if(p.playerColor == "Vermillion")
                {
                    gamePiece.Image = global::WindowsFormsApplication1.Properties.Resources.red_minnie;
                }
                else if(p.playerColor == "Indigo")
                {
                    gamePiece.Image = global::WindowsFormsApplication1.Properties.Resources.purple_cthulhu;
                }
                else
                {
                    gamePiece.Image = global::WindowsFormsApplication1.Properties.Resources.green_dino;
                }
                int x_loc = p.getBoardPosition() == -1 ? start_x : p.getBoardPosition() >= num_spaces ? end_x : x_locs[p.getBoardPosition()];
                int y_loc = p.getBoardPosition() == -1 ? start_y : p.getBoardPosition() >= num_spaces ? end_y : y_locs[p.getBoardPosition()];
                gamePiece.Location = new System.Drawing.Point(x_loc, y_loc);
                gamePiece.Name = "player" + i;
                gamePiece.Size = new System.Drawing.Size(74, 68);
                gamePiece.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                gamePiece.TabIndex = 7 + i;
                gamePiece.TabStop = false;
                ((System.ComponentModel.ISupportInitialize)(gamePiece)).EndInit();
                content.AddControl(gamePiece);
            }

            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();

            color = System.Drawing.Color.MidnightBlue;
            content.AddControl(button4);
            content.AddControl(button3);
            content.AddControl(button2);
            content.AddControl(button1);
            content.AddControl(pictureBox1);          

            return content;
        }

        private static DisplayContent GenerateUSOKContent(Game game, ref System.Drawing.Color color)
        {
            DisplayContent content = new DisplayContent();

            System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
            System.Windows.Forms.Button button4 = new System.Windows.Forms.Button();

            button4.BackColor = System.Drawing.Color.MidnightBlue;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button4.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button4.ForeColor = System.Drawing.Color.LightGray;
            button4.Location = new System.Drawing.Point(532, 599);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(288, 101);
            button4.TabIndex = 5;
            button4.Text = "Got it!";
            button4.UseVisualStyleBackColor = false;
            button4.Click += new System.EventHandler(game.BackToNormal);

            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Moccasin;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(227, 65);
            label1.MaximumSize = new System.Drawing.Size(900, 500);
            label1.MinimumSize = new System.Drawing.Size(900, 500);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(900, 500);
            label1.TabIndex = 6;
            label1.Text = game.UsokText;

            color = System.Drawing.Color.Orange;

            content.AddControl(button4);
            content.AddControl(label1);

            return content;
        }

        private static DisplayContent GenerateExamSpinContent(Game game, ref System.Drawing.Color color)
        {
            DisplayContent content = new DisplayContent();

            System.Windows.Forms.PictureBox pictureBox1 = new System.Windows.Forms.PictureBox();
            System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();
            System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();

            if (!game.CurrentTile().isStopTile())
                return null;

            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.exam_time;
            pictureBox1.Location = new System.Drawing.Point(44, 44);
            pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(319, 336);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;

            button1.BackColor = System.Drawing.Color.MidnightBlue;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.Color.Snow;
            button1.Location = new System.Drawing.Point(443, 315);
            button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(545, 65);
            button1.TabIndex = 1;
            button1.Text = "Spin For Exam Score!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(((StopTile)game.CurrentTile()).GetExamSpin);

            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.IndianRed;
            label2.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(412, 44);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.MaximumSize = new System.Drawing.Size(640, 300);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(609, 54);
            label2.TabIndex = 3;
            label2.Text = "You spun a ";
            label2.Text += game.currSpin;
            label2.Text += ": Stop studying! You\'ve officially reached the end of Year ";
            label2.Text += ((StopTile)game.CurrentTile()).getType() == CharacteristicType.MAJOR ? "1" : ((StopTile)game.CurrentTile()).getType() == CharacteristicType.CLUB ? "2" : "3";
            label2.Text += ".  Spin at least a 3 in order to pass your final exams and continue.";
            
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();

            color = System.Drawing.Color.DarkRed;

            content.AddControl(label2);
            content.AddControl(button1);
            content.AddControl(pictureBox1);

            return content;
        }

        private static DisplayContent GenerateChoosePCContent(Game game, ref System.Drawing.Color color)
        {
            DisplayContent content = new DisplayContent();

            System.Windows.Forms.Button buttonA = new System.Windows.Forms.Button();
            System.Windows.Forms.Button buttonB = new System.Windows.Forms.Button();
            System.Windows.Forms.Button buttonC = new System.Windows.Forms.Button();
            System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
            System.Windows.Forms.PictureBox pictureBox1 = new System.Windows.Forms.PictureBox();

            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();

            if (!game.CurrentTile().isStopTile())
                return null;

            PlayerCharacteristic[] list = ((StopTile)game.CurrentTile()).options;

            buttonA.BackColor = System.Drawing.Color.Yellow;
            buttonA.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonA.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonA.ForeColor = System.Drawing.Color.MidnightBlue;
            buttonA.Location = new System.Drawing.Point(76, 300);
            buttonA.Name = "buttonA";
            buttonA.Size = new System.Drawing.Size(117, 47);
            buttonA.TabIndex = 0;
            buttonA.Text = "Choice A";
            buttonA.UseVisualStyleBackColor = false;
            buttonA.Click += new System.EventHandler(((StopTile)game.CurrentTile()).SetChosenCharacteristicA);

            buttonB.BackColor = System.Drawing.Color.Yellow;
            buttonB.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonB.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonB.ForeColor = System.Drawing.Color.MidnightBlue;
            buttonB.Location = new System.Drawing.Point(275, 300);
            buttonB.Name = "buttonB";
            buttonB.Size = new System.Drawing.Size(117, 47);
            buttonB.TabIndex = 1;
            buttonB.Text = "Choice B";
            buttonB.UseVisualStyleBackColor = false;
            buttonB.Click += new System.EventHandler(((StopTile)game.CurrentTile()).SetChosenCharacteristicB);

            if (list.Length > 2)
            {
                buttonC.BackColor = System.Drawing.Color.Yellow;
                buttonC.Cursor = System.Windows.Forms.Cursors.Hand;
                buttonC.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                buttonC.ForeColor = System.Drawing.Color.MidnightBlue;
                buttonC.Location = new System.Drawing.Point(461, 300);
                buttonC.Name = "buttonC";
                buttonC.Size = new System.Drawing.Size(117, 47);
                buttonC.TabIndex = 2;
                buttonC.Text = "Choice C";
                buttonC.UseVisualStyleBackColor = false;
                buttonC.Click += new System.EventHandler(((StopTile)game.CurrentTile()).SetChosenCharacteristicC);
            }

            int spinVal = ((StopTile)game.CurrentTile()).examSpinVal;
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.LightYellow;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(10, 34);
            label1.MaximumSize = new System.Drawing.Size(500, 250);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(500, 48);
            label1.TabIndex = 3;
            label1.Text = "Congrats, " + game.CurrentPlayer().getPlayerName() + "! You scored a ";
            label1.Text += spinVal + " out of 6 and passed your exams ";
            label1.Text +=  spinVal == 3 ? "(barely)." : spinVal == 4 ? "with an acceptable amount of mediocrity." : 
                spinVal == 5 ? " with flying colors! (your parents are proud)" : " with a perfect score (whatanerd).";
            label1.Text += "Now that you've officially finished another year of school,  it's time to choose a ";
            label1.Text += list[0].getType() == CharacteristicType.MAJOR ? "Major" : list[0].getType() == CharacteristicType.CLUB ? "Club" : "Capstone Experience";
            label1.Text += "! Please pick from the following options:\nChoice A) ";
            label1.Text += list[0].getText();
            label1.Text += "\nChoice B) ";
            label1.Text += list[1].getText();
            if (list.Length > 2)
            {
                label1.Text += "\nChoice C) ";
                label1.Text += list[2].getText();
            }
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.ErrorImage = null;
            try
            {
                pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.confused;
            }
            catch( Exception e )
            {
                pictureBox1.Image = null;
            }
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(516, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(149, 146);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;

            color = System.Drawing.SystemColors.MenuHighlight;

            content.AddControl(pictureBox1);
            content.AddControl(label1);
            if (list.Length > 2)
                content.AddControl(buttonC);
            content.AddControl(buttonB);
            content.AddControl(buttonA);

            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();

            return content;
        }

        private static DisplayContent GenerateDisplayResultsContent()
        {
            DisplayContent content = new DisplayContent();

            return content;
        }
    }
}
