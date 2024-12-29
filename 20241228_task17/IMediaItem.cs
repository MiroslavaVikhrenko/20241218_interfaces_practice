using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241228_task17
{
    /*
     Интерфейс IMediaItem: Должен содержать свойства Title (название), 
        Author (автор) и Year (год выпуска). Должен содержать метод DisplayInfo(), 
        который выводит информацию о медиаматериале.
     */
    public interface IMediaItem
    {
        string Title { get; }
        string Author { get; }
        DateTime Year { get; }

        void DisplayInfo();

    }
}
