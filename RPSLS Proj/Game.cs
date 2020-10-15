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
            Console.WriteLine("Welcome to a riveting game 'Rock Paper Scissors Lizard Spock!' \nThe rules are simple: choose a" +
                "gesture from Rock, Paper, Scissors, Lizard, and Spock. \nRock beats Scissors and Lizard" +
                "\nPaper beats Rock and Spock\nScissors beats Paper and Lizard\nLizzard beats Paper and Spock\nSpock beats Rock and Scissors");
            Console.WriteLine("The first player to 3 points wins the game.");
        }
        public void InstantiatePlayers()
        {
            Console.WriteLine("Will this be a one player game or a two player game? 1 for one, 2 for two.");
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                Console.WriteLine("What would you like to name Player One?");
                Player playerOne = new Player(Console.ReadLine());
                Console.WriteLine("Player Two will be the computer.");
                ComputerPlayer playerTwo = new ComputerPlayer();


            }
            if(userInput == "2")
            {
                Console.WriteLine("What would you like to name Player One?");
                Player playerOne = new Player(Console.ReadLine());
                Console.WriteLine("What would you like to name Player Two?");
                Player playerTwo = new Player(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("I'm sorry, but that was not a valid entry");
                InstantiatePlayers();
            }

            
        }

        
    }
}
