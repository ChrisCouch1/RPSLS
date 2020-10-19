using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Proj
{
    public class HumanPlayer : Player

    {
        public string playerName;

        public HumanPlayer(string playerName)
        {
            playerName = Console.ReadLine();
        }

         public override string MakeAChoice()
         {
            string userInput;
            Console.WriteLine("What will be your next move?\nChoose from:\n0 for Rock\n1 for Paper\n2 for Scissors\n3 for Lizard\n4 for Spock");
            userInput = Console.ReadLine();
            return userInput;

         }


    }
}
