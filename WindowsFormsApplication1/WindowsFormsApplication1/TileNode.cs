using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class TileNode
    {
        private Tile _tile;
        private TileNode _next;
        private double _x;
        private double _y;

        public TileNode(Tile tile, double x, double y) {
            _tile = tile;
            _x = x;
            _y = y;
        }

        public Tile CurrentTile
        {
            get
            {
                return _tile;
            }
        }

        public double X
        {
            get
            {
                return _x;
            }
        }

        public double Y
        {
            get
            {
                return _y;
            }
        }

        public TileNode Next
        {
            get
            {
                return _next;
            }
        }

        public void AttachTile(TileNode nextNode)
        {
            _next = nextNode;
        }

    }
}
