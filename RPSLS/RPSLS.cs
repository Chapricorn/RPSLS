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
            RockPaper Game = new RockPaper();
            Game.gameRules();
            Game.playerOrComp();

            Game.chooseChoice();
            Game.chooseChoice2();
            Game.player1();
            Game.player2();

        }
    }
}
