using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Capstone : PlayerCharacteristic
    {
        String text;
        int earningPotential;

        public Capstone( String _text, int _earningPotential )
        {
            text = _text;
            earningPotential = _earningPotential;
        }

        public String getText()
        {
            return text;
        }

        public int getEarningPotential()
        {
            return earningPotential;
        }

        public CharacteristicType getType()
        {
            return CharacteristicType.CAPSTONE;
        }
    }
}