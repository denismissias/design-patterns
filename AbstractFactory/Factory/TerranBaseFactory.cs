namespace AbstractFactory
{
    public class TerranBaseFactory : IBaseFactory
    {
        public TerranBaseFactory()
        {
            CreateBase();
        }
        public void CreateBase()
        {
            Console.WriteLine("Success Terran base created");

            TerranBaseCoating coating = new TerranBaseCoating();
            coating.Composition();

            TerranBaseEnergy energy = new TerranBaseEnergy();
            energy.Composition();
        }
    }
}