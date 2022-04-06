using Builder.Creators;

namespace Builder
{
    internal static class Program
    {
        private static void Main()
        {
            var army = new Army();

            SoldierBuilder soldierBuilder = new SpecialForcesBuilder();

            ShowCreatedSoldier(army, soldierBuilder);
            
            soldierBuilder = new LightInfantaryBuilder();
            
            ShowCreatedSoldier(army, soldierBuilder);

            Console.ReadKey();
        }

        private static void ShowCreatedSoldier(Army army, SoldierBuilder soldierBuilder)
        {
            army.BuildSoldier(soldierBuilder);

            var soldier = soldierBuilder.GetSoldier();

            Console.WriteLine($"Soldier with characteristics: {soldier?.Gun}, {soldier?.Transport}, {soldier?.Focus}");
        }
    }
}