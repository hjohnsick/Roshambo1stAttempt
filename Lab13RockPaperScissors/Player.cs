using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RockPaperScissors
{
    abstract class Player
    {
        public string Name { get; set; }
        public int RoshValue { get; set; }

        public abstract Roshambo GenerateRoshambo();//need to add the enum to the return type which is Roshambo
        
          
    }
}
