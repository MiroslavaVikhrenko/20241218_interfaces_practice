using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace _20241219_task8
{
    /*
     * Создайте интерфейс «IMath». В нём должно быть четыре метода: 

    ■ int Max() — возвращает максимум; 
    ■ int Min() — возвращает минимум;
    ■ float Avg() — возвращает среднеарифметическое; 
    ■ bool Search(int valueToSearch) — ищет valueSearch внутри контейнера данных.
    Возвращает true, если значение найдено. Возвращает false, если значение не найдено.

    Класс, созданный в первом задании «Array», должен имплементировать интерфейс «IMath». 

    Метод Max — возвращает максимум среди элементов массива. 
    Метод Min — возвращает минимум среди элементов массива. 
    Метод Avg — возвращает среднеарифметическое среди элементов массива. 
    Метод Search — ищет значение внутри массива. Возвращает true, если значение найдено. Возвращает false, если значение не найдено. Напишите код для тестирования полученной функциональности.
     */
    internal class ClassArray : IMath
    {
        public string Name { get; set; }
        public int[] Numbers {  get; set; }

        public int Max()
        {
            int max = Numbers[0];
            int elementNumber = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] > max)
                {
                    max = Numbers[i];
                    elementNumber = i;
                }
            }
            return Numbers[elementNumber];
        }

        public int Min()
        {
            int min = Numbers[0];
            int elementNumber = 0;
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] < min)
                {
                    min = Numbers[i];
                    elementNumber = i;
                }
            }
            return Numbers[elementNumber];
        }

        public float Avg()
        {
            int sum = 0;

            for (int i = 0;i < Numbers.Length;i++)
            {
                sum += Numbers[i];
            }

            return (float)(sum / Numbers.Length);
        }

        public bool Search(int valueToSearch)
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (valueToSearch == Numbers[i])
                {
                    Console.WriteLine($"{valueToSearch} was found in array!");
                    return true;
                }
            }

            Console.WriteLine($"{valueToSearch} was NOT found in array!");
            return false;
        }
    }
}
