namespace _20241219_task8
{
    internal class Program
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
        static void Main(string[] args)
        {
            ClassArray array = new ClassArray { Numbers = new int[]{ 10, 5, 2, 11, 18, 20, 70 } , Name = "My array"};
            Console.WriteLine("\n-----------Original Array-----------\n");
            PrintArray(array);

            Console.WriteLine("\n\n-----------Max-----------\n");
            Console.WriteLine(array.Max());

            Console.WriteLine("\n-----------Min-----------\n");
            Console.WriteLine(array.Min());

            Console.WriteLine("\n-----------Avg-----------\n");
            Console.WriteLine(array.Avg());

            try
            {
                Console.WriteLine("\nEnter a number to search\n");
                int valueToSearch = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"-----------Searching for {valueToSearch}-----------\n");
                Console.WriteLine($"Result of searching opration: {array.Search(valueToSearch)}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        public static void PrintArray(ClassArray array)
        {
            for (int i = 0; i < array.Numbers.Length; i++)
            {
                if (i == array.Numbers.Length - 1)
                {
                    Console.Write($"{array.Numbers[i]}");
                }
                else
                {
                    Console.Write($"{array.Numbers[i]} | ");
                }
                
            }
        }
    }
}
