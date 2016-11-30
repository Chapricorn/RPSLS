using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new players
            Player PlayerOne = new Player();
            Player PlayerTwo = new Player();
            Player Computer = new Player();

            // create new game
            Game game = new Game();
            game.gameRules();
            game.playerOrComp(PlayerOne, PlayerTwo);
            //game.startComputer();
         
            // choose choice for players
            // while no player is winning, continue playing
            //while (PlayerOne.score < 2 && PlayerTwo.score < 2)
            {
                game.chooseChoiceForPlayerOne(PlayerOne);
                game.chooseChoiceForPlayerTwo(PlayerTwo);
                game.ComputeWinner(PlayerOne, PlayerTwo);
            }

            //game.startComputer();

        }
    }
}
