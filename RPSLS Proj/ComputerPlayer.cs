using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Proj
{
    public class ComputerPlayer : Player
    {
        public Random random = new Random();
        public string playerName;
        public ComputerPlayer(string playerName)
        {
            playerName = "Computer Player";
        }

        public override string MakeAChoice()
        {
            string computerInput;
            computerInput = Convert.ToString(random.Next(5));
            return computerInput;

        }
    }
}
