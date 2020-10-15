using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Proj
{
    public class ComputerPlayer
    {
        public Random random = new Random();
        public string playerName;
        public ComputerPlayer()
        {
            playerName = "Computer Player";
        }

        public int CompMakeAChoice(int computerInput)
        {
            computerInput = random.Next(1,6);
            return computerInput;

        }
    }
}
