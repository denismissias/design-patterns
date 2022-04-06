using System;

namespace FactoryMethod
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var factoryMethod = new FactoryMethod();
            
            Console.WriteLine("Liu Kang | SubZero | Scorpion");
            Console.WriteLine();

            Console.WriteLine("Select your Character: ");
            var selected = Console.ReadLine();

            var character = factoryMethod.SelectCharacter(selected);

            Console.WriteLine();
            Console.WriteLine("You'll play with ");
            character?.Selected();

            Console.ReadKey();
        }
    }
}