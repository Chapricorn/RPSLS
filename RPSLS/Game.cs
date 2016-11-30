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
        public Int32 age = 0; 
        public string brand = string.Empty;

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

                //Console.WriteLine(" Enter Player Age: ");
                //Console.ReadLine();
                //age = Int32.Parse(userInput.ToString());

                //Console.WriteLine(" Enter Computer Brand Name: ");
                //Console.ReadLine();
                //brand = userInput;

                PlayerOne.SetPlayerProperties(name, 15, brand);

                PlayerOne.DisplayInfo();


                // Create new playerTwo
                PlayerTwo = new Player();
                Console.WriteLine(" Enter Player2 Name: ");
                Console.ReadLine();
                name = userInput;

                //Console.WriteLine(" Enter Player2 Age: ");
                //Console.ReadLine();
                //age = Int32.Parse(userInput.ToString());

                //Console.WriteLine(" Enter Computer Brand Name: ");
                //Console.ReadLine();
                //brand = userInput;

                PlayerTwo.SetPlayerProperties(name, 23, brand);

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
        //public void chooseChoice1()
        //{

        //}

        //public void chooseChoice2()
        //{

        //}

        public void ComputeWinner(Player PlayerOne, Player PlayerTwo)
        {

            if (PlayerOne.chooseChoice == "Rock" && PlayerTwo.chooseChoice == "Scissors") {
                Console.WriteLine(" Player one win");
                PlayerOne.AddWinningScore();
            }

            if (PlayerOne.chooseChoice == "Scissors" && PlayerTwo.chooseChoice == "Rock")
            {
                Console.WriteLine(" Player two win");
                PlayerTwo.AddWinningScore();
            }

            //TODO: add more If statements here ...

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
            //Console.WriteLine("Choose Rock, Paper, Scissors, Lizard, or Spock to Play");
            //public string compChoice = Console.ReadLine().ToLower();

            //    startComputer = new startComputer();
            //    playerOne.chooseChoice();
            //}
            //Random choice = new Random();
            //int CompChoice = choice.Next(6);
            //        if (compChoice == 1)
            //            if (userChoice == "Rock")
            //                    {
            //                        Console.WriteLine(" Computer chose Rock");
            //                        Console.WriteLine(" It's a Draw");
            //                    }
            //                    else if (userChoice == "Paper")
            //                    {
            //                        Console.WriteLine(" Computer chose Paper");
            //                        Console.WriteLine(" It's a Draw");
            //                    }
            //                    else if (userChoice == "Scissors")
            //                    {
            //                        Console.WriteLine(" Computer chose Scissors");
            //                        Console.WriteLine(" It's a Draw");
            //                    }
            //                    else if (userChoice == "Lizard")
            //                    {
            //                        Console.WriteLine(" Computer chose Lizard");
            //                        Console.WriteLine(" It's a Draw");
            //                    }
            //                    else if (userChoice == "Spock")
            //                    {
            //                        Console.WriteLine(" Computer chose Spock");
            //                        Console.WriteLine(" It's a Draw");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, or Spock!");
            //                    }

            //                else if (compChoice == 2)
            //                {
            //                    if (userChoice == "Rock")
            //                    {
            //                        Console.WriteLine(" Computer chose Paper");
            //                        Console.WriteLine(" You lose, Paper covers Rock");

            //                    }
            //                    else if (userChoice == "paper")
            //                    {
            //                        Console.WriteLine(" Computer chose Scissors");
            //                        Console.WriteLine(" You lose, Scissors cuts Paper ");

            //                    }
            //                    else if (userChoice == "scissors")
            //                    {
            //                        Console.WriteLine(" Computer chose Lizard");
            //                        Console.WriteLine(" You won, Scissors decapitates Lizard");
            //                    }
            //                    else if (userChoice == "Lizard")
            //                    {
            //                        Console.WriteLine(" Computer chose Spock");
            //                        Console.WriteLine(" You Won, Lizard poisons Spock");
            //                    }
            //                    else if (userChoice == "Spock")
            //                    {
            //                        Console.WriteLine(" Computer chose Rock");
            //                        Console.WriteLine(" You won, Spock vaporizes Rock");
            //                    }

            //                    else
            //                    {
            //                        Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, or Spock!");
            //                    }
            //                }
            //                else if (compChoice == 3)
            //                {
            //                    if (userChoice == "Rock")
            //                    {
            //                        Console.WriteLine(" Computer chose Scissors");
            //                        Console.WriteLine(" You win, Rock crushes Scissors");

            //                    }
            //                    else if (userChoice == "paper")
            //                    {
            //                        Console.WriteLine(" Computer chose Lizard");
            //                        Console.WriteLine(" You lose, Lizard eats Paper");

            //                    }
            //                    else if (userChoice == "scissors")
            //                    {
            //                        Console.WriteLine(" Computer chose Spock");
            //                        Console.WriteLine(" You lose, Spock smashes Scissors");

            //                    }
            //                    else if (userChoice == "Lizard")
            //                    {
            //                        Console.WriteLine(" Computer chose Rock");
            //                        Console.WriteLine(" You won, Rock crushes Lizard ");
            //                    }
            //                    else if (userChoice == "Spock")
            //                    {
            //                        Console.WriteLine(" Computer chose Paper");
            //                        Console.WriteLine(" You lose, Paper disproves Spock");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, or Spock!");

            //                    }
            //                }
            //                else if (compChoice == 4)
            //                {
            //                    if (userChoice == "Rock")
            //                    {
            //                        Console.WriteLine(" Computer chose Lizard");
            //                        Console.WriteLine(" You win, Rock crushes Lizard");

            //                    }
            //                    else if (userChoice == "paper")
            //                    {
            //                        Console.WriteLine(" Computer chose Spock");
            //                        Console.WriteLine("You lose, Paper disproves Spock");

            //                    }
            //                    else if (userChoice == "scissors")
            //                    {
            //                        Console.WriteLine(" Computer chose Rock");
            //                        Console.WriteLine("You lose, Rock crushes Scissors");

            //                    }
            //                    else if (userChoice == "Lizard")
            //                    {
            //                        Console.WriteLine("Computer chose Paper");
            //                        Console.WriteLine("You won, Lizard eats Paper");
            //                    }
            //                    else if (userChoice == "Spock")
            //                    {
            //                        Console.WriteLine("Computer chose Scissors");
            //                        Console.WriteLine("You won, Spock smashes Scissors");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, or Spock!");

            //                    }
            //                }
            //                else if (compChoice == 5)
            //                {
            //                    if (userChoice == "Rock")
            //                    {
            //                        Console.WriteLine(" Computer chose Spock");
            //                        Console.WriteLine("You lose, Spock vaporizes Rock");

            //                    }
            //                    else if (userChoice == "paper")
            //                    {
            //                        Console.WriteLine(" Computer chose Rock");
            //                        Console.WriteLine(" You win, Paper covers Rock");

            //                    }
            //                    else if (userChoice == "scissors")
            //                    {
            //                        Console.WriteLine(" Computer chose Paper");
            //                        Console.WriteLine(" You won, Scissors cut Paper");

            //                    }
            //                    else if (userChoice == "Lizard")
            //                    {
            //                        Console.WriteLine(" Computer chose Scissors");
            //                        Console.WriteLine(" You lose, Scissors decapitates Lizard");
            //                    }
            //                    else if (userChoice == "Spock")
            //                    {
            //                        Console.WriteLine(" Computer chose Lizard");
            //                        Console.WriteLine(" You lose, Lizard poisons Spock");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, or Spock!");
            //                    }

            //                    Console.ReadKey();
            //                }
            //}
        }
    }
}









    