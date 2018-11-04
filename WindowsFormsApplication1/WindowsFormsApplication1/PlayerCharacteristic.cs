using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public enum CharacteristicType { MAJOR, CLUB, CAPSTONE };

    public interface PlayerCharacteristic
    {
        // Return text to be displayed for this player characteristic
        String getText();

        // Return earning equivalent for calculation at the end of the game
        int getEarningPotential();

        // Return the type of characteristic
        CharacteristicType getType();
    }
}