using SomeOptionalParamThings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCar
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Car("Blue");

            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}
