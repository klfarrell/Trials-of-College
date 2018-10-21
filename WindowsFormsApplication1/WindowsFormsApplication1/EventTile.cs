
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public enum EventTileType { LOAN, FRIEND, OCC };

    public class EventTile : Tile
    {
        private String text;
        private EventTileType actionType;
        private int actionValue;

        public EventTile( String _text, EventTileType _actionType, int _actionValue )
        {
            text = _text;
            actionType = _actionType;
            actionValue = _actionValue;
        }

        public String getText()
        {
            return text;
        }

        public bool actOnPlayer( Player p )
        {
            switch( actionType )
            {
                case EventTileType.LOAN:
                    p.numLoans += actionValue;
                    break;
                case EventTileType.FRIEND:
                    p.numFriends += actionValue;
                    break;
                case EventTileType.OCC:
                    p.numCredits += actionValue;
                    break;
            }
            return true;
        }

        public bool isStopTile()
        {
            return false;
        }
    }
}