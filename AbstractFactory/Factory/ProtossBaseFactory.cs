using AbstractFactory.Coating;
using AbstractFactory.Energy;

namespace AbstractFactory.Factory
{
    public class ProtossBaseFactory : IBaseFactory
    {
        public ProtossBaseFactory()
        {
            CreateBase();
        }
        public void CreateBase()
        {
            Console.WriteLine("Success Protoss base created");

            ProtossBaseCoating coating = new ProtossBaseCoating();
            coating.Composition();

            ProtossBaseEnergy energy = new ProtossBaseEnergy();
            energy.Composition();
        }
    }
}