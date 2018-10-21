using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class StopTile : Tile
    {

        private bool spinForExam( Player p )
        {
            return true; //TODO: define logic
        }

        private void chooseCharacteristic( Player p )
        {
            //TODO: define logic
        }

        public StopTile()
        {
            //TODO: define logic
        }

        public String getText()
        {
            return "";
        }

        public bool actOnPlayer(Player p)
        {
            if ( spinForExam( p ) )
            {
                chooseCharacteristic( p );
                return true;
            }
            else
                return false;
        }

        public bool isStopTile()
        {
            return true;
        }
    }
}