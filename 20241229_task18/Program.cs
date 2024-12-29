using System.Diagnostics;

namespace _20241229_task18
{
    internal class Program
    {
        /*
         Описать класс «Game», который содержит свойства: name, price. 
        Описать класс «GameStop», содержащий свойства: name, gamescount, Game game(объект класса Game). 
        Используя интерфейс ICloneable, присвоить значение одного объекта – 
        другому, чтобы объекты не были связаны ссылкой.
         */
        static void Main(string[] args)
        {
            Game g1 = new Game("Monopoly", 100.0m);
            Game g2 = new Game("Chess", 80.0m);

            GameShop gs1 = new GameShop("Game Shop 1", 10, g1);

            Console.WriteLine($"Original gs1 :\n {gs1}");


            GameShop gs2 = (GameShop)gs1.Clone();

            Console.WriteLine($"\n\nOriginal gs2 after cloning from gs1 :\n {gs2}");

            gs2.Game = g2;
            gs2.Name = "Game Shop 2";
            gs2.GameCount = 5;


            Console.WriteLine($"\n\nUpdated gs2 :\n {gs2}");
            Console.WriteLine($"\n\ngs1 after only gs2 was updated :\n {gs1}");

            Console.ReadKey();
        }
    }

    public class Game 
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Game(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Game: {Name}, price {Price} CAD";
        }
    }

    public class GameShop : ICloneable
    {
        public string Name { get; set; }
        public int GameCount { get; set; }
        public Game Game { get; set; }
        public GameShop(string name, int count, Game game)
        {
            Name = name;
            GameCount = count;
            Game = game;
        }
        public override string ToString()
        {
            return $"Game shop: {Name}, count {GameCount}, {Game}";
        }

        public object Clone()
        {
            //return new GameShop(Name, GameCount, Game);
            return this.MemberwiseClone();
        }
    }
}
