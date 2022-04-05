namespace AbstractFactory.Energy
{
    public class ProtossBaseEnergy : IEnergy
    {
        public void Composition()
        {
            Console.WriteLine("Base supporting energy with crystals");
        }
    }
}