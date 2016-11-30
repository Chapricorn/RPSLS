using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public string name;
        public int age;
        public Human(string Name, int Age)
        {
            name = Name;
            age = Age;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
        }
    }
}