
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
        private Game gameRef;

        public EventTile( String _text, EventTileType _actionType, int _actionValue, Game thegame )
        {
            text = _text;
            actionType = _actionType;
            actionValue = _actionValue;
            gameRef = thegame;
        }

        public String getText()
        {
            return text;
        }

        public void actOnCurrentPlayer()
        {
            switch( actionType )
            {
                case EventTileType.LOAN:
                    gameRef.CurrentPlayer().numLoans += actionValue;
                    break;
                case EventTileType.FRIEND:
                    gameRef.CurrentPlayer().numFriends += actionValue;
                    break;
                case EventTileType.OCC:
                    gameRef.CurrentPlayer().numCredits += actionValue;
                    break;
            }
        }

        public bool isStopTile()
        {
            return false;
        }
    }
}