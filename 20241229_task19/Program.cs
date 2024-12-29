namespace _20241229_task19
{
    internal class Program
    {
        /*
         Написать класс сравнения чисел, реализующий интерфейс сравнения IComparer<int>, 
        который сортирует числа следующим образом: 

        Все пятерки сначала 
        Все четверки в конце 
        Все остальные числа по возрастанию
         */
        static void Main(string[] args)
        {
            Number[] numbers =
            {
                new Number(){Value = 4},
                new Number(){Value = 5},
                new Number(){Value = 9},
                new Number(){Value = 7},
                new Number(){Value = 5},
                new Number(){Value = 5},
                new Number(){Value = 1},
                new Number(){Value = 2},
                new Number(){Value = 5},
                new Number(){Value = 4},
                new Number(){Value = 4}
            };

            Console.WriteLine("-------------Original Array-------------");
            PrintArray(numbers);

            Array.Sort(numbers);

            Console.WriteLine("\n-------------Sorted Array-------------");
            PrintArray(numbers);

            Console.ReadKey();
        }

        public static void PrintArray(Number[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i].Value == nums.Length - 1)
                {
                    Console.Write($"{nums[i].Value}");
                }
                else
                {
                    Console.Write($"{nums[i].Value} | ");
                }
            }
        }
    }

    public class Number : IComparable
    {
        public int Value { get; set; }

        public int CompareTo(object? obj)
        {
            //     Less than zero – This instance precedes other in the sort order.
            //     Zero – This instance occurs in the same position in the sort order as other.
            //
            //     Greater than zero – This instance follows other in the sort order.

            Number n = obj as Number;

            if (n != null)
            {
                if (Value == 5)
                {
                    return -1;
                }
                else if (n.Value == 5)
                {
                    return 1;
                }
                else if (Value == 4)
                {
                    return 1;
                }
                else if (n.Value == 4)
                {
                    return -1;
                }
                else
                {
                    return Value.CompareTo(n.Value);
                }
                
            }
            else
            {
                throw new Exception("Cannot compare these objects");
            }
        }
    }

}
