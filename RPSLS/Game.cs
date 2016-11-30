using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        Player player1;
        Player player2;
        public Game()
        {

        }
        public void RunGame()
        {
            GameRules();
            SetUpPlayers();
            //loop
            ComputeWinner();
        }
        public void GameRules()
        {
            Console.WriteLine(" Thank You for choosing The RPSLS Game, here are the Rules. \n");
            Console.WriteLine(" PRESS ENTER TO CONTINUE. ");
            Console.ReadLine();
            Console.WriteLine(" Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, ");
            Console.WriteLine(" Spock smashes Scissors, Scissors decapitates Lizard, Lizard eats Paper, ");
            Console.WriteLine(" Paper disproves Spock, Spock vaporizes Rock, and Rock crushes Scissors. \n");
            Console.WriteLine(" PRESS ENTER TO CONTINUE! ");
            Console.ReadLine();

        }

        public void SetUpPlayers()
        {
            player1 = new Human();
            player1.GetName();

            Console.WriteLine(" Do you want to play against another Player OR against the Computer? \n");
            Console.WriteLine(" TYPE: Player or Computer");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "Player" || userInput == "player") 
            {
                Console.WriteLine(" GREAT! You are playing against another Player \n");
                player2 = new Human();
                player2.GetName();          
            }

            else if (userInput == "Computer")
            {
                Console.WriteLine(" YOU ARE VERSING Computer");
                player2 = new Computer();
                player2.GetName();
               
            }
            else
            {
                Console.WriteLine(" PLEASE CHOOSE OPPONENT: Player or Computer");
                SetUpPlayers();
            }
        }

        public void ComputeWinner()

        {
            player1.MakeChoice();
            player2.MakeChoice();
            // If Player1 choose Rock
            if (player1.choice == "Rock" && player2.choice == "Rock")
            {
                Console.WriteLine(" It's a Tie!");
            }

            if (player1.choice == "Rock" && player2.choice == "Paper")
            {
                Console.WriteLine(" Player2 Win! Paper covers Rock");
                player2.AddWinningScore();
            }
            if (player1.choice == "Rock" && player2.choice == "Scissors")
            {
                Console.WriteLine(" Player1 Wins! Rock crushes Scissors");
                player2.AddWinningScore();
            }
            if (player1.choice == "Rock" && player2.choice == "Lizard")
            {
                Console.WriteLine(" Player1 Wins! Rock crushes Lizards");
                player2.AddWinningScore();
            }
            if (player1.choice == "Rock" && player2.choice == "Spock")
            {
                Console.WriteLine(" Player2 Wins!, Spock Vaporizes Rock");
                player2.AddWinningScore();
            }

            // If Player1 choose Paper
            else if (player1.choice == "Paper" && player2.choice == "Paper")
            {
                Console.WriteLine(" It's a Tie!");
            }

            if (player1.choice == "Paper" && player2.choice == "Rock")
            {
                Console.WriteLine(" Player1 Win! Paper covers Rock");
                player2.AddWinningScore();
            }
            if (player1.choice == "Paper" && player2.choice == "Scissors")
            {
                Console.WriteLine(" Player2 Wins! Scissors cuts Paper");
                player2.AddWinningScore();
            }
            if (player1.choice == "Paper" && player2.choice == "Lizard")
            {
                Console.WriteLine(" Player2 Wins! Lizard eats Paper");
                player2.AddWinningScore();
            }
            if (player1.choice == "Paper" && player2.choice == "Spock")
            {
                Console.WriteLine(" Player1 Wins!, Paper disproves Spock");
                player2.AddWinningScore();
            }

            // If Player1 choose Scissors
            else if (player1.choice == "Scissors" && player2.choice == "Scissors")
            {
                Console.WriteLine(" It's a Tie!");
            }

            if (player1.choice == "Scissors" && player2.choice == "Paper")
            {
                Console.WriteLine(" Player1 Win! Scissors cuts Paper");
                player2.AddWinningScore();
            }
            if (player1.choice == "Scissors" && player2.choice == "Rock")
            {
                Console.WriteLine(" Player2 Wins! Rock crushes Scissors");
                player2.AddWinningScore();
            }
            if (player1.choice == "Scissors" && player2.choice == "Lizard")
            {
                Console.WriteLine(" Player1 Wins! Scissors decapitates Lizard");
                player2.AddWinningScore();
            }
            if (player1.choice == "Scissors" && player2.choice == "Spock")
            {
                Console.WriteLine(" Player2 Wins!, Spock smashes Scissors");
                player2.AddWinningScore();
            }

            // If Player1 choose Lizard
            else if (player1.choice == "Lizard" && player2.choice == "Lizard")
            {
                Console.WriteLine(" It's a Tie!");
            }

            if (player1.choice == "Lizard" && player2.choice == "Rock")
            {
                Console.WriteLine(" Player2 Wins! Rock crushes Lizard");
                player2.AddWinningScore();
            }
            if (player1.choice == "Lizard" && player2.choice == "Paper")
            {
                Console.WriteLine(" Player1 Wins! Lizard eats Paper");
                player2.AddWinningScore();
            }
            if (player1.choice == "Lizard" && player2.choice == "Scissors")
            {
                Console.WriteLine(" Player1 Wins! Scissors decapitates Lizard");
                player2.AddWinningScore();
            }
            if (player1.choice == "Lizard" && player2.choice == "Spock")
            {
                Console.WriteLine(" Player1 Wins!, Lizard poisons Spock");
                player2.AddWinningScore();
            }

            // If Player1 choose Spock
            else if (player1.choice == "Spock" && player2.choice == "Spock")
            {
                Console.WriteLine(" It's a Tie!");
            }

            if (player1.choice == "Spock" && player2.choice == "Rock")
            {
                Console.WriteLine(" Player1 Wins! Spock vaporizes Rock");
                player2.AddWinningScore();
            }
            if (player1.choice == "Spock" && player2.choice == "Paper")
            {
                Console.WriteLine(" Player2 Wins! Paper disproves Spock");
                player2.AddWinningScore();
            }
            if (player1.choice == "Spock" && player2.choice == "Scissors")
            {
                Console.WriteLine(" Player1 Wins! Spock smashes Scissors");
                player2.AddWinningScore();
            }
            if (player1.choice == "Spock" && player2.choice == "Lizard")
            {
                Console.WriteLine(" Player2Wins!, Lizard poisons Spock");
                player2.AddWinningScore();
            }

            // If any player win twice
            if (player1.score > 2)
            {
                Console.WriteLine(" Player one win");
                Console.WriteLine(" The game is over ");
                player1.score = 0;
                player2.score = 0;
            }

            // if any player won twice
            if (player2.score > 2)
            {
                Console.WriteLine(" Player two win");
                Console.WriteLine(" The game is over ");
                player1.score = 0;
                player2.score = 0;
            }

        }

        public void startComputer()
        {
            // section for player vs. computer
        }
    }
}









    