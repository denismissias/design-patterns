namespace Adapter
{
    public class Airplane
    {
        public void Fly(string character)
        {
            Console.WriteLine($"{character} flying forward!");
        }

        public void FireMissile()
        {
            Console.WriteLine("Fired missile in the game!");
        }
    }
}
