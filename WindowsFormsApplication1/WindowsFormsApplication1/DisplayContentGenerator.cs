using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class DisplayContentGenerator
    {
        public static DisplayContent GenerateMenuContent(Menu menu, ref System.Drawing.Color color)
        {
            if (menu.State.Equals("Normal"))
                return GenerateNormalMenuContent();
            else if (menu.State.Equals("Rules"))
                return GenerateRulesContent();
            else if (menu.State.Equals("NameNumber"))
                return GenerateNameNumberContent();
            else if (menu.State.Equals("CreatePlayer"))
                return GenerateCreatePlayerContent();
            else if (menu.State.Equals("LoadGame"))
                return GenerateLoadGameContent();
            else
                return null;
        }


        public static DisplayContent GenerateGameContent(Game game, ref System.Drawing.Color color)
        {
            if (game.State.Equals("Normal"))
                return GenerateNormalGameContent();
            else if (game.State.Equals("UnitedStatesOfOK"))
                return GenerateUSOKContent(game, ref color);
            else if (game.State.Equals("AreYouSure"))
                return GenerateAreYouSureContent();
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
        private static DisplayContent GenerateNormalMenuContent() {
            DisplayContent content = new DisplayContent();

            return content;
        }

        private static DisplayContent GenerateRulesContent()
        {
            DisplayContent content = new DisplayContent();

            return content;
        }

        private static DisplayContent GenerateNameNumberContent()
        {
            DisplayContent content = new DisplayContent();

            return content;
        }

        private static DisplayContent GenerateCreatePlayerContent()
        {
            DisplayContent content = new DisplayContent();

            return content;
        }

        private static DisplayContent GenerateLoadGameContent()
        {
            DisplayContent content = new DisplayContent();

            return content;
        }

        private static DisplayContent GenerateNormalGameContent()
        {
            DisplayContent content = new DisplayContent();

            return content;
        }

        private static DisplayContent GenerateUSOKContent(Game game, ref System.Drawing.Color color)
        {
            DisplayContent content = new DisplayContent();

            System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
            System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();

            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.LightGray;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(39, 39);
            label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label2.MaximumSize = new System.Drawing.Size(640, 300);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(611, 56);
            label2.TabIndex = 3;
            label2.Text = game.usokText;

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
            button1.Click += new System.EventHandler(game.BackToNormal);

            color = System.Drawing.Color.Aquamarine;
          
            content.AddControl(button1);
            content.AddControl(label2);

            return content;
        }

        private static DisplayContent GenerateAreYouSureContent()
        {
            DisplayContent content = new DisplayContent();

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

            pictureBox1.Image = ((System.Drawing.Image)(System.Drawing.Image.FromFile("images/exam_time.jpg")));
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
            label2.Text = "Stop studying! You\'ve officially reached the end of Year ";
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
                pictureBox1.Image = ((System.Drawing.Image)(System.Drawing.Image.FromFile("images/confused.jpg")));
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
