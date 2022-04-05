using FactoryMethod.Characters;

namespace FactoryMethod
{
    public class FactoryMethod
    {
        public ICharacter? SelectCharacter(string? character)
        {
            switch (character)
            {
                case "Liu Kang": return new LiuKang();
                case "SubZero": return new SubZero();
                case "Scorpion": return new Scorpion();
                default: return null;
            }
        }
    }
}