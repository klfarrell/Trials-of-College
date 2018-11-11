using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public interface Tile
    {
        // Returns the String to be displayed for this time
        String getText();

        // Always returns true for EventTile
        // Returns true for StopTile if the player should take another turn
        // Returns false for StopTile if the player should execute this tile again (failed exam)
        void actOnCurrentPlayer();

        // Returns true if object class is StopTile
        bool isStopTile();
    }
}