namespace Class
{
    class Game
    {
        public string name;
        public string jenre;
        public int release;
        public string developer;
        public string platform;
    }

    class Program
    {
        static Game GetGame()
        {
            Game game = new Game();

            game.name = "Ведьмак 3: Дикая Охота";
            game.jenre = "RPG, Action, Fantasy";
            game.release = 2015;
            game.developer = "CD Projekt RED";
            game.platform = "Windows, Playstation 4,5";

            return game;
        }
        
        static Game GetGame2()
        {
            Game game = new Game();

            game.name = "GTA V";
            game.jenre = "Action, Adventure";
            game.release = 2013;
            game.developer = "Rockstar Games";
            game.platform = "Windows, Playstation 4,5";

            return game;
        }

        static void Print(Game game) 
        {
            Console.WriteLine("Название: " + game.name);
            Console.WriteLine("Жанр: " + game.jenre);
            Console.WriteLine("Дата выпуска: " + game.release);
            Console.WriteLine("Разрабртчики: " + game.developer);
            Console.WriteLine("Платформа: " + game.platform);
        }

        static void Main(string[] args) 
        { 
            Game game1 = GetGame();
            Game game2 = GetGame2();

            Print(game1);
            Console.WriteLine("\n");
            Print(game2);
        }
    }
}