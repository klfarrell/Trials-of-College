using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Player
    {
        public string playerName { get; set; }
        public string playerColor { get; set; }
        public uint boardPosition { get; set; }
        public int numLoans { get; set; }
        public int numFriends { get; set; }
        public int numCredits { get; set; }
        public bool isCommunityCollege { get; set; }
        public bool isGraduated { get; set; }

        public Player(string _playerName, string _playerColor, uint _boardPosition, int _numLoans, int _numFriends, int _numCredits, bool _isCommunityCollege, bool _isGraduated)
        {
            playerName = _playerName;
            playerColor = _playerColor;
            boardPosition = _boardPosition;
            numLoans = _numLoans;
            numFriends = _numFriends;
            numCredits = _numCredits;
            isCommunityCollege = _isCommunityCollege;
            isGraduated = _isGraduated;
        }

        public int getLoans()
        {
            return numLoans;
        }

        public int getFriends()
        {
            return numFriends;
        }

        public int getCredits()
        {
            return numCredits;
        }

        public uint getBoardPosition()
        {
            return boardPosition;
        }

        public string getPlayerName()
        {
            return playerName;
        }

        public string getPlayerColor()
        {
            return playerColor;
        }
    }

}