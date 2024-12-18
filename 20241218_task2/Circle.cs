using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241218_task2
{
    /*
         Есть классы геометрических фигур «Прямоугольник» и «Окружность». 
        У обоих классов должны быть методы вычисления периметра и площади. 
        Создать их, используя общий интерфейс.
    */
    public class Circle : IFigure
    {
        public string Name { get; set; }
        public double Radius { get; set; }
        public Circle(string name, double r)
        {
            Name = name;
            Radius = r;
        }
        public void CalculatePerimeter()
        {
            Console.WriteLine($"Perimeter for circle {Name} is {Math.Round((2 * Radius * Math.PI), 2)} cm");
        }

        public void CalculateSquare()
        {
            Console.WriteLine($"Square for circle {Name} is {Math.Round((Math.PI * Radius * Radius), 2)} cm2");
        }
        public override string ToString()
        {
            return $"Circle {Name}: r = {Radius} cm";
        }
    }
}
