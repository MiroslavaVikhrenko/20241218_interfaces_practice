namespace _20241228_task14
{
    internal class Program
    {
        /*Создать массив и заполнить случайными числами. 
         * Описать метод расширения, определяющий четное ли число. 
         * Вывести только четные числа, используя этот метод.*/
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 5, 0, 2, 1, 4 };

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].IsEven())
                {
                    Console.WriteLine(array[i]);
                }
            }

            Console.ReadKey();
        }
    }

    public static class IntExtensions
    {
        public static bool IsEven(this int x)
        {
            if (x %  2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
