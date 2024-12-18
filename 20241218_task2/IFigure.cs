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
    internal interface IFigure
    {
        void CalculateSquare();
        void CalculatePerimeter();
    }
}
