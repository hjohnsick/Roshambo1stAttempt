using System;

namespace Lab13RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a user name: ");
            string playerOne = Console.ReadLine();

            Console.Write($"Hello {playerOne}!\nWho do you want to play against?\nEasy Peasy or Macho Man?");
            string userChoice = Console.ReadLine();

            if (userChoice == "Easy Peasy")//Easy Peasy player will return rock everytime
            {
                EasyPlayer.GenerateRoshambo();
            }
            else//else will generate a random number
            {
                ComputerPlayer.GenerateRoshambo();
            }


           /* if (userChoice == rock && computerChoice == rock || userChoice == scissors && computerChoice == scissors || userChoice == paper && computerChoice == paper)
            {
                return draw;
            }
            else if (userChoice == rock && computerChoice == paper || userChoice)
            {
                return Computer Wins!;
            }*/
        }
    }
}
