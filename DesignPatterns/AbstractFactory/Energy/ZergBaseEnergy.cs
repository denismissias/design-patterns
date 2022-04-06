namespace AbstractFactory.Energy
{
    public class ZergBaseEnergy : IEnergy
    {
        public void Composition()
        {
            Console.WriteLine("Base support energy by ground");
        }
    }
}