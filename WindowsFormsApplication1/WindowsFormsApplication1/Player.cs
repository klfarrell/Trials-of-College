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
    }
}