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
                return GenerateChoosePCContent();
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

        private static DisplayContent GenerateChoosePCContent()
        {
            DisplayContent content = new DisplayContent();

            return content;
        }

        private static DisplayContent GenerateDisplayResultsContent()
        {
            DisplayContent content = new DisplayContent();

            return content;
        }
    }
}
