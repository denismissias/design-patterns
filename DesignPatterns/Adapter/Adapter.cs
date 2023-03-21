namespace Adapter
{
    public class Adapter : IAction
    {
        Airplane airplane;

        public Adapter(Airplane airplane)
        {
            this.airplane = airplane;
        }

        public void Shoot()
        {
            this.airplane.FireMissile();
        }

        public void Walk(string player)
        {
            this.airplane.Fly(player);
        }
    }
}
