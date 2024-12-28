using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _20241228_task15
{
    /*
         Создайте интерфейс, содержащий описание методов для нахождения суммы цифр числа и 
        определение количества нулей в записи числа. На основе этого интерфейса создайте классы, 
        содержащие реализацию методов интерфейса в случае целого и действительного чисел.
         */
    public interface IWorkWithNumbers<T>  
    {
        T Number { get; }
        int SumDigits();
        int CountZeros();
    }
}
