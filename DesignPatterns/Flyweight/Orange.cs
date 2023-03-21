namespace Flyweight
{
    public class Orange : Turtle
    {
        public Orange()
        {
            condition = "Turtle is in hoof, ";
            action = "running on the ground - ";
        }

        public override void Show(string color)
        {
            this.color = color;

            Console.WriteLine($"{condition}{action}{color.ToUpper()}");
        }
    }
}
