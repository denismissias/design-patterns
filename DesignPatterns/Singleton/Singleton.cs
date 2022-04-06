namespace Singleton;

public sealed class Singleton
{
    private static Singleton? _instance;

    public static Singleton? GetInstance
    {
        get
        {
            if (_instance != null) return _instance;
            _instance = new Singleton();
            Console.WriteLine("Bola em jogo");

            return _instance;
        }
    }

    public void Message(string message)
    {
        Console.WriteLine(message);
    }
}