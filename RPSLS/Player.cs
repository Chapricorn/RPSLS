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
        public string name;       
        public int score;
        public string choice;
     
        public void SetPlayerProperties()
        {
            //name = Name;         
            score = 0;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name: {0}", name);          
        }

        public void AddWinningScore()
        {
            score = score + 1;  

        }
        public virtual void MakeChoice()
        {

        }
        public virtual void GetName()
        {
            
        }
    }
}
