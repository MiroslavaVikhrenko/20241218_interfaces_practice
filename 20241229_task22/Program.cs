using System;

namespace _20241229_task22
{
    internal class Program
    {
        /*
         Разработайте класс «MyExtension», который объявляет следующие методы расширения:
        1). Метод «SummaDigit», который расширяет тип Int32 и возвращает сумму цифры произвольного целого числа. 
        Пример: n = 1274, результат = 14 (14 = 1 + 2 + 7 +4).

        2) Метод «SummaWithReverse», который расширяет тип UInt32 и возвращает сумму исходного 
        положительного целого числа с числом, полученным из оригинала переставляем все цифры 
        в обратном порядке Пример: n = 132 результат = 363 (363 = 132 + 231).
         */
        static void Main(string[] args)
        {
            int n = 1274;
            Console.WriteLine(n.SumDigit());

            uint n2 = 132;
            Console.WriteLine(n2.SumWithReverse());

            Console.ReadKey();
        }
    }

    public static class Extensions
    {
        public static int SumDigit(this int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        public static uint SumWithReverse(this uint n)
        {
            uint sum = n;
            uint n2 = 0;
            while (n > 0)
            {
                n2 = n2 * 10 + n % 10;
                n /= 10;
            }

            return sum + n2;
        }
    }
}
