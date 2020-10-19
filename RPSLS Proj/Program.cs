using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.DisplayGameRules();

            game.InstantiateGestures();

            game.InstantiatePlayers();

            game.playGame();
            

        }
    }
}
