namespace Flyweight
{
    public abstract class Turtle
    {
        protected string condition;
        protected string action;
        public string color;

        public abstract void Show(string color);
    }
}
