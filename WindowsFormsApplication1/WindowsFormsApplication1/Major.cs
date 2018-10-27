using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{ 
    public class Major : PlayerCharacteristic
    {
        String text;
        int earningPotential;

        public Major( String _text, int _earningPotential )
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
            return CharacteristicType.MAJOR;
        }
    }
}