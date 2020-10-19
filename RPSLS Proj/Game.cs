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
            " from Rock, Paper, Scissors, Lizard, and Spock.\nRock crushes lizard, lizard poisons Spock,\nSpock smashes scissors, scissors decapitate lizard,\nLizard eats paper, " +
            "paper disproves Spock,\nSpock vaporizes rock. And as it always has, rock crushes scissors.\n-- Dr. Sheldon Cooper (The Big Bang Theory S02E08)");
            Console.WriteLine("The first player to 3 points wins the game.");
        }
        public void InstantiatePlayers()
        {
            Console.WriteLine("Will this be a one player game or a two player game? 1 for one, 2 for two.");
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                
                playerOne = new HumanPlayer("Player One");
                playerTwo = new ComputerPlayer("ComputerPlayer");
                


            }
            else if(userInput == "2")
            {
               
                playerOne = new HumanPlayer("Player One");
                playerTwo = new HumanPlayer("Player Two");
                
            }
            else
            {
                Console.WriteLine("I'm sorry, but that was not a valid entry. Try again");
                InstantiatePlayers();
            }
            
            
        }
        public void playGame()
        {   int playerOneScore = 0;
            int playerTwoScore = 0;
            string playerOneInput;
            string playerTwoInput;
            do
            {
                Console.WriteLine("Player One, please select your move:\n0 for Rock\n1 for Paper\n2 for Scissors\n3 for Lizard\n4 for Spock");
                playerOneInput = Console.ReadLine();
                switch (playerOneInput)
                {
                    case "0":
                        Console.WriteLine("Player Two will now select...\nPlease select your move:\n0 for Rock\n1 for Paper\n2 for Scissors\n3 for Lizard\n4 for Spock");
                        playerTwoInput = playerTwo.MakeAChoice();
                        if (playerOneInput == playerTwoInput)
                        {
                            Console.WriteLine("TIED! No points");
                        }
                        else if (playerTwoInput == "1")
                        {
                            Console.WriteLine("Paper covers Rock, Player Two wins a point!");
                            playerTwoScore++;
                        }
                        else if (playerTwoInput == "2")
                        {
                            Console.WriteLine("Rock smashes Scissors, Player One wins a point!");
                            playerOneScore++;
                        }
                        else if (playerTwoInput == "3")
                        {
                            Console.WriteLine("Rock smashes Lizard, Player One wins a point!");
                            playerOneScore++;
                        }
                        else if (playerTwoInput == "4")
                        {
                            Console.WriteLine("Spock vaporizes Rock, Player Two wins a point!");
                            playerTwoScore++;
                        }
                        break;
                    case "1":
                        Console.WriteLine("Player Two will now select...\nPlease select your move:\n0 for Rock\n1 for Paper\n2 for Scissors\n3 for Lizard\n4 for Spock");
                        playerTwoInput = playerTwo.MakeAChoice();
                        if (playerOneInput == playerTwoInput)
                        {
                            Console.WriteLine("TIED! No points");
                        }
                        else if (playerTwoInput == "0")
                        {
                            Console.WriteLine("Paper covers Rock, Player One wins a point!");
                            playerOneScore++;
                        }
                        else if (playerTwoInput == "2")
                        {
                            Console.WriteLine("Scissors cuts Paper, Player Two wins a point!");
                            playerTwoScore++;
                        }
                        else if (playerTwoInput == "3")
                        {
                            Console.WriteLine("Lizard eats Paper, Player Two wins a point!");
                            playerTwoScore++;
                        }
                        else if (playerTwoInput == "4")
                        {
                            Console.WriteLine("Paper disproves Spock, Player One wins a point!");
                            playerOneScore++;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Player Two will now select...\nPlease select your move:\n0 for Rock\n1 for Paper\n2 for Scissors\n3 for Lizard\n4 for Spock");
                        playerTwoInput = playerTwo.MakeAChoice(); 
                        if (playerOneInput == playerTwoInput)
                        {
                            Console.WriteLine("TIED! No points");
                        }
                        else if (playerTwoInput == "0")
                        {
                            Console.WriteLine("Rock smashes Scissors, Player Two wins a point!");
                            playerTwoScore++;
                        }
                        else if (playerTwoInput == "1")
                        {
                            Console.WriteLine("Scissors cut Paper, Player One wins a point!");
                            playerOneScore++;
                        }
                        else if (playerTwoInput == "3")
                        {
                            Console.WriteLine("Scissors decapitate Lizard, Player One wins a point!");
                            playerOneScore++;
                        }
                        else if (playerTwoInput == "4")
                        {
                            Console.WriteLine("Spock smashes Scissors, Player Two wins a point!");
                            playerTwoScore++;
                        }
                        break;
                    case "3":
                        Console.WriteLine("Player Two will now select...\nPlease select your move:\n0 for Rock\n1 for Paper\n2 for Scissors\n3 for Lizard\n4 for Spock");
                        playerTwoInput = playerTwo.MakeAChoice();
                        if (playerOneInput == playerTwoInput)
                        {
                            Console.WriteLine("TIED! No points");
                        }
                        else if (playerTwoInput == "0")
                        {
                            Console.WriteLine("Rock smashes Lizard, Player Two wins a point!");
                            playerTwoScore++;
                        }
                        else if (playerTwoInput == "1")
                        {
                            Console.WriteLine("Lizard eats Paper, Player One wins a point!");
                            playerOneScore++;
                        }
                        else if (playerTwoInput == "2")
                        {
                            Console.WriteLine("Scissors decapitate Lizard, Player Two wins a point!");
                            playerTwoScore++;
                        }
                        else if (playerTwoInput == "4")
                        {
                            Console.WriteLine("Lizard poisons Spock, Player One wins a point!");
                            playerOneScore++;
                        }
                        break;
                    case "4":
                        Console.WriteLine("Player Two will now select...\nPlease select your move:\n0 for Rock\n1 for Paper\n2 for Scissors\n3 for Lizard\n4 for Spock");
                        playerTwoInput = playerTwo.MakeAChoice();
                        if (playerOneInput == playerTwoInput)
                        {
                            Console.WriteLine("TIED! No points");
                        }
                        else if (playerTwoInput == "0")
                        {
                            Console.WriteLine("Spock vaporizes Rock, Player One wins a point!");
                            playerOneScore++;
                        }
                        else if (playerTwoInput == "1")
                        {
                            Console.WriteLine("Paper disproves Spock, Player Two wins a point!");
                            playerTwoScore++;
                        }
                        else if (playerTwoInput == "2")
                        {
                            Console.WriteLine("Spock smashes Scissors, Player One wins a point!");
                            playerOneScore++;
                        }
                        else if (playerTwoInput == "3")
                        {
                            Console.WriteLine("Lizard poisons Spock, Player One wins a point!");
                            playerTwoScore++;
                        }
                        break;
                }
            }
            while (playerOneScore <= 2 && playerTwoScore <= 2);
            Console.WriteLine("GAME OVER\nPlayer One score is " + playerOneScore + ", and Player Two score is " + playerTwoScore);
            Console.ReadLine();



            


        }

        
    }
}
