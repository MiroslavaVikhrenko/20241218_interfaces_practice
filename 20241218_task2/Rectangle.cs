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
    public class Rectangle : IFigure
    {
        public string Name { get; set; }
        public double SideA {  get; set; }
        public double SideB { get; set; }
        public Rectangle(string name, double a, double b)
        {
            Name = name;
            SideA = a;
            SideB = b;
        }
        public void CalculatePerimeter()
        {
            Console.WriteLine($"Perimeter for rectangle {Name} is {(SideA + SideB) * 2} cm");
        }

        public void CalculateSquare()
        {
            Console.WriteLine($"Square for rectangle {Name} is {SideA * SideB} cm2");
        }

        public override string ToString()
        {
            return $"Rectangle {Name}: a = {SideA} cm, b = {SideB} cm";
        }
    }
}
