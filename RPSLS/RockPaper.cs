using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class RockPaper
    {
        public void gameRules()
        {
            Console.WriteLine(" Thank You for choosing The RPSLS Game, here are the Rules: ");
            Console.ReadLine();
            Console.WriteLine(" Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, ");
            Console.WriteLine(" Spock smashes Scissors, Scissors decapitates Lizard, Lizard eats Paper, ");
            Console.WriteLine(" Paper disproves Spock, Spock vaporizes Rock, and Rock crushes Scissors. ");
            Console.ReadLine();
        }

        public void playerOrComp()
        {

            Console.WriteLine(" Do you want to verse another Player OR verse the Computer?");
            string input = Console.ReadLine();

            switch (input)
            {
                case "player":
                    Console.WriteLine(" You are playing against another Player");
                    Console.ReadLine();
                    break;

                case "computer":
                    Console.WriteLine(" You are playing against Computer");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine(" Please choose Opponent: Player or Computer");
                    playerOrComp();
                    break;
            }
        }


        public void player1()
        {
            Console.WriteLine();
        }


        public void chooseChoice()
        {
            Console.WriteLine("Player1 Enter: Paper, Rock, Scissors, Lizard, or Spock.");
            string player1choice = Console.ReadLine();

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

                    break;
            }
        }
        public void player2()
        {
            Console.WriteLine();
        }


        public void chooseChoice2()
        {
            Console.WriteLine("Player2 Enter: Paper, Rock, Scissors, Lizard, or Spock.");
            string player2choice = Console.ReadLine();

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

                    break;
            
            }
        


                    Console.WriteLine("Choose Rock, Paper, Scissors, Lizard, or Spock to Play");
                    string userChoice = Console.ReadLine();

                    Random choice = new Random();
                    int CompChoice = choice.Next(6);
                    if (CompChoice == 1)
                    {
                        if (userChoice == "Rock")
                        {
                            Console.WriteLine(" Computer chose Rock");
                            Console.WriteLine(" It's a Draw");
                        }
                        else if (userChoice == "Paper")
                        {
                            Console.WriteLine(" Computer chose Paper");
                            Console.WriteLine(" It's a Draw");
                        }
                        else if (userChoice == "Scissors")
                        {
                            Console.WriteLine(" Computer chose Scissors");
                            Console.WriteLine(" It's a Draw");
                        }
                        else if (userChoice == "Lizard")
                        {
                            Console.WriteLine(" Computer chose Lizard");
                            Console.WriteLine(" It's a Draw");
                        }
                        else if (userChoice == "Spock")
                        {
                            Console.WriteLine(" Computer chose Spock");
                            Console.WriteLine(" It's a Draw");
                        }
                        else
                        {
                            Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, or Spock!");
                        }
                    }
                    else if (CompChoice == 2)
                    {
                        if (userChoice == "Rock")
                        {
                            Console.WriteLine(" Computer chose Paper");
                            Console.WriteLine(" You lose, Paper covers Rock");

                        }
                        else if (userChoice == "paper")
                        {
                            Console.WriteLine(" Computer chose Scissors");
                            Console.WriteLine(" You lose, Scissors cuts Paper ");

                        }
                        else if (userChoice == "scissors")
                        {
                            Console.WriteLine(" Computer chose Lizard");
                            Console.WriteLine(" You won, Scissors decapitates Lizard");
                        }
                        else if (userChoice == "Lizard")
                        {
                            Console.WriteLine(" Computer chose Spock");
                            Console.WriteLine(" You Won, Lizard poisons Spock");
                        }
                        else if (userChoice == "Spock")
                        {
                            Console.WriteLine(" Computer chose Rock");
                            Console.WriteLine(" You won, Spock vaporizes Rock");
                        }

                        else
                        {
                            Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, or Spock!");
                        }
                    }
                    else if (CompChoice == 3)
                    {
                        if (userChoice == "Rock")
                        {
                            Console.WriteLine(" Computer chose Scissors");
                            Console.WriteLine(" You win, Rock crushes Scissors");

                        }
                        else if (userChoice == "paper")
                        {
                            Console.WriteLine(" Computer chose Lizard");
                            Console.WriteLine(" You lose, Lizard eats Paper");

                        }
                        else if (userChoice == "scissors")
                        {
                            Console.WriteLine(" Computer chose Spock");
                            Console.WriteLine(" You lose, Spock smashes Scissors");

                        }
                        else if (userChoice == "Lizard")
                        {
                            Console.WriteLine(" Computer chose Rock");
                            Console.WriteLine(" You won, Rock crushes Lizard ");
                        }
                        else if (userChoice == "Spock")
                        {
                            Console.WriteLine(" Computer chose Paper");
                            Console.WriteLine(" You lose, Paper disproves Spock");
                        }
                        else
                        {
                            Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, or Spock!");

                        }
                    }
                    else if (CompChoice == 4)
                    {
                        if (userChoice == "Rock")
                        {
                            Console.WriteLine(" Computer chose Lizard");
                            Console.WriteLine(" You win, Rock crushes Lizard");

                        }
                        else if (userChoice == "paper")
                        {
                            Console.WriteLine(" Computer chose Spock");
                            Console.WriteLine("You lose, Paper disproves Spock");

                        }
                        else if (userChoice == "scissors")
                        {
                            Console.WriteLine(" Computer chose Rock");
                            Console.WriteLine("You lose, Rock crushes Scissors");

                        }
                        else if (userChoice == "Lizard")
                        {
                            Console.WriteLine("Computer chose Paper");
                            Console.WriteLine("You won, Lizard eats Paper");
                        }
                        else if (userChoice == "Spock")
                        {
                            Console.WriteLine("Computer chose Scissors");
                            Console.WriteLine("You won, Spock smashes Scissors");
                        }
                        else
                        {
                            Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, or Spock!");

                        }
                    }
                    else if (CompChoice == 5)
                    {
                        if (userChoice == "Rock")
                        {
                            Console.WriteLine(" Computer chose Spock");
                            Console.WriteLine("You lose, Spock vaporizes Rock");

                        }
                        else if (userChoice == "paper")
                        {
                            Console.WriteLine(" Computer chose Rock");
                            Console.WriteLine(" You win, Paper covers Rock");

                        }
                        else if (userChoice == "scissors")
                        {
                            Console.WriteLine(" Computer chose Paper");
                            Console.WriteLine(" You won, Scissors cut Paper");

                        }
                        else if (userChoice == "Lizard")
                        {
                            Console.WriteLine(" Computer chose Scissors");
                            Console.WriteLine(" You lose, Scissors decapitates Lizard");
                        }
                        else if (userChoice == "Spock")
                        {
                            Console.WriteLine(" Computer chose Lizard");
                            Console.WriteLine(" You lose, Lizard poisons Spock");
                        }
                        else
                        {
                            Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, or Spock!");
                        }

                        Console.ReadKey();
                    }
                }
            }
        }

                

        

    


    