using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    class EasyPlayer : Player
    {
        public override Roshambo GenerateRoshambo()//anytime you want to use the abstract or virtual in a concrete way you have to override the method
        {
            return Roshambo.rock;
        }

        
    }
}
