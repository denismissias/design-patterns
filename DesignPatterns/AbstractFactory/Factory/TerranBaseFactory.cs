using AbstractFactory.Coating;
using AbstractFactory.Energy;

namespace AbstractFactory.Factory
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

            ICoating coating = new TerranBaseCoating();
            coating.Composition();

            IEnergy energy = new TerranBaseEnergy();
            energy.Composition();
        }
    }
}