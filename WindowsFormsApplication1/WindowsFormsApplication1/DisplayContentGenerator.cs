using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class DisplayContentGenerator
    {
        public static DisplayContent GenerateMenuContent(Menu menu)
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


        public static DisplayContent GenerateGameContent(Game game)
        {
            if (game.State.Equals("Normal"))
                return GenerateNormalGameContent();
            else if (game.State.Equals("UnitedStatesOfOK"))
                return GenerateUSOKContent();
            else if (game.State.Equals("AreYouSure"))
                return GenerateAreYouSureContent();
            else if (game.State.Equals("ExamSpin"))
                return GenerateExamSpinContent();
            else if (game.State.Equals("ChoosePC"))
                return GenerateChoosePCContent(game);
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

        private static DisplayContent GenerateUSOKContent()
        {
            DisplayContent content = new DisplayContent();

            return content;
        }

        private static DisplayContent GenerateAreYouSureContent()
        {
            DisplayContent content = new DisplayContent();

            return content;
        }

        private static DisplayContent GenerateExamSpinContent()
        {
            DisplayContent content = new DisplayContent();

            return content;
        }

        private static DisplayContent GenerateChoosePCContent(Game game)
        {
            DisplayContent content = new DisplayContent();

            System.Windows.Forms.Button buttonA = new System.Windows.Forms.Button();
            System.Windows.Forms.Button buttonB = new System.Windows.Forms.Button();
            System.Windows.Forms.Button buttonC = new System.Windows.Forms.Button();
            System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
            System.Windows.Forms.PictureBox pictureBox1 = new System.Windows.Forms.PictureBox();

            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();

            buttonA.BackColor = System.Drawing.Color.Yellow;
            buttonA.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonA.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonA.ForeColor = System.Drawing.Color.MidnightBlue;
            buttonA.Location = new System.Drawing.Point(76, 214);
            buttonA.Name = "buttonA";
            buttonA.Size = new System.Drawing.Size(117, 47);
            buttonA.TabIndex = 0;
            buttonA.Text = "Choice A";
            buttonA.UseVisualStyleBackColor = false;
            buttonA.Click += new System.EventHandler(game.setPC_A);

            buttonB.BackColor = System.Drawing.Color.Yellow;
            buttonB.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonB.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonB.ForeColor = System.Drawing.Color.MidnightBlue;
            buttonB.Location = new System.Drawing.Point(275, 214);
            buttonB.Name = "buttonB";
            buttonB.Size = new System.Drawing.Size(117, 47);
            buttonB.TabIndex = 1;
            buttonB.Text = "Choice B";
            buttonB.UseVisualStyleBackColor = false;
            buttonB.Click += new System.EventHandler(game.setPC_B);

            buttonC.BackColor = System.Drawing.Color.Yellow;
            buttonC.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonC.Font = new System.Drawing.Font("Ink Free", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonC.ForeColor = System.Drawing.Color.MidnightBlue;
            buttonC.Location = new System.Drawing.Point(461, 214);
            buttonC.Name = "buttonC";
            buttonC.Size = new System.Drawing.Size(117, 47);
            buttonC.TabIndex = 2;
            buttonC.Text = "Choice C";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += new System.EventHandler(game.setPC_C);

            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.LightYellow;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(10, 34);
            label1.MaximumSize = new System.Drawing.Size(500, 250);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(500, 48);
            label1.TabIndex = 3;
            //TODO: this should come from the possible player characteristics!
            label1.Text = "Lots of text to be seen here! Quite a long description of what will be asked...";

            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = ((System.Drawing.Image)(System.Drawing.Image.FromFile("./images/confused.jpg")));
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(516, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(149, 146);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;

            //this.BackColor = System.Drawing.SystemColors.MenuHighlight;

            content.AddControl(pictureBox1);
            content.AddControl(label1);
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
