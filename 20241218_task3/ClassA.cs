using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241218_task3
{
    /*
         Напишите программу, в которой будет описан интерфейс с методом без аргументов, 
        который возвращает результатом целое число. На основе интерфейса создайте два класса. 
        У каждого класса должно быть целочисленное поле. 
        В первом классе метод результатом возвращает сумму четных чисел, 
        во втором классе метод возвращает результатом сумму нечетных чисел. 
        Количество слагаемых в сумме определяется полем объекта, из которого вызывается метод. 
        Проверьте работу метода, получив доступ к объекту класса через объектную переменную и через интерфейсную переменную.
     */
    public class ClassA : ICalculate
    {
        public int NumberOfEvenNumbers { get; set; }

        public ClassA(int numberOfEvenNumbers)
        {
            NumberOfEvenNumbers = numberOfEvenNumbers;
        }
        public int Calculate()
        {
            int[] numbers = new int[NumberOfEvenNumbers];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    numbers[i] = 0;
                }
                else
                {
                    numbers[i] = numbers[i - 1] + 2;
                }
            }
            
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }
    }
}
