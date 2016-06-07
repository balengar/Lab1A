using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1A
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;
            System.Console.Write("What is your name? ");
            name = System.Console.ReadLine();
            System.Console.Write("What is your age? ");
            age = System.Console.ReadLine();
            System.Console.WriteLine("Welcome, "+name+", age "+age+".");
            System.Console.Write("Press any key to quit.");
            System.Console.ReadKey();
        }
    }
}
