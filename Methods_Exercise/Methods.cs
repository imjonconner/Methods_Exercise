using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Exercise;

internal class Methods
{
    public static void Info()
    { 
        Console.WriteLine("What is your name?");  
        var name = Console.ReadLine();

        Console.WriteLine("what is your favorite color?");
        var color = Console.ReadLine();

        Console.WriteLine("what is your favorite animal?");
        var animal = Console.ReadLine();

        Console.WriteLine("what is your favorite band?");
        var band = Console.ReadLine();

        Console.WriteLine($"My name is {name}." +
                           $"My favorite color is {color}." +
                           $"My favorite animal is {animal}." +
                           $"My favorite band is {band}.");
    }
}
