namespace FruitMachine

{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.CreateReels();
            game.Render();
            
            Controls controls = new Controls(game);
            controls.GetInput();
        }
    }
}