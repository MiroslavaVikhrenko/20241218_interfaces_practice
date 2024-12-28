using System.Collections;

namespace _20241228_task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass c = new MyClass();

            foreach (var item in c)
            {
                Console.WriteLine(item);
            }

            c.Choice = false;

            foreach (var item in c)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }

    public class MyClass : IEnumerable
    {
        public string[] Days { get; set; }
        public int[] Numbers { get; set; }
        public bool Choice { get; set; }
        public MyClass()
        {
            Days = new string[] { "Monday", "Tuesday", "Wensday", "Thursday", "Friday", "Saturday", "Sunday" };
            Numbers = new int[] { 0, 1, 2, 3 };
            Choice = true;
        }

        public IEnumerator GetEnumerator()
        {
            if (Choice)
            {
                return Days.GetEnumerator();
            }
            else
            {
                return Numbers.GetEnumerator();
            }          
        }
    }
}
