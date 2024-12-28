namespace _20241228_task15
{
    internal class Program
    {
        /*
         Создайте интерфейс, содержащий описание методов для нахождения суммы цифр числа и 
        определение количества нулей в записи числа. На основе этого интерфейса создайте классы, 
        содержащие реализацию методов интерфейса в случае целого и действительного чисел.
         */
        static void Main(string[] args)
        {
            Class1 c1 = new Class1(1209470023);
            Console.WriteLine($"Number: {c1.Number}, type: {c1.Number.GetType()}");
            Console.WriteLine($"Zeros: {c1.CountZeros()}");
            Console.WriteLine($"Digits' sum: {c1.SumDigits()}\n\n");

            Class2 c2 = new Class2(56808708.45);
            Console.WriteLine($"Number: {c2.Number}, type: {c2.Number.GetType()}");
            Console.WriteLine($"Zeros: {c2.CountZeros()}");
            Console.WriteLine($"Digits' sum: {c2.SumDigits()}");


            Console.ReadKey();
        }
    }
}
