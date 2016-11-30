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
        public int _age;
        public string _brand;

        public Computer(string name, int Age, string brand)
        {
            _name = name;
            _age = Age;
            _brand = brand;

        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name: {0}", _name);
            Console.WriteLine("Age: {0}", _age);
            Console.WriteLine("Brand: {0}", _brand);

        }
    }
}
