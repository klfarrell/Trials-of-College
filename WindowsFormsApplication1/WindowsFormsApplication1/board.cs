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
            //create tiles here!!
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