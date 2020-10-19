using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Proj
{
    public class Game
    {
        
        public int playerOneScore = 0;
        public int playerTwoScore = 0;
        public List<Gestures> listOfGestures = new List<Gestures>();
        Player playerOne;
        Player playerTwo;

        public void InstantiateGestures()
        {
            Rock rock = new Rock("Rock");
            Paper paper = new Paper("Paper");
            Scissors scissors = new Scissors("Scissors");
            Lizard lizard = new Lizard("Lizard");
            Spock spock = new Spock("Spock");
            listOfGestures.Add(rock);
            listOfGestures.Add(paper);
            listOfGestures.Add(scissors);
            listOfGestures.Add(lizard);
            listOfGestures.Add(spock);
        }

        public void DisplayGameRules()
        {
            Console.WriteLine("Welcome to a riveting game 'Rock Paper Scissors Lizard Spock!' \nThe rules are simple: choose a move" +
            "from Rock, Paper, Scissors, Lizard, and Spock.\nRock crushes lizard, lizard poisons Spock,\nSpock smashes scissors, scissors decapitate lizard,\nLizard eats paper," +
            "paper disproves Spock,\nSpock vaporizes rock. And as it always has, rock crushes scissors.\n-- Dr. Sheldon Cooper (The Big Bang Theory S02E08)");
            Console.WriteLine("The first player to 3 points wins the game.");
        }
        public void InstantiatePlayers()
        {
            Console.WriteLine("Will this be a one player game or a two player game? 1 for one, 2 for two.");
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                Console.WriteLine("What would you like to name Player One?");
                playerOne = new HumanPlayer(Console.ReadLine());
                Console.WriteLine("Player Two will be the computer.");
                playerTwo = new ComputerPlayer("ComputerPlayer");



            }
            if(userInput == "2")
            {
                Console.WriteLine("What would you like to name Player One?");
                playerOne = new HumanPlayer(Console.ReadLine());
                Console.WriteLine("What would you like to name Player Two?");
                playerTwo = new HumanPlayer(Console.ReadLine());
                
            }
            else
            {
                Console.WriteLine("I'm sorry, but that was not a valid entry");
                InstantiatePlayers();
            }
            
            
        }
        public void playGame()
        {
            Console.WriteLine("Player One, please select your move:\n0 for Rock\n1 for Paper\n2 for Scissors\n3 for Lizard\n4 for Spock");
            playerOne.MakeAChoice(Convert.ToInt32(Console.ReadLine()));
            switch (Console.ReadLine())
            {
                case 1:
                Console.WriteLine("Player Two will now select...\nPlease select your move:\n0 for Rock\n1 for Paper\n2 for Scissors\n3 for Lizard\n4 for Spock");

            }


        }

        
    }
}
