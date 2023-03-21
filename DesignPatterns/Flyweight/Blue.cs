namespace Flyweight
{
    public class Blue : Turtle
    {
        public Blue()
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
