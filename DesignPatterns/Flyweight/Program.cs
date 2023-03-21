using Flyweight;
using System.Drawing;

var flyweight = new Flyweight.Flyweight();

Turtle turtle;

while (true)
{
    Console.WriteLine();
    Console.Write("What turtle send to screen: ");
    string? color = Console.ReadLine();
    turtle = flyweight.GetTurtle(color);
    turtle.Show(color);
    Console.WriteLine();
    Console.WriteLine("----------------------------");
}
