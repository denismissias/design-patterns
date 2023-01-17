namespace Prototype
{
    public class Cloud : CloudTemplate
    {
        private readonly string _fillCollor;
        private readonly string _lineCollor;

        public Cloud(string fill, string line) 
        {
            _fillCollor = fill;
            _lineCollor = line;
        }

        public string LineCollor => _lineCollor;

        public string FillCollor => _fillCollor;

        public override CloudTemplate Clone()
        {
            Console.WriteLine($"The cloned cloud has line {_lineCollor} e fill {_fillCollor}");

            return MemberwiseClone() as CloudTemplate;
        }
    }
}
