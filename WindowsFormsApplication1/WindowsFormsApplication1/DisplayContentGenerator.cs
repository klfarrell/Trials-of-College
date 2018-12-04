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
                return GenerateDisplayResultsContent(game, ref color);
            else if (game.State.Equals("Stats"))
                return GenerateStatsDisplayContent(game, ref color);
            else
                return null;
        }

        //Private methods to make the shit above easier

        //MENU CONTENT
        private static DisplayContent GenerateNormalMenuContent(Menu menu, ref System.Drawing.Color color) {

            DisplayContent content = new DisplayContent();

            var pictureBox4 = new System.Windows.Forms.PictureBox();
            var pictureBox3 = new System.Windows.Forms.PictureBox();
            var pictureBox2 = new System.Windows.Forms.PictureBox();
            var pictureBox1 = new System.Windows.Forms.PictureBox();
            var label1 = new System.Windows.Forms.Label();
            var button1 = new System.Windows.Forms.Button();
            var button2 = new System.Windows.Forms.Button();
            var button3 = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();

            pictureBox4.Image = global::WindowsFormsApplication1.Properties.Resources.dorm_room;
            pictureBox4.Location = new System.Drawing.Point(2, 169);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(295, 221);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;

            pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.dining_hall;
            pictureBox3.Location = new System.Drawing.Point(2, 385);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(295, 203);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;

            pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.college_campus;
            pictureBox2.Location = new System.Drawing.Point(2, 586);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(295, 204);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;

            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.research;
            pictureBox1.Location = new System.Drawing.Point(2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(295, 170);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;

            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(353, 43);
            label1.MaximumSize = new System.Drawing.Size(1000, 300);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(975, 240);
            label1.TabIndex = 4;
            label1.Text = "Welcome to Trials of College, a coming of age tale of a game where you can broaden your world view with " +
                "some of life\'s most academic and hedonistic experiences!";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;

            button1.BackColor = System.Drawing.Color.MidnightBlue;
            button1.ForeColor = System.Drawing.Color.LightGray;
            button1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.Location = new System.Drawing.Point(360, 513);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(283, 150);
            button1.TabIndex = 5;
            button1.Text = "Create Game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += menu.CreateGameButtonPressed;

            button2.BackColor = System.Drawing.Color.MidnightBlue;
            button2.ForeColor = System.Drawing.Color.LightGray;
            button2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.Location = new System.Drawing.Point(1038, 513);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(283, 150);
            button2.TabIndex = 6;
            button2.Text = "Read Rules";
            button2.UseVisualStyleBackColor = false;
            button2.Click += menu.ViewRulesButtonPressed;

            button3.BackColor = System.Drawing.Color.MidnightBlue;
            button3.ForeColor = System.Drawing.Color.LightGray;
            button3.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button3.Location = new System.Drawing.Point(703, 513);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(283, 150);
            button3.TabIndex = 7;
            button3.Text = "Load Game";
            button3.UseVisualStyleBackColor = false;
            button3.Click += menu.LoadGameButtonPressed;

            ((System.ComponentModel.ISupportInitialize)(pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();

            color = System.Drawing.Color.MediumPurple;

            content.AddControl(button1);
            content.AddControl(button2);
            content.AddControl(label1);
            content.AddControl(button3);
            content.AddControl(pictureBox4);
            content.AddControl(pictureBox3);
            content.AddControl(pictureBox2);
            content.AddControl(pictureBox1);

            return content;
        }

        private static DisplayContent GenerateRulesContent(Menu menu, ref System.Drawing.Color color)
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
            button4.Text = "Return";
            button4.UseVisualStyleBackColor = false;
            button4.Click += new System.EventHandler(menu.CancelButtonPressed);

            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.LightGray;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(227, 65);
            label1.MaximumSize = new System.Drawing.Size(900, 500);
            label1.MinimumSize = new System.Drawing.Size(900, 500);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(900, 500);
            label1.TabIndex = 6;
            label1.Text = Game.rules;
            

            color = System.Drawing.Color.MediumPurple;

            content.AddControl(button4);
            content.AddControl(label1);

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
            var button6 = new System.Windows.Forms.Button();
 
            button1.BackColor = System.Drawing.Color.MidnightBlue;
            button1.ForeColor = System.Drawing.Color.Gray;
            button1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.Location = new System.Drawing.Point(371, 364);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(137, 79);
            button1.TabIndex = 0;
            button1.Text = "2";
            button1.UseVisualStyleBackColor = false;
            button1.Click += menu.Number2Clicked;
            if(menu.NumPlayers == 2)
            {
                button1.BackColor = System.Drawing.Color.Yellow;
                button1.UseVisualStyleBackColor = false;                
            }

            button2.BackColor = System.Drawing.Color.MidnightBlue;
            button2.ForeColor = System.Drawing.Color.Gray;
            button2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.Location = new System.Drawing.Point(537, 364);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(137, 79);
            button2.TabIndex = 5;
            button2.Text = "3";
            button2.UseVisualStyleBackColor = false;
            button2.Click += menu.Number3Clicked;
            if (menu.NumPlayers == 3)
            {
                button2.BackColor = System.Drawing.Color.Yellow;
                button2.UseVisualStyleBackColor = false;
            }

            button3.BackColor = System.Drawing.Color.MidnightBlue;
            button3.ForeColor = System.Drawing.Color.Gray;
            button3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button3.Location = new System.Drawing.Point(703, 364);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(137, 79);
            button3.TabIndex = 6;
            button3.Text = "4";
            button3.UseVisualStyleBackColor = false;
            button3.Click += menu.Number4Clicked;
            if (menu.NumPlayers == 4)
            {
                button3.BackColor = System.Drawing.Color.Yellow;
                button3.UseVisualStyleBackColor = false;
            }

            button4.BackColor = System.Drawing.Color.MidnightBlue;
            button4.ForeColor = System.Drawing.Color.Gray;
            button4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button4.Location = new System.Drawing.Point(867, 364);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(137, 79);
            button4.TabIndex = 7;
            button4.Text = "5";
            button4.UseVisualStyleBackColor = false;
            button4.Click += menu.Number5Clicked;
            if (menu.NumPlayers == 5)
            {
                button4.BackColor = System.Drawing.Color.Yellow;
                button4.UseVisualStyleBackColor = false;
            }

            button5.BackColor = System.Drawing.Color.MidnightBlue;
            button5.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button5.ForeColor = System.Drawing.Color.LightGray;
            button5.Location = new System.Drawing.Point(703, 613);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(270, 130);
            button5.TabIndex = 8;
            button5.Text = "Next";
            button5.UseVisualStyleBackColor = false;
            button5.Click += menu.NameNumberNextButtonClicked;

            button6.BackColor = System.Drawing.Color.MidnightBlue;
            button6.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button6.ForeColor = System.Drawing.Color.LightGray;
            button6.Location = new System.Drawing.Point(404, 613);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(270, 130);
            button6.TabIndex = 9;
            button6.Text = "Cancel";
            button6.UseVisualStyleBackColor = false;
            button6.Click += menu.CancelButtonPressed;

            label1.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(383, 81);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(604, 62);
            label1.TabIndex = 1;
            label1.Text = "What is the name of your game?";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            textBox1.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox1.Location = new System.Drawing.Point(537, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(309, 37);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += menu.GameNameChanged;
            textBox1.Text = menu.GameName;

            label2.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(354, 269);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(667, 60);
            label2.TabIndex = 4;
            label2.Text = "How many players shall play your game?";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            color = System.Drawing.Color.MediumPurple;

            content.AddControl(button1);
            content.AddControl(button2);
            content.AddControl(button3);
            content.AddControl(button4);
            content.AddControl(button5);
            content.AddControl(button6);
            content.AddControl(label1);
            content.AddControl(label2);
            content.AddControl(textBox1);

            return content;
        }

        private static DisplayContent GenerateCreatePlayerContent(Menu menu, ref System.Drawing.Color color)
        {
            DisplayContent content = new DisplayContent();
            color = System.Drawing.Color.MediumPurple;

            var button1 = new System.Windows.Forms.Button();
            var button2 = new System.Windows.Forms.Button();
            var button3 = new System.Windows.Forms.Button();
            var button4 = new System.Windows.Forms.Button();
            var button5 = new System.Windows.Forms.Button();
            var button6 = new System.Windows.Forms.Button();      
            var button7 = new System.Windows.Forms.Button();
            var button8 = new System.Windows.Forms.Button();
            var button9 = new System.Windows.Forms.Button();
            var label1 = new System.Windows.Forms.Label();
            var label2 = new System.Windows.Forms.Label();           
            var label3 = new System.Windows.Forms.Label();
            var label4 = new System.Windows.Forms.Label();
            var textBox1 = new System.Windows.Forms.TextBox();

            label1.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(382, 156);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(135, 62);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            label2.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(248, 266);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(120, 60);
            label2.TabIndex = 4;
            label2.Text = "Color:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            label3.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(354, 35);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(667, 60);
            label3.TabIndex = 10;
            label3.Text = "Create Player " + menu.CurrentPlayer;
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            label4.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(367, 402);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(120, 60);
            label4.TabIndex = 12;
            label4.Text = "Path:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            textBox1.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox1.Location = new System.Drawing.Point(537, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(309, 37);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += menu.PlayerNameBoxChanged;
            textBox1.Text = menu.PlayerName;

            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(77)))));
            button1.ForeColor = System.Drawing.Color.Gray;
            button1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.Location = new System.Drawing.Point(755, 265);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(121, 58);
            button1.TabIndex = 0;
            button1.Text = "Cerulean";
            button1.UseVisualStyleBackColor = false;
            button1.Click += menu.CeruleanButtonClicked;
            if (menu.PlayerColor.Equals("Cerulean"))
            {
                button1.BackColor = System.Drawing.Color.Yellow;
                button1.UseVisualStyleBackColor = false;
            }

            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(9)))), ((int)(((byte)(1)))));
            button2.ForeColor = System.Drawing.Color.Gray;
            button2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button2.Location = new System.Drawing.Point(374, 267);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(121, 58);
            button2.TabIndex = 5;
            button2.Text = "Vermillon";
            button2.UseVisualStyleBackColor = false;
            button2.Click += menu.VermillionButtonClicked;
            if (menu.PlayerColor.Equals("Vermillion"))
            {
                button2.BackColor = System.Drawing.Color.Yellow;
                button2.UseVisualStyleBackColor = false;
            }

            button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(1)))));
            button3.ForeColor = System.Drawing.Color.Gray;
            button3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button3.Location = new System.Drawing.Point(501, 265);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(121, 58);
            button3.TabIndex = 6;
            button3.Text = "Saffron";
            button3.UseVisualStyleBackColor = false;
            button3.Click += menu.SaffronButtonClicked;
            if (menu.PlayerColor.Equals("Saffron"))
            {
                button3.BackColor = System.Drawing.Color.Yellow;
                button3.UseVisualStyleBackColor = false;
            }

            button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(57)))), ((int)(((byte)(0)))));
            button4.ForeColor = System.Drawing.Color.Gray;
            button4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button4.Location = new System.Drawing.Point(628, 265);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(121, 58);
            button4.TabIndex = 7;
            button4.Text = "Viridian";
            button4.UseVisualStyleBackColor = false;
            button4.Click += menu.ViridianButtonClicked;
            if (menu.PlayerColor.Equals("Viridian"))
            {
                button4.BackColor = System.Drawing.Color.Yellow;
                button4.UseVisualStyleBackColor = false;
            }

            button5.BackColor = System.Drawing.Color.MidnightBlue;
            button5.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button5.ForeColor = System.Drawing.Color.LightGray;
            button5.Location = new System.Drawing.Point(703, 613);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(270, 130);
            button5.TabIndex = 8;
            button5.Text = menu.CurrentPlayer == menu.NumPlayers ? "Begin the Game!" : "Next Player";
            button5.UseVisualStyleBackColor = false;
            button5.Click += menu.SubmitButtonClicked;

            button6.BackColor = System.Drawing.Color.MidnightBlue;
            button6.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button6.ForeColor = System.Drawing.Color.LightGray;
            button6.Location = new System.Drawing.Point(404, 613);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(270, 130);
            button6.TabIndex = 9;
            button6.Text = "Cancel";
            button6.UseVisualStyleBackColor = false;
            button6.Click += menu.CancelButtonPressed;

            button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(11)))), ((int)(((byte)(60)))));
            button7.ForeColor = System.Drawing.Color.Gray;
            button7.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button7.Location = new System.Drawing.Point(882, 265);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(121, 58);
            button7.TabIndex = 11;
            button7.Text = "Indigo";
            button7.UseVisualStyleBackColor = false;
            button7.Click += menu.IndigoButtonClicked;
            if (menu.PlayerColor.Equals("Indigo"))
            {
                button7.BackColor = System.Drawing.Color.Yellow;
                button7.UseVisualStyleBackColor = false;
            }

            button8.BackColor = System.Drawing.Color.MidnightBlue;
            button8.ForeColor = System.Drawing.Color.Gray;
            button8.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button8.Location = new System.Drawing.Point(502, 393);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(172, 79);
            button8.TabIndex = 13;
            button8.Text = "4-Year College";
            button8.UseVisualStyleBackColor = false;
            button8.Click += menu.FourYearButtonClicked;
            if (!menu.PlayerPath)
            {
                button8.BackColor = System.Drawing.Color.Yellow;
                button8.UseVisualStyleBackColor = false;
            }

            button9.BackColor = System.Drawing.Color.MidnightBlue;
            button9.ForeColor = System.Drawing.Color.Gray;
            button9.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button9.Location = new System.Drawing.Point(703, 393);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(172, 79);
            button9.TabIndex = 14;
            button9.Text = "Community College";
            button9.UseVisualStyleBackColor = false;
            button9.Click += menu.CommunityButtonClicked;
            if (menu.PlayerPath)
            {
                button9.BackColor = System.Drawing.Color.Yellow;
                button9.UseVisualStyleBackColor = false;
            }

            content.AddControl(button1);
            content.AddControl(button2);
            content.AddControl(button3);
            content.AddControl(button4);
            content.AddControl(button5);
            content.AddControl(button6);
            content.AddControl(button7);
            content.AddControl(button8);
            content.AddControl(button9);
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
            System.Windows.Forms.Button button5 = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();

            pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.game_board;
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

            button5.BackColor = System.Drawing.Color.LightSkyBlue;
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button5.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button5.ForeColor = System.Drawing.Color.Black;
            button5.Location = new System.Drawing.Point(400, 9);
            button5.Name = "button3";
            button5.Size = new System.Drawing.Size(128, 44);
            button5.TabIndex = 4;
            button5.Text = "Main Menu";
            button5.UseVisualStyleBackColor = false;
            button5.Click += new System.EventHandler(game.GoToMainMenu);

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
                gamePiece.Image = p.playerColor == "Cerulean" ? global::WindowsFormsApplication1.Properties.Resources.blue_wings :
                    p.playerColor == "Veridian" ? global::WindowsFormsApplication1.Properties.Resources.green_dino : 
                    p.playerColor == "Saffron" ? global::WindowsFormsApplication1.Properties.Resources.yellow_pika : 
                    p.playerColor == "Vermillion" ? global::WindowsFormsApplication1.Properties.Resources.red_minnie : 
                    p.playerColor == "Indigo" ? global::WindowsFormsApplication1.Properties.Resources.purple_cthulhu : 
                    global::WindowsFormsApplication1.Properties.Resources.green_dino;
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
            content.AddControl(button5);
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
            label1.BackColor = game._usOKLightColor;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Font = new System.Drawing.Font("Ink Free", game._usOKDarkColor == System.Drawing.Color.MediumPurple ? 18F : 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(77, 65);
            label1.MaximumSize = new System.Drawing.Size(1200, 500);
            label1.MinimumSize = new System.Drawing.Size(1200, 500);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1200, 500);
            label1.TabIndex = 6;
            label1.Text = game.UsokText;

            color = game._usOKDarkColor;

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
            pictureBox1.Location = new System.Drawing.Point(64, 44);
            pictureBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(519, 536);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;

            button1.BackColor = System.Drawing.Color.MidnightBlue;
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button1.ForeColor = System.Drawing.Color.Snow;
            button1.Location = new System.Drawing.Point(663, 415);
            button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(545, 165);
            button1.TabIndex = 1;
            button1.Text = "Spin For Exam Score!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(((StopTile)game.CurrentTile()).GetExamSpin);

            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.IndianRed;
            label2.Font = new System.Drawing.Font("Ink Free", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(632, 44);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.MaximumSize = new System.Drawing.Size(640, 300);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(609, 150);
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
            System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
            System.Windows.Forms.PictureBox pictureBox1 = new System.Windows.Forms.PictureBox();

            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();

            if (!game.CurrentTile().isStopTile())
                return null;

            PlayerCharacteristic[] list = ((StopTile)game.CurrentTile()).options;

            buttonA.BackColor = System.Drawing.Color.MidnightBlue;
            buttonA.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonA.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonA.ForeColor = System.Drawing.Color.LightGray;
            buttonA.Location = new System.Drawing.Point(321, 603);
            buttonA.Name = "buttonA";
            buttonA.Size = new System.Drawing.Size(185, 79);
            buttonA.TabIndex = 0;
            buttonA.Text = "Choice A";
            buttonA.UseVisualStyleBackColor = false;
            buttonA.Click += new System.EventHandler(((StopTile)game.CurrentTile()).SetChosenCharacteristicA);

            buttonB.BackColor = System.Drawing.Color.MidnightBlue;
            buttonB.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonB.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonB.ForeColor = System.Drawing.Color.LightGray;
            buttonB.Location = new System.Drawing.Point(617, 603);
            buttonB.Name = "buttonB";
            buttonB.Size = new System.Drawing.Size(185, 79);
            buttonB.TabIndex = 5;
            buttonB.Text = "Choice B";
            buttonB.UseVisualStyleBackColor = false;
            buttonB.Click += new System.EventHandler(((StopTile)game.CurrentTile()).SetChosenCharacteristicB);

            if (list.Length > 2)
            {
                buttonC.BackColor = System.Drawing.Color.MidnightBlue;
                buttonC.Cursor = System.Windows.Forms.Cursors.Hand;
                buttonC.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                buttonC.ForeColor = System.Drawing.Color.LightGray;
                buttonC.Location = new System.Drawing.Point(904, 603);
                buttonC.Name = "buttonC";
                buttonC.Size = new System.Drawing.Size(185, 79);
                buttonC.TabIndex = 6;
                buttonC.Text = "Choice C";
                buttonC.UseVisualStyleBackColor = false;
                buttonC.Click += new System.EventHandler(((StopTile)game.CurrentTile()).SetChosenCharacteristicC);
            }

            int spinVal = ((StopTile)game.CurrentTile()).examSpinVal;

            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.LightYellow;
            label1.Font = new System.Drawing.Font("Ink Free", 20F);
            label1.Location = new System.Drawing.Point(238, 65);
            label1.MaximumSize = new System.Drawing.Size(625, 250);
            label1.MinimumSize = new System.Drawing.Size(625, 250);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(625, 250);
            label1.TabIndex = 3;
            label1.Text = "Congrats, " + game.CurrentPlayer().getPlayerName() + "! You scored a ";
            label1.Text += spinVal + " out of 6 and passed your exams ";
            label1.Text += spinVal == 3 ? "(barely)." : spinVal == 4 ? "with an acceptable amount of mediocrity." :
                spinVal == 5 ? " with flying colors! (your parents are proud)." : " with a perfect score (whatanerd).";
            label1.Text += " Take out ";
            label1.Text += game.CurrentPlayer().isCommunityCollege ? "$7000" : "$10,000";
            label1.Text += " in loans to cover tuition for next year, fun stuff! Also, ";
            label1.Text += "now that you've officially finished another year of school,  it's time to choose a ";
            label1.Text += list[0].getType() == CharacteristicType.MAJOR ? "Major" : list[0].getType() == CharacteristicType.CLUB ? "Club" : "Capstone Experience";
            label1.Text += "! Please pick from the following options:";

            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.LightYellow;
            label2.Font = new System.Drawing.Font("Ink Free", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(238, 275);
            label2.MaximumSize = new System.Drawing.Size(625, 300);
            label2.MinimumSize = new System.Drawing.Size(625, 300);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(625, 250);
            label2.TabIndex = 7;
            label2.Text = "\nChoice A) ";
            label2.Text += list[0].getText();
            label2.Text += "\nChoice B) ";
            label2.Text += list[1].getText();
            if (list.Length > 2)
            {
                label2.Text += "\nChoice C) ";
                label2.Text += list[2].getText();
            }

            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.confused;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(913, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(270, 290);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;

            color = System.Drawing.Color.SpringGreen;

            content.AddControl(pictureBox1);
            content.AddControl(label1);
            content.AddControl(label2);
            if (list.Length > 2)
                content.AddControl(buttonC);
            content.AddControl(buttonB);
            content.AddControl(buttonA);

            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();

            return content;
        }

        private static DisplayContent GenerateStatsDisplayContent(Game game, ref System.Drawing.Color color)
        {
            DisplayContent content = new DisplayContent();

            System.Windows.Forms.Label[] playerBoxes = new System.Windows.Forms.Label[game.numPlayers];
            System.Windows.Forms.PictureBox[] playerPics = new System.Windows.Forms.PictureBox[game.numPlayers];
            var title = new System.Windows.Forms.Label();
            var ok = new System.Windows.Forms.Button();

            for (int idx = 0; idx < game.numPlayers; idx++)
            {
                playerBoxes[idx] = new System.Windows.Forms.Label();
                playerBoxes[idx].BackColor = System.Drawing.Color.Plum;
                playerBoxes[idx].Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                playerBoxes[idx].ForeColor = System.Drawing.Color.Black;
                playerBoxes[idx].Name = "label" + idx;
                playerBoxes[idx].Size = new System.Drawing.Size(378, 280);
                playerBoxes[idx].MinimumSize = new System.Drawing.Size(378, 280);
                playerBoxes[idx].MaximumSize = new System.Drawing.Size(378, 280);

                int x = idx == 0 ? 107 : idx == 1 ? 533 : idx == 2 ? 956 : idx == 3 ? 303 : 748;
                int y = idx < 3 ? 95 : 380;
                playerBoxes[idx].Location = new System.Drawing.Point(x, y);

                playerBoxes[idx].Text = "Name: ";
                playerBoxes[idx].Text += game.players[idx].getPlayerName();
                playerBoxes[idx].Text += "\r\nLoans taken: $";
                playerBoxes[idx].Text += game.players[idx].getLoans();
                playerBoxes[idx].Text += "\r\nNumber of Friends: ";
                playerBoxes[idx].Text += game.players[idx].getFriends();
                playerBoxes[idx].Text += "\r\nNumber of Credits: ";
                playerBoxes[idx].Text += game.players[idx].getCredits();
                playerBoxes[idx].Text += "\r\nBoard Completion: ";
                playerBoxes[idx].Text += game.players[idx].getBoardPosition() + 1;
                playerBoxes[idx].Text += "/64\r\nSchool: ";
                playerBoxes[idx].Text += game.players[idx].isCommunityCollege ? "Community College" : "4-Year College";
                playerBoxes[idx].Text += "\r\nYear in School: ";
                playerBoxes[idx].Text += game.players[idx].getBoardPosition() < 23 ? "Freshman" :
                    game.players[idx].getBoardPosition() < 38 ? "Sophomore" :
                    game.players[idx].getBoardPosition() < 52 ? "Junior" :
                    game.players[idx].getBoardPosition() < 64 ? "Senior" : "Graduated";
                playerBoxes[idx].Text += "\r\nMajor: ";
                playerBoxes[idx].Text += game.players[idx].major == null ? "TBD" : game.players[idx].major.getText();
                playerBoxes[idx].Text += "\r\nClub: ";
                playerBoxes[idx].Text += game.players[idx].club == null ? "TBD" : game.players[idx].club.getText();
                playerBoxes[idx].Text += "\r\nCapstone: ";
                playerBoxes[idx].Text += game.players[idx].capstone == null ? "TBD" : game.players[idx].capstone.getText();

                playerPics[idx] = new System.Windows.Forms.PictureBox();
                ((System.ComponentModel.ISupportInitialize)(playerPics[idx])).BeginInit();
                playerPics[idx].Image = game.players[idx].playerColor == "Cerulean" ? global::WindowsFormsApplication1.Properties.Resources.blue_wings :
                    game.players[idx].playerColor == "Veridian" ? global::WindowsFormsApplication1.Properties.Resources.green_dino :
                    game.players[idx].playerColor == "Saffron" ? global::WindowsFormsApplication1.Properties.Resources.yellow_pika :
                    game.players[idx].playerColor == "Vermillion" ? global::WindowsFormsApplication1.Properties.Resources.red_minnie :
                    game.players[idx].playerColor == "Indigo" ? global::WindowsFormsApplication1.Properties.Resources.purple_cthulhu :
                    global::WindowsFormsApplication1.Properties.Resources.green_dino;
                playerPics[idx].Name = "pictureBox" + idx;
                playerPics[idx].BackColor = System.Drawing.Color.LightGray;
                playerPics[idx].Size = new System.Drawing.Size(73, 63);
                playerPics[idx].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                playerPics[idx].TabIndex = 15;
                playerPics[idx].TabStop = false;

                x = idx == 0 ? 397 : idx == 1 ? 825 : idx == 2 ? 1251 : idx == 3 ? 597 : 1042;
                y = idx < 3 ? 110 : 393;
                playerPics[idx].Location = new System.Drawing.Point(x, y);
            }

            ok.BackColor = System.Drawing.Color.MidnightBlue;
            ok.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ok.ForeColor = System.Drawing.Color.LightGray;
            ok.Location = new System.Drawing.Point(582, 675);
            ok.Name = "buttonok";
            ok.Size = new System.Drawing.Size(270, 93);
            ok.TabIndex = 8;
            ok.Text = "Continue";
            ok.UseVisualStyleBackColor = false;
            ok.Click += new System.EventHandler(game.BackToNormal);

            title.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title.ForeColor = System.Drawing.Color.Black;
            title.Location = new System.Drawing.Point(387, 21);
            title.Name = "labeltitle";
            title.Size = new System.Drawing.Size(667, 60);
            title.TabIndex = 10;
            title.Text = "Player Statistics";
            title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            foreach (var pic in playerPics)
                ((System.ComponentModel.ISupportInitialize)(pic)).EndInit();

            foreach (var pic in playerPics)
                content.AddControl(pic);
            foreach (var box in playerBoxes)
                content.AddControl(box);
            content.AddControl(title);
            content.AddControl(ok);

            color = System.Drawing.Color.DarkMagenta;

            return content;
        }

        private static DisplayContent GenerateDisplayResultsContent(Game game, ref System.Drawing.Color color)
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
            button4.Click += new System.EventHandler(game.GoToMainMenu);

            label1.AutoSize = true;
            label1.BackColor = game._usOKLightColor;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Font = new System.Drawing.Font("Ink Free", game._usOKDarkColor == System.Drawing.Color.MediumPurple ? 18F : 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(77, 65);
            label1.MaximumSize = new System.Drawing.Size(1200, 500);
            label1.MinimumSize = new System.Drawing.Size(1200, 500);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1200, 500);
            label1.TabIndex = 6;
            label1.Text = game.UsokText;

            color = game._usOKDarkColor;

            content.AddControl(button4);
            content.AddControl(label1);

            return content;
        }
    }
}
