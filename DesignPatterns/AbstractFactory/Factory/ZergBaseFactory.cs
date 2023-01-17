using AbstractFactory.Coating;
using AbstractFactory.Energy;

namespace AbstractFactory.Factory
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

            ICoating coating = new ZergBaseCoating();
            coating.Composition();

            IEnergy energy = new ZergBaseEnergy();
            energy.Composition();
        }
    }
}