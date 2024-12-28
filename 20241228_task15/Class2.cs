using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241228_task15
{
    /*
         Создайте интерфейс, содержащий описание методов для нахождения суммы цифр числа и 
        определение количества нулей в записи числа. На основе этого интерфейса создайте классы, 
        содержащие реализацию методов интерфейса в случае целого и действительного чисел.
         */
    public class Class2 : IWorkWithNumbers<double>
    {
        public double Number { get; set; }
        public Class2(double number)
        {
            Number = number;
        }

        public int CountZeros()
        {
            string str = Number.ToString();

            int zeros = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '0')
                {
                    zeros++;
                }
            }
            return zeros;
        }

        public int SumDigits()
        {
            string str = Number.ToString();
            int sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    sum += int.Parse(str[i].ToString());
                }
            }

            return sum;
        }
    }
}
