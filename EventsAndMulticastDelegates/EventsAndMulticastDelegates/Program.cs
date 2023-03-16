namespace EventsAndMulticastDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RenderingEngine renderingEngine = new RenderingEngine();
            AudioSystem audioSystem = new AudioSystem();
            

            Player player1 = new Player("PEWPEW");
            Player player2 = new Player("Amachuchi");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is running... Press any key to end the game");

            Console.ReadKey();
            Console.WriteLine();
            
            GameEventManager.TriggerGameOver();
        }
    }
}