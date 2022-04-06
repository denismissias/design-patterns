namespace Singleton
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var player1 = Singleton.GetInstance;
            player1?.Message("Player 1: A bola está comigo no meio campo.");
            
            var player2 = Singleton.GetInstance;
            player2?.Message("Player 2: Recebeu a bola.");
            
            var player3 = Singleton.GetInstance;
            player3?.Message("Player 3: Recebeu o lançamento na linha de fundo.");

            Console.ReadKey();
        }
    }
}