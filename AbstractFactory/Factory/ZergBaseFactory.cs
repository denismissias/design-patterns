namespace AbstractFactory
{
    public class ZergBaseFactory : IBaseFactory
    {
        public ZergBaseFactory()
        {
            CreateBase();
        }
        public void CreateBase()
        {
            Console.WriteLine("Success Zerg base created");

            ZergBaseCoating coating = new ZergBaseCoating();
            coating.Composition();

            ZergBaseEnergy energy = new ZergBaseEnergy();
            energy.Composition();
        }
    }
}