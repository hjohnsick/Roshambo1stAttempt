using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    class ComputerPlayer : Player
    {
  
        public override Roshambo GenerateRoshambo()
        {
            Random rnd = new Random();
            int computNumber = rnd.Next(1, 4);
            if (computNumber == 1)
            {
                return Roshambo.rock;
            }
            else if (computNumber == 2)
            {
                return Roshambo.paper;
            }
            else
            {
                return Roshambo.scissors;
            }

        }
    }
    }
}
