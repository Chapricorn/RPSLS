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
        public int _age;
        public string _brand;
        public int score;
        public string chooseChoice;

        /// <summary>
        /// Set  Property values
        /// </summary>
        /// <param name="name"></param>
        /// <param name="Age"></param>
        /// <param name="brand"></param>
        public void SetPlayerProperties(string name, int Age, string brand )
        {
            _name = name;
            _age = Age;
            _brand = brand;
            score = 0;

        }

        /// <summary>
        /// display player's information
        /// </summary>
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name: {0}", _name);
            Console.WriteLine("Age: {0}", _age);
            Console.WriteLine("Brand: {0}", _brand);
          
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
