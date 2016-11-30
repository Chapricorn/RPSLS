using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        // public properties
        public string _name;
       
        public int score;
        public string chooseChoice;

        /// <summary>
        /// Set  Property values
        /// </summary>
        /// <param name="name"></param>
     
        public void SetPlayerProperties(string name )
        {
            _name = name;         
            score = 0;
        }

        /// <summary>
        /// display player's information
        /// </summary>
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name: {0}", _name);          
        }

        /// <summary>
        /// add 1 to players score
        /// </summary>
        public void AddWinningScore()
        {
            score  += 1;  //this is equevelent to score = score + 1

        }
    }
}
