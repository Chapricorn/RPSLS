using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        
        public Human()
        {
            
        }
        public override void GetName()
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
        }
        public override void MakeChoice()
        {
            Console.WriteLine("Enter: Paper, Rock, Scissors, Lizard, or Spock.");
            choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "paper":
                    Console.WriteLine(" Player have chosen: " + choice + "! \n");
                    break;
                case "rock":
                    Console.WriteLine(" Player have chosen:  " + choice + "! \n");
                    break;
                case "scissors":
                    Console.WriteLine(" Player have chosen: " + choice + "! \n");
                    break;
                case "lizard":
                    Console.WriteLine(" Player have chosen:  " + choice + "! \n");
                    break;
                case "spock":
                    Console.WriteLine(" Player have chosen:  " + choice + "! \n");
                    break;
                default:
                    Console.WriteLine(" Please chose a choice! ");
                    MakeChoice();
                    break;
            }
        }
    }
}