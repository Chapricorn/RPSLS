using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer
    {
        public string _name;
      

        public Computer(string name)
        {
            _name = name;
      
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name: {0}", _name);
       
        }
    }
}
