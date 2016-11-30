using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game

    {
        public string name = string.Empty;
      
        public void gameRules()
        {
            Console.WriteLine(" Thank You for choosing The RPSLS Game, here are the Rules: ");
            Console.ReadLine();
            Console.WriteLine(" Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, ");
            Console.WriteLine(" Spock smashes Scissors, Scissors decapitates Lizard, Lizard eats Paper, ");
            Console.WriteLine(" Paper disproves Spock, Spock vaporizes Rock, and Rock crushes Scissors. ");
            Console.ReadLine();

        }

        public void playerOrComp(Player PlayerOne, Player PlayerTwo)
        {
            Console.WriteLine(" Do you want to verse another Player OR verse the Computer?");
            string userInput = Console.ReadLine().ToLower();


            if (userInput == "Player" || userInput == "player") 
            {
                Console.WriteLine(" You are playing against another Player");
                Console.ReadLine();

                // Create new playerTwo
                PlayerOne = new Player();

                Console.WriteLine(" Enter Player Name: ");
                Console.ReadLine();
                name = userInput;

                PlayerOne.SetPlayerProperties(name);
                PlayerOne.DisplayInfo();


                // Create new playerTwo
                PlayerTwo = new Player();
                Console.WriteLine(" Enter Player2 Name: ");
                Console.ReadLine();
                name = userInput;
                PlayerTwo.DisplayInfo();
            }

            else if (userInput == "Computer")
            {
                Console.WriteLine(" You are playing against Computer");
                Console.ReadLine();
                //    Computer computer = new Computer();
                //    computer.startComputer();
            }
            else
            {

                Console.WriteLine(" Please choose Opponent: Player or Computer");
                playerOrComp(PlayerOne, PlayerTwo);
            }
        }

        public void chooseChoiceForPlayerOne(Player PlayerOne)
        {
            Console.WriteLine("Player1 Enter: Paper, Rock, Scissors, Lizard, or Spock.");
            string player1choice = Console.ReadLine().ToLower();
            PlayerOne.chooseChoice = player1choice.ToString();
            switch (player1choice)
            {
                case "paper":
                    Console.WriteLine(" Player1 have chosen: " + player1choice + "! \n");
                    break;
                case "rock":
                    Console.WriteLine(" Player1 have chosen:  " + player1choice + "! \n");
                    break;
                case "scissors":
                    Console.WriteLine(" Player1 have chosen: " + player1choice + "! \n");
                    break;
                case "lizard":
                    Console.WriteLine(" Player1 have chosen:  " + player1choice + "! \n");
                    break;
                case "spock":
                    Console.WriteLine(" Player1 have chosen:  " + player1choice + "! \n");
                    break;
                default:
                    Console.WriteLine(" Please chose a choice! ");
                    chooseChoiceForPlayerOne(PlayerOne);
                    break;
            }
        }
        public void chooseChoiceForPlayerTwo(Player PlayerTwo)
        {

            Console.WriteLine("Player2 Enter: Paper, Rock, Scissors, Lizard, or Spock.");
            string player2choice = Console.ReadLine().ToLower();

            PlayerTwo.chooseChoice = player2choice.ToString();

            switch (player2choice)

            {
                case "paper":
                    Console.WriteLine(" Player2 have chosen: " + player2choice + "! \n");
                    break;
                case "rock":
                    Console.WriteLine(" Player2 have chosen:  " + player2choice + "! \n");
                    break;
                case "scissors":
                    Console.WriteLine(" Player2 have chosen: " + player2choice + "! \n");
                    break;
                case "lizard":
                    Console.WriteLine(" Player2 have chosen:  " + player2choice + "! \n");
                    break;
                case "spock":
                    Console.WriteLine(" Player2 have chosen:  " + player2choice + "! \n");
                    break;
                default:
                    Console.WriteLine(" Please chose a choice! ");
                    chooseChoiceForPlayerTwo(PlayerTwo);
                    break;
            }

        }

        public void ComputeWinner(Player PlayerOne, Player PlayerTwo)
        {
            // Player1 choose Rock
            if (PlayerOne.chooseChoice == "Rock" && PlayerTwo.chooseChoice == "Rock") {
                Console.WriteLine(" It's a Tie!");
                PlayerOne.AddWinningScore();
            }

            if (PlayerOne.chooseChoice == "Rock" && PlayerTwo.chooseChoice == "Paper")
            {
                Console.WriteLine(" Player2 Win! Paper covers Rock");
                PlayerTwo.AddWinningScore();
            }
            if (PlayerOne.chooseChoice == "Rock" && PlayerTwo.chooseChoice == "Scissors")
            {
                Console.WriteLine(" Player1 Wins! Rock crushes Scissors");
                PlayerTwo.AddWinningScore();
            }
            if (PlayerOne.chooseChoice == "Rock" && PlayerTwo.chooseChoice == "Lizard")
            {
                Console.WriteLine(" Player1 Wins! Rock crushes Lizards");
                PlayerTwo.AddWinningScore();
            }
            if (PlayerOne.chooseChoice == "Rock" && PlayerTwo.chooseChoice == "Spock")
            {
                Console.WriteLine(" Player2 Wins!, Spock Vaporizes Rock");
                PlayerTwo.AddWinningScore();
            }

            // Player1 choose Paper
            if (PlayerOne.chooseChoice == "Paper" && PlayerTwo.chooseChoice == "Paper")
            {
                Console.WriteLine(" It's a Tie!");
                PlayerOne.AddWinningScore();
            }

            if (PlayerOne.chooseChoice == "Paper" && PlayerTwo.chooseChoice == "Rock")
            {
                Console.WriteLine(" Player1 Win! Paper covers Rock");
                PlayerTwo.AddWinningScore();
            }
            if (PlayerOne.chooseChoice == "Paper" && PlayerTwo.chooseChoice == "Scissors")
            {
                Console.WriteLine(" Player2 Wins! Scissors cuts Paper");
                PlayerTwo.AddWinningScore();
            }
            if (PlayerOne.chooseChoice == "Paper" && PlayerTwo.chooseChoice == "Lizard")
            {
                Console.WriteLine(" Player2 Wins! Lizard eats Paper");
                PlayerTwo.AddWinningScore();
            }
            if (PlayerOne.chooseChoice == "Paper" && PlayerTwo.chooseChoice == "Spock")
            {
                Console.WriteLine(" Player1 Wins!, Paper disproves Spock");
                PlayerTwo.AddWinningScore();
            }

            // Player1 choose Scissors
            if (PlayerOne.chooseChoice == "Scissors" && PlayerTwo.chooseChoice == "Scissors")
            {
                Console.WriteLine(" It's a Tie!");
                PlayerOne.AddWinningScore();
            }

            if (PlayerOne.chooseChoice == "Scissors" && PlayerTwo.chooseChoice == "Paper")
            {
                Console.WriteLine(" Player1 Win! Scissors cuts Paper");
                PlayerTwo.AddWinningScore();
            }
            if (PlayerOne.chooseChoice == "Scissors" && PlayerTwo.chooseChoice == "Rock")
            {
                Console.WriteLine(" Player2 Wins! Rock crushes Scissors");
                PlayerTwo.AddWinningScore();
            }
            if (PlayerOne.chooseChoice == "Scissors" && PlayerTwo.chooseChoice == "Lizard")
            {
                Console.WriteLine(" Player1 Wins! Scissors decapitates Lizard");
                PlayerTwo.AddWinningScore();
            }
            if (PlayerOne.chooseChoice == "Scissors" && PlayerTwo.chooseChoice == "Spock")
            {
                Console.WriteLine(" Player2 Wins!, Spock smashes Scissors");
                PlayerTwo.AddWinningScore();
            }

            // Player1 choose Lizard
            if (PlayerOne.chooseChoice == "Lizard" && PlayerTwo.chooseChoice == "Lizard")
            {
                Console.WriteLine(" It's a Tie!");
                PlayerOne.AddWinningScore();
            }

            if (PlayerOne.chooseChoice == "Lizard" && PlayerTwo.chooseChoice == "Rock")
            {
                Console.WriteLine(" Player2 Wins! Rock crushes Lizard");
                PlayerTwo.AddWinningScore();
            }
            if (PlayerOne.chooseChoice == "Lizard" && PlayerTwo.chooseChoice == "Paper")
            {
                Console.WriteLine(" Player1 Wins! Lizard eats Paper");
                PlayerTwo.AddWinningScore();
            }
            if (PlayerOne.chooseChoice == "Lizard" && PlayerTwo.chooseChoice == "Scissors")
            {
                Console.WriteLine(" Player1 Wins! Scissors decapitates Lizard");
                PlayerTwo.AddWinningScore();
            }
            if (PlayerOne.chooseChoice == "Lizard" && PlayerTwo.chooseChoice == "Spock")
            {
                Console.WriteLine(" Player1 Wins!, Lizard poisons Spock");
                PlayerTwo.AddWinningScore();
            }

            // Player1 choose Spock
            if (PlayerOne.chooseChoice == "Spock" && PlayerTwo.chooseChoice == "Spock")
            {
                Console.WriteLine(" It's a Tie!");
                PlayerOne.AddWinningScore();
            }

            if (PlayerOne.chooseChoice == "Spock" && PlayerTwo.chooseChoice == "Rock")
            {
                Console.WriteLine(" Player1 Wins! Spock vaporizes Rock");
                PlayerTwo.AddWinningScore();
            }
            if (PlayerOne.chooseChoice == "Spock" && PlayerTwo.chooseChoice == "Paper")
            {
                Console.WriteLine(" Player2 Wins! Paper disproves Spock");
                PlayerTwo.AddWinningScore();
            }
            if (PlayerOne.chooseChoice == "Spock" && PlayerTwo.chooseChoice == "Scissors")
            {
                Console.WriteLine(" Player1 Wins! Spock smashes Scissors");
                PlayerTwo.AddWinningScore();
            }
            if (PlayerOne.chooseChoice == "Spock" && PlayerTwo.chooseChoice == "Lizard")
            {
                Console.WriteLine(" Player2Wins!, Lizard poisons Spock");
                PlayerTwo.AddWinningScore();
            }

            // if any player won twice
            if (PlayerOne.score > 1){
                Console.WriteLine(" Player one win");
                Console.WriteLine(" The game is over ");
                PlayerOne.score = 0;
                PlayerTwo.score = 0;
            }

            // if any player won twice
            if (PlayerTwo.score > 1)
            {
                Console.WriteLine(" Player two win");
                Console.WriteLine(" The game is over ");
                PlayerOne.score = 0;
                PlayerTwo.score = 0;
            }

        }
        public void startComputer()
        {
            
        }
    }
}









    