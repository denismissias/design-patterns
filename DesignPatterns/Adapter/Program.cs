using Adapter;

Character character = new();

Airplane airplane = new();

IAction adapter = new Adapter.Adapter(airplane);

Console.WriteLine("---WALKING---");

character.Walk("Character");
character.Shoot();

Console.WriteLine("---FLYING---");

adapter.Walk("Character");
adapter.Shoot();

Console.ReadKey();
