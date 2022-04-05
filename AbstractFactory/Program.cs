using AbstractFactory.Factory;

namespace AbstractFactory
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            IBaseFactory factory;

            Console.Write("Chose one character: 1-Protoss | 2-Zergs | 3-Terranos: ");

            switch (Console.ReadLine())
            {
                case "1":
                    factory = new ProtossBaseFactory();
                    break;
                case "2":
                    factory = new ZergBaseFactory();
                    break;
                case "3":
                    factory = new TerranBaseFactory();
                    break;
            }

            Console.ReadLine();
        }
    }
}