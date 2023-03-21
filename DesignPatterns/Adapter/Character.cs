namespace Adapter
{
    public class Character : IAction
    {
        public void Shoot()
        {
            Console.WriteLine("Shooting in game!");
        }

        public void Walk(string player)
        {
            Console.WriteLine($"{player} walked forward!");
        }
    }
}
