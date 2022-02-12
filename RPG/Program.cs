using System;
using RPG.src.Entities;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            var arus = new Knight("Arus", 23, "Knight" );
            var wizard = new Wizard("Jennica", 23, "White Wizard ");
            
            Console.WriteLine($"{arus}");
            Console.WriteLine($"{wizard.Attack(1)}");
            Console.WriteLine($"{wizard.Attack(7)}");
        }
    }
}