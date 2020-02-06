using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    class Player3 : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Console.WriteLine("Choose 1 for rock, 2 for paper, and 3 for scissors.");
            int userChoice = int.Parse(Console.ReadLine());

           if (userChoice == 1)
            {
                return Roshambo.rock;
            }
           else if (userChoice == 2)
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
