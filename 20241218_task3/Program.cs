namespace _20241218_task3
{
    internal class Program
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
        static void Main(string[] args)
        {
            ClassA a1 = new ClassA(10);
            ClassA a2 = new ClassA(5);
            ClassB b1 = new ClassB(12);
            ClassB b2 = new ClassB(3);

            Console.WriteLine("From class object:");
            Console.WriteLine(a1.Calculate());
            Console.WriteLine(a2.Calculate());
            Console.WriteLine(b1.Calculate());
            Console.WriteLine(b2.Calculate());

            Console.WriteLine("From interface object:");

            ICalculate[] calculates = { a1, a2, b1, b2 };

            for (int i = 0; i < calculates.Length; i++)
            {
                Console.WriteLine(calculates[i].Calculate());
            }

        }
    }
}
