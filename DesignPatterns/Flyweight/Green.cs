namespace Flyweight
{
    public class Green : Turtle
    {
        public Green()
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
