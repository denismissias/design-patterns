using System;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod factoryMethod = new FactoryMethod();
            
            Console.WriteLine("Liu Kang | SubZero | Scorpion");
            Console.WriteLine();

            Console.WriteLine("Select your Character: ");
            string? selected = Console.ReadLine();

            ICharacter? character = factoryMethod.SelectCharacter(selected);

            Console.WriteLine();
            Console.WriteLine("You'll play with ");
            character?.Selected();

            Console.ReadKey();
        }
    }
}