using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class BoardLayoutGraph
    {
        //
        private TileNode _communityFirst;
        private TileNode _communityLast;

        private TileNode _fourYearFirst;
        private TileNode _fourYearLast;

        private List<TileNode> _allNodes;

        public BoardLayoutGraph() {
            _allNodes = new List<TileNode>();
        }

        public void AppendNodeToCommunityPath(TileNode node) {
            _allNodes.Add(node);

            if(_communityFirst == null)
            {
                _communityFirst = node;
                _communityLast = node;
            }else
            {
                _communityLast.AttachTile(node);
                _communityLast = node;
            }

            
        }

        public void AppendNodeToFourYearPath(TileNode node)
        {
            _allNodes.Add(node);

            if (_fourYearFirst == null)
            {
                _fourYearFirst = node;
                _fourYearLast = node;
            }
            else
            {
                _fourYearLast.AttachTile(node);
                _fourYearLast = node;
            }
        }

        public void AppendNodeToJoinedPath(TileNode node)
        {
            _allNodes.Add(node);
            
            if(_fourYearFirst == null && _communityFirst == null)
            {
                _fourYearFirst = node;
                _communityFirst = node;
                _fourYearLast = node;
                _communityLast = node;
            }else
            {
                _communityLast.AttachTile(node);
                _fourYearLast.AttachTile(node);
                _communityLast = node;
                _communityFirst = node;
            }
        }

        public TileNode GetFirstCommunityNode()
        {
            return _communityFirst;
        }

        public TileNode GetFirstFourYearNode()
        {
            return _fourYearFirst;
        }

        public List<TileNode> GetAllNodes() {
            // Doing it this way so the list can't be modified from outside
            var nodes = new List<TileNode>();
            nodes.AddRange(_allNodes);
            return nodes;
        }
    }
}
