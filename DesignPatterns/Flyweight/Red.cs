namespace Flyweight
{
    public class Red : Turtle
    {
        public Red()
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
