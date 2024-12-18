namespace _20241218_task2
{
    internal class Program
    {
        /*
         Есть классы геометрических фигур «Прямоугольник» и «Окружность». 
        У обоих классов должны быть методы вычисления периметра и площади. 
        Создать их, используя общий интерфейс.
         */
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle("Black", 10, 5);
            Rectangle r2 = new Rectangle("Yellow", 4, 7);
            Circle c1 = new Circle("Pink", 10);
            Circle c2 = new Circle("Green", 7);

            IFigure[] figures = {r1, r2, c1 , c2 };

            for (int i = 0; i < figures.Length; i++)
            {
                Console.WriteLine("---------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(figures[i].ToString());
                Console.ResetColor();
                Console.WriteLine("---------------------------");
                figures[i].CalculateSquare();
                figures[i].CalculatePerimeter();
            }
        }
    }
}
