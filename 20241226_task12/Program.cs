using System.Numerics;

namespace _20241226_task12
{
    internal class Program
    {
        /*
         Определить обобщенный интерфейс для арифметических операций. Реализовать интерфейс в двух классах: 
        один с универсальным параметром, второй с явным типом int. Использовать оба класса в программе.
         */
        static void Main(string[] args)
        {
            Math2 m2 = new Math2();

            Console.WriteLine($"math 2 int class (Sum): {m2.Sum(5, 2)}, (Mult) {m2.Mult(5, 2)}" );

            Math1<int> m1 = new Math1<int>();

            Console.WriteLine($"math 1 generic class (Sum): {m1.Sum(5, 2)}, (Mult) {m1.Mult(5, 2)}");

            Console.ReadKey();
        }
    }

    public interface IMath<T> 
    {
        T Sum(T x, T y);
        T Mult(T x, T y);
    }

    public class Math1<T> : IMath<T> where T : INumber<T>
    {
        public T Mult(T x, T y)
        {
            return x * y;
        }

        public T Sum(T x, T y)
        {
            return x + y;
        }
    }

    public class Math2 : IMath<int>
    {
        public int Mult(int x, int y)
        {
            return x * y;
        }

        public int Sum(int x, int y)
        {
            return x * y;
        }
    }
}
