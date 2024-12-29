using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241228_task17
{
    /*
     Интерфейс IBorrowable: Должен содержать метод Borrow(), 
        который будет арендовать медиаматериал. Должен содержать метод Return(), 
        который будет возвращать медиаматериал.
     */
    public interface IBorrowable
    {
        void Borrow(Library library);
        void Return(Library library);
    }
}
